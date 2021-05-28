using System;

namespace EscrevendoNoCelular.ClassLibrary.TDD
{
    class ManipulaMensagem
    {
        internal string ValidaMensagem(string mensagem)
        {
            char[] charMensagem = mensagem.ToCharArray();
            foreach (char item in charMensagem)
            {
                if (item != '1' && item != '2' && item != '3' && item != '4' && item != '5' && item != '6' && item != '7' && item != '8' && item != '9' && item != '0' && item != '_')
                    return "possue caracter não reconhecido";
            }
            return "";
        }

        internal string ConverteMensagem(string mensagem)
        {
            ModificarMensagem modificarMensagem = new ModificarMensagem();
            char[] charMensagem = mensagem.ToCharArray();

            int proxNumero = 0;
            string contNum2 = "", contNum3 = "", contNum4 = "", contNum5 = "", contNum6 = "", contNum7 = "", contNum8 = "", contNum9 = "";

            string mensagemFinal = "";

            for (int i = 0; i < charMensagem.Length; i++)
            {
                proxNumero = i + 1;

                if (charMensagem[i] == '2')
                {
                    contNum2 += 2;
                    if (proxNumero >= charMensagem.Length)
                        mensagemFinal += modificarMensagem.ConverteNumero(contNum2);
                    else if (charMensagem[proxNumero] != '2')
                    {
                        mensagemFinal += modificarMensagem.ConverteNumero(contNum2);
                        ZerarContadores(out proxNumero, out contNum2, out contNum3, out contNum4, out contNum5, out contNum6, out contNum7, out contNum8, out contNum9);
                    }
                }

                else if (charMensagem[i] == '3')
                {
                    contNum3 += 3;
                    if (proxNumero >= charMensagem.Length)
                        mensagemFinal += modificarMensagem.ConverteNumero(contNum3);
                    else if (charMensagem[proxNumero] != '3')
                    {
                        mensagemFinal += modificarMensagem.ConverteNumero(contNum3);
                        ZerarContadores(out proxNumero, out contNum2, out contNum3, out contNum4, out contNum5, out contNum6, out contNum7, out contNum8, out contNum9);
                    }
                }

                else if (charMensagem[i] == '4')
                {
                    contNum4 += 4;
                    if (proxNumero >= charMensagem.Length)
                        mensagemFinal += modificarMensagem.ConverteNumero(contNum4);
                    else if (charMensagem[proxNumero] != '4')
                    {
                        mensagemFinal += modificarMensagem.ConverteNumero(contNum4);
                        ZerarContadores(out proxNumero, out contNum2, out contNum3, out contNum4, out contNum5, out contNum6, out contNum7, out contNum8, out contNum9);
                    }
                }

                else if (charMensagem[i] == '5')
                {
                    contNum5 += 5;
                    if (proxNumero >= charMensagem.Length)
                        mensagemFinal += modificarMensagem.ConverteNumero(contNum5);
                    else if (charMensagem[proxNumero] != '5')
                    {
                        mensagemFinal += modificarMensagem.ConverteNumero(contNum5);
                        ZerarContadores(out proxNumero, out contNum2, out contNum3, out contNum4, out contNum5, out contNum6, out contNum7, out contNum8, out contNum9);
                    }
                }

                else if (charMensagem[i] == '6')
                {
                    contNum6 += 6;
                    if (proxNumero >= charMensagem.Length)
                        mensagemFinal += modificarMensagem.ConverteNumero(contNum6);
                    else if (charMensagem[proxNumero] != '6')
                    {
                        mensagemFinal += modificarMensagem.ConverteNumero(contNum6);
                        ZerarContadores(out proxNumero, out contNum2, out contNum3, out contNum4, out contNum5, out contNum6, out contNum7, out contNum8, out contNum9);
                    }
                }

                else if (charMensagem[i] == '7')
                {
                    contNum7 += 7;
                    if (proxNumero >= charMensagem.Length)
                        mensagemFinal += modificarMensagem.ConverteNumero(contNum7);
                    else if (charMensagem[proxNumero] != '7')
                    {
                        mensagemFinal += modificarMensagem.ConverteNumero(contNum7);
                        ZerarContadores(out proxNumero, out contNum2, out contNum3, out contNum4, out contNum5, out contNum6, out contNum7, out contNum8, out contNum9);
                    }
                }

                else if (charMensagem[i] == '8')
                {
                    contNum8 += 8;
                    if (proxNumero >= charMensagem.Length)
                        mensagemFinal += modificarMensagem.ConverteNumero(contNum8);
                    else if (charMensagem[proxNumero] != '8')
                    {
                        mensagemFinal += modificarMensagem.ConverteNumero(contNum8);
                        ZerarContadores(out proxNumero, out contNum2, out contNum3, out contNum4, out contNum5, out contNum6, out contNum7, out contNum8, out contNum9);
                    }
                }

                else if (charMensagem[i] == '9')
                {
                    contNum9 += 9;
                    if (proxNumero >= charMensagem.Length)
                        mensagemFinal += modificarMensagem.ConverteNumero(contNum9);
                    else if (charMensagem[proxNumero] != '9')
                    {
                        mensagemFinal += modificarMensagem.ConverteNumero(contNum9);
                        ZerarContadores(out proxNumero, out contNum2, out contNum3, out contNum4, out contNum5, out contNum6, out contNum7, out contNum8, out contNum9);
                    }
                }

                else if (charMensagem[i] == '0')
                    mensagemFinal += " ";                   
            }
            return mensagemFinal;
        }

        private static void ZerarContadores(out int proxNumero, out string contNum2, out string contNum3, out string contNum4, out string contNum5, out string contNum6, out string contNum7, out string contNum8, out string contNum9)
        {
            proxNumero = 0;
            contNum2 = "";
            contNum3 = "";
            contNum4 = "";
            contNum5 = "";
            contNum6 = "";
            contNum7 = "";
            contNum8 = "";
            contNum9 = "";
        }
    }
}
