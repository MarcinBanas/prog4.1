using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace prog4._1
{
    public class BazaDanych
    {
        private string _ConnectionString;
        
        
        public BazaDanych(string connectionString)
        {
            this._ConnectionString = connectionString;
            
        }
    }
}
