// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2


// int[] array = GetRandomArray(20, 100, 1000);
// Console.WriteLine(String.Join(" ", array));
// Console.WriteLine($"Количество четных элементов в массиве = {GetEvenCount(array)}");

// int[] GetRandomArray(int size, int minValue, int maxValue)
// {
//     int[] result = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         result[i] = new Random().Next(minValue, maxValue);
//     }
//     return result;
// }

// int GetEvenCount(int[] array)
// {
//     int count = 0;
//     foreach (var item in array)
//     {
//         if (item % 2 == 0) count++;
//     }
//     return count;
// }




// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

// int[] array = GetRandomArray(4, -100, 100);
// Console.WriteLine(String.Join(" ", array));
// Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях = {OddSum(array)}");

// int[] GetRandomArray(int size, int minValue, int maxValue)
// {
//     int[] result = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         result[i] = new Random().Next(minValue, maxValue);
//     }
//     return result;
// }

// int OddSum(int[] array)
// {
//     int sum = 0;
//     for (int i = 1; i < array.Length; i = i + 2)
//     {
//         sum = sum + array[i];
//     }
//     return sum;
// }




// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

// double[] array = GetRandomArray(10, -100, 100);
// Console.WriteLine(String.Join("; ", array));
// Console.WriteLine($"Разница между максимальным и минимальным элементом массива = {DiffMaxMin(array)}");

// double[] GetRandomArray(int size, int minValue, int maxValue)
// {
//     var rnd = new Random();
//     double[] result = new double[size];
//     for (int i = 0; i < size; i++)
//     {
//         result[i] = rnd.Next(minValue, maxValue) + Math.Round(rnd.NextDouble(), 1);
//     }
//     return result;
// }

// double DiffMaxMin(double[] array)
// {
//     double maxElem = array[0];
//     double minElem = array[0];
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] >= maxElem)
//             maxElem = array[i];
//         if (array[i] <= minElem)
//             minElem = array[i];
//     }
//     return maxElem - minElem;
// }
