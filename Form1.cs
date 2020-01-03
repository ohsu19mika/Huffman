using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Huffman
{
    public partial class Form1 : Form
    {
        private Tree _tree;
        private string _codeTableFile = "CodeTable.txt";
        private string _codedFile = "Encoded.bin";
        private BinaryFileHandling.ErrorHandling errorHandling = new BinaryFileHandling.ErrorHandling(ErrorBox);

        public Form1()
        {
            InitializeComponent();
        }

        static private void ErrorBox(string error)
        {
            MessageBox.Show(error);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _tree = new Tree();
            tbCodeTable.Text = ofdCodeTable.FileName = _codeTableFile;
            tbCodedFile.Text = ofdCodedFile.FileName = _codedFile;
        }

        private void TbCodeTable_Click(object sender, EventArgs e)
        {
            ofdCodeTable.ShowDialog();
        }

        private void OfdCodeTable_FileOk(object sender, CancelEventArgs e)
        {
            _codeTableFile = tbCodeTable.Text = ofdCodeTable.FileName;
        }

        private void OfdCodedFile_FileOk(object sender, CancelEventArgs e)
        {
            _codedFile = tbCodedFile.Text = ofdCodedFile.FileName;
        }

        private void TbCodedFile_Click(object sender, EventArgs e)
        {
            ofdCodedFile.ShowDialog();
        }

        private void BtnEncode_Click(object sender, EventArgs e)
        {
            //Check that text doesn't include ';' which is used as separator in code table
            if (tbTextToCode.Text.Contains(";"))
            {
                MessageBox.Show("Error in encoding: Text to encode can't include ';'");
                return;
            }


            //Encoding
            _tree.BuildFromText(tbTextToCode.Text);
            BitArray encoded = _tree.Encode(tbTextToCode.Text);
            
            //Saving encoded text in "true" bits
            //byte[] bytes = new byte[encoded.Count/8+1];

            //for (int i = 0; i < encoded.Count; i++)
            //{
            //    if (encoded[i])
            //        bytes[i/8] = (bytes[i/8] |= (byte)(1 << (i%8)));
            //}
            //File.WriteAllBytes("testi.bin", bytes);

            //Saving BitArray object to file
            BinaryFileHandling binaryFileHandling = new BinaryFileHandling(errorHandling);

            binaryFileHandling.Save(_codedFile, encoded);

            //Creating code table
            List<string> codeTable = new List<string>();
            Dictionary<char, string> dict = new Dictionary<char, string>();
            dict = _tree.CreateCodeTable();

            foreach (var pair in dict)
            {
                codeTable.Add(pair.Key + ";" + pair.Value);
            }

            //Saving code table to file
            File.WriteAllLines(_codeTableFile, codeTable, Encoding.Default);
        }

        private void BtnDecode_Click(object sender, EventArgs e)
        {
            BinaryFileHandling binaryFileHandling = new BinaryFileHandling(errorHandling);
            
            
            //Check code table file
            if (!File.Exists(_codeTableFile))
            {
                MessageBox.Show("Error in decoding: Code table file \"" + _codeTableFile + "\" doesn't exist");
                return;
            }
            //Reading code table file, spliting it to rows
            string fileContent = File.ReadAllText(_codeTableFile, Encoding.Default);
            string[] separator = { "\r\n" };
            string[] rows = fileContent.Split(separator, StringSplitOptions.RemoveEmptyEntries);

            //Dictionary for tree building
            Dictionary<char, string> dict = new Dictionary<char, string>();

            foreach (var item in rows)
            {
                string[] pieces = item.Split(';');
                dict.Add(pieces[0].ToCharArray()[0], pieces[1]);
            }

            //Tree building from dict
            _tree.BuildFromCodeTable(dict);

            //Reading BitArray object from file
            BitArray encoded = null;
            var obj = binaryFileHandling.Load(_codedFile);
            if (obj != null)
                if (obj is BitArray)
                    encoded = obj as BitArray;

            //Reading from "true" bits
            //byte[] testbytes = File.ReadAllBytes("testi.bin");
            //BitArray encoded1 = new BitArray(testbytes);
            
            //Decoding
            if (encoded != null)
                tbEncodedOutput.Text = _tree.Decode(encoded);
            else
                MessageBox.Show("Error in loading " + _codedFile + " file");
        }
    }
}
