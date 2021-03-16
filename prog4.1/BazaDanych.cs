using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace prog4._1
{
    class BazaDanych
    {
        public string ConnectionString { get; set; } // czy connection string to jedyna informacja jaką mogę wyciągnąć do klasy?
        
        public BazaDanych(string connectionString)
        {
            this.ConnectionString = connectionString;
            
        }
    }
}
