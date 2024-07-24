using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using quiz_app.Data;
using quiz_app.Models;
using quiz_app.Services;

namespace quiz_app.Pages
{
    public class CreateModel : PageModel
    {
        private readonly QuestionService _questionService;

        public CreateModel(QuestionService questionService)
        {
            _questionService = questionService;
        }

        [BindProperty]
        public Question Question { get; set; } = new Question();

        [BindProperty]
        public List<Answer> Answers { get; set; } = new List<Answer>
        {
            new Answer(),
            new Answer(),
            new Answer()
        };

        [BindProperty]
        public int CorrectAnswerIndex { get; set; }

        public IActionResult OnGet()
        {
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {

            _questionService.AddQuestion(Question, Answers, CorrectAnswerIndex);

            return RedirectToPage("./Index");
        }
    }
}