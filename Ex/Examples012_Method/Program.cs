// 1 вид

void Method1()
{
Console.WriteLine("Автор …");
}
Method1();

// 2 вид

void Method2(string msg) // где void ключевое слово, дальше идентификатор, в скобках указаны какие-то аргументы.
{
Console.WriteLine(msg); // оператор, в скобках указан принятый аргумент.
}
Method2("Текст сообщения"); // где Metod2 является идентификатором, а в скобках указан текст, выводимый в консоли.


void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg); // где переменная count отображает на экране определённое количество сообщений msg.
        i++;
    }
}
Method21(msg: "Текст", count: 4);


// вид 3

int Method3() // не принимает никакие аргументы

{
    return DataTime.Now.Year; // обязательное использование оператора return,
}

int year = Method3(); // вызываем метод, в левой части используем идентификатор переменной (year) и через оператор 
Console.WriteLine(year);

// вид 4

string Method4(int count, string text)
{
    int i = 0;
    string result = String.Empty;
    while (i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}
string res = Method4(10, "asdf");
Console.WriteLine(res);


string Method4(int count, string text)
{
    string result = String.Empty;
    for (int i = 0; i < count; i++) // вначале ключевое слово, затем инициализация счётчика, после проверка условия и инкремент (увеличение счётчика).
    {
        result = result + text;
    }
    return result;
}
string res = Method4(10, "asdf");
Console.WriteLine(res);