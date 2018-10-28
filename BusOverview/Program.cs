using BusOverview.Repository.Entities;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using System;

namespace BusOverview
{
    public class Program
    {
        public static void Main()
        {
            var connection = new SqliteConnection("Data Source=busOwerview.db");
            connection.Open();

            var options = new DbContextOptionsBuilder<DatabaseContext>()
                    .UseSqlite(connection)
                    .Options;

            // Create the schema in the database
            using (var context = new DatabaseContext())
            {
                context.Database.EnsureCreated();
            }

            using (var db = new DatabaseContext())
            {
                db.Linha.Add(new Model.Linha { NomeLinha = "teste" });
                var count = db.SaveChanges();
                Console.WriteLine("{0} records saved to database", count);

                Console.WriteLine();
                Console.WriteLine("All Linhas in database:");
                foreach (var linha in db.Linha)
                {
                    Console.WriteLine("{0}", linha.NomeLinha);
                }

                Console.ReadKey();
            }
        }
    }
}
