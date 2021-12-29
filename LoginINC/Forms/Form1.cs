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
    public partial class Form1 : Form
    {
        int x = 3;
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (Passtxd.PasswordChar == '•')
            {
                pictureBox2.BringToFront();
                Passtxd.PasswordChar = '\0';
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (Passtxd.PasswordChar == '\0')
            {
                pictureBox3.BringToFront();
                Passtxd.PasswordChar = '•';
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            this.Hide();
            form2.Show();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            messege messege = new messege();
            
            messege.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (isvalid())
            {
                Loginctrl loginctrl = new Loginctrl();
                loginctrl.verificarLogin(Usertxd.Text, Passtxd.Text);
                if (loginctrl.mensagem.Equals(""))
                {
                    if (loginctrl.tem)
                    {
                        MessageBox.Show("Okay logado");
                    }
                    else
                    {
                        MessageBox.Show("Usuario ou senha não encontrado");
                        Passtxd.Clear();
                        Usertxd.Clear();
                    }
                }
                else
                {
                    MessageBox.Show(loginctrl.mensagem);
                }
            }
        }
        

        //verificar se os campos de usuario e senha estao vazios banco de dados
        private bool isvalid()
        {
            if (Usertxd.Text.TrimStart() == string.Empty)
            {
                MessageBox.Show("Por Favor preencha o campo de Usuario !");
                return false;
            }
            else if (Passtxd.Text.TrimStart() == string.Empty)
            {
                MessageBox.Show("Por Favor preencha o campo de Senha");
                return false;
            }
            return true;
        }

    }
}

