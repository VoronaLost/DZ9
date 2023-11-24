// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 29

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
int Akkerman (int m, int n)
{
    if (m == 0) return n+1;
    else if (m > 0 && n == 0) return Akkerman(m-1, 1);
    else return Akkerman(m - 1, Akkerman(m, n-1));
}
Console.WriteLine($"Функция Аккермана для заданных M = {M} и N = {N}:");
Console.WriteLine(Akkerman(M, N));
