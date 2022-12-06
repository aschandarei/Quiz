using System.Text.Json;
using QuizLibrary;

namespace QuizEditor
{
	public partial class QuizEditor : Form
	{
		private readonly Quiz _quiz = new();
		private string _path = string.Empty;
		private Question? _selectedQuestion = null;
		private readonly BindingSource bindingSource = new();


		public QuizEditor()
		{
			InitializeComponent();

			try
			{
				var ofd = new OpenFileDialog
				{
					Title = "Open existing quiz file",
					Filter = "JSON files (*.json)|*.json"
				};
				var result = ofd.ShowDialog();
				if (result == DialogResult.OK)
				{
					_path = ofd.FileName;
					var content = File.ReadAllText(_path);
					_quiz = JsonSerializer.Deserialize<Quiz>(content) ?? new Quiz();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
				Environment.Exit(1);
			}
			_quiz.Questions = _quiz.Questions.OrderBy(q => q.Content).ToList();
			bindingSource.DataSource = _quiz.Questions;
			listBoxQuestions.DataSource = bindingSource;
			listBoxQuestions.DisplayMember = "Content";
			SetText();
		}

		private void buttonSave_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(_path))
			{
				var sfd = new SaveFileDialog
				{
					Title = "Create new quiz file",
					Filter = "JSON files (*.json)|*.json"
				};
				var newQuizFile = sfd.ShowDialog();
				if (newQuizFile == DialogResult.OK)
				{

					_path = sfd.FileName;
					var fi = new FileInfo(_path);
					_quiz.Name = fi.Name[..5];
					SetText();
				}
				else
				{
					return;
				}
			}


			var content = JsonSerializer.Serialize(_quiz, new JsonSerializerOptions
			{
				WriteIndented = true
			});
			File.WriteAllText(_path, content);
		}

		private void SetText()
		{
			var count = _quiz.Questions.Count switch
			{
				1 => "1 question",
				_ => $"{_quiz.Questions.Count} questions",
			};
			Text = string.IsNullOrEmpty(_path) ?
				$"New quiz - ({count})" :
				$"{_quiz.Name} - ({count} from {_path})";
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
			SetText();
		}

		private void EditQuestion(Question question)
		{
			bindingSource.ResetBindings(false);
		}

		private void listBoxQuestions_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			_selectedQuestion = listBoxQuestions.SelectedItem as Question;
			if (_selectedQuestion != null)
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

		private void buttonClearSearch_Click(object sender, EventArgs e)
		{
			textBoxSearch.Text = string.Empty;
		}
	}
}