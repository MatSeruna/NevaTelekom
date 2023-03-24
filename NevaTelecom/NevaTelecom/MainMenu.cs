using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NevaTelecom
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }  
        private void button_tarifs_Click(object sender, EventArgs e)
        {
            this.Hide();
            Tariffs tarifs = new Tariffs();
            tarifs.Show();
        }
    }
}
