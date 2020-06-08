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
        readonly string FL_origional    = @"Dependencies\\SlideshowOrigional.html";
        readonly string FL_cssstyle     = @"Dependencies\\cssstyles.css";
        readonly string FL_jquery       = @"Dependencies\\jquery-1.4.2.min.js";
        readonly string FL_OBS_Twitter  = @"OBS_Twitter.html";
        readonly string FL_twitterFB_savedata  = @"Dependencies\\twitterFB_savedata.txt";
        #endregion
        #region Loading things
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
            bool file1, file2, file3, file4;
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
        #endregion

        //html to display emails. (The backslash \ will escape the "" in your HTML code.)
        List<string> EmailHTML = new List<string>() {
            "<link rel=\"stylesheet\" type=\"text/css\" href=\"Dependencies/cssstyles.css\" />",
            "<p id=\"emailbox\"><table><tr><th style=\"font-size: 30px;\">",
            "Test name",
            "</th><th  style=\"text-align: right;\"><img src=\"Dependencies/email.png\" height=\"50\" width=\"50\"></th></tr><tr><th colspan=\"2\">",
            "Test body text",
            "</th></tr><tr><th colspan=\"2\">",
            "<img src=\"Dependencies/pic.jfif\" width=\"458px\">",
            "</th></tr></table></p>"};


        #region Clear and update buttons
        private void B_Clear_Click(object sender, EventArgs e)
        {
            File.Delete(FL_OBS_Twitter);
            File.Copy(FL_origional, FL_OBS_Twitter);
        }
        private void B_Update_Click(object sender, EventArgs e)
        {
            if (RB_single.Checked)
            {
                #region tweets and FBs single
                //Single tweets
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

                //Single Facebooks
                if (RB_FB1.Checked)
                {
                    File.Delete(FL_OBS_Twitter);
                    File.WriteAllText(FL_OBS_Twitter, TB_FB1.Text);
                }
                if (RB_FB2.Checked)
                {
                    File.Delete(FL_OBS_Twitter);
                    File.WriteAllText(FL_OBS_Twitter, TB_FB2.Text);
                }
                if (RB_FB3.Checked)
                {
                    File.Delete(FL_OBS_Twitter);
                    File.WriteAllText(FL_OBS_Twitter, TB_FB3.Text);
                }
                if (RB_FB4.Checked)
                {
                    File.Delete(FL_OBS_Twitter);
                    File.WriteAllText(FL_OBS_Twitter, TB_FB4.Text);
                }
                if (RB_FB5.Checked)
                {
                    File.Delete(FL_OBS_Twitter);
                    File.WriteAllText(FL_OBS_Twitter, TB_FB5.Text);
                }
                #endregion
                if (RB_Email1.Checked)
                {
                    File.Delete(FL_OBS_Twitter);
                    EmailHTML[2] = TB_EmailName.Text;
                    EmailHTML[4] = TB_EmailBody.Text;
                    File.WriteAllLines(FL_OBS_Twitter, EmailHTML.ToArray());
                }

            }
            if (RB_slideshow.Checked)
            {
                File.Delete(FL_OBS_Twitter);
                File.Copy(FL_origional, FL_OBS_Twitter);

                #region Multi, tweets and FBs
                //reverse order so that first tweet shows first
                //Tweets
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

                //FBs
                if (CB_FB1.Checked)
                {
                    var alllines = File.ReadAllLines(FL_OBS_Twitter).ToList();
                    alllines.Insert(14, "");
                    alllines.Insert(15, "<li>");
                    alllines.Insert(16, TB_FB1.Text);
                    alllines.Insert(17, "</li>");
                    File.WriteAllLines(FL_OBS_Twitter, alllines.ToArray());
                }
                if (CB_FB2.Checked)
                {
                    var alllines = File.ReadAllLines(FL_OBS_Twitter).ToList();
                    alllines.Insert(14, "");
                    alllines.Insert(15, "<li>");
                    alllines.Insert(16, TB_FB2.Text);
                    alllines.Insert(17, "</li>");
                    File.WriteAllLines(FL_OBS_Twitter, alllines.ToArray());
                }
                if (CB_FB3.Checked)
                {
                    var alllines = File.ReadAllLines(FL_OBS_Twitter).ToList();
                    alllines.Insert(14, "");
                    alllines.Insert(15, "<li>");
                    alllines.Insert(16, TB_FB3.Text);
                    alllines.Insert(17, "</li>");
                    File.WriteAllLines(FL_OBS_Twitter, alllines.ToArray());
                }
                if (CB_FB4.Checked)
                {
                    var alllines = File.ReadAllLines(FL_OBS_Twitter).ToList();
                    alllines.Insert(14, "");
                    alllines.Insert(15, "<li>");
                    alllines.Insert(16, TB_FB4.Text);
                    alllines.Insert(17, "</li>");
                    File.WriteAllLines(FL_OBS_Twitter, alllines.ToArray());
                }
                if (CB_FB5.Checked)
                {
                    var alllines = File.ReadAllLines(FL_OBS_Twitter).ToList();
                    alllines.Insert(14, "");
                    alllines.Insert(15, "<li>");
                    alllines.Insert(16, TB_FB5.Text);
                    alllines.Insert(17, "</li>");
                    File.WriteAllLines(FL_OBS_Twitter, alllines.ToArray());
                }
                #endregion

            }

        }
        #endregion
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
        private void L_FB1_Click(object sender, EventArgs e)
        {
            TB_FB1.Clear();
        }
        private void L_FB2_Click(object sender, EventArgs e)
        {
            TB_FB2.Clear();
        }
        private void L_FB3_Click(object sender, EventArgs e)
        {
            TB_FB3.Clear();
        }
        private void L_FB4_Click(object sender, EventArgs e)
        {
            TB_FB4.Clear();
        }
        private void L_FB5_Click(object sender, EventArgs e)
        {
            TB_FB5.Clear();
        }

        #endregion
        #region Memory buttons
        private void B_SaveAll_Click(object sender, EventArgs e)
        {
            File.WriteAllText(FL_twitterFB_savedata, string.Empty);
            var TwtFBSaveDataLines = File.ReadAllLines(FL_twitterFB_savedata).ToList();
            TwtFBSaveDataLines.Add(TB_tweet1.Text);
            TwtFBSaveDataLines.Add(TB_tweet2.Text);
            TwtFBSaveDataLines.Add(TB_tweet3.Text);
            TwtFBSaveDataLines.Add(TB_tweet4.Text);
            TwtFBSaveDataLines.Add(TB_tweet5.Text);
            TwtFBSaveDataLines.Add(TB_FB1.Text);
            TwtFBSaveDataLines.Add(TB_FB2.Text);
            TwtFBSaveDataLines.Add(TB_FB3.Text);
            TwtFBSaveDataLines.Add(TB_FB4.Text);
            TwtFBSaveDataLines.Add(TB_FB5.Text);
            File.WriteAllLines(FL_twitterFB_savedata, TwtFBSaveDataLines.ToArray());
        }
        private void B_LoadAll_Click(object sender, EventArgs e)
        {
            var TwtFBSaveDataLines = File.ReadAllLines(FL_twitterFB_savedata).ToList();
            TB_tweet1.Text  = TwtFBSaveDataLines[0];
            TB_tweet2.Text  = TwtFBSaveDataLines[1];
            TB_tweet3.Text  = TwtFBSaveDataLines[2];
            TB_tweet4.Text  = TwtFBSaveDataLines[3];
            TB_tweet5.Text  = TwtFBSaveDataLines[4];
            TB_FB1.Text = TwtFBSaveDataLines[5];
            TB_FB2.Text = TwtFBSaveDataLines[6];
            TB_FB3.Text = TwtFBSaveDataLines[7];
            TB_FB4.Text = TwtFBSaveDataLines[8];
            TB_FB5.Text = TwtFBSaveDataLines[9];

        }
        private void B_ClearAll_Click(object sender, EventArgs e)
        {
            DialogResult dialogresult = MessageBox.Show("This will remove all saved tweets, FBs & emails", "Clear Memory", MessageBoxButtons.YesNo);
            if(dialogresult == DialogResult.Yes)
            {
                #region Clear all text boxes
                TB_tweet1.Clear();
                TB_tweet2.Clear();
                TB_tweet3.Clear();
                TB_tweet4.Clear();
                TB_tweet5.Clear();
                TB_FB1.Clear();
                TB_FB2.Clear();
                TB_FB3.Clear();
                TB_FB4.Clear();
                TB_FB5.Clear();
                #endregion
                File.WriteAllText(FL_twitterFB_savedata, string.Empty);
            }
        }





        #endregion


    }
}
