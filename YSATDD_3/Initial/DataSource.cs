using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Initial
{
    public class DataSource
    {
        public string ServerName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string CatalogName { get; set; }

        public void Validate()
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
