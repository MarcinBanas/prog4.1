using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace prog4._1
{
    class BazaDanych
    {
        public string ConnectionString { get; set; }
        
        public BazaDanych(string connectionString)
        {
            this.ConnectionString = connectionString;
            
        }
    }
}
