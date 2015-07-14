using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using AWSSDK_DotNet.IntegrationTests.Utils;
using Amazon.DynamoDBv2;
using Amazon.DynamoDBv2.Model;
using Amazon.DynamoDBv2.DocumentModel;
using System.IO;
using ThirdParty.Json.LitJson;
using System.Xml;


namespace AWSSDK_DotNet.IntegrationTests.Tests.DynamoDB
{
    [TestClass]
    public partial class DynamoDBStreamsTests : TestBase<AmazonDynamoDBStreamsClient>
    {
        [TestMethod]
        [TestCategory("DynamoDBStreams")]
        public void TestDescribeStreams()
        {
            Client.ListStreams(new ListStreamsRequest
            {

            });
        }
    }
}
