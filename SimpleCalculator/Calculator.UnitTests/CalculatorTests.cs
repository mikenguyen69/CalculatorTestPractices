using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    public class CalculatorTests
    {
        #region Plus Tests
        [Test]
        public void CalculatePlusInt()
        {
            Assert.AreEqual(Calculator.Plus(1, 2), 3);  
        }

        [Test]
        public void CalculatePlusDouble()
        {

            Assert.AreEqual(Calculator.Plus(1.5, 2), 3.5);
            Assert.AreEqual(Calculator.Plus(2, 2.5), 4.5);
        }

        [Test]
        public void CalculatePlusInValid()
        {
            Assert.AreEqual(Calculator.Plus("a", 2), "Invalid input for a or b");
        }
        #endregion

        #region Multiplier Tests
        [Test]
        public void CalculateMultiplierInt()
        {
            Assert.AreEqual(Calculator.Multiplier(2, 1), 2);

        }

        [Test]
        public void CalculateMultiplierDouble()
        {
            Assert.AreEqual(Calculator.Multiplier(2, 2.25), 4.5);
            Assert.AreEqual(Calculator.Multiplier(2.25, 2), 4.5);
        }

        [Test]
        public void CalculateMultiplierInvalid()
        {
            Assert.AreEqual(Calculator.Multiplier(2, 1), 2);

        }

        #endregion

        #region Divide Tests
        [Test]
        public void CalculateDivideInt_HasNoRemainder()
        {
            Assert.AreEqual(Calculator.Divide(6, 2), 3);
        }

        [Test]
        public void CalculateDivideInt_HasRemainder()
        {
            Assert.AreEqual(Calculator.Divide(4, 5), 0.8);

        }

        [Test]
        public void CalculateDivideDouble()
        {
            Assert.AreEqual(Calculator.Divide(4, 0.5), 8);

        }

        [Test]
        public void CalculateDivideZero()
        {
            Assert.AreEqual(Calculator.Divide(4, 0), "Can't divide 0");

        }
        #endregion
    }
}
