using System;
using System.Collections.Generic;
using System.Text;

namespace FaktoryMethod
{
    public abstract class Transporte
    {
        public abstract string descricao { get; }
        public abstract int totalPassageiros { get; }
    }
}
