namespace DesignPatterns.Singleton
{
    internal class Configuration
    {
        private static Configuration _configuration = null;
        private static object obj = new object();
        
        private Configuration() { }
        public int Prop1 { get; set; }
        public int Prop2 { get; set; }

        public static Configuration GetInstance()
        {
            lock (obj)
            {
                if (_configuration is null)
                {
                    _configuration = new Configuration();
                }
                return _configuration;
            }
        }

    }
}
