using Microsoft.EntityFrameworkCore;
using quiz_app.Data;
using quiz_app.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace quiz_app.Services
{
    public class QuizService
    {
        private readonly QuizDbContext _context;
        private List<Question> _selectedQuestions;
        private int _score;

        public QuizService(QuizDbContext context)
        {
            _context = context;
            _selectedQuestions = new List<Question>();
            _score = 0;
        }

        public async Task<List<Question>> GetRandomQuestions(int count)
        {
            return await _context.Questions
                .Include(q => q.Answers)
                .OrderBy(q => Guid.NewGuid())
                .Take(count)
                .ToListAsync();
        }

        public async Task<List<Question>> GetQuestionByIds(List<int> questionIds)
        {
            return await _context.Questions
                .Include(q => q.Answers)
                .Where(q => questionIds.Contains(q.QuestionId))
                .ToListAsync();
        }

        public async Task<int> SubmitQuiz (List<int> questionIds, List<string> answers)
        {
            var questions = await GetQuestionByIds(questionIds);
            var _selectedQuestions = questions
                .OrderBy(q => Array.IndexOf(questionIds.ToArray(), q.QuestionId))
                .ToList();

            for (int i = 0; i < _selectedQuestions.Count; i++)
            {
                var rightAnswer = _selectedQuestions[i].Answers.FirstOrDefault(a => a.IsCorrect).Text;
                if (answers[i] == rightAnswer)
                {
                    _score++;
                }
            }

            return _score;
        }
    }
}