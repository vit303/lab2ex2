using lab2ex2;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestLab2
{
    [TestClass]
    public class DateTests
    {
        [TestMethod]
        public void ToString_ReturnsCorrectFormat()
        {
            
            var date = new Date
            {
                Day = 15,
                Month = 10,
                Year = 2023
            };

            
            var result = date.ToString();

            
            Assert.AreEqual("15/10/2023", result);
        }
    }

}
