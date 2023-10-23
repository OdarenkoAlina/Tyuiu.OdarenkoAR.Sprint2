using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.OdarenkoAR.Sprint2.Task4.V1.Lib;
namespace Tyuiu.OdarenkoAR.Sprint2.Task4.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCondition1()
        {
            DataService ds = new DataService();
            double x = 3;
            double y = 6;
            double res = ds.Calculate(x, y);
            double wait = 1;
            Assert.AreEqual(wait, res);
        }
        [TestMethod]
        public void ValidCondition2()
        {
            DataService ds = new DataService();
            double x = 4;
            double y = 1;
            double res = ds.Calculate(x, y);
            double wait = 2.5;
            Assert.AreEqual(wait, res);
        }
    }
}
