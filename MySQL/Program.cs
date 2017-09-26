using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace MySQL
{
    class Program
    {
        static void Main(string[] args)
        {
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = "Server=192.168.56.121; Port=3306; Database=Concerten; Uid=imma; Pwd=imma;";

            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "SELECT COUNT(*) FROM Artiesten";

            con.Open();

            //int aantalArtiesten = (int)cmd.ExecuteScalar(); //de cast "(int)" is zelfde als Convert.ToInt32()

            Console.WriteLine("Aantal artiesten: " + cmd.ExecuteScalar());
        }
    }
}