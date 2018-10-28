using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
   public class ExtratorValorDeArgumentosURL
    {
        public string URL { get; set; }
        private readonly string _argumentos;
        public ExtratorValorDeArgumentosURL(string url)
        {
            if (string.IsNullOrEmpty(url))
            {
                throw new ArgumentException("O Argumento não pode ser vazio",nameof(url));
            }

            URL = url;
            int indiceInterrogacao = url.IndexOf("?");
            _argumentos = url.Substring(indiceInterrogacao+1);
        }

        public string GetValor(string nomeArgumento)
        {
            nomeArgumento = nomeArgumento.ToUpper();
            string argumentoEmCaixaAlta = _argumentos.ToUpper();

            string aTexto = nomeArgumento + "=";
            int indice = argumentoEmCaixaAlta.IndexOf(aTexto);

            string resultado = _argumentos.Substring(indice + aTexto.Length);
            int indiceEComercial = resultado.IndexOf('&');

            if(indiceEComercial == -1)
            {
                return resultado;
            }
            return resultado.Remove(indiceEComercial);
        }
    }
}
