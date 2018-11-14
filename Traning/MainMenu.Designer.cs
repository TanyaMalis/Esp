namespace Traning
{
    partial class MainMenu
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
            this.gente = new System.Windows.Forms.Button();
            this.pais = new System.Windows.Forms.Button();
            this.animal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // gente
            // 
            this.gente.Font = new System.Drawing.Font("Segoe Script", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gente.Location = new System.Drawing.Point(28, 77);
            this.gente.Name = "gente";
            this.gente.Size = new System.Drawing.Size(166, 65);
            this.gente.TabIndex = 0;
            this.gente.Text = "Gente";
            this.gente.UseVisualStyleBackColor = true;
            this.gente.Click += new System.EventHandler(this.gente_Click);
            // 
            // pais
            // 
            this.pais.Font = new System.Drawing.Font("Segoe Script", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pais.Location = new System.Drawing.Point(209, 77);
            this.pais.Name = "pais";
            this.pais.Size = new System.Drawing.Size(166, 65);
            this.pais.TabIndex = 1;
            this.pais.Text = "País";
            this.pais.UseVisualStyleBackColor = true;
            this.pais.Click += new System.EventHandler(this.pais_Click);
            // 
            // animal
            // 
            this.animal.Font = new System.Drawing.Font("Segoe Script", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.animal.Location = new System.Drawing.Point(390, 77);
            this.animal.Name = "animal";
            this.animal.Size = new System.Drawing.Size(166, 65);
            this.animal.TabIndex = 2;
            this.animal.Text = "Animal ";
            this.animal.UseVisualStyleBackColor = true;
            this.animal.Click += new System.EventHandler(this.animal_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 561);
            this.Controls.Add(this.animal);
            this.Controls.Add(this.pais);
            this.Controls.Add(this.gente);
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button gente;
        private System.Windows.Forms.Button pais;
        private System.Windows.Forms.Button animal;
    }
}