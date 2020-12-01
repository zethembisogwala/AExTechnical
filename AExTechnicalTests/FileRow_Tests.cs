using AExTechnical;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace AExTechnicalTests
{
    [TestClass]
    public class FileRow_Tests
    {
        [TestMethod]
        public void AddValues_Test()
        {
            //Arrange
            FileRow fileRow1 = new FileRow() { IP = "1.2.3.4", Values = new RowValues() { Values = new List<string>() { "1", "2" } } };
            FileRow fileRow2 = new FileRow() { IP = "1.2.3.4", Values = new RowValues() { Values = new List<string>() { "1", "2" } } };
           
            FileRow expectedFileRow1 = new FileRow() { IP = "1.2.3.4", Values = new RowValues() { Values = new List<string>() { "1", "2" } } };

            //Act
            bool addValuesSuccess = fileRow1.AddValues(fileRow2.Values.Values);


            //Assert
            Assert.IsTrue(expectedFileRow1.Equals(fileRow1) && addValuesSuccess, "Objects were not equal");
        }
    }
}
