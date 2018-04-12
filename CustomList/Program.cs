using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    class Program
    {
        static void Main(string[] args)
        {
            //The built-in List < T > class is a generic class that acts as a wrapper over the array class. You cannot use built-in List or Array methods.
            //use Test Driven Development(TDD), so that I can write tests for my methods to pass to ensure proper functionality within my application.There needs to be several tests per method.
            //make good, consistent commits.
            //use a custom-built list class that stores its values in an array, so that I can store any data type in my collection.
            //ability to add an object to an instance of my custom-built list class.
            //the ability to remove an object from an instance of my custom-built list class.
            //custom list class to be iterable.
            //be able to override the ToString method that converts the contents of the custom list to a string.
            //able to overload the + operator, so that I can add two instances of the custom list class together.
            //able to overload the – operator, so that I can subtract one instance of a custom list class from another instance of a custom list class.
            //Count property implemented on the custom-built list class, so that I can get a count of the number of elements in my custom list class instance.
            //ability to zip two custom list class instances together in the form of a zipper.An example:
            //- I have List<int> odd = new List<int>() { 1, 3, 5 }; and List<int> even = new List<int>() { 2, 4, 6 }; 
            //- When lists odd and even are zipped together, your new list will contain values 1,2,3,4,5,6
            //use C# best practices, SOLID design principles, and good naming conventions on the project. 
            //BONUS: ability to sort an instance of my custom-built list class. To be eligible for the bonus points, you may not use Array.Sort() that is already built in and you must tell us what sorting algorithm you used.
            //BONUS: ability to earn bonus points for an EASTER EGG user story, regarding implementing a specific good practice on one of the above methods specified in a user story above.

            //Random random = new Random();

            CustomList<int> testList = new CustomList<int>();
            //CustomList<int> testList2 = new CustomList<int>();
            //CustomList<Lemon> lemonList = new CustomList<Lemon>();
            //CustomList<int> combinedlist;
            //CustomList<int> subtractList;

            //for (int i = 0; i <= 4000; i++)
            //{
            //    testList.Add(i);   
            //}

            testList.Add(1);
            testList.Add(2);

            Console.WriteLine(testList.ToString());


            //foreach (var item in testList)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine("0: " + lemonList[0].Value);
            //lemonList.Remove(0);
            //Console.WriteLine(testList.ToString());

            //combinedlist = testList + testList2;
            //subtractList = testList - testList2;
            //Console.WriteLine(subtractList);
            //Console.ReadLine();
            CustomList<int> expectedList = new CustomList<int>();
            CustomList<int> actuaList = new CustomList<int>();

            expectedList.Add(1);
            expectedList.Add(1);
            expectedList.Add(2);

            Console.ReadKey();
        }
    }
}
