// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
  Console.WriteLine("Введите число -> ");
  int num = Convert.ToInt32(Console.ReadLine());

  if(num < 0)
  {
    Console.WriteLine("Введите число которое больше нуля ");
  }
  int count = 2;
 while (count <= num)
 {
    if (count%2 == 0)
    {Console.WriteLine(count + "" );}
 
 count++;
 }