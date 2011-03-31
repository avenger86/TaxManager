using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TaxManager
{
	public partial class UserDialog : Form
	{
		public UserDialog()
		{

		}
		public UserDialog(String titleText,String labelText, String promptText="Пожалуста введите число!")
		{
			InitializeComponent();
			this.Text = titleText;
			_lblTitle.Text = labelText;
			Prompt = promptText;

		}

		private void btnOk_Click(object sender, EventArgs e)
		{
			if( _maskedTextBox.Text.Length > 0 )
			{
				this.DialogResult = DialogResult.OK;
				this.Close();
			}
			else
			{
				MessageBox.Show(Prompt);
				_maskedTextBox.Focus();
			}

		}

		public int AmountValue
		{
			get { return int.Parse(_maskedTextBox.Text); }
			set { _maskedTextBox.Text = value.ToString(); }
		}

		private String _prompt;

		public String Prompt
		{
			get { return _prompt; }
			set { _prompt = value; }
		}

		private void UserDialog_Shown(object sender, EventArgs e)
		{
			_maskedTextBox.Select(0, _maskedTextBox.Text.Length);
		}

	}
}
