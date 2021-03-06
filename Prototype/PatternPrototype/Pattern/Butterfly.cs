﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternPrototype.Pattern
{
    class Butterfly : Prototype
    {
        public Butterfly(string name)
            : base(name)
        {
        }

        public override Prototype Clone()
        {
            return new Butterfly(Name);
        }
    }
}
