using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.PuzyrevIV.Sprint2.Task7.V7.Lib;

namespace Tyuiu.PuzyrevIV.Sprint2.Task6.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidPointInsideArea()
        {
            DataService ds = new DataService();

            Assert.IsTrue(ds.CheckPointInArea(-1, 0));

            Assert.IsTrue(ds.CheckPointInArea(-0.5, 0.5));
        }

        [TestMethod]
        public void ValidPointOnBoundaries()
        {
            DataService ds = new DataService();

            Assert.IsTrue(ds.CheckPointInArea(-2, -2));
            Assert.IsTrue(ds.CheckPointInArea(0, 0));
            Assert.IsTrue(ds.CheckPointInArea(-1, 1));
            Assert.IsTrue(ds.CheckPointInArea(0, 2));
        }

        [TestMethod]
        public void ValidPointOutsideArea()
        {
            DataService ds = new DataService();

            Assert.IsFalse(ds.CheckPointInArea(0, 3));      
            Assert.IsFalse(ds.CheckPointInArea(-1, 2));    

            Assert.IsFalse(ds.CheckPointInArea(-1, -2));   

            Assert.IsFalse(ds.CheckPointInArea(0.5, 0.5));  
            Assert.IsFalse(ds.CheckPointInArea(1, 1));     

            Assert.IsFalse(ds.CheckPointInArea(-3, -3));
            Assert.IsFalse(ds.CheckPointInArea(-3, 0));
        }
    }
}
