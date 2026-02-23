using System;
using System.Collections.Generic;
using System.Security.AccessControl;
using System.Text;

namespace Lab17
{
    internal class Dollar : Currency
    {
     
        // Конструктор за замовчуванням.
        public Dollar() : base(0) { }
        // Конструктор на основі базового. 
        public Dollar(double value) : base(value) { }

        // Метод, який перетворює в гривні.
        public override double toGRN()
        {
            return Data * 43;
        }

        // Метод для виведення.
        public override string print()
        {
            return $"Значення в долларах: {Data}";
        }
    }
}
