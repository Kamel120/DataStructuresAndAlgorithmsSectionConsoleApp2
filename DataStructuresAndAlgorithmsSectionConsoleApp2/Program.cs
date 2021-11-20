using System;
using System.Collections;

namespace DataStructuresAndAlgorithmsSectionConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Example: Create an ArrayList
            ArrayList arlist = new ArrayList();
            // or 
            var arrlist = new ArrayList(); // recommended 

            //Example: Adding Elements in ArrayList
            //adding elements using ArrayList.Add() method
            var arlist1 = new ArrayList();
            arlist1.Add(1);
            arlist1.Add("Bill");
            arlist1.Add(" ");
            arlist1.Add(true);
            arlist1.Add(4.5);
            arlist1.Add(null); //""

            // adding elements using object initializer syntax
            var arlist2 = new ArrayList()
                {
                    2, "Steve", " ", true, 4.5, null
                };


            //Example: Adding Entire Array / ArrayList into ArrayList
            //var arlist1 = new ArrayList();

            //var arlist2 = new ArrayList()
            //        {
            //            1, "Bill", " ", true, 4.5, null
            //        };

            //int[] arr = { 100, 200, 300, 400 };

            //Queue myQ = new Queue();
            //myQ.Enqueue("Hello");
            //myQ.Enqueue("World!");

            //arlist1.AddRange(arlist2); //adding arraylist in arraylist 
            //arlist1.AddRange(arr); //adding array in arraylist 
            //arlist1.AddRange(myQ); //adding Queue in arraylist

            //Example: Accessing Elements of ArrayList
            //var arlist = new ArrayList()
            //    {
            //        1,
            //        "Bill",
            //        300,
            //        4.5f
            //    };

            //Access individual item using indexer
            //int firstElement = (int)arlist[0]; //returns 1
            //string secondElement = (string)arlist[1]; //returns "Bill"
            //int secondElement = (int) arlist[1]; //Error: cannot cover string to in                                             t

            //using var keyword without explicit casting
            //var firstElement = arlist[0]; //returns 1
            //var secondElement = arlist[1]; //returns "Bill"
            ////var fifthElement = arlist[5]; //Error: Index out of range

            //update elements
            //arlist[0] = "Steve";
            //arlist[1] = 100;
            //arlist[5] = 500; //Error: Index out of range

            //Example: Iterate ArrayList
            //ArrayList arlist = new ArrayList()
            //            {
            //                1,
            //                "Bill",
            //                300,
            //                4.5F
            //            };

            //foreach (var item in arlist)
            //    Console.Write(item + ", "); //output: 1, Bill, 300, 4.5, 

            //for (int i = 0; i < arlist.Count; i++)
            //    Console.Write(arlist[i] + ", "); //output: 1, Bill, 300, 4.5, 

            //Example: Insert Element in ArrayList
            //ArrayList arlist = new ArrayList()
            //    {
            //        1,
            //        "Bill",
            //        300,
            //        4.5f
            //    };

            //arlist.Insert(1, "Second Item");

            //foreach (var btngan_m5ll in arlist)
            //    Console.WriteLine(btngan_m5ll);


            //Example: Insert Collection in ArrayList
            //ArrayList arlist1 = new ArrayList()
            //    {
            //        100, 200, 600
            //    };

            //ArrayList arlist2 = new ArrayList()
            //    {
            //        300, 400, 500
            //    };
            //arlist1.InsertRange(2, arlist2);

            //foreach (var item in arlist1)
            //    Console.Write(item + ", "); //output: 100, 200, 300, 400, 500, 600, 

            //Example: Remove Elements from ArrayList
            //ArrayList arList = new ArrayList()
            //    {
            //        1,
            //        null,
            //        "Bill",
            //        300,
            //        " ",
            //        4.5f,
            //        300,
            //    };

            ////arList.Remove(null); //Removes first occurance of null
            ////arList.RemoveAt(4); //Removes element at index 4
            //arList.RemoveRange(4, 3);//Removes two elements starting from 1st item (0 index)


            //Example: Check for Elements
            //ArrayList arList = new ArrayList()
            //    {
            //        1,
            //        "Bill",
            //        300,
            //        4.5f,
            //        300
            //    };

            //Console.WriteLine(arList.Contains(300)); // true
            //Console.WriteLine(arList.Contains("Bill")); // true
            //Console.WriteLine(arList.Contains(10)); // false
            //Console.WriteLine(arList.Contains("Steve")); // false

            //if (arList.Contains(300))
            //{
            //    Console.WriteLine("yes arraylist conatins 300 value");
            //}



        }
    }
}
