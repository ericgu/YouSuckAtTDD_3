using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Initial
{
    public class DataSource
    {
        public string ServerName { get; private set; }
        public string Username { get; private set; }
        public string Password { get; private set; }
        public string CatalogName { get; private set; }

        public DataSource(string serverName, string username, string password, string catalogName)
        {
            ServerName = serverName;
            Username = username;
            Password = password;
            CatalogName = catalogName;

            Validate();
        }

        void Validate()
        {
            if (String.IsNullOrEmpty(CatalogName) ||
                String.IsNullOrEmpty(ServerName) ||
                Username == null)
            {
                throw new NullReferenceException();
            }

            if (Username != String.Empty &&
                String.IsNullOrEmpty(Password))
            {
                throw new NullReferenceException();
            }
        }
    }
}
