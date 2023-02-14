Console.Write("Определение формата дня недели - Введите число от 1 до 7: ");
int number = int.Parse(Console.ReadLine()!);

int result = (number / 100) % 10;

if (number <= 7)
{
    if(number >= 6)
    {
        Console.WriteLine($"{number} день недели -> выходной");
    }

    else
    {
        Console.WriteLine($"{number} день недели -> рабочий");
    }
}    
else
{
    Console.WriteLine($"Не верно введённые данные, в неделе 7 дней");
}