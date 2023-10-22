using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.BeketovVN.Sprint3.Task3.V30.Lib;

namespace Tyuiu.BeketovVN.Sprint3.Task3.V30.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            string str = "fyyklbtyn ygrc vfyyyyh";
            char rpb = 'y';


            int res = ds.GetMaxCharCount(str, rpb);

            int wait = 4;

            Assert.AreEqual(wait, res);
        }
    }
}
