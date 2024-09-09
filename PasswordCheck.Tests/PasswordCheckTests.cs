using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Password.Tests
{
    [TestClass]
    public class PasswordCheckTests
    {
        [TestMethod]
        public void Checker_Digits_1()
        {
            //arrange
            int expected = 1;
            string password = "1111";
            //act
            int actual = PasswordCheck.Checker(password);
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Checker_DigitsLower_2()
        {
            //arrange
            int expected = 2;
            string password = "aaaa1111";
            //act
            int actual = PasswordCheck.Checker(password);
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Checker_DigitsLowerUpper_3()
        {
            //arrange
            int expected = 3;
            string password = "aaAA11";
            //act
            int actual = PasswordCheck.Checker(password);
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Checker_DigitsLowerUpperSymbols_4()
        {
            //arrange
            int expected = 4;
            string password = "aaAA11!!";
            //act
            int actual = PasswordCheck.Checker(password);
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Checker_DigitsLowerUpperSymbolsLength_5()
        {
            //arrange
            int expected = 5;
            string password = "aaAA11!!aaAA11!!";
            //act
            int actual = PasswordCheck.Checker(password);
            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
