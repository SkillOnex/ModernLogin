using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginINC
{
    class Loginctrl
    {
        public bool tem = false;
        public string mensagem = "";
        SqlCommand cmd = new SqlCommand();
        Conexao con = new Conexao();
        SqlDataReader dr;
        public bool verificarLogin(string Usuario, string Senha)
        {

            cmd.CommandText = "select * from Logins where Usuario = @Usuario and Senha = @Senha";
            cmd.Parameters.AddWithValue("@Usuario", Usuario);
            cmd.Parameters.AddWithValue("@Senha", Senha);

            try
            {
                cmd.Connection = con.conectar();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    tem = true;
                }
            }
            catch (SqlException e)
            {

                this.mensagem = "Erro banco de dados";
            }
            return tem;
        }

        public string cadastrar(string Usuario, string Senha)
        {
            return mensagem;
        }
    }
}
