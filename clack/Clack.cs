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

        bool FileBtnClicked = false;

        public void HideAllMenus()
        {

            filePanel.Visible = false;
            FileBtnClicked = false;

        }

        public void ShowMenu(uint menu)
        {
            if (menu == 0)
            {
                filePanel.Visible = true;
                FileBtnClicked = true;
            }
        }

        

        public Clack()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HideAllMenus();
            openFileDialog1.ShowDialog();
            try
            {
                path = openFileDialog1.FileName;
                Console.WriteLine(path);
                string readfile = File.ReadAllText(path);
                textArea.Text = readfile;
            }
            catch { }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            HideAllMenus();
            if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                path = saveFileDialog1.FileName;
                Console.WriteLine(path);
                BinaryWriter bw = new BinaryWriter(File.Create(path));
                bw.Write(textArea.Text);
                bw.Dispose();
            }
            Console.WriteLine(path);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            HideAllMenus();
            if (File.Exists(path))
            {
                BinaryWriter bw = new BinaryWriter(File.Open(path, FileMode.Create));
                bw.Write(textArea.Text);
                bw.Dispose();
            }
            else
            {
                if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    path = saveFileDialog1.FileName;
                    Console.WriteLine(path);
                    BinaryWriter bw = new BinaryWriter(File.Create(path));
                    bw.Write(textArea.Text);
                    bw.Dispose();
                }
            }
        }

        private void Clack_Load(object sender, EventArgs e) {}

        private void button4_Click(object sender, EventArgs e)
        {
            HideAllMenus();
            if (!FileBtnClicked)
            {
                ShowMenu(0);
            } else if (FileBtnClicked)
            {
                HideAllMenus();
            }
        }

        private void textArea_Click(object sender, EventArgs e) { HideAllMenus(); }
    }
}
