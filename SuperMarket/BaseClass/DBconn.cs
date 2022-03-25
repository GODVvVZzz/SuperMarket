using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMarket.BaseClass
{
    class DBConn
    {
        public static MySqlConnection MyConn()
        {
            return new MySqlConnection("Host=127.0.0.1;port=3306;Database=supermarket;Username=root;Password=root");
        }
    }
}
