using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TaxManager
{
	class TaxMetaData
	{
		private List<int> _iExDays;

		public List<int> ExcludedDays
		{
			get { return _iExDays; }
			set { _iExDays = value; }
		}
		public TaxMetaData(int year, int month, int taxAmount)
		{
			TaxAmount = taxAmount;
			Month = month;
			Year = year;
			DaysInMonth = DateTime.DaysInMonth(Year, Month);
			_iExDays = new List<int>();
			int iFirstDay = (int)new DateTime(Year, Month, 1).DayOfWeek;
			if (iFirstDay == 0)
				iFirstDay = 7;
			int iFirstWeekend = 8 - iFirstDay;
			for (int i = iFirstWeekend; i < DaysInMonth; i += 7)
			{
				_iExDays.Add(i);
			}
		}
		public TaxMetaData(int year, int month)
		{
			TaxAmount = 0;
			Month = month;
			Year = year;
			DaysInMonth = DateTime.DaysInMonth(Year, Month);
			_iExDays = new List<int>();

			for (int i = 0; i < DaysInMonth; i++)
			{
				_iExDays.Add(i + 1);
			}
		}

		private int _iDaysInMonth;

		public int DaysInMonth
		{
			get { return _iDaysInMonth; }
			private set { _iDaysInMonth = value; }
		}

		public int WorkDays
		{
			get { return DaysInMonth - _iExDays.Count; }
		}

		private int _TaxAmount;

		public int TaxAmount
		{
			get { return _TaxAmount; }
			set { _TaxAmount = value; }
		}
		private int _iYear;

		public int Year
		{
			get { return _iYear; }
			private set { _iYear = value; }
		}
		private int _iMonth;

		public int Month
		{
			get { return _iMonth; }
			private set { _iMonth = value; }
		}


		public List<int> AmountList
		{
			get { return MakeAmountList(WorkDays, TaxAmount); }
		}

		private List<int> MakeAmountList(int numberOfDays, int moneyAmount)
		{
			int iAvarage = TaxAmount / WorkDays;
			List<int> lList = new List<int>(WorkDays);
			int iTempAmount = TaxAmount;
			int dTemp = 0;
			Random rGen = new Random(new Random(DateTime.Now.Millisecond).Next());
			for (int i = 0; i < WorkDays - 1; i++)
			{
				dTemp = rGen.Next((iAvarage - iAvarage / 10) / 10, (iAvarage + iAvarage / 10) / 10);
				dTemp *= 10;
				lList.Add(dTemp);
				iTempAmount -= dTemp;
			}
			lList.Add(iTempAmount);
			return lList;
		}


	}
}
