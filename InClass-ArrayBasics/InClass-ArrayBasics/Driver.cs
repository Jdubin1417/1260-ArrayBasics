using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace InClass_ArrayBasics
{
    public class Driver
    {
        public static void Main()
        {
            int[] myNums = new int[5]; //0, 0, 0, 0, 0

            myNums[2] = 3;
            Console.WriteLine(myNums[0]); //0
            Console.WriteLine(myNums[2]); //3

            Console.WriteLine("-----");

            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine(myNums[i]);
            }

            Console.WriteLine("-----");

            for (int i = 0; i <= 5; i++)
            {
                //System.IndexOutOfRangeException: 'Index was outside the bounds of the array.'
                //when trying to access myNums[5], which doesn't exist
                //Console.WriteLine(myNums[i]);
            }

            //to help avoid off-by-one error and not have to change the size
            //everywhere in your code if I changed it on ln 14
            //arrayName.Length - a property that holds the size/number of elements in the array
            for (int i = 0; i < myNums.Length; i++)
            {
                //System.IndexOutOfRangeException: 'Index was outside the bounds of the array.'
                //when trying to access myNums[5], which doesn't exist
                Console.WriteLine(myNums[i]);
            }

            //Arrays can be used in any place you can use any other variable
            myNums[0]++;

            if (myNums[3] < 2)
            {
                //...
            }

            for(int i = 0; i < myNums[2]; i++)
            {
                //...
            }

            /////////////////////////////
            Console.WriteLine("\n---\n");

            //int[] daysInEachMonth = new int[12];
            //daysInEachMonth[0] = 31;
            //daysInEachMonth[1] = 28;
            //...

            int[] daysInEachMonth = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

            /////////////////////////////
            Console.WriteLine("\n---\n");

            for(int i = 0; i < daysInEachMonth.Length; i++)
            {
                Console.WriteLine(daysInEachMonth[i]);
            }

            foreach(int day in daysInEachMonth)
            {
                Console.WriteLine(day);
            }

            /////////////////////////////
            Console.WriteLine("\n---\n");

            //Shallow copy - do not do!!!
            //int[] numbers = { 1, 3, 7, 21, 5 };
            //int[] numbers2 = numbers;

            //Deep copy
            int[] numbers = { 1, 3, 7, 21, 5 }; //5 items
            int[] numbers2 = new int[5]; //new array of the same size to copy to

            //copy over all elements
            for(int i = 0; i < numbers.Length; i++)
            {
                numbers2[i] = numbers[i];
            }


            int[] numbers3 = { 1, 3, 7, 21, 5 }; //5 items
            int[] numbers4 = new int[10]; //new array that is bigger

            //copy over all elements
            for (int i = 0; i < numbers3.Length; i++)
            {
                numbers4[i] = numbers3[i];
            }

            for(int i = 0; i < numbers4.Length; i++)
            {
                Console.WriteLine(numbers4[i]);
            }

        }
    }
}
