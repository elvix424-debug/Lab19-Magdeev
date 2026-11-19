int CountCharacter(string text, char target)
{
    int count = 0;

    for (int i = 0; i < text.Length; i++)
    {
        if (text[i] == target)
        {
            count++;
        }
    }

    return count;
}
Console.WriteLine(CountCharacter("мама", 'м'));
Console.WriteLine(CountCharacter("Код 2026", ' '));
Console.WriteLine(CountCharacter("", 'а'));




int CountDigits(string text)
{
    int count = 0;

    foreach (char symbol in text)
    {
        if (char.IsDigit(symbol))
        {
            count += 1;
        }
    }

    return count;
}


int CountLetters(string text)
{
    int count = 0;

    foreach (char symbol in text)
    {
        if (char.IsLetter(symbol))
        {
            count++;
        }
    }

    return count;
}

Console.WriteLine(CountDigits("A2B3"));
Console.WriteLine(CountLetters("Код 2026!"));





int FindCharacterIndex(string text, char target)
{
    int index = -1;

    for (int i = 0; i < text.Length; i++)
    {
        if (text[i] == target)
        {
            return i;
        }
    }

    return index;
}

Console.WriteLine(FindCharacterIndex("banana", 'a'));
Console.WriteLine(FindCharacterIndex("banana", 'b'));
Console.WriteLine(FindCharacterIndex("banana", 'z'));
Console.WriteLine(FindCharacterIndex("", 'a'));