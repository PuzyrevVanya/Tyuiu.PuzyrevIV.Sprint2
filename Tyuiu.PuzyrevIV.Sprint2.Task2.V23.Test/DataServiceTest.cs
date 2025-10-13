using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.PuzyrevIV.Sprint2.Task2.V23.Lib;

namespace Tyuiu.PuzyrevIV.Sprint2.Task2.V23.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCheckDotInShadeArea()
        {
            DataService ds = new DataService();
            int x = 4;
            int y = 5;
            
            bool res = ds.CheckDotInShadedArea(x, y);
            bool wait = true;

            Assert.AreEqual(wait, res);
        }
    }
}
