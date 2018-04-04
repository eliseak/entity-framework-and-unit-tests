using System;
using System.Collections.Generic;
using System.Text;

namespace Demo_Asserts
{
    public class CaracteristicasJogador
    {
        // Atributos do jogador
        public int Vida { get; set; }

        public string Nome { get; set; }

        public string Apelido { get; set; }

        public bool NovoJogador { get; set; }

        public List<string> Armas { get; set; }


        public CaracteristicasJogador()
        {
            Nome = GerarNome();

            NovoJogador = true;

            CriarArmasIniciais();
        }

        public void Dormir()
        {
            var random = new Random();

            // Aumentar a vida do jogador
            var aumentarVida = random.Next(1, 101);

            Vida += aumentarVida;
        }

        public void PerderVida(int perderVida)
        {
            Vida = Math.Max(1, Vida -= perderVida);
        }

        private string GerarNome()
        {
            var nomes = new[] {
                "Eoh",
                "MSSP",
                "FB",
                "Armahot"
            };
            return nomes[new Random().Next(0, nomes.Length)];
        }

        private void CriarArmasIniciais()
        {
            Armas = new List<string>()
            {
                "espada",
                "adaga",
                "escudo",
                "pistola"
            };


        }
    }
}
