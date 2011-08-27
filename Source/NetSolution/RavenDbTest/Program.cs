using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Raven.Client.Document;

namespace RavenDbTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var store = new DocumentStore() { Url = "http://localhost:8080" };
            store.Initialize();
            using(var session = store.OpenSession())
            {
                var user = session.Load<User>("users/1");
                Console.WriteLine(user);
            }

            Console.ReadLine();
        }


    }

    public class User
    {
        public String Username { get; set; }
        public String PasswordHash { get; set; }

        public override string ToString()
        {
            return Username + " " + PasswordHash;
        }
    }
}
