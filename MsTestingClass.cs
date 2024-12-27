using Microsoft.VisualStudio.TestPlatform.TestHost;
using MS_Testing_practice;
namespace Testing_With_MS_Testing
{
    [TestClass]
    public class MsTestingClass
    {
        private MSTestingDemo demo ;
        [TestInitialize]
        public void Setup()
        {
            demo = new MSTestingDemo();
        }
        [TestCategory("positive or negative")]
        [TestMethod]
        //Arrange
        [DataRow(2, true)]
        [DataRow(-3, false)]
        [DataRow(10, true)]
        [DataRow(20, true)]
        public void TestPositiveOrNegative(int data, bool expected)
        {
            //AAA methodology
            //Act
            bool actual = demo.PosOrNeg(data);

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestCategory("Sum of Natural Numbers")]
        [TestMethod]
        //Arrange
        [DataRow(18, 171)]
        [DataRow(11, 66)]
        [DataRow(5, 15)]
        [DataRow(15, 120)]
        public void TestSumOfNaturalNum(int data, int expected)
        {
            //Act
            int actual = demo.SumOfNaturalNum(data);

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestCategory("Sum of natural numbers in a give range")]
        [TestMethod]
        //Arrange
        [DataRow(1, 5, 15)]
        [DataRow(2, 6, 20)]
        public void TestSumOfNaturalNumbersInRange(int data1, int data2, int expected)
        {
            //Act
            int actual = demo.SumOfRange(data1, data2);

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestCategory("count vowels in a string")]
        [TestMethod]
        //Arrange
        [DataRow("Csharp", 1)]
        [DataRow("DotNet", 2)]
        [DataRow("Framework", 3)]
        public void TestReturnsTheVowelCount(string data,  int expected)
        {
            //Act
            int actual = demo.GetVowelCount(data);

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
