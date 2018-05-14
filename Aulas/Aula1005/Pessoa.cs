using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula1005_POO
{
    class Pessoa
    {
        //Atributo
        private string nome;

        //Propriedade
        public string Nome { get; set; }

        public string cpf { get; set; }

        //Construtor
        public Pessoa()
        {

        }

        public Pessoa(string nome)
        {
            Nome = nome;
        }

        public Pessoa(string nome, string cpf)
        {
            Nome = nome;
            cpf = cpf;
        }
    }
    //ponto
    public abstract string ImprimirInfo();
        {

        }
    }
}
