// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// Console.Write("Введите число A");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число B");
// int b = Convert.ToInt32(Console.ReadLine());

// int GetDegree ()
// {
//     int c=1;
//     for (int i=0; i<b; i++)
//     {
//         c= c*a;
//     }
//    return c;

//    }
//    Console.Write(GetDegree());


// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]


// int [] array= new int[8];
// GetArray();

// void GetArray()
// {
//    for (int i = 0; i < array.Length; i++)
//  {
//     array[i] = new Random().Next(0,100);
//     Console.Write(array[i]+" ");
//  }

// }


//    Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Write("Введите число");
 int num = Convert.ToInt32(Console.ReadLine());
 int GetSum()
 {
 int sum=0;
 for (int i=0; i<num;i++ )
 {
      sum = sum + num % 10;
                num = num /10 ;
 }
 return sum;
 }
 Console.WriteLine(GetSum());

