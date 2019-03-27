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
    public partial class America_De_Nord : Form
    {
        public America_De_Nord()
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

        private void oraseDinAfricaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            America_De_Sud ads = new America_De_Sud();
            ads.ShowDialog();
            this.Close();
        }

        private void asiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Africa af = new Africa();
            af.ShowDialog();
            this.Close();
        }

        private void asiaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Asia asi = new Asia();
            asi.ShowDialog();
            this.Close();
        }

        private void australiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Australia aus = new Australia();
            aus.ShowDialog();
            this.Close();
        }

        private void oraseEuropeneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Europa eur = new Europa();
            eur.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DetaliiNewyork dnew = new DetaliiNewyork();
            dnew.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DetaliiLosangeles dlos = new DetaliiLosangeles();
            dlos.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DetaliiChicago dchi = new DetaliiChicago();
            dchi.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DetaliiPhoenix dpho = new DetaliiPhoenix();
            dpho.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DetaliiSandiego dsan = new DetaliiSandiego();
            dsan.ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            DetaliiSanfrancisco dfra = new DetaliiSanfrancisco();
            dfra.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            DetaliiWashington dwas = new DetaliiWashington();
            dwas.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            DetaliiLasvegas dveg = new DetaliiLasvegas ();
            dveg.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            DetaliiBoston dbos = new DetaliiBoston();
            dbos.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DetaliiMiami dmia = new DetaliiMiami();
            dmia.ShowDialog();
        }

        private void galerieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            OraseVizitate ov = new OraseVizitate();
            ov.ShowDialog();
            this.Close();
        }

        private void contactToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            DorinteDeVizitare dv = new DorinteDeVizitare();
            dv.ShowDialog();
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
