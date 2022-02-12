using System;

namespace Singleton
{
    //rotinas de uso geral
    public static class Geral
    {
        public static string GerarNumerosAleatorios(int extensaoDesejada)
        {
            string retorno = "";
            Random rdn = new Random();

            for (int i = 0; i < extensaoDesejada; i++)
            {
                retorno = string.Concat(retorno, rdn.Next(10).ToString());
            }

            return retorno;
        }
    }
}
