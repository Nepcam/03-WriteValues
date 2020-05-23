using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WriteValues
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonRun_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Will open/create file called \"base 2.txt\"");
            // create the output stream and open file called "base 2.txt" 
            // preserving contents if any
            StreamWriter outputFile; 
            outputFile = File.CreateText("base 2.txt");

            // add five lines of text
            for (int count = 1; count < 100000000; count = count * 2)
            {
                outputFile.WriteLine(count);
            }

            // close the stream/file, ensuring all data will be saved in the file
            outputFile.Close();
            MessageBox.Show("Values 1, 2, 4... added to \"base 2.txt\".");
        }
    }
}
