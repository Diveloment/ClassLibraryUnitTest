using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ClassLibrary2;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int a = 10;
            int b = 20;
            int expected = 200;

            Geometry g = new Geometry();
            int actual = g.Rect(a, b);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod2()
        {
            string password = "/P@ssw0rd/";
            int expected = 5;

            PasswordChecker checker = new PasswordChecker();
            int actual = checker.PswdStrench(password);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod3Fail()
        {
            string password = "Passw0rd";
            int expected = 5;

            PasswordChecker checker = new PasswordChecker();
            int actual = checker.PswdStrench(password);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void OperationsAdd()
        {
            int a = 5;
            int b = 7;
            int expected = 12;

            MathOperations opr = new MathOperations();
            int actual = opr.Add(a, b);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void OperationsSub()
        {
            int a = 5;
            int b = 7;
            int expected = -2;

            MathOperations opr = new MathOperations();
            int actual = opr.Sub(a, b);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void OperationsMul()
        {
            int a = 5;
            int b = 7;
            int expected = 35;

            MathOperations opr = new MathOperations();
            int actual = opr.Mul(a, b);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void OperationsDiv()
        {
            int a = 15;
            int b = 3;
            int expected = 5;

            MathOperations opr = new MathOperations();
            int actual = opr.Div(a, b);

            Assert.AreEqual(expected, actual);
        }
    }
}
