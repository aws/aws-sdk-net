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
        [Trait("Category", "CoreCLR")]
        public void SingleSuccessfulRequest()
        {
            var task = Task.Run(() => UDPListener());
            AmazonDynamoDBConfig config = new AmazonDynamoDBConfig
            {
                RegionEndpoint = Amazon.RegionEndpoint.USEast1
            };
            AmazonDynamoDBClient client = new AmazonDynamoDBClient(config);
            client.ListTablesAsync(new ListTablesRequest { }).Wait();

            using (var udpClient = new UdpClient())
            {
                udpClient.Send(Encoding.UTF8.GetBytes("Exit"),
                        Encoding.UTF8.GetBytes("Exit").Length, "127.0.0.1", 31000);
                Thread.Sleep(10);
            }
            Assert.Equal(3, task.Result.Count);
            CSMTestUtilities testUtils = new CSMTestUtilities
            {
                Service = "DynamoDB",
                ApiCall = "ListTables",
                Domain = "dynamodb.us-east-1.amazonaws.com",
                Region = "us-east-1",
                HttpStatusCode = 200
            };
            foreach (var value in task.Result)
            {
                if (!value.Equals("Exit"))
                {
                    try
                    {
                        testUtils.Validate(JsonConvert.DeserializeObject<MonitoringAPICallEvent>(value));
                    }
                    catch (Exception e)
                    {
                        testUtils.Validate(JsonConvert.DeserializeObject<MonitoringAPICallAttempt>(value));
                    }
                }
                else
                {
                    break;
                }
            }
        }

        [Fact]
        [Trait("Category", "CSM")]
        [Trait("Category", "Async")]
        [Trait("Category", "CoreCLR")]
        public void SingleInvalidRequest()
        {
            var task = Task.Run(() => UDPListener());
            AmazonDynamoDBConfig config = new AmazonDynamoDBConfig
            {
                RegionEndpoint = Amazon.RegionEndpoint.USEast1
            };
            AmazonDynamoDBClient client = new AmazonDynamoDBClient(config);
            try
            {
                client.DeleteTableAsync(new DeleteTableRequest
                {
                    TableName = "foobar"
                }).Wait();
            }
            catch(Exception e)
            {

            }
            finally
            {
                using (var udpClient = new UdpClient())
                {
                    udpClient.Send(Encoding.UTF8.GetBytes("Exit"),
                            Encoding.UTF8.GetBytes("Exit").Length, "127.0.0.1", 31000);
                    Thread.Sleep(10);
                }
                Assert.Equal(3, task.Result.Count);
                CSMTestUtilities testUtils = new CSMTestUtilities
                {
                    Service = "DynamoDB",
                    ApiCall = "DeleteTable",
                    Domain = "dynamodb.us-east-1.amazonaws.com",
                    Region = "us-east-1",
                    AWSException = "ResourceNotFoundException",
                    AWSExceptionMessage = "Requested resource not found",
                    HttpStatusCode = 400
                };
                foreach (var value in task.Result)
                {
                    if (!value.Equals("Exit"))
                    {
                        try
                        {
                            testUtils.Validate(JsonConvert.DeserializeObject<MonitoringAPICallEvent>(value));
                        }
                        catch (Exception e)
                        {
                            testUtils.Validate(JsonConvert.DeserializeObject<MonitoringAPICallAttempt>(value));
                        }
                    }
                    else
                    {
                        break;
                    }
                }
            }
        }

        private List<string> UDPListener()
        {
            List<string> stash = new List<string>();
            using (var udpClient = new UdpClient())
            {
                udpClient.Client.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);
                udpClient.Client.Bind(new IPEndPoint(IPAddress.Any, 31000));
                IPEndPoint RemoteIpEndPoint = new IPEndPoint(IPAddress.Any, 0);
                do
                {
                    stash.Add(Encoding.UTF8.GetString(udpClient.Receive(ref RemoteIpEndPoint)));
                }
                while (!stash.Last().Equals("Exit"));
            }
            return stash;
        }
    }
}
