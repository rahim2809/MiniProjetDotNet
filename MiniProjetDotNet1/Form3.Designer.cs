
namespace MiniProjetDotNet1
{
    partial class Form3
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Quitter_button = new System.Windows.Forms.Button();
            this.Apperçu_button = new System.Windows.Forms.Button();
            this.Modifier_Note_button = new System.Windows.Forms.Button();
            this.Enregistrer_Note_button = new System.Windows.Forms.Button();
            this.Nouveau_button = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Module_comboBox = new System.Windows.Forms.ComboBox();
            this.Num_Inscription_comboBox = new System.Windows.Forms.ComboBox();
            this.Note_textBox = new System.Windows.Forms.TextBox();
            this.Nom_Prenom_TextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(38, 306);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(718, 108);
            this.dataGridView1.TabIndex = 5;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Quitter_button);
            this.groupBox2.Controls.Add(this.Apperçu_button);
            this.groupBox2.Controls.Add(this.Modifier_Note_button);
            this.groupBox2.Controls.Add(this.Enregistrer_Note_button);
            this.groupBox2.Controls.Add(this.Nouveau_button);
            this.groupBox2.Location = new System.Drawing.Point(529, 50);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(233, 237);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            // 
            // Quitter_button
            // 
            this.Quitter_button.Location = new System.Drawing.Point(29, 166);
            this.Quitter_button.Name = "Quitter_button";
            this.Quitter_button.Size = new System.Drawing.Size(198, 23);
            this.Quitter_button.TabIndex = 4;
            this.Quitter_button.Text = "QUITTER";
            this.Quitter_button.UseVisualStyleBackColor = true;
            this.Quitter_button.Click += new System.EventHandler(this.Quitter_button_Click);
            // 
            // Apperçu_button
            // 
            this.Apperçu_button.Location = new System.Drawing.Point(29, 134);
            this.Apperçu_button.Name = "Apperçu_button";
            this.Apperçu_button.Size = new System.Drawing.Size(198, 23);
            this.Apperçu_button.TabIndex = 3;
            this.Apperçu_button.Text = "APERCU ";
            this.Apperçu_button.UseVisualStyleBackColor = true;
            this.Apperçu_button.Click += new System.EventHandler(this.Apperçu_button_Click);
            // 
            // Modifier_Note_button
            // 
            this.Modifier_Note_button.Location = new System.Drawing.Point(29, 105);
            this.Modifier_Note_button.Name = "Modifier_Note_button";
            this.Modifier_Note_button.Size = new System.Drawing.Size(198, 23);
            this.Modifier_Note_button.TabIndex = 2;
            this.Modifier_Note_button.Text = "MODIFIER NOTE";
            this.Modifier_Note_button.UseVisualStyleBackColor = true;
            this.Modifier_Note_button.Click += new System.EventHandler(this.Modifier_Note_button_Click);
            // 
            // Enregistrer_Note_button
            // 
            this.Enregistrer_Note_button.Location = new System.Drawing.Point(29, 64);
            this.Enregistrer_Note_button.Name = "Enregistrer_Note_button";
            this.Enregistrer_Note_button.Size = new System.Drawing.Size(198, 23);
            this.Enregistrer_Note_button.TabIndex = 1;
            this.Enregistrer_Note_button.Text = "ENREGISTRER NOTE";
            this.Enregistrer_Note_button.UseVisualStyleBackColor = true;
            this.Enregistrer_Note_button.Click += new System.EventHandler(this.Enregistrer_Note_button_Click);
            // 
            // Nouveau_button
            // 
            this.Nouveau_button.Location = new System.Drawing.Point(29, 28);
            this.Nouveau_button.Name = "Nouveau_button";
            this.Nouveau_button.Size = new System.Drawing.Size(198, 23);
            this.Nouveau_button.TabIndex = 0;
            this.Nouveau_button.Text = "NOUVEAU";
            this.Nouveau_button.UseVisualStyleBackColor = true;
            this.Nouveau_button.Click += new System.EventHandler(this.Nouveau_button_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Module_comboBox);
            this.groupBox1.Controls.Add(this.Num_Inscription_comboBox);
            this.groupBox1.Controls.Add(this.Note_textBox);
            this.groupBox1.Controls.Add(this.Nom_Prenom_TextBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(38, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(435, 250);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // Module_comboBox
            // 
            this.Module_comboBox.FormattingEnabled = true;
            this.Module_comboBox.Items.AddRange(new object[] {
            "Architecture JEE et DotNet",
            "Administration des bases de données",
            "Stochastique et Analyse de données",
            "Optimisation et théorie des graphes",
            "Gestion de projet et analyse financière",
            "Modélisation UML2"});
            this.Module_comboBox.Location = new System.Drawing.Point(203, 139);
            this.Module_comboBox.Name = "Module_comboBox";
            this.Module_comboBox.Size = new System.Drawing.Size(187, 21);
            this.Module_comboBox.TabIndex = 9;
            this.Module_comboBox.SelectedIndexChanged += new System.EventHandler(this.Module_comboBox_SelectedIndexChanged);
            // 
            // Num_Inscription_comboBox
            // 
            this.Num_Inscription_comboBox.FormattingEnabled = true;
            this.Num_Inscription_comboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.Num_Inscription_comboBox.Location = new System.Drawing.Point(203, 51);
            this.Num_Inscription_comboBox.Name = "Num_Inscription_comboBox";
            this.Num_Inscription_comboBox.Size = new System.Drawing.Size(187, 21);
            this.Num_Inscription_comboBox.TabIndex = 8;
            this.Num_Inscription_comboBox.SelectedIndexChanged += new System.EventHandler(this.Num_Inscription_comboBox_SelectedIndexChanged);
            // 
            // Note_textBox
            // 
            this.Note_textBox.Location = new System.Drawing.Point(203, 186);
            this.Note_textBox.Name = "Note_textBox";
            this.Note_textBox.Size = new System.Drawing.Size(187, 20);
            this.Note_textBox.TabIndex = 7;
            this.Note_textBox.TextChanged += new System.EventHandler(this.Note_textBox_TextChanged);
            // 
            // Nom_Prenom_TextBox
            // 
            this.Nom_Prenom_TextBox.Location = new System.Drawing.Point(203, 98);
            this.Nom_Prenom_TextBox.Name = "Nom_Prenom_TextBox";
            this.Nom_Prenom_TextBox.Size = new System.Drawing.Size(187, 20);
            this.Nom_Prenom_TextBox.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "NOTE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "MODULE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "NOM ET PRENOM";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "NUMERO D\'INSCRIPTION";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form3";
            this.Text = "GESTION DES NOTES";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button Quitter_button;
        private System.Windows.Forms.Button Apperçu_button;
        private System.Windows.Forms.Button Modifier_Note_button;
        private System.Windows.Forms.Button Enregistrer_Note_button;
        private System.Windows.Forms.Button Nouveau_button;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox Module_comboBox;
        private System.Windows.Forms.ComboBox Num_Inscription_comboBox;
        private System.Windows.Forms.TextBox Note_textBox;
        private System.Windows.Forms.TextBox Nom_Prenom_TextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}