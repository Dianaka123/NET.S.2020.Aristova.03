using NET.S._2020.Aristova._03;
using NUnit.Framework;

namespace Tets
{
    public class TestNOD
    {

        [Test]
        public void EvklidNODArray12_69_27Exp3()
        {
            //Arrange
            NOD nod = new NOD(new [] {12, 69, 27});
            int exp = 3;
            //Act
            int fact = nod.EvklidNOD();
            //Assert
            Assert.AreEqual(exp, fact);
        }

        [Test]
        public void EvklidNODArray7_3_12Exp1()
        {
            NOD nod = new NOD(new[] { 7,3,12 });
            int exp = 1;
            //Act
            int fact = nod.EvklidNOD();
            //Assert
            Assert.AreEqual(exp, fact);
        }

        [Test]
        public void EvklidNODArray12_Negative69_27Exp3()
        {
            //Arrange
            NOD nod = new NOD(new[] { 12, -69, 27 });
            int exp = 3;
            //Act
            int fact = nod.EvklidNOD();
            //Assert
            Assert.AreEqual(exp, fact);
        }

        [Test]
        public void EvklidNODArray12_0_27ExpNegative1()
        {
            //Arrange
            NOD nod = new NOD(new[] { 12, 0, 27 });
            int exp = -1;
            //Act
            int fact = nod.EvklidNOD();
            //Assert
            Assert.AreEqual(exp, fact);
        }

        [Test]
        public void BinEvklidNODArray12_69_27Exp3()
        {
            //Arrange
            NOD nod = new NOD(new[] { 12, 69, 27 });
            int exp = 3;
            //Act
            uint fact = nod.BinaryGCD();
            //Assert
            Assert.AreEqual(exp, fact);
        }

        [Test]
        public void BinEvklidNODArray7_3_12Exp1()
        {
            NOD nod = new NOD(new[] { 7, 3, 12 });
            int exp = 1;
            //Act
            uint fact = nod.BinaryGCD();
            //Assert
            Assert.AreEqual(exp, fact);
        }

        [Test]
        public void BinEvklidNODArray12_Negative69_27Exp3()
        {
            //Arrange
            NOD nod = new NOD(new[] { 12, -69, 27 });
            int exp = 3;
            //Act
            uint fact = nod.BinaryGCD();
            //Assert
            Assert.AreEqual(exp, fact);
        }

        [Test]
        public void BinEvklidNODArray12_0_0ExpNegative12()
        {
            //Arrange
            NOD nod = new NOD(new[] { 12, 0, 0 });
            
            int exp = 12;
            //Act
            uint fact = nod.BinaryGCD();
            //Assert
            Assert.AreEqual(exp, fact);
        }

    }
}