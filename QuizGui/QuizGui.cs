using System.Reflection;
using System.Text.Json;
using QuizLibrary;

namespace QuizGui
{
	public partial class QuizGui : Form
	{
		private readonly Random random = new();

		/// <summary>
		/// List of questions
		/// </summary>
		private readonly List<Question> Questions = new();

		/// <summary>
		/// List with all available answer checkboxes
		/// </summary>
		private readonly List<CheckBox> CheckBoxes;

		/// <summary>
		/// List with the current visible checkboxes
		/// </summary>
		private List<CheckBox> AnswerBoxes = new();

		/// <summary>
		/// Current question index
		/// </summary>
		private int index = 0;

		/// <summary>
		/// Maximum achievable score
		/// </summary>
		private readonly float HighScores = 0;

		/// <summary>
		/// Achieved score
		/// </summary>
		private readonly List<float> Scored = new();


		public QuizGui()
		{
			InitializeComponent();

			CheckBoxes = new List<CheckBox>
			{
				checkBoxA,
				checkBoxB,
				checkBoxC,
				checkBoxD,
				checkBoxE
			};

			ResetCheckBoxes();

			try
			{
				var workingDirectory = new FileInfo(Assembly.GetExecutingAssembly().Location).DirectoryName;
				var content = File.ReadAllText($@"{workingDirectory}\quiz.json");
				var quiz = JsonSerializer.Deserialize<Quiz>(content) ?? new Quiz();

				Questions = quiz.Questions;
				Text = quiz.Name;
				if (Questions.Count < 1) throw new Exception("Not enough questions!");

				foreach (var question in Questions)
				{
					Scored.Add(0);
					foreach (var answer in question.Answers) if (answer.IsCorrect) HighScores++;
				}

				// Shuffle questions
				Questions = Questions.OrderBy(item => random.Next()).ToList();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
				Application.Exit();
			}

			AskQuestion();
		}

		private void AskQuestion()
		{
			float ownScore = 0;
			foreach (var score in Scored) ownScore += score;
			var percent = ownScore / HighScores * 100;
			labelScored.Text = $"{ownScore}/{HighScores}";
			labelPercent.Text = $"({percent:0.00}%)";

			if (index >= Questions.Count)
			{
				MessageBox.Show($"Finished!\r\nScored: {labelScored.Text}\r\n{labelPercent.Text}");
				Application.Exit();
				return;
			}

			var question = Questions[index];
			textBoxQuestion.Text = question.Content;
			groupBoxQuestion.Text = $"Question: {index + 1}/{Questions.Count}";

			var answerCount = question.Answers.Count();
			AnswerBoxes = new List<CheckBox>();
			for (int i = 0; i < answerCount; i++) AnswerBoxes.Add(CheckBoxes[i]);

			// Shuffle answer check boxes if more than just two
			if (answerCount > 2) AnswerBoxes = AnswerBoxes.OrderBy(item => random.Next()).ToList();

			for (int i = 0; i < answerCount; i++)
			{
				var answer = question.Answers[i];
				AnswerBoxes[i].Visible = true;
				AnswerBoxes[i].Text = answer.Content;
				AnswerBoxes[i].Tag = answer;
			}
		}

		private void ResetCheckBoxes()
		{
			foreach (var checkBox in CheckBoxes)
			{
				checkBox.Visible = false;
				checkBox.Checked = false;
			}

			checkBoxCheat.Checked = false;
		}

		private void buttonNext_Click(object sender, EventArgs e)
		{
			var points = 0;
			foreach (var box in AnswerBoxes) if (box.Checked && box.Tag is Answer answer && answer.IsCorrect) points++;
			Scored[index] = points;

			ResetCheckBoxes();
			index++;
			AskQuestion();
		}

		private void checkBoxCheat_CheckedChanged(object sender, EventArgs e)
		{
			if (sender is not CheckBox cheater) return;

			foreach (var box in AnswerBoxes) box.ForeColor = Color.Black;

			if (!cheater.Checked) return;

			foreach (var box in AnswerBoxes) if (box.Tag is Answer answer && answer.IsCorrect) box.ForeColor = Color.Red;
		}

		private void buttonPrevious_Click(object sender, EventArgs e)
		{
			ResetCheckBoxes();

			index--;
			if (index < 0) index = 0;
			Scored[index] = 0;

			AskQuestion();
		}
	}
}