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
    public class DeleteModel : PageModel
    {
        private readonly quiz_app.Data.QuizDbContext _context;
        private readonly QuestionService _questionService;

        public DeleteModel(quiz_app.Data.QuizDbContext context, QuestionService questionService)
        {
            _context = context;
            _questionService = questionService;
        }

        [BindProperty]
        public Question Question { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            var question = _questionService.GetQuestionById(id.Value);

            Question = question;

            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            _questionService.DeleteQuestion(id.Value);

            return RedirectToPage("./Index");
        }
    }
}
