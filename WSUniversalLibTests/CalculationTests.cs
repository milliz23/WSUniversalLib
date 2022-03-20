using Microsoft.VisualStudio.TestTools.UnitTesting;
using WSUniversalLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WSUniversalLib.Tests
{
    [TestClass()]
    public class CalculationTests
    {
        [TestMethod()]
        public void GetQuantityForProductTest()
        {
            int rez = 114148;
            Calculation calculation = new Calculation();
            int fak = calculation.GetQuantityForProduct(3, 1, 15, 20, 45);
            Assert.AreEqual(rez, fak);
        }
        [TestMethod()]
        public void GetQuantityForProductTest2()
        {
            int rez = 339;
            Calculation calculation = new Calculation();
            int fak = calculation.GetQuantityForProduct(3, 1, 5, 4, 2);
            Assert.AreEqual(rez, fak);
        }
        [TestMethod()]
        public void GetQuantityForProductTest3()
        {
            int rez = 227;
            Calculation calculation = new Calculation();
            int fak = calculation.GetQuantityForProduct(2, 2, 6, 3, 5);
            Assert.AreEqual(rez, fak);
        }
        [TestMethod()]
        public void GetQuantityForProductTest4()
        {
            int rez = 155;
            Calculation calculation = new Calculation();
            int fak = calculation.GetQuantityForProduct(1, 1, 5, 4, 7);
            Assert.AreEqual(rez, fak);
        }
        [TestMethod()]
        public void GetQuantityForProductTest5()
        {
            int rez = 199;
            Calculation calculation = new Calculation();
            int fak = calculation.GetQuantityForProduct(1, 1, 6, 5, 6);
            Assert.AreEqual(rez, fak);
        }
        [TestMethod()]
        public void GetQuantityForProductTest6()
        {
            int rez = 1787;
            Calculation calculation = new Calculation();
            int fak = calculation.GetQuantityForProduct(3, 2, 7, 5, 6);
            Assert.AreEqual(rez, fak);
        }
        [TestMethod()]
        public void GetQuantityForProductTest7()
        {
            int rez = 422;
            Calculation calculation = new Calculation();
            int fak = calculation.GetQuantityForProduct(2, 1, 7, 4, 6);
            Assert.AreEqual(rez, fak);
        }
        [TestMethod()]
        public void GetQuantityForProductTest8()
        {
            int rez = 40;
            Calculation calculation = new Calculation();
            int fak = calculation.GetQuantityForProduct(1, 2, 2, 3, 6);
            Assert.AreEqual(rez, fak);
        }
        [TestMethod()]
        public void GetQuantityForProductTest9()
        {
            int rez = 68;
            Calculation calculation = new Calculation();
            int fak = calculation.GetQuantityForProduct(2, 1, 3, 3, 3);
            Assert.AreEqual(rez, fak);
        }
        [TestMethod()]
        public void GetQuantityForProductTest10()
        {
            int rez = 350;
            Calculation calculation = new Calculation();
            int fak = calculation.GetQuantityForProduct(1, 2, 5, 9, 7);
            Assert.AreEqual(rez, fak);
        }
        [TestMethod()]
        public void GetQuantityForProductTestHard()
        {
            int rez = 2099;
            Calculation calculation = new Calculation();
            int fak = calculation.GetQuantityForProduct(2, 1, 93, 3, 3);
            Assert.AreEqual(rez, fak);
        }
        [TestMethod()]
        public void GetQuantityForProductTestHard2()
        {
            int rez = 4287;
            Calculation calculation = new Calculation();
            int fak = calculation.GetQuantityForProduct(3, 2, 3, (int)56.3, 3);
            Assert.AreEqual(rez, fak);
        }
        [TestMethod()]
        public void GetQuantityForProductTestHard3()
        {
            int rez = 26254;
            Calculation calculation = new Calculation();
            int fak = calculation.GetQuantityForProduct(3, 1, 3, 3, 345);
            Assert.AreEqual(rez, fak);
        }
        [TestMethod()]
        public void GetQuantityForProductTestHard4()
        {
            int rez = 0;
            Calculation calculation = new Calculation();
            int fak = calculation.GetQuantityForProduct(1, 2, (int)0.6, 63, 3);
            Assert.AreEqual(rez, fak);
        }
        [TestMethod()]
        public void GetQuantityForProductTestHard5()
        {
            int rez = 78993;
            Calculation calculation = new Calculation();
            int fak = calculation.GetQuantityForProduct(3, 2, 36, 6, 43);
            Assert.AreEqual(rez, fak);
        }
    }
}