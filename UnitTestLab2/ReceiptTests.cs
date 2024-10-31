using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using lab2ex2
    ;
using System.IO;
namespace UnitTestLab2
{
    [TestClass]
    public class ReceiptTests
    {
        [TestMethod]
        public void ToString_ReturnsCorrectString()
        {
            
            var receipt = new Receipt
            {
                DocumentNumber = "R001",
                Date = new Date { Day = 11, Month = 11, Year = 2021 }
            };

            
            var result = receipt.ToString();

            
            Assert.IsTrue(result.Contains("Type: Receipt"));
            Assert.IsTrue(result.Contains("Number: R001"));
            Assert.IsTrue(result.Contains("Date: 11/11/2021"));
        }

        [TestMethod]
        public void PrintDetails_CorrectOutput()
        {
            
            var receipt = new Receipt
            {
                DocumentNumber = "R001",
                Date = new Date { Day = 11, Month = 10, Year = 2024 }
            };

            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);

                
                receipt.PrintDetails();

                
                var result = sw.ToString().Trim();
                Assert.IsTrue(result.Contains("Document Number: R001"));
                Assert.IsTrue(result.Contains("Date: 11/10/2024"));
                Assert.IsTrue(result.Contains("This is a receipt document."));
            }
        }
    }
}
