using Microsoft.Extensions.Options;

namespace YXH.Repository.DBContext
{

    public class DapperDBContextOptions : IOptions<DapperDBContextOptions>
    {
        public static string Config;
        public string Configuration { get; set; }

        DapperDBContextOptions IOptions<DapperDBContextOptions>.Value
        {
            get { return this; }
        }
    }
    public class DBContextOptions: DapperDBContextOptions
    {

    }


    public class MySqlDBContextOptions: DapperDBContextOptions
    {

    }

}
