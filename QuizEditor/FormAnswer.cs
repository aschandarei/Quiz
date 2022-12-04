using QuizLibrary;

namespace QuizEditor
{
	public partial class FormAnswer : Form
	{
		private Action<Answer> _answerAction;
		private Answer _answer = new();
		public FormAnswer(Action<Answer> answerAction, Answer? answer = null)
		{
			InitializeComponent();

			_answerAction = answerAction;
			if (answer != null)
			{
				_answer = answer;
			}
			textBoxAnswer.Text = _answer.Content;
			if (_answer.IsCorrect)
			{
				buttonCorrect.ForeColor = Color.Red;
				buttonWrong.ForeColor = Color.Black;
			}
			else
			{
				buttonCorrect.ForeColor = Color.Black;
				buttonWrong.ForeColor = Color.Red;
			}

		}

		private void buttonBulk_Click(object sender, EventArgs e)
		{
			foreach (var line in textBoxAnswer.Text.Split(Environment.NewLine))
			{
				var answer = new Answer();
				answer.Content = line[2..];
				_answerAction?.Invoke(answer);
			}
			Close();
		}

		private void buttonWrong_Click(object sender, EventArgs e)
		{
			_answer.Content = textBoxAnswer.Text;
			_answer.IsCorrect = false;
			_answerAction?.Invoke(_answer);
			Close();
		}

		private void buttonCorrect_Click(object sender, EventArgs e)
		{
			_answer.Content = textBoxAnswer.Text;
			_answer.IsCorrect = true;
			_answerAction?.Invoke(_answer);
			Close();
		}
	}
}
