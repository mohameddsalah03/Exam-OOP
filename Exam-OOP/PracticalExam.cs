using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_OOP
{
    public class PracticalExam : Exam
    {

        public PracticalExam(List<Question> questions)
        {
            Questions = questions ?? throw new ArgumentNullException(nameof(questions));
        }

        public override void ShowExam()
        {

            Console.WriteLine("=== Practical Exam ===");
            int totalMarks = 0;
            var stopwatch = new System.Diagnostics.Stopwatch();
            stopwatch.Start();

            foreach (Question question in Questions)
            {
                if (question is null) continue;

                if (stopwatch.Elapsed.TotalMinutes > Time)
                {
                    Console.WriteLine("Time is up!");
                    break;
                }

                
                Console.Write($" {question.Head} \tMark : {question.Mark}\n");
                Console.WriteLine($"{question.Body ?? "N0 Question Body Provided!"}");
                foreach (var answer in question.AnswerList)
                {
                    Console.WriteLine($"{answer.Id}. {answer.AnswerText ?? "No text provided"}");
                }
                Console.Write("Enter Your Answer: ");
                int.TryParse(Console.ReadLine(), out int userAnswerId);
                if (userAnswerId == question.RightAnswer?.Id)
                {
                    totalMarks += question.Mark;
                }
                Console.WriteLine($"Correct Answer: {question.RightAnswer?.AnswerText ?? "No correct answer"}");

            }
            stopwatch.Stop();
            Console.WriteLine($"Your Total Marks: {totalMarks}");
        }



    }
}
