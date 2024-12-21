using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Calculadora.Services;

namespace CalculadoraTestes
{
    public class ValidacoesStringTets
    {
        private ValidacoesString _validacoes;

        public ValidacoesStringTets()
        {
            _validacoes = new ValidacoesString();
        } 

        [Fact]
        public void DeveContar3CaracteresEmOlaERetornar3()
        {
            //Arrange
            string texto = "Olá";

            //Act
            int resultado =  _validacoes.ContarCaracteres(texto);

            //Assert
            Assert.Equal(3, resultado);
        }       
    }
}