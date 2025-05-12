using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_OOP
{
    public class TrueFalseQuestion : Question
    {
        public TrueFalseQuestion(string? body, int mark, Answer[] answerList, Answer rightAnswer)
            : base(body, mark, answerList, rightAnswer)
        {
            if (answerList.Length != 2 ||
                answerList[0].AnswerText != "true" ||
                answerList[1].AnswerText != "false")
            {
                throw new ArgumentException("TrueFalseQuestion must have exactly two answers: 'true' and 'false'.");
            }
        }

        public TrueFalseQuestion()
        {
            AnswerList = new Answer[2];
            AnswerList[0] = new Answer() { Id = 1, AnswerText = "true" };
            AnswerList[1] = new Answer() { Id = 2, AnswerText = "false" };
        }

        public override string Head { get; set; } = "True / False Question";


        public override void AddQuestion()
        {
            Console.WriteLine("Enter The Body Of Question: ");
            Body = Console.ReadLine() ?? string.Empty;

            Console.WriteLine("Enter The Mark Of Question: ");
            int mark;
            while (!int.TryParse(Console.ReadLine(), out mark) || mark <= 0)
            {
                Console.WriteLine("Invalid mark. Please enter a positive number:");
            }
            Mark = mark;

            Console.WriteLine("Enter The Right Answer [1 for True, 2 for False]: ");
            int rAnswer;
            while (!int.TryParse(Console.ReadLine(), out  rAnswer) || (rAnswer != 1 && rAnswer != 2))
            {
                Console.WriteLine("Invalid answer. Please select 1 for True or 2 for False:");
            }
            RightAnswer = AnswerList.FirstOrDefault(x => x.Id == rAnswer) 
                ?? throw new InvalidOperationException("Right answer not found.");


        }
    }
}
