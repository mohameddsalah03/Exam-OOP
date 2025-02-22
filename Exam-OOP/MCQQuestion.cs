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
            Body = Console.ReadLine();

            Console.WriteLine("Enter The Mark Of Question : ");
            int.TryParse(Console.ReadLine(), out int mark);
            Mark = mark;


            Console.WriteLine("=== Choices Of Questions ===");
            Answer[] answers = new Answer[3];
            for (int i = 0; i < answers.Length; i++)
            {
                Console.WriteLine($"Enter Choice Of Number [{i + 1}] : ");
                answers[i] = new Answer(i + 1, Console.ReadLine());
            }
            AnswerList = answers;



            Console.WriteLine("Enter The Right Answer [ 1 | 2 | 3 ] : ");
            int.TryParse(Console.ReadLine(), out int rAnswer);

            RightAnswer = answers.FirstOrDefault(x => x.Id == rAnswer);

        }

    }
}
