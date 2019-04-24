// Mike Bashkatov
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

namespace ArrayListSimpleEx
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ArrayList text = new ArrayList();
        string progrText = "";
        bool reverse;

        private void arrayListOperation()
        {
            text.Add("I");
            text.Add("Love");
            text.Add("Programming");
            text.Add("So");
            text.Add("Much");
        }

        private void str()
        {
            progrText = "";
            for (int i = 0; i < text.Count; i++)
            {
                progrText += text[i].ToString() + " ";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            arrayListOperation();
        }

        private void btnShowMsg_Click(object sender, EventArgs e)
        {
            if(reverse == true)
            {
                reverse = false;
                text.Reverse();
            }
            str();
            lblMessage.Text = progrText;
        }

        private void btnReverse_Click(object sender, EventArgs e)
        {
            text.Reverse();
            str();
            lblMessage.Text = progrText;
            reverse = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string addedText = txtSecondPos.Text + " ";
            if(reverse == true)
            {
                MessageBox.Show("Please show message in a regular order first");
            }

            else if (txtSecondPos.Text == string.Empty)
            {
                MessageBox.Show("Please enter at least something");
            }
            else
            {
                addedText.TrimStart();
                text.Insert(2, addedText);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (reverse == true)
            {
                MessageBox.Show("Please show message in a regular order first");
            }
            else
            {
                if(text.Count <= 2)
                {
                    MessageBox.Show("Phrase is alreDY TOO SMALL!");
                }
                else
                {
                    text.RemoveAt(2);
                }
            }

        }
    }
}
