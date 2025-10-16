using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.PuzyrevIV.Sprint2.Task5.V11.Lib;


namespace Tyuiu.PuziIV.Sprint2.Task5.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidFindDateOfNextDay()
        {
            DataService ds = new DataService();

            Assert.AreEqual("2023-01-02", ds.FindDateOfNextDay(2023, 1, 1));
            Assert.AreEqual("2023-02-01", ds.FindDateOfNextDay(2023, 1, 31));
            Assert.AreEqual("2023-03-01", ds.FindDateOfNextDay(2023, 2, 28)); 
            Assert.AreEqual("2023-04-01", ds.FindDateOfNextDay(2023, 3, 31));
            Assert.AreEqual("2023-05-01", ds.FindDateOfNextDay(2023, 4, 30));
            Assert.AreEqual("2023-12-31", ds.FindDateOfNextDay(2023, 12, 30));
            Assert.AreEqual("2024-01-01", ds.FindDateOfNextDay(2023, 12, 31));

        }

        [TestMethod]
         public void InvalidInput_ReturnsErrorMessage()
         {
            DataService ds = new DataService();

            Assert.AreEqual("Некорректная дата", ds.FindDateOfNextDay(2023, 1, 32));  
            Assert.AreEqual("Некорректная дата", ds.FindDateOfNextDay(2023, 0, 15));   
            Assert.AreEqual("Некорректная дата", ds.FindDateOfNextDay(0, 6, 15));      
         }
    }
}
