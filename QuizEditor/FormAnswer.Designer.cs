namespace QuizEditor
{
	partial class FormAnswer
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
			this.textBoxAnswer = new System.Windows.Forms.TextBox();
			this.buttonCorrect = new System.Windows.Forms.Button();
			this.buttonBulk = new System.Windows.Forms.Button();
			this.buttonWrong = new System.Windows.Forms.Button();
			this.tableLayoutPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// tableLayoutPanel
			// 
			this.tableLayoutPanel.ColumnCount = 4;
			this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel.Controls.Add(this.textBoxAnswer, 0, 0);
			this.tableLayoutPanel.Controls.Add(this.buttonCorrect, 3, 1);
			this.tableLayoutPanel.Controls.Add(this.buttonBulk, 0, 1);
			this.tableLayoutPanel.Controls.Add(this.buttonWrong, 2, 1);
			this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel.Name = "tableLayoutPanel";
			this.tableLayoutPanel.RowCount = 2;
			this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
			this.tableLayoutPanel.Size = new System.Drawing.Size(800, 450);
			this.tableLayoutPanel.TabIndex = 0;
			// 
			// textBoxAnswer
			// 
			this.tableLayoutPanel.SetColumnSpan(this.textBoxAnswer, 4);
			this.textBoxAnswer.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textBoxAnswer.Location = new System.Drawing.Point(3, 3);
			this.textBoxAnswer.Multiline = true;
			this.textBoxAnswer.Name = "textBoxAnswer";
			this.textBoxAnswer.Size = new System.Drawing.Size(794, 414);
			this.textBoxAnswer.TabIndex = 1;
			// 
			// buttonCorrect
			// 
			this.buttonCorrect.Dock = System.Windows.Forms.DockStyle.Fill;
			this.buttonCorrect.Location = new System.Drawing.Point(603, 423);
			this.buttonCorrect.Name = "buttonCorrect";
			this.buttonCorrect.Size = new System.Drawing.Size(194, 24);
			this.buttonCorrect.TabIndex = 3;
			this.buttonCorrect.Text = "Correct";
			this.buttonCorrect.UseVisualStyleBackColor = true;
			this.buttonCorrect.Click += new System.EventHandler(this.buttonCorrect_Click);
			// 
			// buttonBulk
			// 
			this.buttonBulk.Dock = System.Windows.Forms.DockStyle.Fill;
			this.buttonBulk.Location = new System.Drawing.Point(3, 423);
			this.buttonBulk.Name = "buttonBulk";
			this.buttonBulk.Size = new System.Drawing.Size(194, 24);
			this.buttonBulk.TabIndex = 4;
			this.buttonBulk.Text = "BULK";
			this.buttonBulk.UseVisualStyleBackColor = true;
			this.buttonBulk.Click += new System.EventHandler(this.buttonBulk_Click);
			// 
			// buttonWrong
			// 
			this.buttonWrong.Dock = System.Windows.Forms.DockStyle.Fill;
			this.buttonWrong.Location = new System.Drawing.Point(403, 423);
			this.buttonWrong.Name = "buttonWrong";
			this.buttonWrong.Size = new System.Drawing.Size(194, 24);
			this.buttonWrong.TabIndex = 5;
			this.buttonWrong.Text = "Wrong";
			this.buttonWrong.UseVisualStyleBackColor = true;
			this.buttonWrong.Click += new System.EventHandler(this.buttonWrong_Click);
			// 
			// FormAnswer
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.tableLayoutPanel);
			this.Name = "FormAnswer";
			this.Text = "Answer";
			this.tableLayoutPanel.ResumeLayout(false);
			this.tableLayoutPanel.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private TableLayoutPanel tableLayoutPanel;
		private TextBox textBoxAnswer;
		private Button buttonCorrect;
		private Button buttonBulk;
		private Button buttonWrong;
	}
}