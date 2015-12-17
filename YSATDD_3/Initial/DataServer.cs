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

            dataSource.Validate();

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
