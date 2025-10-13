using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.PuzyrevIV.Sprint2.Task0.V5.Lib;

namespace Tyuiu.PuzyrevIV.Sprint2.Task0.V5.Test
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void ValidGetCompareOperations()
        {
            DataService ds = new DataService();
            int x = 105;
            int y = 223;
            bool[] res = new bool[6];
            res = ds.GetCompareOperations(x, y);
            bool[] wait = new bool[6] { false, true, true, true, false, true };

            CollectionAssert.AreEqual(wait, res);
        }
    }
}
