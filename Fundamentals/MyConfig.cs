using Dolittle.Configuration;

namespace Fundamentals
{
    [Name("ultimate")]
    public class MyConfig : IConfigurationObject
    {
        public MyConfig(string connectionString)
        {
            ConnectionString = connectionString;
        }


        public string ConnectionString { get; }

    }
}