using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_OOP
{
    public class Answer
    {

        public int Id { get; set; }
        public string? AnswerText { get; set; }

        public Answer(int Id, string? answerText)
        {
            this.Id = Id;
            AnswerText = answerText;
        }

        public Answer()
        {

        }

        public override string ToString()
            => $"Answer Id : {Id} , Answer Text : {AnswerText ?? "No Answer!"}";


    }
}
