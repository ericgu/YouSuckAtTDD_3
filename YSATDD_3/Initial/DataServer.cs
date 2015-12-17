using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Initial
{
    public class DataServer
    {
        private ILegacyService _legacyService;

        public DataServer(ILegacyService legacyService)
        {
            _legacyService = legacyService;
        }

        public void CreateDataSource( DataSource dataSource)
        {
            if (dataSource == null)
            {
                throw new ArgumentNullException();
            }

            if (string.IsNullOrEmpty(dataSource.CatalogName) ||
                string.IsNullOrEmpty(dataSource.ServerName) ||
                dataSource.Username == null)
            {
                throw new NullReferenceException();
            }

            if (dataSource.Username != String.Empty &&
                string.IsNullOrEmpty(dataSource.Password))
            {
                throw new NullReferenceException();
            }

            DataSourceLegacy dataSourceLegacy = new DataSourceLegacy
            {
                ServerName = dataSource.ServerName,
                Username = dataSource.Username,
                Password = dataSource.Password,
                CatalogName = "Legacy" + dataSource.CatalogName
            };

            _legacyService.DataSourceCreate(dataSourceLegacy);
        }
    }
}
