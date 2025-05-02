using IntegerValues;

namespace TestIntegerValue
{
    [TestClass]
    public sealed class TestInteger
    {
        [TestMethod]
        public void TestRound_ReturnCorrectRound()
        {
            //Arrange
            double a = 15.45;
            int expected = 15;

            //Act
            int actual = Integer.Round(a);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestRound_ThorwExeption()
        {
            //Arrange
            double a = 2147483648.0;

            //Act and Assert
            Assert.ThrowsException<OverflowException>(() => Integer.Round(a));
        }


        [TestMethod]
        public void TestIsEven_ReturnTrue()
        {
            //Arrange
            int a = 16;
            bool expected = true;

            //Act
            bool actual = Integer.IsEven(a);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestAbsolute_ReturnCorrectModel()
        {
            //Arrange
            int a = -16;
            int expected = 16;

            //Act
            int actual = Integer.Absolute(a);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestAbsolute_ThorwExeption()
        {
            int a = int.MinValue;

            //Act and Assert
            Assert.ThrowsException<OverflowException>(() => Integer.Absolute(a));
        }
    }
}
