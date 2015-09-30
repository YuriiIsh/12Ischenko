using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Collections.Generic;

namespace Лабораторная_2
{
    class Program
    {
        public static Hashtable HashCode = new Hashtable();
        static void Main(string[] args)
        {
            // 1.
            Console.WriteLine("Задание 1");
           Student s1 = new Student();
             Console.WriteLine(s1.ToShortString());

            // 2.
            Console.WriteLine();
            Console.WriteLine("Задание 2");
            s1.Name = "Ванёк";
            s1.Family = "Тикканин";
            s1.Born = new DateTime(1997, 5, 2);
            s1.NumberGroup = 230;
            s1.FormOfEducation = Education.Specialist;
            Console.WriteLine(s1.ToShortString()); 
            
            // 3.
            Console.WriteLine();
            Console.WriteLine("Задание 3");
            Exam ooo=new Exam("Математика", 5, new DateTime(2010, 4, 3));
            Exam aaa = new Exam("Русский", 4, new DateTime(2010, 4, 3));
            s1.CountOfExams = 2;
            s1.AddExams(ooo);
            s1.AddExams(aaa);
            s1.AddTests("География", true, new DateTime(2010, 5, 1));
            Console.WriteLine(s1.ToString());

            // 4.
            Console.WriteLine();
            Console.WriteLine("Задание 4");
            Person p1 = new Person("Петюня", "Братанов", new DateTime(2005, 6, 7));
            Person p2 = new Person("Петюня", "Братанов", new DateTime(2005, 6, 7));
            Console.WriteLine("Хэш-код {0}: {1}\nХэш-код {2}: {3}", p1.ToString(), p1.GetHashCode(), p2.ToString(), p2.GetHashCode());
            // 5.
            Console.WriteLine();
            Console.WriteLine("Задание 5");
            Student s2 = new Student(new Person("Пацан", "Пацанский", new DateTime(2008, 3, 2)), Education.Bachelor, 240);
            s2.CountOfExams = 4;
            Exam a = new Exam("Философия", 3, new DateTime(2014, 4, 2));
            Exam b = new Exam("История", 5, new DateTime(2014, 4, 2));
            Exam c = new Exam("География", 3, new DateTime(2014, 4, 2));
            Exam d= new Exam ("Алгебра",4, new DateTime(2014, 4, 2));            
            s2.AddExams(a);
            s2.AddExams(b);
            s2.AddExams(c);
            s2.AddExams(d);
            s2.Tests.Add(new Test("Английский язык",false,new DateTime(2014,6,4)));
            s2.Tests.Add(new Test("Русский язык", true, new DateTime(2014, 6, 4)));
            Console.WriteLine(s2.ToString());

            // 6.
            Console.WriteLine();
            Console.WriteLine("Задание 6");
            Console.WriteLine(s2.ReturnThisPerson.ToString());

            // 7.
            Console.WriteLine();
            Console.WriteLine("Задание 7");
            Student s3 = (Student)s2.DeepCopy();
           // s2.Name = "Братуха";
            Console.WriteLine("Исходный измененный объект:\n {0}\n\nНовый объект, являющийся копией исходного неизмененного:\n {1}", s2.ToShortString(), s3.ToShortString());

            // 8.
            //s2.NumberGroup = 50;

            // 9.
            Console.WriteLine();
            Console.WriteLine("Задание 9");
            Console.WriteLine("Список экзаменов:");
            int k=1;
            foreach (Exam i in s2.PassedExams)
            {
                string Exams = "";
                 Exams = Exams  +  i;
                 Console.WriteLine("{0}) {1}", k,Exams.ToString());
                 k++;
            }
            Console.WriteLine("Список тестов:");
            k=1;
            foreach(Test i in s2.Tests)
            {
                Console.WriteLine("{0}) {1}", k, i.ToString());
                k++;
            }

            // 10.
            Console.WriteLine();
            Console.WriteLine("Задание 10");
            Console.WriteLine("Список экзаменов,оценка которых выше 3:");
            k = 1;
            foreach (Exam i in s2.PassedExams)
            {
                if (i.mark > 3)
                {
                    Console.WriteLine("{0}) {1}", k, i.ToString());
                    k++;
                }
            }
            Console.Read();
        }
    }
}
