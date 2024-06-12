string[] words_array;
Console.WriteLine("Введите несколько строк через запятую");
string words = Console.ReadLine();
words_array = words.Split(',');
string[] final_words = new string[words_array.Length];
int j = 0;
foreach (var word in words_array)
{
    if (word.Length <= 3)
    {
        final_words[j] = word;
        j++;
    }
}
Console.WriteLine(string.Join(", ", final_words, 0, j));