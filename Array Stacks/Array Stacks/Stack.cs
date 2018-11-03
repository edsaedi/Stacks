using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Stacks
{
    class Stack<T>
    {
        //Capacity Method

        T[] stack;
        public int Count { get; private set; }

        public Stack(int capacity = 10)
        {
            if (capacity < 10)
            {
                capacity = 10;
            }

            stack = new T[capacity];
            Count = 0;
        }

        //Add is going to add an item at the end of the array
        public void Push(T item)
        {
            // if count == capacity (stack.Length)
            if (Count == stack.Length)
            {
                Resize(Count * 2);
                //call resize
            }
            stack[Count] = item;
            Count++;
        }

        public T Pop()
        {
            //if count is 1/4 of array length, resize half array length. very optional

            Count--;
            return stack[Count];
        }

        public T Peek()
        {
            return stack[Count-1];
        }

        public bool IsEmpty()
        {
            return Count == 0;
        }

        private void Resize(int size)
        {
            //resize the array
            //create a new array with size "size"
            T[] temp = new T[size];
            //copy everything over
            for (int i = 0; i < stack.Length; i++)
            {
                temp[i] = stack[i];
            }
            // stack = temp
            stack = temp;
        }

    }
}
