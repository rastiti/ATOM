using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibDeClasses{
    public class DataBaseManager{

        private static DataBaseManager instance = null;
        private static MySqlConnection connection;
        private static string server = "localhost";
        private static string database = "atom";
        private static string uid = "root";
        private static string password = "";

        private DataBaseManager(){
            try {
                connection = new MySqlConnection("SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";");
            }catch(Exception e){
                Console.WriteLine("Probleme connexion base de données.");
            }
        }

        public static DataBaseManager getInstance(){
            if(instance == null)
                instance = new DataBaseManager();
            return instance;
        }

        public dynamic executerRequete(String requete){
            /*
                SI INSERT -> True ou False en fonction du résultat
                SI SELECT -> False(erreur login/mdp) ou String(message erreur) ou tableau de données
                SI DELETE -> False ou False
            */
            if (!OpenConnection())
                return "Application indisponible";
            MySqlCommand cmd = new MySqlCommand(requete, connection);
            MySqlDataReader rdr = cmd.ExecuteReader();
            try {
                if (!rdr.HasRows) {
                    return false;
                }
                Object[] tab = new Object[rdr.FieldCount];
                while (rdr.Read()){
                    int count = rdr.GetValues(tab);
                    for (int i = 0; i < count; i++)
                        Console.WriteLine(tab[i]);
                }
                return tab;
            }
            finally{
                CloseConnection();
                rdr.Close();
            }
        }

        private static bool OpenConnection(){
            try{
                connection.Open();
                return true;
            }catch(MySqlException ex){
                switch (ex.Number){
                    case 0:
                        //0: Cannot connect to server.
                        Console.WriteLine("Connexion au serveur impossible.");
                    break;

                    case 1045:
                        //1045: Invalid user name and/or password.
                        Console.WriteLine("Connexion au serveur impossible.");
                    break;
                }
                return false;
            }
        }

        private static bool CloseConnection(){
            try{
                connection.Close();
                return true;
            }catch(MySqlException e){
                Console.WriteLine("Probleme fermeture connexion base de données.");
                return false;
            }
        }
    }
}