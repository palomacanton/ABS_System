using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ABS_System.Models
{
    public abstract class Bebida
    {
        private string _copo;  // tornando privado
        private int _pedrasDeGelo;  // tornando privado
        public int _opcoesDeTamanho { get; private set; }  // usando private set
        public bool _takeOut { get; private set; }  // usando private set
        public bool _eatIn { get; private set; }  // usando private set

        public Bebida(string copo, int pedrasDeGelo, int opcoesDeTamanho, bool takeOut, bool eatIn)
        {
            _copo = copo;
            _pedrasDeGelo = pedrasDeGelo;
            _opcoesDeTamanho = opcoesDeTamanho;
            _takeOut = takeOut;
            _eatIn = eatIn;
        }

        // Outras propriedades e métodos
    }
}
