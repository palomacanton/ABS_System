using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ABS_System.Models
{
    public class SucoDeUva : Bebida
    {
        public SucoDeUva(string copo, int pedrasDeGelo, int opcoesDeTamanho, bool takeOut, bool eatIn) : base(copo, pedrasDeGelo, opcoesDeTamanho, takeOut, eatIn)
        {}
    }
}