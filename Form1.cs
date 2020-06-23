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
        readonly string FL_origional    = @"Dependencies\\SlideshowOrigional.html";         //Template for HTML slideshow
        readonly string FL_cssstyle     = @"Dependencies\\cssstyles.css";                   //CSS for slideshow
        readonly string FL_jquery       = @"Dependencies\\jquery-1.4.2.min.js";             //Javascript for slidshow
        readonly string FL_OBS_Twitter  = @"OBS_Twitter.html";                              //Output HTML page
        readonly string FL_twitterFB_savedata = @"Dependencies\\twitterFB_savedata.txt";    //Savedata for tweets and facebook comments    
        readonly string FL_Email_savedata = @"Dependencies\\Email_savedata.txt";            //Savedata for emails 
        readonly string FL_multiview = @"Multiview.html";                                   //Multiview output
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
            //Check to see if the critical files exist
            bool file1, file2, file3;
            file1 = System.IO.File.Exists(FL_origional);    
            file2 = System.IO.File.Exists(FL_cssstyle);
            file3 = System.IO.File.Exists(FL_jquery);

            if (file1 & file2 & file3) 
            {
                //If all critical files exist, allow user to continue
                B_FileCheck.BackColor = Color.Green;
                GB_ActiveArea.Enabled = true;
            }
            else
            {
                //Lock user out 
                B_FileCheck.BackColor = Color.Red;
                GB_ActiveArea.Enabled = false;
            }
        }
        #endregion

        string EmailHTML;
        readonly string EmailHTMLOrigional =    //HTML string for inserting an email. This creates a box with a name, body and email icon
                    "<link rel=\"stylesheet\" type=\"text/css\" href=\"Dependencies/cssstyles.css\" />" +
                    "<p id=\"emailbox\"><table><tr><th style=\"font-size: 30px;\">" +
                    " NAME " +
                    "</th><th  style=\"text-align: right;\"><img src=\"Dependencies/email.png\" height=\"50\" width=\"50\"></th></tr><tr><th colspan=\"2\">" +
                    " BODY " +
                    "</th></tr><tr><th colspan=\"2\">" +
                    //"<img src=\"Dependencies/pic.jfif\" width=\"458px\">",
                    "</th></tr></table></p>";

        //list for savedata. Each email uses 2 elements in the list, one for name and one for body
        //Eg... Email1 name = EmailSaveData[0] and Email1 body = EmailSaveData[1]
        List<string> EmailSavedata = new List<string>(new string[10]);  

        //HTML for the multiview output. ITs just an HTML table
        readonly string MultiviewHTML =
            "<meta http-equiv=\"refresh\" content=\"10\">" + //refresh webpage every 10 seconds
            "<table>" +
            "<tr>" +
            "<th id=\"multiview\">EMAIL1</th>" +
            "<th id=\"multiview\">EMAIL2</th>" +
            "<th id=\"multiview\">EMAIL3</th>" +
            "<th id=\"multiview\">EMAIL4</th>" +
            "<th id=\"multiview\">EMAIL5</th>" +
            "</tr>" +
            "<tr>" +
            "<th>TWEET1</th>" +
            "<th>TWEET2</th>" +
            "<th>TWEET3</th>" +
            "<th>TWEET4</th>" +
            "<th>TWEET5</th>" +
            "</tr>" +
            "<tr>" +
            "<th>FB1</th>" +
            "<th>FB2</th>" +
            "<th>FB3</th>" +
            "<th>FB4</th>" +
            "<th>FB5</th>" +
            "</tr>" +
            "</table>";


        #region Clear and update buttons
        private void B_Clear_Click(object sender, EventArgs e)
        {
            //Clear file by deleating it and copying the template across
            File.Delete(FL_OBS_Twitter);
            File.Copy(FL_origional, FL_OBS_Twitter);
        }
        private void B_Update_Click(object sender, EventArgs e)
        {
            //For displaying single social media snippets. 
            //simple IF checks all radio buttons. only one radio button can be checked at once, as they are all in the same region. 
            if (RB_single.Checked)
            {
                #region Singles
                //Single tweets
                if (RB_tweet1.Checked)
                {
                    File.Delete(FL_OBS_Twitter);
                    //write raw tweet embed data directly to the HTML file
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
                    //Write raw facebook comment embed data to HTML file. Change width to line up with tweet width. Change heigh to be auto, else you loose the bottom of the comment with the reduced width
                    File.WriteAllText(FL_OBS_Twitter, TB_FB1.Text.Replace("width=\"560\"", "width=\"550\"").Replace("height=\"", "height=\"auto"));
                }
                if (RB_FB2.Checked)
                {
                    File.Delete(FL_OBS_Twitter);
                    File.WriteAllText(FL_OBS_Twitter, TB_FB2.Text.Replace("width=\"560\"", "width=\"550\"").Replace("height=\"", "height=\"auto"));
                }
                if (RB_FB3.Checked)
                {
                    File.Delete(FL_OBS_Twitter);
                    File.WriteAllText(FL_OBS_Twitter, TB_FB3.Text.Replace("width=\"560\"", "width=\"550\"").Replace("height=\"", "height=\"auto"));
                }
                if (RB_FB4.Checked)
                {
                    File.Delete(FL_OBS_Twitter);
                    File.WriteAllText(FL_OBS_Twitter, TB_FB4.Text.Replace("width=\"560\"", "width=\"550\"").Replace("height=\"", "height=\"auto"));
                }
                if (RB_FB5.Checked)
                {
                    File.Delete(FL_OBS_Twitter);
                    File.WriteAllText(FL_OBS_Twitter, TB_FB5.Text.Replace("width=\"560\"", "width=\"550\"").Replace("height=\"", "height=\"auto"));
                }
                //emails
                if (RB_Email1.Checked)
                {
                    File.Delete(FL_OBS_Twitter);
                    EmailHTML = EmailHTMLOrigional; //Reset EmailHTML veriable with template
                    //Insert email html into output html file. Replace name and body with the data
                    File.WriteAllText(FL_OBS_Twitter, EmailHTML.Replace("NAME", EmailSavedata[0]).Replace("BODY", EmailSavedata[1]));
                }
                if (RB_Email2.Checked)
                {
                    File.Delete(FL_OBS_Twitter);
                    EmailHTML = EmailHTMLOrigional;
                    File.WriteAllText(FL_OBS_Twitter, EmailHTML.Replace("NAME", EmailSavedata[2]).Replace("BODY", EmailSavedata[3]));
                }
                if (RB_Email3.Checked)
                {
                    File.Delete(FL_OBS_Twitter);
                    EmailHTML = EmailHTMLOrigional;
                    EmailHTML.Replace("NAME", EmailSavedata[4]);
                    File.WriteAllText(FL_OBS_Twitter, EmailHTML.Replace("NAME", EmailSavedata[4]).Replace("BODY", EmailSavedata[5]));
                }
                if (RB_Email4.Checked)
                {
                    File.Delete(FL_OBS_Twitter);
                    EmailHTML = EmailHTMLOrigional;
                    File.WriteAllText(FL_OBS_Twitter, EmailHTML.Replace("NAME", EmailSavedata[6]).Replace("BODY", EmailSavedata[7]));
                }
                if (RB_Email5.Checked)
                {
                    File.Delete(FL_OBS_Twitter);
                    EmailHTML = EmailHTMLOrigional;
                    File.WriteAllText(FL_OBS_Twitter, EmailHTML.Replace("NAME", EmailSavedata[8]).Replace("BODY", EmailSavedata[9]));
                }

                #endregion
            }

            //for when a slideshow is wanted
            if (RB_slideshow.Checked)
            {
                File.Delete(FL_OBS_Twitter);
                File.Copy(FL_origional, FL_OBS_Twitter);    //reset html file every time
                //reverse order so that first tweet shows first
                //Tweets
                if (CB_tweet5.Checked)
                {
                    //<li> </li> needs to encapsulate every social media snippet
                    var alllines = File.ReadAllLines(FL_OBS_Twitter).ToList();
                    alllines.Insert(14, "");
                    alllines.Insert(15, "<li>");
                    alllines.Insert(16, TB_tweet5.Text);    //write tweet embed data
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
                    alllines.Insert(15, "<li id=\"FBcomment\">");   //change id in CSS. refer to css file to see whats changed
                    alllines.Insert(16, TB_FB1.Text.Replace("width=\"560\"", "width=\"550\"").Replace("height=\"", "height=\"auto"));   //change height and width as before 
                    alllines.Insert(17, "</li>");
                    File.WriteAllLines(FL_OBS_Twitter, alllines.ToArray());
                }
                if (CB_FB2.Checked)
                {
                    var alllines = File.ReadAllLines(FL_OBS_Twitter).ToList();
                    alllines.Insert(14, "");
                    alllines.Insert(15, "<li id=\"FBcomment\">");
                    alllines.Insert(16, TB_FB2.Text.Replace("width=\"560\"", "width=\"550\"").Replace("height=\"", "height=\"auto"));
                    alllines.Insert(17, "</li>");
                    File.WriteAllLines(FL_OBS_Twitter, alllines.ToArray());
                }
                if (CB_FB3.Checked)
                {
                    var alllines = File.ReadAllLines(FL_OBS_Twitter).ToList();
                    alllines.Insert(14, "");
                    alllines.Insert(15, "<li id=\"FBcomment\">");
                    alllines.Insert(16, TB_FB3.Text.Replace("width=\"560\"", "width=\"550\"").Replace("height=\"", "height=\"auto"));
                    alllines.Insert(17, "</li>");
                    File.WriteAllLines(FL_OBS_Twitter, alllines.ToArray());
                }
                if (CB_FB4.Checked)
                {
                    var alllines = File.ReadAllLines(FL_OBS_Twitter).ToList();
                    alllines.Insert(14, "");
                    alllines.Insert(15, "<li id=\"FBcomment\">");
                    alllines.Insert(16, TB_FB4.Text.Replace("width=\"560\"", "width=\"550\"").Replace("height=\"", "height=\"auto"));
                    alllines.Insert(17, "</li>");
                    File.WriteAllLines(FL_OBS_Twitter, alllines.ToArray());
                }
                if (CB_FB5.Checked)
                {
                    var alllines = File.ReadAllLines(FL_OBS_Twitter).ToList();
                    alllines.Insert(14, "");
                    alllines.Insert(15, "<li id=\"FBcomment\">");
                    alllines.Insert(16, TB_FB5.Text.Replace("width=\"560\"", "width=\"550\"").Replace("height=\"", "height=\"auto"));
                    alllines.Insert(17, "</li>");
                    File.WriteAllLines(FL_OBS_Twitter, alllines.ToArray());
                }

                //Emails
                if (CB_Email1.Checked)
                {
                    EmailHTML = EmailHTMLOrigional;
                    var alllines = File.ReadAllLines(FL_OBS_Twitter).ToList();
                    alllines.Insert(14, "");
                    alllines.Insert(15, "<li id=\"emailboxslideshow\">");   //email slideshow CSS. Refer to css file
                    alllines.Insert(16, EmailHTML.Replace("id=\"emailbox\"","").Replace("NAME", EmailSavedata[0]).Replace("BODY", EmailSavedata[1]));   //replace name and body with data
                    alllines.Insert(17, "</li>");
                    File.WriteAllLines(FL_OBS_Twitter, alllines.ToArray());
                }
                //Emails
                if (CB_Email2.Checked)
                {
                    EmailHTML = EmailHTMLOrigional;
                    var alllines = File.ReadAllLines(FL_OBS_Twitter).ToList();
                    alllines.Insert(14, "");
                    alllines.Insert(15, "<li id=\"emailboxslideshow\">");
                    alllines.Insert(16, EmailHTML.Replace("id=\"emailbox\"", "").Replace("NAME", EmailSavedata[2]).Replace("BODY", EmailSavedata[3]));
                    alllines.Insert(17, "</li>");
                    File.WriteAllLines(FL_OBS_Twitter, alllines.ToArray());
                }
                //Emails
                if (CB_Email3.Checked)
                {
                    EmailHTML = EmailHTMLOrigional;
                    var alllines = File.ReadAllLines(FL_OBS_Twitter).ToList();
                    alllines.Insert(14, "");
                    alllines.Insert(15, "<li id=\"emailboxslideshow\">");
                    alllines.Insert(16, EmailHTML.Replace("id=\"emailbox\"", "").Replace("NAME", EmailSavedata[4]).Replace("BODY", EmailSavedata[5]));
                    alllines.Insert(17, "</li>");
                    File.WriteAllLines(FL_OBS_Twitter, alllines.ToArray());
                }
                //Emails
                if (CB_Email4.Checked)
                {
                    EmailHTML = EmailHTMLOrigional;
                    var alllines = File.ReadAllLines(FL_OBS_Twitter).ToList();
                    alllines.Insert(14, "");
                    alllines.Insert(15, "<li id=\"emailboxslideshow\">");
                    alllines.Insert(16, EmailHTML.Replace("id=\"emailbox\"", "").Replace("NAME", EmailSavedata[6]).Replace("BODY", EmailSavedata[7]));
                    alllines.Insert(17, "</li>");
                    File.WriteAllLines(FL_OBS_Twitter, alllines.ToArray());
                }
                //Emails
                if (CB_Email5.Checked)
                {
                    EmailHTML = EmailHTMLOrigional;
                    var alllines = File.ReadAllLines(FL_OBS_Twitter).ToList();
                    alllines.Insert(14, "");
                    alllines.Insert(15, "<li id=\"emailboxslideshow\">");
                    alllines.Insert(16, EmailHTML.Replace("id=\"emailbox\"", "").Replace("NAME", EmailSavedata[8]).Replace("BODY", EmailSavedata[9]));
                    alllines.Insert(17, "</li>");
                    File.WriteAllLines(FL_OBS_Twitter, alllines.ToArray());
                }
            }
            #region Multiview output

            EmailHTML = EmailHTMLOrigional;
            File.Delete(FL_multiview);  //reset multiview file
            File.WriteAllText(FL_multiview, MultiviewHTML
                //different CSS is needed for multiview. Replace name and body as before
                .Replace("EMAIL1", EmailHTML.Replace("id=\"emailbox\"", "id=\"emailboxmultiview\"").Replace("NAME", EmailSavedata[0]).Replace("BODY", EmailSavedata[1]))
                .Replace("EMAIL2", EmailHTML.Replace("id=\"emailbox\"", "id=\"emailboxmultiview\"").Replace("NAME", EmailSavedata[2]).Replace("BODY", EmailSavedata[3]))
                .Replace("EMAIL3", EmailHTML.Replace("id=\"emailbox\"", "id=\"emailboxmultiview\"").Replace("NAME", EmailSavedata[4]).Replace("BODY", EmailSavedata[5]))
                .Replace("EMAIL4", EmailHTML.Replace("id=\"emailbox\"", "id=\"emailboxmultiview\"").Replace("NAME", EmailSavedata[6]).Replace("BODY", EmailSavedata[7]))
                .Replace("EMAIL5", EmailHTML.Replace("id=\"emailbox\"", "id=\"emailboxmultiview\"").Replace("NAME", EmailSavedata[8]).Replace("BODY", EmailSavedata[9]))

                //Copy tweets directly
                .Replace("TWEET1", TB_tweet1.Text)
                .Replace("TWEET2", TB_tweet2.Text)
                .Replace("TWEET3", TB_tweet3.Text)
                .Replace("TWEET4", TB_tweet4.Text)
                .Replace("TWEET5", TB_tweet5.Text)

                //remove width style. Multiview is a table, so the width is automaticaly controlled 
                .Replace("FB1", TB_FB1.Text.Replace("width=\"560\"", ""))
                .Replace("FB2", TB_FB2.Text.Replace("width=\"560\"", ""))
                .Replace("FB3", TB_FB3.Text.Replace("width=\"560\"", ""))
                .Replace("FB4", TB_FB4.Text.Replace("width=\"560\"", ""))
                .Replace("FB5", TB_FB5.Text.Replace("width=\"560\"", "")));

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
            File.WriteAllText(FL_twitterFB_savedata, string.Empty); //clear file
            var TwtFBSaveDataLines = File.ReadAllLines(FL_twitterFB_savedata).ToList(); //read file to set type of 'TwtFBSaveDataLines'
            //add all elements to the list
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
            File.WriteAllLines(FL_twitterFB_savedata, TwtFBSaveDataLines.ToArray());    //write to file

            //check to see what email is being shown at that time
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
            File.WriteAllLines(FL_Email_savedata, EmailSavedata.ToArray()); //save email data

        }
        private void B_LoadAll_Click(object sender, EventArgs e)
        {
            var TwtFBSaveDataLines = File.ReadAllLines(FL_twitterFB_savedata).ToList(); //read file to set type of 'TwtFBSaveDataLines'
            //write data to text boxes
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
            ComB_Email.SelectedIndex = 0;           //select first email
            TB_EmailName.Text = EmailSavedata[0];   //write first email data to textboxes
            TB_EmailBody.Text = EmailSavedata[1];
        }
        private void B_ClearAll_Click(object sender, EventArgs e)
        {
            //message box, just in case
            DialogResult dialogresult = MessageBox.Show("This will remove all saved tweets, FBs & emails", "Clear Memory", MessageBoxButtons.YesNo);
            if(dialogresult == DialogResult.Yes)
            {
                //clear text boxes
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

                //clear save data files
                File.WriteAllText(FL_twitterFB_savedata, string.Empty);
                File.WriteAllText(FL_Email_savedata, string.Empty);
                EmailSavedata.Clear();
            }
        }
        #endregion

        private void CB_Email_SelectedIndexChanged(object sender, EventArgs e)
        {
            //when the email selection index is changed, change what is shown in the textboxes
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
            //as soon as the email selection box is clicked(before index has been changed), save current email to save data
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
