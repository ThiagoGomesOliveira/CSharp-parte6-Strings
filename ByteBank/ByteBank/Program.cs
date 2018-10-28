using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            string url = "www.bytebank.com/cambio?origem=real&destino=dolar";
            ExtratorValorDeArgumentosURL extrator = new ExtratorValorDeArgumentosURL(url);
            string teste = extrator.GetValor("origem"); // real&destino=dolar
            Console.WriteLine(teste);
            Console.ReadLine();

        }
    }
}
