using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ABS_System.Models
{
    public abstract class Bebida
    {
        public string TipoDaBebida { get; set; }
        public string Copo { get; set; }
        public int PedrasDeGelo { get; set; }
        public int OpcoesDeTamanho { get; set; }
        public bool TakeOut { get; set; }
        public bool EatIn { get; set; }

        public Bebida()
        {
        }

    }
}
