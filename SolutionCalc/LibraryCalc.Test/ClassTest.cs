using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LibraryCalc.Test
{
    /// <summary>
    /// Summary description for ClassTest
    /// </summary>
    [TestClass]
    public class ClassTest
    {
        public ClassTest()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public void TestSomma2zeri()
        {
            double num1 = 0;
            double num2 = 0;
            double ris = 0;

            double somma = Calc.Somma(num1, num2);

            Assert.AreEqual(ris, somma);
        }
        [TestMethod]
        public void TestSommaZeroCinque()
        {
            double num1 = 5;
            double num2 = 0;
            double ris = 5;

            double somma = Calc.Somma(num1, num2);

            Assert.AreEqual(ris, somma);
        }
        [TestMethod]
        public void TestSomma()
        {
            double num1 = 7;
            double num2 = 2;
            double ris = 9;

            double somma = Calc.Somma(num1, num2);

            Assert.AreEqual(ris, somma);
        }
        [TestMethod]
        public void TestSommaPerZero()
        {
            double num1 = 0;
            double num2 = 1;
            double ris = 1;

            double somma = Calc.Somma(num1, num2);

            Assert.AreEqual(ris, somma);
        }
        private static double Divisione(double num1, double num2)
        {
            throw new NotImplementedException();
        }
        [TestMethod]
        public void TestDivisione2zeri()
        {
            double num1 = 0;
            double num2 = 0;
            double ris = 0;

            double Divisione = Calc.Divisione(num1, num2);

            Assert.AreEqual(ris, Divisione);
        }
        [TestMethod]
        public void TestDivisioneZeroCinque()
        {
            double num1 = 5;
            double num2 = 0;
            double ris = 0;

            double Divisione = Calc.Divisione(num1, num2);

            Assert.AreEqual(ris, Divisione);
        }
        [TestMethod]
        public void TestDivisione()
        {
            double num1 = 7;
            double num2 = 2;
            double ris = 3.5;

            double Divisione = Calc.Divisione(num1, num2);

            Assert.AreEqual(ris, Divisione);
        }
        [TestMethod]
        public void TestDivisioneaPerZero()
        {
            double num1 = 0;
            double num2 = 1;
            double ris = 0;

            double Divisione = Calc.Divisione(num1, num2);

            Assert.AreEqual(ris, Divisione);
        }

        [TestMethod]
        public static double Massimo(double num1, double num2)
        {
            throw new NotImplementedException();
        }
        [TestMethod]
        public void TestMassimo()
        {
            double num1 = 5;
            double num2 = 2;
            double max = 5;

            double Massimo = Calc.Massimo(num1, num2);
            Assert.AreEqual(max, Massimo);
        }
        [TestMethod]
        public void TestMassimoPer3e4()
        {
            double num1 = 3;
            double num2 = 4;
            double max = 4;

            double Massimo = Calc.Massimo(num1, num2);
            Assert.AreEqual(max, Massimo);
        }
        public void TestMassimoPerDueSette()
        {
            double num1 = 7;
            double num2 = 7;
            double max = 7;

            double Massimo = Calc.Massimo(num1, num2);
            Assert.AreEqual(max, Massimo);
        }
        [TestMethod]
        public static double Minimo(double num1, double num2)
        {
            throw new NotImplementedException();
        }
        [TestMethod]
        public void TestMinimo()
        {
            double num1 = 5;
            double num2 = 2;
            double min = 5;

            double Minimo = Calc.Minimo(num1, num2);
            Assert.AreEqual(min, Minimo);
        }
        [TestMethod]
        public void TestMinimoPer3e4()
        {
            double num1 = 3;
            double num2 = 4;
            double min = 4;

            double Minimo = Calc.Minimo(num1, num2);
            Assert.AreEqual(min, Minimo);
        }
        [TestMethod]
        public void TestMinimoPerDueSette()
        {
            double num1 = 7;
            double num2 = 7;
            double min = 7;

            double Minimo = Calc.Minimo(num1, num2);
            Assert.AreEqual(min, Minimo);
        }
        [TestMethod]
        public static double Media(double num1, double num2)
        {
            throw new NotImplementedException();
        }
        [TestMethod]
        public void TestMedia()
        {
            double num1 = 5;
            double num2 = 2;
            double ris = 3.5;

            double Media = Calc.Media(num1, num2);
            Assert.AreEqual(ris, Media);
        }
        [TestMethod]
        public void TestMediaPer3e4()
        {
            double num1 = 3;
            double num2 = 4;
            double ris = 3.5;

            double Media = Calc.Media(num1, num2);
            Assert.AreEqual(ris, Media);
        }
        [TestMethod]
        public void TestMediaPerDueSette()
        {
            double num1 = 7;
            double num2 = 7;
            double ris = 7;

            double Media = Calc.Media(num1, num2);
            Assert.AreEqual(ris, Media);
        }
        [TestMethod]
        public static double MassimoTre(double num1, double num2, double num3)
        {
            throw new NotImplementedException();
        }
        [TestMethod]
        public void TestMassimoTraTreNumeri()
        {
            double num1 = 7;
            double num2 = 6;
            double num3 = 5;
            double max = 7;

            double massimo = MassimoTre(num1, num2, num3);
            Assert.AreEqual(max, massimo);
        }
        [TestMethod]
        public void TestMassimoTraUnoQuattroSei()
        {
            double num1 = 1;
            double num2 = 4;
            double num3 = 6;
            double max = 6;

            double massimo = Calc.Massimo3(num1, num2, num3);
            Assert.AreEqual(max, massimo);
        }
        [TestMethod]
        public static double MinimoTre(double num1, double num2, double num3)
        {
            throw new NotImplementedException();
        }
        [TestMethod]
        public void TestMinimoTraTreNumeri()
        {
            double num1 = 7;
            double num2 = 6;
            double num3 = 5;
            double min = 5;

            double minimo = MinimoTre(num1, num2, num3);
            Assert.AreEqual(min, minimo);
        }
        [TestMethod]
        public void TestMinimoTraUnoQuattroSei()
        {
            double num1 = 1;
            double num2 = 4;
            double num3 = 6;
            double min = 1;

            double minimo = Calc.Minimo3(num1, num2, num3);
            Assert.AreEqual(min, minimo);
        }
        [TestMethod]
        public static double Media3(double num1, double num2, double num3)
        {
            throw new NotImplementedException();
        }
        [TestMethod]
        public void TestMediaTraTreNumeri()
        {
            double num1 = 7;
            double num2 = 6;
            double num3 = 5;
            double ris = 5;

            double media = Calc.Media3(num1, num2, num3);
            Assert.AreEqual(ris, media);
        }

        [TestMethod]
        public void TestMediaTraUnoQuattroSei()
        {
            double num1 = 1;
            double num2 = 4;
            double num3 = 6;
            double ris = 1;

            double media = Calc.Media3(num1, num2, num3);
            Assert.AreEqual(ris, media);
        }

    }
}
