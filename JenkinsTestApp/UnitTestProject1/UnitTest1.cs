using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var testclass = new  JenkinsTestApp.Models.TestClass();
            //assert
            int expected = testclass.GetValue();
            int actual = 5;
           Assert.AreEqual(expected, actual, "fail");
        }
    }
    
}
