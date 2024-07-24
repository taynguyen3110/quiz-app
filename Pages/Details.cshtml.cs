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
    public class DetailsModel : PageModel
    {
        private readonly QuestionService _questionService;

        public DetailsModel(QuestionService questionService)
        {
            _questionService = questionService;
        }

        public Question Question { get; set; }

        public async Task<IActionResult> OnGetAsync(int id)
        {
            Question = _questionService.GetQuestionById(id);

            if (Question == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
