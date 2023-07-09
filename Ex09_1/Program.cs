// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
//Ввод значений
int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

//Сумма элементов заданного диапазона M-N
int SumElements(int m, int n)
{
    if (m == n)
    {
        return m;
    }
    return n + SumElements(m, n - 1);
}

//Проверка диапазона значений
bool ValidRang(int n, int m)
{
    if (n > m)
    {
        return false;
    }
    else
        return true;
}

//.............................................
int m = ReadInt("Введите число: ");
int n = ReadInt("Введите число: ");

if (ValidRang(m, n))
{
    System.Console.WriteLine($"Сумма элементов диапазона от {m} до {n} равна  {SumElements(m, n)}");
}
else
{
    System.Console.WriteLine("Диапазон задан не верно!");
}