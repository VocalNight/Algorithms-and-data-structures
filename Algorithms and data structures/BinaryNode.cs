using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_and_data_structures
{
    internal class BinaryNode
    {
        public int Value { get; set; }
        public BinaryNode Left { get; set; }
        public BinaryNode Right { get; set; }
        public bool Visited { get; set; }
    }
}
