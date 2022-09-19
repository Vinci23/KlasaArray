using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace AutomobiliV
{
    public partial class Form1 : Form
    {
        ArrayList listaAutomobila = new ArrayList();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnNovi_Click(object sender, EventArgs e)

        {
            btnUnesi.Enabled = true;
            txtNovi.Enabled = true;
        }

        private void btnUnesi_Click(object sender, EventArgs e)
        {
            Automobil a = new Automobil(txtNovi.Text);
            listaAutomobila.Add(a);
            rtbispis.AppendText(listaAutomobila.IndexOf(a)
                + 1 + ". " + a.DajMarku() + "\n");
            txtNovi.Enabled = false;
            btnUnesi.Enabled = false;
            txtNovi.Clear();
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            rtbispis.Clear();
        }
    }
}
