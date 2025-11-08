using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrihlasovaniUzivatelu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //ahoj lidi, tohle je zkouska

            //jsem diddler
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Registration r = new Registration();
            r.Show();
        }
    }
}
