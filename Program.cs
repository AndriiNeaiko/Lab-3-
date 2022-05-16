using System.Text;

public class Laboratorka
{
    public static void TotalNumber(string str)
    {
        int i, wrd, l;

        Console.Write("\n\n Порахуйте загальну кількість слів у рядку:\n");
        Console.Write(" ------------------------------------------------------\n");

        l = 0;
        wrd = 1;


        while (l <= str.Length - 1)
        {
            if (str[l] == ' ' || str[l] == '\n' || str[l] == '\t')
            {
                wrd++;
            }
            l++;
        }

        Console.Write(" Загальна кількість слів у рядку дорівнює:  {0}\n", wrd);

    }

    static string remVowel(string str)
    {
        char[] vowels = { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };

        List<char> al = vowels.OfType<char>().ToList(); ;

        StringBuilder sb = new StringBuilder(str);

        for (int i = 0; i < sb.Length; i++)
        {
            if (al.Contains(sb[i]))
            {
                sb.Replace(sb[i].ToString(), "");
                i--;
            }
        }


        return sb.ToString();
    }
    // Метод драйвера для перевірки вищевказаної функції
    public static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.Default;
        Console.Write("\n Напишіть свій текст:");
        string str = Console.ReadLine();

        TotalNumber(str);
        Console.Write("\n Видаляє голосну з коду:\n");
        Console.Write(" ------------------------------------------------------\n");
        Console.Write(" " + remVowel(str));
        Console.Write("\n\n");
        Console.ReadLine();
    }
}