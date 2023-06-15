using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaldırıTespitSistemi
{
    public partial class Form2 : Form
    {
        private Form1 form1;
        public Form2(Form1 form1)
        {
            InitializeComponent();
            this.form1 = new Form1();
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 frm = new Form1();
            frm.ShowDialog();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 50; i++)
            {
                Thread.Sleep(50);
            }

            string selectedValue = form1.SelectedItem;
        }

        private void btnSaldiriOlustur_Click(object sender, EventArgs e)
        {
            RunPythonScript();
        }

        private void RunPythonScript()
        {
            string pythonPath = "C:\\Users\\9500169\\AppData\\Roaming\\Microsoft\\Windows\\Start Menu\\Programs\\Python 3.9";
            string scriptPath = "C:\\Users\\9500169\\Desktop\\bitirme_projesi\\SaldırıTespitSistemi\\Model1_LR.py";

            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = pythonPath;
            startInfo.Arguments = scriptPath;
            startInfo.RedirectStandardOutput = true;
            startInfo.UseShellExecute = false;
            startInfo.CreateNoWindow = true;

            using (Process process = Process.Start(startInfo))
            {
                using (StreamReader reader = process.StandardOutput)
                {
                    string result = reader.ReadToEnd();
                    richTextBox1.Text = result;
                }
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
