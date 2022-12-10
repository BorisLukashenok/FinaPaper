
using static System.Console;
Clear();

bool СorrectInput(string str, out int number)
{
    number = 0;
    if (int.TryParse(str, out number))
        return true;
    else
        return false;
}

int numOfString,
    count = 0;

do
{
    Write("Введите количесво строк: ");

    if (СorrectInput(ReadLine()!, out numOfString))
        break;
    else
        WriteLine("Вы ввели не число!!!");
} while (true);

string[] stringArray = new string[numOfString];

for (int i = 0; i < stringArray.Length; i++)
{
    Write($"Введите {i + 1}ю строку: ");
    stringArray[i] = ReadLine()!;
    if (stringArray[i].Length <= 3)
        count++;
}
if (count == 0)
    WriteLine("В введеном списке нет строк длинной меньше или равных трем.");
else
{
    string[] outStringArray = new string[count];
    WriteLine($"{count} {count switch
    {
        1 => "строка длинна которой",
        > 1 and < 5 => "строки длинна которых",
        _ => "строк длинна которых"
    }} меньше или равна трем:");
    count = 0;
    for (int i = 0; i < stringArray.Length; i++)
    {
        if (stringArray[i].Length <= 3)
        {
            outStringArray[count] = stringArray[i];
            WriteLine(outStringArray[count]);
            count++;
        }
    }
}


