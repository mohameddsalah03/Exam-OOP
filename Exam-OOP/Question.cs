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
        }

        protected Question(string? body, int mark, Answer[] answerList, Answer rightAnswer)
        {
            Body = body;
            Mark = mark;
            AnswerList = answerList;
            RightAnswer = rightAnswer;
        }

        

        public abstract void AddQuestion();




    }
}
