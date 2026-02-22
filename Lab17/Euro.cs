using System;
using System.Collections.Generic;
using System.Text;

namespace Lab17
{
    internal class Euro : Currency
    {
        public Euro() : base(0) { }
        public Euro(double value) : base(value) { }
        public override double toGRN()
        {
            return Data * 51;
        }

        public override string print()
        {
            return $"Значення в євро: {Data}";
        }
    }
}

