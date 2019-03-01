using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JewelListGenerator
{
    public partial class MainForm : Form
    {
        List<JewelLineItem> _foundLines = new List<JewelLineItem>();

        public MainForm()
        {
            InitializeComponent();
            
        }

        private string GetFileNameFromPath(string pPath)
        {
            string[] parts = pPath.Split('/');
            return parts[parts.Length - 1];
        }

        private void btnRunJewel_Click(object sender, EventArgs e)
        {
            _foundLines = new List<JewelLineItem>();

            // get directory path.
            string dirPath = txtBoxDirectoryInput.Text;

            // get string to search.
            string searchString = txtBoxSearchString.Text;

            // do we auto list [JEWEL]
            bool shouldListJewels = checkBoxListJewels.Checked;

            // recurse through the root directory.
            // for each file that is not a directory.
            //  for each line in the file:
            //      - keep track of the line number.
            //      - test whether the line contains the string we are looking for.
            //      - if yes the append the line infomation to a list.

            string[] filePathList = Directory.GetFiles(dirPath, "*.*", SearchOption.AllDirectories);

            foreach (string filePath in filePathList)
            {
                StreamReader fs = new StreamReader(filePath);

                int lineNumber = 0;
                while (!fs.EndOfStream)
                {
                    lineNumber++;

                    string line = fs.ReadLine();

                    bool containsSearchString = line.Contains(searchString);
                    bool containsJewelString = line.Contains("[JEWEL]");

                    if (containsSearchString || containsJewelString)
                    {
                        JewelLineItem item = new JewelLineItem();
                        item.SourceFile = GetFileNameFromPath(filePath);
                        item.LineNumber = lineNumber;

                        _foundLines.Add(item);
                    }
                }

                fs.Close();
            }

            dataGridView.Rows.Clear();

            foreach (JewelLineItem lineItem in _foundLines)
            {
                dataGridView.Rows.Add(lineItem.SourceFile, lineItem.LineNumber);
            }
        }
        
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "CSV file (*.csv)|*.csv| All Files (*.*)|*.*";
            saveFileDialog1.Title = "Save an Comma Seperated Values file.";
            saveFileDialog1.ShowDialog();

            // If the file name is not an empty string open it for saving.  
            if (saveFileDialog1.FileName != "")
            {
                // Saves the Image via a FileStream created by the OpenFile method.  
                System.IO.FileStream fs =
                   (System.IO.FileStream)saveFileDialog1.OpenFile();

                StreamWriter sw = new StreamWriter(fs);
                sw.WriteLine("Filename,LineNumber");
                foreach (JewelLineItem item in _foundLines)
                {
                    sw.WriteLine(item.SourceFile + "," + item.LineNumber);
                }
                sw.Close();

                fs.Close();
            }
        }
    }

    public class JewelLineItem
    {
        public string SourceFile = "N/A";
        public int LineNumber = -1;
    }
}
