using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo_Asserts.Tests.Igualdade
{
    [TestFixture]
    public class CalculadoraTests
    {
        [Test]
        public void DevoSomarNumerosInteiros()
        {
            var sut = new Calculadora();

            var resultado = sut.SomarInteiros(4, 2);

            Assert.That(resultado, Is.EqualTo(6));
        }

        [Test]
        public void DevoSomarNumerosDecimais()
        {
            var sut = new Calculadora();

            var resultado = sut.SomarDecimais(4.4, 2.2);

            Assert.That(resultado, Is.EqualTo(6.6));
        }

        [Test]
        public void DevoSomarNumerosDecimais_UsandoWithin()
        {
            var sut = new Calculadora();

            var resultado = sut.SomarDecimais(4.4, 2.2);

            // Within - permite tolerância
            Assert.That(resultado, Is.EqualTo(6.6).Within(0.001));
        }

        [Test]
        public void DevoSomarNumerosDecimais_UsandoWithinPorcentagem()
        {
            var sut = new Calculadora();

            var resultado = sut.SomarDecimais(50, 50);

            // Within - permite tolerância
            Assert.That(resultado, Is.EqualTo(101).Within(1).Percent);
        }

        [Test]
        public void DevoSomarNumerosDecimais_WithinErrado()
        {
            var sut = new Calculadora();

            var resultado = sut.SomarDecimais(4.4, 2.2);

            Assert.That(resultado, Is.EqualTo(30).Within(100));
        }
    }
}
