// Задайте двумерный массив символов (тип char [,]). Создать строку из символов этого массива.

string GetStringFromCharArray (char[,] array)
{
    string result = string.Empty; 
    foreach (char symbol in array) 
    {
       result += symbol;
    }
    return result;
}

char[,] chars = {
                {'1', 'd', '!', '2', 'f'},
                {'4', 'k', 't', '8', 'x'},
                {'l', '0', ';', '5', 'h'},
                {'e', 't', 'o', '4', '.'}
                };
string res = GetStringFromCharArray(chars);
Console.WriteLine($"Result: {res}");