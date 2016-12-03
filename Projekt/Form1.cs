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
                Label TablelaZnakow = e as Label;
                if (TablelaZnakow != null)
                {
                    int liczba = 0;
                    TablelaZnakow.Text = znaki[liczba];
                    znaki.RemoveAt(liczba);
                }
            }
        }


        public Form1()
        {
            InitializeComponent();
            DobierzZanaki();
        }

    }
}
