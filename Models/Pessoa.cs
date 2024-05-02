using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FormacaoNETDeveloper.Models //Organização das classes
{
    public class Pessoa //Classe
    {
        public string Nome { get; set; } //Propriedades - Atributos
        public int Idade { get; set; } // get - pegar o valor, set - atribuir o valor

        public void Apresentar() //Função - Método
        {
            //Parâmetro ou agurmento
            Console.WriteLine($"Olá, meu nome é {Nome}, e tenho {Idade} anos"); // Console - Classe, WriteLine - Método
        }
    }
}