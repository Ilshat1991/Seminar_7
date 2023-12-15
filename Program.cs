// Задача 1

// void rec(int n, int m)
// {
//     if (n < m) return;
//     else
//     {
//         rec (n-1, m); 
//         Console.Write($"{n} ");       
//     }
// }

// Console.Clear();
// Console.Write("Введите M: ");
// int m = int.Parse(Console.ReadLine());
// Console.Write("Введите N: ");
// int n = int.Parse(Console.ReadLine());
// rec (n, m);



// Задача 2

// int AccermanFunc(int n, int m)
// {
//     if (n == 0) return (m+1);
//     else if (m == 0) return (AccermanFunc(n-1, 1));
//     else  return (AccermanFunc(n-1, AccermanFunc(n,m-1)));
// }

// Console.Clear();
// Console.Write("Введите N: ");
// int n = int.Parse(Console.ReadLine());
// Console.Write("Введите M: ");
// int m = int.Parse(Console.ReadLine());
// int x = AccermanFunc (n, m);
// Console.Write(x);



// Задача 3 

// void FillArray(int[] array)
// {
//     for(int i = 0; i < array.GetLength(0); i++)
//         array[i] = new Random().Next(-100, 101);
// }


// void PrintRecArray (int[] array, int arrLength)
// {
//     if (arrLength == 0) return;
//     Console.Write($"{array[arrLength - 1] } \t");
//     PrintRecArray (array, (arrLength-1));
// }

// Console.Clear();
// Console.Write("Введите колличество элементов массива ");
// //int n = int.Parse(Console.ReadLine());
// int[] arr1 = new int [int.Parse(Console.ReadLine())];
// FillArray(arr1);
// Console.WriteLine("Исходный массив: " + string.Join("\t", arr1));
// Console.Write("Перевернутый массив: ");
// PrintRecArray(arr1, arr1.Length);