using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.PuzyrevIV.Sprint2.Task6.V12.Lib;

namespace Tyuiu.PuzyrevIV.Sprint2.Task5.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidFindDateOfPreviousDay_LeapYear()
        {
            DataService ds = new DataService();

            Assert.AreEqual("2024-02-29", ds.FindDateOfPreviousDay(2024, 3, 1));
            Assert.AreEqual("2024-02-28", ds.FindDateOfPreviousDay(2024, 2, 29));
            Assert.AreEqual("2024-01-31", ds.FindDateOfPreviousDay(2024, 2, 1));
            Assert.AreEqual("2024-01-01", ds.FindDateOfPreviousDay(2024, 1, 2));
            Assert.AreEqual("2023-12-31", ds.FindDateOfPreviousDay(2024, 1, 1));
        }

        [TestMethod]
        public void ValidFindDateOfPreviousDay_NonLeapYear()
        {
            DataService ds = new DataService();

            Assert.AreEqual("2023-02-28", ds.FindDateOfPreviousDay(2023, 3, 1));
            Assert.AreEqual("2023-02-27", ds.FindDateOfPreviousDay(2023, 2, 28));
            Assert.AreEqual("2023-01-31", ds.FindDateOfPreviousDay(2023, 2, 1));
        }


        [TestMethod]
        public void InvalidInput_ReturnsErrorMessage()
        {
            DataService ds = new DataService();

            Assert.AreEqual("Некорректная дата", ds.FindDateOfPreviousDay(2023, 1, 0));
            Assert.AreEqual("Некорректная дата", ds.FindDateOfPreviousDay(2023, 13, 15));
            Assert.AreEqual("Некорректная дата", ds.FindDateOfPreviousDay(0, 6, 15));
        }
    }
}
