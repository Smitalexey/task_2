using System; 
  class Program 
  {
     static void Main()
    {
Console.WriteLine("Введите любое число до 7, каждая цифра обозначает день по порядку, где 1  - это понедельник и так далее");
int n = Convert.ToInt32(Console.ReadLine());
if (n == 1 || n == 2 || n == 3 || n == 4 || n == 5) Console.WriteLine("Будний день");
else Console.WriteLine("Выходной день");
    }
  }