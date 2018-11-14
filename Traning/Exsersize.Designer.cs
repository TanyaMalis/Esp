namespace Traning
{
    partial class Exsersize
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
            this.ruEs = new System.Windows.Forms.Button();
            this.esRu = new System.Windows.Forms.Button();
            this.symbola = new System.Windows.Forms.Button();
            this.symbole = new System.Windows.Forms.Button();
            this.symboli = new System.Windows.Forms.Button();
            this.symbolo = new System.Windows.Forms.Button();
            this.symboln = new System.Windows.Forms.Button();
            this.word = new System.Windows.Forms.Label();
            this.TranslatedWord = new System.Windows.Forms.TextBox();
            this.nextWord = new System.Windows.Forms.Button();
            this.result = new System.Windows.Forms.Button();
            this.retest = new System.Windows.Forms.Button();
            this.anotherType = new System.Windows.Forms.Button();
            this.toMainMenu = new System.Windows.Forms.Button();
            this.dictionar = new System.Windows.Forms.Button();
            this.symbolu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ruEs
            // 
            this.ruEs.Font = new System.Drawing.Font("Segoe Script", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ruEs.Location = new System.Drawing.Point(133, 74);
            this.ruEs.Name = "ruEs";
            this.ruEs.Size = new System.Drawing.Size(275, 136);
            this.ruEs.TabIndex = 0;
            this.ruEs.Text = "Перевод на испанский";
            this.ruEs.UseVisualStyleBackColor = true;
            this.ruEs.Click += new System.EventHandler(this.ruEs_Click);
            // 
            // esRu
            // 
            this.esRu.Font = new System.Drawing.Font("Segoe Script", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.esRu.Location = new System.Drawing.Point(133, 275);
            this.esRu.Name = "esRu";
            this.esRu.Size = new System.Drawing.Size(275, 136);
            this.esRu.TabIndex = 1;
            this.esRu.Text = "Перевод на русский";
            this.esRu.UseVisualStyleBackColor = true;
            this.esRu.Click += new System.EventHandler(this.esRu_Click);
            // 
            // symbola
            // 
            this.symbola.Font = new System.Drawing.Font("Segoe Script", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.symbola.Location = new System.Drawing.Point(0, 511);
            this.symbola.Margin = new System.Windows.Forms.Padding(0);
            this.symbola.Name = "symbola";
            this.symbola.Size = new System.Drawing.Size(100, 50);
            this.symbola.TabIndex = 2;
            this.symbola.Text = "á";
            this.symbola.UseVisualStyleBackColor = true;
            this.symbola.Visible = false;
            this.symbola.Click += new System.EventHandler(this.symbol_Click);
            // 
            // symbole
            // 
            this.symbole.Font = new System.Drawing.Font("Segoe Script", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.symbole.Location = new System.Drawing.Point(100, 511);
            this.symbole.Name = "symbole";
            this.symbole.Size = new System.Drawing.Size(100, 50);
            this.symbole.TabIndex = 3;
            this.symbole.Text = "é";
            this.symbole.UseVisualStyleBackColor = true;
            this.symbole.Visible = false;
            this.symbole.Click += new System.EventHandler(this.symbol_Click);
            // 
            // symboli
            // 
            this.symboli.Font = new System.Drawing.Font("Segoe Script", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.symboli.Location = new System.Drawing.Point(200, 511);
            this.symboli.Name = "symboli";
            this.symboli.Size = new System.Drawing.Size(100, 50);
            this.symboli.TabIndex = 4;
            this.symboli.Text = "í";
            this.symboli.UseVisualStyleBackColor = true;
            this.symboli.Visible = false;
            this.symboli.Click += new System.EventHandler(this.symbol_Click);
            // 
            // symbolo
            // 
            this.symbolo.Font = new System.Drawing.Font("Segoe Script", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.symbolo.Location = new System.Drawing.Point(300, 511);
            this.symbolo.Name = "symbolo";
            this.symbolo.Size = new System.Drawing.Size(100, 50);
            this.symbolo.TabIndex = 5;
            this.symbolo.Text = "ó";
            this.symbolo.UseVisualStyleBackColor = true;
            this.symbolo.Visible = false;
            this.symbolo.Click += new System.EventHandler(this.symbol_Click);
            // 
            // symboln
            // 
            this.symboln.Font = new System.Drawing.Font("Segoe Script", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.symboln.Location = new System.Drawing.Point(500, 511);
            this.symboln.Name = "symboln";
            this.symboln.Size = new System.Drawing.Size(100, 50);
            this.symboln.TabIndex = 6;
            this.symboln.Text = "ñ";
            this.symboln.UseVisualStyleBackColor = true;
            this.symboln.Visible = false;
            this.symboln.Click += new System.EventHandler(this.symbol_Click);
            // 
            // word
            // 
            this.word.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.word.Font = new System.Drawing.Font("Segoe Script", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.word.Location = new System.Drawing.Point(12, 168);
            this.word.Name = "word";
            this.word.Size = new System.Drawing.Size(560, 42);
            this.word.TabIndex = 8;
            this.word.Text = "Слово";
            this.word.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.word.Visible = false;
            // 
            // TranslatedWord
            // 
            this.TranslatedWord.Font = new System.Drawing.Font("Segoe Script", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TranslatedWord.Location = new System.Drawing.Point(180, 275);
            this.TranslatedWord.Name = "TranslatedWord";
            this.TranslatedWord.Size = new System.Drawing.Size(200, 50);
            this.TranslatedWord.TabIndex = 9;
            this.TranslatedWord.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TranslatedWord.Visible = false;
            this.TranslatedWord.TextChanged += new System.EventHandler(this.TranslatedWord_TextChanged);
            this.TranslatedWord.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TranslatedWord_KeyPress);
            // 
            // nextWord
            // 
            this.nextWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextWord.Location = new System.Drawing.Point(438, 388);
            this.nextWord.Name = "nextWord";
            this.nextWord.Size = new System.Drawing.Size(50, 50);
            this.nextWord.TabIndex = 10;
            this.nextWord.Text = ">";
            this.nextWord.UseVisualStyleBackColor = true;
            this.nextWord.Visible = false;
            this.nextWord.Click += new System.EventHandler(this.nextWord_Click);
            // 
            // result
            // 
            this.result.Font = new System.Drawing.Font("Segoe Script", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.result.Location = new System.Drawing.Point(195, 388);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(165, 50);
            this.result.TabIndex = 11;
            this.result.Text = "Результат";
            this.result.UseVisualStyleBackColor = true;
            this.result.Visible = false;
            this.result.Click += new System.EventHandler(this.result_Click);
            // 
            // retest
            // 
            this.retest.Font = new System.Drawing.Font("Segoe Script", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.retest.Location = new System.Drawing.Point(0, 459);
            this.retest.Name = "retest";
            this.retest.Size = new System.Drawing.Size(279, 46);
            this.retest.TabIndex = 12;
            this.retest.Text = "Еще раз";
            this.retest.UseVisualStyleBackColor = true;
            this.retest.Visible = false;
            this.retest.Click += new System.EventHandler(this.retest_Click);
            // 
            // anotherType
            // 
            this.anotherType.Font = new System.Drawing.Font("Segoe Script", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.anotherType.Location = new System.Drawing.Point(306, 459);
            this.anotherType.Name = "anotherType";
            this.anotherType.Size = new System.Drawing.Size(279, 46);
            this.anotherType.TabIndex = 13;
            this.anotherType.Text = "Другой перевод";
            this.anotherType.UseVisualStyleBackColor = true;
            this.anotherType.Visible = false;
            this.anotherType.Click += new System.EventHandler(this.anotherType_Click);
            // 
            // toMainMenu
            // 
            this.toMainMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toMainMenu.Location = new System.Drawing.Point(0, 0);
            this.toMainMenu.Name = "toMainMenu";
            this.toMainMenu.Size = new System.Drawing.Size(50, 50);
            this.toMainMenu.TabIndex = 14;
            this.toMainMenu.Text = "<";
            this.toMainMenu.UseVisualStyleBackColor = true;
            this.toMainMenu.Visible = false;
            this.toMainMenu.Click += new System.EventHandler(this.toMainMenu_Click);
            // 
            // dictionar
            // 
            this.dictionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dictionar.Location = new System.Drawing.Point(535, 0);
            this.dictionar.Name = "dictionar";
            this.dictionar.Size = new System.Drawing.Size(50, 50);
            this.dictionar.TabIndex = 15;
            this.dictionar.Text = "?";
            this.dictionar.UseVisualStyleBackColor = true;
            this.dictionar.Click += new System.EventHandler(this.dictionar_Click);
            // 
            // symbolu
            // 
            this.symbolu.Font = new System.Drawing.Font("Segoe Script", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.symbolu.Location = new System.Drawing.Point(400, 511);
            this.symbolu.Name = "symbolu";
            this.symbolu.Size = new System.Drawing.Size(100, 50);
            this.symbolu.TabIndex = 16;
            this.symbolu.Text = "ú";
            this.symbolu.UseVisualStyleBackColor = true;
            this.symbolu.Visible = false;
            this.symbolu.Click += new System.EventHandler(this.symbol_Click);
            // 
            // Exsersize
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 561);
            this.Controls.Add(this.symbolu);
            this.Controls.Add(this.dictionar);
            this.Controls.Add(this.toMainMenu);
            this.Controls.Add(this.anotherType);
            this.Controls.Add(this.retest);
            this.Controls.Add(this.result);
            this.Controls.Add(this.nextWord);
            this.Controls.Add(this.TranslatedWord);
            this.Controls.Add(this.word);
            this.Controls.Add(this.symboln);
            this.Controls.Add(this.symbolo);
            this.Controls.Add(this.symboli);
            this.Controls.Add(this.symbole);
            this.Controls.Add(this.symbola);
            this.Controls.Add(this.esRu);
            this.Controls.Add(this.ruEs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.Name = "Exsersize";
            this.Text = "Exsersize";
            this.Load += new System.EventHandler(this.Exsersize_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Exsersize_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ruEs;
        private System.Windows.Forms.Button esRu;
        private System.Windows.Forms.Button symbola;
        private System.Windows.Forms.Button symbole;
        private System.Windows.Forms.Button symboli;
        private System.Windows.Forms.Button symbolo;
        private System.Windows.Forms.Button symboln;
        private System.Windows.Forms.Label word;
        private System.Windows.Forms.TextBox TranslatedWord;
        private System.Windows.Forms.Button nextWord;
        private System.Windows.Forms.Button result;
        private System.Windows.Forms.Button retest;
        private System.Windows.Forms.Button anotherType;
        private System.Windows.Forms.Button toMainMenu;
        private System.Windows.Forms.Button dictionar;
        private System.Windows.Forms.Button symbolu;
    }
}