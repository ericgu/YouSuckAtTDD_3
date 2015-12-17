using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Initial;

namespace Initial_Tests
{
    [TestClass]
    public class DataServer_Tests
    {
        [TestMethod]
        public void when_I_call_CreateDataSource_with_a_null_data_source__it_throws_an_exception()
        {
            DataServer dataServer = new DataServer();

            try
            {
                dataServer.CreateDataSource(null);
            }
            catch (ArgumentNullException)
            {
                return;
            }

            Assert.Fail("Exception missing");
        }

        [TestMethod]
        public void when_I_call_CreateDataSource_with_a_valid_data_source__it_calls_the_legacy_server_with_proper_data()
        {
            DataServer dataServer = new DataServer();

            DataSource dataSource = new DataSource
            {
                CatalogName = "Fred",
                ServerName = "http://example.com",
                Username = "Mister Slate",
                Password = "Rock on"
            };
            dataServer.CreateDataSource(dataSource);

            // Assert.???
            // I don't know how to check this...
        }
    }
}
