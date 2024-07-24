using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using quiz_app.Data;
using quiz_app.Services;

namespace quiz_app.Models
{
    public class IndexModel : PageModel
    {
        private readonly QuestionService _questionService;

        public IndexModel(QuestionService questionService)
        {
            _questionService = questionService;
        }

        public IList<Question> Question { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Question = _questionService.GetAllQuestions();
        }
    }
}
