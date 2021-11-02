using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab18
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<string> skobki = new Stack<string>();
            Console.WriteLine("Введите выражение со скобками");
            string str = Console.ReadLine();
            for (int i = 0;i<str.Length;i++)
            {
                if (str[i] =='{')
                {
                    skobki.Push("}");
                }
                else
                { 
                    if (str[i]=='[')
                    {
                        skobki.Push("]");
                    }
                    else
                    {
                        if (str[i]=='(')
                        {
                            skobki.Push(")");
                        }
                        else
                        {
                            if (str[i] == '}')
                            {
                                if (skobki.Count == 0)
                                {
                                    Console.WriteLine("Скобки расставлены не правильно");
                                }
                                else
                                {
                                    if (skobki.Peek() == "}")
                                    {
                                        skobki.Pop();
                                    }
                                    else
                                    {
                                        Console.WriteLine("Скобки расставлены не правильно");
                                    }
                                }
                            }
                            else
                            {
                                if (str[i] == ']')
                                {
                                    if (skobki.Count == 0)
                                    {
                                        Console.WriteLine("Скобки расставлены не правильно");
                                    }
                                    else
                                    { 
                                        if (skobki.Peek() == "]")
                                        {
                                            skobki.Pop();
                                        }
                                        else
                                        {
                                            Console.WriteLine("Скобки расставлены не правильно");
                                        }
                                    }
                                }
                                else
                                {
                                    if (str[i] == ')')
                                    {
                                        if (skobki.Count == 0)
                                        {
                                            Console.WriteLine("Скобки расставлены не правильно");
                                        }
                                        else
                                        {
                                            if (skobki.Peek() == ")")
                                            {
                                                skobki.Pop();
                                            }
                                            else
                                            {
                                                Console.WriteLine("Скобки расставлены не правильно");
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            if (skobki.Count!=0)
            {
                Console.WriteLine("Скобки расставлены не правильно");
            }
            else
            {
                if (skobki.Count == 0)
                {
                    Console.WriteLine("Скобки расставлены правильно");
                }

            }
            Console.ReadKey();
        }
    }
}
