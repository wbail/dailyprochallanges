using System;
using System.Linq;

namespace _20200329_MaxInAStack
{
    class Program
    {
        private static int top = -1;
        private static int[] stack = new int[4];
        static void Main(string[] args)
        {
            Program.Push(1);
            Program.Push(2);
            Program.Push(3);
            Program.Push(2);
            Program.Max();
            Program.Pop();
            Program.Pop();
            Program.Max();
        }

        static void Push(int value)
        {
            if(top == stack.Count() - 1)
            {
                Console.WriteLine("Full");
                return;
            }

            top++;
            stack[top] = value;
        }

        static void Pop()
        {
            IsEmpty();

            top--;
        }

        static void Max()
        {
            IsEmpty();
            
            int aux = 0;
            
            for(int i = 0; i < (top+1); i++)
            {
                if(aux < stack[i])
                {
                    aux = stack[i];
                }
            }

            Console.WriteLine(aux);
        }

        static void IsEmpty()
        {
            if(top == -1)
            {
                Console.WriteLine("None");
                return;
            }
        }
    }
}
