using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Лабораторная_2
{
    enum Education
    {
        Specialist,Bachelor,SecondEducation
    };
    class Person:IDateAndCopy
    {
        Random r = new Random();
        string name;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        string family;
        public string Family
        {
            get
            {
                return family;
            }
            set
            {
                family = value;
            }
        }
        DateTime date;
        public DateTime Born
        {
            get
            {
                return date;
            }
            set
            {
                date = value;
            }
        }
        int ChangeDateYear
        {
            get
            {
                return Born.Year;
            }
            set
            {
                Born = new DateTime(value, Born.Month, Born.Day);
            }
        }
        public Person(string name, string family, DateTime date)
        {
            this.Name = name;
            this.Family = family;
            this.Born = date;

            HashCodeGeneration();
        }
        public Person()
        {
            Name = "Иван";
            Family = "Иванов";
            Born = new DateTime(1995, 2, 3);

            HashCodeGeneration();
        }

        public void HashCodeGeneration() //генерация хэш-кода
        {
            if (Program.HashCode[this.Name] == null)
                Program.HashCode[this.Name] = r.Next(100000);
            if (Program.HashCode[this.Family] == null)
                Program.HashCode[this.Family] = r.Next(100000);
            if (Program.HashCode[this.Born] == null)
                Program.HashCode[this.Born] = r.Next(100000);
        }

        public override string ToString()
        {
            base.ToString();
            return Name + " " + Family + " Дата рождения: " + Born.Day + "." + Born.Month + "." + Born.Year;
        }
        public virtual string ToShortString()
        {
            return Name + " " + Family;
        }

        public override bool Equals(object obj)
        {
            base.Equals(obj);
            if (obj == null)
                return false;
            Person p = obj as Person;
            return this == p;
        }
        public override int GetHashCode()
        {
            base.GetHashCode();
            return (int)Program.HashCode[this.Name] + (int)Program.HashCode[this.Family] + (int)Program.HashCode[this.Born];
        }
        public object DeepCopy()
       {
           Person p = new Person();
           p.Name = this.Name;
          p.Family = this.Family;
            p.Born = this.Born;
          return p;
        }
        public static bool operator == (Person a,Person b)
        {
            if (a.Name == b.Name && a.Family == b.Family && a.Born == b.Born)
                    return true;
                return false;
        }
        public static bool operator != (Person a, Person b)
        {
            if (a.Name != b.Name || a.Family != b.Family || a.Born != b.Born)
                    return true;
                return false;
        }
    }
}
