//задайте масси из 12 элементов,заполненный случайными числами от -9 до 9
//найдите сумму положительных и отрицательных элементов
 int[] GetArray(int size,int minValue,int maxValue)
 {
    int[] res=new int[size];
    for (int i=0;i<size;i++)
    { res[i]=new Random().Next(minValue,maxValue+1);
    }
    return res;
 
 }
 void СountNumbers(int[] array)
 {  
    int positiveSum=0;
    int negativeSum=0;
    foreach(int el in array)
    { 
        positiveSum+=el>0 ? el:0;//if el>0;pos+=el;else pos+=0
        negativeSum+=el<0 ? el:0; 

    }
    Console.WriteLine($"сумма положительных элементов {positiveSum}");
    Console.WriteLine($"сумма отрицательных элементов {negativeSum}");


 }
 int[] array=GetArray(-12,-9,9);
 Console.WriteLine(String.Join(" ",array));
 СountNumbers(array);



// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
// */

// int number = ReadInt("Введите число: ");
// int len = NumberLen(number);
// SumNumbers(number, len);


// // Функция ввода
// int ReadInt(string message)
// {
//     Console.Write(message);
//     return Convert.ToInt32(Console.ReadLine());
// }

// // Функция подсчета цифр в числе
// int NumberLen(int a)
// {
//     int index = 0;
//     while (a > 0)
//     {
//         a /= 10;
//         index++;
//     }
//     return index;
// }

// // Функция вывода суммы цифр в числе
// void SumNumbers(int n, int len)
// {
//     int sum = 0;
//     for (int i = 1; i <= len; i++)
//     {
//         sum += n % 10;
//         n /= 10;
//     }
//     Console.WriteLine(sum);
// }




