using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.BeketovVN.Sprint3.Task1.V17.Lib;

namespace Tyuiu.BeketovVN.Sprint3.Task1.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMultiplySeries()
        {
            DataService ds = new DataService();

            int startValue = 1;
            int stopValue = 4;
            int value = 1;

            double res = ds.GetMultiplySeries(value, startValue, stopValue);
            double wait = 482982.891;
            Assert.AreEqual(wait, res);
        }
    }
}
