using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Лабораторная_2
{
    class Test:IDateAndCopy
    {
        public DateTime Born { get; set; }
        public string nameSubject { get; set; }
        public bool signExamination { get; set; }
        public Test(string nameSubject, bool signExamination , DateTime Date)
        {
            this.nameSubject = nameSubject;
            this.signExamination = signExamination;
           this.Born = Date;
        }
        public Test()
        {
            this.nameSubject = "Предмет не определен";
            this.signExamination = false;
            Born = new DateTime (2000, 1, 1);
        }
        public override string ToString()
        {
            base.ToString();
            return nameSubject + ", зачет: " + signExamination;
        }
        public object DeepCopy()
        {
            Test t = new Test();
            t.nameSubject = this.nameSubject;
           t.signExamination = this.signExamination;
           t.Born = this.Born;
            return t;
        }
    }
}
