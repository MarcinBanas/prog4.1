using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace prog4._1
{
    public class BazaDanych
    {
        public string ConnectionString;
        
        
        public BazaDanych(string connectionString)
        {
            this.ConnectionString = connectionString;
            
        }
    }
}
