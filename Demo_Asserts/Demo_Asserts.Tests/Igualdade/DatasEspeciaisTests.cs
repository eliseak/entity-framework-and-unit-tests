using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo_Asserts.Tests.Igualdade
{
    [TestFixture]
    public class DatasEspeciaisTests
    {
        [Test]
        public void DeveRetornarData_AnoNovo()
        {
            var sut = new DatasEspeciaisStore();

            var resultado = sut.Data(DatasEspeciais.AnoNovo);

            Assert.That(resultado, Is.EqualTo(new DateTime(2018, 1, 1, 0, 0, 0)));
        }

        [Test]
        public void DeveRetornarData_AnoNovo_Within()
        {
            var sut = new DatasEspeciaisStore();

            var resultado = sut.Data(DatasEspeciais.AnoNovo);

            //Assert.That(resultado, Is.EqualTo(new DateTime(2018, 1, 1, 0, 0, 1)).Within(1).Milliseconds);

            Assert.That(resultado, Is.EqualTo(new DateTime(2018, 1, 1, 0, 0, 1)).Within(TimeSpan.FromSeconds(1)));
        }

        [Test]
        public void DeveRetornarData_Natal()
        {
            var sut = new DatasEspeciaisStore();

            var resultado = sut.Data(DatasEspeciais.Natal);

            Assert.That(resultado, Is.EqualTo(new DateTime(2018, 12, 25, 0, 0, 0)));
        }

    }
}
