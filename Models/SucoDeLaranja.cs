using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ABS_System.Models
{
    public class SucoDeLaranja : Bebida
    {
        public bool condicao = true;
        public string tipoDaBebida = "suco";
        public string copo = "copo de plástico";
        public SucoDeLaranja()
        {}
        public void Escolha(){
            
        Console.WriteLine("Escolha dentre as opções de proporção: \n1 - 300ml\n2 - 500ml\n3 - 700ml");
        while(condicao == true){

            switch (Console.ReadLine()){
        case "1":
            OpcoesDeTamanho = 300;
            condicao = false;
            break;

        case "2":
            OpcoesDeTamanho = 500;
            condicao = false;
            break;

        default:
            Console.WriteLine("Opção inválida");
            condicao = true;
            break;
    }
}
        }
    }
    
}