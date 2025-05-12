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
            Name = name ?? throw new ArgumentNullException(nameof(name));
        }



        public override string ToString()
            => $"Id : {Id} ,Name : {Name} ";

        public void CreateExam()
        {
            Console.WriteLine("Enter Type Of Exam [1 for Final, 2 for Practical]: ");
            int typeOfExam;
            while (!int.TryParse(Console.ReadLine(), out typeOfExam) || (typeOfExam != 1 && typeOfExam != 2))
            {
                Console.WriteLine("Invalid exam type. Please enter 1 for Final or 2 for Practical:");
            }

            Console.WriteLine("Enter Number Of Questions: ");
            int numQuestions;
            while (!int.TryParse(Console.ReadLine(), out numQuestions) || numQuestions <= 0)
            {
                Console.WriteLine("Invalid number. Please enter a positive number:");
            }

            Console.WriteLine("Enter Time For Exam (in minutes): ");
            int timeForExam;
            while (!int.TryParse(Console.ReadLine(), out timeForExam) || timeForExam <= 0)
            {
                Console.WriteLine("Invalid time. Please enter a positive number:");
            }


            List<Question> questions = new List<Question>();
            for (int i = 0; i < numQuestions; i++)
            {
                int questionType;
         
                if (typeOfExam == 1) // Final Exam
                {
                    Console.Write($"Enter The Type of Question [{i + 1}] => [1 for MCQ, 2 for True/False]: ");
                    while (!int.TryParse(Console.ReadLine(), out questionType) || (questionType != 1 && questionType != 2))
                    {
                        Console.WriteLine("Invalid question type. Please enter 1 for MCQ or 2 for True/False:");
                    }
                }
                else // Practical Exam
                {
                    Console.WriteLine($"Question [{i + 1}] is MCQ (only MCQ supported for Practical Exam).");
                    questionType = 1; // Force MCQ for Practical Exam
                }

                if (questionType == 1)
                {
                    MCQQuestion mcqQuestion = new MCQQuestion();
                    mcqQuestion.AddQuestion();
                    questions.Add(mcqQuestion);
                }
                else
                {
                    TrueFalseQuestion tfQuestion = new TrueFalseQuestion();
                    tfQuestion.AddQuestion();
                    questions.Add(tfQuestion);
                }
            }

            SubjectExam = typeOfExam == 1
                ? new FinalExam(questions) { Time = timeForExam, NumberOfQuestions = numQuestions }
                : new PracticalExam(questions) { Time = timeForExam, NumberOfQuestions = numQuestions };


        }





    }
}
