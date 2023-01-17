namespace New.Net7
{
    using static System.Console;
    using static System.String;

    internal class Program
    {
        static void Main(string[] args)
        {
            WriteLine(" ///////////////////List Patterns////////////////////////////////");
            string list;

            list = "1,Adriano,Test";
            Console.WriteLine("");

            string[] info = list.Split(',');
            Console.WriteLine(list);
            Console.WriteLine();

            if (info is [var id, var name, var _])
            {
                Console.WriteLine($"Id: {id}");
                Console.WriteLine($"Name: {name}");
            }
            else
            {
                Console.WriteLine("Bad Input");
            }
            Console.WriteLine("");
            Console.WriteLine("");

            list = "2,Adriano,Test,World,C#,.Net7";

            string[] info2 = list.Split(',');
            Console.WriteLine(list);

            if (info2 is ["1" or "2", var id2, var name2, .., var ending])
            {
                Console.WriteLine($"Id: {id2}");
                Console.WriteLine($"Name: {name2}");
                Console.WriteLine($"ending: {ending}");
                Console.WriteLine("");

            }
            else
            {
                Console.WriteLine("bad input");
                Console.WriteLine("");

            }

            var list3 = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            void Print(int[] list3, Range range)
                 => WriteLine(Join(", ", list3[range]));

            Print(list3, ..);
            Print(list3, ..3);
            Print(list3, 3..);
            Print(list3, 3..5);

            Print(list3, ^7..);
            Print(list3, ..^4);

            Print(list3, 3..^4);
            Print(list3, ^4..^1);
            Console.WriteLine("");

            WriteLine(" ///////////////////String interpolation////////////////////////////////");

            int age = 27;
            Console.WriteLine("");

            WriteLine($"The user is {age} years old, wich is {age switch
            {
                > 80 => "old",
                > 60 => "getting old",
                > 20 => "a good age",
                _ => "young"
            }}");
            Console.WriteLine("");

        }
    }
}