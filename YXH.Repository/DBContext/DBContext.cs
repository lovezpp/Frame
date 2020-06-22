using Microsoft.Extensions.Options;
using System.Data;
using System.Data.SqlClient;

namespace YXH.Repository.DBContext
{
    public class DBContext : DapperDBContext
    {
        public DBContext(IOptions<DBContextOptions> optionsAccessor) : base(optionsAccessor)
        {

        }
        protected override IDbConnection CreateConnection(string connectionString)
        {
            IDbConnection conn = new SqlConnection(connectionString);
            return conn;
        }

    }
    public class MySqlDBContext : DapperDBContext
    {
        public MySqlDBContext(IOptions<MySqlDBContextOptions> optionsAccessor) : base(optionsAccessor)
        {

        }
        protected override IDbConnection CreateConnection(string connectionString)
        {
            IDbConnection conn = new SqlConnection(connectionString);
            return conn;
        }

    }
}
