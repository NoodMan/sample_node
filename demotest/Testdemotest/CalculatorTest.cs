using demotest;

namespace Testdemotest
{
    [TestClass]
    public class CalculatorTest
    {
        public Calculator calculator;

        [TestInitialize]
        public void TestInitialize()
        {
            calculator = new Calculator();
        }


        [TestMethod]
        [DataRow(3, 3, 6)]
        [DataRow(5, 5, 10)]
        public void Add(double numberOne, double numberTwo, double result)
        {

 
            double actualresult = calculator.Add(numberOne, numberTwo);

            Assert.AreEqual(result, actualresult);
        }

        [TestMethod]
        [DataRow(6, 3, 3)]
        [DataRow(10, 5, 5)]
        public void Substract(double numberOne, double numberTwo, double result)
        {


            double actualresult = calculator.Subtract(numberOne, numberTwo);

           
            Assert.AreEqual(result, actualresult);
        }
        [TestMethod]
        [DataRow(6, 3, 2)]
        [DataRow(10, 5, 2)]
        public void Divide(double numberOne, double numberTwo, double result)
        {


            double actualresult = calculator.Divide(numberOne, numberTwo);

            Assert.AreEqual(result, actualresult);
        }


        [TestMethod]
        [DataRow(6, 0)]
        [DataRow(10, 0)]
        public void Divide_ByZero(double numberOne, double numberTwo)
        {
            Assert.ThrowsException<DivideByZeroException>(() => calculator.Divide(numberOne, numberTwo));
        }

        [TestMethod]
        [DataRow(6, 3, 18)]
        [DataRow(10, 5, 50)]
        public void Multiply(double numberOne, double numberTwo, double result)
        {


            double actualresult = calculator.Multiply(numberOne, numberTwo);


            Assert.AreEqual(result, actualresult);
        }
    }
}