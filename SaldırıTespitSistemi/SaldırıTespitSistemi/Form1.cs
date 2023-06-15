using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaldırıTespitSistemi
{
    public partial class Form1 : Form
    {

        public string SelectedItem { get; private set; }


        private void OpenForm2()
        {
            Form2 form2 = new Form2(this);
            form2.Show();
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void btnModelEgit_Click(object sender, EventArgs e)
        {
            if (cbAlgoritma.SelectedIndex >= 0 && cbVeriSeti.SelectedIndex >= 0)
            {              
                    this.Hide();
                    Form2 frm = new Form2(this);
                    frm.ShowDialog();
                

            }
            else
            {
                MessageBox.Show("Seçim yapılmadı");
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbAlgoritma_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedItem = cbAlgoritma.SelectedIndex.ToString();
        }

        private void cbVeriSeti_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbAlgoritma.Items.Add("Lojistik Regresyon");
            cbAlgoritma.Items.Add("K En Yakın Komşu Algoritması");
            cbAlgoritma.Items.Add("LightGBM");
            cbAlgoritma.Items.Add("GBM");

            cbVeriSeti.Items.Add("UNSW-NB15");
        }

        private void labelControl1_Click(object sender, EventArgs e)
        {

        }
    }
}
