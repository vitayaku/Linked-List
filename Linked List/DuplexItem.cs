using System;
using System.Collections.Generic;
using System.Text;

namespace Linked_List
{
    class DuplexItem<T>
    {
        public T Data { get; set; }
        
        public DuplexItem<T> Previous { get; set; }

        public DuplexItem<T> Next { get; set; }
    }
}
