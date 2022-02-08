using System;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data;


namespace MiniProjetDotNet1
{
    public partial class Form3 : Form
    {
        static String connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\rahim\Documents\ProjetDotNet\Gest_Notes.accdb";
        OleDbConnection conn = new OleDbConnection(connectionString);

        private bool rechercher_numero(string num_Etu, string nom_module)
        {
            bool p = false;
            conn.Open();
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT [Notes.Note] FROM [Module] INNER JOIN ([Etudiant] INNER JOIN [Notes] ON [Etudiant].[Num_Etu] = [Notes].[Num_Etu]) ON [Module].[Num_Mod] = [Notes].[Num_Mod] where [Etudiant].[Num_Etu] = @numero and [Module].[Nom_Mod] = @nom";
            cmd.Parameters.AddWithValue("@numero", num_Etu);
            cmd.Parameters.AddWithValue("@nom",nom_module);
            OleDbDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
                p = true;

            dr.Close();
            conn.Close();
            return p;
        }

        private string rechercher_num(string nom_module)
        {
            
            conn.Open();
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT [Module.Num_Mod] FROM [Module] WHERE [Module.Nom_Mod]=@nom";
            cmd.Parameters.AddWithValue("@nom", nom_module);
            
            OleDbDataReader drr = cmd.ExecuteReader();
            drr.Read();
            string num_module = drr[0].ToString(); ;
            drr.Close();
            conn.Close();
            return num_module;
        }

        private bool rechercher_num1(string num_etudiant)
        {
            bool p = false;
            conn.Open();
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT [Etudiant.Num_Etu] FROM [Etudiant] WHERE [Etudiant.Num_Etu]=@num";
            cmd.Parameters.AddWithValue("@num", num_etudiant);

            OleDbDataReader drr = cmd.ExecuteReader();
            if (!(drr.HasRows))
                p = true;

            drr.Close();
            conn.Close();
            return p;
        }

        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            
        }

        private void Nouveau_button_Click(object sender, EventArgs e)
        {
            Note_textBox.Text = "";
            Nom_Prenom_TextBox.Text = "";
            Module_comboBox.Text = "";
            Num_Inscription_comboBox.Text = "";
        }

