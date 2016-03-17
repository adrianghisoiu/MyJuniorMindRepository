﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PasswordGenerator
{
    [TestClass]
    public class PasswordGenerator
    {
        [TestMethod]
        public void TestForSmallLetters()
        {
            Assert.AreEqual(6, CountLowerCaseLetters(GeneratePassword(6)));
        }

        [TestMethod]
        public void TestForCountLowerCaseLetters()
        {
            Assert.AreEqual(3, CountLowerCaseLetters("abc"));
        }

        [TestMethod]
        public void TestForUpperCaseLetters()
        {
            var actual = GeneratePassword(6, 3);
            Assert.AreEqual(3, CountUpperCaseLetters(actual));
            Assert.AreEqual(6, actual.Length);
        }

        [TestMethod]
        public void TestForNumbers()
        {
            Assert.AreEqual(2, CountNumbers(GeneratePassword(6, 2, 2)));
        }

        private static string GeneratePassword(int passwordLength, int upperNumber=0, int number = 0)
        {
            Random rand = new Random();
            string myString = CharactersGenerator(passwordLength - upperNumber, rand, 'a', 'z')
                + CharactersGenerator(upperNumber, rand, 'A', 'Z')
                + CharactersGenerator(number, rand, '0', '9');
            return myString;
        }

        private static string CharactersGenerator(int number, Random rand, char first, char second)
        {
            char c = (char)0;
            string myString = null;
            for (int i = 0; i < number; i++)
            {
                c = (char)(rand.Next(first, second));
                myString += c.ToString();
            }

            return myString;
        }

        int CountLowerCaseLetters(string myString)
        {
            return CountCharacters(myString, 'a', 'z');
        }

        int CountUpperCaseLetters(string myString)
        {
            return CountCharacters(myString, 'A', 'Z');
        }

        int CountNumbers(string myString)
        {
            return CountCharacters(myString, '0', '9');
        }

        private static int CountCharacters(string myString, char first, char second)
        {
            int contor = 0;
            for (int i = 0; i < myString.Length; i++)
                if (myString[i] >= first && myString[i] <= second)
                    contor++;

            return contor;
        }
    }
}
