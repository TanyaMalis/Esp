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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        /// <summary>
        /// метод вызова формы для отработки темы gente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gente_Click(object sender, EventArgs e)
        {
            Exsersize Exs = new Exsersize(); 
            Exs.Tema = "gente"; // тему задаем, как gente
            Exs.ShowDialog();
        }

        private void pais_Click(object sender, EventArgs e)
        {
            Exsersize Exs = new Exsersize();
            Exs.Tema = "pais"; // тему задаем, как pais
            Exs.ShowDialog();
        }

        private void animal_Click(object sender, EventArgs e)
        {
            Exsersize Exs = new Exsersize();
            Exs.Tema = "animal";
            Exs.ShowDialog();
        }
    }
}
