using Initial;

static internal class DataSourceCopyer
{
    public static DataSourceLegacy CopyDataSourceToDataSourceLegacy(DataSource dataSource)
    {
        DataSourceLegacy dataSourceLegacy = new DataSourceLegacy
        {
            ServerName = dataSource.ServerName,
            Username = dataSource.Username,
            Password = dataSource.Password,
            CatalogName = "Legacy" + dataSource.CatalogName
        };
        return dataSourceLegacy;
    }
}