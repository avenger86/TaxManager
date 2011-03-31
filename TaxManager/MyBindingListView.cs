using System;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
namespace TaxManager
{
	class MyBindingListView : BindingList<TaxData>, IBindingListView, IList<TaxData>, ICollection<TaxData>, IBindingList, System.Collections.IList
	{
		private string _strFilter;
		private bool _bFiltered;
		private List<TaxData> _ltdFull;
		private List<TaxMetaData> _ltmdInfo;
		public MyBindingListView()
		{
			_ltdFull = new List<TaxData>();
			_ltmdInfo = new List<TaxMetaData>();
		}
		public void ApplySort(ListSortDescriptionCollection sorts)
		{
			throw new NotImplementedException();
		}
		public string Filter
		{
			get
			{
				return _strFilter;
			}
			set
			{
				_strFilter = value;
				if (_strFilter.Length == 0)
					_bFiltered = false;
				else
					_bFiltered = true;
				ApplayFilter();
			}
		}

		public void RemoveFilter()
		{
			Filter = "";

		}

		public ListSortDescriptionCollection SortDescriptions
		{
			get { throw new NotImplementedException(); }
		}

		public bool SupportsAdvancedSorting
		{
			get { throw new NotImplementedException(); }
		}

		public bool SupportsFiltering
		{
			get { return true; }
		}
		public IList<TaxData> Items
		{
		    get { return base.Items; }
		}
		private bool CheckItem(TaxData item)
		{
			DateTime dtTempDate;
			if (DateTime.TryParse(_strFilter, out dtTempDate))
				if (dtTempDate.Date.Year == item.Date.Date.Year && dtTempDate.Date.Month == item.Date.Date.Month)
					return true;
			return false;

		}

		public void ApplayFilter()
		{
			bool b = true;
			if (_bFiltered)
			{
				this.Items.Clear();
				foreach (TaxData item in _ltdFull)
				{
					if (CheckItem(item))
						this.Items.Add(item);
					b = !b;
				}
			}
			else
			{
				this.Items.Clear();
				foreach (TaxData item in _ltdFull)
				{
					this.Items.Add(item);
				}
			}
			this.ResetBindings();
		}
		protected override void InsertItem(int index, TaxData item)
		{
			_ltdFull.Add(item);
			base.InsertItem(index, item);
		}

		public void FillList(DateTime date, int moneyAmount, bool isNew)
		{
			TaxMetaData tmdCurrent;
			if (!isNew)
			{
				tmdCurrent = _ltmdInfo.Find(delegate(TaxMetaData item)
				{
					return item.Month == date.Month && item.Year == date.Year;
				});
				foreach (TaxData item in this.Items)
				{
					if (!item.Active)
						tmdCurrent.ExcludedDays.Add(item.Date.Day);
				}
				tmdCurrent.TaxAmount = moneyAmount;
			}
			else
				tmdCurrent = new TaxMetaData(date.Year, date.Month, moneyAmount);

			RemoveMonth(date.Year, date.Month, isNew);
			_ltmdInfo.Add(tmdCurrent);
			List<int> lValues = tmdCurrent.AmountList;
			for (int i = 0, j = 0; i < tmdCurrent.DaysInMonth; i++, date += TimeSpan.FromDays(1))
			{
				if (!tmdCurrent.ExcludedDays.Contains(i + 1))
					this.Add(new TaxData(true, date, lValues[j++]));
			}
			this.ResetBindings();
		}
		/*		protected override void RemoveItem(int index)
				{
					m_ltdFull.RemoveAt(index);dddsdsdsdsd
					this.Items.RemoveAt(index);
					this.ResetBindings();
				}*/
		public void RemoveMonth(int year, int month, bool isNew)
		{
			Predicate<TaxData> pTaxData = (item) =>
			{
				if (item.Date.Month == month && item.Date.Year == year)
					return true;
				return false;
			};
			Predicate<TaxMetaData> pTaxMetaData = (item) =>
			{
				if (item.Month == month && item.Year == year)
					return true;
				return false;
			};
			int index;
			while ((index = _ltdFull.FindIndex(pTaxData)) != -1)
			{
				_ltdFull.RemoveAt(index);
			}
			if (true)
				while ((index = _ltmdInfo.FindIndex(pTaxMetaData)) != -1)
				{
					_ltmdInfo.RemoveAt(index);
				}
		}
		public int GetMoneyAmount(int year, int month)
		{
			TaxMetaData tmdTemp;
			tmdTemp = _ltmdInfo.Find(delegate(TaxMetaData item) { return item.Month == month && item.Year == year; });
			if (tmdTemp == null)
				return 0;
			return tmdTemp.TaxAmount;
		}

