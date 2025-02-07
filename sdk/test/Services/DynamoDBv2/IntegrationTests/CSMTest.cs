using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Amazon.DynamoDBv2;
using Amazon.DynamoDBv2.DataModel;
using Amazon.DynamoDBv2.DocumentModel;
using Amazon.DynamoDBv2.Model;
using Amazon.Util;
using AWSSDK_DotNet.IntegrationTests.Utils;

namespace AWSSDK_DotNet.IntegrationTests.Tests
{
    public class CSMTest
    {
        [TestMethod]
        [TestCategory("DynamoDBv2")]
        [TestCategory("CSM")]
        public void SingleSuccessfulAttempt()
        {
            AmazonDynamoDBClient client = new AmazonDynamoDBClient(Amazon.RegionEndpoint.USEast1);
            client.CreateTable(new CreateTableRequest {
                TableName = "SampleTable"
            });
            // Define item attributes
            Dictionary<string, AttributeValue> attributes = new Dictionary<string, AttributeValue>();
            // Author is hash-key
            attributes["Author"] = new AttributeValue { S = "Mark Twain" };
            // Title is range-key
            attributes["Title"] = new AttributeValue { S = "The Adventures of Tom Sawyer" };
            // Other attributes
            attributes["Year"] = new AttributeValue { N = "1876" };
            attributes["Setting"] = new AttributeValue { S = "Missouri" };
            attributes["Pages"] = new AttributeValue { N = "275" };
            attributes["Genres"] = new AttributeValue
            {
                SS = new List<string> { "Satire", "Folk", "Children's Novel" }
            };

            // Create PutItem request
            PutItemRequest request = new PutItemRequest
            {
                TableName = "SampleTable",
                Item = attributes
            };

            // Issue PutItem request
            client.PutItem(request);
        }
    }
}
