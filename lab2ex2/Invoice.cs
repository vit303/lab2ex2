using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2ex2
{
    public class Invoice : Document //Накладная
    {
        public override string GetDocumentType()
        {
            return "Invoice";
        }

        public override void PrintDetails()
        {
            base.PrintDetails();
            Console.WriteLine("This is an invoice document.");
        }

        public override string ToString()
        {
            return base.ToString() + " - This is an invoice.";
        }
    }
}
