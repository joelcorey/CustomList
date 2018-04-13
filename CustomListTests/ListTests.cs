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

        [TestMethod]
        public void Remove_RemoveFromList_VerifyRemoveAtIndex()
        {
            //Arrange
            CustomList<int> expectedlList = new CustomList<int>();
            CustomList<int> actualList = new CustomList<int>();
            int expected;
            int actual;
            //Act
            expectedlList.Add(1);
            actualList.Add(1);
            actualList.Add(1);
            actualList.Remove(1);
            expected = expectedlList.Count;
            actual = actualList.Count;
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ToString_ConvertIntToString_IntToStringSuccess()
        {
            CustomList<int> testList = new CustomList<int>();
            //Arrange
            testList.Add(1);
            testList.Add(2);
            string expected;
            string actual;
            //Act
            expected = "1, 2";
            actual = testList.ToString();
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ToString_ConvertIntToString_IntToStringFailure()
        {
            CustomList<int> testList = new CustomList<int>();
            //Arrange
            testList.Add(1);
            testList.Add(2);
            int expected;
            string actual;
            //Act
            expected = 1;
            actual = testList.ToString();
            //Assert
            Assert.AreNotEqual(expected, actual);
        }

        [TestMethod]
        public void ToString_CompareExistingString_StringToStringSuccess()
        {
            CustomList<string> testList = new CustomList<string>();
            //Arrange
            string expected;
            string actual;
            //Act
            testList.Add("1");
            expected = "1";
            actual = testList[0];
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReverseArray_ReverseArray_ArrayReversed()
        {
            //Arrange
            CustomList<int> listForward = new CustomList<int>();
            CustomList<int> listBackward = new CustomList<int>();
            int expected;
            int actual;
            //Act
            listForward.Add(1);
            listForward.Add(2);
            listBackward.Add(2);
            listBackward.Add(1);
            listBackward.Reverse();
            expected = listForward[0];
            actual = listBackward[0];
            //Assert
            Assert.AreEqual(expected, actual);
        }

        //[TestMethod]
        //public void NameHere()
        //{
        //    CustomList<int> testList = new CustomList<int>();
        //    //Arrange

        //    //Act

        //    //Assert

        //}
    }
}
