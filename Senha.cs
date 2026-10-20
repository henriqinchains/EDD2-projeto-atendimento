using System;

namespace Atendimento
{
    public class Senha
    {
        private int id;
        private DateTime dataGerac;
        private DateTime horaGerac;
        private DateTime dataAtend;
        private DateTime horaAtend;

        public Senha(int id)
        {
            this.id = id;
            DateTime agora = DateTime.Now;
            dataGerac = agora;
            horaGerac = agora;
        }

        // Acréscimo ao diagrama: registra o momento do atendimento (chamado pelo Guiche)
        public void registrarAtendimento()
        {
            DateTime agora = DateTime.Now;
            dataAtend = agora;
            horaAtend = agora;
        }

        public string dadosParciais()
        {
            return id + "-" + dataGerac.ToString("dd/MM/yyyy") + "-" + horaGerac.ToString("HH:mm:ss");
        }

        public string dadosCompletos()
        {
            return id + "-" + dataGerac.ToString("dd/MM/yyyy") + "-" + horaGerac.ToString("HH:mm:ss")
                 + "-" + dataAtend.ToString("dd/MM/yyyy") + "-" + horaAtend.ToString("HH:mm:ss");
        }
    }
}
