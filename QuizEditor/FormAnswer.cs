using QuizLibrary;

namespace QuizEditor
{
	public partial class FormAnswer : Form
	{
		private Action<Answer> _answerAction;
		private Answer _answer = new();
		public FormAnswer(Action<Answer> answerAction, Answer? answer = null)
		{
			_answerAction = answerAction;
			if (answer != null )
			{
				_answer = answer;
				textBoxAnswer.Text = answer.Content;
				checkBoxCorrectAnswer.Checked = answer.IsCorrect;
			}
			InitializeComponent();
		}

		private void buttonOk_Click(object sender, EventArgs e)
		{
			_answer.Content = textBoxAnswer.Text;
			_answer.IsCorrect = checkBoxCorrectAnswer.Checked;
			_answerAction?.Invoke(_answer);
			Close();
		}
	}
}
