using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using WindowsFormsExample;

namespace WindowsFormsExample.Tests
{
    [TestClass]
    public class EncryptTest
    {
        [TestMethod]
        public void Encrypttest()
        {

            string expected = "svool";
            Atbash test_class = new Atbash();
            string actual = test_class.EncryptText("Hello");
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void Decryptest()
        {

            string expected = "hello";
            Atbash test_class = new Atbash();
           // string actual = test_class.EncryptDecrypt("svool", "abcdefghijklmnopqrstuvwxyz", "zyxwvutsrqponmlkjihgfedcba");
           // Assert.AreEqual(expected, actual);

        }
    }
}
