using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_OOP
{
    public abstract class Question
    {

        public abstract string Head { get; set; }
        public string Body { get; set; }
        public int Mark { get; set; }
        public Answer[] AnswerList { get; set; }
        public Answer RightAnswer { get; set; }

       

        protected Question()
        {
            AnswerList = Array.Empty<Answer>();

        }

        protected Question(string? body, int mark, Answer[] answerList, Answer rightAnswer)
        {
            Body = body;
            Mark = mark;
            AnswerList = answerList ?? throw new ArgumentNullException(nameof(answerList));
            RightAnswer = rightAnswer ?? throw new ArgumentNullException(nameof(rightAnswer));
        }



        public abstract void AddQuestion();


    }
}
