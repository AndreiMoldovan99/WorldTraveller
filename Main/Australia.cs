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
    public partial class Australia : Form
    {
        public Australia()
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

        private void australiaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void americaDeNordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            America_De_Nord adn = new America_De_Nord();
            adn.ShowDialog();
            this.Close();
        }

        private void europaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Europa eur = new Europa();
            eur.ShowDialog();
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            DetaliiMelbourne dmel = new DetaliiMelbourne();
            dmel.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            DetaliiGoldcoast dgol = new DetaliiGoldcoast();
            dgol.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DetaliiSydney dsyd = new DetaliiSydney();
            dsyd.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DetaliiAdelaide dade = new DetaliiAdelaide();
            dade.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DetaliiBrisbane dbri = new DetaliiBrisbane();
            dbri.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DetaliiHobart dhob = new DetaliiHobart();
            dhob.ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            DetaliiPerth dper = new DetaliiPerth();
            dper.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            DetaliiEsperance desp = new DetaliiEsperance();
            desp.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            DetaliiNewcastle dnew = new DetaliiNewcastle();
            dnew.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DetaliiSaintGeorge dsai = new DetaliiSaintGeorge();
            dsai.ShowDialog();
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
