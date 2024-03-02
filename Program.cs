

using System.Diagnostics.Tracing;
using System.Runtime.CompilerServices;

namespace Strings2
//pls upload
{
    class Program
    {
        public static void Main(string[] args)
        {

        }
    }
    class Answers
    {
        public static void ex1()
        {
            string w1 = Console.ReadLine();
            string w2 = Console.ReadLine();
            Console.WriteLine((w1.Length > w2.Length) ? w1 : w2);
        }
        public static void ex2()
        {
            string s1 = Console.ReadLine();
            string s2 = Console.ReadLine();
            Console.WriteLine(s1 + " " + s2);
            Console.WriteLine(s2 + " " + s2);
        }
        public static void ex3a()
        {
            string s1 = Console.ReadLine();
            string s2 = Console.ReadLine();
            Console.WriteLine((s1.Length > s2.Length) ? s1 + s2 : s2 + s1);
        }
        public static void ex3b()
        {
            string s1 = Console.ReadLine();
            string s2 = Console.ReadLine();
            string s3 = Console.ReadLine();
            if (s1.Length > s2.Length && s1.Length > s3.Length)
            {
                if (s2.Length > s3.Length)
                    Console.WriteLine(s1 + s2 + s3);
                else
                    Console.WriteLine(s1 + s3 + s2);
            }
            else if (s2.Length > s1.Length && s2.Length > s3.Length)
            {
                if (s1.Length > s3.Length)
                    Console.WriteLine(s2 + s1 + s3);
                else
                    Console.WriteLine(s2 + s3 + s1);
            }
            else
            {
                if (s1.Length > s2.Length)
                    Console.WriteLine(s3 + s1 + s2);
                else
                    Console.WriteLine(s3 + s2 + s1);
            }
        }
        public static void ex4()
        {
            string name = "";
            string longest = "";
            while (name != "end")
            {
                name = Console.ReadLine();
                if (name.Length > longest.Length)
                    longest = name;
            }
        }
        public static void ex5()
        {
            int over = 0;
            int under = 0;
            string input = Console.ReadLine();
            while (input != "END")
            {
                if (input.Length > 4)
                    over++;
                else
                    under++;
                input = Console.ReadLine();
            }
            Console.WriteLine("More than 4 chars: " + over + "\n4 or less: " + under);
        }
        public static void ex6()
        {
            string s = Console.ReadLine();
            char c = char.Parse(Console.ReadLine());
            int count = 0;
            for (int i = 0; i < s.Length; i++)
                if (s[i] == c)
                    count++;
            Console.WriteLine(count);
        }
        public static void ex7()
        {
            string input = Console.ReadLine();
            bool gottaPrint = true;
            for (int i = 0; i < input.Length - 1; i++)
            {
                if (input[i] == input[i + 1] && gottaPrint)
                {
                    gottaPrint = false;
                    Console.WriteLine(i);
                }
            }
            if (gottaPrint)
                Console.WriteLine(-1);
        }
        public static void ex8()
        {
            string s = Console.ReadLine();
            int lower = 0;
            int upper = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] >= 'a' && s[i] <= 'z')
                    lower++;
                else if (s[i] >= 'A' && s[i] <= 'Z')
                    upper++;
            }
            Console.WriteLine("Upper: " + upper + "\nLower: " + lower);
        }
        /*ex9a :
         * please explain - what am I doing?
         *  a=4
         *  b=0
         *  c=0
         *  d=1
         *  e=3
         *  f=0
         *  g=1
         *  h=1
         *  i=2
         *  j=0
         *  k=0
         *  l=2
         *  m=1
         *  n=2
         *  o=1
         *  p=2
         *  q=0
         *  r=0
         *  s=1
         *  t=1
         *  u=0
         *  v=0
         *  w=1
         *  x=1
         *  y=0
         *  z=0
         */
        //ex9b : Code prints the amount of each letter in the string.
        public static void ex10()
        {
            int input = int.Parse(Console.ReadLine());
            int[] appearances = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            while (input != 0)
            {
                appearances[input % 10]++;
                input /= 10;
            }
            Console.WriteLine("number    appearances");
            for (int i = 0; i < 10; i++)
                Console.WriteLine(i + "         " + appearances[i]);
            int maxAppearances = 0;
            for (int i = 0; i < 10; i++)
                if (appearances[i] > maxAppearances)
                    maxAppearances = appearances[i];
            Console.Write("Appeared the most: ");
            for (int i = 0; i < 10; i++)
                if (appearances[i] == maxAppearances)
                    Console.Write(i + ", ");
        }
        public static void ex11()
        {
            string s = Console.ReadLine();
            Console.WriteLine("First space index: " + s.IndexOf(' '));

            string word = ""; bool isWord = true, lastWordNotRan = true;
            while (s.Length > 1 && lastWordNotRan)
            {
                isWord = true;
                word = s.Substring(s.LastIndexOf(' '));
                for (int i = 0; i < word.Length; i++)
                    if ((word[i] < 'a' || word[i] > 'z') && (word[i] < 'A' || word[i] > 'Z'))
                        isWord = false;
                if (isWord)
                {
                    Console.WriteLine(s.LastIndexOf(' ') + 1);
                    lastWordNotRan = false;
                }
                else s = s.Substring(0, s.LastIndexOf(' '));
            }
            if (lastWordNotRan)
                Console.WriteLine("No words found");

            int words = 1;
            for (int i = 0; i < s.Length; i++) if (s[i] == ' ') words++;
            Console.WriteLine(words);
        }
        public static int ex12(string s)
        {
            if (s.Length > 80) return -1;
            int longest = 0;
            string[] words = s.Split(' ');
            for (int i = 0; i < words.Length; i++)
                if (words[i].Length > longest)
                    longest = words[i].Length;
            return longest;
        }
        public static void ex13()
        {
            string s = "  ";
            while (s[s.Length - 1] != '.' && s[s.Length - 2] != '*')
                s += Console.ReadLine()[0];
            s = s.Substring(2);
            for (int i = 0; i < s.Length - 1; i++)
            {
                if (s[i] == '*' && s[i + 1] == '*')
                {
                    Console.Write("*"); i++;
                }
                else if (s[i] == '*' && s[i] == ',')
                    Console.WriteLine();
            }
        }
        public static bool ex14(string s)
        {
            if (s.Length > 80) return false;
            string reverse = "";
            for (int i = s.Length - 1; i >= 0; i--)
                reverse += s[i];
            return reverse == s;
        }
        public static void ex15() => Console.WriteLine(Console.ReadLine().ToCharArray().Reverse().ToString());
        /*ex16a:
         * 97 a
         * 98 b
         * 99 c
         * 100 d
         * 101 e
         * 102 f
         * 103 g
         * 104 h
         * 105 i
         * 106 j
         * 107 k
         * 108 l
         * 109 m
         * 110 n
         * 111 o
         * 112 p
         * 113 q
         * 114 r
         * 115 s
         * 116 t
         * 117 u
         * 118 v
         * 119 w
         * 120 x
         * 121 y
         * 122 z
        */
        //ex16b: Code prints ascii value of each letter in the abc.
        /*ex17a:
         * 65 A
         * 66 B
         * 67 C
         * 68 D
         * 69 E
         * 70 F
         * 71 G
         * 72 H
         * 73 I
         * 74 J
         * 75 K
         * 76 L
         * 77 M
         * 78 N
         * 79 O
         * 80 P
         * 81 Q
         * 82 R
         * 83 S
         * 84 T
         * 85 U
         * 86 V
         * 87 W
         * 88 X
         * 89 Y
         * 90 Z
        */
        /*ex17b:
         * 48 0
         * 49 1
         * 50 2
         * 51 3
         * 52 4
         * 53 5
         * 54 6
         * 55 7
         * 56 8
         * 57 9
        */
        /*ex17c:
         * למרות שלא אמור להיות אפשרי משום שהאותיות העבריות לא כלולות בטבלת האסקי המקורית
         * בטבלה המורחבת (המשוכללת והחדשה יותר )כלולים הרבה יותר תווים מ255 וביניהם גם אותיות עבריות
         * לכן זה אפשרי ויש פלט הגיוני
         */
        public static void ex18()
        {
            string s = Console.ReadLine();
            int val = 0;
            for (int i = 0; i < s.Length; i++)
                if (s[i] < '0' || s[i] > '9')
                {
                    Console.WriteLine("Not a number");
                    return;
                }
            for (int i = 0; i < s.Length; i++)
                val += s[i] - '0';
            Console.WriteLine(val);
        }
        public static bool ex19a(string str) //idk if understood question
        {
            for (int i = 0; i < str.Length - 1; i++)
                if (str.Substring(i, 2) == "ab")
                    return true;
            return false;
        }
        public static void ex19b()
        {
            for (int i = 0; i < 10; i++)
                Console.WriteLine(ex19a(Console.ReadLine()));
        }
        public static void ex20()
        {
            string s1 = Console.ReadLine();
            if (s1.Length > 255) s1 = s1.Substring(0, 255);
            string s2, s3;
            if (s1.Length > 10)
            {
                s2 = Console.ReadLine().Substring(0, 10);
                s3 = Console.ReadLine().Substring(0, 10);
            }
            else
            {
                s2 = Console.ReadLine().Substring(0, s1.Length);
                s3 = Console.ReadLine().Substring(0, s1.Length);
            }
            // כתבתי את הפונקציות במחלקה נפרדת
            //היות ולא התבקשתי ליצור אותן בשאלות קודמות
            while (s1.IndexOf(s2) != -1)
                s1 = s1.delete(s1.IndexOf(s2), s2.Length).insert(s1.IndexOf(s2), s3);
        }
        public static void ex21() => Console.WriteLine(Console.ReadLine().Remove(' '));
        public static void ex22(string s)
        {
            string result = s[0].ToString();
            for (int i = 1; i < s.Length; i++)
                if (!(s[i - 1] == ' ' && s[i] == ' '))
                    result += s[i];
        }
        public static void ex23a()
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            string action = Console.ReadLine();
            Console.WriteLine((action == "ADD") ? n1 + n2 : n1 - n2);
        }
        //ex23b: gotta create "if" statements for each action

        public static void ex24a()
        {
            string s = Console.ReadLine();
            if (s.Length > 20) s = s.Substring(0, 20);
            Console.WriteLine(s.IndexOf("AA") > 0);
        }
        //ex24b: put "AAA" as an argument in the IndexOf method

        public static void ex25()
        {
            string s = Console.ReadLine();
            if (s.Length > 100) s = s.Substring(0, 100);
            int[] count = { 0, 0, 0 };
            for (int i = 0; i < s.Length; i++)
                count[s[i] - 'a']++;
            Console.WriteLine("a: " + count[0] + "\nb: " + count[1] + "\nc: " + count[2]);
            if (count[0] < count[1] && count[0] < count[2])
                Console.WriteLine("a appeared the least");
            else if (count[1] < count[0] && count[1] < count[2])
                Console.WriteLine("b appeared the least");
            else if (count[2] < count[0] && count[2] < count[1])
                Console.WriteLine("c appeared the least");
        }
        public static void ex26()
        {
            string s = Console.ReadLine();
            if (s.Length > 20) s = s.Substring(0, 20);
            for (int i = 0; i < s.Length; i++)
                if (s[i] != '*')
                    Console.Write($"{s[i]}{s[i]}");
        }
        public static void ex27()
        {
            string s = Console.ReadLine();
            if (s.Length > 75) s = s.Substring(0, 75);
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == ',') Console.WriteLine();
                else if (s[i] == '.') Console.WriteLine("\n");
                else Console.Write(s[i]);
            }
        }
        public static void PELET(string SOD, int n1, int n2) //ex28a
        {
            Console.WriteLine($"{SOD[n1]}{SOD[n2]}");
        }
        public static void ex28b()
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            while (input != "SOFSOFSOF")
                PELET(input, n1, n2);
        }
        public static void ex29a()
        {
            string s = Console.ReadLine();
            if (s.Length > 150) s = s.Substring(0, 150);
            int[] SOD = new int[20];
            for (int i = 0; i < SOD.Length; i++)
                SOD[i] = int.Parse(Console.ReadLine());
            int index = 0;
            int sum = 0;
            for (int i = 0; i < SOD.Length; i++) sum += SOD[i];
            if (sum > s.Length) { Console.WriteLine("Wrong input"); return; }
            for (int i = 0; i < SOD.Length; i++)
            {
                Console.Write($"{s.Substring(index, SOD[i])} ");
                index += SOD[i];
            }
        }
        //ex29b: gotta check if sum of SOD array is less than length of the string

        public static void ex30()
        {
            string s = "";
            string input;
            for (int i = 0; i < 15; i++)
            {
                input = Console.ReadLine();
                if (input[0] == input[input.Length - 1])
                    s = s + input + "\n";
            }
            Console.WriteLine(s);
        }
        public static void ex31()
        {
            string s = "";
            string input;
            for (int i = 0; i < 15; i++)
            {
                input = Console.ReadLine();
                if (input.Length > 15) input = input.Substring(0, 15);
                if (input.Substring(0, 3) == "www")
                    s = s + input + "\n";
            }
            Console.WriteLine(s);
        }

        public static int Func(int n, int k, string s) => (s.IndexOf("aa") != -1) ? n * k : (s.IndexOf("a") != -1) ? n + k : n - k; // ex32
        public static void ex32b()
        {
            int[,] arr = new int[25, 35];
            for (int height = 0; height < 25; height++)
                for (int width = 0; width < 35; width++)
                    arr[height, width] = Func(height, width, Console.ReadLine());
            int positive = 0; //counter for positive values in the array
            int negative = 0; //counter for negative values in the array 
            for (int i = 0; i < arr.GetLength(0); i++)
                for (int j = 0; j < arr.GetLength(1); j++)
                { if (arr[i, j] > 0) positive++; else if (arr[i, j] < 0) negative++; }
            Console.WriteLine("Array:");
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++) Console.Write(arr[i, j]);
                Console.WriteLine();
            }
            Console.WriteLine($"Positives: {positive}\nNegatives: {negative}");
        }
        public static void ex33()
        {
            string input = Console.ReadLine();
            string res = "";
            for (int i = 0; i < res.Length; i++)
                if (input[i] != ' ')
                    res += (input[i] < 'M') ? input[i] + (char)input[i] + 1 : input[i] + (char)input[i] - 1;
            Console.WriteLine(res);
        }
        public static void ex34()
        {
            string st1 = "helloWorld";
            //a
            Console.WriteLine(st1);
            //b
            Console.WriteLine(st1.Substring(0, 4));
            //c
            Console.WriteLine((st1.IndexOf('Y') != -1) ? "yes" : "no");
        }
        public static void ex35()
        {
            string tel = Console.ReadLine();
            string st1 = "abc" + tel;
            Console.WriteLine(st1[st1.Length - 1]);
            Console.WriteLine(st1[st1.Length - 2]);
        }
        public static void ex36()
        {
            string s1 = Console.ReadLine();
            string s2 = Console.ReadLine();
            string res = "";
            for (char c = 'a'; c <= 'z'; c++)
                if (s1.IndexOf(c) != -1 && s2.IndexOf(c) != -1) res += c.ToString();
            for (char c = 'A'; c <= 'Z'; c++)
                if (s1.IndexOf(c) != -1 && s2.IndexOf(c) != -1) res += c.ToString();
        }
        public static void ex37()
        {
            string s = Console.ReadLine() + " ";
            string st = "";
            for (int i = 0; i < s.Length - 1; i++)
                if (!(s[i] == ' ' && s[i + 1] == ' '))
                    st += s[i];
            string[] words = st.Split(' ');
            for (int i = 0; i < words.Length; i++)
                Console.WriteLine((words[i].Substring(words[i].Length - 2) == "ות" || words[i][words[i].Length - 1] == 'ה') ? "כנראה נקבה" : "כנראה זכר");
        }
        public static void ex38() => Console.WriteLine(Console.ReadLine().LastIndexOf(Console.ReadLine()));
        public static void ex39()
        {
            string input = Console.ReadLine();
            string[] words = input.Split('*');
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length % 2 != 0)
                    Console.WriteLine(words[i][words[i].Length / 2 + 1]);
            }
        }
        public static void ex40()
        {
            int shortestStreak = 0;
            int currentStreak = 1;
            string s = Console.ReadLine();
            for (int i = 1; i < s.Length; i++)
            {
                if (s[i] == s[i - 1])
                    currentStreak++;
                else
                {
                    if (currentStreak < shortestStreak || shortestStreak == 0)
                        shortestStreak = currentStreak;
                    currentStreak = 1;
                }
            }
        }
    }
    public static class Extensions
    {
        public static string delete(this string s, int index, int length) => s.Remove(index, length);
        public static string insert(this string s, int index, string toInsert) => s.Insert(index, toInsert);
    }
}