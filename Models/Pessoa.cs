using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace C_.Models
{
    public class Pessoa
    {
        
        public Pessoa(){

        }

        // Contrutor -- Sempre o mesmo nome da clase e não tem um retorno
        public Pessoa(string nome, string sobrenome){

            //[propriedade] = [o que veio de paramentro]
            Nome = nome;
            Sobrenome = sobrenome;

        }

        //propriedades (digita prop) -> se há get e set = propriedades

        // Se colocamos o get e set vazio -> aceita qualquer valor

        // deixando Nome obrigatorio - protegendo a propriedade Nome
        private string _nome;
        private int _idade;
        public String Nome 
        { 
            /*get{
                return _nome.ToUpper();
            }*/

            get => _nome.ToUpper();
            
            set {

                if (value == ""){
                    //exceção - validando se o nome está vazio
                    throw new ArgumentException("O nome não pode ser vazio");
                }
                _nome = value;
            }  
            
        }

        public string Sobrenome{ get; set; }

        public  string NomeCompleto => $"{Nome} {Sobrenome}".ToUpper();

       //public int Idade { get; set; }

       //Validando a Idade

       public int Idade { 
        
        get => _idade;
        set{
            if (value < 0){
                throw new ArgumentException("A idade não pode ser menor do que zero");

            }

            _idade = value;
        }
    }
        // Criando metodos (ações)

        public void Apresentar(){
            Console.WriteLine($"Nome: {NomeCompleto}, Idade: {Idade}");
        }

    }
}