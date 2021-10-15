using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Title = "open";
            op.Filter = "Text Document (*.txt)|*.txt|All Files(*.*)|*.*";
            if (op.ShowDialog() == DialogResult.OK)
                richTextBox1.LoadFile(op.FileName, RichTextBoxStreamType.PlainText);
            this.Text = op.FileName;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog op = new SaveFileDialog();
            op.Title = "Save";
            op.Filter = "Text Document (*.txt)|*.txt|All Files(*.*)|*.*";
            if (op.ShowDialog() == DialogResult.OK)
                richTextBox1.SaveFile(op.FileName, RichTextBoxStreamType.PlainText);
            this.Text = op.FileName;
        }

      

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Redo();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
        }

        private void dateTImeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text= System.DateTime .Now.ToString();
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog op = new FontDialog();
            if (op.ShowDialog() == DialogResult.OK);
            richTextBox1.Font = op.Font;
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog op = new ColorDialog();
            if (op.ShowDialog() == DialogResult.OK);
            richTextBox1.ForeColor = op.Color ;

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Made By: Sarmad Razaq\n Registration ID: FA19-BCS-039 \n Course: Visual Programming \n Session: Fall 2019");
        }

        private void exitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            
        }
    }
}
