using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndQueue
{
    public class Node
    {

        //define variables
        public int data;
        public Node Next;

        //parameterized constructor
        public Node(int data)
        {
            this.data = data;
            Next = null;
        }
    }
}
