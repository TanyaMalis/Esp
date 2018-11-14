namespace Traning
{
    partial class WordForm
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.word = new System.Windows.Forms.Label();
            this.TranslatedWord = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // word
            // 
            this.word.AutoSize = true;
            this.word.Font = new System.Drawing.Font("Segoe Script", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.word.Location = new System.Drawing.Point(96, 62);
            this.word.Name = "word";
            this.word.Size = new System.Drawing.Size(104, 42);
            this.word.TabIndex = 0;
            this.word.Text = "Слово";
            // 
            // TranslatedWord
            // 
            this.TranslatedWord.Font = new System.Drawing.Font("Segoe Script", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TranslatedWord.Location = new System.Drawing.Point(59, 137);
            this.TranslatedWord.Name = "TranslatedWord";
            this.TranslatedWord.Size = new System.Drawing.Size(197, 50);
            this.TranslatedWord.TabIndex = 1;
            // 
            // WordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TranslatedWord);
            this.Controls.Add(this.word);
            this.Name = "WordForm";
            this.Size = new System.Drawing.Size(304, 256);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label word;
        private System.Windows.Forms.TextBox TranslatedWord;
    }
}
