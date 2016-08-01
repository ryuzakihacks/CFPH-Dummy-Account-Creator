using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using mshtml;


namespace CFPH_Dummy_Account_Creator
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            browser.ScriptErrorsSuppressed = true;
            browser.DocumentCompleted += DocumentCompleteHandler;
            browser.StatusTextChanged += Updatestatus;
        }

        private void Updatestatus(object sender, EventArgs e)
        {
            if (browser.StatusText.Contains("https://mem.ph.gameclub.com/Member/Join/UserAgreeFrm.asp"))
            {
                label_status.Text = "Status: Loading EULA";
            }

            if (browser.StatusText.Contains("https://mem.ph.gameclub.com/Member/Join/MemberJoinFrm.asp"))
            {
                label_status.Text = "Status: Loading CAPTCHA";
            }
            if (browser.StatusText.Contains("https://mem.ph.gameclub.com/Member/Join/Complete.asp"))
            {
                label_status.Text = "Status: Finalizing";
            }
        }


        private void DocumentCompleteHandler(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            if (browser.Url.ToString() == "https://mem.ph.gameclub.com/Member/Join/UserAgreeFrm.asp")
            {
                browser.Document.GetElementById("chk_agree1").InvokeMember("CLICK");
                browser.Document.GetElementById("chk_agree2").InvokeMember("CLICK");
                browser.Document.InvokeScript("agree");
            }
            if (browser.Url.ToString() == "https://mem.ph.gameclub.com/Member/Join/MemberJoinFrm.asp")
            {
                IHTMLDocument2 document = (IHTMLDocument2)browser.Document.DomDocument;
                IHTMLControlRange imgRange = (IHTMLControlRange)((HTMLBody)document.body).createControlRange();

                imgRange.add((IHTMLControlElement) document.all.item("imgCaptcha"));
                imgRange.execCommand("Copy");
                picturebox.Image = (Bitmap) Clipboard.GetDataObject().GetData(DataFormats.Bitmap);

                label_status.Text = "Status: Ready";
                textbox_capcha.Enabled = true;
                textbox_username.Enabled = true;
                textbox_password.Enabled = true;
            }

            if (browser.Url.ToString() == "https://mem.ph.gameclub.com/Member/Join/Complete.asp")
            {
                MessageBox.Show("Registration Sucessful");
                Close();
            }
        }
        
        private void button_createaccount_Click(object sender, EventArgs e)
        {
            if (browser.Url.ToString() != "https://mem.ph.gameclub.com/Member/Join/MemberJoinFrm.asp") return;
            browser.Document.GetElementById("user_id").SetAttribute("value", textbox_username.Text);
            browser.Document.GetElementById("user_pw").SetAttribute("value", textbox_password.Text);
            browser.Document.GetElementById("user_pw2").SetAttribute("value", textbox_password.Text);
            browser.Document.GetElementById("user_nick").SetAttribute("value", RandomString(15));
            browser.Document.GetElementById("mail1").SetAttribute("value", RandomString(15));
            browser.Document.GetElementById("selectmail").Children[1].SetAttribute("selected", "selected");
            browser.Document.GetElementById("mail2").SetAttribute("value", "yahoo.com");
            browser.Document.GetElementById("fname").SetAttribute("value", RandomString(15));
            browser.Document.GetElementById("lname").SetAttribute("value", RandomString(15));
            browser.Document.GetElementById("gender").InvokeMember("CLICK");
            browser.Document.GetElementById("iMonth").Children[1].SetAttribute("selected", "selected");
            browser.Document.GetElementById("iDay").Children[1].SetAttribute("selected", "selected");
            browser.Document.GetElementById("iYear").Children[1].SetAttribute("selected", "selected");
            browser.Document.GetElementById("province").Children[1].SetAttribute("selected", "selected");
            browser.Document.GetElementById("province").InvokeMember("onChange");
            //browser.Document.GetElementById("city").Children[1].SetAttribute("selected", "selected");
            browser.Document.GetElementById("question").Children[1].SetAttribute("selected", "selected");
            browser.Document.GetElementById("answer").SetAttribute("value", RandomString(15));
            browser.Document.GetElementById("SecretNumber").SetAttribute("value", textbox_capcha.Text);
            browser.Document.InvokeScript("frmSubmit");
        }

      

    

        private static Random random = new Random((int)DateTime.Now.Ticks);//thanks to McAden
        private string RandomString(int size)
        {
            StringBuilder builder = new StringBuilder();
            char ch;
            for (int i = 0; i < size; i++)
            {
                ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65)));
                builder.Append(ch);
            }

            return builder.ToString();
        }

      
     }
}
