using ParserGamer.Domain.Entities;
using ParserGamer.Domain.Interfaces.Services;
using System.Collections.Generic;
using System.IO;


namespace ParserGamer.Domain.Services
{
    public class ToolsService : IToolsService
    {
        private readonly string Kill = "Kill";
        private readonly string PlayerWorld = "<world>";

        public void LerArquivo()
        {
            var players = new List<Player>();
            var novasLinhas = new List<string>();
            int contadorMortes = 0;
            int mortesWorld = 0;

            var todasAsLinhas = File.ReadAllLines(@"C:\Users\Bruno-PC\Desktop\games.log.txt");

            foreach (string linha in todasAsLinhas)
            {
                if (linha.Contains(Kill))
                {
                    contadorMortes++;

                    var palavras = linha.Split();
                    var playerMorto = palavras[8].ToString();


                    if (EPlayerWorldMatou(linha))
                    {
                        mortesWorld++;
                    }
                }
            }



        }

        private bool EPlayerWorldMatou(string linha)
        {
            if (linha.Contains(PlayerWorld))
            {
                return true;
            }
            return false;
        }
    }
}
