using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using WindowsFormsApp1.Algorythm;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class Cipher : Form
    {
        Actions asd = new Actions();
        public Cipher()
        {
            InitializeComponent();
            
        }

        private void browseDecode_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            string filename = openFileDialog1.FileName;
            string readfile = File.ReadAllText(filename);
            textBox3.Text = readfile;
        }
        private void browseEncode_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            string filename = openFileDialog1.FileName;
            string readfile = File.ReadAllText(filename);
            textBoxEncode.Text = readfile;
        }
       
        //гасло
        private void goEncode_Click(object sender, EventArgs e)
        {
            asd.Vectors(textBoxEncode.Text);
            if (gasloEncodeRButton.Checked)
            {
                textBoxEncodeResult.Text = asd.GasloEncode(textBoxEncode.Text, keywordEtext.Text);
            }
            else if (linearEncode.Checked)
            {
                textBoxEncodeResult.Text = asd.EncodeLinear(textBoxEncode.Text);
            }
            else
            {
                textBoxEncodeResult.Text = asd.EncodeNonLinear(textBoxEncode.Text);
            }
        }
        private void DecodeButton_Click(object sender, EventArgs e)
        {
            if (gasloDecode.Checked)
            {
                textBox4.Text = asd.GasloDecode(textBox3.Text, keywordD.Text);
            }
            else if (linearEncode.Checked)
            {
                textBox4.Text = asd.DecodeLinear(textBox3.Text);
            }
            else
            {
                textBox4.Text = asd.DecodeNonLinear(textBox3.Text);
            }
        }
        private void gasloEncodeRButton_CheckedChanged(object sender, EventArgs e)
        {
            textBoxEncodeResult.Clear();
            lableForg1.Visible = true;
            keywordEtext.Visible = true;
        }

        private void gasloDecode_CheckedChanged(object sender, EventArgs e)
        {
            textBox4.Clear();
            lableForg2.Visible = true;
            keywordD.Visible = true;
        }

        private void linearEncode_CheckedChanged(object sender, EventArgs e)
        {
            textBoxEncodeResult.Clear();
            lableForg1.Visible = false;
            keywordEtext.Visible = false;
        }

        private void nonLinearEncode_CheckedChanged(object sender, EventArgs e)
        {
            textBoxEncodeResult.Clear();
            lableForg1.Visible = false;
            keywordEtext.Visible = false;
        }

        private void linearDecode_CheckedChanged(object sender, EventArgs e)
        {
            textBox4.Clear();
            lableForg2.Visible = false;
            keywordD.Visible = false;
        }

        private void nonlinearDe_CheckedChanged(object sender, EventArgs e)
        {
            textBox4.Clear();
            lableForg2.Visible = false;
            keywordD.Visible = false;
        }

        private void exportEncode_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (Stream s  = File.Open(saveFileDialog.FileName, FileMode.CreateNew))
                using (StreamWriter sw = new StreamWriter(s))
                {
                    sw.Write(textBoxEncodeResult.Text);
                }
            }
        }

        private void exportDecode_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (Stream s = File.Open(saveFileDialog.FileName, FileMode.CreateNew))
                using (StreamWriter sw = new StreamWriter(s))
                {
                    sw.Write(textBox4.Text);
                }
            }
        }
    }
}
