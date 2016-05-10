using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RailCommander.Models
{
    public class User
    {
        private int id;
        private String name;
        private String firstName;
        private String email;
        private String pass;
        private String pass2;
        public static List<User> users = new List<User>();

        public User(int id, String name, String firstName, String email, String pass, String pass2)
        {
            this.id = id;
            this.name = name;
            this.firstName = firstName;
            this.email = email;
            this.pass = pass;
            this.pass2 = pass2;
        }

        public User() { }

        public int ID { get; set; }
        public String Name { get; set; }
        public String FirstName { get; set; }
        public String Email { get; set; }
        public String Pass { get; set; }
        public String Pass2 { get; set; }

        public static List<User> mesUsers()
        {
            List<User> users = new List<User>();
            DBConnect BDD = new DBConnect();
            users = BDD.usersBDD();

            return users;
        }
    }
}