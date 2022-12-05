using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise4
{
    class node
    {
        public int info;
        public node next;
        public node(int i, node p)
        {
            info = info;
            next = next;
        }
    }
    class Stack
    {
        node top;
        
        public Stack()
        {
            
            top = null;
        }
        bool empty()
        {
            if (top == null)
                return true;
            else
                return false;
        }
        public void push(int element)
        {
            node rera;
            rera = new node(element, null);

            rera.next = top;
            top = rera;
            Console.WriteLine("\n" + element + "pushed");
        }
        public void pop()
        {
            Console.WriteLine("\n the poped elements is: " + top.info);
            top = top.next;
        }
        public void display()
        {
            node tmp;
            if (empty())
                Console.WriteLine("\n Stack Empty");
            else
            {
                for (tmp = top; tmp != null; tmp = tmp.next)
                {
                    Console.WriteLine(tmp.info);
                }
            }
        }

        static void Main(string[] args)
        {
            Stack s = new Stack();
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("\nStack Menu");
                Console.WriteLine("1. push");
                Console.WriteLine("2. pop");
                Console.WriteLine("3. display");
                Console.WriteLine("4. exit");
                Console.Write("\nEnter your Choice");
                string input = Console.ReadLine();
                char ch = Convert.ToChar(input == "" ? "0" : input);
                switch (ch)
                {
                    case '1':
                        Console.Write("\nEnter a number :");
                        int num = Convert.ToInt32(Console.ReadLine());
                        s.push(num);
                        break;
                    case '2':
                        if (s.empty())
                        {
                            Console.WriteLine("\nStack Empty");
                            break;
                        }
                        s.pop();
                        break;
                    case '3':
                        s.display();
                        break;
                    case '4':
                        return;
                    default:
                        Console.WriteLine("\n Invalid choice");
                        break;
                }
            }

        }
    }
}
