using System;

namespace EscrevendoNoCelular.ClassLibrary.TDD
{
    public class MensagemInicial
    {
        public string ManipularMensagem(string mensagem)
        {
            ManipulaMensagem manipulaMensagem = new ManipulaMensagem();
            string mensagemFinal = "";

            if (mensagem.Length == 0)
                mensagemFinal = "nenhum número foi digitado, tente novamente!!";
            else
            {
                mensagemFinal = manipulaMensagem.ValidaMensagem(mensagem);
                if (mensagemFinal.Length == 0)
                    mensagemFinal = manipulaMensagem.ConverteMensagem(mensagem);
                if (mensagemFinal.Length > 255)
                    mensagemFinal = "A mensagem ultrapassa os 255 caracteres permitido, tente novamente!!";
            }

            return mensagemFinal;
        }
    }
}
