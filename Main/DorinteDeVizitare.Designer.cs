namespace Main
{
    partial class DorinteDeVizitare
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label denumire_OrasLabel;
            System.Windows.Forms.Label tara_OrasLabel;
            System.Windows.Forms.Label nota_OrasLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DorinteDeVizitare));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.primaPaginaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oraseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.europaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.americaDeNordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.americaDeSudToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aFRICAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.australiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.galerieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contactToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logInToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oraseDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oraseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dorinteOraseDataSet = new Main.DorinteOraseDataSet();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.denumire_OrasTextBox = new System.Windows.Forms.TextBox();
            this.tara_OrasTextBox = new System.Windows.Forms.TextBox();
            this.nota_OrasTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.oraseTableAdapter = new Main.DorinteOraseDataSetTableAdapters.OraseTableAdapter();
            this.tableAdapterManager = new Main.DorinteOraseDataSetTableAdapters.TableAdapterManager();
            idLabel = new System.Windows.Forms.Label();
            denumire_OrasLabel = new System.Windows.Forms.Label();
            tara_OrasLabel = new System.Windows.Forms.Label();
            nota_OrasLabel = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.oraseDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oraseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dorinteOraseDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            idLabel.Location = new System.Drawing.Point(688, 208);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(23, 17);
            idLabel.TabIndex = 7;
            idLabel.Text = "Id:";
            // 
            // denumire_OrasLabel
            // 
            denumire_OrasLabel.AutoSize = true;
            denumire_OrasLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            denumire_OrasLabel.Location = new System.Drawing.Point(688, 249);
            denumire_OrasLabel.Name = "denumire_OrasLabel";
            denumire_OrasLabel.Size = new System.Drawing.Size(108, 17);
            denumire_OrasLabel.TabIndex = 9;
            denumire_OrasLabel.Text = "Denumire Oras:";
            // 
            // tara_OrasLabel
            // 
            tara_OrasLabel.AutoSize = true;
            tara_OrasLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            tara_OrasLabel.Location = new System.Drawing.Point(688, 289);
            tara_OrasLabel.Name = "tara_OrasLabel";
            tara_OrasLabel.Size = new System.Drawing.Size(77, 17);
            tara_OrasLabel.TabIndex = 11;
            tara_OrasLabel.Text = "Tara Oras:";
            // 
            // nota_OrasLabel
            // 
            nota_OrasLabel.AutoSize = true;
            nota_OrasLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            nota_OrasLabel.Location = new System.Drawing.Point(688, 333);
            nota_OrasLabel.Name = "nota_OrasLabel";
            nota_OrasLabel.Size = new System.Drawing.Size(77, 17);
            nota_OrasLabel.TabIndex = 13;
            nota_OrasLabel.Text = "Nota Oras:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.menuStrip1.Font = new System.Drawing.Font("Sitka Small", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.primaPaginaToolStripMenuItem,
            this.oraseToolStripMenuItem,
            this.galerieToolStripMenuItem,
            this.contactToolStripMenuItem,
            this.logInToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1139, 43);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // primaPaginaToolStripMenuItem
            // 
            this.primaPaginaToolStripMenuItem.Name = "primaPaginaToolStripMenuItem";
            this.primaPaginaToolStripMenuItem.Size = new System.Drawing.Size(195, 39);
            this.primaPaginaToolStripMenuItem.Text = "Prima pagina";
            this.primaPaginaToolStripMenuItem.Click += new System.EventHandler(this.primaPaginaToolStripMenuItem_Click);
            // 
            // oraseToolStripMenuItem
            // 
            this.oraseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.europaToolStripMenuItem,
            this.americaDeNordToolStripMenuItem,
            this.americaDeSudToolStripMenuItem,
            this.aFRICAToolStripMenuItem,
            this.asiaToolStripMenuItem,
            this.australiaToolStripMenuItem});
            this.oraseToolStripMenuItem.Name = "oraseToolStripMenuItem";
            this.oraseToolStripMenuItem.Size = new System.Drawing.Size(152, 39);
            this.oraseToolStripMenuItem.Text = "Destinatii";
            // 
            // europaToolStripMenuItem
            // 
            this.europaToolStripMenuItem.Name = "europaToolStripMenuItem";
            this.europaToolStripMenuItem.Size = new System.Drawing.Size(304, 40);
            this.europaToolStripMenuItem.Text = "Europa";
            this.europaToolStripMenuItem.Click += new System.EventHandler(this.europaToolStripMenuItem_Click);
            // 
            // americaDeNordToolStripMenuItem
            // 
            this.americaDeNordToolStripMenuItem.Name = "americaDeNordToolStripMenuItem";
            this.americaDeNordToolStripMenuItem.Size = new System.Drawing.Size(304, 40);
            this.americaDeNordToolStripMenuItem.Text = "America de Nord";
            this.americaDeNordToolStripMenuItem.Click += new System.EventHandler(this.americaDeNordToolStripMenuItem_Click);
            // 
            // americaDeSudToolStripMenuItem
            // 
            this.americaDeSudToolStripMenuItem.Name = "americaDeSudToolStripMenuItem";
            this.americaDeSudToolStripMenuItem.Size = new System.Drawing.Size(304, 40);
            this.americaDeSudToolStripMenuItem.Text = "America de Sud";
            this.americaDeSudToolStripMenuItem.Click += new System.EventHandler(this.americaDeSudToolStripMenuItem_Click);
            // 
            // aFRICAToolStripMenuItem
            // 
            this.aFRICAToolStripMenuItem.Name = "aFRICAToolStripMenuItem";
            this.aFRICAToolStripMenuItem.Size = new System.Drawing.Size(304, 40);
            this.aFRICAToolStripMenuItem.Text = "Africa";
            this.aFRICAToolStripMenuItem.Click += new System.EventHandler(this.aFRICAToolStripMenuItem_Click);
            // 
            // asiaToolStripMenuItem
            // 
            this.asiaToolStripMenuItem.Name = "asiaToolStripMenuItem";
            this.asiaToolStripMenuItem.Size = new System.Drawing.Size(304, 40);
            this.asiaToolStripMenuItem.Text = "Asia";
            this.asiaToolStripMenuItem.Click += new System.EventHandler(this.asiaToolStripMenuItem_Click);
            // 
            // australiaToolStripMenuItem
            // 
            this.australiaToolStripMenuItem.Name = "australiaToolStripMenuItem";
            this.australiaToolStripMenuItem.Size = new System.Drawing.Size(304, 40);
            this.australiaToolStripMenuItem.Text = "Australia";
            this.australiaToolStripMenuItem.Click += new System.EventHandler(this.australiaToolStripMenuItem_Click);
            // 
            // galerieToolStripMenuItem
            // 
            this.galerieToolStripMenuItem.Name = "galerieToolStripMenuItem";
            this.galerieToolStripMenuItem.Size = new System.Drawing.Size(330, 39);
            this.galerieToolStripMenuItem.Text = "Orase ce trebuie vizitate";
            this.galerieToolStripMenuItem.Click += new System.EventHandler(this.galerieToolStripMenuItem_Click);
            // 
            // contactToolStripMenuItem
            // 
            this.contactToolStripMenuItem.Name = "contactToolStripMenuItem";
            this.contactToolStripMenuItem.Size = new System.Drawing.Size(262, 39);
            this.contactToolStripMenuItem.Text = "Dorinte de vizitare";
            // 
            // logInToolStripMenuItem
            // 
            this.logInToolStripMenuItem.Name = "logInToolStripMenuItem";
            this.logInToolStripMenuItem.Size = new System.Drawing.Size(91, 39);
            this.logInToolStripMenuItem.Text = "Lista";
            this.logInToolStripMenuItem.Click += new System.EventHandler(this.logInToolStripMenuItem_Click);
            // 
            // oraseDataGridView
            // 
            this.oraseDataGridView.AutoGenerateColumns = false;
            this.oraseDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.oraseDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.oraseDataGridView.DataSource = this.oraseBindingSource;
            this.oraseDataGridView.Location = new System.Drawing.Point(35, 56);
            this.oraseDataGridView.Name = "oraseDataGridView";
            this.oraseDataGridView.RowTemplate.Height = 24;
            this.oraseDataGridView.Size = new System.Drawing.Size(604, 622);
            this.oraseDataGridView.TabIndex = 7;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Denumire_Oras";
            this.dataGridViewTextBoxColumn2.HeaderText = "Denumire_Oras";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Tara_Oras";
            this.dataGridViewTextBoxColumn3.HeaderText = "Tara_Oras";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Nota_Oras";
            this.dataGridViewTextBoxColumn4.HeaderText = "Nota_Oras";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // oraseBindingSource
            // 
            this.oraseBindingSource.DataMember = "Orase";
            this.oraseBindingSource.DataSource = this.dorinteOraseDataSet;
            // 
            // dorinteOraseDataSet
            // 
            this.dorinteOraseDataSet.DataSetName = "DorinteOraseDataSet";
            this.dorinteOraseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.oraseBindingSource, "Id", true));
            this.idTextBox.Location = new System.Drawing.Point(802, 205);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(100, 22);
            this.idTextBox.TabIndex = 8;
            // 
            // denumire_OrasTextBox
            // 
            this.denumire_OrasTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.oraseBindingSource, "Denumire_Oras", true));
            this.denumire_OrasTextBox.Location = new System.Drawing.Point(802, 246);
            this.denumire_OrasTextBox.Name = "denumire_OrasTextBox";
            this.denumire_OrasTextBox.Size = new System.Drawing.Size(242, 22);
            this.denumire_OrasTextBox.TabIndex = 10;
            // 
            // tara_OrasTextBox
            // 
            this.tara_OrasTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.oraseBindingSource, "Tara_Oras", true));
            this.tara_OrasTextBox.Location = new System.Drawing.Point(802, 286);
            this.tara_OrasTextBox.Name = "tara_OrasTextBox";
            this.tara_OrasTextBox.Size = new System.Drawing.Size(242, 22);
            this.tara_OrasTextBox.TabIndex = 12;
            // 
            // nota_OrasTextBox
            // 
            this.nota_OrasTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.oraseBindingSource, "Nota_Oras", true));
            this.nota_OrasTextBox.Location = new System.Drawing.Point(802, 330);
            this.nota_OrasTextBox.Name = "nota_OrasTextBox";
            this.nota_OrasTextBox.Size = new System.Drawing.Size(100, 22);
            this.nota_OrasTextBox.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button1.Location = new System.Drawing.Point(930, 330);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(177, 34);
            this.button1.TabIndex = 15;
            this.button1.Text = "Adauga oras";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label1.Location = new System.Drawing.Point(675, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 17);
            this.label1.TabIndex = 16;
            this.label1.Text = "Adauga oras la lista de dorinte:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label2.Location = new System.Drawing.Point(672, 548);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 17);
            this.label2.TabIndex = 17;
            this.label2.Text = "Sterge oras cu ID-ul:";
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(816, 548);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(100, 22);
            this.textBoxId.TabIndex = 18;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button2.Location = new System.Drawing.Point(930, 548);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(184, 34);
            this.button2.TabIndex = 19;
            this.button2.Text = "Sterge";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label3.Location = new System.Drawing.Point(661, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(317, 34);
            this.label3.TabIndex = 20;
            this.label3.Text = "Vrei sa adaugi orasele tale preferate intr-o lista? \r\nPerfect, Simte-te liber sa " +
    "faci asta!";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label4.Location = new System.Drawing.Point(661, 477);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(254, 34);
            this.label4.TabIndex = 21;
            this.label4.Text = "Te-ai razgandit in legatura cu un oras?\r\ne ok, poti sa-l stergi din lista ta!\r\n";
            // 
            // oraseTableAdapter
            // 
            this.oraseTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.OraseTableAdapter = this.oraseTableAdapter;
            this.tableAdapterManager.UpdateOrder = Main.DorinteOraseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // DorinteDeVizitare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BackgroundImage = global::Main.Properties.Resources.background1;
            this.ClientSize = new System.Drawing.Size(1139, 710);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(denumire_OrasLabel);
            this.Controls.Add(this.denumire_OrasTextBox);
            this.Controls.Add(tara_OrasLabel);
            this.Controls.Add(this.tara_OrasTextBox);
            this.Controls.Add(nota_OrasLabel);
            this.Controls.Add(this.nota_OrasTextBox);
            this.Controls.Add(this.oraseDataGridView);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1157, 757);
            this.MinimumSize = new System.Drawing.Size(1157, 757);
            this.Name = "DorinteDeVizitare";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "World Traveler";
            this.Load += new System.EventHandler(this.DorinteDeVizitare_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.oraseDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oraseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dorinteOraseDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem primaPaginaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oraseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem galerieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contactToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logInToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem europaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem americaDeNordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem americaDeSudToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aFRICAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asiaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem australiaToolStripMenuItem;
        private DorinteOraseDataSet dorinteOraseDataSet;
        private System.Windows.Forms.BindingSource oraseBindingSource;
        private DorinteOraseDataSetTableAdapters.OraseTableAdapter oraseTableAdapter;
        private DorinteOraseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView oraseDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox denumire_OrasTextBox;
        private System.Windows.Forms.TextBox tara_OrasTextBox;
        private System.Windows.Forms.TextBox nota_OrasTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}