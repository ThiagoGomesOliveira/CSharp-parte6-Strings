using ByteBank.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente(666,222);
            Console.WriteLine(conta.ToString());
            Console.ReadLine();
           

        }



        public static void TesteRegex()
        {
            //string url = "www.bytebank.com/cambio?origem=real&destino=dolar";
            //ExtratorValorDeArgumentosURL extrator = new ExtratorValorDeArgumentosURL(url);
            //string teste = extrator.GetValor("origem"); // real&destino=dolar
            //Console.WriteLine(teste);
            // string padrao = "[0123456789][0123456789][0123456789][0123456789][-][0123456789][0123456789][0123456789][0123456789]";
            string padrao = "[0-9]{4,5}-?[0-9]{4}";
            string texto = "Meu número é: 2342-3453";
            Match match = Regex.Match(texto, padrao);
            Console.WriteLine(match.Value);
            Console.ReadLine();
        }
    }
}
