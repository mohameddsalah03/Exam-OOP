using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_OOP
{
    public class FinalExam : Exam
    {
        public FinalExam(List<Question> questions)
        {
            Questions = questions;
        }

        public override void ShowExam()
        {
            Console.WriteLine("=== Final Exam ===");
            foreach (Question question in Questions)
            {

                Console.Write($" {question.Head} \tMark : {question.Mark}");
                Console.WriteLine("\n"+question.Body);
                foreach (var answer in question.AnswerList)
                {
                    Console.WriteLine(answer.Id + ". " + answer.AnswerText);
                }
                Console.Write("Enter Ur Answer : ");
                string userAnswer = Console.ReadLine();
                Console.WriteLine($"Correct Answer : {question.RightAnswer.AnswerText}");

            }

        }
    }
}
