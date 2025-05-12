using System.Diagnostics;

namespace Exam_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Subject sub01 = new Subject(10, "C#");
            sub01.CreateExam();
            Console.Clear();


            Console.WriteLine("Do u Want To Start A Exam ? : [Y/N]");
            string input = Console.ReadLine()?.ToLower();
            if (input == "y") 
            {
                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();
                sub01.SubjectExam.ShowExam();
                stopwatch.Stop();
                Console.WriteLine($"The Elapsed Time : {stopwatch.Elapsed}");

            }
        }
    }
}
