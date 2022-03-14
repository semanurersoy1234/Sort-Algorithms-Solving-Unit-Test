using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ce100_hw1_algo_lib_cs
{


    public class Class1
    {

        /**
        * 
        * @name InsertionSort
        * 
        * @param [in] arr [\b int[]]
         
        * Insertion sort is a simple sorting algorithm that builds the final sorted array (or list) one item at a time.
        * Insertion sort is a sorting algorithm that places an unsorted element at its suitable place in each iteration.
        **/
        public static void InsertionSort(int[] arr)
        {
            int n = arr.Length;
            for (int i = 1; i < n; ++i)
            {
                int key = arr[i];
                int j = i - 1;

                // Move elements of arr[0..i-1],
                // that are greater than key,
                // to one position ahead of
                // their current position
                while (j >= 0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j];
                    j = j - 1;
                }
                arr[j + 1] = key;
            }
        }

        /**
        * 
        * @name SelectionSort
        * 
        * @param [in] arr [\b int[]]
         
        * Selection sort is an in-place comparison sorting algorithm.
        **/

        public static void SelectionSort(int[] arr)
        {
            int n = arr.Length;

            // One by one move boundary of unsorted subarray
            for (int i = 0; i < n - 1; i++)
            {
                // Find the minimum element in unsorted array
                int min_idx = i;
                for (int j = i + 1; j < n; j++)
                    if (arr[j] < arr[min_idx])
                        min_idx = j;

                // Swap the found minimum element with the first
                // element
                int temp = arr[min_idx];
                arr[min_idx] = arr[i];
                arr[i] = temp;
            }
        }

        /**
        * 
        * @name Merge
        * 
        * @param [in] numbers [\b int[]]
        * @param [in] left [\b int]
        * @param [in] mid [\b int]
        * @param [in] right [\b int]
       
        * Merge sort is a recursive algorithm that continually splits a list in half. 
        **/
        public static void Merge(int[] numbers, int left, int mid, int right)
        {
            int[] temp = new int[25];
            int i, eol, num, pos;
            eol = (mid - 1);
            pos = left;
            num = (right - left + 1);

            while ((left <= eol) && (mid <= right))
            {
                if (numbers[left] <= numbers[mid])
                    temp[pos++] = numbers[left++];
                else
                    temp[pos++] = numbers[mid++];
            }
            while (left <= eol)
                temp[pos++] = numbers[left++];
            while (mid <= right)
                temp[pos++] = numbers[mid++];
            for (i = 0; i < num; i++)
            {
                numbers[right] = temp[right];
                right--;
            }
        }

        /**
        * 
        * @name RecursiveMergeSort
        * 
        * @param [in] arr [\b int[]]
        * retval [\b int []] 
        * Merge sort is a recursive algorithm that continually splits a list in half. 
        **/
        public static void RecursiveMergeSort(int[] numbers, int left, int right)
        {
            int mid;
            if (right > left)
            {
                mid = (right + left) / 2;
                RecursiveMergeSort(numbers, left, mid);
                RecursiveMergeSort(numbers, (mid + 1), right);
                Merge(numbers, left, (mid + 1), right);
            }
        }

        /**
        * 
        * @name RecursivevePower
        * 
        * @param [in] arr [\b int[]]
        * retval [\b long ] 
        * To find power of any number, you can use pow() function. result = pow
        **/
        public static int RecursivePower(int n, int powerRaised)
        {
            if (powerRaised != 0)
                return (n * RecursivePower(n, powerRaised - 1));
            else
                return 1;
        }

        /**
        * 
        * @name NaivePower
        * 
        * @param [in] arr [\b int[]]
        * retval [\b int []] 
        * Returns the result of an exponential number.
        **/
        public static long Naive_Power(int a, int p)
        {
            long pow = 1L;
            for (int i = 1; i <= p; i++)
            {
                pow = pow * a;
            }
            return pow;

        }

        /**
        * 
        * @name RecursiveBinarySearch
        * 
        * @param [in] arr [\b int[]]
        * retval [\b int []] 
        * Recursive binary search is an implementation of the binary search algorithm that uses recursive method calls.
        **/

        public static int RecursiveBinarySearch(int[] arr, int l, int r, int x)
        {
            if (r >= l)
            {
                int mid = l + (r - l) / 2;


                if (arr[mid] == x)
                    return mid;


                if (arr[mid] > x)
                    return RecursiveBinarySearch(arr, l, mid - 1, x);


                return RecursiveBinarySearch(arr, mid + 1, r, x);
            }
            return -1;
        }

        /**
        * 
        * @name IterativeBinarySearch
        * 
        * @param [in] arr [\b int[]]
        * retval [\b int []] 
        * Binary search begins by comparing the middle element of the array to the target value.
        * •	If the target value is equal to the middle element, its position in the array is returned.
        **/
        public static int IterativeBinarySearch(int[] arr, int x)
        {
            int l = 0, r = arr.Length - 1;
            while (l <= r)
            {
                int m = l + (r - l) / 2;


                if (arr[m] == x)
                    return m;

                if (arr[m] < x)
                    l = m + 1;

                else
                    r = m - 1;
            }
            return -1;
        }

        /**
        * 
        * @name MasterMethod
        * 
        * @param [in] x [\b int]
        * @param [in] y [\b int]
        * @param [in] f [\b string]     
        **/
        public static string MasterMethod(int x, int y, string f)
        {
            double e = Math.Log(Convert.ToDouble(x), Convert.ToDouble(y));
            double a;
            try
            {
                a = Convert.ToDouble(f.Replace("n^", ""));

            }
            catch (Exception)
            {
                a = 1;
            }

            if (x >= 1)
            {
                if (e > a)
                {
                    return "T(n) = n^" + e;
                }
                else if (e == a)
                {
                    return "T(n) = n^" + e + "logn";
                }
                else if (e < a)
                {
                    return "T(n) = n^" + a;
                }
            }
            return "Incalculable!";
        }



    }
}




