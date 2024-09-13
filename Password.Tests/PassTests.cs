using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Password.Tests
{
    [TestClass]
    public class PassTests  
    {

        [TestMethod]
        public void CheckPassword_OnlyDigits()
        {
            // arrange
            string password = "123456";
            int expected = 1;

            // act
            Pass checker = new Pass();
            int actual = checker.CheckPassword(password);

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CheckPassword_DigitsAndLowerCaseLetters()
        {
            // arrange
            string password = "abc123";
            int expected = 2;

            // act
            Pass checker = new Pass();
            int actual = checker.CheckPassword(password);

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CheckPassword_DigitsLowerUpperCaseLetters()
        {
            // arrange
            string password = "Abc123";
            int expected = 3;

            // act
            Pass checker = new Pass();
            int actual = checker.CheckPassword(password);

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CheckPassword_DigitsLowerUpperCaseLettersSpecialChar()
        {
            // arrange
            string password = "Abc123!";
            int expected = 4;

            // act
            Pass checker = new Pass();
            int actual = checker.CheckPassword(password);

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CheckPassword_AllConditionsMet()
        {
            // arrange
            string password = "Abc123!@#12345";
            int expected = 5;

            // act
            Pass checker = new Pass();
            int actual = checker.CheckPassword(password);

            // assert
            Assert.AreEqual(expected, actual);
        }
    }
}
