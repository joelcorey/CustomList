using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomList;
using System.Collections.Generic;

namespace CustomListTests
{
    [TestClass]
    public class ListTests
    {
        [TestMethod]
        public void Add_AddToList_AddToListSuccess()
        {
            CustomList<string> hello = new CustomList<string>();
            //Arrange
            string expected = "world";
            string actual;
            //Act
            hello.Add("world");
            actual = hello[0];
            //Assert
            Assert.AreEqual(expected, actual);
        }

        // check capacity
        [TestMethod]
        public void Add_AddToList_VerifyCapcityDoubles()
        {
            CustomList<int> testList = new CustomList<int>();
            //Arrange
            int expected = 10;
            int actual;
            //Act
            for (int i = 0; i < 6; i++)
            {
                testList.Add(i);
            }
            actual = testList.Capacity;
            //Assert
            Assert.AreEqual(expected, actual);
        }

        //check count
        [TestMethod]
        public void Add_AddToList_VerifyCount()
        {
            CustomList<int> testList = new CustomList<int>();
            //Arrange
            int expected = 3;
            int actual;
            //Act
            testList.Add(1);
            testList.Add(2);
            testList.Add(3);
            actual = testList.Count;
            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
