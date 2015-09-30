using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Лабораторная_2
{
    interface IDateAndCopy
    {
        object DeepCopy();
        DateTime Born { get; set; }
    }
}
