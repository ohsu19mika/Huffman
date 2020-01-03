using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Huffman
{
    //Sources:
    //https://www.csharpstar.com/csharp-huffman-coding-using-dictionary/
    //+ classes example codes
    class Tree
    {
        private List<TreeNode> _nodes = new List<TreeNode>();
        private TreeNode Root { get; set; }
        private Dictionary<char, int> Frequencies { get; set; } = new Dictionary<char, int>();

        //Building tree from text
        public void BuildFromText(string source)
        {
            for (int i = 0; i < source.Length; i++)
            {
                if (!Frequencies.ContainsKey(source[i]))
                {
                    Frequencies.Add(source[i], 0);
                }

                Frequencies[source[i]]++;
            }

            foreach (KeyValuePair<char, int> symbol in Frequencies)
            {
                _nodes.Add(new TreeNode() { Symbol = symbol.Key, Frequency = symbol.Value });
            }

            while (_nodes.Count > 1)
            {

                _nodes.Sort();

                if (_nodes.Count >= 2)
                {

                    // Take first two items and
                    // create a parent node by combining the frequencies
                    TreeNode parent = new TreeNode()
                    {
                        Symbol = '*',
                        Frequency = _nodes[0].Frequency + _nodes[1].Frequency,
                        Left = _nodes[0],
                        Right = _nodes[1]
                    };

                    _nodes.Remove(parent.Left);
                    _nodes.Remove(parent.Right);
                    _nodes.Add(parent);
                }

                Root = _nodes.FirstOrDefault();

            }

        }

        //Building tree from dictionary containing char as key and bits as string(value) 
        public void BuildFromCodeTable(Dictionary<char, string> dict)
        {
            Root = new TreeNode();
            TreeNode parent;

            foreach (var pair in dict)
            {
                parent = Root;
                for (int i = 0; i < pair.Value.Length; i++)
                {
                    //Bit true -> go right
                    if (pair.Value[i] == '1')
                    {
                        //Check if next node is already created
                        if (parent.Right != null)
                        {
                            parent = parent.Right;
                        }
                        //Create new node to tree
                        else
                        {
                            parent.Right = new TreeNode() { Symbol = '*' };
                            parent = parent.Right;
                        }
                    }
                    //Bit false -> go left
                    else
                    {
                        //Check if next node is already created
                        if (parent.Left != null)
                        {
                            parent = parent.Left;
                        }
                        //Create new node to tree
                        else
                        {
                            parent.Left = new TreeNode() { Symbol = '*' };
                            parent = parent.Left;
                        }
                    }
                }
                //When bits are go through, add symbol to correct place
                parent.Symbol = pair.Key;
            }
        }

        //Encodes string to BitArray object
        public BitArray Encode(string source)
        {
            List<bool> encodedSource = new List<bool>();

            for (int i = 0; i < source.Length; i++)
            {
                List<bool> encodedSymbol = Root.Traverse(source[i], new List<bool>());
                encodedSource.AddRange(encodedSymbol);
            }

            BitArray bits = new BitArray(encodedSource.ToArray());

            return bits;
        }

        //Decodes BitArray object to string
        public string Decode(BitArray bits)
        {
            TreeNode current = this.Root;
            StringBuilder decoded = new StringBuilder();

            foreach (bool bit in bits)
            {
                if (bit)
                {
                    if (current.Right != null)
                    {
                        current = current.Right;
                    }
                    else
                        return "Error in decoding!!";
                }
                else
                {
                    if (current.Left != null)
                    {
                        current = current.Left;
                    }
                    else
                        return "Error in decoding!!";
                }

                if (current.IsLeaf())
                {
                    decoded.Append(current.Symbol);
                    current = this.Root;
                }
            }

            return decoded.ToString();
        }

        //Creates code table as dictionary: key = symbol, value = bits as string
        public Dictionary<char, string> CreateCodeTable()
        {
            Dictionary<char, string> dict = new Dictionary<char, string>();

            foreach (var pair in Frequencies)
            {
                StringBuilder code = new StringBuilder();

                foreach (bool item in Encode(pair.Key.ToString()))
                {
                    code.Append(item ? 1 : 0);
                }
                dict.Add(pair.Key, code.ToString());
                
            }

            return dict;
        }
    }
}
