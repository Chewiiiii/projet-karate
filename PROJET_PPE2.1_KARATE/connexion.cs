﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace PROJET_PPE2._1_KARATE
{
    //Cette class est la class de connexion à la base de données
    //En cas d'erreur, vérifier que le mot de pass (PASSWORD) et/ou le nom d'utilisateur (UID) sont exact.
    class connexion
    {
        public static MySqlConnection ConnectionBD()
        {
            // Création de la chaîne de connexion
            string connectionString = "SERVER=localhost; DATABASE=karate; UID=root; PASSWORD=root";
            MySqlConnection conn = new MySqlConnection(connectionString);
            return conn;
        }
    }
}
