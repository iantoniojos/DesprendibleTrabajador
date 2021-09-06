using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesprendibleTrabajador
{
    public partial class Desprendible : Form
    {
        public Desprendible()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainMenu myMenu = new MainMenu();
            myMenu.Show();
            this.Hide();

        }
    }
}
