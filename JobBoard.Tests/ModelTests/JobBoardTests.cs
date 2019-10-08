using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using JobBoards.Models;

namespace JobBoards.Tests
{
    [TestClass]
    public class BoardTest
    {
        [TestMethod]
        public void GetId_ItemsInstantiateWithAnIdAndGetterReturns_Int()
        {
            //Arrange
            string jobTitle = "Poozer";
            string companyName = "Company";
            string jobDes = "This job sucks";
            string Contact = "Jeff";
            string Email = "Email";
            string Phone = "phone";
            JobBoard newJobBoard = new JobBoard(jobTitle, companyName, jobDes, Contact, Email, Phone);

            //Act
            int result = newJobBoard.Id;
            System.Console.WriteLine(newJobBoard.Id);

            //Assert
            Assert.AreEqual(1, result);
        }
    }
}
