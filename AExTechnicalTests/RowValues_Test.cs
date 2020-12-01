using AExTechnical;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace AExTechnicalTests
{
    [TestClass]
    public class RowValues_Test
    {    
        /// <summary>
         /// Test case for the + operator when combining row values
         /// </summary>
        [TestMethod]
        public void PlusOperator_Test()
        {
            //Arrange
            RowValues firstRowValues = new RowValues() { Values = new List<string>() { "1", "3" } };
            RowValues secondRowValues = new RowValues() { Values = new List<string>() { "2" } };

            RowValues expectedRowValues = new RowValues() { Values = new List<string>() { "1", "2", "3" } };

            //Act
            RowValues addedRowValues = firstRowValues + secondRowValues;

            //Assert
            Assert.IsTrue(expectedRowValues.Equals(addedRowValues), "The row values were not what they were expected.");
        }

        /// <summary>
        /// Test case for the Equals method when comparing row values
        /// </summary>
        [TestMethod]
        public void EqualsMethod_Test()
        {
            //Arrange
            RowValues firstRowValues = new RowValues() { Values = new List<string>() { "1"} };
            RowValues secondRowValues = new RowValues() { Values = new List<string>() { "1" } };

            bool expectedEquals = true;

            //Act
            bool equalsResult = firstRowValues.Equals(secondRowValues);

            //Assert
            Assert.AreEqual(expectedEquals, equalsResult);
        }
    }
}
