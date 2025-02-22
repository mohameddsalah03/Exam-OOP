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
            Console.WriteLine("Enter The Body Of Question : ");
            Body = Console.ReadLine();

            Console.WriteLine("Enter The Mark Of Question : ");
            int.TryParse(Console.ReadLine(), out int mark);
            Mark = mark;


            Console.WriteLine("Enter The Right Answer [ 1 for True , 2 For Flase] : ");
            int.TryParse(Console.ReadLine(), out int rAnswer);


            RightAnswer = AnswerList.FirstOrDefault(x => x.Id == rAnswer);



        }
    }
}
