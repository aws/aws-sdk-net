using System;
using System.Linq;

using Microsoft.VisualStudio.TestTools.UnitTesting;
using Amazon.S3;
using AWSSDK_DotNet.IntegrationTests.Utils;
using Amazon;
using Amazon.Runtime;
using System.Collections.Generic;
using System.Reflection;
using Amazon.Runtime.Internal.Auth;
using System.Configuration;
using System.Collections.Specialized;
using System.Xml;
using System.IO;
using System.Text.Json;
using System.Text;


namespace AWSSDK_DotNet.IntegrationTests.Tests
{
    [TestClass]
    public class TestsNetFramework
    {
        [TestMethod]
        [TestCategory("General")]
        public void TestResponseMockingLots()
        {
            var count = 1000;
            for(int i=0;i<count;i++)
            {
                Console.WriteLine("Test {0}", i + 1);
                TestResponseMocking();
            }
        }

        [TestMethod]
        [TestCategory("General")]
        public void TestResponseMocking()
        {
            var rawResponse = @"HTTP/1.1 200 OK
x-amzn-RequestId: 1111111111111111111111111111111111111111111111111111
x-amz-crc32: 3108219267
Content-Type: application/x-amz-json-1.0
Content-Length: 110
Date: Tue, 28 Jul 2015 23:51:35 GMT

{""TableNames"":[""DotNetTests-HashRangeTable"",""DotNetTests-HashTable"",""Events""]}";
            var rawErrorResponse = @"HTTP/1.1 400 Bad Request
x-amzn-RequestId: 2222222222222222222222222222222222222222222222222222
x-amz-crc32: 4224273561
Content-Type: application/x-amz-json-1.0
Content-Length: 140
Date: Tue, 28 Jul 2015 23:51:34 GMT

{""__type"":""com.amazonaws.dynamodb.v20120810#ResourceNotFoundException"",""message"":""Requested resource not found: Table: FakeTable not found""}";

            using (var client = new Amazon.DynamoDBv2.AmazonDynamoDBClient())
            {
                // create mocker and hook it up to a client
                var mocker = new Mocker();
                mocker.AddToClient(client);

                // use raw response
                mocker.RawResponse = rawResponse;

                // make calls and verify data is as expected
                var response = client.ListTables();
                Assert.IsNotNull(response);
                Assert.IsNotNull(response.TableNames);
                Assert.AreEqual(3, response.TableNames.Count);
                Assert.IsNotNull(response.ResponseMetadata);
                Assert.IsNotNull(response.ResponseMetadata.RequestId);
                Assert.AreEqual("1111111111111111111111111111111111111111111111111111", response.ResponseMetadata.RequestId);

                // clear raw response
                mocker.RawResponse = string.Empty;
                // set callback
                mocker.CreateResponseCallback = (httpRequest) =>
                {
                    // create HttpResponse (in this case, from the raw response, but can be created manually)
                    var httpResponse = Mocker.CreateHttpResponse(rawResponse);

                    // modify headers
                    httpResponse.Headers["x-amzn-RequestId"] = "foo!";
                    httpResponse.Headers.Remove("x-amz-crc32");

                    // modify body
                    using (var memoryStream = new MemoryStream())
                    using (var writer = new Utf8JsonWriter(memoryStream))
                    {
                        writer.WriteStartObject();
                        writer.WritePropertyName("TableNames");
                        writer.WriteStartArray();
                        writer.WriteStringValue("Logs"); // Add a new table name
                        writer.WriteEndArray();
                        writer.WriteEndObject();
                        writer.Flush();
                        var newBody = Encoding.UTF8.GetString(memoryStream.ToArray());
                        httpResponse.Body = newBody;
                    }

                    return httpResponse;
                };

                // make calls and verify data is as expected
                response = client.ListTables();
                Assert.IsNotNull(response);
                Assert.IsNotNull(response.TableNames);
                Assert.AreEqual(1, response.TableNames.Count);
                Assert.AreEqual("Logs", response.TableNames[0]);
                Assert.IsNotNull(response.ResponseMetadata);
                Assert.IsNotNull(response.ResponseMetadata.RequestId);
                Assert.AreEqual("foo!", response.ResponseMetadata.RequestId);

                // clear callback
                mocker.CreateResponseCallback = null;
                // set raw response to error response
                mocker.RawResponse = rawErrorResponse;

                // make call and verify exception is thrown
                var exception = AssertExtensions.ExpectException<Amazon.DynamoDBv2.Model.ResourceNotFoundException>(() => client.DescribeTable("foo"));
                Assert.IsNotNull(exception);
                Assert.IsNotNull(exception.Message);
                Assert.AreEqual("Requested resource not found: Table: FakeTable not found", exception.Message);
                Assert.AreEqual("2222222222222222222222222222222222222222222222222222", exception.RequestId);
            }
        }
    }
}
