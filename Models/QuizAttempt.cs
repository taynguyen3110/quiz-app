namespace quiz_app.Models
{
    public class QuizAttempt
    {
        public int QuizAttemptId { get; set; }
        public DateTime AttemptDate { get; set; }
        public int Score { get; set; }
        public List<Question> Questions { get; set; }
    }
}
