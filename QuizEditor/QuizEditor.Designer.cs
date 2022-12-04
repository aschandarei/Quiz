namespace QuizEditor
{
	partial class QuizEditor
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
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.buttonOpenFile = new System.Windows.Forms.Button();
			this.labelQuestionsFile = new System.Windows.Forms.Label();
			this.textBoxSearch = new System.Windows.Forms.TextBox();
			this.listBoxQuestions = new System.Windows.Forms.ListBox();
			this.buttonClearFilter = new System.Windows.Forms.Button();
			this.buttonAdd = new System.Windows.Forms.Button();
			this.buttonSave = new System.Windows.Forms.Button();
			this.tableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 3;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
			this.tableLayoutPanel1.Controls.Add(this.buttonOpenFile, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.labelQuestionsFile, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.textBoxSearch, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.listBoxQuestions, 0, 2);
			this.tableLayoutPanel1.Controls.Add(this.buttonClearFilter, 1, 1);
			this.tableLayoutPanel1.Controls.Add(this.buttonAdd, 1, 2);
			this.tableLayoutPanel1.Controls.Add(this.buttonSave, 1, 3);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 4;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(1464, 612);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// buttonOpenFile
			// 
			this.tableLayoutPanel1.SetColumnSpan(this.buttonOpenFile, 2);
			this.buttonOpenFile.Dock = System.Windows.Forms.DockStyle.Fill;
			this.buttonOpenFile.Location = new System.Drawing.Point(1407, 3);
			this.buttonOpenFile.Name = "buttonOpenFile";
			this.buttonOpenFile.Size = new System.Drawing.Size(54, 24);
			this.buttonOpenFile.TabIndex = 0;
			this.buttonOpenFile.Text = "...";
			this.buttonOpenFile.UseVisualStyleBackColor = true;
			this.buttonOpenFile.Click += new System.EventHandler(this.buttonOpenFile_Click);
			// 
			// labelQuestionsFile
			// 
			this.labelQuestionsFile.AutoSize = true;
			this.labelQuestionsFile.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelQuestionsFile.Location = new System.Drawing.Point(3, 0);
			this.labelQuestionsFile.Name = "labelQuestionsFile";
			this.labelQuestionsFile.Size = new System.Drawing.Size(1398, 30);
			this.labelQuestionsFile.TabIndex = 1;
			this.labelQuestionsFile.Text = "Questions file";
			// 
			// textBoxSearch
			// 
			this.textBoxSearch.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textBoxSearch.Location = new System.Drawing.Point(3, 33);
			this.textBoxSearch.Name = "textBoxSearch";
			this.textBoxSearch.Size = new System.Drawing.Size(1398, 23);
			this.textBoxSearch.TabIndex = 2;
			this.textBoxSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxSearch_KeyDown);
			// 
			// listBoxQuestions
			// 
			this.listBoxQuestions.Dock = System.Windows.Forms.DockStyle.Fill;
			this.listBoxQuestions.FormattingEnabled = true;
			this.listBoxQuestions.ItemHeight = 15;
			this.listBoxQuestions.Location = new System.Drawing.Point(3, 63);
			this.listBoxQuestions.Name = "listBoxQuestions";
			this.tableLayoutPanel1.SetRowSpan(this.listBoxQuestions, 2);
			this.listBoxQuestions.Size = new System.Drawing.Size(1398, 546);
			this.listBoxQuestions.TabIndex = 4;
			this.listBoxQuestions.SelectedIndexChanged += new System.EventHandler(this.listBoxQuestions_SelectedIndexChanged);
			this.listBoxQuestions.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBoxQuestions_MouseDoubleClick);
			// 
			// buttonClearFilter
			// 
			this.buttonClearFilter.Location = new System.Drawing.Point(1407, 33);
			this.buttonClearFilter.Name = "buttonClearFilter";
			this.buttonClearFilter.Size = new System.Drawing.Size(24, 23);
			this.buttonClearFilter.TabIndex = 5;
			this.buttonClearFilter.Text = "X";
			this.buttonClearFilter.UseVisualStyleBackColor = true;
			this.buttonClearFilter.Click += new System.EventHandler(this.buttonClearFilter_Click);
			// 
			// buttonAdd
			// 
			this.tableLayoutPanel1.SetColumnSpan(this.buttonAdd, 2);
			this.buttonAdd.Dock = System.Windows.Forms.DockStyle.Top;
			this.buttonAdd.Location = new System.Drawing.Point(1407, 63);
			this.buttonAdd.Name = "buttonAdd";
			this.buttonAdd.Size = new System.Drawing.Size(54, 23);
			this.buttonAdd.TabIndex = 7;
			this.buttonAdd.Text = "Add";
			this.buttonAdd.UseVisualStyleBackColor = true;
			this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
			// 
			// buttonSave
			// 
			this.tableLayoutPanel1.SetColumnSpan(this.buttonSave, 2);
			this.buttonSave.Location = new System.Drawing.Point(1407, 585);
			this.buttonSave.Name = "buttonSave";
			this.buttonSave.Size = new System.Drawing.Size(54, 23);
			this.buttonSave.TabIndex = 8;
			this.buttonSave.Text = "Save";
			this.buttonSave.UseVisualStyleBackColor = true;
			this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
			// 
			// QuizEditor
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1464, 612);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Name = "QuizEditor";
			this.Text = "Question Editor";
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private TableLayoutPanel tableLayoutPanel1;
		private Button buttonOpenFile;
		private Label labelQuestionsFile;
		private TextBox textBoxSearch;
		private ListBox listBoxQuestions;
		private Button buttonClearFilter;
		private Button buttonAdd;
		private Button buttonSave;
	}
}