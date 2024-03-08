using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Amazon.DynamoDBv2;
using Amazon.DynamoDBv2.Model;
using System.Net.Sockets;
using System.Net;
using System.Threading;
using Newtonsoft.Json;
using Xunit;
using Amazon;
using Record = Xunit.Record;
using Amazon.Runtime;

namespace AWSSDK.CSM.IntegrationTests
{
    public class CSMIntegrationTestsAsync
    {
        public CSMIntegrationTestsAsync()
        {
            AWSConfigs.CSMConfig.CSMEnabled = true;
        }

        [Fact]
        [Trait("Category", "CSM")]
        [Trait("Category", "Async")]
        [Trait("Category", "NetStandard")]
        public async Task SingleSuccessfulRequestAsync()
        {
            AmazonDynamoDBConfig config = new AmazonDynamoDBConfig
            {
                RegionEndpoint = Amazon.RegionEndpoint.USEast1
            };
            CSMTestUtilities testUtils = new CSMTestUtilities
            {
                Service = "DynamoDB",
                ApiCall = "ListTables",
                AttemptCount = 1,
                Domain = "dynamodb.us-east-1.amazonaws.com",
                Region = "us-east-1",
                HttpStatusCode = 200,
                MaxRetriesExceeded = 0,
                StashCount = 3
            };
            var task = Task.Run(() => testUtils.UDPListener());
            AmazonDynamoDBClient client = new AmazonDynamoDBClient(config);
            await client.ListTablesAsync(new ListTablesRequest { });
            Thread.Sleep(10);
            testUtils.EndTest();
            task.Wait();
            testUtils.Validate(task.Result);
        }

        [Fact]
        [Trait("Category", "CSM")]
        [Trait("Category", "Async")]
        [Trait("Category", "NetStandard")]
        public async Task SingleInvalidRequestAsync()
        {
            AmazonDynamoDBConfig config = new AmazonDynamoDBConfig
            {
                RegionEndpoint = Amazon.RegionEndpoint.USEast1
            };
            CSMTestUtilities testUtils = new CSMTestUtilities
            {
                Service = "DynamoDB",
                ApiCall = "DeleteTable",
                AttemptCount = 1,
                Domain = "dynamodb.us-east-1.amazonaws.com",
                Region = "us-east-1",
                AWSException = "ResourceNotFoundException",
                AWSExceptionMessage = "Requested resource not found",
                HttpStatusCode = 400,
                MaxRetriesExceeded = 0,
                StashCount = 3
            };
            var task = Task.Run(() => testUtils.UDPListener());
            AmazonDynamoDBClient client = new AmazonDynamoDBClient(config);
            var exception = await Record.ExceptionAsync(async () => await client.DeleteTableAsync(new DeleteTableRequest
            {
                TableName = "foobar"
            }));
            Assert.NotNull(exception);
            Assert.IsType<ResourceNotFoundException>(exception);
            Thread.Sleep(10);
            testUtils.EndTest();
            task.Wait();
            testUtils.Validate(task.Result);
        }
    }
}
