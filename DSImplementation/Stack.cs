using System;
using System.Collections.Generic;
using System.Text;

namespace DSImplementation
{
    class Stack
    {
    }
    class StackArray
    {
        private int[] ele;
        private int top;
        private int max;
        public StackArray(int size)
        {
            ele = new int[size];
            top = -1;
            max = size;
        }
        public void push(int num)
        { if(top==max-1)
            { Console.WriteLine("stack Overflow");
                return;
            }
            else {
                top = top + 1;
                ele[top] = num;
            }
            
        }
        public int pop()
        {
            if (top == -1)
            {
                Console.WriteLine("stack underflow");
                return -1;
            }
            else
            {
                Console.WriteLine("Element popped from stack: {0}", ele[top]);
                return ele[top--];
            }
        }
        public int peek()
        {
            if (top == -1)
            {
                Console.WriteLine("Stack is Empty");
                return -1;
            }
            else
            {
                Console.WriteLine("{0} popped from stack ", ele[top]);
                return ele[top];
            }
        }
        public void printStack()
        {
            if (top == -1)
            {
                Console.WriteLine("Stack is Empty");
                return;
            }
            else
            {
                for (int i = 0; i <= top; i++)
                {
                    Console.WriteLine("{0} pushed into stack", ele[i]);
                }
            }
        }
    }
    
    class StackLinkedList
    {
        StackNode root;

        public class StackNode
        {
            public int data { get; set; }
            public StackNode next;            
        }
        public bool isEmpty()
        {
            if (root == null)
                return true;
            else return false;
        }
        public void push(int num)
        {
            var newnode= new StackNode { data = num };
            if (root==null)
            { root = newnode; }
            else
            {
                StackNode temp = root;
                root = newnode;
                newnode.next = temp;
            }
        }
        public int pop()
        {
            int popped = int.MinValue;
            if (root == null)
            {
                Console.WriteLine("Stack is Empty");
            }
            else
            {
                popped = root.data;
                root = root.next;
            }
            return popped;
        }

        public int peek()
        {
            if (root == null)
            {
                Console.WriteLine("Stack is empty");
                return int.MinValue;
            }
            else
            {
                return root.data;
            }
        }
    }
}
