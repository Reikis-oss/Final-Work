Console.Clear();

//Метод создающий массив из строк 
string[] ShortStringsFilter3Char(string[] arr, int limit)
{
    // Считаем количество строк, содержащих не более 3 символов
    int count = CountShortWords(arr, limit);

    // Создаем массив для строк, длина которых не более 3 символов
    int indexRes = 0;
    string[] res = new string[count];

    // Проходим по всем строкам из исходного массива
    for (int index = 0; index < arr.Length; index++)
    {
        // Если длина строки меньше 4 символов, то добавляем ее в результирующий массив
        if (arr[index].Length < limit)
        {
            res[indexRes] = arr[index];
            indexRes++;
        }
    }

    // Возвращаем результирующий массив
    return res;
}


int CountShortWords(string[] arr, int limit)
{
    int res = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length < limit)
        {
            res++;
        }
    }
    return res;
}

void Print1DArrLine(string[] arr)
{
    Console.Write("{");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write($"'{arr[i]}', ");
    }
    Console.WriteLine($"'{arr[arr.Length - 1]}'}}");
}

void PrintData(string mes)
{
    Console.WriteLine(mes);
}

int ReadInputInt(string mes)
{
    Console.Write(mes);
    return Convert.ToInt32(Console.ReadLine() ?? "0");
}

string ReadInputString()
{
    return Console.ReadLine() ?? "0";
}

string[] CreateArrSrting(int count)
{
    string[] res = new string[count];

    for (int i = 0; i < count; i++)
    {
        Console.Write($"Введите текст {i + 1} строки: ");
        res[i] = ReadInputString();
    }

    return res;
}


int countString = ReadInputInt("Введите количество строк: ");
string[] strArr = CreateArrSrting(countString);

int limitChar = ReadInputInt("Введите количество лимит символов в строке: ") + 1;
string[] resArr = ShortStringsFilter3Char(strArr, limitChar);

Console.WriteLine();
PrintData("Изначальный массив:");
Print1DArrLine(strArr);
PrintData("Отсортированный массив:");
Print1DArrLine(resArr);