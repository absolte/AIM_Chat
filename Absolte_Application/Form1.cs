using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Absolte_Application
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            inputData();
            this.inputBox.Focus();
        }

        private void outputBox_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void inputBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                inputData();
            }
        }

        private void inputData()
        {   
            Colorize(this.outputBox, Color.Red, inputBox.Text + "\r\n");
            outputBox.SelectionStart = outputBox.Text.Length;
            outputBox.ScrollToCaret();
            outputBox.Refresh();
            inputBox.Clear();
        }

        void Colorize(RichTextBox textBox, Color color, string text)
        {
            int start = textBox.TextLength;
            textBox.AppendText(text);
            int end = textBox.TextLength;

            textBox.Select(start, end - start);
            {
                textBox.SelectionColor = color;
            }
            textBox.SelectionLength = 0;
        }
    }
}
