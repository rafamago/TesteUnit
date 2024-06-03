using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Calculadora;

namespace Calculadora.Testes
{
    public class ValidacoesStringTests
    {
        private ValidacoesString _validacoes;

        public ValidacoesStringTests()
        {
            _validacoes = new ValidacoesString();
        }
        [Fact]
        public void DeveContar3CaracteresEmOlaERetornar3()
        {
            //Arrange
            string texto = "Ola";
            //ACT
            int resultado = _validacoes.ContarCaracteres(texto);
            //assert
            Assert.Equal(3, resultado)
        }
    }
}