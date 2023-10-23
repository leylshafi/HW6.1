using HW6._1.Models;

namespace HW6._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // TASK 1
           List<Person> people= new List<Person>()
           {
               new Person("Leyla","Shafiyeva",19),
               new Person("Adil","Nasirli",18),
               new Person("Nigar","Shafiyeva",17),
               new Person("Murad","Shafizada",10),
               new Person("Leyla","Aslanova",22),
               new Person("Karim","Karimov",23),
           };
            //a
            //foreach (Person person in people.FindAll(p => p.Name == "Leyla"))
            //{
            //    Console.WriteLine(person);
            //}

            //b
            //foreach (Person person in people.FindAll(p=>p.Surname.EndsWith("ova")|| p.Surname.EndsWith("ov")))
            //{
            //    Console.WriteLine(person);
            //}

            //c
            //foreach (Person person in people.FindAll(p=>p.Age>=20))
            //{
            //    Console.WriteLine(person);
            //}

            // TASK 2
            List<Exam> exams = new List<Exam>();
            exams.Add(new Exam("Math", 2));
            exams.Add(new Exam("English", 1));
            exams.Add(new Exam("Informatics", 3));
            exams.Add(new Exam("Logic", 4));

            //foreach (Exam e in exams.FindAll(e => DateTime.Now.Subtract(e.StartDate).TotalDays<=7) )
            //{
            //    Console.WriteLine(e);
            //}

            //foreach (Exam e in exams.FindAll(e=>e.ExamDuration>=2))
            //{
            //    Console.WriteLine(e);
            //}

            //foreach (Exam e in exams.FindAll(e => e.EndDate>DateTime.Now))
            //{
            //    Console.WriteLine(e);
            //}



        }
    }
}