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
            this.form1 = form1;
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
                Thread.Sleep(5);
            }

            string selectedValue = form1.SelectedItem;
        }

        private void btnSaldiriOlustur_Click(object sender, EventArgs e)
        {
            string powerShellCommand;
            string output;

            if (form1.SelectedItem == "Lojistik Regresyon")
            {
                powerShellCommand = "python C:\\Users\\ogzhn\\Desktop\\saldiri-tespit-sistemi-main\\SaldırıTespitSistemi\\Model1_LR.py";
                output = RunPowerShellCommand(powerShellCommand);
                richTextBox1.Text = output;
            } 
            else if (form1.SelectedItem == "K En Yakın Komşu Algoritması")
            {
                powerShellCommand = "python C:\\Users\\ogzhn\\Desktop\\saldiri-tespit-sistemi-main\\SaldırıTespitSistemi\\Model1_KNN.py";
                output = RunPowerShellCommand(powerShellCommand);
                richTextBox1.Text = output;
            }
            else if (form1.SelectedItem == "LightGBM")
            {
                powerShellCommand = "python C:\\Users\\ogzhn\\Desktop\\saldiri-tespit-sistemi-main\\SaldırıTespitSistemi\\Model1_LightGBM.py";
                output = RunPowerShellCommand(powerShellCommand);
                richTextBox1.Text = output;
            }
            else if (form1.SelectedItem == "GBM")
            {
                powerShellCommand = "python C:\\Users\\ogzhn\\Desktop\\saldiri-tespit-sistemi-main\\SaldırıTespitSistemi\\Model1_GBM.py";
                output = RunPowerShellCommand(powerShellCommand);
                richTextBox1.Text = output;
            }
        }

        string RunPowerShellCommand(string command)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo
            {
                FileName = "powershell.exe",
                Arguments = $"-Command \"{command}\"",
                RedirectStandardOutput = true,
                UseShellExecute = false,
                CreateNoWindow = true
            };

            using (Process process = new Process())
            {
                process.StartInfo = startInfo;
                process.Start();
                string output = process.StandardOutput.ReadToEnd();
                process.WaitForExit();

                return output;
            }
        }


        private void RunPythonScript()
        {
            //string pythonPath = "C:\\Users\\ogzhn\\AppData\\Local\\Programs\\Python\\Python311\\";
            //string scriptPath = "\"C:\\Users\\ogzhn\\Desktop\\saldiri-tespit-sistemi-main\\SaldırıTespitSistemi\\Model1_LR.py\"";

            //ProcessStartInfo startInfo = new ProcessStartInfo();
            //startInfo.FileName = pythonPath;
            //startInfo.Arguments = scriptPath;
            //startInfo.RedirectStandardOutput = true;
            //startInfo.UseShellExecute = false;
            //startInfo.CreateNoWindow = true;

            //using (Process process = Process.Start(startInfo))
            //{
            //    using (StreamReader reader = process.StandardOutput)
            //    {
            //        string result = reader.ReadToEnd();
            //        richTextBox1.Text = result;
            //    }
            //}
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
