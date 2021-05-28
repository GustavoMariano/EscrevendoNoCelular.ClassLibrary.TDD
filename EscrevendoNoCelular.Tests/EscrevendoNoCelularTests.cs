using Microsoft.VisualStudio.TestTools.UnitTesting;
using EscrevendoNoCelular.ClassLibrary.TDD;

namespace EscrevendoNoCelular.Tests
{
    [TestClass]
    public class EscrevendoNoCelularTests
    {
        MensagemInicial mensagemInicial = new MensagemInicial();
        string mensagem = "";

        [TestMethod]
        public void DeveRetornarErro()
        {
            mensagem = "";

            Assert.AreEqual("nenhum número foi digitado, tente novamente!!", mensagemInicial.ManipularMensagem(mensagem));
        }

        [TestMethod]
        public void DeveRetornarPossueCaracterNaoReconhecido()
        {
            mensagem = "1abc";

            Assert.AreEqual("possue caracter não reconhecido", mensagemInicial.ManipularMensagem(mensagem));
        }

        [TestMethod]
        public void DeveRetornarABC()
        {
            mensagem = "2_22_222";

            Assert.AreEqual("ABC", mensagemInicial.ManipularMensagem(mensagem));
        }


        [TestMethod]
        public void DeveRetornarSempreAcessoDojoPuzzles()
        {
            mensagem = "77773367_7773302_222337777_777766606660366656667889999_9999555337777";

            Assert.AreEqual("SEMPRE ACESSO O DOJOPUZZLES", mensagemInicial.ManipularMensagem(mensagem));
        }

        [TestMethod]
        public void DeveRetornarUltrapassa255Caracteres()
        {
            mensagem = "2_22_222_3_33_333_4_44_444_5_55_555_6_66_666_7_77_777_7777_8_88_888_9_99_999_9999_2_22_222_3_33_333_4_44_444_5_55_555_6_66_666_7_77_777_7777_8_88_888_9_99_999_9999_2_22_222_3_33_333_4_44_444_5_55_555_6_66_666_7_77_777_7777_8_88_888_9_99_999_9999_2_22_222_3_33_333_4_44_444_5_55_555_6_66_666_7_77_777_7777_8_88_888_9_99_999_9999_2_22_222_3_33_333_4_44_444_5_55_555_6_66_666_7_77_777_7777_8_88_888_9_99_9999_2_22_222_3_33_333_4_44_444_5_55_555_6_66_666_7_77_777_7777_8_88_888_9_99_999_9999_2_22_222_3_33_333_4_44_444_5_55_555_6_66_666_7_77_777_7777_8_88_888_9_99_999_9999_2_22_222_3_33_333_4_44_444_5_55_555_6_66_666_7_77_777_7777_8_88_888_9_99_999_9999_2_22_222_3_33_333_4_44_444_5_55_555_6_66_666_7_77_777_7777_8_88_888_9_99_999_9999_2_22_222_3_33_333_4_44_444_5_55_555_6_66_666_7_77_777_7777_8_88_888_9_99_9999";

            Assert.AreEqual("A mensagem ultrapassa os 255 caracteres permitido, tente novamente!!", mensagemInicial.ManipularMensagem(mensagem));
        }
    }
}
