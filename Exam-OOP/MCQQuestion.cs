using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_OOP
{
    public class MCQQuestion : Question
    {
        public MCQQuestion(string? body, int mark, Answer[] answerList, Answer rightAnswer)
            : base(body, mark, answerList, rightAnswer)
        {
        }

        public MCQQuestion()
        {

        }

        public override string Head { get; set; } = "Mcq Question";

        public override void AddQuestion()
        {
            Console.WriteLine("Enter The Body Of Question : ");
            Body = Console.ReadLine() ?? string.Empty;

            Console.WriteLine("Enter The Mark Of Question : ");
            int mark;
            while(!int.TryParse(Console.ReadLine(), out mark) || mark <=0)
            {
                Console.WriteLine("Invalid mark. Please enter a positive number:");
            }
            Mark = mark;


            Console.WriteLine("=== Choices Of Questions ===");
            Answer[] answers = new Answer[3];
            for (int i = 0; i < answers.Length; i++)
            {
                Console.WriteLine($"Enter Choice Of Number [{i + 1}] : ");
                answers[i] = new Answer(i + 1, Console.ReadLine() ?? string.Empty);
            }
            AnswerList = answers;



            Console.WriteLine("Enter The Right Answer [ 1 | 2 | 3 ] : ");
            int rAnswer;
            while (!int.TryParse(Console.ReadLine(), out rAnswer) || rAnswer < 1 || rAnswer > 3)
            {
                Console.WriteLine("Invalid answer. Please select 1, 2, or 3:");
            }

            RightAnswer = answers.FirstOrDefault(x => x.Id == rAnswer) 
                ?? throw new InvalidOperationException("Right answer not found."); 

        }

    }
}
