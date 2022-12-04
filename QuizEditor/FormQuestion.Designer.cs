namespace QuizEditor
{
	partial class FormQuestion
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
			if (disposing && (components != null))
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
			this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
			this.textBoxQuestion = new System.Windows.Forms.TextBox();
			this.labelAnswers = new System.Windows.Forms.Label();
			this.listBoxAnswers = new System.Windows.Forms.ListBox();
			this.buttonOk = new System.Windows.Forms.Button();
			this.buttonAddAnswer = new System.Windows.Forms.Button();
			this.buttonCancel = new System.Windows.Forms.Button();
			this.buttonDeleteAnswer = new System.Windows.Forms.Button();
			this.buttonAddYesNo = new System.Windows.Forms.Button();
			this.tableLayoutPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// tableLayoutPanel
			// 
			this.tableLayoutPanel.ColumnCount = 3;
			this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
			this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
			this.tableLayoutPanel.Controls.Add(this.textBoxQuestion, 0, 0);
			this.tableLayoutPanel.Controls.Add(this.labelAnswers, 0, 2);
			this.tableLayoutPanel.Controls.Add(this.listBoxAnswers, 0, 3);
			this.tableLayoutPanel.Controls.Add(this.buttonOk, 1, 0);
			this.tableLayoutPanel.Controls.Add(this.buttonAddAnswer, 1, 4);
			this.tableLayoutPanel.Controls.Add(this.buttonCancel, 1, 1);
			this.tableLayoutPanel.Controls.Add(this.buttonDeleteAnswer, 1, 5);
			this.tableLayoutPanel.Controls.Add(this.buttonAddYesNo, 1, 3);
			this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel.Name = "tableLayoutPanel";
			this.tableLayoutPanel.RowCount = 6;
			this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
			this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
			this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
			this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel.Size = new System.Drawing.Size(800, 450);
			this.tableLayoutPanel.TabIndex = 0;
			// 
			// textBoxQuestion
			// 
			this.textBoxQuestion.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textBoxQuestion.Location = new System.Drawing.Point(3, 3);
			this.textBoxQuestion.Multiline = true;
			this.textBoxQuestion.Name = "textBoxQuestion";
			this.tableLayoutPanel.SetRowSpan(this.textBoxQuestion, 2);
			this.textBoxQuestion.Size = new System.Drawing.Size(734, 194);
			this.textBoxQuestion.TabIndex = 1;
			// 
			// labelAnswers
			// 
			this.labelAnswers.AutoSize = true;
			this.labelAnswers.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelAnswers.Location = new System.Drawing.Point(3, 200);
			this.labelAnswers.Name = "labelAnswers";
			this.labelAnswers.Size = new System.Drawing.Size(734, 20);
			this.labelAnswers.TabIndex = 2;
			this.labelAnswers.Text = "Answers:";
			// 
			// listBoxAnswers
			// 
			this.listBoxAnswers.Dock = System.Windows.Forms.DockStyle.Fill;
			this.listBoxAnswers.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.listBoxAnswers.FormattingEnabled = true;
			this.listBoxAnswers.ItemHeight = 15;
			this.listBoxAnswers.Location = new System.Drawing.Point(3, 223);
			this.listBoxAnswers.Name = "listBoxAnswers";
			this.tableLayoutPanel.SetRowSpan(this.listBoxAnswers, 3);
			this.listBoxAnswers.Size = new System.Drawing.Size(734, 224);
			this.listBoxAnswers.TabIndex = 3;
			this.listBoxAnswers.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.listBoxAnswers_DrawItem);
			this.listBoxAnswers.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBoxAnswers_MouseDoubleClick);
			// 
			// buttonOk
			// 
			this.tableLayoutPanel.SetColumnSpan(this.buttonOk, 2);
			this.buttonOk.Dock = System.Windows.Forms.DockStyle.Top;
			this.buttonOk.Location = new System.Drawing.Point(743, 3);
			this.buttonOk.Name = "buttonOk";
			this.buttonOk.Size = new System.Drawing.Size(54, 23);
			this.buttonOk.TabIndex = 4;
			this.buttonOk.Text = "Save";
			this.buttonOk.UseVisualStyleBackColor = true;
			this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
			// 
			// buttonAddAnswer
			// 
			this.tableLayoutPanel.SetColumnSpan(this.buttonAddAnswer, 2);
			this.buttonAddAnswer.Dock = System.Windows.Forms.DockStyle.Top;
			this.buttonAddAnswer.Location = new System.Drawing.Point(743, 253);
			this.buttonAddAnswer.Name = "buttonAddAnswer";
			this.buttonAddAnswer.Size = new System.Drawing.Size(54, 23);
			this.buttonAddAnswer.TabIndex = 5;
			this.buttonAddAnswer.Text = "Add";
			this.buttonAddAnswer.UseVisualStyleBackColor = true;
			this.buttonAddAnswer.Click += new System.EventHandler(this.buttonAddAnswer_Click);
			// 
			// buttonCancel
			// 
			this.tableLayoutPanel.SetColumnSpan(this.buttonCancel, 2);
			this.buttonCancel.Location = new System.Drawing.Point(743, 33);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(54, 23);
			this.buttonCancel.TabIndex = 7;
			this.buttonCancel.Text = "Cancel";
			this.buttonCancel.UseVisualStyleBackColor = true;
			this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
			// 
			// buttonDeleteAnswer
			// 
			this.tableLayoutPanel.SetColumnSpan(this.buttonDeleteAnswer, 2);
			this.buttonDeleteAnswer.Location = new System.Drawing.Point(743, 283);
			this.buttonDeleteAnswer.Name = "buttonDeleteAnswer";
			this.buttonDeleteAnswer.Size = new System.Drawing.Size(54, 23);
			this.buttonDeleteAnswer.TabIndex = 8;
			this.buttonDeleteAnswer.Text = "Delete";
			this.buttonDeleteAnswer.UseVisualStyleBackColor = true;
			this.buttonDeleteAnswer.Click += new System.EventHandler(this.buttonDeleteAnswer_Click);
			// 
			// buttonAddYesNo
			// 
			this.tableLayoutPanel.SetColumnSpan(this.buttonAddYesNo, 2);
			this.buttonAddYesNo.Location = new System.Drawing.Point(743, 223);
			this.buttonAddYesNo.Name = "buttonAddYesNo";
			this.buttonAddYesNo.Size = new System.Drawing.Size(54, 23);
			this.buttonAddYesNo.TabIndex = 9;
			this.buttonAddYesNo.Text = "Y/N";
			this.buttonAddYesNo.UseVisualStyleBackColor = true;
			this.buttonAddYesNo.Click += new System.EventHandler(this.buttonAddYesNo_Click);
			// 
			// FormQuestion
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.tableLayoutPanel);
			this.Name = "FormQuestion";
			this.Text = "Question";
			this.tableLayoutPanel.ResumeLayout(false);
			this.tableLayoutPanel.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private TableLayoutPanel tableLayoutPanel;
		private TextBox textBoxQuestion;
		private Label labelAnswers;
		private ListBox listBoxAnswers;
		private Button buttonOk;
		private Button buttonAddAnswer;
		private Button buttonCancel;
		private Button buttonDeleteAnswer;
		private Button buttonAddYesNo;
	}
}