using System;
using System.Collections.Generic;
using System.Text;

namespace FaktoryMethod
{
    public class TransporteFaktory : TransporteFaktoryMethod
    {

        public override Transporte CriarTransporte(Tipos.ETipoTransporte transporte)
        {
            switch (transporte)
            {
                case Tipos.ETipoTransporte.aviao:
                    return new Aviao();
                case Tipos.ETipoTransporte.carro:
                    return new Carro();
                case Tipos.ETipoTransporte.moto:
                    return new Moto();
                default: return new Carro();
            }

        }
    }
}
