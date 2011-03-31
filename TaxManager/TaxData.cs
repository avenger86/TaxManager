using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TaxManager
{

	class TaxData
	{
		public TaxData(bool check, DateTime date, int value)
		{
			_checked = check;
			_date = date;
			_moneyValue = value;

		}
		private bool _checked;
		private DateTime _date;
		private int _moneyValue;

		public bool Active
		{
			get { return _checked; }
			set { _checked = value; }
		}

		public DateTime Date
		{
			get { return _date; ; }
			set { _date = value; }
		}


		public int Amount
		{
			get { return _moneyValue; }
			set { _moneyValue = value; }
		}
		
		
	}
}
