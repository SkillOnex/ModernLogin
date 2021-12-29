using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginINC
{
    public class Cadastro
    {
        Conexao conexao = new Conexao();
        SqlCommand cmd = new SqlCommand();
        public string mensagem = "";
        public Cadastro(string Usuario, string Senha)
        {
            cmd.CommandText = "insert into logins (Usuario, senha) values (@Usuario, @Senha)";

            cmd.Parameters.AddWithValue("@Usuario", Usuario);
            cmd.Parameters.AddWithValue("@Senha", Senha);
            try
            {
                Form1 form1 = new Form1();
                Form2 form2 = new Form2();
                cmd.Connection = conexao.conectar();
                cmd.ExecuteNonQuery();
                conexao.desconectar();
                this.mensagem = "Cadastrado";

                form2.Close();
                form1.Show();
                
                
            }
            catch (SqlException e)
            {
                this.mensagem = "erro na conexão";
            }

        }

    }
}
