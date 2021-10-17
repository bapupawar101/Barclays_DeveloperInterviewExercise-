using FileData;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class VersionTestCases
    {
        [TestMethod]
        public void TestCase1()
        {
            MyClass myClass = new MyClass();
            string outputString = myClass.GetOutput(new string[] { "-v", "C:/test.txt" });

            Assert.AreEqual(true, outputString.ToLower().Contains("version"));
        }

        [TestMethod]
        public void TestCase2()
        {
            MyClass myClass = new MyClass();
            string outputString = myClass.GetOutput(new string[] { "--v", "C:/test.txt" });

            Assert.AreEqual(true, outputString.ToLower().Contains("version"));
        }

        [TestMethod]
        public void TestCase3()
        {
            MyClass myClass = new MyClass();
            string outputString = myClass.GetOutput(new string[] { "/v", "C:/test.txt" });

            Assert.AreEqual(true, outputString.ToLower().Contains("version"));
        }

        [TestMethod]
        public void TestCase4()
        {
            MyClass myClass = new MyClass();
            string outputString = myClass.GetOutput(new string[] { "--version", "C:/test.txt" });

            Assert.AreEqual(true, outputString.ToLower().Contains("version"));
        }

        [TestMethod]
        public void TestCase5()
        {
            MyClass myClass = new MyClass();
            string outputString = myClass.GetOutput(new string[] { "invalid_version_key", "C:/test.txt" });

            Assert.AreEqual(true, outputString.ToLower().Contains("please enter valid inputs"));
        }
    }
}
