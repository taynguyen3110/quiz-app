using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using quiz_app.Data;
using quiz_app.Models;
using quiz_app.Services;
using System.Collections.Generic;
using System.Linq;

namespace quiz_app.Pages
{
    public class QuizModel : PageModel
    {
        private readonly QuizService _quizService;

        public QuizModel(QuizDbContext context)
        {
            _quizService = new QuizService(context);
        }

        public IEnumerable<Question> Questions { get; set; }

        [BindProperty]
        public Dictionary<int, int> UserAnswers { get; set; }

        public int Score { get; set; }

        public void OnGet()
        {
            Questions = (IEnumerable<Question>)_quizService.GetRandomQuestions(5);
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _quizService.SubmitAnswers(UserAnswers);
            Score = _quizService.GetScore();

            // Optionally, redirect to a different page to show the score
            // or just display it on the same page.
            return Page();
        }
    }
}