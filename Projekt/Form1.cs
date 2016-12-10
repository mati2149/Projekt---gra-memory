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
    public partial class Form1 : Form
    {
        List<string> znaki = new List<string>()
        {
            "a", "a", "b", "b", "c", "c", "d", "d",
            "e", "e", "f", "f", "g", "g", "h", "h"
        };

        Random losowo = new Random();

        private void DobierzZanaki()
        {
            foreach (Control e in tableLayoutPanel1.Controls)
            {
                Label TabelaZnakow = e as Label;
                if (TabelaZnakow != null)
                {
                    int x = losowo.Next(znaki.Count);
                    TabelaZnakow.Text = znaki[x];
                    TabelaZnakow.ForeColor = TabelaZnakow.BackColor;
                    znaki.RemoveAt(x);
                }
            }
        }
        Label PierwszeKlikniecie = null;
        Label DrugieKlikniecie = null;

        private void KliknijTabele(object y, EventArgs e)
        {

            if (pozwolenie.Enabled == true)
                return;

            Label kliknietatab = y as Label;

            if (kliknietatab != null)
            {
                if (kliknietatab.ForeColor == Color.Black)
                    return;


                if (PierwszeKlikniecie == null)
                {
                    PierwszeKlikniecie = kliknietatab;
                    PierwszeKlikniecie.ForeColor = Color.Black;
                    return;
                }

                DrugieKlikniecie = kliknietatab;
                DrugieKlikniecie.ForeColor = Color.Black;

                CzyJestesZwyciezca();

                if (PierwszeKlikniecie.Text == DrugieKlikniecie.Text)
                {
                    PierwszeKlikniecie = null;
                    DrugieKlikniecie = null;
                    return;
                }
                
                pozwolenie.Start();
            }

        }
        private void OdstepCzasu(object y, EventArgs e)
        {
            pozwolenie.Stop();

            PierwszeKlikniecie.ForeColor = PierwszeKlikniecie.BackColor;
            DrugieKlikniecie.ForeColor = DrugieKlikniecie.BackColor;

            PierwszeKlikniecie = null;
            DrugieKlikniecie = null;

        }

        private void CzyJestesZwyciezca()
        {
            foreach (Control e in tableLayoutPanel1.Controls)
            {
                Label TabelaZnakow = e as Label;

                if (TabelaZnakow != null)
                {
                    if (TabelaZnakow.ForeColor == TabelaZnakow.BackColor)
                        return;
                }
            }
            MessageBox.Show("Udało ci sie prawidłowo odkryć wszystkie obrazki!\nJesteś zwycięzcą!");
            this.Visible = false;
            Menu ddd = new Menu();
            ddd.ShowDialog();
            this.Close();
        }



        public Form1()
        {
            InitializeComponent();
            DobierzZanaki();
        }

    }
}
