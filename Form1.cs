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
        readonly string FL_twitterFB_savedata = @"Dependencies\\twitterFB_savedata.txt";
        readonly string FL_Email_savedata = @"Dependencies\\Email_savedata.txt";
        #endregion
        #region Loading things
        public F_SMauto()
        {
            InitializeComponent();
            GB_ActiveArea.Enabled = false;
            ComB_Email.SelectedIndex = 0;
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

        string EmailHTML;
        readonly string EmailHTMLOrigional =
                    "<link rel=\"stylesheet\" type=\"text/css\" href=\"Dependencies/cssstyles.css\" />"+
                    "<p id=\"emailbox\"><table><tr><th style=\"font-size: 30px;\">"+
                    "NAME"+
                    "</th><th  style=\"text-align: right;\"><img src=\"Dependencies/email.png\" height=\"50\" width=\"50\"></th></tr><tr><th colspan=\"2\">"+
                    "BODY"+
                    "</th></tr><tr><th colspan=\"2\">"+
                    //"<img src=\"Dependencies/pic.jfif\" width=\"458px\">",
                    "</th></tr></table></p>";

        List<string> EmailSavedata = new List<string>(new string[10]);

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
                #region Singles
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
                    File.WriteAllText(FL_OBS_Twitter, TB_FB1.Text.Replace("width=\"560\"", "width=\"550\"").Replace("height=\"", "height=\"9"));
                }
                if (RB_FB2.Checked)
                {
                    File.Delete(FL_OBS_Twitter);
                    File.WriteAllText(FL_OBS_Twitter, TB_FB2.Text.Replace("width=\"560\"", "width=\"550\"").Replace("height=\"", "height=\"9"));
                }
                if (RB_FB3.Checked)
                {
                    File.Delete(FL_OBS_Twitter);
                    File.WriteAllText(FL_OBS_Twitter, TB_FB3.Text.Replace("width=\"560\"", "width=\"550\"").Replace("height=\"", "height=\"9"));
                }
                if (RB_FB4.Checked)
                {
                    File.Delete(FL_OBS_Twitter);
                    File.WriteAllText(FL_OBS_Twitter, TB_FB4.Text.Replace("width=\"560\"", "width=\"550\"").Replace("height=\"", "height=\"9"));
                }
                if (RB_FB5.Checked)
                {
                    File.Delete(FL_OBS_Twitter);
                    File.WriteAllText(FL_OBS_Twitter, TB_FB5.Text.Replace("width=\"560\"", "width=\"550\"").Replace("height=\"", "height=\"9"));
                }
                //emails
                if (RB_Email1.Checked)
                {
                    File.Delete(FL_OBS_Twitter);
                    EmailHTML = EmailHTMLOrigional;
                    EmailHTML.Replace("NAME", EmailSavedata[0]);
                    EmailHTML.Replace("BODY", EmailSavedata[1]);
                    File.WriteAllText(FL_OBS_Twitter, EmailHTML);
                }
                if (RB_Email2.Checked)
                {
                    File.Delete(FL_OBS_Twitter);
                    EmailHTML = EmailHTMLOrigional;
                    EmailHTML.Replace("NAME", EmailSavedata[2]);
                    EmailHTML.Replace("BODY", EmailSavedata[3]);
                    File.WriteAllText(FL_OBS_Twitter, EmailHTML);
                }
                if (RB_Email3.Checked)
                {
                    File.Delete(FL_OBS_Twitter);
                    EmailHTML = EmailHTMLOrigional;
                    EmailHTML.Replace("NAME", EmailSavedata[4]);
                    EmailHTML.Replace("BODY", EmailSavedata[5]);
                    File.WriteAllText(FL_OBS_Twitter, EmailHTML);
                }
                if (RB_Email4.Checked)
                {
                    File.Delete(FL_OBS_Twitter);
                    EmailHTML = EmailHTMLOrigional;
                    EmailHTML.Replace("NAME", EmailSavedata[6]);
                    EmailHTML.Replace("BODY", EmailSavedata[7]);
                    File.WriteAllText(FL_OBS_Twitter, EmailHTML);
                }
                if (RB_Email5.Checked)
                {
                    File.Delete(FL_OBS_Twitter);
                    EmailHTML = EmailHTMLOrigional;
                    EmailHTML.Replace("NAME", EmailSavedata[8]);
                    EmailHTML.Replace("BODY", EmailSavedata[9]);
                    File.WriteAllText(FL_OBS_Twitter, EmailHTML);
                }

                #endregion
            }
            if (RB_slideshow.Checked)
            {
                File.Delete(FL_OBS_Twitter);
                File.Copy(FL_origional, FL_OBS_Twitter);
                #region Multis
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
                    alllines.Insert(16, TB_FB1.Text.Replace("width=\"560\"", "width=\"550\"").Replace("height=\"", "height=\"9"));
                    alllines.Insert(17, "</li>");
                    File.WriteAllLines(FL_OBS_Twitter, alllines.ToArray());
                }
                if (CB_FB2.Checked)
                {
                    var alllines = File.ReadAllLines(FL_OBS_Twitter).ToList();
                    alllines.Insert(14, "");
                    alllines.Insert(15, "<li>");
                    alllines.Insert(16, TB_FB2.Text.Replace("width=\"560\"", "width=\"550\"").Replace("height=\"", "height=\"9"));
                    alllines.Insert(17, "</li>");
                    File.WriteAllLines(FL_OBS_Twitter, alllines.ToArray());
                }
                if (CB_FB3.Checked)
                {
                    var alllines = File.ReadAllLines(FL_OBS_Twitter).ToList();
                    alllines.Insert(14, "");
                    alllines.Insert(15, "<li>");
                    alllines.Insert(16, TB_FB3.Text.Replace("width=\"560\"", "width=\"550\"").Replace("height=\"", "height=\"9"));
                    alllines.Insert(17, "</li>");
                    File.WriteAllLines(FL_OBS_Twitter, alllines.ToArray());
                }
                if (CB_FB4.Checked)
                {
                    var alllines = File.ReadAllLines(FL_OBS_Twitter).ToList();
                    alllines.Insert(14, "");
                    alllines.Insert(15, "<li>");
                    alllines.Insert(16, TB_FB4.Text.Replace("width=\"560\"", "width=\"550\"").Replace("height=\"", "height=\"9"));
                    alllines.Insert(17, "</li>");
                    File.WriteAllLines(FL_OBS_Twitter, alllines.ToArray());
                }
                if (CB_FB5.Checked)
                {
                    var alllines = File.ReadAllLines(FL_OBS_Twitter).ToList();
                    alllines.Insert(14, "");
                    alllines.Insert(15, "<li>");
                    alllines.Insert(16, TB_FB5.Text.Replace("width=\"560\"", "width=\"550\"").Replace("height=\"", "height=\"9"));
                    alllines.Insert(17, "</li>");
                    File.WriteAllLines(FL_OBS_Twitter, alllines.ToArray());
                }

                //Emails
                if (CB_Email1.Checked)
                {
                    EmailHTML = EmailHTMLOrigional;
                    EmailHTML.Replace("NAME", EmailSavedata[0]);
                    EmailHTML.Replace("BODY", EmailSavedata[1]);
                    var alllines = File.ReadAllLines(FL_OBS_Twitter).ToList();
                    alllines.Insert(14, "");
                    alllines.Insert(15, "<li id=\"emailboxslideshow\">");
                    alllines.Insert(16, EmailHTML.Replace("id=\"emailbox\"",""));
                    alllines.Insert(17, "</li>");
                    File.WriteAllLines(FL_OBS_Twitter, alllines.ToArray());
                }
                //Emails
                if (CB_Email2.Checked)
                {
                    EmailHTML = EmailHTMLOrigional;
                    EmailHTML.Replace("NAME", EmailSavedata[2]);
                    EmailHTML.Replace("BODY", EmailSavedata[3]);
                    var alllines = File.ReadAllLines(FL_OBS_Twitter).ToList();
                    alllines.Insert(14, "");
                    alllines.Insert(15, "<li id=\"emailboxslideshow\">");
                    alllines.Insert(16, EmailHTML.Replace("id=\"emailbox\"", ""));
                    alllines.Insert(17, "</li>");
                    File.WriteAllLines(FL_OBS_Twitter, alllines.ToArray());
                }
                //Emails
                if (CB_Email3.Checked)
                {
                    EmailHTML = EmailHTMLOrigional;
                    EmailHTML.Replace("NAME", EmailSavedata[4]);
                    EmailHTML.Replace("BODY", EmailSavedata[5]);
                    var alllines = File.ReadAllLines(FL_OBS_Twitter).ToList();
                    alllines.Insert(14, "");
                    alllines.Insert(15, "<li id=\"emailboxslideshow\">");
                    alllines.Insert(16, EmailHTML.Replace("id=\"emailbox\"", ""));
                    alllines.Insert(17, "</li>");
                    File.WriteAllLines(FL_OBS_Twitter, alllines.ToArray());
                }
                //Emails
                if (CB_Email4.Checked)
                {
                    EmailHTML = EmailHTMLOrigional;
                    EmailHTML.Replace("NAME", EmailSavedata[6]);
                    EmailHTML.Replace("BODY", EmailSavedata[7]);
                    var alllines = File.ReadAllLines(FL_OBS_Twitter).ToList();
                    alllines.Insert(14, "");
                    alllines.Insert(15, "<li id=\"emailboxslideshow\">");
                    alllines.Insert(16, EmailHTML.Replace("id=\"emailbox\"", ""));
                    alllines.Insert(17, "</li>");
                    File.WriteAllLines(FL_OBS_Twitter, alllines.ToArray());
                }
                //Emails
                if (CB_Email5.Checked)
                {
                    EmailHTML = EmailHTMLOrigional;
                    EmailHTML.Replace("NAME", EmailSavedata[8]);
                    EmailHTML.Replace("BODY", EmailSavedata[9]);
                    var alllines = File.ReadAllLines(FL_OBS_Twitter).ToList();
                    alllines.Insert(14, "");
                    alllines.Insert(15, "<li id=\"emailboxslideshow\">");
                    alllines.Insert(16, EmailHTML.Replace("id=\"emailbox\"", ""));
                    alllines.Insert(17, "</li>");
                    File.WriteAllLines(FL_OBS_Twitter, alllines.ToArray());
                }
                #endregion
            }
            #region Multiview output


            #endregion
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


            if (ComB_Email.SelectedIndex == 0)
            {
                EmailSavedata[0] = TB_EmailName.Text;
                EmailSavedata[1] = TB_EmailBody.Text;
            }
            if (ComB_Email.SelectedIndex == 1)
            {
                EmailSavedata[2] = TB_EmailName.Text;
                EmailSavedata[3] = TB_EmailBody.Text;
            }
            if (ComB_Email.SelectedIndex == 2)
            {
                EmailSavedata[4] = TB_EmailName.Text;
                EmailSavedata[5] = TB_EmailBody.Text;
            }
            if (ComB_Email.SelectedIndex == 3)
            {
                EmailSavedata[6] = TB_EmailName.Text;
                EmailSavedata[7] = TB_EmailBody.Text;
            }
            if (ComB_Email.SelectedIndex == 4)
            {
                EmailSavedata[8] = TB_EmailName.Text;
                EmailSavedata[9] = TB_EmailBody.Text;
            }

            File.WriteAllText(FL_Email_savedata, string.Empty);
            File.WriteAllLines(FL_Email_savedata, EmailSavedata.ToArray());

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

            EmailSavedata = File.ReadAllLines(FL_Email_savedata).ToList();
            ComB_Email.SelectedIndex = 0;
            TB_EmailName.Text = EmailSavedata[0];
            TB_EmailBody.Text = EmailSavedata[1];
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
                File.WriteAllText(FL_Email_savedata, string.Empty);
                EmailSavedata.Clear();
            }
        }






        #endregion

        private void CB_Email_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(ComB_Email.SelectedIndex == 0)
            {
                TB_EmailName.Text = EmailSavedata[0];
                TB_EmailBody.Text = EmailSavedata[1];
            }
            if (ComB_Email.SelectedIndex == 1)
            {
                TB_EmailName.Text = EmailSavedata[2];
                TB_EmailBody.Text = EmailSavedata[3];
            }
            if (ComB_Email.SelectedIndex == 2)
            {
                TB_EmailName.Text = EmailSavedata[4];
                TB_EmailBody.Text = EmailSavedata[5];
            }
            if (ComB_Email.SelectedIndex == 3)
            {
                TB_EmailName.Text = EmailSavedata[6];
                TB_EmailBody.Text = EmailSavedata[7];
            }
            if (ComB_Email.SelectedIndex == 4)
            {
                TB_EmailName.Text = EmailSavedata[8];
                TB_EmailBody.Text = EmailSavedata[9];
            }
        }

        private void ComB_Email_Click(object sender, EventArgs e)
        {
            if (ComB_Email.SelectedIndex == 0)
            {
                EmailSavedata[0] = TB_EmailName.Text;
                EmailSavedata[1] = TB_EmailBody.Text;
            }
            if (ComB_Email.SelectedIndex == 1)
            {
                EmailSavedata[2] = TB_EmailName.Text;
                EmailSavedata[3] = TB_EmailBody.Text;
            }
            if (ComB_Email.SelectedIndex == 2)
            {
                EmailSavedata[4] = TB_EmailName.Text;
                EmailSavedata[5] = TB_EmailBody.Text;
            }
            if (ComB_Email.SelectedIndex == 3)
            {
                EmailSavedata[6] = TB_EmailName.Text;
                EmailSavedata[7] = TB_EmailBody.Text;
            }
            if (ComB_Email.SelectedIndex == 4)
            {
                EmailSavedata[8] = TB_EmailName.Text;
                EmailSavedata[9] = TB_EmailBody.Text;
            }
        }
    }
}
