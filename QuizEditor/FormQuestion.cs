using QuizLibrary;
using System.Windows.Forms;

namespace QuizEditor
{
	public partial class FormQuestion : Form
	{
		private Action<Question> _returnQuestion;
		private Question _question = new();
		private Answer? _selectedAnswer;
		private BindingSource bindingSource = new();


		public FormQuestion(
			Action<Question> returnQuestion,
			Question? question = null)
		{
			_returnQuestion = returnQuestion;
			InitializeComponent();
			if (question != null)
			{
				_question = question;
			}
			bindingSource.DataSource = _question.Answers;
			textBoxQuestion.Text = _question.Content;
			listBoxAnswers.DataSource = bindingSource;
			listBoxAnswers.DisplayMember = "Content";
		}

		private void buttonOk_Click(object sender, EventArgs e)
		{
			_question.Content = textBoxQuestion.Text;
			_returnQuestion?.Invoke(_question);
			Close();
		}

		private void buttonAddAnswer_Click(object sender, EventArgs e)
		{
			var formAnswer = new FormAnswer(AddAnswer);
			formAnswer.ShowDialog();
		}

		private void AddAnswer(Answer answer)
		{
			_question.Answers.Add(answer);
			bindingSource.ResetBindings(false);
		}


		private void EditAnswer(Answer answer)
		{
			bindingSource.ResetBindings(false);
		}


		private void listBoxAnswers_SelectedIndexChanged(object sender, EventArgs e)
		{
			_selectedAnswer = _question.Answers[listBoxAnswers.SelectedIndex];
		}

		private void buttonCancel_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void buttonDeleteAnswer_Click(object sender, EventArgs e)
		{
			if (_selectedAnswer != null)
			{
				_question.Answers.Remove(_selectedAnswer);
				bindingSource.ResetBindings(false);
			}
		}

		private void listBoxAnswers_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			if (_selectedAnswer != null)
			{
				var formAnswer = new FormAnswer(EditAnswer, _selectedAnswer);
				formAnswer.ShowDialog();
			}
		}

		private void listBoxAnswers_DrawItem(object sender, DrawItemEventArgs e)
		{
			var item = _question.Answers[e.Index];
			e.DrawBackground();
			var brush = item.IsCorrect ? Brushes.Red : Brushes.Black;
			var font = e.Font ?? new Font("Arial", 9);
			e.Graphics.DrawString(item.Content, font, brush, e.Bounds, StringFormat.GenericDefault);
			e.DrawFocusRectangle();
		}
	}
}
