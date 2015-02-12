using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestTry
{
    [TestClass]
    public class UnitTestTry
    {
        [TestMethod]
        // Test med indata 3,6 4,0 5,7
        public void IsScaleneTrueDoubles1()
        {
            Triangle t = new Triangle(3.6, 4.0, 5.7);
            Assert.IsTrue(t.isScalene(), 
                "Metoden isScalene() returnerar ej true på en triangel utan lika sidor inmatad med tre flyttal.");
        }

        [TestMethod]
        // Test med indata 3,6 4,0 5,7
        public void IsIsoscelesFalseDoubles1()
        {
            Triangle t = new Triangle(3.6, 4.0, 5.7);
            Assert.IsTrue(!t.isIsosceles(), 
                "Metoden isIsoSceles() returnerar ej false på en triangel utan lika sidor inmatad med tre flyttal.");
        }

        [TestMethod]
        // Test med indata 3,6 4,0 5,7
        public void IsEquitateralFalseDoubles1()
        {
            Triangle t = new Triangle(3.6, 4.0, 5.7);
            Assert.IsTrue(!t.isEquilateral(), 
                "Metoden isEquilateral() returnerar ej false på en triangel utan lika sidor inmatad med tre flyttal.");
        }

        [TestMethod]
        // Test med indata 0,3 0,35 0,3
        public void IsIsoscelesTrueDoubles2() 
        {
            Triangle t = new Triangle(0.3, 0.35, 0.3);
            Assert.IsTrue(t.isIsosceles(), 
                "Metoden isIsoSceles() returnerar ej true på en likbent triangel inmatad med tre flyttal.");
        }

        [TestMethod]
        // Test med indata 0,3 0,35 0,3
        public void IsScaleneFalseDoubles2()
        {
            Triangle t = new Triangle(0.3, 0.35, 0.3);
            Assert.IsTrue(!t.isScalene(), 
                "Metoden isScalene() returnerar ej false på en likbent triangel inmatad med tre flyttal.");
        }

        [TestMethod]
        // Test med indata 0,3 0,35 0,3
        public void IsEquilateralFalseDouble2()
        {
            Triangle t = new Triangle(0.3, 0.35, 0.3);
            Assert.IsTrue(!t.isEquilateral(), 
                "Metoden isEquilateral() returnerar ej false på en likbent triangel inmatad med tre flyttal.");
        }

        [TestMethod]
        // Test med indata 334.5 334.5 334.5
        public void IsEquilateralTrueDoubles3() 
        {
            Triangle t = new Triangle(334.5, 334.5, 334.5);
            Assert.IsTrue(t.isEquilateral(), 
                "Metoden isEquilateral() returnerar ej true på en liksidig triangel inmatad med tre flyttal.");
        }

        [TestMethod]
        // Test med indata 334.5 334.5 334.5
        public void IsIsoscelesFalseDoubles3()
        {
            Triangle t = new Triangle(334.5, 334.5, 334.5);
            Assert.IsTrue(!t.isIsosceles(), 
                "Metoden isIsosceles() returnerar ej false på en liksidig triangel inmatad med tre flyttal.");
        }

        [TestMethod]
        // Test med indata 334.5 334.5 334.5
        public void IsScaleneFalseDoubles3()
        {
            Triangle t = new Triangle(334.5, 334.5, 334.5);
            Assert.IsTrue(!t.isScalene(), 
                "Metoden isScalene() returnerar ej false på en liksidig triangel inmatad med tre flyttal.");
        }

        [TestMethod]
        // Test med indata Point(0, 0), Point(10, 0), Point(20, 5)
        public void IsIsoscelesTruePoints1() 
        {
            Triangle t = new Triangle(new Point(0, 0), new Point(10, 0), new Point(5, 20));
            Assert.IsTrue(t.isIsosceles(), 
                "Metoden isIsosceles() returnerar ej true på en likbent triangel inmatad med tre instanser av typen Points");
        }

        [TestMethod]
        // Test med indata Point(-1, -1), Point(5, 2), Point(7, -1)
        public void IsScaleneTruePoints2()
        {
            Triangle t = new Triangle(new Point(-1, -1), new Point(5, 2), new Point(7, -1));
            Assert.IsTrue(t.isScalene(),
                "Metoden isScalene() returnerar ej true på en triangel utan lika sidor inmatad med tre instanser av typen Points");
        }

        [TestMethod]
        // Test med indata Point(2, 2), Point(12, 2), Point(7, höjden)
        public void IsEquitaleralTruePoints3()
        {
            // Varje sida av triangeln är 10 enheter lång.
            // Höjden är roten ur b eftersom -> c^2 = a^2 + b^2 där a = 10/2 och c = 10.
            double height = Math.Sqrt(75.0);

            Triangle t = new Triangle(new Point(2, 2), new Point(12, 2), new Point(7, (height + 2)));
            Assert.IsTrue(t.isEquilateral(),
                "Metoden isEquilateral() returnerar ej true på en liksidig triangel inmatad med tre instanser av typen Points");
        }

        [TestMethod]
        // Test med Point[] som indata
        public void IsIsoscelesTruePointArray1() 
        {
            Point[] points = { new Point(0, 0), new Point(10, 0), new Point(5, 20) };
            Triangle t = new Triangle(points);
            Assert.IsTrue(t.isIsosceles(), 
                "Metoden isIsosceles() returnerar ej true på en likbent triangel inmatad med en Point[]");
        }

        [TestMethod]
        // Test med Point[] som indata
        public void IsScaleneTruePointArray2()
        {
            Point[] points = { new Point(-1, -1), new Point(5, 2), new Point(7, -1) };
            Triangle t = new Triangle(points);
            Assert.IsTrue(t.isScalene(),
                "Metoden isScalene() returnerar ej true på en likbent triangel inmatad med en Point[]");
        }

        [TestMethod]
        // Test med Point[] som indata
        public void IsEquilateralTruePointArray3()
        {
            // Varje sida av triangeln är 10 enheter lång.
            // Höjden är roten ur b eftersom -> c^2 = a^2 + b^2 där a = 10/2 och c = 10.
            double height = Math.Sqrt(75.0);

            Point[] points = { new Point(2, 2), new Point(12, 2), new Point(7, (height + 2)) };
            Triangle t = new Triangle(points);
            Assert.IsTrue(t.isEquilateral(),
                "Metoden isEquilateral() returnerar ej true på en likbent triangel inmatad med en Point[]");
        }

        [TestMethod]
        // Test med double[] som indata
        public void IsScaleneTrueDoubleArray() 
        {
            double[] doubles = { 3.6, 4.0, 5.7 };
            Triangle t = new Triangle(doubles);
            Assert.IsTrue(t.isScalene(), 
                "Metoden IsScalene() returnerar ej true på en triangel utan lika sidor inmatad med en double[]");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        // Test med felaktiga argument i form av negativa tal
        // Inmatning 1.5 -2,5 1.5
        public void WrongArgumentsNegativeInputDoubles() 
        {
            Triangle t = new Triangle(1.5, -2.5, 1.5);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        // Test med felaktiga argument i form av en ogiltig triangel
        // Inmatning 1.0 2.0 3.0
        public void WrongArgumentsBadTriangleDoubles()
        {
            Triangle t = new Triangle(1.0, 2.0, 3.0);
        }
        
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        // Test med felaktiga argument i form av negativa tal i en double[]
        // Inmatning { 1.5 -2,5 1.5 }
        public void WrongArgumentsNegativeInputDoubleArray()
        {
            double[] doubles = { 1.5, -2.5, 1.5 };
            Triangle t = new Triangle(doubles);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        // Test med felaktiga argument i form av fyra stycken element i double[]
        // Inmatning { 1.5, 1.5, 1.5. 2.5 }
        public void WrongNumberOfArgumentsDoubles()
        {
            double[] doubles = { 1.5, 1.5, 1.5, 2.5 };
            Triangle t = new Triangle(doubles);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        // Test med felaktiga argument i form av två stycken element i Point[]
        // Indata { Point(0, 0), Point(10, 0) }
        public void WrongNumberOfArgumentsPoints()
        {
            Point[] points = { new Point(0, 0), new Point(10, 0) };
            Triangle t = new Triangle(points);
        }
    }
}
