namespace QuizLibrary
{
	public class Answer
	{
		public string Content { get; set; }

		public bool IsCorrect { get; set; }

		public Answer()
		{
			Content = string.Empty;
			IsCorrect = false;
		}

		public Answer(string content, bool correct = false)
		{
			Content = content;
			IsCorrect = correct;
		}

		public string Presenter => $"{Content} {(IsCorrect?"[correct]":"[wrong]")}";
	}
}
