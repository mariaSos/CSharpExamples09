// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.

//A(m, n) = n + 1, если m=0,
//A(m, n) = A(m-1, 1), если m#0, n=0,
//A(m, n) = A(m-1, A(m, n – 1)) , если m>0, n>0

//Ввод значений
int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

//Проверка значений
bool ValidParameter(int m, int n, out string message)
{
    message = "Результат функции Аккермана равен ";
    if (m < 0 || n < 0)
    {
        message = "Задано отрицательное значение!";
        return false;
    }
    else
    if (m > 4 || n > 4)
    {
        message = "Задано слишком большое значение";
        return false;
    }
    return true;
}

//Функция Аккермана
int FuncAkkerman(int m, int n)
{
    if (m == 0)
        return n + 1;
    else
      if (n == 0 && m != 0)
        return FuncAkkerman(m - 1, 1);
    else
        return FuncAkkerman(m - 1, FuncAkkerman(m, n - 1));
}

//.............................................
int n = ReadInt("Введите число m: ");
int m = ReadInt("Введите число n: ");

if (ValidParameter(m, n, out string message))
{
    System.Console.WriteLine($"{message} {FuncAkkerman(n, m)}");
}
else
{
    System.Console.WriteLine(message);
}