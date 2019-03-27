using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main
{
    public partial class OraseVizitate : Form
    {
        public OraseVizitate()
        {
            InitializeComponent();
        }

        private void primaPaginaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.ShowDialog();
            this.Close();
        }

        private void europaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Europa eu = new Europa();
            eu.ShowDialog();
            this.Close();
        }

        private void americaDeNordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            America_De_Nord an = new America_De_Nord();
            an.ShowDialog();
            this.Close();
        }

        private void americaDeSudToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            America_De_Sud ads = new America_De_Sud();
            ads.ShowDialog();
            this.Close();
        }

        private void africaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Africa af = new Africa();
            af.ShowDialog();
            this.Close();
        }

        private void asiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Asia asi = new Asia();
            asi.ShowDialog();
            this.Close();
        }

        private void galerieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void australiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Australia au = new Australia();
            au.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listOrase.Items.Clear();
            foreach (string s in checkListOrase.CheckedItems)
                listOrase.Items.Add(s);

            string oras, tara;
            bool amTrecutLaTara = false;
            foreach (string s in listOrase.Items)
            {
                oras = tara = "";
                amTrecutLaTara = false;
                foreach (char c in s)
                {
                    if (c != ';')
                    {
                        if (c != ',')
                        {
                            if (char.IsLetter(c))
                            {
                                if (amTrecutLaTara == false)
                                    oras += new string(c, 1);
                                else
                                    tara += new string(c, 1);
                            }
                        }
                        else
                            amTrecutLaTara = true;
                    }
                }
            }
        }

        private void contactToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            DorinteDeVizitare ddv = new DorinteDeVizitare();
            ddv.ShowDialog();
            this.Close();
        }

        private void logInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Lista li = new Lista();
            li.ShowDialog();
            this.Close();
        }
    }
}
