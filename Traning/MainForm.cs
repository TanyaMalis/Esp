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
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        private void Start_Click(object sender, EventArgs e)
        {
            MainMenu Menu = new MainMenu();
            Menu.Show();
        }
    }
}
