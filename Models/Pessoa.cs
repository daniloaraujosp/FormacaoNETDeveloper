using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FormacaoNETDeveloper.Models //Organização das classes
{
    public class Pessoa //Classe
    {
        public string nome { get; set; } //Propriedades - Atributos
        public int idade { get; set; } // get - pegar o valor, set - atribuir o valor
        public string nomeRepresentanteLegalDaPessoaFisica { get; set; } //Evitar abreviações ex: NomeRepLegal - correto: NomeRepresentanteLegal

        public void apresentar() //Função - Método
        {
            //Parâmetro ou agurmento
            Console.WriteLine($"Olá, meu nome é {nome}, e tenho {idade} anos."); // Console - Classe, WriteLine - Método
        }
    }
}