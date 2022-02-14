namespace Singleton
{
    public class CentralModule
    {
        private static CentralModule _instance;

        //funções de exemplo, simulando dados do cotidiano
        public string ConnectionString { get; set; }
        public string SerialNumber { get; set; }
        private CentralModule() { }

        public static CentralModule GetInstance()
        {
            _instance??= new CentralModule();
            return _instance;
        }
    }
}
