using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{

    class Program
    {
        static void Main(string[] args)
        {
            //RetornaTempoArenaEmMilisegundos("0.45", 340);
            //RetornaTempoMinimoEmMinutos(2749,50,8);
            //RetornaPessoasPreferemUmUnicoPalco(10000);
            //RetornaSeHaEcoNoEstudio(8);
            //CalculaDistanciaBandaPercorre(1, 1);
            //GeraFrequenciaNota(-5);
            //TamanhoSetorBusca(2834, 314);
            //RetornaGuicheIngresso(26);
        }

        public static void RetornaTempoArenaEmMilisegundos(string distancia, int velocidade)
        {
            var distKm = float.Parse(distancia) * 1000000;
            var tempo = distKm / velocidade;

            Console.WriteLine((int)Math.Round(tempo));
        }

        public static void RetornaTempoMinimoEmMinutos(int p, int s, int n)
        {
            var ciclo = 0;
            var tempo = 0f;
            if (p % n != 0)
            {
                ciclo++;
            }
            tempo = (float)(p / n + ciclo) * s / 60;

            Console.WriteLine((int)Math.Ceiling(tempo)); 
        }

        public static void RetornaPessoasPreferemUmUnicoPalco(int quantidadePessoasEvento)
        {
            Console.WriteLine(Convert.ToInt32(Math.Floor(quantidadePessoasEvento * .25))); 
        }

        public static void RetornaSeHaEcoNoEstudio(int distancia)
        {
            Console.WriteLine(Math.Round((double)distancia / 340, 1) >= .1 ? true : false); 
        }

        public static void CalculaDistanciaBandaPercorre(int numeroRodadaEnsaios, int numeroShows)
        {
            var dist = 0;

            for (int i = 0; i < numeroRodadaEnsaios; i++)
                dist += 70 * 2 * 250;

            for (int i = 0; i < numeroShows; i++)
            {
                dist += 21 * 2 * 250;
            }

            Console.WriteLine(dist);
        }

        public static void GeraFrequenciaNota(int semitons)
        {
            var frequenciaNota = new string[2];
            var sobe = new string[12] { "A", "A#", "B", "C", "C#", "D", "D#", "E", "F", "F#", "G", "G#" };
            var desce = new string[12] { "A", "Ab", "G", "Gb", "F", "E", "Eb", "D", "Db", "C", "B", "Bb" };
            var index = Math.Abs(semitons);

            Console.WriteLine(index);

            var frequencia = 440 * Math.Pow(2, (double)semitons / 12);
            frequenciaNota[0] = Math.Round(frequencia, 4).ToString();

            if (frequenciaNota[0].Length > 4 && frequenciaNota[0].Length < 8)
                frequenciaNota[0] += "0";

            if (semitons > 0)
            {
                while (semitons > 12)
                    semitons -= 12;
                frequenciaNota[1] = sobe[semitons];
            }
            else
            {
                while (semitons < 0)
                    semitons += 12;
                frequenciaNota[1] = desce[semitons];
            }
            //return frequenciaNota;
        }

        public static void TamanhoSetorBusca(int areaMaior, int areaMenor)
        {
            var busca = (float)(areaMaior - areaMenor) / 8;
            Console.WriteLine(Convert.ToString(busca));
        }

        public static void RetornaGuicheIngresso(int ingressoNumero)
        {
            var guiche = ingressoNumero > 0 ? 1 : 0;

            while (guiche * guiche < ingressoNumero)
                guiche++;

            Console.WriteLine(guiche);
        }

    }
}
