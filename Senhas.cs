using System.Collections.Generic;

namespace Atendimento
{
    public class Senhas
    {
        private int proximoAtendimento;
        private Queue<Senha> filaSenhas;

        public Senhas()
        {
            filaSenhas = new Queue<Senha>();
            proximoAtendimento = 1;
        }

        public Queue<Senha> FilaSenhas
        {
            get { return filaSenhas; }
        }

        public void gerar()
        {
            filaSenhas.Enqueue(new Senha(proximoAtendimento));
            proximoAtendimento++;
        }
    }
}
