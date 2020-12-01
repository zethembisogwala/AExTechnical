using AExTechnical;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace AExTechnicalTests
{
    [TestClass]
    public class DataFile_Tests
    {
        /// <summary>
        /// Test case for the + operator when combining data files
        /// </summary>
        [TestMethod]
        public void PlusOperator_Test()
        {
            //Arrange
            DataFile file1 = new DataFile() { FileRows = new List<FileRow>() { new FileRow() { IP = "1.2.3.4", Values = new RowValues() { Values = new List<string>() { "1", "2" } } } } };

            DataFile file2 = new DataFile() { FileRows = new List<FileRow>() { new FileRow() { IP = "1.2.3.4", Values = new RowValues() { Values = new List<string>() { "3", "4" } } } } };

            DataFile expectedCombinedFile = new DataFile() { FileRows = new List<FileRow>() { new FileRow() { IP = "1.2.3.4", Values = new RowValues() { Values = new List<string>() { "1", "2", "3", "4" } } } } };

            //Act
            DataFile combinedDataFile = file1 + file2;

            //Assert
            Assert.IsTrue(expectedCombinedFile.Equals(combinedDataFile), "The row values were not what they were expected.");
        }

        /// <summary>
        /// Test case for the Equals method when comparing data files
        /// </summary>
        [TestMethod]
        public void EqualsMethod_Test()
        {
            //Arrange
            DataFile file1 = new DataFile() { FileRows = new List<FileRow>() { new FileRow() { IP = "1.2.3.4", Values = new RowValues() { Values = new List<string>() { "1", "2" } } } } };

            DataFile file2 = new DataFile() { FileRows = new List<FileRow>() { new FileRow() { IP = "1.2.3.4", Values = new RowValues() { Values = new List<string>() { "1", "2" } } } } };


            bool expectedEquals = true;

            //Act
            bool equalsResult = file1.Equals(file2);

            //Assert
            Assert.AreEqual(expectedEquals, equalsResult);
        }
    }
}
