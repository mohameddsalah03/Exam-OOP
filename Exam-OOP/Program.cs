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

            Console.WriteLine("Do u Want To Start A Exam : [Y/N]");
            if (char.Parse(Console.ReadLine().ToLower()) == 'y') ;
            {
                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();
                sub01.SubjectExam.ShowExam();
                Console.WriteLine($"The Elapsed Time : {stopwatch.Elapsed}");

            }
        }
    }
}
