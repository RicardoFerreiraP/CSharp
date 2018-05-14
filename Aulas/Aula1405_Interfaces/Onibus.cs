using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula1405_Interfaces
{
    class Onibus : IMeioTransporte
    {
        public int Velocidade { get; set; }

        public string Modelo { get; set; }

        //chave para objeto Marca
        public int MarcaID { get; set; }

        //Propriedade de navegação
        public virtual Marca _Marca { get; set; }

        public Onibus()
        {
            Velocidade = 0;
        }

        public void Acelerar()
        {
            Velocidade += 7;   
        }

        public void Desacelerar()
        {
            Velocidade -= 4;
        }

        public string ImprimirInfo()
        {
            return "Ônibus, velocidade atual: " + Velocidade;
        }
    }
}
