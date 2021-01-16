
namespace gestion_clients
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.id = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.lastname = new System.Windows.Forms.TextBox();
            this.adresse = new System.Windows.Forms.TextBox();
            this.ville = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.villesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gestion_cltDataSet = new gestion_clients.gestion_cltDataSet();
            this.villesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.villesTableAdapter = new gestion_clients.gestion_cltDataSetTableAdapters.villesTableAdapter();
            this.btn_trie = new System.Windows.Forms.Button();
            this.cbville = new System.Windows.Forms.ComboBox();
            this.txt_chercher = new System.Windows.Forms.TextBox();
            this.btn_all = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.villesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestion_cltDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.villesBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // id
            // 
            this.id.Location = new System.Drawing.Point(106, 66);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(154, 26);
            this.id.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(106, 115);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(154, 26);
            this.name.TabIndex = 3;
            this.name.TextChanged += new System.EventHandler(this.name_TextChanged);
            // 
            // lastname
            // 
            this.lastname.Location = new System.Drawing.Point(106, 169);
            this.lastname.Name = "lastname";
            this.lastname.Size = new System.Drawing.Size(154, 26);
            this.lastname.TabIndex = 4;
            // 
            // adresse
            // 
            this.adresse.Location = new System.Drawing.Point(106, 229);
            this.adresse.Name = "adresse";
            this.adresse.Size = new System.Drawing.Size(154, 26);
            this.adresse.TabIndex = 5;
            // 
            // ville
            // 
            this.ville.Location = new System.Drawing.Point(106, 289);
            this.ville.Name = "ville";
            this.ville.Size = new System.Drawing.Size(154, 26);
            this.ville.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Location = new System.Drawing.Point(554, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(422, 189);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(32, 115);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(373, 39);
            this.button5.TabIndex = 16;
            this.button5.Text = "Mise à jour";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(32, 31);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 46);
            this.button1.TabIndex = 12;
            this.button1.Text = "Ajouter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(166, 31);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 46);
            this.button2.TabIndex = 13;
            this.button2.Text = "Modifier";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(295, 30);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(110, 46);
            this.button3.TabIndex = 14;
            this.button3.Text = "Supprimer";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(295, 267);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(681, 224);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "name :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Last name :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 232);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "adresse :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 292);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 20);
            this.label5.TabIndex = 16;
            this.label5.Text = "ville :";
            // 
            // villesBindingSource
            // 
            this.villesBindingSource.DataMember = "villes";
            this.villesBindingSource.DataSource = this.gestion_cltDataSet;
            // 
            // gestion_cltDataSet
            // 
            this.gestion_cltDataSet.DataSetName = "gestion_cltDataSet";
            this.gestion_cltDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // villesBindingSource1
            // 
            this.villesBindingSource1.DataMember = "villes";
            this.villesBindingSource1.DataSource = this.gestion_cltDataSet;
            // 
            // villesTableAdapter
            // 
            this.villesTableAdapter.ClearBeforeFill = true;
            // 
            // btn_trie
            // 
            this.btn_trie.Location = new System.Drawing.Point(295, 155);
            this.btn_trie.Name = "btn_trie";
            this.btn_trie.Size = new System.Drawing.Size(81, 38);
            this.btn_trie.TabIndex = 19;
            this.btn_trie.Text = "chercher";
            this.btn_trie.UseVisualStyleBackColor = true;
            this.btn_trie.Click += new System.EventHandler(this.btn_trie_Click);
            // 
            // cbville
            // 
            this.cbville.DropDownWidth = 300;
            this.cbville.FormattingEnabled = true;
            this.cbville.Items.AddRange(new object[] {
            "casablanca",
            "rabat",
            "settat",
            "youssoufia",
            "safi",
            "marrakech",
            "meknes",
            "fes",
            "tanger"});
            this.cbville.Location = new System.Drawing.Point(295, 110);
            this.cbville.Name = "cbville";
            this.cbville.Size = new System.Drawing.Size(241, 28);
            this.cbville.TabIndex = 20;
            this.cbville.Text = "                 filtrer par ville";
            this.cbville.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txt_chercher
            // 
            this.txt_chercher.Location = new System.Drawing.Point(295, 66);
            this.txt_chercher.Name = "txt_chercher";
            this.txt_chercher.Size = new System.Drawing.Size(241, 26);
            this.txt_chercher.TabIndex = 21;
            // 
            // btn_all
            // 
            this.btn_all.Location = new System.Drawing.Point(455, 157);
            this.btn_all.Name = "btn_all";
            this.btn_all.Size = new System.Drawing.Size(81, 38);
            this.btn_all.TabIndex = 22;
            this.btn_all.Text = "All";
            this.btn_all.UseVisualStyleBackColor = true;
            this.btn_all.Click += new System.EventHandler(this.btn_all_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1014, 523);
            this.Controls.Add(this.btn_all);
            this.Controls.Add(this.txt_chercher);
            this.Controls.Add(this.cbville);
            this.Controls.Add(this.btn_trie);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ville);
            this.Controls.Add(this.adresse);
            this.Controls.Add(this.lastname);
            this.Controls.Add(this.name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.id);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Form1";
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.SystemColors.ActiveCaptionText;
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.villesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestion_cltDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.villesBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox lastname;
        private System.Windows.Forms.TextBox adresse;
        private System.Windows.Forms.TextBox ville;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private gestion_cltDataSet gestion_cltDataSet;
        private System.Windows.Forms.BindingSource villesBindingSource;
        private gestion_cltDataSetTableAdapters.villesTableAdapter villesTableAdapter;
        private System.Windows.Forms.BindingSource villesBindingSource1;
        private System.Windows.Forms.Button btn_trie;
        private System.Windows.Forms.ComboBox cbville;
        private System.Windows.Forms.TextBox txt_chercher;
        private System.Windows.Forms.Button btn_all;
    }
}

