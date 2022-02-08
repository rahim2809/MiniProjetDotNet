using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;


namespace MiniProjetDotNet1
{
    public partial class Form4 : Form
    {
        static String connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\rahim\Documents\ProjetDotNet\Gest_Notes.accdb";
        OleDbConnection conn = new OleDbConnection(connectionString);


        private void actualiser()
        {
            conn.Open();
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT [Etudiant.Num_Etu], [Etudiant.Nom_Etu], [Etudiant.Prenom_Etu], [Notes.Note] FROM [Module] INNER JOIN ([Etudiant] INNER JOIN [Notes] ON [Etudiant].[Num_Etu] = [Notes].[Num_Etu]) ON [Module].[Num_Mod] = [Notes].[Num_Mod] where [Module].[Nom_Mod] = @nom";
            cmd.Parameters.AddWithValue("@nom", comboBox1.Text);
            OleDbDataReader dre = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dre);
            dataGridView1.DataSource = dt;
            dre.Close();
            conn.Close();
        }

        private void actualiser1()
        {
            conn.Open();
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT AVG([Notes.Note]) FROM [Module] INNER JOIN ([Etudiant] INNER JOIN [Notes] ON [Etudiant].[Num_Etu] = [Notes].[Num_Etu]) ON [Module].[Num_Mod] = [Notes].[Num_Mod] where [Module].[Nom_Mod] = @nom";
            cmd.Parameters.AddWithValue("@nom", comboBox1.Text);
            OleDbDataReader drr = cmd.ExecuteReader();
            drr.Read();
            Moyenne_Class_textBox.Text = drr[0].ToString();
            drr.Close();
            conn.Close();         
        }

        public Form4()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            actualiser();
            actualiser1();
        }

       
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
