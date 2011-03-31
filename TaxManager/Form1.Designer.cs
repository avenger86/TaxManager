namespace TaxManager
{
	partial class frmTaxMain
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.dgvChkBox = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.dgvDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dgvAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btnTst = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.generateMonthToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.generateYearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.dtpMonthYear = new System.Windows.Forms.DateTimePicker();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
			this.tstAmount = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
			this.tstYearAmount = new System.Windows.Forms.ToolStripStatusLabel();
			this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.menuStrip1.SuspendLayout();
			this.statusStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.AllowUserToResizeColumns = false;
			this.dataGridView1.AllowUserToResizeRows = false;
			this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
			dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle16;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvChkBox,
            this.dgvDate,
            this.dgvAmount});
			this.dataGridView1.Location = new System.Drawing.Point(0, 27);
			this.dataGridView1.MultiSelect = false;
			this.dataGridView1.Name = "dataGridView1";
			dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle20.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			dataGridViewCellStyle20.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle20.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle20;
			this.dataGridView1.RowHeadersVisible = false;
			this.dataGridView1.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
			this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.dataGridView1.ShowEditingIcon = false;
			this.dataGridView1.Size = new System.Drawing.Size(323, 422);
			this.dataGridView1.TabIndex = 1;
			this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
			this.dataGridView1.CurrentCellDirtyStateChanged += new System.EventHandler(this.dataGridView1_CurrentCellDirtyStateChanged);
			this.dataGridView1.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridView1_DataBindingComplete);
			// 
			// dgvChkBox
			// 
			this.dgvChkBox.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
			this.dgvChkBox.DataPropertyName = "Active";
			dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle17.NullValue = "False";
			this.dgvChkBox.DefaultCellStyle = dataGridViewCellStyle17;
			this.dgvChkBox.HeaderText = "#";
			this.dgvChkBox.MinimumWidth = 25;
			this.dgvChkBox.Name = "dgvChkBox";
			this.dgvChkBox.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvChkBox.Width = 25;
			// 
			// dgvDate
			// 
			this.dgvDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
			this.dgvDate.DataPropertyName = "Date";
			dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
			dataGridViewCellStyle18.Format = "ddd d MMMM yyyy";
			dataGridViewCellStyle18.NullValue = null;
			this.dgvDate.DefaultCellStyle = dataGridViewCellStyle18;
			this.dgvDate.HeaderText = "Дата";
			this.dgvDate.Name = "dgvDate";
			this.dgvDate.ReadOnly = true;
			this.dgvDate.Width = 150;
			// 
			// dgvAmount
			// 
			this.dgvAmount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.dgvAmount.DataPropertyName = "Amount";
			dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle19.Format = "C2";
			dataGridViewCellStyle19.NullValue = "0";
			this.dgvAmount.DefaultCellStyle = dataGridViewCellStyle19;
			this.dgvAmount.HeaderText = "Сумма";
			this.dgvAmount.Name = "dgvAmount";
			this.dgvAmount.ReadOnly = true;
			this.dgvAmount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			// 
			// btnTst
			// 
			this.btnTst.Location = new System.Drawing.Point(352, 48);
			this.btnTst.Name = "btnTst";
			this.btnTst.Size = new System.Drawing.Size(75, 23);
			this.btnTst.TabIndex = 3;
			this.btnTst.Text = "button2";
			this.btnTst.UseVisualStyleBackColor = true;
			this.btnTst.Click += new System.EventHandler(this.btnTst_Click);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(352, 77);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 6;
			this.button1.Text = "button1";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// menuStrip1
			// 
			this.menuStrip1.AutoSize = false;
			this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(-4, -1);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(465, 25);
			this.menuStrip1.TabIndex = 7;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.exportToolStripMenuItem,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(35, 21);
			this.fileToolStripMenuItem.Text = "File";
			this.fileToolStripMenuItem.DropDownOpening += new System.EventHandler(this.fileToolStripMenuItem_DropDownOpening);
			// 
			// loadToolStripMenuItem
			// 
			this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
			this.loadToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
			this.loadToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
			this.loadToolStripMenuItem.Text = "Load...";
			this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
			// 
			// saveToolStripMenuItem
			// 
			this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
			this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
			this.saveToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
			this.saveToolStripMenuItem.Text = "Save...";
			this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(144, 6);
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
			this.exitToolStripMenuItem.Text = "Exit";
			// 
			// editToolStripMenuItem
			// 
			this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generateMonthToolStripMenuItem,
            this.generateYearToolStripMenuItem,
            this.toolStripSeparator1,
            this.updateToolStripMenuItem});
			this.editToolStripMenuItem.Name = "editToolStripMenuItem";
			this.editToolStripMenuItem.Size = new System.Drawing.Size(37, 21);
			this.editToolStripMenuItem.Text = "Edit";
			this.editToolStripMenuItem.DropDownOpening += new System.EventHandler(this.editToolStripMenuItem_DropDownOpening);
			// 
			// generateMonthToolStripMenuItem
			// 
			this.generateMonthToolStripMenuItem.Name = "generateMonthToolStripMenuItem";
			this.generateMonthToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
			this.generateMonthToolStripMenuItem.Text = "Генерировать на месяц";
			this.generateMonthToolStripMenuItem.Click += new System.EventHandler(this.generateMonthToolStripMenuItem_Click);
			// 
			// generateYearToolStripMenuItem
			// 
			this.generateYearToolStripMenuItem.Name = "generateYearToolStripMenuItem";
			this.generateYearToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
			this.generateYearToolStripMenuItem.Text = "Генерировать на год";
			this.generateYearToolStripMenuItem.Click += new System.EventHandler(this.generateYearToolStripMenuItem_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(201, 6);
			// 
			// updateToolStripMenuItem
			// 
			this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
			this.updateToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F2;
			this.updateToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
			this.updateToolStripMenuItem.Text = "Обновить";
			this.updateToolStripMenuItem.Click += new System.EventHandler(this.updateToolStripMenuItem_Click);
			// 
			// helpToolStripMenuItem
			// 
			this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
			this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
			this.helpToolStripMenuItem.Size = new System.Drawing.Size(40, 21);
			this.helpToolStripMenuItem.Text = "Help";
			// 
			// aboutToolStripMenuItem
			// 
			this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
			this.aboutToolStripMenuItem.ShortcutKeyDisplayString = "";
			this.aboutToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
			this.aboutToolStripMenuItem.Text = "About";
			// 
			// dtpMonthYear
			// 
			this.dtpMonthYear.CustomFormat = "MMMM yyyy";
			this.dtpMonthYear.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpMonthYear.Location = new System.Drawing.Point(200, 2);
			this.dtpMonthYear.Name = "dtpMonthYear";
			this.dtpMonthYear.ShowUpDown = true;
			this.dtpMonthYear.Size = new System.Drawing.Size(123, 20);
			this.dtpMonthYear.TabIndex = 8;
			this.dtpMonthYear.Value = new System.DateTime(2011, 2, 28, 14, 39, 56, 0);
			this.dtpMonthYear.ValueChanged += new System.EventHandler(this.dtpMonthYear_ValueChanged);
			// 
			// statusStrip1
			// 
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.tstAmount,
            this.toolStripStatusLabel2,
            this.tstYearAmount});
			this.statusStrip1.Location = new System.Drawing.Point(0, 452);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(324, 22);
			this.statusStrip1.SizingGrip = false;
			this.statusStrip1.TabIndex = 9;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// toolStripStatusLabel1
			// 
			this.toolStripStatusLabel1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
			this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
			this.toolStripStatusLabel1.Size = new System.Drawing.Size(102, 17);
			this.toolStripStatusLabel1.Text = "Сумма за месяц:";
			// 
			// tstAmount
			// 
			this.tstAmount.AutoSize = false;
			this.tstAmount.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
			this.tstAmount.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.tstAmount.DoubleClickEnabled = true;
			this.tstAmount.Name = "tstAmount";
			this.tstAmount.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
			this.tstAmount.Size = new System.Drawing.Size(60, 17);
			this.tstAmount.Text = "0";
			this.tstAmount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.tstAmount.DoubleClick += new System.EventHandler(this.tstAmount_DoubleClick);
			// 
			// toolStripStatusLabel2
			// 
			this.toolStripStatusLabel2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.toolStripStatusLabel2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
			this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
			this.toolStripStatusLabel2.Size = new System.Drawing.Size(91, 17);
			this.toolStripStatusLabel2.Text = "Сумма за год: ";
			// 
			// tstYearAmount
			// 
			this.tstYearAmount.AutoSize = false;
			this.tstYearAmount.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
			this.tstYearAmount.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.tstYearAmount.DoubleClickEnabled = true;
			this.tstYearAmount.Name = "tstYearAmount";
			this.tstYearAmount.Size = new System.Drawing.Size(70, 17);
			this.tstYearAmount.Text = "0";
			this.tstYearAmount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.tstYearAmount.DoubleClick += new System.EventHandler(this.tstYearAmount_DoubleClick);
			// 
			// exportToolStripMenuItem
			// 
			this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
			this.exportToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
			this.exportToolStripMenuItem.Text = "Export";
			this.exportToolStripMenuItem.Click += new System.EventHandler(this.exportToolStripMenuItem_Click);
			// 
			// frmTaxMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(324, 474);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.dtpMonthYear);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.btnTst);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.menuStrip1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MainMenuStrip = this.menuStrip1;
			this.MaximizeBox = false;
			this.Name = "frmTaxMain";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "TaxManager";
			this.Load += new System.EventHandler(this.frmTaxMain_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button btnTst;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem generateMonthToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
		private System.Windows.Forms.DateTimePicker dtpMonthYear;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
		private System.Windows.Forms.ToolStripStatusLabel tstAmount;
		private System.Windows.Forms.ToolStripMenuItem generateYearToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.DataGridViewCheckBoxColumn dgvChkBox;
		private System.Windows.Forms.DataGridViewTextBoxColumn dgvDate;
		private System.Windows.Forms.DataGridViewTextBoxColumn dgvAmount;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
		private System.Windows.Forms.ToolStripStatusLabel tstYearAmount;
		private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
	}
}

