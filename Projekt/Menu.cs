using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void klawiszStart_Klik(object sender, EventArgs e)
        {
            start.Enabled = false;
            start.Visible = false;
            latwe.Enabled = true;
            latwe.Visible = true;
            trudne.Enabled = true;
            trudne.Visible = true;
        }
        private void klawiszAutorzy_Klik(object sender, EventArgs e)
        {
            autorzy.Enabled = false;
            autorzy.Visible = false;
            pictureBox2.Visible = true;
        }

        private void klawiszZakończ_Klik(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void klawiszLatwe_Klik(object sender, EventArgs e)
        {
            this.Visible = false;
            Form1 Frml = new Form1();
            Frml.ShowDialog();
            this.Close();
        }
        private void klawiszTrudne_Klik(object sender, EventArgs e)
        {
            this.Visible = false;
            Form2 Frmt = new Form2();
            Frmt.ShowDialog();
            this.Close();
        }

        private void pictureBox2_DoubleClick(object sender, EventArgs e)
        {
            sekret Frmsadat = new sekret();
            Frmsadat.ShowDialog();
        }
    }
}
