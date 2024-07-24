using Microsoft.EntityFrameworkCore;
using quiz_app.Models;

namespace quiz_app.Data
{
    public class QuizDbContext : DbContext
    {
        public DbSet<Question> Questions { get; set; }
        public DbSet<Answer> Answers { get; set; }
        public DbSet<QuizAttempt> QuizAttempts { get; set; }

        public QuizDbContext(DbContextOptions<QuizDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Question>(entity =>
            {
                entity.HasKey(q => q.QuestionId); // Primary key

                entity.HasMany(q => q.Answers)
                      .WithOne(a => a.Question)
                      .HasForeignKey(a => a.QuestionId);
            });

            modelBuilder.Entity<Answer>(entity =>
            {
                entity.HasKey(a => a.AnswerId); // Primary key

                entity.Property(a => a.Text)
                      .IsRequired(false);

                entity.HasOne(a => a.Question)
                      .WithMany(q => q.Answers)
                      .HasForeignKey(a => a.QuestionId)
                      .OnDelete(DeleteBehavior.Cascade); // Configure foreign key
            });

            modelBuilder.Entity<Question>().HasData(
                new Question { QuestionId = 1, Text = "What is the capital of France?" },
                new Question { QuestionId = 2, Text = "What is the largest planet in our solar system?" },
                new Question { QuestionId = 3, Text = "Who wrote 'To Kill a Mockingbird'?" },
                new Question { QuestionId = 4, Text = "What is the smallest country in the world?" },
                new Question { QuestionId = 5, Text = "What is the chemical symbol for water?" },
                new Question { QuestionId = 6, Text = "What year did the Titanic sink?" },
                new Question { QuestionId = 7, Text = "What is the hardest natural substance on Earth?" },
                new Question { QuestionId = 8, Text = "What is the longest river in the world?" },
                new Question { QuestionId = 9, Text = "Who painted the Mona Lisa?" },
                new Question { QuestionId = 10, Text = "What is the tallest mountain in the world?" },
                new Question { QuestionId = 11, Text = "Who discovered penicillin?" },
                new Question { QuestionId = 12, Text = "What is the capital of Japan?" },
                new Question { QuestionId = 13, Text = "What is the main ingredient in guacamole?" },
                new Question { QuestionId = 14, Text = "What is the square root of 64?" },
                new Question { QuestionId = 15, Text = "Who is the author of 'Harry Potter' series?" },
                new Question { QuestionId = 16, Text = "What is the capital of Canada?" },
                new Question { QuestionId = 17, Text = "What is the largest ocean on Earth?" },
                new Question { QuestionId = 18, Text = "What is the freezing point of water?" },
                new Question { QuestionId = 19, Text = "What is the largest mammal in the world?" },
                new Question { QuestionId = 20, Text = "What is the capital of Australia?" }
            );

            modelBuilder.Entity<Answer>().HasData(
                // Answers for Question 1
                new Answer { AnswerId = 1, Text = "Paris", IsCorrect = true, QuestionId = 1 },
                new Answer { AnswerId = 2, Text = "London", IsCorrect = false, QuestionId = 1 },
                new Answer { AnswerId = 3, Text = "Berlin", IsCorrect = false, QuestionId = 1 },

                // Answers for Question 2
                new Answer { AnswerId = 4, Text = "Jupiter", IsCorrect = true, QuestionId = 2 },
                new Answer { AnswerId = 5, Text = "Saturn", IsCorrect = false, QuestionId = 2 },
                new Answer { AnswerId = 6, Text = "Mars", IsCorrect = false, QuestionId = 2 },

                // Answers for Question 3
                new Answer { AnswerId = 7, Text = "Harper Lee", IsCorrect = true, QuestionId = 3 },
                new Answer { AnswerId = 8, Text = "Jane Austen", IsCorrect = false, QuestionId = 3 },
                new Answer { AnswerId = 9, Text = "Mark Twain", IsCorrect = false, QuestionId = 3 },

                // Answers for Question 4
                new Answer { AnswerId = 10, Text = "Vatican City", IsCorrect = true, QuestionId = 4 },
                new Answer { AnswerId = 11, Text = "Monaco", IsCorrect = false, QuestionId = 4 },
                new Answer { AnswerId = 12, Text = "San Marino", IsCorrect = false, QuestionId = 4 },

                // Answers for Question 5
                new Answer { AnswerId = 13, Text = "H2O", IsCorrect = true, QuestionId = 5 },
                new Answer { AnswerId = 14, Text = "O2", IsCorrect = false, QuestionId = 5 },
                new Answer { AnswerId = 15, Text = "CO2", IsCorrect = false, QuestionId = 5 },

                // Answers for Question 6
                new Answer { AnswerId = 16, Text = "1912", IsCorrect = true, QuestionId = 6 },
                new Answer { AnswerId = 17, Text = "1905", IsCorrect = false, QuestionId = 6 },
                new Answer { AnswerId = 18, Text = "1898", IsCorrect = false, QuestionId = 6 },

                // Answers for Question 7
                new Answer { AnswerId = 19, Text = "Diamond", IsCorrect = true, QuestionId = 7 },
                new Answer { AnswerId = 20, Text = "Gold", IsCorrect = false, QuestionId = 7 },
                new Answer { AnswerId = 21, Text = "Iron", IsCorrect = false, QuestionId = 7 },

                // Answers for Question 8
                new Answer { AnswerId = 22, Text = "Nile", IsCorrect = true, QuestionId = 8 },
                new Answer { AnswerId = 23, Text = "Amazon", IsCorrect = false, QuestionId = 8 },
                new Answer { AnswerId = 24, Text = "Yangtze", IsCorrect = false, QuestionId = 8 },

                // Answers for Question 9
                new Answer { AnswerId = 25, Text = "Leonardo da Vinci", IsCorrect = true, QuestionId = 9 },
                new Answer { AnswerId = 26, Text = "Vincent van Gogh", IsCorrect = false, QuestionId = 9 },
                new Answer { AnswerId = 27, Text = "Pablo Picasso", IsCorrect = false, QuestionId = 9 },

                // Answers for Question 10
                new Answer { AnswerId = 28, Text = "Mount Everest", IsCorrect = true, QuestionId = 10 },
                new Answer { AnswerId = 29, Text = "K2", IsCorrect = false, QuestionId = 10 },
                new Answer { AnswerId = 30, Text = "Kangchenjunga", IsCorrect = false, QuestionId = 10 },

                // Answers for Question 11
                new Answer { AnswerId = 31, Text = "Alexander Fleming", IsCorrect = true, QuestionId = 11 },
                new Answer { AnswerId = 32, Text = "Louis Pasteur", IsCorrect = false, QuestionId = 11 },
                new Answer { AnswerId = 33, Text = "Marie Curie", IsCorrect = false, QuestionId = 11 },

                // Answers for Question 12
                new Answer { AnswerId = 34, Text = "Tokyo", IsCorrect = true, QuestionId = 12 },
                new Answer { AnswerId = 35, Text = "Osaka", IsCorrect = false, QuestionId = 12 },
                new Answer { AnswerId = 36, Text = "Kyoto", IsCorrect = false, QuestionId = 12 },

                // Answers for Question 13
                new Answer { AnswerId = 37, Text = "Avocado", IsCorrect = true, QuestionId = 13 },
                new Answer { AnswerId = 38, Text = "Tomato", IsCorrect = false, QuestionId = 13 },
                new Answer { AnswerId = 39, Text = "Pepper", IsCorrect = false, QuestionId = 13 },

                // Answers for Question 14
                new Answer { AnswerId = 40, Text = "8", IsCorrect = true, QuestionId = 14 },
                new Answer { AnswerId = 41, Text = "6", IsCorrect = false, QuestionId = 14 },
                new Answer { AnswerId = 42, Text = "10", IsCorrect = false, QuestionId = 14 },

                // Answers for Question 15
                new Answer { AnswerId = 43, Text = "J.K. Rowling", IsCorrect = true, QuestionId = 15 },
                new Answer { AnswerId = 44, Text = "J.R.R. Tolkien", IsCorrect = false, QuestionId = 15 },
                new Answer { AnswerId = 45, Text = "George R.R. Martin", IsCorrect = false, QuestionId = 15 },

                // Answers for Question 16
                new Answer { AnswerId = 46, Text = "Ottawa", IsCorrect = true, QuestionId = 16 },
                new Answer { AnswerId = 47, Text = "Toronto", IsCorrect = false, QuestionId = 16 },
                new Answer { AnswerId = 48, Text = "Vancouver", IsCorrect = false, QuestionId = 16 },

                // Answers for Question 17
                new Answer { AnswerId = 49, Text = "Pacific Ocean", IsCorrect = true, QuestionId = 17 },
                new Answer { AnswerId = 50, Text = "Atlantic Ocean", IsCorrect = false, QuestionId = 17 },
                new Answer { AnswerId = 51, Text = "Indian Ocean", IsCorrect = false, QuestionId = 17 },

                // Answers for Question 18
                new Answer { AnswerId = 52, Text = "0°C", IsCorrect = true, QuestionId = 18 },
                new Answer { AnswerId = 53, Text = "32°C", IsCorrect = false, QuestionId = 18 },
                new Answer { AnswerId = 54, Text = "-1°C", IsCorrect = false, QuestionId = 18 },

                // Answers for Question 19
                new Answer { AnswerId = 55, Text = "Blue Whale", IsCorrect = true, QuestionId = 19 },
                new Answer { AnswerId = 56, Text = "Elephant", IsCorrect = false, QuestionId = 19 },
                new Answer { AnswerId = 57, Text = "Giraffe", IsCorrect = false, QuestionId = 19 },

                // Answers for Question 20
                new Answer { AnswerId = 58, Text = "Canberra", IsCorrect = true, QuestionId = 20 },
                new Answer { AnswerId = 59, Text = "Sydney", IsCorrect = false, QuestionId = 20 },
                new Answer { AnswerId = 60, Text = "Melbourne", IsCorrect = false, QuestionId = 20 }
            );

            modelBuilder.Entity<QuizAttempt>().HasData(
                new QuizAttempt { QuizAttemptId = 1, AttemptDate = DateTime.Now, Score = 2 }
            );
        }
    }

}
