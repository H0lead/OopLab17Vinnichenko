using System;
using System.Collections.Generic;
using System.Security.AccessControl;
using System.Text;

namespace Lab17
{
    internal class Dollar : Currency
    {
        public Dollar() : base(0) { }
        public Dollar(double value) : base(value) { }

        public override double toGRN()
        {
            return Data * 43;
        }

        public override string print()
        {
            return $"Значення в долларах: {Data}";
        }
    }
}
