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
    public partial class America_De_Sud : Form
    {
        public America_De_Sud()
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

        private void africaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Africa af = new Africa();
            af.ShowDialog();
            this.Close();
        }

        private void australiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Asia asi = new Asia();
            asi.ShowDialog();
            this.Close();
        }

        private void australiaToolStripMenuItem1_Click(object sender, EventArgs e)
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

        private void europaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Europa eur = new Europa();
            eur.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DetaliiBuenosaires dbue = new DetaliiBuenosaires();
            dbue.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DetaliiBrasilia dbra = new DetaliiBrasilia();
            dbra.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DetaliiSantiagodechile dsan = new DetaliiSantiagodechile();
            dsan.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DetaliiBogota dbog = new DetaliiBogota();
            dbog.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DetaliiLapaz dlap = new DetaliiLapaz();
            dlap.ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            DetaliiQuito dqui = new DetaliiQuito();
            dqui.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            DetaliiAsuncion dasu = new DetaliiAsuncion();
            dasu.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            DetaliiLima dlim = new DetaliiLima();
            dlim.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            DetaliiParamaribo dpar = new DetaliiParamaribo();
            dpar.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DetaliiCaracas dcar = new DetaliiCaracas();
            dcar.ShowDialog();
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

        private void America_De_Sud_Load(object sender, EventArgs e)
        {

        }
    }
}
