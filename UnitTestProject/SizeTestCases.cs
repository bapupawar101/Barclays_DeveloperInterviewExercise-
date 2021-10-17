using FileData;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class SizeTestCases
    {
        [TestMethod]
        public void TestCase1()
        {
            MyClass myClass = new MyClass();
            string outputString = myClass.GetOutput(new string[] { "-s", "C:/test.txt" });

            Assert.AreEqual(true, outputString.ToLower().Contains("size"));
        }

        [TestMethod]
        public void TestCase2()
        {
            MyClass myClass = new MyClass();
            string outputString = myClass.GetOutput(new string[] { "--s", "C:/test.txt" });

            Assert.AreEqual(true, outputString.ToLower().Contains("size"));
        }

        [TestMethod]
        public void TestCase3()
        {
            MyClass myClass = new MyClass();
            string outputString = myClass.GetOutput(new string[] { "/s", "C:/test.txt" });

            Assert.AreEqual(true, outputString.ToLower().Contains("size"));
        }

        [TestMethod]
        public void TestCase4()
        {
            MyClass myClass = new MyClass();
            string outputString = myClass.GetOutput(new string[] { "--size", "C:/test.txt" });

            Assert.AreEqual(true, outputString.ToLower().Contains("size"));
        }

        [TestMethod]
        public void TestCase5()
        {
            MyClass myClass = new MyClass();
            string outputString = myClass.GetOutput(new string[] { "invalid_size_key", "C:/test.txt" });

            Assert.AreEqual(true, outputString.ToLower().Contains("please enter valid inputs"));
        }
    }
}
