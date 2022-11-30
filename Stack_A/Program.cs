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
        static void Main(string[] args)
        {
            Stacks s = new Stacks();
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("\n**************Stack Menu*************\n");
                Console.WriteLine("1.Push");
                Console.WriteLine("2.Pop");
                Console.WriteLine("3.Display");
                Console.WriteLine("4.Exit");
                Console.WriteLine("\nenter your choice");
                string sInput = Console.ReadLine();
                char ch = Convert.ToChar(sInput == "" ? "0" : sInput);
                switch (ch)
                {
                    case '1':
                        Console.Write("\nEnter a Number : ");
                        int num = Convert.ToInt32(Console.ReadLine());
                        s.Push(num);
                        break;
                    case '2':
                        if (s.Empty())
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
                        Console.WriteLine("\nInvalid Choice");
                        break;
                }
            }
        }
    }
  
}
