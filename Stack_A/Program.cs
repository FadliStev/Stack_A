using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_A
{
    class Node
    {
        public int info;
        public Node next;
        public Node (int i, Node n)
        {
            info = i;   
            next = n;
        }
    }
    class Stacks
    {
        Node top;
        
        public Stacks()
        {
            top = null;
        }

        bool Empty()
        {
            if (top == null)
                return (true);
            else
                return (false);
        }
        public void Push(int element)
        {
            Node fresh;
            fresh = new Node(element, null);

            fresh.next = top;
            top = fresh;
            Console.WriteLine("\n "+ element +"pushed.");
        }
        public void pop()
        {
            Console.WriteLine("\n The poped elment is:" + top.info);
            top = top.next;//Make top point to the next node in sequence
        }
        public void display()
        {
            Node tmp;
            if (Empty()) //If stack is empty
                Console.WriteLine("\nStacks is Empty");
            else
            {
                //Traverse the list from beginning till end
                for (tmp = top; tmp != null; tmp = tmp.next)
                {
                    Console.WriteLine("tmp.info");
                }
                Console.WriteLine();
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
