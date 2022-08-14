using System; //попробовать решить 2 задачу
class Program
{
    static void Main()
    {
        Console.Write("Введите любое натуральное число: ");
        int number = Convert.ToInt32(Console.ReadLine());
        string numberText = Convert.ToString(number);
        if (numberText.Length > 2)
        {
            Console.WriteLine("третья цифра числа - " + numberText[2]);
            }
            else
            {
                Console.WriteLine("третьей цифры нет");
            }
    }
}