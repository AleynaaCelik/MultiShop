using System.Data;
using System.Data.SqlClient;
using Microsoft.Extensions.Configuration;

namespace MultiShop.Discount.Context
{
    public class DapperContext
    {
        private readonly string _connectionString;

        public DapperContext(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DefaultConnection");
        }

        public IDbConnection CreateConnection()
        {
            // SqlConnection kullanarak bir veritabanı bağlantısı oluşturuyoruz.
            return new SqlConnection(_connectionString);
        }
    }
}
