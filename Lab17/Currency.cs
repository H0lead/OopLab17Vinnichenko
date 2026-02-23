using System;
using System.Collections.Generic;
using System.Text;

namespace Lab17
{
    internal abstract class Currency
    {
        // Поле дата.
        private double data;

        // get, set.
        public double Data
        {
            get
            { return data; }
            set
            { data = value; }
        }

        // Конструктор.
        public Currency(double data)
        {
            this.data = data;
        }

        // Метод, який перетворює в гривні.
        public abstract double toGRN();
        
        // Метод для виведення.
        public abstract string print();
    }
}
