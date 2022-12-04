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
			this.labelAnswerText = new System.Windows.Forms.Label();
			this.textBoxAnswer = new System.Windows.Forms.TextBox();
			this.checkBoxCorrectAnswer = new System.Windows.Forms.CheckBox();
			this.buttonOk = new System.Windows.Forms.Button();
			this.tableLayoutPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// tableLayoutPanel
			// 
			this.tableLayoutPanel.ColumnCount = 1;
			this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel.Controls.Add(this.labelAnswerText, 0, 0);
			this.tableLayoutPanel.Controls.Add(this.textBoxAnswer, 0, 1);
			this.tableLayoutPanel.Controls.Add(this.checkBoxCorrectAnswer, 0, 2);
			this.tableLayoutPanel.Controls.Add(this.buttonOk, 0, 3);
			this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel.Name = "tableLayoutPanel";
			this.tableLayoutPanel.RowCount = 4;
			this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
			this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
			this.tableLayoutPanel.Size = new System.Drawing.Size(800, 450);
			this.tableLayoutPanel.TabIndex = 0;
			// 
			// labelAnswerText
			// 
			this.labelAnswerText.AutoSize = true;
			this.labelAnswerText.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelAnswerText.Location = new System.Drawing.Point(3, 0);
			this.labelAnswerText.Name = "labelAnswerText";
			this.labelAnswerText.Size = new System.Drawing.Size(794, 20);
			this.labelAnswerText.TabIndex = 0;
			this.labelAnswerText.Text = "Answer text";
			// 
			// textBoxAnswer
			// 
			this.textBoxAnswer.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textBoxAnswer.Location = new System.Drawing.Point(3, 23);
			this.textBoxAnswer.Multiline = true;
			this.textBoxAnswer.Name = "textBoxAnswer";
			this.textBoxAnswer.Size = new System.Drawing.Size(794, 364);
			this.textBoxAnswer.TabIndex = 1;
			// 
			// checkBoxCorrectAnswer
			// 
			this.checkBoxCorrectAnswer.AutoSize = true;
			this.checkBoxCorrectAnswer.Location = new System.Drawing.Point(3, 393);
			this.checkBoxCorrectAnswer.Name = "checkBoxCorrectAnswer";
			this.checkBoxCorrectAnswer.Size = new System.Drawing.Size(114, 19);
			this.checkBoxCorrectAnswer.TabIndex = 2;
			this.checkBoxCorrectAnswer.Text = "Is correct answer";
			this.checkBoxCorrectAnswer.UseVisualStyleBackColor = true;
			// 
			// buttonOk
			// 
			this.buttonOk.Dock = System.Windows.Forms.DockStyle.Right;
			this.buttonOk.Location = new System.Drawing.Point(722, 423);
			this.buttonOk.Name = "buttonOk";
			this.buttonOk.Size = new System.Drawing.Size(75, 24);
			this.buttonOk.TabIndex = 3;
			this.buttonOk.Text = "OK";
			this.buttonOk.UseVisualStyleBackColor = true;
			this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
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
		private Label labelAnswerText;
		private TextBox textBoxAnswer;
		private CheckBox checkBoxCorrectAnswer;
		private Button buttonOk;
	}
}