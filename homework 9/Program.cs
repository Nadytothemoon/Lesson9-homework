Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии. 


 int Prompt(string message) 
 { 
    System.Console.Write(message);
     return Convert.ToInt32(Console.ReadLine()); 
     } 
      void ShowNumbers(int number) 
     { 
         if (number <= 0)
          {
             return ; 
             }
               System.Console.Write(number);
                ShowNumbers(number - 1 ); 
               } 
                int number = Prompt("Введите номер >");
  ShowNumbers(number); 



Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

Console.Write("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());
SumMToN(m, n); 
void SumMToN(int m, int n)
  { 
   Console.Write(SumMN(m - 1, n)); 
      }
int SumMN(int m, int n) 
  { 
int res = m; 
   if (m == n)
 return 0; 
   else 
      {
        m++;
          res = m + SumMN(m, n);
           return res;
      }
                     } 

                  

 Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 


Console.WriteLine("Введите начальное число M:");
int numberM = int.Parse(Console.ReadLine());
Console.WriteLine("Введите начальное число N:"); 
int numberN = int.Parse(Console.ReadLine());
int AckermannFunction (int numberM, int numberN) 
   { 
     if (numberM == 0) return numberN + 1;
         if (numberM != 0 && numberN == 0) return AckermannFunction(numberM - 1, 1);
             if (numberM > 0 && numberN > 0) return AckermannFunction(numberM - 1, AckermannFunction(numberM, numberN - 1)); 
return AckermannFunction(numberM, numberN);
      } 
Console.WriteLine($"Функция Аккермана для чисел A({numberM},{numberN}) = {AckermannFunction(numberM, numberN)}");