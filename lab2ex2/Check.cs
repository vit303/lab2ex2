using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2ex2
{
    public class Check : Document
    {
        public override string GetDocumentType()
        {
            return "Check";
        }

        public override void PrintDetails()
        {
            base.PrintDetails();
            Console.WriteLine("This is a check document.");
        }

        public override string ToString()
        {
            return base.ToString() + " - This is a check.";
        }
    }
}
