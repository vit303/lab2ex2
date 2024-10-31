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
    public class CheckTests
    {
        [TestMethod]
        public void ToString_ReturnsCorrectString()
        {
            
            var check = new Check
            {
                DocumentNumber = "C001",
                Date = new Date { Day = 12, Month = 12, Year = 2012 }
            };

            var result = check.ToString();

            Assert.IsTrue(result.Contains("Type: Check"));
            Assert.IsTrue(result.Contains("Number: C001"));
            Assert.IsTrue(result.Contains("Date: 12/12/2012"));
        }

        [TestMethod]
        public void PrintDetails_CorrectOutput()
        {
           
            var check = new Check
            {
                DocumentNumber = "C001",
                Date = new Date { Day = 12, Month = 12, Year = 2012 }
            };

            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                
                check.PrintDetails(); 

                var result = sw.ToString().Trim();
                Assert.IsTrue(result.Contains("Document Number: C001"));
                Assert.IsTrue(result.Contains("Date: 12/12/2012"));
                Assert.IsTrue(result.Contains("This is a check document."));
            }
        }
    }
}
