// Задайте произвольную строку. Выясните, является ли она палиндромом.
string RequestLine()
{
    Console.Write("Введите строку: ");
    string text = Console.ReadLine();
    return text;
}

bool PalindromeChecking (string text)
{
    text = text.ToLower();
    for (int i = 0,  j = text.Length - 1; i < text.Length / 2; i++, j--)
    {
        if (text[i] != text[j])
        {
            return false;
        }
    }
    return true;
}
Console.WriteLine((PalindromeChecking(RequestLine()))? "Строка является палиндромом":"Строка не является палиндромом");

