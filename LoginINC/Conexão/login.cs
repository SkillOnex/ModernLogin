using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginINC
{
    class logincommands
    {

        public bool tem;
        public string mensagem = "";
        public bool login(string Usuario, string Senha)
        {
            
            Loginctrl logincmd = new Loginctrl();
            tem = logincmd.verificarLogin(Usuario, Senha);
            if (!logincmd.mensagem.Equals(""))
            {
                this.mensagem = logincmd.mensagem;
            }
            return tem;
        }
        public string cadastrar(string Usuario, string Senha)
        {
            return mensagem;
        }
    }
}
