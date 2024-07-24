using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using quiz_app.Data;
using quiz_app.Models;
using quiz_app.Services;

namespace quiz_app.Pages
{
    public class TakeQuizModel : PageModel
    {

        private readonly QuizService _quizService;

        public TakeQuizModel(QuizService quizService)
        {
            _quizService = quizService;
        }

        [BindProperty]
        public List<Question> Questions { get; set; } = new List<Question>();

        [BindProperty]
        public List<string> Answers { get; set; } = new List<string>();

        [BindProperty]
        public List<int> QuestionIds { get; set; } = new List<int>();

        public bool IsQuizCompleted { get; set; } = false;

        public int Score { get; set; } = 0;

        public async Task<IActionResult> OnGetAsync()
        {
            Questions = await _quizService.GetRandomQuestions(5);

            QuestionIds = Questions.Select(q => q.QuestionId).ToList();

            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            Score = await _quizService.SubmitQuiz(QuestionIds, Answers);

            IsQuizCompleted = true;

            return Page();
        }
    }
}

