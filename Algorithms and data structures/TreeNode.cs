using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_and_data_structures
{
    internal class TreeNode
    {
        public int Value {  get; set; }
        public bool Visited { get; set; }
        public List<TreeNode> Children { get; set;}
    }
}
