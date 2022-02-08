
namespace MiniProjetDotNet1
{
    partial class Form2
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Moyenne_textBox = new System.Windows.Forms.TextBox();
            this.DNaissance_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.Prenom_textBox = new System.Windows.Forms.TextBox();
            this.Nom_textBox = new System.Windows.Forms.TextBox();
            this.Num_Inscription_textBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Quitter_button = new System.Windows.Forms.Button();
            this.Moyenne_button = new System.Windows.Forms.Button();
            this.Supprimer_button = new System.Windows.Forms.Button();
            this.Modifier_button = new System.Windows.Forms.Button();
            this.Ajouter_button = new System.Windows.Forms.Button();
            this.Recherche_Num_button = new System.Windows.Forms.Button();
            this.Nouveau_button = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Dernier_etudiant_button = new System.Windows.Forms.Button();
            this.Suivant_etudiant_button = new System.Windows.Forms.Button();
            this.Precedent_Etudiant_button = new System.Windows.Forms.Button();
            this.premier_Etudiant_button = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.Moyenne_textBox);
            this.groupBox1.Controls.Add(this.DNaissance_dateTimePicker);
            this.groupBox1.Controls.Add(this.Prenom_textBox);
            this.groupBox1.Controls.Add(this.Nom_textBox);
            this.groupBox1.Controls.Add(this.Num_Inscription_textBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(36, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(471, 272);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "INFOS ETUDIANT";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "MOYENNE";
            // 
            // Moyenne_textBox
            // 
            this.Moyenne_textBox.Location = new System.Drawing.Point(250, 227);
            this.Moyenne_textBox.Name = "Moyenne_textBox";
            this.Moyenne_textBox.Size = new System.Drawing.Size(200, 20);
            this.Moyenne_textBox.TabIndex = 8;
            // 
            // DNaissance_dateTimePicker
            // 
            this.DNaissance_dateTimePicker.CustomFormat = "dd-MM-yyyy";
            this.DNaissance_dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DNaissance_dateTimePicker.Location = new System.Drawing.Point(250, 182);
            this.DNaissance_dateTimePicker.Name = "DNaissance_dateTimePicker";
            this.DNaissance_dateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.DNaissance_dateTimePicker.TabIndex = 7;
            this.DNaissance_dateTimePicker.ValueChanged += new System.EventHandler(this.DNaissance_dateTimePicker_ValueChanged);
            // 
            // Prenom_textBox
            // 
            this.Prenom_textBox.Location = new System.Drawing.Point(250, 134);
            this.Prenom_textBox.Name = "Prenom_textBox";
            this.Prenom_textBox.Size = new System.Drawing.Size(200, 20);
            this.Prenom_textBox.TabIndex = 6;
            // 
            // Nom_textBox
            // 
            this.Nom_textBox.Location = new System.Drawing.Point(250, 91);
            this.Nom_textBox.Name = "Nom_textBox";
            this.Nom_textBox.Size = new System.Drawing.Size(200, 20);
            this.Nom_textBox.TabIndex = 5;
            // 
            // Num_Inscription_textBox
            // 
            this.Num_Inscription_textBox.Location = new System.Drawing.Point(250, 53);
            this.Num_Inscription_textBox.Name = "Num_Inscription_textBox";
            this.Num_Inscription_textBox.Size = new System.Drawing.Size(200, 20);
            this.Num_Inscription_textBox.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "DATE DE NAISSANCE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "PRENOM";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "NOM";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "NUMERO D\'INSCRIPTION";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Quitter_button);
            this.groupBox2.Controls.Add(this.Moyenne_button);
            this.groupBox2.Controls.Add(this.Supprimer_button);
            this.groupBox2.Controls.Add(this.Modifier_button);
            this.groupBox2.Controls.Add(this.Ajouter_button);
            this.groupBox2.Controls.Add(this.Recherche_Num_button);
            this.groupBox2.Controls.Add(this.Nouveau_button);
            this.groupBox2.Location = new System.Drawing.Point(563, 78);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(205, 244);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // Quitter_button
            // 
            this.Quitter_button.Location = new System.Drawing.Point(6, 200);
            this.Quitter_button.Name = "Quitter_button";
            this.Quitter_button.Size = new System.Drawing.Size(193, 23);
            this.Quitter_button.TabIndex = 6;
            this.Quitter_button.Text = "QUITTER";
            this.Quitter_button.UseVisualStyleBackColor = true;
            this.Quitter_button.Click += new System.EventHandler(this.Quitter_button_Click);
            // 
            // Moyenne_button
            // 
            this.Moyenne_button.Location = new System.Drawing.Point(6, 170);
            this.Moyenne_button.Name = "Moyenne_button";
            this.Moyenne_button.Size = new System.Drawing.Size(193, 23);
            this.Moyenne_button.TabIndex = 5;
            this.Moyenne_button.Text = "MOYENNE";
            this.Moyenne_button.UseVisualStyleBackColor = true;
            this.Moyenne_button.Click += new System.EventHandler(this.Moyenne_button_Click);
            // 
            // Supprimer_button
            // 
            this.Supprimer_button.Location = new System.Drawing.Point(6, 141);
            this.Supprimer_button.Name = "Supprimer_button";
            this.Supprimer_button.Size = new System.Drawing.Size(193, 23);
            this.Supprimer_button.TabIndex = 4;
            this.Supprimer_button.Text = "SUPPRIMER";
            this.Supprimer_button.UseVisualStyleBackColor = true;
            this.Supprimer_button.Click += new System.EventHandler(this.Supprimer_button_Click);
            // 
            // Modifier_button
            // 
            this.Modifier_button.Location = new System.Drawing.Point(6, 112);
            this.Modifier_button.Name = "Modifier_button";
            this.Modifier_button.Size = new System.Drawing.Size(193, 23);
            this.Modifier_button.TabIndex = 3;
            this.Modifier_button.Text = "MODIFIER";
            this.Modifier_button.UseVisualStyleBackColor = true;
            this.Modifier_button.Click += new System.EventHandler(this.Modifier_button_Click);
            // 
            // Ajouter_button
            // 
            this.Ajouter_button.Location = new System.Drawing.Point(6, 82);
            this.Ajouter_button.Name = "Ajouter_button";
            this.Ajouter_button.Size = new System.Drawing.Size(193, 23);
            this.Ajouter_button.TabIndex = 2;
            this.Ajouter_button.Text = "AJOUTER";
            this.Ajouter_button.UseVisualStyleBackColor = true;
            this.Ajouter_button.Click += new System.EventHandler(this.Ajouter_button_Click);
            // 
            // Recherche_Num_button
            // 
            this.Recherche_Num_button.Location = new System.Drawing.Point(6, 53);
            this.Recherche_Num_button.Name = "Recherche_Num_button";
            this.Recherche_Num_button.Size = new System.Drawing.Size(193, 23);
            this.Recherche_Num_button.TabIndex = 1;
            this.Recherche_Num_button.Text = "RECHERCHER PAR NUMERO";
            this.Recherche_Num_button.UseVisualStyleBackColor = true;
            this.Recherche_Num_button.Click += new System.EventHandler(this.Recherche_Num_button_Click);
            // 
            // Nouveau_button
            // 
            this.Nouveau_button.Location = new System.Drawing.Point(6, 19);
            this.Nouveau_button.Name = "Nouveau_button";
            this.Nouveau_button.Size = new System.Drawing.Size(193, 23);
            this.Nouveau_button.TabIndex = 0;
            this.Nouveau_button.Text = "NOUVEAU";
            this.Nouveau_button.UseVisualStyleBackColor = true;
            this.Nouveau_button.Click += new System.EventHandler(this.Nouveau_button_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Dernier_etudiant_button);
            this.groupBox3.Controls.Add(this.Suivant_etudiant_button);
            this.groupBox3.Controls.Add(this.Precedent_Etudiant_button);
            this.groupBox3.Controls.Add(this.premier_Etudiant_button);
            this.groupBox3.Location = new System.Drawing.Point(36, 344);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(726, 57);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // Dernier_etudiant_button
            // 
            this.Dernier_etudiant_button.Location = new System.Drawing.Point(566, 17);
            this.Dernier_etudiant_button.Name = "Dernier_etudiant_button";
            this.Dernier_etudiant_button.Size = new System.Drawing.Size(91, 23);
            this.Dernier_etudiant_button.TabIndex = 3;
            this.Dernier_etudiant_button.Text = ">>";
            this.Dernier_etudiant_button.UseVisualStyleBackColor = true;
            this.Dernier_etudiant_button.Click += new System.EventHandler(this.Dernier_etudiant_button_Click);
            // 
            // Suivant_etudiant_button
            // 
            this.Suivant_etudiant_button.Location = new System.Drawing.Point(387, 19);
            this.Suivant_etudiant_button.Name = "Suivant_etudiant_button";
            this.Suivant_etudiant_button.Size = new System.Drawing.Size(102, 23);
            this.Suivant_etudiant_button.TabIndex = 2;
            this.Suivant_etudiant_button.Text = ">";
            this.Suivant_etudiant_button.UseVisualStyleBackColor = true;
            this.Suivant_etudiant_button.Click += new System.EventHandler(this.Suivant_etudiant_button_Click);
            // 
            // Precedent_Etudiant_button
            // 
            this.Precedent_Etudiant_button.Location = new System.Drawing.Point(213, 19);
            this.Precedent_Etudiant_button.Name = "Precedent_Etudiant_button";
            this.Precedent_Etudiant_button.Size = new System.Drawing.Size(100, 23);
            this.Precedent_Etudiant_button.TabIndex = 1;
            this.Precedent_Etudiant_button.Text = "<";
            this.Precedent_Etudiant_button.UseVisualStyleBackColor = true;
            this.Precedent_Etudiant_button.Click += new System.EventHandler(this.Precedent_Etudiant_button_Click);
            // 
            // premier_Etudiant_button
            // 
            this.premier_Etudiant_button.Location = new System.Drawing.Point(48, 19);
            this.premier_Etudiant_button.Name = "premier_Etudiant_button";
            this.premier_Etudiant_button.Size = new System.Drawing.Size(99, 23);
            this.premier_Etudiant_button.TabIndex = 0;
            this.premier_Etudiant_button.Text = "<<";
            this.premier_Etudiant_button.UseVisualStyleBackColor = true;
            this.premier_Etudiant_button.Click += new System.EventHandler(this.premier_Etudiant_button_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 462);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form2";
            this.Text = "GESTION DES ETUDIANTS";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker DNaissance_dateTimePicker;
        private System.Windows.Forms.TextBox Prenom_textBox;
        private System.Windows.Forms.TextBox Nom_textBox;
        private System.Windows.Forms.TextBox Num_Inscription_textBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button Quitter_button;
        private System.Windows.Forms.Button Moyenne_button;
        private System.Windows.Forms.Button Supprimer_button;
        private System.Windows.Forms.Button Modifier_button;
        private System.Windows.Forms.Button Ajouter_button;
        private System.Windows.Forms.Button Recherche_Num_button;
        private System.Windows.Forms.Button Nouveau_button;
        private System.Windows.Forms.TextBox Moyenne_textBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button Dernier_etudiant_button;
        private System.Windows.Forms.Button Suivant_etudiant_button;
        private System.Windows.Forms.Button Precedent_Etudiant_button;
        private System.Windows.Forms.Button premier_Etudiant_button;
    }
}