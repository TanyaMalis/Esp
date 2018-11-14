using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Traning
{
    public partial class Exsersize : Form
    {
        string tema; //задает выбранную тему слов
        Work workingPage = new Work(); // создание рабочей страницы
        List<string> translatedWords = new List<string>(); // список переведа слов
        List<string> words = new List<string>(); // список слов
        bool ruEsFlag = false; // определение типа проверки: c русского на испанский или наоборот

        /// <summary>
        /// свойство для темы слов
        /// </summary>
        public string Tema
        {
            get
            {
                return tema;
            }

            set
            {
                tema = value;
            }
        }

        public Exsersize()
        {
            InitializeComponent();
        }

        private void Exsersize_Load(object sender, EventArgs e)
        {
            workingPage.ChoiceTema(tema); // выбор слов выбранной темы
            toMainMenu.Visible = true;
        }

        /// <summary>
        /// если перешли по кнопке перевода с русского на испанский
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ruEs_Click(object sender, EventArgs e)
        {
            ruEsFlag = true; // устанавливаем флаг, что перевод будет с русского языка
            ChoiceType(); 
        }

        /// <summary>
        /// если перешли по кнопке перевода с испанского на русский
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void esRu_Click(object sender, EventArgs e)
        {
            ruEsFlag = false;
            ChoiceType();
        }

        /// <summary>
        /// метод выбора типа задания
        /// </summary>
        private void ChoiceType()
        {
            workingPage.RandomWords(); // перемешиваем слова из выбранной темы
            if (ruEsFlag) // смотрим на установленный флаг, если перевод с русского языка
            {
                words = workingPage.TransformRuWords; // за слова для перевода берем русские слова
                translatedWords = workingPage.TransformEsWords; // за их перевод - испанские
                symbola.Visible = true;
                symbole.Visible = true;
                symboli.Visible = true;
                symboln.Visible = true;
                symbolo.Visible = true;
                symbolu.Visible = true;
            }
            else
            {
                words = workingPage.TransformEsWords; // иначе слова для перевода - испанские
                translatedWords = workingPage.TransformRuWords; // их перевод - русский
            }
            DesignPage(); // переход на метод оформления страницы с тренажером
        }
        
        int indx = 0; // индексатор для номера слова в списке
        int ProgressCount = 0; // число верных ответов

        /// <summary>
        /// метод оформления тренажера
        /// </summary>
        private void DesignPage()
        {
            dictionar.Visible = false;
            ruEs.Visible = false; 
            esRu.Visible = false;
            word.Visible = true;  
            TranslatedWord.Visible = true;
            toMainMenu.Visible = false;
            ShowTest_ruEs();
        }

        /// <summary>
        /// метод вывода на экран слова для перевода
        /// </summary>
        private void ShowTest_ruEs()
        {
            if (indx < words.Count) 
            {
                word.Text = words[indx]; 
            }
        }

        /// <summary>
        /// метод обработки введеного слова
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TranslatedWord_TextChanged(object sender, EventArgs e)
        {
            if (indx == words.Count - 1) // если это последнее слово
            {
                nextWord.Visible = false; // не показываем кнопку для перехода на следующее слова
                result.Visible = true; // а показываем для получения результата 
            }
            else nextWord.Visible = true; // если не последнее, показываем переход на следующее слово
        }

        /// <summary>
        /// метод обработки перехода к следующему слову
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void nextWord_Click(object sender, EventArgs e)
        {
            NextWord();
        }

        private void NextWord()
        {
            Progress(); // проверяем правильность написанного слова
            TranslatedWord.Text = "";
            indx++;
            ShowTest_ruEs();
            nextWord.Visible = false;
        }

        /// <summary>
        /// метод проверки правильности введенного перевода
        /// </summary>
        /// <param name="translate"></param>
        /// <param name="key"></param>
        private void Progress()
        {// если введенное слово совпадает со словом из списка переводов увеличиваем счетчик правильных ответов
            if (TranslatedWord.Text == translatedWords[indx]) ProgressCount++; 
        }

        /// <summary>
        /// метод вывода результата
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void result_Click(object sender, EventArgs e)
        {
            Progress(); // проверяем правильность перевода для последнего слова
            double progressProcent = ((ProgressCount / 1.0) / words.Count) * 100; // высчитываем процент правильных ответов
            word.Text = "Ваш результат: " + string.Format("{0:0.##}", progressProcent) + "%";
            TranslatedWord.Visible = false;
            TranslatedWord.Text = "";
            result.Visible = false;
            retest.Visible = true;
            anotherType.Visible = true;
            toMainMenu.Visible = true;
            symbola.Visible = false;
            symbole.Visible = false;
            symboli.Visible = false;
            symboln.Visible = false;
            symbolo.Visible = false;
            symbolu.Visible = false;
        }

        private void Result()
        {
            Progress(); // проверяем правильность перевода для последнего слова
            double progressProcent = ((ProgressCount / 1.0) / words.Count) * 100; // высчитываем процент правильных ответов
            word.Text = "Ваш результат: " + string.Format("{0:0.##}", progressProcent) + "%";
            TranslatedWord.Visible = false;
            TranslatedWord.Text = "";
            result.Visible = false;
            retest.Visible = true;
            anotherType.Visible = true;
            toMainMenu.Visible = true;
            symbola.Visible = false;
            symbole.Visible = false;
            symboli.Visible = false;
            symboln.Visible = false;
            symbolo.Visible = false;
            symbolu.Visible = false;
        }

        private void symbol_Click(object sender, EventArgs e)
        {
            Button symbol = (Button)sender;
            TranslatedWord.Text += symbol.Text;
            if (indx == words.Count - 1) result.Focus();
            else nextWord.Focus();
        }

        /// <summary>
        /// метод для обработки кнопки повторного прохождения
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void retest_Click(object sender, EventArgs e)
        {
            Repeated();
        }

        private void anotherType_Click(object sender, EventArgs e)
        {
            if (ruEsFlag) ruEsFlag = false;
            else ruEsFlag = true;
            Repeated();
        }

        private void Repeated()
        {
            retest.Visible = false;
            anotherType.Visible = false;
            toMainMenu.Visible = false;
            indx = 0;
            ProgressCount = 0;
            ChoiceType();
        }

        private void toMainMenu_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dictionar_Click(object sender, EventArgs e)
        {
            Dictionary DicWords = new Dictionary();
            DicWords.ShowDialog();
        }

        private void TranslatedWord_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                if (indx == words.Count - 1) Result();
                    NextWord();
            }
        }

        private void Exsersize_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 97 && e.KeyChar <= 122)
            {
                if (TranslatedWord.Visible == true)
                {
                    TranslatedWord.Text += e.KeyChar.ToString();
                    e.Handled = true;
                }
            }
        }
    }
}
