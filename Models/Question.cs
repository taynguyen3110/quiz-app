using System.ComponentModel.DataAnnotations;

namespace quiz_app.Models
{
    public class Question
    {
        public int QuestionId { get; set; }

        [Required(ErrorMessage = "The question text is required.")]
        [StringLength(200, ErrorMessage = "The question text cannot exceed 200 characters.")]
        public string Text { get; set; } = string.Empty;

        public List<Answer> Answers { get; set; }
    }
}
