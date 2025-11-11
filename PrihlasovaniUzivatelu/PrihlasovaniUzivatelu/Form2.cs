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
    public partial class Form2 : Form
    {
        //random pro random hodnoty
        Random rdm1 = new Random();
        Random rdm2 = new Random();
        Random rdm3 = new Random();
        Random rdm4 = new Random();
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
        private Image Picturegiver(int multiS)
        {
            switch (multiS)
            {
                case 1:
                    return Properties.Resources.Diamant;
                case 2:
                    return Properties.Resources.Cherry;
                case 3:
                    return Properties.Resources._7;
                case 4:
                    return Properties.Resources.Pear;
                case 5:
                    return Properties.Resources.Lemon;

                default:
                    return null;
            }


        }

        private void RerollButton_Click(object sender, EventArgs e)
        {

            //S znamená Slot takže Slot 1 až 4
            int S1 = rdm1.Next(1, 5);
            int S2 = rdm2.Next(1, 5);
            int S3 = rdm3.Next(1, 5);


            pictureSlot1.Image = Picturegiver(S1);
            pictureSlot2.Image = Picturegiver(S2);
            pictureSlot3.Image = Picturegiver(S3);
        }
    }
}
