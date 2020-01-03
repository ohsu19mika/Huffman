using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Huffman
{   
    //Sources:
    //https://www.csharpstar.com/csharp-huffman-coding-using-dictionary/
    //+ classes example codes
    class TreeNode : IComparable<TreeNode>
    {
        public char Symbol { get; set; }
        public int Frequency { get; set; }
        public TreeNode Left { get; set; }
        public TreeNode Right { get; set; }

        public override string ToString()
        {
            return Symbol.ToString() + ": " + Frequency.ToString();
        }

        public int CompareTo(TreeNode other)
        {
            return Frequency - other.Frequency;
        }

        //Finds symbol from tree and returns path in bits to it
        public List<bool> Traverse(char symbol, List<bool> data)
        {
            // Leaf
            if (IsLeaf())
            {
                if (symbol.Equals(this.Symbol))
                {
                    return data;
                }
                else
                {
                    return null;
                }
            }
            else
            {
                List<bool> left = null;
                List<bool> right = null;

                if (Left != null)
                {
                    List<bool> leftPath = new List<bool>();
                    leftPath.AddRange(data);
                    leftPath.Add(false);

                    left = Left.Traverse(symbol, leftPath);
                }

                //If symbol found from left no need to go right path
                if (left == null && Right != null)
                {
                    List<bool> rightPath = new List<bool>();
                    rightPath.AddRange(data);
                    rightPath.Add(true);
                    right = Right.Traverse(symbol, rightPath);
                }

                if (left != null)
                {
                    return left;
                }
                else
                {
                    return right;
                }
            }
        }

        //For checking if node is leaf
        public bool IsLeaf()
        {
            return (Left == null && Right == null);
        }
    }
}
