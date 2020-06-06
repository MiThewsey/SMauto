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

namespace SMauto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void B_File_Click(object sender, EventArgs e)
        {
            bool file1, file2, file3;
            file1 = System.IO.File.Exists("Dependencies\\origional.html");
            file2 = System.IO.File.Exists("Dependencies\\cssstyles.css");
            file3 = System.IO.File.Exists("Dependencies\\jquery-1.4.2.min.js");

            if (file1 & file2 & file3) 
            {
                B_FileCheck.BackColor = Color.Green;
            }
            else
            {
                B_FileCheck.BackColor = Color.Red;
            }

        }

        private void B_Clear_Click(object sender, EventArgs e)
        {
            File.Delete(@"Dependencies\\OBStwitter.html");
            File.Copy(@"Dependencies\\origional.html", @"Dependencies\\OBStwitter.html");
        }

        private void L_Tweet1_Click(object sender, EventArgs e)
        {
            TB_Tweet1.Clear();
        }

        private void B_Update_Click(object sender, EventArgs e)
        {
            var alllines = File.ReadAllLines(@"Dependencies\\OBStwitter.html").ToList();
            alllines.Insert(14, "");
            alllines.Insert(15, "<li>");
            alllines.Insert(16, TB_Tweet1.Text);
            alllines.Insert(17, "</li>");
            File.WriteAllLines(@"Dependencies\\OBStwitter.html", alllines.ToArray());
        }
    }
}
