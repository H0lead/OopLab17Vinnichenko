using System;
using System.Collections.Generic;
using System.Text;

namespace Lab17
{
    internal class Euro : Currency
    {
        // Конструктор за замовчуванням.
        public Euro() : base(0) { }

        // Конструктор на основі базового. 
        public Euro(double value) : base(value) { }

        // Метод, який перетворює в гривні.
        public override double toGRN()
        {
            return Data * 51;
        }

        // Метод для виведення.
        public override string print()
        {
            return $"Значення в євро: {Data}";
        }
    }
}

