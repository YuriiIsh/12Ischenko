using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Лабораторная_2
{
    [Serializable]
    class NumberGroupException : ApplicationException
    {
        public NumberGroupException() { }
        public NumberGroupException(string message) : base(message) { }
        public NumberGroupException(string message, Exception ex) : base(message) { }
        // Конструктор для обработки сериализации типа
        protected NumberGroupException(System.Runtime.Serialization.SerializationInfo info,
            System.Runtime.Serialization.StreamingContext contex)
            : base(info, contex) { }
    }
}
