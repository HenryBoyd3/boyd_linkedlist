using System;
using System.Collections.Generic;
using System.Text;

namespace boyd_linkedlist
{
    class Node
    {
        public string data;
        public Node next;
        public Node(string Input)
        {
            data = Input;
            next = null;
        }
    }
}
