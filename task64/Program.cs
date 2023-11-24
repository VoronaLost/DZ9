// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5. -> "1, 2, 3, 4, 5"
// M = 4; N = 8. -> "4, 6, 7, 8"
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
string PrintNumbers (int start, int end)
{
    if (start > end)
    {
        Console.WriteLine("Вы ввели M > N, нет натуральных чисел в промежутке");
        return "";
    }
    if (start == end) return start.ToString();
    return (start + "\t" + PrintNumbers(start + 1, end));
}
Console.WriteLine($"Все натуральные числа в промежутке от {M} до {N}:");
Console.WriteLine(PrintNumbers(M, N));
