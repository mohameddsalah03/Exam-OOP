using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_OOP
{
    public class Subject
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Exam SubjectExam { get; set; }

        public Subject()
        {

        }

        public Subject(int id, string name)
        {
            Id = id;
            Name = name;
        }


        public override string ToString()
            => $"Id : {Id} ,Name : {Name} ";

        public void CreateExam()
        {
            Console.WriteLine("Enter Type Of Exam [1 for Final ,2 For Practical ] : ");
            int.TryParse(Console.ReadLine(), out int TypeOfExam);

            Console.WriteLine("Enter Number Of Questions : ");
            int.TryParse(Console.ReadLine(), out int numQuestions);

            Console.WriteLine("Enter Time For Exam : ");
            int.TryParse(Console.ReadLine(), out int TimeForExam);

            List<Question> questions = new List<Question>();
            for (int i = 0; i < numQuestions; i++)
            {
                Console.Write($"Enter The Type of Question [{i + 1}] => [1 for MCQ, 2 for True/False]: ");
                int.TryParse(Console.ReadLine(), out int questionType);


                if (questionType == 1)
                {
                    MCQQuestion mcqquestion = new MCQQuestion();
                    mcqquestion.AddQuestion();
                    questions.Add(mcqquestion);
                }
                else if (questionType == 2)
                {
                    TrueFalseQuestion tFquestion = new TrueFalseQuestion();
                    tFquestion.AddQuestion();
                    questions.Add(tFquestion);
                }

            }


            if (TypeOfExam == 1)
            {
                SubjectExam = new FinalExam(questions) { Time = TimeForExam, NumberOfQuestions = numQuestions };
            }
            else
            {
                SubjectExam = new PracticalExam(questions) { Time = TimeForExam, NumberOfQuestions = numQuestions };
            }


        }





    }
}
