using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LoginINC
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            
          Cadastro cad = new Cadastro(Usertxd.Text, Passtxd2.Text);
                
        
         }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

            if (Passtxd.PasswordChar == '•')
            {
                pictureBox8.BringToFront();
                Passtxd.PasswordChar = '\0';
                Passtxd2.PasswordChar = '\0';
            }
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            if (Passtxd.PasswordChar == '\0')
            {
                pictureBox7.BringToFront();
                Passtxd.PasswordChar = '•';
                Passtxd2.PasswordChar = '•';
            }
        }
        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            messege messege = new messege();
            messege.Show();
        }
    }
}
