using System;
using System.Collections.Generic;
using System.Linq;
/* * Find missing parenthesis in a given expression – 2 * ( 3 + 5(sasdfasdfasd)*/
namespace Stack1
{
    class Program
    {
        //static void FindMissParenth(string input)
        //{
        //    var stack = new Stack<char>();

        //    var dict = new Dictionary<char, char>() { { '(', ')' }, { '[', ']' }, { '{', '}' } };

        //    var foundmissing = true;
        //    foreach (var chr in input)
        //    {
        //        if (dict.ContainsKey(chr))
        //            stack.Push(chr);
        //        else if (dict.ContainsValue(chr))
        //        {
        //            make sure something to pop if not then know it found missing
        //           foundmissing = stack.Any();
        //            if (foundmissing)
        //            {
        //                var startingchar = stack.Pop();
        //                foundmissing = dict.Contains(new KeyValuePair<char, char>(startingchar, chr)); // check it is in the dictionary
        //            }
        //            if found missing exit loop no need to continue
        //            if (!foundmissing)
        //            {
        //                Console.WriteLine("not found a pair for parenthsis " + chr);
        //                break;
        //            }
        //        }
        //    }
        //    if (stack.Count > 0)
        //        Console.WriteLine("Missing close parenthesis");
        //}
        static void FoundMissing(string str)
        {
            var stack = new Stack<char>();
            //int i = 0;
            foreach (char par in str)
            {
                if (par == '(')
                   stack.Push(par);
                else if (par == ')')
                {
                    if (stack.Count > 0)
                        stack.Pop();
                    else
                    {
                        Console.WriteLine("Missing open parenthesis '('");
                        //i = 1;
                    }
                }
            }
            if (stack.Count > 0)
                Console.WriteLine("Missing close " + stack.Count + " parenthesis  ')'");
            //else
            //{
            //    if (i == 0)
            //        Console.WriteLine("It is ok");
            //}
        }

        static void Main(string[] args)
        {
            //string str = "2*(3+5(sa)";
            string str = "(2*4)))";
            FoundMissing(str);
        }
    }
}
