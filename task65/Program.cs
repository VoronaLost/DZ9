// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int inputnumber(string variableName)
{
    bool isNumber = false;
    Console.WriteLine($"Введите {variableName}: ");
    int finalNumber=0;
    while (isNumber == false)
        {
        string input = Console.ReadLine();
        isNumber = int.TryParse(input, out finalNumber);
        if (finalNumber < 0) isNumber = false;
        if (isNumber==false)
        Console.WriteLine($"Неверный формат, введите натуральное значение {variableName}:");
        }
    return finalNumber;
}

int M = inputnumber("число M");
int N = inputnumber("число N");
int SummOutput (int start, int end)
{
    if (start > end)
    {
        Console.WriteLine("Вы ввели M > N, нет натуральных чисел в промежутке, сумма равна:");
        return 0;
    }
    if (start == end) return start;
    return (start + SummOutput(start + 1, end));
}
Console.WriteLine($"Сумма элементов между {M} и {N}:");
Console.WriteLine(SummOutput(M, N));
