using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2ex2
{

    public class Receipt : Document //Квитанция
    {
        public override string GetDocumentType()
        {
            return "Receipt";
        }

        public override void PrintDetails()
        {
            base.PrintDetails();
            Console.WriteLine("This is a receipt document.");
        }

        public override string ToString()
        {
            return base.ToString() + " - This is a receipt.";
        }
    }
}
