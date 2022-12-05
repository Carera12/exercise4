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
        public  node(int i, node p)
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
    }
    class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
