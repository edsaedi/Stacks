using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introduction_to_Stacks
{
    public class Stack<T>
    {
        LinkedList<T> stackList;
        public int Count => stackList.Count;

        public Stack()
        {
            stackList = new LinkedList<T>();
        }

        void Push(T value)
        {
            stackList.AddFirst(value);
        }

        T Pop()
        {
            if (stackList.First == null)
            {
                throw new Exception("The stack is empty");
            }

            else
            {
                var temp = stackList.First.Value;
                stackList.RemoveFirst();
                return temp;
            }
        }

        T Peek()
        {
            if (stackList.First == null)
            {
                throw new Exception("The stack is empty");
            }

            else
            {
                return stackList.First.Value;
            }
        }

        bool IsEmpty()
        {
            if (stackList.First != null)
            {
                return true;
            }
            return false;
        }

    }
}
