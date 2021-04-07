using System;
using System.Data.SqlClient;

namespace prog4._1
{
    class Program
    {
        static void Main(string[] args)
        {
            BazaDanych Northwind = new BazaDanych(@"Data Source=DESKTOP-9K2SBT4;Initial Catalog=ZNorthwind;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False;MultipleActiveResultSets=True");

            Northwind.WyswietlDane();
            Northwind.DodajWpis();
            Northwind.AktualizujWpis();
            Northwind.UsunWpis();
        }
    }
}
