using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TriangleInformationCalculator.Tests
{
    [TestClass()]
    public class TriangleTests
    {
        [TestMethod()]
        public void isValidTest()
        {
            Triangle triangle = new Triangle(3, 4, 5);
            Assert.IsTrue(triangle.isValid());
        }

        [TestMethod()]
        public void isNotValidTest()
        {
            Triangle triangle = new Triangle(3, 4, 7);
            Assert.IsFalse(triangle.isValid());
        }

        [TestMethod()]
        public void ClassifyEqualateralTest()
        {
            Triangle triangle = new Triangle(4, 4, 4);
            triangle.Classify();
            Assert.AreEqual("Acute Equalateral", triangle.GetAngleType() + " " + triangle.GetSideType());
        }

        [TestMethod()]
        public void ClassifyAcuteIsoscelesTest()
        {
            Triangle triangle = new Triangle(4, 4, 3);
            triangle.Classify();
            Assert.AreEqual("Acute Isosceles", triangle.GetAngleType() + " " + triangle.GetSideType());
        }

        [TestMethod()]
        public void ClassifyObtuseIsoscelesTest()
        {
            Triangle triangle = new Triangle(4, 4, 7);
            triangle.Classify();
            Assert.AreEqual("Obtuse Isosceles", triangle.GetAngleType() + " " + triangle.GetSideType());
        }

        [TestMethod()]
        public void ClassifyAcuteScaleneTest()
        {
            Triangle triangle = new Triangle(4, 5, 6);
            triangle.Classify();
            Assert.AreEqual("Acute Scalene", triangle.GetAngleType() + " " + triangle.GetSideType());
        }

        [TestMethod()]
        public void ClassifyObtuseScaleneTest()
        {
            Triangle triangle = new Triangle(3, 4, 6);
            triangle.Classify();
            Assert.AreEqual("Obtuse Scalene", triangle.GetAngleType() + " " + triangle.GetSideType());
        }

        [TestMethod()]
        public void ClassifyRightScaleneTest()
        {
            Triangle triangle = new Triangle(3, 4, 5);
            triangle.Classify();
            Assert.AreEqual("Right Scalene", triangle.GetAngleType() + " " + triangle.GetSideType());
        }

        [TestMethod()]
        public void GetAngleMeasurementsTest()
        {
            String[] expectedAngleMeasurements = { "90.00", "60.00", "30.00" };
            Triangle triangle = new Triangle(5, 4.33, 2.5);
            triangle.Classify();
            double[] actualAngleMeasurementsDouble = triangle.GetAngleMeasurements();
            String[] actualAngleMeasurementsString = { String.Format("{0:0.00}", actualAngleMeasurementsDouble[0]),
                String.Format("{0:0.00}", actualAngleMeasurementsDouble[1]),
                String.Format("{0:0.00}", actualAngleMeasurementsDouble[2]) };
            CollectionAssert.AreEqual(expectedAngleMeasurements, actualAngleMeasurementsString);
        }
    }
}