using System;
using ConsoleApp3;
using NUnit.Framework;
using NET.S._2020.Aristova._03;

namespace Tets
{
    public class TestBitOperation
    {
        [Test]
        public void
            ConvertToBitStringCustom_Negative255255_1100000001101111111010000010100011110101110000101000111101011100()
        {
            //Arrange
            double value = -255.255;
            string exp = "1100000001101111111010000010100011110101110000101000111101011100";

            //Act
            string fact = BitOperationsWithDouble.ConvertToBitStringCustom(value);

            //Assert
            Assert.AreEqual(exp, fact);
        }

        [Test]
        public void
            ConvertToBitStringCustom_255255_0100000001101111111010000010100011110101110000101000111101011100()
        {
            //Arrange
            double value = 255.255;
            string exp = "0100000001101111111010000010100011110101110000101000111101011100";

            //Act
            string fact = BitOperationsWithDouble.ConvertToBitStringCustom(value);

            //Assert
            Assert.AreEqual(exp, fact);
        }

        [Test]
        public void
            ConvertToBitStringCustom_4294967295_0100000111101111111111111111111111111111111000000000000000000000()
        {
            //Arrange
            double value = 4294967295.0;
            string exp = "0100000111101111111111111111111111111111111000000000000000000000";

            //Act
            string fact = BitOperationsWithDouble.ConvertToBitStringCustom(value);

            //Assert
            Assert.AreEqual(exp, fact);
        }

        [Test]
        public void
            ConvertToBitStringCustom_Min_1111111111101111111111111111111111111111111111111111111111111111()
        {
            //Arrange
            double value = Double.MinValue;
            string exp = "1111111111101111111111111111111111111111111111111111111111111111";

            //Act
            string fact = BitOperationsWithDouble.ConvertToBitStringCustom(value);

            //Assert
            Assert.AreEqual(exp, fact);
        }


        [Test]
        public void
            ConvertToBitStringCustom_Max_0111111111101111111111111111111111111111111111111111111111111111()
        {
            //Arrange
            double value = Double.MaxValue;
            string exp = "0111111111101111111111111111111111111111111111111111111111111111";

            //Act
            string fact = BitOperationsWithDouble.ConvertToBitStringCustom(value);

            //Assert
            Assert.AreEqual(exp, fact);
        }

        [Test]
        public void
            ConvertToBitStringCustom_Epsilon_0000000000000000000000000000000000000000000000000000000000000001()
        {
            //Arrange
            double value = Double.Epsilon;
            string exp = "0000000000000000000000000000000000000000000000000000000000000001";

            //Act
            string fact = BitOperationsWithDouble.ConvertToBitStringCustom(value);

            //Assert
            Assert.AreEqual(exp, fact);
        }

        [Test]
        public void
            ConvertToBitStringCustom_NaN_1111111111111000000000000000000000000000000000000000000000000000()
        {
            //Arrange
            double value = Double.NaN;
            string exp = "1111111111111000000000000000000000000000000000000000000000000000";

            //Act
            string fact = BitOperationsWithDouble.ConvertToBitStringCustom(value);

            //Assert
            Assert.AreEqual(exp, fact);
        }

        [Test]
        public void
            ConvertToBitStringCustom_NegativeInfinity_1111111111111000000000000000000000000000000000000000000000000000()
        {
            //Arrange
            double value = Double.NegativeInfinity;
            string exp = "1111111111110000000000000000000000000000000000000000000000000000";

            //Act
            string fact = BitOperationsWithDouble.ConvertToBitStringCustom(value);

            //Assert
            Assert.AreEqual(exp, fact);
        }

        [Test]
        public void
            ConvertToBitStringCustom_PositiveInfinity_0111111111110000000000000000000000000000000000000000000000000000()
        {
            //Arrange
            double value = Double.PositiveInfinity;
            string exp = "0111111111110000000000000000000000000000000000000000000000000000";

            //Act
            string fact = BitOperationsWithDouble.ConvertToBitStringCustom(value);

            //Assert
            Assert.AreEqual(exp, fact);
        }

        [Test]
        public void
            ConvertToBitStringCustom_Positive0_0000000000000000000000000000000000000000000000000000000000000000()
        {
            //Arrange
            double value = 0.0;
            string exp = "0000000000000000000000000000000000000000000000000000000000000000";

            //Act
            string fact = BitOperationsWithDouble.ConvertToBitStringCustom(value);

            //Assert
            Assert.AreEqual(exp, fact);
        }


        [Test]
        public void
            ConvertToBitStringCustom_Negative0_1000000000000000000000000000000000000000000000000000000000000000()
        {
            //Arrange
            double value = -0.0;
            string exp = "1000000000000000000000000000000000000000000000000000000000000000";

            //Act
            string fact = BitOperationsWithDouble.ConvertToBitStringCustom(value);

            //Assert
            Assert.AreEqual(exp, fact);
        }
    }
}