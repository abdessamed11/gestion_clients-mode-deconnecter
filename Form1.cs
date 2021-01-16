using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace gestion_clients
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection cnx = new SqlConnection(@"data source=DESKTOP-QUDI77S\MSSQLSERVER01;initial catalog=gestion_clt;integrated security=true");
        DataSet DS = new DataSet();      
        SqlDataAdapter DA;
        //DataView dv;
        SqlDataAdapter vl;


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        DataTable dtclient;

        //chargement les donnes database dans le datagridview
        
        private void Form1_Load_1(object sender, EventArgs e)
        {
            
            try
            {
                DA = new SqlDataAdapter("Select * from clients", cnx);
               // vl = new SqlDataAdapter("Select villes from villes", cnx);
                DA.Fill(DS, "clients");
                dtclient = DS.Tables["clients"];
                //vl.Fill(DS, "villes");
                dataGridView1.DataSource = DS.Tables["clients"];
                //combo_villes.DataSource = DS.Tables["villes"];
                //dv = new DataView(dtclient);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        //modifier les info des tableau
        private void button1_Click(object sender, EventArgs e)
        {
            DataRow r = dtclient.NewRow();
            r[0] = id.Text;
            r[1] = name.Text;
            r[2] = lastname.Text;
            r[3] = adresse.Text;
            r[4] = ville.Text;
            dtclient.Rows.Add(r);
            
        }

        private void name_TextChanged(object sender, EventArgs e)
        {

        }
        //modifier la ligne selectonner dans le datagridview
        private void button2_Click(object sender, EventArgs e)
        {
            int a = getIndice();
            dtclient.Rows[a][0] = id.Text;
            dtclient.Rows[a][1] = name.Text;
            dtclient.Rows[a][2] = lastname.Text;
            dtclient.Rows[a][3] = adresse.Text;
            dtclient.Rows[a][4] = ville.Text;
        }
        //recuperer les données selectionner dans le tableau et afficher dans le formulaire 
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                id.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                name.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                lastname.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                adresse.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                ville.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();

                
            }
            catch (Exception)
            {

            }
        }


        //creer une fonction qui recupere la valeaur indice pour utiliser suprimer la ligne selectionner
        int getIndice()
        {
            int indice = 0;
           
            try
            {

                for (int i = 0; i < dtclient.Rows.Count; i++)
                {
                    if (Convert.ToInt32(dtclient.Rows[i][0]) == Convert.ToInt32(id.Text))
                    {
                        indice = i;
                    }
                }

            }
            catch (Exception)
            {
                
            }
            return indice;
        }


        //suprimer la ligne selectionner
        private void button3_Click(object sender, EventArgs e)
        {
            int b = getIndice();
            dtclient = DS.Tables["clients"];
            dtclient.Rows[b].Delete();
        }
        //enregistrer la modification vers database
        private void button5_Click(object sender, EventArgs e)
        {
            SqlCommandBuilder scb = new SqlCommandBuilder(DA);
            DA.Update(DS, "clients");
            MessageBox.Show("mise à jour effectué avec succés");
        }
        //deux button une pour chercher par le nom et autre pour trier le tableau par la ville
        private void btn_trie_Click(object sender, EventArgs e)
        {
            if (txt_chercher.Text.Length == 0)
            {
                DA = new SqlDataAdapter("Select * from clients where ville ='" + cbville.Text + "'", cnx);
                DS.Tables["clients"].Clear();
                DA.Fill(DS, "clients");
                dataGridView1.DataSource = DS.Tables["clients"];
            }else if(txt_chercher.Text.Length != 0)
            {
                
                DA = new SqlDataAdapter("SELECT * FROM clients WHERE nom = '"+txt_chercher.Text+"'", cnx);
                DS.Tables["clients"].Clear();
                DA.Fill(DS, "clients");
                dataGridView1.DataSource = DS.Tables["clients"];
            }
            
            
        }

        private void combo_villes_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            

        }

        private void btn_vider_Click(object sender, EventArgs e)
        {
            //dataGridView1.Rows.Clear();
        }

        private void btn_all_Click(object sender, EventArgs e)
        {
            DA = new SqlDataAdapter("Select * from clients", cnx);
            vl = new SqlDataAdapter("Select villes from villes", cnx);
            DA.Fill(DS, "clients");
            dtclient = DS.Tables["clients"];
            vl.Fill(DS, "villes");
            dataGridView1.DataSource = DS.Tables["clients"];
            //combo_villes.DataSource = DS.Tables["villes"];
            //dv = new DataView(dtclient);
        }
    }
}
