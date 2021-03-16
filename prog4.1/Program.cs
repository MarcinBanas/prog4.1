using System;
using System.Data.SqlClient;

namespace prog4._1
{
    class Program
    {
        public static void DodajWpis(SqlConnection connection)
        {
            connection.Open();
            var insertSql = "insert into mg.Kategorie (IDKategorii,NazwaKategorii,Opis) VALUES (@ID,@Nazwakat,@Opis)";
            var insertCommand = new SqlCommand(insertSql, connection);
            Console.WriteLine("ID:");
            var id = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Nazwa Kategori:");
            var nazwakat = Console.ReadLine();
            Console.WriteLine("Opis:");
            var opis = Console.ReadLine();
            insertCommand.Parameters.Add(new SqlParameter("ID", id));
            insertCommand.Parameters.Add(new SqlParameter("Nazwakat", nazwakat));
            insertCommand.Parameters.Add(new SqlParameter("Opis", opis));
            insertCommand.ExecuteNonQuery();
            connection.Close();
        }

        public static void UsunWpis(SqlConnection connection)
        {
            connection.Open();
            var insertSql3 = "delete mg.Kategorie where IDkategorii=@ID";
            var insertCommand3 = new SqlCommand(insertSql3, connection);
            Console.WriteLine("delete ID:");
            var id3 = Int32.Parse(Console.ReadLine());

            insertCommand3.Parameters.Add(new SqlParameter("ID", id3));

            insertCommand3.ExecuteNonQuery();
            connection.Close();
        }

        public static void AktualizujWpis(SqlConnection connection)
        {
            connection.Open();
            var insertSql2 = "update mg.Kategorie set NazwaKategorii=@Nazwakat,Opis=@Opis where IDKategorii=@ID";
            var insertCommand2 = new SqlCommand(insertSql2, connection);

            Console.WriteLine("update ID:");
            var id2 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("nowa Nazwa Kategori:");
            var nazwakat2 = Console.ReadLine();
            Console.WriteLine("nowy Opis:");
            var opis2 = Console.ReadLine();

            insertCommand2.Parameters.Add(new SqlParameter("ID", id2));
            insertCommand2.Parameters.Add(new SqlParameter("Nazwakat", nazwakat2));
            insertCommand2.Parameters.Add(new SqlParameter("Opis", opis2));
            insertCommand2.ExecuteNonQuery();
            connection.Close();
        }

        public static void WyswietlDane(SqlConnection connection)
        {
            connection.Open();
            var zapytanie = "SELECT * FROM mg.Kategorie";
            var command = new SqlCommand(zapytanie, connection);
            var reader = command.ExecuteReader();

            while (reader.Read())
            {
                Console.Write(reader.GetInt32(0) + "   ");
                Console.Write(reader.GetString(1) + "          ");
                Console.WriteLine(reader.GetString(2) + "        ");
            }
            connection.Close();
        }
        static void Main(string[] args)
        {
            BazaDanych Northwind = new BazaDanych(@"Data Source=DESKTOP-9K2SBT4;Initial Catalog=ZNorthwind;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False;MultipleActiveResultSets=True");
            SqlConnection connection = new SqlConnection(Northwind.ConnectionString);

            WyswietlDane(connection);
            DodajWpis(connection);
            AktualizujWpis(connection);
            UsunWpis(connection);

        }
    }
}
