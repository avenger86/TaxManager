namespace TaxManager
{
	partial class UserDialog
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if( disposing && (components != null) )
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this._lblTitle = new System.Windows.Forms.Label();
			this._maskedTextBox = new System.Windows.Forms.MaskedTextBox();
			this.btnOk = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lblTitle
			// 
			this._lblTitle.AutoSize = true;
			this._lblTitle.Location = new System.Drawing.Point(12, 20);
			this._lblTitle.Name = "lblTitle";
			this._lblTitle.Size = new System.Drawing.Size(43, 13);
			this._lblTitle.TabIndex = 0;
			this._lblTitle.Text = "За год:";
			// 
			// maskedTextBox
			// 
			this._maskedTextBox.Location = new System.Drawing.Point(53, 17);
			this._maskedTextBox.Mask = "0000000";
			this._maskedTextBox.Name = "maskedTextBox";
			this._maskedTextBox.PromptChar = ' ';
			this._maskedTextBox.Size = new System.Drawing.Size(87, 20);
			this._maskedTextBox.TabIndex = 1;
			// 
			// btnOk
			// 
			this.btnOk.Location = new System.Drawing.Point(146, 15);
			this.btnOk.Name = "btnOk";
			this.btnOk.Size = new System.Drawing.Size(75, 23);
			this.btnOk.TabIndex = 2;
			this.btnOk.Text = "OK";
			this.btnOk.UseVisualStyleBackColor = true;
			this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
			// 
			// UserDialog
			// 
			this.AcceptButton = this.btnOk;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(226, 52);
			this.Controls.Add(this.btnOk);
			this.Controls.Add(this._maskedTextBox);
			this.Controls.Add(this._lblTitle);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "UserDialog";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "UserDialog";
			this.Shown += new System.EventHandler(this.UserDialog_Shown);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label _lblTitle;
		private System.Windows.Forms.MaskedTextBox _maskedTextBox;
		private System.Windows.Forms.Button btnOk;
	}
}