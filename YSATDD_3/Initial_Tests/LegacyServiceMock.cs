using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Initial;

namespace Initial_Tests
{
    class LegacyServiceMock : ILegacyService
    {
        public DataSourceLegacy DataSourceLegacy { get; set; }

        public void DataSourceCreate(DataSourceLegacy dataSource)
        {
            DataSourceLegacy = dataSource;
        }
    }
}
