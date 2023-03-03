using System.Text;
using System.Text.RegularExpressions;

namespace NetStringsApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            
            ^ - соответсвие на начало строки @"^Wo"
            $ - соответсвие на конец строки @"\w*ld$"
            . - любой символ "м.р"
            * - повторение предыдущего символа (набора) 0 и более раз
            + - повторение предыдущего символа (набора) 1 и более раз
            ? - повторение предыдущего символа (набора) 0 или 1 раз
            \w - алфавитные символы и цифры
            \W - все кроме алфавитные символы и цифры
            \s - любые пробельные символы
            \S - все кроме пробельные символы
            \d - любая цифра
            \D - все кроме любая цифра

            */


            string str = "Бык тупогуб тупогубенький бычок. У быка бела губа, была тупа";

            Regex regex = new Regex(@"туп(\w*)");
            MatchCollection matches = regex.Matches(str);
            foreach (Match match in matches)
                Console.WriteLine(match.Value);
        }

        static void StringExample()
        {
            var s1 = new String("Hello world");
            var s2 = new String('*', 10);
            Console.WriteLine(new String('*', 10));

            var s3 = new String("Hello world".ToCharArray(), 3, 6);


            string str1 = "*** Hello ***";
            Console.WriteLine(str1.StartsWith("***"));
            Console.WriteLine(str1.EndsWith("***"));

            string path = @"D:\Users\Works {str1}";

            string multiStr = @"jhkh kasjdfhasdjk dfkasjhf
    asdfasl asdlf jasflj aslkfj asdl fj
                fasdf asd fasdf asdfasd";

            string multyStr2 =
                """
                dasl lkjksdafs
                dfasdfasdf
                asdffasdfasdf
                """;

            Console.WriteLine(multyStr2);
            int a = 100;
            DateTime dateTime = DateTime.Now.AddMonths(5);

            System.Globalization.CultureInfo culture = new System.Globalization.CultureInfo("ru-ru");

            Console.WriteLine(String.Format(culture, "a = {0}, date now: {1}", a, dateTime));

            Console.WriteLine(str1.IndexOf("lll"));
            Console.WriteLine(str1.Insert(10, "world "));
            Console.WriteLine(str1);

            string[] names = new[] { "Bob", "Joe", "Sam" };
            string strName = String.Join(", ", names);
            Console.WriteLine(strName);

            string strCsv = "1965;Мышка,А правильней использовать Ёлочки;;4900,00";
            string[] arrCsv = strCsv.Split(new string[] { ";", "," }, StringSplitOptions.None);
            Console.WriteLine();
            foreach (var item in arrCsv)
                Console.WriteLine(item);
            string text = "В этом примере используется Format(IFormatProvider, String, Object[]) метод для отображения строкового представления некоторых значений даты и времени и числовых значений с использованием нескольких различных языков и региональных параметров.";
            string[] words = text.Split(' ');
            Console.WriteLine();
            foreach (var item in words)
                Console.WriteLine(item);

            string str2 = "Hello world, hello people";
            Console.WriteLine(str2.Replace("Hello", "Good by"));

            str2 = str2.Replace("Hello", "Good by");

            Console.WriteLine(str2.Insert(11, " ---- "));
            Console.WriteLine(str2.Substring(5, 7));

            string str3 = "     Hello      ";
            Console.WriteLine(str3.Trim() + str3.Trim());
            Console.WriteLine(str3.ToLower() + " " + str3.ToUpper());

            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("Hello");
            strBuilder.Insert(3, " ----- ");
            Console.WriteLine(strBuilder);
            string sb = strBuilder.ToString();
        }
    }
}