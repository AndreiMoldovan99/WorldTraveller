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
    public partial class Africa : Form
    {
        public Africa()
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

        private void europaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Europa eur = new Europa();
            eur.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DetaliiCairo dcar = new DetaliiCairo();
            dcar.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DetaliiCapetown dcap = new DetaliiCapetown();
            dcap.ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            DetaliiTripoli dtri = new DetaliiTripoli();
            dtri.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DetaliiAlexandria dale = new DetaliiAlexandria();
            dale.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DetaliiCasablanca dcas = new DetaliiCasablanca();
            dcas.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DetaliiNairobi dnai = new DetaliiNairobi();
            dnai.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            DetaliiJohannensburg djoh = new DetaliiJohannensburg();
            djoh.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            DetaliiAlger dalg = new DetaliiAlger();
            dalg.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Detaliiluanda dlua = new Detaliiluanda();
            dlua.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DetalliDakar ddak = new DetalliDakar();
            ddak.ShowDialog();
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
