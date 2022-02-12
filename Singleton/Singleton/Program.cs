using System;

namespace Singleton
{
    class Program
    {
        private static CentralModule centralModule = null;
        static void Main(string[] args)
        {
            CreateCentralModule();
            ShowCentralModuleInfo();
        }

        private static void CreateCentralModule()
        {
            centralModule = CentralModule.GetInstance();
            centralModule.ConnectionString = @"SERVER:C:\Singleton\Database\BD_2021.FDB";
            centralModule.SerialNumber = Geral.GerarNumerosAleatorios(30);
        }

        private static void ShowCentralModuleInfo()
        {
            Console.WriteLine($"Database: { centralModule.ConnectionString}");
            Console.WriteLine($"Serial Key: { centralModule.SerialNumber}");
            Console.ReadKey();
        }
    }
}
