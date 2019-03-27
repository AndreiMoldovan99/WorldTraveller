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
    public partial class Asia : Form
    {
        public Asia()
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

        private void europaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Europa eur = new Europa();
            eur.ShowDialog();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DetaliiMumbai dmum = new DetaliiMumbai();
            dmum.ShowDialog();
        }

        private void Asia_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DetaiiTokyo dtok = new DetaiiTokyo();
            dtok.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DetaliiSeul dseu = new DetaliiSeul();
            dseu.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DetaliiJakartah djak = new DetaliiJakartah();
            djak.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DetaliiDelhi ddel = new DetaliiDelhi ();
            ddel.ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            DetaliiManila dman = new DetaliiManila();
            dman.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            DetaliiShanghai dsha = new DetaliiShanghai();
            dsha.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            DetaliiCalcutta dcal = new DetaliiCalcutta();
            dcal.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            DetaliiBeijing dbei = new DetaliiBeijing();
            dbei.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DetaliiHongkong dhon = new DetaliiHongkong();
            dhon.ShowDialog();
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
