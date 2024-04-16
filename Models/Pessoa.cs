using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace C_.Models
{
    public class Pessoa
    {

        //propriedades (digita prop) -> se há get e set = propriedades
        public String Nome { get; set; }
        public int Idade { get; set; }

        // criando metodos (ações)

        public void Apresentar(){
            Console.WriteLine($"Nome: {Nome}, Idade: {Idade}");
        }


    }
}