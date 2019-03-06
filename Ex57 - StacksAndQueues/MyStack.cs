using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex57___StacksAndQueues
{
    public class MyStack<T>
    {
        private List<T> stack;
        public MyStack()
        {
            stack = new List<T>();
        }

        public void Push(T item)
        {
            stack.Add(item);
        }

        public T Pop()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException();
            }
            else
            {
                T data = stack.Last();
                stack.Remove(stack.Last());
                return data;
            }
        }

        public T Peek()
        {
            return stack.Last();
        }

        public int Count()
        {
            return stack.Count();
        }

        public Boolean IsEmpty()
        {
            if (!stack.Any())
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
