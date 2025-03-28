using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace notepad
{
    public partial class Form1 : Form
    {
        string filename = string.Empty,PrevFileContent = string.Empty;
        public Form1()
        {
            InitializeComponent();
        }
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(filename != String.Empty)
            {
                string CurrentFileContent = richTextBox1.Text;
                if(PrevFileContent != CurrentFileContent)
                {
                    richTextBox1.SaveFile(filename);
                    ClearData();
                    CurrentFileContent = string.Empty;
                }
                else
                {
                    ClearData();
                    CurrentFileContent = string.Empty;
                }
            }
            else if(richTextBox1.Text.Length > 0)
            {
                  DialogResult DR = MessageBox.Show("Do You Want to Save?", "Notepad", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                  if(DR == DialogResult.Yes)
                 {
                     SaveData();
                     ClearData();
                 }
                 else
                 {
                     ClearData();
                 }
              }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog OD = new OpenFileDialog();
            OD.Title = "Open -- Notepad";
            OD.Filter = "Text Files |*.txt";
            OD.DefaultExt = "txt";
            OD.InitialDirectory = "D:\\Afternoon";
            OD.ShowDialog();
            if (OD.FileName != "")
            {
                richTextBox1.LoadFile(OD.FileName);
                filename = OD.FileName;
                PrevFileContent = richTextBox1.Text;
            }
        }
        private void ClearData()
        {
            richTextBox1.Text=string.Empty;
            filename=string.Empty;
            PrevFileContent = string.Empty;
        }
    private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveData();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
           filename = string.Empty;
            SaveData();
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog FD = new FontDialog();
            FD.ShowDialog();
            richTextBox1.Font = FD.Font;
        }

        private void fontcolorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog CD = new ColorDialog();
            CD.ShowDialog();
            richTextBox1.ForeColor = CD.Color;
        }

        private void SaveData()
        {
            if (filename == string.Empty)
            {
                SaveFileDialog SD = new SaveFileDialog();
                SD.Title = "Save -- Notepad";
                SD.Filter = "Text Files |*.txt";
                SD.DefaultExt = "txt";
                SD.InitialDirectory = "D:\\Afternoon";
                SD.ShowDialog();
                if (SD.FileName != "")
                {
                    richTextBox1.SaveFile(SD.FileName);
                    filename = SD.FileName;
                    PrevFileContent = richTextBox1.Text;
                }
            }
            else
            {
                richTextBox1.SaveFile(filename);
            }
        }
      
    }
}



