using NUnit.Framework;
using System;

namespace Calculadora.Tests
{
    public class CalculadoraTests
    {
        [TestFixture]
        public class CalculadoraSimplesTests
        {
            [Test]
            public void DeveAdicionarDoisNumeros()
            {
                // System Under Test
                var sut = new CalculadoraSimples();

                var resultado = sut.Adicionar(5, 5);

                Assert.That(resultado, Is.EqualTo(10));
            }

            [Test]
            public void DeveMultiplicarDoisNumeros()
            {
                var sut = new CalculadoraSimples();

                var resultado = sut.Multiplicar(5, 5);

                Assert.That(resultado, Is.EqualTo(25));
            }

            [Test]
            public void DeveSubtrairDoisNumeros()
            {
                var sut = new CalculadoraSimples();

                var resultado = sut.Subtrair(5, 5);

                Assert.That(resultado, Is.EqualTo(0));
            }

            [Test]
            public void DeveDividirDoisNumeros()
            {
                var sut = new CalculadoraSimples();

                var resultado = sut.Dividir(5, 5);

                Assert.That(resultado, Is.EqualTo(1));
            }

        }
    }
}
