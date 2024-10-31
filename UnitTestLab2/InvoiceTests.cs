using lab2ex2;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestLab2
{
    [TestClass]
    public class InvoiceTests
    {
        [TestMethod]
        public void ToString_ReturnsCorrectString()
        {
            
            var invoice = new Invoice
            {
                DocumentNumber = "I001",
                Date = new Date { Day = 13, Month = 3, Year = 2023 }
            };

        
            var result = invoice.ToString();

          
            Assert.IsTrue(result.Contains("Type: Invoice"));
            Assert.IsTrue(result.Contains("Number: I001"));
            Assert.IsTrue(result.Contains("Date: 13/3/2023"));
        }

        [TestMethod]
        public void PrintDetails_CorrectOutput()
        {
       
            var invoice = new Invoice
            {
                DocumentNumber = "I001",
                Date = new Date { Day = 13, Month = 3, Year = 2023 }
            };

            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);

               
                invoice.PrintDetails(); 

             
                var result = sw.ToString().Trim();
                Assert.IsTrue(result.Contains("Document Number: I001"));
                Assert.IsTrue(result.Contains("Date: 13/3/2023"));
                Assert.IsTrue(result.Contains("This is an invoice document."));
            }
        }
    }
}
