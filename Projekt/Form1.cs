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

        private void DobierzZanaki()
        {
            foreach (Control e in tableLayoutPanel1.Controls)
            {
                Label TabelaZnakow = e as Label;
                if (TabelaZnakow != null)
                {
                    int x = 0;
                    TabelaZnakow.Text = znaki[x];
                    znaki.RemoveAt(x);
                }
            }
        }

        private void KliknijTabele()
        {

            bool pozwolenie = true;

            if (pozwolenie == true)
                return;

            

            if (pozwolenie != false)
            {
                


            }

        }




        public Form1()
        {
            InitializeComponent();
            DobierzZanaki();
        }

    }
}
