// (не обязательная): Задайте строку, состоящую из слов, разделенных пробелами. 
// Сформировать строку, в которой слова расположены в обратном порядке. В полученной строке слова должны быть также разделены пробелами.

string RequestLine()
{
    Console.Write("Введите строку: ");
    string text = Console.ReadLine();
    return text;
}

int CountingWord(string text)
{
    int countWord = 1;
    for (int i = 0; i < text.Length; i++)
    {
        if (text[i] == ' ')
        {
            countWord++;
        }
    }
    return countWord;
}

string [] СreatingArrayStrings(string text, int countWord)
{
    string [] wordArray = new string [countWord];
    string word = string.Empty;
    int count = 0;
    foreach (char symbol in text)
    {
        if (symbol == ' ')
        {
            wordArray[count] = word;
            count++;
            word = string.Empty;
        }
        else
        {
            word += symbol;
        }
    }
    wordArray[count] = word;
    return wordArray;
}

void ReversingArray(string[] wordArray) 
{
    for (int i = 0, j = wordArray.Length - 1; i < wordArray.Length / 2; i++, j--)
    {
        string temp = wordArray[i];
        wordArray[i] = wordArray[j];
        wordArray[j] = temp;
    }
}

string text = RequestLine();
int countWord = CountingWord(text);
string [] wordArray = СreatingArrayStrings(text, countWord);
ReversingArray(wordArray);
string newText = String.Join(" ", wordArray);
Console.WriteLine(newText);