        private void Enregistrer_Note_button_Click(object sender, EventArgs e)
        {
            if (Note_textBox.Text == "" || Nom_Prenom_TextBox.Text == "" || Module_comboBox.Text == "" || Num_Inscription_comboBox.Text == "") //controle de saisie
            {
                MessageBox.Show("Champs vides!!", "champs vides", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (rechercher_numero(Num_Inscription_comboBox.Text, Module_comboBox.Text) == true) // vérification de l'existence du client dont le CIN est saisi dans la zone CIN
            {

                MessageBox.Show("Etudiant possedant deja une note dans ce module. Veuillez cliquer sur MODIFIER si vous vous voulez changer sa Note", "note existe deja dans ce module", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Num_Inscription_comboBox.Focus();
                Num_Inscription_comboBox.SelectAll(); //selectionner le champ CIN pour une éventuelle resaisie
            }
            else
            {
                string num = rechercher_num(Module_comboBox.Text);
                conn.Open();
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = conn;
                
                cmd.CommandText ="INSERT INTO Notes ( [Num_Etu], [Num_Mod], [Note] ) VALUES (@numEtu,@numMod,@note)";
                cmd.Parameters.AddWithValue("@numEtu", Num_Inscription_comboBox.Text);
                cmd.Parameters.AddWithValue("@numMod", num);
                cmd.Parameters.AddWithValue("@note", Note_textBox.Text);
                
                OleDbParameter param_num = new OleDbParameter();
                param_num.ParameterName = "@numero";
                
                cmd.Parameters.Add(param_num);

                int r = cmd.ExecuteNonQuery();
                if (r != 0)
                {
                    MessageBox.Show("Note bien Enregistré", "Enregistrement", MessageBoxButtons.OK, MessageBoxIcon.Information);  
                }

                conn.Close();

            }
        }

        private void Modifier_Note_button_Click(object sender, EventArgs e)
        {
            conn.Open();
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = conn;
            cmd.CommandText = "UPDATE [Module] INNER JOIN ([Etudiant] INNER JOIN [Notes] ON [Etudiant].[Num_Etu] = [Notes].[Num_Etu]) ON [Module].[Num_Mod] = [Notes].[Num_Mod] SET [Notes].[Note]=@note WHERE((([Etudiant].[Num_Etu]) = @numero) AND(([Module].[Nom_Mod]) = @nom))";
            cmd.Parameters.AddWithValue("@note", Note_textBox.Text);
            cmd.Parameters.AddWithValue("@numero", Num_Inscription_comboBox.Text);
            cmd.Parameters.AddWithValue("@nom", Module_comboBox.Text);

            int drr = cmd.ExecuteNonQuery();

            if (drr != 0)
            {
                MessageBox.Show("Note bien modifié", "Modifié avec success", MessageBoxButtons.OK, MessageBoxIcon.Information); 
            }
            conn.Close();
        }

        private void Apperçu_button_Click(object sender, EventArgs e)
        {
            if (Num_Inscription_comboBox.Text == "") //controle de saisie
            {
                MessageBox.Show("Champ vide!!", "champ vide", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {

                conn.Open();
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = conn;
                cmd.CommandText = "SELECT [Module.Nom_Mod], [Notes.Note] FROM [Module] INNER JOIN ([Etudiant] INNER JOIN [Notes] ON [Etudiant].[Num_Etu] = [Notes].[Num_Etu]) ON [Module].[Num_Mod] = [Notes].[Num_Mod] where [Etudiant].[Num_Etu] = @numero";
                cmd.Parameters.AddWithValue("@numero", Num_Inscription_comboBox.Text);
                OleDbDataReader dre = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dre);
                dataGridView1.DataSource = dt;
                dre.Close();
                conn.Close();
            }
        }

        private void Quitter_button_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Close();
        }

        private void Module_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Num_Inscription_comboBox.Text == "") //controle de saisie
            {
                MessageBox.Show("Champ Numero Inscription vide !!", "Numero Inscription vide", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                conn.Open();
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = conn;
                cmd.CommandText = "SELECT [Notes.Note] FROM [Module] INNER JOIN ([Etudiant] INNER JOIN [Notes] ON [Etudiant].[Num_Etu] = [Notes].[Num_Etu]) ON [Module].[Num_Mod] = [Notes].[Num_Mod] where [Etudiant].[Num_Etu] = @numero and [Module].[Nom_Mod] = @nom";
                cmd.Parameters.AddWithValue("@numero", Num_Inscription_comboBox.Text);
                cmd.Parameters.AddWithValue("@nom", Module_comboBox.Text);

                OleDbDataReader drr = cmd.ExecuteReader();
                if (!(drr.HasRows))
                {
                    MessageBox.Show("Pas de  Note Pour cet Etudiant dans ce Module. Veuillez Cliquer sur le button ENREGISTRER si vous voulez ajouter une note !!", "Pas de  Note Pour cet Etudiant dans ce Module !!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    drr.Read();
                    Note_textBox.Text = drr[0].ToString();
                    drr.Close();
                }
                   
                conn.Close();
            }
           

        }

        private void Num_Inscription_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (rechercher_num1(Num_Inscription_comboBox.Text) == true) // vérification de l'existence du client dont le CIN est saisi dans la zone CIN
            {

                MessageBox.Show("Aucun etudiant ne possede ce numero. Veuillez l ajouté en cliquant sur AJOUTER ", "Numero Inexistant ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Num_Inscription_comboBox.Focus();
                Num_Inscription_comboBox.SelectAll(); //selectionner le champ CIN pour une éventuelle resaisie
            }

            else
            {
                conn.Open();
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = conn;
                cmd.CommandText = "select * from Etudiant where Num_Etu = @numero";
                cmd.Parameters.AddWithValue("@numero", Num_Inscription_comboBox.Text);
                OleDbDataReader drr = cmd.ExecuteReader();
                drr.Read();
                Nom_Prenom_TextBox.Text = drr[1].ToString() + "   " + drr[2].ToString();
                drr.Close();
                conn.Close();
            }

            



            /*conn.Open();
           OleDbCommand cmd = new OleDbCommand();
           cmd.Connection = conn;
           cmd.CommandText = "select Nom_Etu from Etudiant where Num_Etu = @numero";
           cmd.Parameters.AddWithValue("@numero", Num_Inscription_comboBox.Text);
           OleDbDataReader drr = cmd.ExecuteReader();
           drr.Read();
           Nom_Prenom_TextBox.Text = drr[0].ToString();
           drr.Close();
           conn.Close();*/

            /*conn.Open();
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select Nom_Etu from Etudiant where Num_Etu = @numero";
            cmd.Parameters.AddWithValue("@numero", Num_Inscription_comboBox.Text);
            
            object result = cmd.ExecuteScalar();
            Nom_Prenom_TextBox.Text = result.ToString();
            
            conn.Close();*/
        }

        private void Note_textBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
