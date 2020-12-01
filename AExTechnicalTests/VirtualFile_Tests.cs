using AExTechnical;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace AExTechnicalTests
{    
    /// <summary>
     /// Test cases for fuctions in the VirtualFile class
     /// </summary>
    [TestClass]
    public class VirtualFile_Tests
    {
        [TestMethod]
        public void GetFilePath_Test()
        {
            //Arrange
            string fileName = "fileUno";

            //Act
            string path = VirtualFile.GetFilePath(fileName);

            //Assert

            Assert.IsNotNull(path);
        }
    }
}
