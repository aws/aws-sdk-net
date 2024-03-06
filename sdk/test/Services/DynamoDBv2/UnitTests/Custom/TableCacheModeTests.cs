using Amazon;
using Amazon.DynamoDBv2;
using Amazon.DynamoDBv2.DataModel;
using Amazon.DynamoDBv2.DocumentModel;
using Amazon.DynamoDBv2.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal.Util;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace AWSSDK_DotNet.UnitTests
{
    /// <summary>
    /// Tests the behavior determined by <see cref="MetadataCachingMode"/>, 
    /// which controls how the internal DescribeTable result is cached
    /// </summary>
    [TestClass]
    public class TableCacheModeTests
    {
        [TestInitialize]
        public void Initialize()
        {
            // These tests rely on the static SDK-wide cache, so we must reset
            // it before each case or else relevant state will be shared
            SdkCache.Clear();
        }

        /// <summary>
        /// Asserts that DescribeTable is called twice for different credentials for default behavior
        /// </summary>
        [DataTestMethod, TestCategory("DynamoDBv2")]
        [DataRow(null)]
        [DataRow(MetadataCachingMode.Default)]
        public void DataModel_DefaultWithDifferentCredentials_DescribeTableCalledTwice(MetadataCachingMode? metadataCachingMode)
        {
            var config = new DynamoDBContextConfig
            {
                MetadataCachingMode = metadataCachingMode
            };

            var client1 = CreateMockedClient(new BasicAWSCredentials("test", "test"));  
            var client2 = CreateMockedClient(new BasicAWSCredentials("test2", "test2"));

            new DynamoDBContext(client1.Object, config).GetTargetTable<ItemClass>();
            new DynamoDBContext(client2.Object, config).GetTargetTable<ItemClass>();

            client1.Verify(x => x.DescribeTable(It.IsAny<DescribeTableRequest>()), Times.Once());
            client2.Verify(x => x.DescribeTable(It.IsAny<DescribeTableRequest>()), Times.Once());
        }

        /// <summary>
        /// Asserts that DescribeTable is called once for the same credentials for default behavior
        /// </summary>
        /// <param name="metadataCachingMode"></param>
        [DataTestMethod, TestCategory("DynamoDBv2")]
        [DataRow(null)]
        [DataRow(MetadataCachingMode.Default)]
        public void DataModel_DefaultWithSameCredentials_DescribeTableCalledOnce(MetadataCachingMode? metadataCachingMode)
        {
            var config = new DynamoDBContextConfig
            {
                MetadataCachingMode = metadataCachingMode
            };

            var client1 = CreateMockedClient(new BasicAWSCredentials("test", "test"));
            var client2 = CreateMockedClient(new BasicAWSCredentials("test", "test"));

            new DynamoDBContext(client1.Object, config).GetTargetTable<ItemClass>();
            new DynamoDBContext(client2.Object, config).GetTargetTable<ItemClass>();

            client1.Verify(x => x.DescribeTable(It.IsAny<DescribeTableRequest>()), Times.Once());
            client2.Verify(x => x.DescribeTable(It.IsAny<DescribeTableRequest>()), Times.Never());
        }

        /// <summary>
        /// Asserts that DescribeTable is called once for different credentials when using <see cref="MetadataCachingMode.TableNameOnly"/>
        /// </summary>
        [TestMethod]
        [TestCategory("DynamoDBv2")]
        public void DataModel_TableNameOnlyWithDifferentCredentials_DescribeTableCalledOnce()
        {
            var config = new DynamoDBContextConfig
            {
                MetadataCachingMode = MetadataCachingMode.TableNameOnly,
            };

            var client1 = CreateMockedClient(new BasicAWSCredentials("test", "test"));
            var client2 = CreateMockedClient(new BasicAWSCredentials("test2", "test2"));

            new DynamoDBContext(client1.Object, config).GetTargetTable<ItemClass>();
            new DynamoDBContext(client2.Object, config).GetTargetTable<ItemClass>();

            client1.Verify(x => x.DescribeTable(It.IsAny<DescribeTableRequest>()), Times.Once());
            client2.Verify(x => x.DescribeTable(It.IsAny<DescribeTableRequest>()), Times.Never());
        }

        /// <summary>
        /// Asserts that DescribeTable is called once for different credentials when using <see cref="MetadataCachingMode.TableNameOnly"/>
        /// when it is set via <see cref="AWSConfigsDynamoDB"/> instead of the context-specific <see cref="DynamoDBContextConfig"/>
        /// </summary>
        [TestMethod]
        [TestCategory("DynamoDBv2")]
        public void DataModel_TableNameOnlyViaConfigWithDifferentCredentials_DescribeTableCalledOnce()
        {
            AWSConfigsDynamoDB.Context.MetadataCachingMode = MetadataCachingMode.TableNameOnly;

            var client1 = CreateMockedClient(new BasicAWSCredentials("test", "test"));
            var client2 = CreateMockedClient(new BasicAWSCredentials("test2", "test2"));

            new DynamoDBContext(client1.Object, new DynamoDBContextConfig()).GetTargetTable<ItemClass>();
            new DynamoDBContext(client2.Object, new DynamoDBContextConfig()).GetTargetTable<ItemClass>();

            client1.Verify(x => x.DescribeTable(It.IsAny<DescribeTableRequest>()), Times.Once());
            client2.Verify(x => x.DescribeTable(It.IsAny<DescribeTableRequest>()), Times.Never());
        }

        /// <summary>
        /// Asserts that DescribeTable is called once for the same credentials when using <see cref="MetadataCachingMode.TableNameOnly"/>
        /// </summary>
        [TestMethod]
        [TestCategory("DynamoDBv2")]
        public void DataModel_TableNameOnlyWithSameCredentials_DescribeTableCalledOnce()
        {
            var config = new DynamoDBContextConfig
            {
                MetadataCachingMode = MetadataCachingMode.TableNameOnly,
            };

            var client1 = CreateMockedClient(new BasicAWSCredentials("test", "test"));
            var client2 = CreateMockedClient(new BasicAWSCredentials("test", "test"));

            new DynamoDBContext(client1.Object, config).GetTargetTable<ItemClass>();
            new DynamoDBContext(client2.Object, config).GetTargetTable<ItemClass>();

            client1.Verify(x => x.DescribeTable(It.IsAny<DescribeTableRequest>()), Times.Once());
            client2.Verify(x => x.DescribeTable(It.IsAny<DescribeTableRequest>()), Times.Never());
        }

        /// <summary>
        /// Asserts that DescribeTable is called twice for different credentials for default behavior
        /// </summary>
        [DataTestMethod, TestCategory("DynamoDBv2")]
        [DataRow(null)]
        [DataRow(MetadataCachingMode.Default)]
        public void DocumentModel_DefaultWithDifferentCredentials_DescribeTableCalledTwice(MetadataCachingMode? metadataCachingMode)
        {
            var tableConfig = new TableConfig("MockTable") 
            { 
                MetadataCachingMode = metadataCachingMode 
            };

            var client1 = CreateMockedClient(new BasicAWSCredentials("test", "test"));
            var client2 = CreateMockedClient(new BasicAWSCredentials("test2", "test2"));

            var table1 = Table.LoadTable(client1.Object, tableConfig);
            var table2 = Table.LoadTable(client2.Object, tableConfig);

            client1.Verify(x => x.DescribeTable(It.IsAny<DescribeTableRequest>()), Times.Once());
            client2.Verify(x => x.DescribeTable(It.IsAny<DescribeTableRequest>()), Times.Once());
        }

        /// <summary>
        /// Asserts that DescribeTable is called once for the same credentials for default behavior
        /// </summary>
        [DataTestMethod, TestCategory("DynamoDBv2")]
        [DataRow(null)]
        [DataRow(MetadataCachingMode.Default)]
        public void DocumentModel_DefaultWithSameCredentials_DescribeTableCalledOnce(MetadataCachingMode? metadataCachingMode)
        {
            var tableConfig = new TableConfig("MockTable")
            {
                MetadataCachingMode = metadataCachingMode
            };

            var client1 = CreateMockedClient(new BasicAWSCredentials("test", "test"));
            var client2 = CreateMockedClient(new BasicAWSCredentials("test", "test"));

            var table1 = Table.LoadTable(client1.Object, tableConfig);
            var table2 = Table.LoadTable(client2.Object, tableConfig);

            client1.Verify(x => x.DescribeTable(It.IsAny<DescribeTableRequest>()), Times.Once());
            client2.Verify(x => x.DescribeTable(It.IsAny<DescribeTableRequest>()), Times.Never());
        }

        /// <summary>
        /// Asserts that DescribeTable is called once for different credentials when using <see cref="MetadataCachingMode.TableNameOnly"/>
        /// </summary>
        [DataTestMethod, TestCategory("DynamoDBv2")]
        public void DocumentModel_TableNameOnlyWithDifferentCredentials_DescribeTableCalledOnce()
        {
            var tableConfig = new TableConfig("MockTable")
            {
                MetadataCachingMode = MetadataCachingMode.TableNameOnly
            };

            var client1 = CreateMockedClient(new BasicAWSCredentials("test", "test"));
            var client2 = CreateMockedClient(new BasicAWSCredentials("test2", "test2"));

            var table1 = Table.LoadTable(client1.Object, tableConfig);
            var table2 = Table.LoadTable(client2.Object, tableConfig);

            client1.Verify(x => x.DescribeTable(It.IsAny<DescribeTableRequest>()), Times.Once());
            client2.Verify(x => x.DescribeTable(It.IsAny<DescribeTableRequest>()), Times.Never());
        }

        /// <summary>
        /// Asserts that DescribeTable is called once for the same credentials when using <see cref="MetadataCachingMode.TableNameOnly"/>
        /// </summary>
        [DataTestMethod, TestCategory("DynamoDBv2")]
        public void DocumentModel_TableNameOnlyWithSameCredentials_DescribeTableCalledOnce()
        {
            var tableConfig = new TableConfig("MockTable")
            {
                MetadataCachingMode = MetadataCachingMode.TableNameOnly
            };

            var client1 = CreateMockedClient(new BasicAWSCredentials("test", "test"));
            var client2 = CreateMockedClient(new BasicAWSCredentials("test", "test"));

            var table1 = Table.LoadTable(client1.Object, tableConfig);
            var table2 = Table.LoadTable(client2.Object, tableConfig);

            client1.Verify(x => x.DescribeTable(It.IsAny<DescribeTableRequest>()), Times.Once());
            client2.Verify(x => x.DescribeTable(It.IsAny<DescribeTableRequest>()), Times.Never());
        }

        [DynamoDBTable("MockTable")]
        private class ItemClass
        {
            public string Id { get; set; }
        }

        private Mock<AmazonDynamoDBClient> CreateMockedClient(BasicAWSCredentials credentials)
        {
            var client = new Mock<AmazonDynamoDBClient>(credentials);

            client.Setup(x => x.DescribeTable(It.IsAny<DescribeTableRequest>())).Returns(
                new DescribeTableResponse()
                {
                    Table = new TableDescription()
                }
            );

            return client;
        }
    }
}
