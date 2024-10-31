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
    public class OrganizationTests
    {
        [TestMethod]
        public void ToString_ReturnsCorrectString()
        {
            // Arrange
            var organization = new Organization
            {
                Name = "Ooorganization",
                Address = "123 Main Street"
            };

            // Act
            var result = organization.ToString();

            // Assert
            Assert.AreEqual("Organization: Ooorganization, Address: 123 Main Street", result);
        }
    }
}
