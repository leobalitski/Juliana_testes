using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Embutidos.Tests
{
    [TestClass]
    [DebuggerDisplay("{" + nameof(GetDebuggerDisplay) + "(),nq}")]
    public class UsuarioTests
    {
        [TestMethod]
        public void Senha_Incorreto()
        {
            ValidaUsuario usuario = new ValidaUsuario();
            var resultado = usuario.Login("JamalM", "12345");

            Assert.AreEqual("Login ou senha incorretos!", resultado);
        }
        //s


        [TestMethod]
        public void Login_Incorreto()
        {
            ValidaUsuario usuario = new ValidaUsuario();
            var resultado = usuario.Login("Xesquedele", "123456");

            Assert.AreEqual("Login ou senha incorretos!", resultado);
        }

        [TestMethod]
        public void Login_Vazio()
        {
            ValidaUsuario usuario = new ValidaUsuario();
            var resultado = usuario.Login("", "265");

            Assert.AreEqual("Login ou senha incorretos!", resultado);
        }

        [TestMethod]
        public void Senha_VaziaIncorreta()
        {
            ValidaUsuario usuario = new ValidaUsuario();
            var resultado = usuario.Login("JamalM", "");

            Assert.AreEqual("Login ou senha incorretos!", resultado);
        }

        [DataTestMethod]

        [DataRow(null)]
        [DataRow("321")]
        [DataRow("412")]
        [DataRow("434")]
        [DataRow("123")]
        private string GetDebuggerDisplay()
        {
            return ToString();
        }

        [TestMethod]
        public void estoque_Vazio()
        {
            Validaestoque estoque = new Validaestoque();
            var consulta = estoque.empty;
            if (estoque != full)
            {
                Assert.AreEqual(" estoque vazio favor encher", resultado);
            }
            else
            {
                Assert.AreEqual(" estoque cheio ", resultado);
            }

            Assert.AreEqual("return vazio!", resultado);
        }
        [TestMethod]
        public void cvv_incorreto()
        {
            Validacvv cvv = new Validacvv();

            var resultado = cvv.validacao("1,2,3");

            if (cvv != ("1,2,3"))
            {

                Assert.AreEqual("cvv incorreto!", resultado);
            }
            else
            {
                Assert.AreEqual("cvv correto!", resultado);
            }


            Assert.AreEqual("Cvv incorreto, favor tentar novamente!", resultado);
        }


    }


}
