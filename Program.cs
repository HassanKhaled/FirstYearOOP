using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Data.SqlTypes;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace OOP_Lab1_1dArray
{
     class Program
    {
        static void Main(string[] args)
        {
            // 1.1 Array Introduction

            //double d1, d2, d3;
            //d1 = 10.5;
            //d2 = 15.5;
            //d3 = 9.5;

            // 1.2 Array definition 
            // type [] name = new type [size];
            // int[] nums = new int[5];

            //// type [] name = new type []{value1,value2,value3};
            //int[] nums2 = new int[] { 1, 7, 8, 5, 9, 6, 4, 2, 3, 3 };

            //// type [] name = new type [size]{val1,val2,va3};
            //int[] name = new int[3] { 1, 2, 3 };

            //// type [] name = {value1,value2,value2};
            //int[] nums1 = { 1, 2, 3, 4, 5, 6, };

            // 2. Array and index 
            //int[] nums = new int[5];
            //nums[0] = 2;
            //nums[1] = 10;
            //nums[2] = 5;

            //3. priting array elements using for loop
            //int[] nums = { 1, 2, 4, 9, 3, 1, 0 };
            //string[] names = { "hassan", "ahmed", "mohamed" };
            //double[] dnums = { 1.2, 5.3, 125.3 };

            //for (int i = 0; i < 7; i++)
            //{
            //    Console.WriteLine(nums[i]);
            //}

            //for (int i = 0; i < nums.Length; i++)
            //{
            //    Console.WriteLine(nums[i]);
            //}

            //Console.WriteLine(nums[0]);
            //Console.WriteLine(names[2]);
            //Console.WriteLine(dnums[1]);

            //4. priting array using foreach loop
            //int[] nums = { 1, 2, 4, 9, 3, 1, 0 };
            //string[] names = { "hassan", "ahmed", "mohamed" };
            //double[] dnums = { 1.2, 5.3, 125.3 };

            //foreach (int item in nums)
            //{
            //    Console.WriteLine(item);
            //}

            //foreach (string item in names)
            //{
            //    Console.WriteLine(item);
            //}

            //foreach (var item in dnums)
            //{
            //    Console.WriteLine(item);
            //}

            //5 reading elements from user using for looop 
            //int[] nums = new int[3];
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    Console.WriteLine("enter element number"+i);
            //    nums[i] = int.Parse(Console.ReadLine());
            //}

            //foreach (int item in nums)
            //{
            //    Console.WriteLine(item);
            //}

            //6. passing array as paramters
            //int[] nums = { 1, 2, 4, 9, 3, 1, 0 };

            //int[] nums1= new int [3];
            //ReadArray(nums1);
            //PrintArray(nums1);

            //7. Operation on vectors (1D Array)
            //int[] vector1 = { 1, 2, 3 };
            //int[] vector2 = { 4, 5, 6 };
            //int[] results = new int[3];

            //sumVectors(vector1, vector2, results);

            //8. sum and average of an array 
            //int[] numbers = { 1, 5, 9, 6, 5, 2, 4, 2, 6, 2, 0 };
            //Console.WriteLine(average(numbers));

            //9. max and min of an array
            //int[] numbers = { 1, 5, 9, 6, 5, 2, 4, 2, 6, 2, 0 };
            //Console.WriteLine( maxArray(numbers));
            //Console.WriteLine(minArray(numbers));

            // 10. using Array built in methods
            //int[] numbers = { 1, 5, 9, 6, 5, 2, 4, 2, 6, 2, 0 };

            //Console.WriteLine("Sum = "+numbers.Max());
            //Console.WriteLine("Min = "+numbers.Min());
            //Console.WriteLine("Max = "+numbers.Sum());
            //Console.WriteLine("Average = {0}",numbers.Sum()/numbers.Length);

            //11. changing element inside an array 
            //int[] arr = { 1, 2, 3, 4, 5 };
            //arr[0] = 10;
            //arr[3] = 45;
            //PrintArray(arr);

            // 12. string variable as 1d charachter array
            //string name = "Ahmed Mohamed";
            //foreach (var c in name)
            //{
            //    Console.WriteLine(c);
            //}

            // 13. Count odd and even and specifice elements inside array 
            //int[] arr = { 1, 2, 3, 4, 5 };
            //Console.WriteLine("Numbers of Odd Elements is {0}",countOdd(arr));
            //Console.WriteLine("Numbers of even Elements is {0}", countEven(arr));
            //Console.WriteLine("Numbers of 2 in array is {0}", countElement(arr,2));

            //14. search array for a specific element
            int[] arr = { 1, 2, 3, 4, 5 };
            Console.WriteLine("does {0} exist in array {1}",2,SearchArray(arr,2));
            Console.WriteLine("does {0} exist in array {1}", 10, SearchArray(arr, 10));
            Console.WriteLine("index of {0} is {1}",4,getIndex(arr,4));
            Console.WriteLine("index of {0} is {1}", 9, getIndex(arr, 9));
            Console.WriteLine("enter element");
            int search = int.Parse(Console.ReadLine());
            Console.WriteLine("index of {0} is {1}",search,getIndex(arr,search));

        }
        static int getIndex(int[] arr, int element) {
            int index = -1;
            for (int i = 0; i < arr.Length; i++)
                if (arr[i]==element)
                    index = i;
            return index;
        }

        static bool SearchArray(int[] arr, int element) {
            bool flag = false; foreach (var i in arr)
                if (i == element)
                    flag = true;
            return flag;
        }
        static int countElement(int[] arr, int element) {

            int count = 0;
            foreach (var i in arr)
                if (i  == element)
                    count++;
            return count;
        }
        static int countEven(int[] arr)
        {
            int count = 0;
            foreach (var i in arr)
                if (i % 2 == 0)
                    count++;
            return count;
        }
        static int countOdd(int[] arr) {
            int count = 0;
            foreach (var i in arr)
                if (i%2==1)
                    count++;
            return count;
        }
        static int minArray(int[] arr)
        {

            int min = arr[0];

            for (int i = 0; i < arr.Length; i++)
                if (min > arr[i])
                    min = arr[i];
            return min;
        }
        static int maxArray(int[] arr) {

            int max = arr[0];

            for (int i = 0; i < arr.Length; i++)
                if (max < arr[i])
                    max = arr[i];
            return max;
        }
        static double average(int[] arr) {

            return SumArray(arr)/ arr.Length;
        }

        static int SumArray(int[] arr) {
            int sum = 0;
            foreach (var i in arr)
            {
                sum += i;
            }
            return sum;
        }

        static void sumVectors(int[] v1, int[] v2, int[] r) {
            for (int i = 0; i < 3; i++)
            {
                r[i] = v1[i] + v2[i];
                Console.WriteLine("{0}+{1}={2}", v1[i], v2[i], r[i]);
            }

        }
        static void ReadArray(int[] arr) {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("enter element number" + i);
                arr[i] = int.Parse(Console.ReadLine());
            }
        }
        static void PrintArray(int[] arr) {

            foreach (int item in arr)
            {
                Console.WriteLine(item);
            }
        }
    }
}
