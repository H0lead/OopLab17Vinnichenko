using System;
using System.Collections.Generic;
using System.Text;

namespace Lab17
{
    internal abstract class Currency
    {
        private double data;

        public double Data
        {
            get
            { return data; }
            set
            { data = value; }
        }

        public Currency(double data)
        {
            this.data = data;
        }

        public abstract double toGRN();
        public abstract string print();
    }
}
