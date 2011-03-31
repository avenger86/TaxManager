using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace TaxManager
{
	public partial class frmTaxMain : Form
	{
		private MyBindingListView _taxList;
		private bool _edited;
		System.Data.DataSet dataSet = new System.Data.DataSet();
		public frmTaxMain()
		{

			InitializeComponent();
			InitTaxList();
		}
		private void InitTaxList()
		{
			_taxList = new MyBindingListView();
			_taxList.RaiseListChangedEvents = true;
			_taxList.AllowNew = true;
			_taxList.AllowEdit = true;
			_taxList.AllowRemove = false;
			dtpMonthYear.Value = DateTime.Today;
			dtpMonthYear.Value = new DateTime(dtpMonthYear.Value.Year, dtpMonthYear.Value.Month, 1);
		}

		private void frmTaxMain_Load(object sender, EventArgs e)
		{
			dataGridView1.DataSource = _taxList;
			_taxList.ListChanged += new ListChangedEventHandler(blTaxList_ListChanged);
			_edited = false;

		}

		void blTaxList_ListChanged(object sender, ListChangedEventArgs e)
		{
			//MessageBox.Show(e.ListChangedType.ToString());
			CalculateData();

		}

		private void btnTst_Click(object sender, EventArgs e)
		{
			//blTaxList.Clear();
			//blTaxList.Add(new TaxData(true, DateTime.Now, (float)(new Random().NextDouble() * 1000)));
			//blTaxList.
			//MessageBox.Show(blTaxList.Count.ToString());
			//blTaxList.Filter = "2010-10-20";
			//blTaxList.FillList(dtpMonthYear.Value, 500000,true);
			StringBuilder sb = new StringBuilder();
			foreach( TaxData item in _taxList.Items )
			{
				sb.AppendFormat("{0}:\t{1}\n",item.Date.ToString("ddd d MMMM yyyy"),item.Amount.ToString());
			}
			//sb.AppendFormat("Итого:\t{0}",_taxList.GetMoneyAmount());
			MessageBox.Show(sb.ToString());
			//System.Diagnostics.Debugger.Break();
			//My name is cat sdfsdf sdsdddddsdsddsdsd
			MessageBox.Show("Test");



		}
		private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
		{
			_edited = true;
			if (e.RowIndex >= 0)
				CalculateData();
		}

		private void dataGridView1_CurrentCellDirtyStateChanged(object sender, EventArgs e)
		{
			//MessageBox.Show("Test");
			dataGridView1.CommitEdit(DataGridViewDataErrorContexts.Commit);
		}
		private void CalculateData()
		{
			float summ = 0;
			foreach (TaxData tdItem in _taxList.AsEnumerable<TaxData>())
			{
				if (tdItem.Active)
					summ += tdItem.Amount;

			}
			tstAmount.Text = summ.ToString();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (_taxList.Save("C:/work/sav.sav") != true)
				MessageBox.Show("Error");
		}

		private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
		{
			int i = 0;
			foreach (DataGridViewRow item in dataGridView1.Rows)
			{
				item.DefaultCellStyle.BackColor = (i++ % 2 == 0) ? Color.FromArgb(0xf3, 0xf3, 0xf9) : Color.FromArgb(0xe6, 0xe6, 0xcc);
			}
		}


		private void dtpMonthYear_ValueChanged(object sender, EventArgs e)
		{
			_taxList.Filter = dtpMonthYear.Value.ToString();
			//tstAmount.Text = _taxList.GetMoneyAmount(dtpMonthYear.Value.Year, dtpMonthYear.Value.Month).ToString();
			tstYearAmount.Text = _taxList.GetMoneyAmount(dtpMonthYear.Value.Year).ToString();
			_edited = false;
		}

		private void generateYearToolStripMenuItem_Click(object sender, EventArgs e)
		{
			UserDialog udForm = new UserDialog("Введите сумму на год", "За год:");
			udForm.AmountValue = int.Parse(tstYearAmount.Text);
			if (udForm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
			{
				/*for( int i = 0; i < 12; i++ )
				{
					blTaxList.FillList(new DateTime(dtpMonthYear.Value.Year, i + 1, 1),
											udForm.AmountValue/12, true);
					
				}
				*/
				_taxList.FillYearList(dtpMonthYear.Value.Year, udForm.AmountValue, true);
				_taxList.ApplayFilter();
				tstYearAmount.Text = _taxList.GetMoneyAmount(dtpMonthYear.Value.Year).ToString();
				_edited = false;
			}
		}

		private void generateMonthToolStripMenuItem_Click(object sender, EventArgs e)
		{
			_taxList.FillList(dtpMonthYear.Value, int.Parse(tstAmount.Text), true);
			_taxList.ApplayFilter();
			tstYearAmount.Text = _taxList.GetMoneyAmount(dtpMonthYear.Value.Year).ToString();
			_edited = false;
		}

		private void updateToolStripMenuItem_Click(object sender, EventArgs e)
		{
			int amount = _taxList.GetMoneyAmount(dtpMonthYear.Value.Year, dtpMonthYear.Value.Month);
			_taxList.FillList(dtpMonthYear.Value, amount, false);
			_taxList.ApplayFilter();
			tstYearAmount.Text = _taxList.GetMoneyAmount(dtpMonthYear.Value.Year).ToString();
			_edited = false;
		}

		private void editToolStripMenuItem_DropDownOpening(object sender, EventArgs e)
		{
			updateToolStripMenuItem.Enabled = _edited;
			if (_taxList.GetMoneyAmount(dtpMonthYear.Value.Year, dtpMonthYear.Value.Month) > 0)
				generateMonthToolStripMenuItem.Enabled = true;
			else
				generateMonthToolStripMenuItem.Enabled = false;
		}

		private void tstAmount_DoubleClick(object sender, EventArgs e)
		{
			UserDialog udForm = new UserDialog("Введите сумму на месяц", "За месяц:");
			udForm.AmountValue = int.Parse(tstAmount.Text);
			if (udForm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
			{
				_taxList.FillList(dtpMonthYear.Value, udForm.AmountValue,
										false);
				_taxList.ApplayFilter();
				_edited = false;
			}
		}

		private void tstYearAmount_DoubleClick(object sender, EventArgs e)
		{
			UserDialog udForm		= new UserDialog("Введите сумму на год", "За год:");
			udForm.AmountValue		= int.Parse(tstYearAmount.Text);

			if (udForm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
			{
				_taxList.FillYearList(dtpMonthYear.Value.Year, udForm.AmountValue, false);
				_taxList.ApplayFilter();
				_edited = false;

			}
		}

		private void loadToolStripMenuItem_Click(object sender, EventArgs e)
		{
			OpenFileDialog fileDialog	= new OpenFileDialog();
			fileDialog.CheckFileExists	= true;
			fileDialog.DefaultExt		= "sav";
			fileDialog.FileName			= "TaxData.sav";
			fileDialog.Filter			= "TaxData(*.sav)|*.sav";
			fileDialog.InitialDirectory	= Application.CommonAppDataPath;
			fileDialog.Multiselect		= false;

			if (fileDialog.ShowDialog() == DialogResult.OK)
			{
				if (_taxList.Load(fileDialog.FileName) != 1)
					MessageBox.Show("Error");
			}

			tstYearAmount.Text = _taxList.GetMoneyAmount(dtpMonthYear.Value.Year).ToString();
		}

		private void fileToolStripMenuItem_DropDownOpening(object sender, EventArgs e)
		{
				saveToolStripMenuItem.Enabled = !_taxList.Empty;
		}

		private void saveToolStripMenuItem_Click(object sender, EventArgs e)
		{
			SaveFileDialog fileDialog	= new SaveFileDialog();
			fileDialog.AddExtension		= true;
			fileDialog.OverwritePrompt	= true;
			fileDialog.DefaultExt		= "sav";
			fileDialog.FileName			= "TaxData.sav";
			fileDialog.Filter			= "TaxData(*.sav)|*.sav";
			fileDialog.InitialDirectory = Application.CommonAppDataPath;

			if (fileDialog.ShowDialog() == DialogResult.OK)
			{
				if (_taxList.Save(fileDialog.FileName) != true)
					MessageBox.Show("Error");
			}
						
		}

		private void exportToolStripMenuItem_Click(object sender, EventArgs e)
		{
			SaveFileDialog fileDialog = new SaveFileDialog();
			fileDialog.AddExtension = true;
			fileDialog.OverwritePrompt = true;
			fileDialog.DefaultExt = "txt";
			//fileDialog.FileName = "TaxData.sav";
			fileDialog.Filter = "Text file(*.txt)|*.txt";
			//fileDialog.InitialDirectory = Application.CommonAppDataPath;

			if( fileDialog.ShowDialog() == DialogResult.OK )
			{
				if( _taxList.Export(fileDialog.FileName,dtpMonthYear.Value.Year,dtpMonthYear.Value.Month) != true )
					MessageBox.Show("Error");
			}
		}




		/*		private void button2_Click(object sender, EventArgs e)
				{
					System.Data.DataTable table = new DataTable("ParentTable");
					// Declare variables for DataColumn and DataRow objects.
					DataColumn column;
					DataRow row;

					// Create new DataColumn, set DataType, 
					// ColumnName and add to DataTable.    
					column = new DataColumn();
					column.DataType = System.Type.GetType("System.Int32");
					column.ColumnName = "id";
					column.ReadOnly = true;
					column.Unique = true;
					// Add the Column to the DataColumnCollection.
					table.Columns.Add(column);

					// Create second column.
					column = new DataColumn();
					column.DataType = System.Type.GetType("System.Boolean");
					column.ColumnName = "Check";
					column.AutoIncrement = false;
					column.Caption = "Check";
					column.ReadOnly = false;
					column.Unique = false;
					// Add the column to the table.
					table.Columns.Add(column);

					// Create second column.
					column = new DataColumn();
					column.DataType = System.Type.GetType("System.String");
					column.ColumnName = "ParentItem";
					column.AutoIncrement = false;
					column.Caption = "ParentItem";
					column.ReadOnly = false;
					column.Unique = false;
					// Add the column to the table.
					table.Columns.Add(column);

					// Make the ID column the primary key column.
					DataColumn[] PrimaryKeyColumns = new DataColumn[1];
					PrimaryKeyColumns[0] = table.Columns["id"];
					table.PrimaryKey = PrimaryKeyColumns;

					// Instantiate the DataSet variable.
					//dataSet = new DataSet();
					// Add the new DataTable to the DataSet.
					dataSet1.Tables.Add(table);

					// Create three new DataRow objects and add 
					// them to the DataTable
					for( int i = 0; i <= 5; i++ )
					{
						row = table.NewRow();
						row["id"] = i;
						row["ParentItem"] = "ParentItem " + i;
						row["Check"] = true;
						table.Rows.Add(row);
					}
					dataGridView1.DataSource = dataSet1;
					dataGridView1.DataMember = "ParentTable";
				}*/

	}

}