		public int GetMoneyAmount(int year)
		{
			int totalAmount = 0;
			Predicate<TaxMetaData> pTaxMetaData = (item) => { return item.Year == year; };
			foreach (TaxMetaData item in _ltmdInfo.FindAll(pTaxMetaData))
			{
				totalAmount += item.TaxAmount;
			}
			return totalAmount;
		}
		public void FillYearList(int year, int moneyAmount, bool isNew)
		{
			int avarage = moneyAmount / 12;
			int lastAmount = moneyAmount;
			int temp = 0;
			Random rGen = new Random(new Random(DateTime.Now.Millisecond).Next());
			for (int i = 0; i < 11; i++)
			{
				temp = rGen.Next((avarage - avarage / 10) / 10, (avarage + avarage / 10) / 10);
				temp *= 10;
				lastAmount -= temp;
				FillList(new DateTime(year, i + 1, 1), temp, isNew);
			}
			FillList(new DateTime(year, 12, 1), lastAmount, isNew);
		}

		public bool Save(String fileName)
		{
			if (_ltdFull.Count > 0)
			{
				FileStream fileStream	= new FileStream(fileName, FileMode.OpenOrCreate);
				BinaryWriter bwFile		= new BinaryWriter(fileStream);

				fileStream.SetLength(0);
				fileStream.Flush();
				bwFile.Write(_ltdFull.Count);
				foreach (TaxData item in _ltdFull)
				{
					bwFile.Write(item.Active);
					bwFile.Write(item.Date.ToBinary());
					bwFile.Write(item.Amount);
				}

				bwFile.Flush();
				bwFile.Close();
				fileStream.Close();
				return true;
			}
			return false;
		}
		public int Load(String saveFileName)
		{
			int structSize			= (sizeof(Int32) + sizeof(bool) + sizeof(long));
			FileStream fileStream	= new FileStream(saveFileName, FileMode.OpenOrCreate);
			BinaryReader brFile		= new BinaryReader(fileStream);

			fileStream.Seek(0, SeekOrigin.Begin);
			int structsCount = brFile.ReadInt32();

			if (structsCount == (brFile.BaseStream.Length - 1) / structSize)
			{
				_ltdFull.Clear();
				_ltmdInfo.Clear();

				for (int i = 0; i < structsCount; i++)
				{
					TaxData tempTaxData = new TaxData(brFile.ReadBoolean(), new DateTime(brFile.ReadInt64()), brFile.ReadInt32());
					TaxMetaData tempTaxMetaData;

					_ltdFull.Add(tempTaxData);
					tempTaxMetaData = _ltmdInfo.Find((item) =>
					{
						return item.Month == tempTaxData.Date.Month && item.Year == tempTaxData.Date.Year;
					});

					if (tempTaxMetaData == null)
					{
						tempTaxMetaData = new TaxMetaData(tempTaxData.Date.Year, tempTaxData.Date.Month);
						_ltmdInfo.Add(tempTaxMetaData);
					}
					tempTaxMetaData.ExcludedDays.Remove(tempTaxData.Date.Day);
					tempTaxMetaData.TaxAmount += tempTaxData.Amount;
				}

				this.ApplayFilter();
				brFile.Close();
				fileStream.Close();
				return 1;
			}

			brFile.Close();
			fileStream.Close();
			return 0;
		}

		public bool Empty 
		{
			get { return _ltdFull.Count == 0; }
		}

		public bool Export(string fileName,int year,int month)
		{
			if( Items.Count > 0 )
			{
				FileStream fileStream = new FileStream(fileName, FileMode.OpenOrCreate);
				BinaryWriter bwFile = new BinaryWriter(fileStream);
				
				fileStream.SetLength(0);
				fileStream.Flush();
				StringBuilder sb = new StringBuilder();
				foreach( TaxData item in this.Items )
				{
					sb.AppendFormat("{0}:\t{1}\r\n", item.Date.ToString("ddd d MMMM yyyy"), item.Amount.ToString());
				}
				sb.AppendFormat("Итого:\t{0}", GetMoneyAmount(year, month));
				System.Text.UTF8Encoding s = new UTF8Encoding();

				
				bwFile.Write(System.Text.Encoding.GetEncoding(1251).GetBytes(sb.ToString()));
				bwFile.Flush();
				bwFile.Close();
				fileStream.Close();
				return true;
			}
			return false;
		}
	}
}
