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

    public partial class F_SMauto : Form
    {

        #region FL = File Locations
        readonly string FL_origional    = @"Dependencies\\origional.html";
        readonly string FL_cssstyle     = @"Dependencies\\cssstyles.css";
        readonly string FL_jquery       = @"Dependencies\\jquery-1.4.2.min.js";
        readonly string FL_OBS_Twitter  = @"Dependencies\\OBS_Twitter.html";
        #endregion

        public F_SMauto()
        {
            InitializeComponent();
            GB_ActiveArea.Enabled = false;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void B_File_Click(object sender, EventArgs e)
        {
            bool file1, file2, file3;
            file1 = System.IO.File.Exists(FL_origional);
            file2 = System.IO.File.Exists(FL_cssstyle);
            file3 = System.IO.File.Exists(FL_jquery);

            if (file1 & file2 & file3) 
            {
                B_FileCheck.BackColor = Color.Green;
                GB_ActiveArea.Enabled = true;
            }
            else
            {
                B_FileCheck.BackColor = Color.Red;
                GB_ActiveArea.Enabled = false;
            }

        }

        private void B_Clear_Click(object sender, EventArgs e)
        {
            File.Delete(FL_OBS_Twitter);
            File.Copy(FL_origional, FL_OBS_Twitter);
        }



        private void B_Update_Click(object sender, EventArgs e)
        {
            if (RB_single.Checked)
            {
                if (RB_tweet1.Checked)
                {
                    File.Delete(FL_OBS_Twitter);
                    File.WriteAllText(FL_OBS_Twitter, TB_tweet1.Text);
                }
                if (RB_tweet2.Checked)
                {
                    File.Delete(FL_OBS_Twitter);
                    File.WriteAllText(FL_OBS_Twitter, TB_tweet2.Text);
                }
                if (RB_tweet3.Checked)
                {
                    File.Delete(FL_OBS_Twitter);
                    File.WriteAllText(FL_OBS_Twitter, TB_tweet3.Text);
                }
                if (RB_tweet4.Checked)
                {
                    File.Delete(FL_OBS_Twitter);
                    File.WriteAllText(FL_OBS_Twitter, TB_tweet4.Text);
                }
                if (RB_tweet5.Checked)
                {
                    File.Delete(FL_OBS_Twitter);
                    File.WriteAllText(FL_OBS_Twitter, TB_tweet5.Text);
                }
            }
            if (RB_slideshow.Checked)
            {
                File.Delete(FL_OBS_Twitter);
                File.Copy(FL_origional, FL_OBS_Twitter);

                //reverse order so that first tweet shows first
                if (CB_tweet5.Checked)
                {
                    var alllines = File.ReadAllLines(FL_OBS_Twitter).ToList();
                    alllines.Insert(14, "");
                    alllines.Insert(15, "<li>");
                    alllines.Insert(16, TB_tweet5.Text);
                    alllines.Insert(17, "</li>");
                    File.WriteAllLines(FL_OBS_Twitter, alllines.ToArray());
                }
                if (CB_tweet4.Checked)
                {
                    var alllines = File.ReadAllLines(FL_OBS_Twitter).ToList();
                    alllines.Insert(14, "");
                    alllines.Insert(15, "<li>");
                    alllines.Insert(16, TB_tweet4.Text);
                    alllines.Insert(17, "</li>");
                    File.WriteAllLines(FL_OBS_Twitter, alllines.ToArray());
                }
                if (CB_tweet3.Checked)
                {
                    var alllines = File.ReadAllLines(FL_OBS_Twitter).ToList();
                    alllines.Insert(14, "");
                    alllines.Insert(15, "<li>");
                    alllines.Insert(16, TB_tweet3.Text);
                    alllines.Insert(17, "</li>");
                    File.WriteAllLines(FL_OBS_Twitter, alllines.ToArray());
                }
                if (CB_tweet2.Checked)
                {
                    var alllines = File.ReadAllLines(FL_OBS_Twitter).ToList();
                    alllines.Insert(14, "");
                    alllines.Insert(15, "<li>");
                    alllines.Insert(16, TB_tweet2.Text);
                    alllines.Insert(17, "</li>");
                    File.WriteAllLines(FL_OBS_Twitter, alllines.ToArray());
                }
                if (CB_tweet1.Checked)
                {
                    var alllines = File.ReadAllLines(FL_OBS_Twitter).ToList();
                    alllines.Insert(14, "");
                    alllines.Insert(15, "<li>");
                    alllines.Insert(16, TB_tweet1.Text);
                    alllines.Insert(17, "</li>");
                    File.WriteAllLines(FL_OBS_Twitter, alllines.ToArray());
                }
            }

        }

        #region Clear textbox buttons
        private void L_Tweet1_Click(object sender, EventArgs e)
        {
            TB_tweet1.Clear();
        }

        private void L_tweet2_Click(object sender, EventArgs e)
        {
            TB_tweet2.Clear();
        }

        private void L_tweet3_Click(object sender, EventArgs e)
        {
            TB_tweet3.Clear();
        }

        private void L_tweet4_Click(object sender, EventArgs e)
        {
            TB_tweet4.Clear();
        }

        private void L_tweet5_Click(object sender, EventArgs e)
        {
            TB_tweet5.Clear();
        }
        #endregion
    }
}
