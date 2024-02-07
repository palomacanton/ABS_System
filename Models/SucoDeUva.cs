using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ABS_System.Models
{
    public class SucoDeUva : Bebida
    {
        public bool condicao = true;
        public bool condicao2 = true;
        public bool condicao3 = true;
        public string Copo = "copo de plástico";
        public void Escolha(){
            Console.WriteLine("Escolha dentre as opções de proporção: \n1 - 300ml\n2 - 500ml");
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
        public void OpcaoGelo(){
            Console.WriteLine("Vai querer gelo?\n1 - Sim\n2 - Não");
            while(condicao2 == true){
                switch (Console.ReadLine()){
                    case "1":
                        PedrasDeGelo = 12;
                        condicao2 = false;
                        break;

                    case "2":
                        PedrasDeGelo = 0;
                        condicao2 = false;
                        break;

                    default:
                        Console.WriteLine("Opção inválida");
                        condicao2 = true;
                        break;
                        }
                    }
            
                    }
        public void ComerNoRestaurante(){
            Console.WriteLine("Deseja:\n1 - Beber no restaurante\n2 - Levar para casa");
            while(condicao3 == true){
                switch (Console.ReadLine()){
                    case "1":
                        Beber = "com furo na tampa do copo, para beber no restaurante.";
                        condicao3 = false;
                        break;

                    case "2":
                        Beber = "sem furo na tampa do copo, para beber em casa.";
                        condicao3 = false;
                        break;

                    default:
                        Console.WriteLine("Opção inválida");
                        condicao3 = true;
                        break;
                        }
                    }
            
                    }
        public void PedidoRealizado(){
            Console.WriteLine($"Seu pedido foi realizado com sucesso!!!\nUm suco de uva no {Copo}, {OpcoesDeTamanho} ml, com {PedrasDeGelo} pedras de gelo, {Beber}");
        }

        }
    }