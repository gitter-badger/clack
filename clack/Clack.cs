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

namespace clack
{
    public partial class Clack : Form
    {
        string path;

        public Clack()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            try
            {
                path = openFileDialog1.FileName;
                Console.WriteLine(path);
                string readfile = File.ReadAllText(path);
                richTextBox1.Text = readfile;
            }
            catch { }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Text File|*.txt";
            if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                path = saveFileDialog1.FileName;
                Console.WriteLine(path);
                BinaryWriter bw = new BinaryWriter(File.Create(path));
                bw.Write(richTextBox1.Text);
                bw.Dispose();
            }
            Console.WriteLine(path);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (File.Exists(path))
            {
                BinaryWriter bw = new BinaryWriter(File.Open(path, FileMode.Create));
                bw.Write(richTextBox1.Text);
                bw.Dispose();
            }
            else
            {
                saveFileDialog1.Filter = "Text File|*.txt";
                if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    path = saveFileDialog1.FileName;
                    Console.WriteLine(path);
                    BinaryWriter bw = new BinaryWriter(File.Create(path));
                    bw.Write(richTextBox1.Text);
                    bw.Dispose();
                }
            }
        }

        private void Clack_Load(object sender, EventArgs e)
        {
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
