﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2ex2
{
    public class Organization
    {
        public string Name { get; set; }
        public string Address { get; set; }

        public override string ToString()
        {
            return $"Organization: {Name}, Address: {Address}";
        }
    }
}
