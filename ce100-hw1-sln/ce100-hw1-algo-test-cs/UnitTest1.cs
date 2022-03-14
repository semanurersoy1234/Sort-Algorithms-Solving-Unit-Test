using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ce100_hw1_algo_test_cs;
using ce100_hw1_algo_lib_cs;

namespace ce100_hw1_algo_test_cs
{
    [TestClass]
    public class UnitTest1
    {
            [TestMethod]
            public void InsertionSort_Test1()
            {
                int[] array = { 13, 5, 34, 22, 18 };
                Class1.InsertionSort(array);
                int[] result = { 5, 13, 18, 22, 34 };
                CollectionAssert.AreEqual(array, result);

            }

            [TestMethod]
            public void InsertionSort_Test2()
            {
                int[] array = { 7, 16, 38, 13, 25, 22 };
                Class1.InsertionSort(array);
                int[] result = { 7, 13, 16, 22, 25, 38 };
                CollectionAssert.AreEqual(array, result);

            }
            [TestMethod]
            public void InsertionSort_Test3()
            {
                int[] array = { 27, 58, 61, 47, 18, 8, 34 };
                Class1.InsertionSort(array);
                int[] result = { 8, 18, 27, 34, 47, 58, 61 };
                CollectionAssert.AreEqual(array, result);
            }
            [TestMethod]
            public void SelectionSort_Test1()
            {
                int[] array = { 5, 10, 3, 36, 42, 27 };
                Class1.SelectionSort(array);
                int[] result = { 3, 5, 10, 27, 36, 42 };
                CollectionAssert.AreEqual(array, result);

            }
            [TestMethod]
            public void SelectionSort_Test2()
            {
                int[] array = { 36, 7, 87, 27, 13, 46, 68 };
                Class1.SelectionSort(array);
                int[] result = { 7, 13, 27, 36, 46, 68, 87 };
                CollectionAssert.AreEqual(array, result);
            }

            [TestMethod]
            public void SelectionSort_Test3()
            {
                int[] array = { 32, 5, 72, 18, 56, 13, 25 };
                Class1.SelectionSort(array);
                int[] result = { 5, 13, 18, 25, 32, 56, 72 };
                CollectionAssert.AreEqual(array, result);
            }

            [TestMethod]
            public void RecursiveMergeSort_Test1()
            {
                int[] array = { 25, 4, 38, 12, 58, 42 };
                Class1.RecursiveMergeSort(array, 0, array.Length - 1);
                int[] result = { 4, 12, 25, 38, 42, 58 };
                CollectionAssert.AreEqual(array, result);
            }

            [TestMethod]
            public void RecursiveMergeSort_Test2()
            {
                int[] array = { 13, 7, 65, 24, 42, 35 };
                Class1.RecursiveMergeSort(array, 0, array.Length - 1);
                int[] result = { 7, 13, 24, 35, 42, 65 };
                CollectionAssert.AreEqual(array, result);
            }

            [TestMethod]
            public void RecursiveMergeSort_Test3()
            {
                int[] array = { 46, 78, 4, 26, 14, 35 };
                Class1.RecursiveMergeSort(array, 0, array.Length - 1);
                int[] result = { 4, 14, 26, 35, 46, 78 };
                CollectionAssert.AreEqual(array, result);
            }
        [TestMethod]
        public void RecursivePower_Test1()
        {
            Assert.AreEqual(Class1.RecursivePower(6, 3), 216);

        }
        [TestMethod]
        public void RecursivePower_Test2()
        {
            Assert.AreEqual(Class1.RecursivePower(7, 2), 49);

        }
        [TestMethod]
        public void RecursivePower_Test3()
        {
            Assert.AreEqual(Class1.RecursivePower(569, 0), 1);

        }
        [TestMethod]
        public void NaivePower_Test1()
        {
            Assert.AreEqual(Class1.Naive_Power(3, 4), 81);
        }

        [TestMethod]
        public void NaivePower_Test2()
        {
            Assert.AreEqual(Class1.Naive_Power(16, 2), 256);
        }

        [TestMethod]
        public void NaivePower_Test3()
        {
            Assert.AreEqual(Class1.Naive_Power(8, 3), 512);
        }

        [TestMethod]
        public void RecursiveBinarySearch_Test1()
        {
            int[] array = { 7, 9, 14, 18, 27, 36, 45 };
            int n = array.Length;
            int a = 27;
            Assert.AreEqual(Class1.RecursiveBinarySearch(array, 0, n - 1, a), 4);
        }

        [TestMethod]
        public void RecursiveBinarySearch_Test2()
        {
            int[] array = { 8, 10, 17, 38, 105, 156, 189, 210, 252 };
            int n = array.Length;
            int a = 38;
            Assert.AreEqual(Class1.RecursiveBinarySearch(array, 0, n - 1, a), 3);
        }

        [TestMethod]
        public void RecursiveBinarySearch_Test3()
        {
            int[] array = { 3, 12, 27, 65, 72, 85, 92, 141 };
            int n = array.Length;
            int a = 85;
            Assert.AreEqual(Class1.RecursiveBinarySearch(array, 0, n - 1, a), 5);
        }

        [TestMethod]
        public void IterativeBinarySearch_Test1()
        {
            int[] array = { 8, 38, 56, 65, 92, 178 };
            int a = 8;
            Assert.AreEqual(Class1.IterativeBinarySearch(array, a), 0);
        }

        [TestMethod]
        public void IterativeBinarySearch_Test2()
        {
            int[] array = { 19, 25, 45, 62, 75, 87, 102, 189, 228 };
            int a = 189;
            Assert.AreEqual(Class1.IterativeBinarySearch(array, a), 7);
        }

        [TestMethod]
        public void IterativeBinarySearch_Test3()
        {
            int[] array = { 32, 56, 75, 92, 125, 224, 241, 266, 351 };
            int a = 75;
            Assert.AreEqual(Class1.IterativeBinarySearch(array, a), 2);
        }

        [TestMethod]
        public void MasterMethod_Test1()
        {
            Assert.AreEqual(Class1.MasterMethod(10, 100, "n^2"), "T(n) = n^2");
        }

        [TestMethod]
        public void MasterMethod_Test2()
        {
            Assert.AreEqual(Class1.MasterMethod(5, 125, "n^3"), "T(n) = n^3");
        }

        [TestMethod]
        public void MasterMethod_Test3()
        {
            Assert.AreEqual(Class1.MasterMethod(4, 4, "n^1"), "T(n) = n^1logn");
        }
    }
}
    

