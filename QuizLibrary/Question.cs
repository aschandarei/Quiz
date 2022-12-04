namespace QuizLibrary
{
	public class Question
	{
		public string Content { get; set; }

		public List<Answer> Answers { get; set; }

		public Question()
		{
			Content = string.Empty;
			Answers = new List<Answer>();
		}

		public Question(string content, List<Answer> answers)
		{
			Content = content;
			Answers = answers;
		}
	}
}
