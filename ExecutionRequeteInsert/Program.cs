using System;
using System.Data.SqlClient;
namespace ExecutionRequeteInsert
{
    class Program
    {
        static void Main(string[] args)
        {
            string connexionString, requete;
            connexionString = @"Data Source=localhost;Initial Catalog=GestionStagiaires;User= 'sa'; password = 'admintp4'";
            requete = "SELECT * FROM Stagiaires";
            SqlConnection connexion = new SqlConnection(connexionString);
            SqlCommand commande = connexion.CreateCommand();
            commande.CommandText = requete;
            connexion.Open();
            SqlDataReader lire = commande.ExecuteReader();
            while (lire.Read())
            {
                Console.WriteLine("ID : {0} | Nom : {1} | Prenom : {2}", lire.GetInt32(0), lire.GetString(1), lire["Prenom"]);
            }
            connexion.Close();
            connexion.Dispose();
            Console.ReadLine();
        }
    }
}
