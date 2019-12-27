using System;
using System.Data;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace InfraStructure.Implementation.Product
{
    public class BaseInfraImpl:IDisposable
    {
        private IConfiguration configuration;
        private ILogger<ProductinfraImpl> logger;

        public BaseInfraImpl(IConfiguration configuration, ILogger<ProductinfraImpl> logger)
        {
            this.configuration = configuration;
            this.logger = logger;
        }

        public void Dispose()
        {
//         if (conn !=null)
//            conn.Close();   
        }

//        public IDbConnection conn;
        // public IDbConnection GetConnection()
        // {
        //     if (conn == null)
        //     {
        //         string ConnectionString = configuration.GetConnectionString("ProductConnection");
        //         conn = new SqlConnection(ConnectionString);
        //     }
        //     return conn;
        // }
    }
}