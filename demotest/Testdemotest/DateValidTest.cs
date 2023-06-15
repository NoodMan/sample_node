using demotest;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static demotest.DateValid;

namespace Testdemotest
{
    [TestClass]
    public class DateValidTest
    {
        private DateValid dateValid;

        [TestInitialize]
        public void TestInitialize()
        {
            dateValid = new DateValid();
        }

        [TestMethod]
        public void IsDateValid_NullOrWhiteSpace_ReturnsFalse()
        {
            string date = null;

            bool result = dateValid.IsDateValid(date);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void IsDateValid_TryParse_ReturnsFalse()
        {
            string date = "ae/ab/2023";

            bool result = dateValid.IsDateValid(date);

            Assert.IsFalse(result);
        }
        [TestMethod]
        [DataRow("32-01-2022")]
        [DataRow("00-01-2022")]
        [DataRow("29-02-2022")]
        public void IsDateValid_InvalidDay_ReturnsFalse(string date)
        {
            bool result = dateValid.IsDateValid(date);

            Assert.IsFalse(result);
        }
        [TestMethod]
        [DataRow("01-00-2022")]
        [DataRow("01-13-2022")]
        public void IsDateValid_InvalidMonth_ReturnsFalse(string date)
        {
            bool result = dateValid.IsDateValid(date);

            Assert.IsFalse(result);
        }



        [TestMethod]
        [DataRow("01-01-1999")]
        [DataRow("01-01-2100")]
        public void IsDateValid_InvalidYear_ReturnsFalse(string date)
        {
            bool result = dateValid.IsDateValid(date);

            Assert.IsFalse(result);
        }

        [TestMethod]
        [DataRow("20-07-2023")]
        [DataRow("23-03-2022")]
        [DataRow("28-02-2022")]
        public void IsDateValid_ValidDates_ReturnsTrue(string date)
        {
            bool result = dateValid.IsDateValid(date);

            Assert.IsTrue(result);
        }
    }
}
