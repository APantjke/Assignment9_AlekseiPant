using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment9_AlekseiPant
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void DisplayButton(object sender, EventArgs e)
        {
            string UserInput = textBox1.Text.ToString();
            int []charCount = new int[256];

            for (int i = 0; i < UserInput.Length; i++)
            {
                charCount[UserInput[i]]++;
            }

            int maxCount = -1;
            char character = ' ';

            for (int i = 0; i < UserInput.Length; i++)
            {
                if (maxCount < charCount[UserInput[i]])
                {
                    maxCount = charCount[UserInput[i]];
                    character = UserInput[i];
                }
            }

            textBox2.Text = "Most frequently appearing character in the string: " + character + "\r" + "\n" +
                            "Number of times this character occurs: " + maxCount;
        }
    }
}
