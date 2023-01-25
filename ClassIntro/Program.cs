using System;
using System.Reflection.Metadata;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Engin";
            int age = 17;

            Kurs kurs1 = new Kurs();
            kurs1.CourseName = "C#";
            kurs1.Instructor = "Engin Demiroğ";
            kurs1.ViewsRate = 68;

            Kurs kurs2 = new Kurs();
            kurs2.CourseName = "Java";
            kurs2.Instructor = "Kerem Varış";
            kurs2.ViewsRate = 64;

            Kurs kurs3 = new Kurs();
            kurs3.CourseName = "Python";
            kurs3.Instructor = "Berkay Bilgin";
            kurs3.ViewsRate = 80;

            Kurs[] kurslar = new Kurs[] {
                kurs1, 
                kurs2,
                kurs3
            };

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.CourseName + " : " + kurs.Instructor);
            }

        }
    }

    class Kurs
    {
        public string CourseName { get; set; }
        public string Instructor { get; set; }
        public int ViewsRate { get; set; }
    }

}