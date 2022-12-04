using System.Text.Json;
using QuizLibrary;

namespace QuizEditor
{
	public partial class QuizEditor : Form
	{
		private readonly Quiz _quiz = new();
		private readonly string _path = string.Empty;
		private Question? _selectedQuestion = null;
		private readonly BindingSource bindingSource = new();


		public QuizEditor()
		{
			InitializeComponent();
			var ofd = new OpenFileDialog();
			ofd.Filter = "JSON files (*.json)|*.json";
			var result = ofd.ShowDialog();
			if (result == DialogResult.OK)
			{
				_path = ofd.FileName;
				var content = File.ReadAllText(_path);
				_quiz = JsonSerializer.Deserialize<Quiz>(content) ?? new Quiz();
				Text = $"{_quiz.Name} - ({_quiz.Questions.Count} questions from {_path})";
				_quiz.Questions = _quiz.Questions.OrderBy(q => q.Content).ToList();
				bindingSource.DataSource = _quiz.Questions;
				listBoxQuestions.DataSource = bindingSource;
				listBoxQuestions.DisplayMember = "Content";
			}
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
			_quiz.Questions = _quiz.Questions.OrderBy(q => q.Content).ToList();
			FilterQuestions(textBoxSearch.Text);
			Text = $"{_quiz.Name} - ({_quiz.Questions.Count} questions from {_path})";
		}

		private void EditQuestion(Question question)
		{
			bindingSource.ResetBindings(false);
		}

		private void listBoxQuestions_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			_selectedQuestion = listBoxQuestions.SelectedItem as Question;
			if (_selectedQuestion!= null)
			{
				var formQuestion = new FormQuestion(EditQuestion, _selectedQuestion);
				formQuestion.ShowDialog();
			}
		}

		private void textBoxSearch_TextChanged(object sender, EventArgs e)
		{
			FilterQuestions(textBoxSearch.Text);
		}

		private void FilterQuestions(string lookFor)
		{
			if (string.IsNullOrEmpty(lookFor))
			{
				bindingSource.DataSource = _quiz.Questions;
				bindingSource.ResetBindings(false);
				return;
			}

			var filtered = new List<Question>();
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
			bindingSource.DataSource = filtered;
			bindingSource.ResetBindings(false);
		}
	}
}