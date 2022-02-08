using System;
using System.Windows.Forms;
using System.Data.OleDb;

namespace MiniProjetDotNet1
{
    public partial class Form2 : Form
    {
        static String connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\rahim\Documents\ProjetDotNet\Gest_Notes.accdb";
        OleDbConnection conn = new OleDbConnection(connectionString);

        private bool rechercher_numero(int num)
        {
            bool p = false;
            conn.Open();
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select * from Etudiant where Num_Etu = @numero";
            cmd.Parameters.AddWithValue("@numero", num);
            OleDbDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
                p = true;

            dr.Close();
            conn.Close();
            return p;
        }


        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void Nouveau_button_Click(object sender, EventArgs e)
        {
            Num_Inscription_textBox.Text = "";
            Nom_textBox.Text = "";
            Prenom_textBox.Text = "";
        }

        private void Recherche_Num_button_Click(object sender, EventArgs e)
        {
            if (Num_Inscription_textBox.Text == "")
                MessageBox.Show("Champ Numero vide!!", "champ vide", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else if (rechercher_numero(int.Parse(Num_Inscription_textBox.Text))==false)
            {
                Nom_textBox.Text = "";
                Prenom_textBox.Text = "";
                MessageBox.Show("Numero introuvable!!", "introuvable", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Num_Inscription_textBox.Focus();
                Num_Inscription_textBox.SelectAll();
            }
            else
            {
                conn.Open();
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = conn;
                cmd.CommandText= "select * from Etudiant where Num_Etu = @numero";
                cmd.Parameters.AddWithValue("@numero", Num_Inscription_textBox.Text);
                OleDbDataReader drr = cmd.ExecuteReader();
                drr.Read();
                Nom_textBox.Text = drr[1].ToString();
                Prenom_textBox.Text = drr[2].ToString();
                drr.Close();
                conn.Close();
            }
        }

        private void Ajouter_button_Click(object sender, EventArgs e)
        {
            if (Num_Inscription_textBox.Text == "" || Nom_textBox.Text == "" || Prenom_textBox.Text == "" )
                MessageBox.Show("Champ vide!!", "champ vide", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else if (rechercher_numero(int.Parse(Num_Inscription_textBox.Text)) == true)
            {
                MessageBox.Show("Etudiant existe déjà", "existant", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Num_Inscription_textBox.Focus();
                Num_Inscription_textBox.SelectAll();
            }
            else
            {
                conn.Open();
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = conn;
                cmd.CommandText = "insert into Etudiant values (@numero, @nom, @prenom, @DateNaissance)";
                cmd.Parameters.AddWithValue("@numero", Num_Inscription_textBox.Text);
                cmd.Parameters.AddWithValue("@nom", Nom_textBox.Text);
                cmd.Parameters.AddWithValue("@prenom", Prenom_textBox.Text);
                cmd.Parameters.Add("@DateNaissance", DNaissance_dateTimePicker);


                int r = cmd.ExecuteNonQuery();
                if (r != 0)
                {
                    MessageBox.Show("Etudiant bien ajouté", "ajout", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    conn.Close();
                }
            }
        }

        private void Modifier_button_Click(object sender, EventArgs e)
        {
            if (Num_Inscription_textBox.Text == "" || Nom_textBox.Text == "" || Prenom_textBox.Text == "") //controle de saisie
            {
                MessageBox.Show("Champ vide!!", "champ vide", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (rechercher_numero(int.Parse(Num_Inscription_textBox.Text)) == false) // vérification de l'existence du client dont le CIN est saisi dans la zone CIN
            {

                MessageBox.Show("Etudiant Introuvable", "Introuvable", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Num_Inscription_textBox.Focus();
                Num_Inscription_textBox.SelectAll(); //selectionner le champ CIN pour une éventuelle resaisie
            }
            else
            {
                conn.Open();
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = conn;
                // cmd.CommandText = String.Format("update client set nom='{0}',prenom='{1}',ville='{2}',tel='{3}' where cin='{4}'", NOM_textBox.Text, PRENOM_textBox.Text, VILLE_textBox.Text, TEL_textBox4.Text, CIN_textBox.Text);
                cmd.CommandText = String.Format("update Etudiant set Nom_Etu=@nom, Prenom_Etu=@prenom, DateN_Etu=@date where Num_Etu=@numero");

                cmd.Parameters.AddWithValue("@nom", Nom_textBox.Text);
                cmd.Parameters.AddWithValue("@prenom", Prenom_textBox.Text);
                cmd.Parameters.Add("@DateNaissance", DNaissance_dateTimePicker);
                OleDbParameter param_num = new OleDbParameter();
                param_num.ParameterName = "@numero";
                param_num.Value = Num_Inscription_textBox.Text;
                cmd.Parameters.Add(param_num);

                int r = cmd.ExecuteNonQuery();
                if (r != 0)
                {
                    MessageBox.Show("Etudiant bien Modifié", "Modification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                }
                conn.Close();
            }
        }

        private void Supprimer_button_Click(object sender, EventArgs e)
        {
            if (Num_Inscription_textBox.Text == "") //controle de saisie
            {
                MessageBox.Show("Champ Numero vide!!", "champ vide", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (rechercher_numero(int.Parse(Num_Inscription_textBox.Text)) == false) // vérification de l'existence du client dont le CIN est saisi dans la zone CIN
            {

                MessageBox.Show("Etudiant Introuvable", "Introuvable", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Num_Inscription_textBox.Focus();
                Num_Inscription_textBox.SelectAll(); //selectionner le champ CIN pour une éventuelle resaisie
            }
            else
            {
                /*conn.Open();
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = conn;
                cmd.CommandText = String.Format("DELETE [Notes.*] FROM [Module] INNER JOIN([Etudiant] INNER JOIN [Notes] ON [Etudiant].[Num_Etu] = [Notes].[Num_Etu]) ON [Module].[Num_Mod] = [Notes].[Num_Mod] where [Etudiant].[Num_Etu] = @numero;");
                cmd.Parameters.AddWithValue("@numero", Num_Inscription_textBox.Text);
                int r = cmd.ExecuteNonQuery();
                cmd.CommandText = String.Format("DELETE [Etudiant.*] FROM [Module] INNER JOIN([Etudiant] INNER JOIN [Notes] ON [Etudiant].[Num_Etu] = [Notes].[Num_Etu]) ON [Module].[Num_Mod] = [Notes].[Num_Mod] where [Etudiant].[Num_Etu] = @numero;");
                cmd.Parameters.AddWithValue("@numero", Num_Inscription_textBox.Text);
                int rr = cmd.ExecuteNonQuery();
                if (rr != 0)
                {
                    MessageBox.Show("Etudiant bien Supprimé", "Suppression", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Nouveau_button.PerformClick(); //appeler le bouton nouveau pour vider les champs
                    conn.Close();
                }*/

                conn.Open();
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = conn;
                cmd.CommandText = "SELECT [Notes.Note] FROM [Module] INNER JOIN ([Etudiant] INNER JOIN [Notes] ON [Etudiant].[Num_Etu] = [Notes].[Num_Etu]) ON [Module].[Num_Mod] = [Notes].[Num_Mod] where [Etudiant].[Num_Etu] = @numero";
                cmd.Parameters.AddWithValue("@numero", Num_Inscription_textBox.Text);
                

                OleDbDataReader drr = cmd.ExecuteReader();
                if ((drr.HasRows))
                {
                    OleDbCommand cmd2 = new OleDbCommand();
                    cmd2.Connection = conn;
                    cmd2.CommandText = String.Format("DELETE FROM Notes WHERE [Notes].[Num_Etu] = @numero");
                    cmd2.Parameters.AddWithValue("@numero", Num_Inscription_textBox.Text);
                    int r = cmd2.ExecuteNonQuery();
                }
                
                OleDbCommand cmd1 = new OleDbCommand();
                cmd1.Connection = conn;
                cmd1.CommandText = String.Format("DELETE [Etudiant.*] FROM [Etudiant] where [Etudiant].[Num_Etu] = @numero");
                cmd1.Parameters.AddWithValue("@numero", Num_Inscription_textBox.Text);
                int rr = cmd1.ExecuteNonQuery();
                MessageBox.Show("Etudiant Supprimé avec Succes avec verification de son existence dans la table des Notes!!", "Etudiant supprimé avec Succes", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                conn.Close();

            }
        }

        private void Moyenne_button_Click(object sender, EventArgs e)
        {
            if (Num_Inscription_textBox.Text == "" || Nom_textBox.Text == "" || Prenom_textBox.Text == "") //controle de saisie
            {
                MessageBox.Show("Champ vide!!", "champ vide", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                conn.Open();
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = conn;
                // cmd.CommandText = String.Format("update client set nom='{0}',prenom='{1}',ville='{2}',tel='{3}' where cin='{4}'", NOM_textBox.Text, PRENOM_textBox.Text, VILLE_textBox.Text, TEL_textBox4.Text, CIN_textBox.Text);
                cmd.CommandText = String.Format("SELECT AVG([Notes.Note]) FROM [Module] INNER JOIN ([Etudiant] INNER JOIN [Notes] ON [Etudiant].[Num_Etu] = [Notes].[Num_Etu]) ON [Module].[Num_Mod] = [Notes].[Num_Mod] where [Etudiant].[Num_Etu] = @num");
                cmd.Parameters.AddWithValue("@num", Num_Inscription_textBox.Text);
                OleDbDataReader drr = cmd.ExecuteReader();
                drr.Read();
                Moyenne_textBox.Text = drr[0].ToString();
                drr.Close();
                conn.Close();
            }
        }

        private void Quitter_button_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Close();
        }

        private void DNaissance_dateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void premier_Etudiant_button_Click(object sender, EventArgs e)
        {
            conn.Open();
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = conn;
            // cmd.CommandText = String.Format("update client set nom='{0}',prenom='{1}',ville='{2}',tel='{3}' where cin='{4}'", NOM_textBox.Text, PRENOM_textBox.Text, VILLE_textBox.Text, TEL_textBox4.Text, CIN_textBox.Text);
            cmd.CommandText = String.Format("SELECT * FROM [Etudiant] where [Etudiant].[Num_Etu] = (SELECT MIN([Etudiant].[Num_Etu]) FROM [Etudiant])");
            OleDbDataReader drr = cmd.ExecuteReader();
            drr.Read();
            Num_Inscription_textBox.Text = drr[0].ToString();
            Nom_textBox.Text = drr[1].ToString();
            Prenom_textBox.Text = drr[2].ToString();

            drr.Close();
            conn.Close();
        }

        private void Dernier_etudiant_button_Click(object sender, EventArgs e)
        {
            conn.Open();
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = conn;
            // cmd.CommandText = String.Format("update client set nom='{0}',prenom='{1}',ville='{2}',tel='{3}' where cin='{4}'", NOM_textBox.Text, PRENOM_textBox.Text, VILLE_textBox.Text, TEL_textBox4.Text, CIN_textBox.Text);
            cmd.CommandText = String.Format("SELECT * FROM [Etudiant] where [Etudiant].[Num_Etu] = (SELECT MAX([Etudiant].[Num_Etu]) FROM [Etudiant])");
            OleDbDataReader drr = cmd.ExecuteReader();
            drr.Read();
            Num_Inscription_textBox.Text  = drr[0].ToString();
            Nom_textBox.Text = drr[1].ToString();
            Prenom_textBox.Text = drr[2].ToString();

            drr.Close();
            conn.Close();
        }

        private void Suivant_etudiant_button_Click(object sender, EventArgs e)
        {
            if (Num_Inscription_textBox.Text == "") //controle de saisie
            {
                MessageBox.Show("Champ Numero vide!!", "champ vide", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                conn.Open();
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = conn;
                // cmd.CommandText = String.Format("update client set nom='{0}',prenom='{1}',ville='{2}',tel='{3}' where cin='{4}'", NOM_textBox.Text, PRENOM_textBox.Text, VILLE_textBox.Text, TEL_textBox4.Text, CIN_textBox.Text);
                cmd.CommandText = String.Format("SELECT * FROM [Etudiant] where [Etudiant].[Num_Etu] = @num");
                cmd.Parameters.AddWithValue("@num", int.Parse(Num_Inscription_textBox.Text)+1);
                OleDbDataReader drr = cmd.ExecuteReader();
                drr.Read();
                Num_Inscription_textBox.Text = drr[0].ToString();
                Nom_textBox.Text = drr[1].ToString();
                Prenom_textBox.Text = drr[2].ToString();

                drr.Close();
                conn.Close();
            }
        }

        private void Precedent_Etudiant_button_Click(object sender, EventArgs e)
        {
            if (Num_Inscription_textBox.Text == "") //controle de saisie
            {
                MessageBox.Show("Champ Numero vide!!", "champ vide", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                conn.Open();
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = conn;
                // cmd.CommandText = String.Format("update client set nom='{0}',prenom='{1}',ville='{2}',tel='{3}' where cin='{4}'", NOM_textBox.Text, PRENOM_textBox.Text, VILLE_textBox.Text, TEL_textBox4.Text, CIN_textBox.Text);
                cmd.CommandText = String.Format("SELECT * FROM [Etudiant] where [Etudiant].[Num_Etu] = @num");
                cmd.Parameters.AddWithValue("@num", int.Parse(Num_Inscription_textBox.Text) - 1);
                OleDbDataReader drr = cmd.ExecuteReader();
                drr.Read();
                Num_Inscription_textBox.Text = drr[0].ToString();
                Nom_textBox.Text = drr[1].ToString();
                Prenom_textBox.Text = drr[2].ToString();

                drr.Close();
                conn.Close();
            }
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        
    }
}
