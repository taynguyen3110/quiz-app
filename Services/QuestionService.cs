using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using quiz_app.Data;
using quiz_app.Models;

namespace quiz_app.Services
{
    public class QuestionService
    {
        private readonly QuizDbContext _context;

        public QuestionService(QuizDbContext context)
        {
            _context = context;
        }

        public List<Question> GetAllQuestions()
        {
            return _context.Questions.ToList();
        }

        public Question GetQuestionById(int id)
        {
            return _context.Questions.Include(q => q.Answers).FirstOrDefault(q => q.QuestionId == id);
        }

        public List<Answer> GetAnswers (int questionId)
        {
            return _context.Answers.Where(a => a.QuestionId == questionId).ToList();
        }
        public async Task AddQuestion(Question question, List<Answer> answers, int correctAnswerIndex)
        {
            // Set the correct answer
            for (int i = 0; i < answers.Count; i++)
            {
                answers[i].IsCorrect = (i == correctAnswerIndex);
            }

            question.Answers = answers;

            _context.Questions.Add(question);
            await _context.SaveChangesAsync();
        }


        public void UpdateQuestion(Question question)
        {
            _context.Questions.Update(question);
            _context.SaveChanges();
        }

        public void DeleteQuestion(int id)
        {
            var question = _context.Questions.Find(id);
            if (question != null)
            {
                _context.Questions.Remove(question);
                _context.SaveChanges();
            }
        }
    }
}