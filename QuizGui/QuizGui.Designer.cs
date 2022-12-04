namespace QuizGui
{
	partial class QuizGui
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.checkBoxA = new System.Windows.Forms.CheckBox();
			this.checkBoxB = new System.Windows.Forms.CheckBox();
			this.checkBoxC = new System.Windows.Forms.CheckBox();
			this.checkBoxD = new System.Windows.Forms.CheckBox();
			this.textBoxQuestion = new System.Windows.Forms.TextBox();
			this.checkBoxE = new System.Windows.Forms.CheckBox();
			this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
			this.groupBoxAnswers = new System.Windows.Forms.GroupBox();
			this.groupBoxQuestion = new System.Windows.Forms.GroupBox();
			this.groupBoxTest = new System.Windows.Forms.GroupBox();
			this.buttonPrevious = new System.Windows.Forms.Button();
			this.checkBoxCheat = new System.Windows.Forms.CheckBox();
			this.labelPercent = new System.Windows.Forms.Label();
			this.labelScored = new System.Windows.Forms.Label();
			this.buttonNext = new System.Windows.Forms.Button();
			this.tableLayoutPanel.SuspendLayout();
			this.groupBoxAnswers.SuspendLayout();
			this.groupBoxQuestion.SuspendLayout();
			this.groupBoxTest.SuspendLayout();
			this.SuspendLayout();
			// 
			// checkBoxA
			// 
			this.checkBoxA.AutoSize = true;
			this.checkBoxA.Location = new System.Drawing.Point(14, 25);
			this.checkBoxA.Name = "checkBoxA";
			this.checkBoxA.Size = new System.Drawing.Size(40, 25);
			this.checkBoxA.TabIndex = 4;
			this.checkBoxA.Text = "A";
			this.checkBoxA.UseVisualStyleBackColor = true;
			// 
			// checkBoxB
			// 
			this.checkBoxB.AutoSize = true;
			this.checkBoxB.Location = new System.Drawing.Point(14, 55);
			this.checkBoxB.Name = "checkBoxB";
			this.checkBoxB.Size = new System.Drawing.Size(39, 25);
			this.checkBoxB.TabIndex = 5;
			this.checkBoxB.Text = "B";
			this.checkBoxB.UseVisualStyleBackColor = true;
			// 
			// checkBoxC
			// 
			this.checkBoxC.AutoSize = true;
			this.checkBoxC.Location = new System.Drawing.Point(14, 85);
			this.checkBoxC.Name = "checkBoxC";
			this.checkBoxC.Size = new System.Drawing.Size(39, 25);
			this.checkBoxC.TabIndex = 6;
			this.checkBoxC.Text = "C";
			this.checkBoxC.UseVisualStyleBackColor = true;
			// 
			// checkBoxD
			// 
			this.checkBoxD.AutoSize = true;
			this.checkBoxD.Location = new System.Drawing.Point(14, 115);
			this.checkBoxD.Name = "checkBoxD";
			this.checkBoxD.Size = new System.Drawing.Size(41, 25);
			this.checkBoxD.TabIndex = 7;
			this.checkBoxD.Text = "D";
			this.checkBoxD.UseVisualStyleBackColor = true;
			// 
			// textBoxQuestion
			// 
			this.textBoxQuestion.AcceptsReturn = true;
			this.textBoxQuestion.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBoxQuestion.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textBoxQuestion.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.textBoxQuestion.Location = new System.Drawing.Point(3, 25);
			this.textBoxQuestion.Multiline = true;
			this.textBoxQuestion.Name = "textBoxQuestion";
			this.textBoxQuestion.ReadOnly = true;
			this.textBoxQuestion.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.textBoxQuestion.Size = new System.Drawing.Size(1419, 447);
			this.textBoxQuestion.TabIndex = 8;
			// 
			// checkBoxE
			// 
			this.checkBoxE.AutoSize = true;
			this.checkBoxE.Location = new System.Drawing.Point(14, 145);
			this.checkBoxE.Name = "checkBoxE";
			this.checkBoxE.Size = new System.Drawing.Size(38, 25);
			this.checkBoxE.TabIndex = 9;
			this.checkBoxE.Text = "E";
			this.checkBoxE.UseVisualStyleBackColor = true;
			// 
			// tableLayoutPanel
			// 
			this.tableLayoutPanel.ColumnCount = 2;
			this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
			this.tableLayoutPanel.Controls.Add(this.groupBoxAnswers, 0, 1);
			this.tableLayoutPanel.Controls.Add(this.groupBoxQuestion, 0, 0);
			this.tableLayoutPanel.Controls.Add(this.groupBoxTest, 1, 1);
			this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel.Name = "tableLayoutPanel";
			this.tableLayoutPanel.RowCount = 2;
			this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 180F));
			this.tableLayoutPanel.Size = new System.Drawing.Size(1431, 661);
			this.tableLayoutPanel.TabIndex = 10;
			// 
			// groupBoxAnswers
			// 
			this.groupBoxAnswers.Controls.Add(this.checkBoxA);
			this.groupBoxAnswers.Controls.Add(this.checkBoxE);
			this.groupBoxAnswers.Controls.Add(this.checkBoxB);
			this.groupBoxAnswers.Controls.Add(this.checkBoxC);
			this.groupBoxAnswers.Controls.Add(this.checkBoxD);
			this.groupBoxAnswers.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBoxAnswers.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.groupBoxAnswers.Location = new System.Drawing.Point(3, 484);
			this.groupBoxAnswers.Name = "groupBoxAnswers";
			this.groupBoxAnswers.Size = new System.Drawing.Size(1305, 174);
			this.groupBoxAnswers.TabIndex = 2;
			this.groupBoxAnswers.TabStop = false;
			this.groupBoxAnswers.Text = "Answer(s)";
			// 
			// groupBoxQuestion
			// 
			this.tableLayoutPanel.SetColumnSpan(this.groupBoxQuestion, 2);
			this.groupBoxQuestion.Controls.Add(this.textBoxQuestion);
			this.groupBoxQuestion.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBoxQuestion.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.groupBoxQuestion.Location = new System.Drawing.Point(3, 3);
			this.groupBoxQuestion.Name = "groupBoxQuestion";
			this.groupBoxQuestion.Size = new System.Drawing.Size(1425, 475);
			this.groupBoxQuestion.TabIndex = 3;
			this.groupBoxQuestion.TabStop = false;
			this.groupBoxQuestion.Text = "Question";
			// 
			// groupBoxTest
			// 
			this.groupBoxTest.Controls.Add(this.buttonPrevious);
			this.groupBoxTest.Controls.Add(this.checkBoxCheat);
			this.groupBoxTest.Controls.Add(this.labelPercent);
			this.groupBoxTest.Controls.Add(this.labelScored);
			this.groupBoxTest.Controls.Add(this.buttonNext);
			this.groupBoxTest.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBoxTest.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.groupBoxTest.Location = new System.Drawing.Point(1314, 484);
			this.groupBoxTest.Name = "groupBoxTest";
			this.groupBoxTest.Size = new System.Drawing.Size(114, 174);
			this.groupBoxTest.TabIndex = 4;
			this.groupBoxTest.TabStop = false;
			this.groupBoxTest.Text = "Scores";
			// 
			// buttonPrevious
			// 
			this.buttonPrevious.Location = new System.Drawing.Point(10, 125);
			this.buttonPrevious.Name = "buttonPrevious";
			this.buttonPrevious.Size = new System.Drawing.Size(40, 40);
			this.buttonPrevious.TabIndex = 6;
			this.buttonPrevious.Text = "<<";
			this.buttonPrevious.UseVisualStyleBackColor = true;
			this.buttonPrevious.Click += new System.EventHandler(this.buttonPrevious_Click);
			// 
			// checkBoxCheat
			// 
			this.checkBoxCheat.AutoSize = true;
			this.checkBoxCheat.Location = new System.Drawing.Point(12, 90);
			this.checkBoxCheat.Name = "checkBoxCheat";
			this.checkBoxCheat.Size = new System.Drawing.Size(71, 25);
			this.checkBoxCheat.TabIndex = 5;
			this.checkBoxCheat.Text = "cheat";
			this.checkBoxCheat.UseVisualStyleBackColor = true;
			this.checkBoxCheat.CheckedChanged += new System.EventHandler(this.checkBoxCheat_CheckedChanged);
			// 
			// labelPercent
			// 
			this.labelPercent.AutoSize = true;
			this.labelPercent.Location = new System.Drawing.Point(6, 55);
			this.labelPercent.Name = "labelPercent";
			this.labelPercent.Size = new System.Drawing.Size(24, 21);
			this.labelPercent.TabIndex = 4;
			this.labelPercent.Text = "%";
			// 
			// labelScored
			// 
			this.labelScored.AutoSize = true;
			this.labelScored.Location = new System.Drawing.Point(6, 25);
			this.labelScored.Name = "labelScored";
			this.labelScored.Size = new System.Drawing.Size(26, 21);
			this.labelScored.TabIndex = 3;
			this.labelScored.Text = "[ ]";
			// 
			// buttonNext
			// 
			this.buttonNext.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.buttonNext.Location = new System.Drawing.Point(60, 125);
			this.buttonNext.Name = "buttonNext";
			this.buttonNext.Size = new System.Drawing.Size(40, 40);
			this.buttonNext.TabIndex = 2;
			this.buttonNext.Text = ">>";
			this.buttonNext.UseVisualStyleBackColor = true;
			this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
			// 
			// Quiz
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1431, 661);
			this.Controls.Add(this.tableLayoutPanel);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Quiz";
			this.Text = "Quiz";
			this.tableLayoutPanel.ResumeLayout(false);
			this.groupBoxAnswers.ResumeLayout(false);
			this.groupBoxAnswers.PerformLayout();
			this.groupBoxQuestion.ResumeLayout(false);
			this.groupBoxQuestion.PerformLayout();
			this.groupBoxTest.ResumeLayout(false);
			this.groupBoxTest.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion
		private CheckBox checkBoxA;
		private CheckBox checkBoxB;
		private CheckBox checkBoxC;
		private CheckBox checkBoxD;
		private TextBox textBoxQuestion;
		private CheckBox checkBoxE;
		private TableLayoutPanel tableLayoutPanel;
		private GroupBox groupBoxAnswers;
		private GroupBox groupBoxQuestion;
		private GroupBox groupBoxTest;
		private Label labelPercent;
		private Label labelScored;
		private Button buttonNext;
		private CheckBox checkBoxCheat;
		private Button buttonPrevious;
	}
}