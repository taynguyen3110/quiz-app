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
    public class EditModel : PageModel
    {
        private readonly quiz_app.Data.QuizDbContext _context;

        private readonly QuestionService _questionService;
        public EditModel(QuestionService questionService, QuizDbContext context)
        {
            _questionService = questionService;
            _context = context;
        }

        [BindProperty]
        public Question Question { get; set; } = default!;

        [BindProperty]
        public List<Answer> Answers { get; set; } = new List<Answer>();

        [BindProperty]
        public int CorrectAnswerIndex { get; set; }

        [BindProperty]
        public int QuestionId { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var question = _questionService.GetQuestionById(id.Value);

            if (question == null)
            {
                return NotFound();
            }

            Question = question;
            QuestionId = question.QuestionId;
            Answers = question.Answers.ToList();
            CorrectAnswerIndex = Answers.FindIndex(a => a.IsCorrect);

            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            var existingQuestion = _questionService.GetQuestionById(QuestionId);

            // Update Question entity
            existingQuestion.Text = Question.Text;

            var existingAnswer = _questionService.GetAnswers(QuestionId);

            // Update Answers
            foreach (var answer in existingAnswer)
            {
                for (int i = 0; i < Answers.Count; i++)
                {
                    if (answer.AnswerId == Answers[i].AnswerId)
                    {
                        answer.Text = Answers[i].Text;
                        answer.IsCorrect = (i == CorrectAnswerIndex);
                        _context.Entry(answer).State = EntityState.Modified;
                    }
                }
            }

            // Update the context
            _context.Entry(existingQuestion).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!QuestionExists(QuestionId))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool QuestionExists(int id)
        {
            return _context.Questions.Any(e => e.QuestionId == id);
        }
    }
}
