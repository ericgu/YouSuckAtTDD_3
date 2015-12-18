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
            var dataSourceLegacy = DataSourceCopyer.CopyDataSourceToDataSourceLegacy(dataSource);

            _legacyService.DataSourceCreate(dataSourceLegacy);
        }
    }
}
