using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        string currentChoose = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void Btn_cat_Click(object sender, EventArgs e)
        {
            MessageBox.Show(currentChoose);
        }

        private void picture_cat_Click(object sender, EventArgs e)
        {
            picture_cat.BackColor = SystemColors.ActiveBorder;
            picture_dog.BackColor = SystemColors.Control;
            picture_parrot.BackColor = SystemColors.Control;
            currentChoose = "This is a cat";
        }

        private void picture_dog_Click(object sender, EventArgs e)
        {
            picture_cat.BackColor = SystemColors.Control;
            picture_dog.BackColor = SystemColors.ActiveBorder;
            picture_parrot.BackColor = SystemColors.Control;
            currentChoose = "This is a dog";
        }

        private void picture_parrot_Click(object sender, EventArgs e)
        {
            picture_cat.BackColor = SystemColors.Control;
            picture_dog.BackColor = SystemColors.Control;
            picture_parrot.BackColor = SystemColors.ActiveBorder;
            currentChoose = "This is a parrot";
        }



        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
