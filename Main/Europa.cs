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
    public partial class Europa : Form
    {
        public Europa()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

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
            this.Hide();
            Australia aus = new Australia();
            aus.ShowDialog();
            this.Close();
        }

        private void americaDeNordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            America_De_Nord adn = new America_De_Nord();
            adn.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DetaliiLondra dlon = new DetaliiLondra();
            dlon.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DetaliiBerlin dber = new DetaliiBerlin();
            dber.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DetaliiMadrid dmad = new DetaliiMadrid();
            dmad.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DetaliiAtena date = new DetaliiAtena();
            date.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DetaliiRoma drom = new DetaliiRoma();
            drom.ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            DetaliiParis dpar = new DetaliiParis();
            dpar.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            DetaliiBucuresti dbuc = new DetaliiBucuresti();
            dbuc.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            DetaliiLisabona dlis = new DetaliiLisabona();
            dlis.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            DetaliiCopenhaga dcop = new DetaliiCopenhaga();
            dcop.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DetaliiMilano dmil = new DetaliiMilano();
            dmil.ShowDialog();
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

        private void Europa_Load(object sender, EventArgs e)
        {

        }
    }
}
