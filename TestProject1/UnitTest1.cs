using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SDM_Compulsory_Assignment;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            ILogicHandler logic = new LogicHandler();

            Console.WriteLine(logic.getReviews());
        }
    }
}