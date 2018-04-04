using System;
using NUnit.Framework;

namespace Demo_Asserts.Tests
{
    [TestFixture]
    public class JuntarNomesTests
    {
        [Test]
        public void DevoJuntarNomes()
        {
            var sut = new JuntarNomes();

            var nomeCompleto = sut.Juntar("Mary","Sue");

            Assert.That(nomeCompleto, Is.EqualTo("Mary Sue"));

        }

        [Test]
        public void DevoJuntarNomes_CaseInsensitive()
        {
            var sut = new JuntarNomes();

            var nomeCompleto = sut.Juntar("mary", "sue");

            Assert.That(nomeCompleto, Is.EqualTo("MARY SUE").IgnoreCase);
        }

        [Test]
        public void DevoJuntarNomes_NaoIgual()
        {
            var sut = new JuntarNomes();

            var nomeCompleto = sut.Juntar("Mary", "Sue");

            Assert.That(nomeCompleto, Is.Not.EqualTo("John Sue"));
        }
    }
}
