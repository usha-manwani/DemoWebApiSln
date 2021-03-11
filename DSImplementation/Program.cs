using System;

namespace DSImplementation
{
    class Program
    {
        static void Main(string[] args)
        {
            StackLinkedList p = new StackLinkedList();

            p.push(10);
            p.push(20);
            p.push(30);
            Console.WriteLine(p.pop() + " popped from stack");

            Console.WriteLine("Top element is " + p.peek());
            Console.WriteLine(InfixToPostfix.infixToPostfix("a*(b+c*e)*d"));
            Console.Read();
           
        }
    }
}
