// Задайте строку, содержащую латинские буквы в обоих регистрах. Сформируйте строку, в которой все заглавные буквы заменены на строчные

string RequestLine()
{
    Console.Write("Введите строку: ");
    string text = Console.ReadLine();
    return text;
}

string ConvertLineLover(string text)
{
    text = text.ToLower();
    return text;
}

Console.WriteLine($"Преобразованный текст: {ConvertLineLover(RequestLine())} ");
