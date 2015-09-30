using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Collections.Generic;

namespace Лабораторная_2
{
    class Student : Person
    {
        private readonly List<Exam> _passedExams = new List<Exam>();

        public List<Exam> PassedExams
        {
            get { return _passedExams; }
        }
        Education formOfEducation;
        public Education FormOfEducation // Формы Обучения
        {
            get
            {
                return formOfEducation;
            }
            set
            {
                formOfEducation = value;
            }
        }
        int numberGroup;
        public int NumberGroup // Номер группы
        {
            get
            {
                return numberGroup;
            }
            set
            {
                if (value <= 100 || value > 599)
                {
                    throw new NumberGroupException("ОШИБКА: номер группы должен быть в диапазоне от 101 до 599 включительно");
                }
                else
                    numberGroup = value;
            }
        }
        ArrayList tests;
        public ArrayList Tests
        {
            get
            {
                return tests;
            }
            set
            {
                tests = value;
            }
        }
        Exam[] exams;
        public Exam[] Exams
        {
            get
            {
                return exams;
            }
            set
            {
                exams = value;
            }
        }

        public int CountOfExams //количество экзаменов
        {
            get
            {
                return PassedExams.Count;
            }
            set
            {

                _passedExams.Capacity = value;
                             

            }

        }
        public Person ReturnThisPerson
        {
            get
            {
                //возвращаем объект типа Person с полями, равными полям текущего элемента Student
                return (Person)this.DeepCopy();
            }
            set
            {
                //задаем поля унаследованые от Person значениями из value
                this.Name = value.Name;
                this.Family = value.Family;
                this.Born = value.Born;
            }
        }
        public Exam def = new Exam();
        public Student(Person p, Education FormOfEducation, int NumberOfGroup)
        {
            Name = p.Name;
            Family = p.Family;
            Born = p.Born;
            this.FormOfEducation = FormOfEducation;
            this.NumberGroup = NumberOfGroup;
            tests = new ArrayList();
        }
        public Student()
            : base()
        {
            this.FormOfEducation = Education.Bachelor;
            this.NumberGroup = 101;
            tests = new ArrayList();
            PassedExams.Add(def);
        }
        public void AddExams(params Exam[] exams)
        {
            _passedExams.AddRange(exams);
        }
        public void AddTests(string nameSubject, bool signExamination, DateTime Date)
        {
            Tests.Add(new Test(nameSubject, signExamination, Date));
        }
        public override string ToString()
        {
            string Exams = "";
            string tests = "";
            foreach (Exam element in _passedExams)
            {
                Exams = Exams + "\n" + element;
            }
            for (int i = 0; i < this.Tests.Count; i++)
            {
                tests = tests + "\n"+ this.Tests[i].ToString();
            }
            return this.Name + " " + Family + " " + " Дата Рождения " + Born.Year.ToString() + "." + Born.Month.ToString() + "." + Born.Day.ToString() +
                " \nФорма образования " + FormOfEducation.ToString() + " № группы " + numberGroup + Exams + "\n" + tests ;



        }
        public override string ToShortString()
        {
            return Name + " " + Family + ", дата рождения:  " + Born.Day + "." + Born.Month + "." + Born.Year +
                "\nФорма обучения: " + FormOfEducation + ", номер группы: " + NumberGroup.ToString() +
                "\nСредний балл:" + Middlemark.ToString();
        }
        double sum = 0;
              public double Middlemark
        {
            get
            {

                if (PassedExams.Capacity != 0)
                {
                    for (int k = 0; k != _passedExams.Capacity; k++)
                    {

                        foreach (Exam i in PassedExams)
                        {

                            sum = sum + i.mark;

                        }
                    }
                       
                }

                double a = (sum / PassedExams.Capacity);
                if  (a > 5)
                {
                 a = 5;
                     return a;
            }
                else  {return a;}
            }
            set
            {
                sum = value;
            }
        }




        public object DeepCopy()
        {
            Student st = new Student();
            st.Name = this.Name;
            st.Family = this.Family;
            st.Born = this.Born;
            st.NumberGroup = this.numberGroup;
            st.FormOfEducation = this.formOfEducation;
            st.exams = this.exams;
            st.Tests = this.tests;
            st.Middlemark = this.Middlemark;
            return st;
        }
    }
}

