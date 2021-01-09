using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PassGenApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            passlabel.Text = CreateRandomPassword(trackBar1.Value);
            

        }

        private void generate_Click(object sender, EventArgs e)
        {
           
            if (numberbox.Checked)
            {
                passlabel.Text = CreateRandomPassword2(trackBar1.Value);
         
            }
            else if (symbolbox.Checked)
            {
                passlabel.Text = CreateRandomPassword3(trackBar1.Value);
              
            }
            else if (!symbolbox.Checked && !numberbox.Checked)
            {
                passlabel.Text = CreateRandomPassword(trackBar1.Value);  passlabel.Font = new Font("JMHTypewriterdry-Regular", 15, FontStyle.Regular);
            }
        }

        private static string CreateRandomPassword(int length)
        {
            string validChars = "ABCDEFGHJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
            Random random = new Random();

            char[] chars = new char[length];
            for (int i = 0; i < length; i++)
            {
                chars[i] = validChars[random.Next(0, validChars.Length)];
            }
            return new string(chars);
        }
        private static string CreateRandomPassword2(int length)
        {
            string validChars = "ABCDEFGHJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz01234567890";
            Random random = new Random();

            char[] chars = new char[length];
            for (int i = 0; i < length; i++)
            {
                chars[i] = validChars[random.Next(0, validChars.Length)];
            }
            return new string(chars);
        }
        private static string CreateRandomPassword3(int length)
        {
            string validChars = "ABCDEFGHJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz01234567890!@#$%^&*()_+";
            Random random = new Random();

            char[] chars = new char[length];
            for (int i = 0; i < length; i++)
            {
                chars[i] = validChars[random.Next(0, validChars.Length)];
            }
            return new string(chars);
        }
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            count.Text = "" +  $"Length ({trackBar1.Value})";
           
        }

        private void copy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(passlabel.Text);
        }
    }
}
