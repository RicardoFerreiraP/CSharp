using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula1005_POO
{
    class Cliente
    {
        //Atributo
        private string nome;

        //Propriedade
        public string Nome { get; set; }

        public string cpf { get; set; }

        //Construtor
        public Cliente()
        {

        }

        public Cliente(string nome)
        {
            Nome = nome;
        }

        public Cliente(string nome, string cpf)
        {
            Nome = nome;
            cpf = cpf;
        }
    }
}
