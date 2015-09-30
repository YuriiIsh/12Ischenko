using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Лабораторная_2
{
    class Exam:IDateAndCopy
    {
        public string nameSubject { get; set; }
        public int mark { get; set; }
        public DateTime Born { get; set; }
        public Exam(string nameSubject, int mark, DateTime Date)
        {
            this.nameSubject = nameSubject;
            this.mark = mark;
            this.Born = Date;
        }
        public Exam()
        {
            this.nameSubject = "Хохлятский";
            this.mark = 4;
            this.Born = new DateTime(2013,1,2);
        }
        public override string ToString()
        {
            base.ToString();
            return nameSubject +  ", оценка: " + mark + ", дата: "+ Born.Day + "." + Born.Month + "." + Born.Year;
        }
        public object DeepCopy()
        {
            Exam e = new Exam();
            e.nameSubject = this.nameSubject;
            e.mark = this.mark;
            e.Born = this.Born;
            return e;
        }
    }
}
