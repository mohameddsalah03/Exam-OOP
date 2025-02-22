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
            Questions = questions;
        }

        public override void ShowExam()
        {

            Console.WriteLine("=== Practical Exam ===");
            foreach (Question question in Questions)
            {
                if (question is MCQQuestion)
                {
                    Console.Write($" {question.Head} \tMark : {question.Mark}\n");
                    Console.WriteLine(question.Body);
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
}
