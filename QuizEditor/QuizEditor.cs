using System.Text.Json;
using QuizLibrary;

namespace QuizEditor
{
	public partial class QuizEditor : Form
	{
		private Quiz _quiz = new();
		private string _path = string.Empty;
		private Question? _selectedQuestion = null;

		public QuizEditor()
		{
			InitializeComponent();
			this.labelQuestionsFile.Text = string.Empty;
		}

		private void buttonOpenFile_Click(object sender, EventArgs e)
		{
			var ofd = new OpenFileDialog();
			ofd.Filter = "JSON files (*.json)|*.json";
			var result = ofd.ShowDialog();
			if (result == DialogResult.OK)
			{
				_path = ofd.FileName;
				labelQuestionsFile.Text = _path;
				var content = File.ReadAllText(_path);
				_quiz = JsonSerializer.Deserialize<Quiz>(content) ?? new Quiz();
				Text = _quiz.Name;
				_quiz.Questions.OrderBy(q => q.Content);
				setDataSource(_quiz.Questions);
			}
		}

		private void setDataSource(List<Question> questions)
		{
			listBoxQuestions.DataSource = questions;
			listBoxQuestions.DisplayMember = "Content";
		}

		private void buttonSearch_Click(object sender, EventArgs e)
		{

		}

		private void buttonClearFilter_Click(object sender, EventArgs e)
		{
			setDataSource(_quiz.Questions);
			textBoxSearch.Text = string.Empty;
		}

		private void buttonSave_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(_path)) return;

			var content = JsonSerializer.Serialize(_quiz, new JsonSerializerOptions
			{
				WriteIndented = true
			});
			File.WriteAllText(_path, content);
		}

		private void buttonAdd_Click(object sender, EventArgs e)
		{
			var formQuestion = new FormQuestion(AddQuestion);
			formQuestion.ShowDialog();
		}

		private void AddQuestion(Question question)
		{
			_quiz.Questions.Add(question);
		}

		private void EditQuestion(Question question)
		{
			
		}

		private void textBoxSearch_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				var filtered = new List<Question>();
				var lookFor = textBoxSearch.Text;
				foreach (var question in _quiz.Questions)
				{
					var hit = false;
					if (question.Content.Contains(lookFor))
					{
						hit = true;
					}
					else
					{
						foreach (var answer in question.Answers)
						{
							if (answer.Content.Contains(lookFor))
							{
								hit = true;
								break;
							}
						}
					}
					if (hit)
					{
						filtered.Add(question);
					}
				}
				setDataSource(filtered);
			}
		}

		private void listBoxQuestions_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			if (_selectedQuestion!= null)
			{
				var formQuestion = new FormQuestion(EditQuestion, _selectedQuestion);
				formQuestion.ShowDialog();
			}
		}

		private void listBoxQuestions_SelectedIndexChanged(object sender, EventArgs e)
		{
			_selectedQuestion = _quiz.Questions[listBoxQuestions.SelectedIndex];
		}
	}
}