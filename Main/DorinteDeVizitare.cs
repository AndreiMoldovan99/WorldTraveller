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
    public partial class DorinteDeVizitare : Form
    {
        public DorinteDeVizitare()
        {
            InitializeComponent();
        }

        private void aFRICAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Africa af = new Africa();
            af.ShowDialog();
            this.Close();
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
            Australia au = new Australia();
            au.ShowDialog();
            this.Close();
        }

        private void galerieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            OraseVizitate ov = new OraseVizitate();
            ov.ShowDialog();
            this.Close();
        }

        private void DorinteDeVizitare_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dorinteOraseDataSet.Orase' table. You can move, or remove it, as needed.
            this.oraseTableAdapter.Fill(this.dorinteOraseDataSet.Orase);

        }

        private void oraseBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.oraseBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dorinteOraseDataSet);

        }

        private void logInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Lista li = new Lista();
            li.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(denumire_OrasTextBox.Text == "" ||
                tara_OrasTextBox.Text == "" ||
                nota_OrasTextBox.Text == "")
            {
                MessageBox.Show("Atentie! Nu ati introdus toate datele!");
                return;
            }
            int nota = 0;
            bool ok = int.TryParse(nota_OrasTextBox.Text, out nota);

            if(!ok)
            {
                MessageBox.Show("Atentie! Nota trebuie sa fie cifra!");
            }

            this.oraseTableAdapter.InsertQuery(denumire_OrasTextBox.Text,
                tara_OrasTextBox.Text,
                nota);
            this.oraseTableAdapter.Fill(this.dorinteOraseDataSet.Orase);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(textBoxId.Text == "")
            {
                MessageBox.Show("Atentie! Introduceti ID !");
                return;
            }
            int id_eliminat;
            bool okId = int.TryParse(textBoxId.Text, out id_eliminat);

            if (okId == false)
            {
                MessageBox.Show("Atentie! ID-ul trebuie sa fie numar!");
                return;
            }

            this.oraseTableAdapter.DeleteQuery(id_eliminat);
            this.oraseTableAdapter.Fill(this.dorinteOraseDataSet.Orase);
        }
    }
}
