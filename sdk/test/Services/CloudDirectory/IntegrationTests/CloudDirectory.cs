using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Amazon;
using Amazon.ECR;
using Amazon.ECR.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Amazon.CloudDirectory;
using Amazon.CloudDirectory.Model;
using AWSSDK_DotNet.CommonTest.Utils;

namespace AWSSDK_DotNet.IntegrationTests.Tests
{
    [TestClass]
    public class CloudDirectory : TestBase<AmazonCloudDirectoryClient>
    {
        private const string ListObjectAttributesResponse = @"{""Attributes"":[{""Key"":{""FacetName"":""Person"",""Name"":""username"",""SchemaArn"":""arn:aws:clouddirectory:us-east-1:123456789012:directory/AQPCHP0oaUPOoPHKMr1kMTs/schema/person/1""},""Value"":{""BinaryValue"":null,""BooleanValue"":null,""DatetimeValue"":null,""NumberValue"":null,""StringValue"":""bob""}}],""NextToken"":null}";

        [TestMethod]
        [TestCategory("CloudDirectory")]
        public void TestAttributes()
        {
            using(var servlet = new ResponseTestServlet())
            {
                servlet.Response = ListObjectAttributesResponse;

                var config = new AmazonCloudDirectoryConfig { ServiceURL = servlet.ServiceURL };
                using(var client = new AmazonCloudDirectoryClient(config))
                {
                    var response = client.ListObjectAttributes(new ListObjectAttributesRequest());

                    var attribute = response.Attributes.SingleOrDefault();
                    Assert.IsNotNull(attribute);

                    var key = attribute.Key;
                    Assert.IsNotNull(key);

                    Assert.AreEqual("Person", key.FacetName);
                    Assert.AreEqual("username", key.Name);
                    Assert.AreEqual("arn:aws:clouddirectory:us-east-1:123456789012:directory/AQPCHP0oaUPOoPHKMr1kMTs/schema/person/1", key.SchemaArn);

                    var value = attribute.Value;
                    Assert.IsNotNull(value);

                    Assert.IsNull(value.BinaryValue);
                    Assert.IsFalse(value.BooleanValue);
                    Assert.AreEqual(default(DateTime), value.DatetimeValue);
                    Assert.IsNull(value.NumberValue);
                    Assert.AreEqual("bob", value.StringValue);
                }
            }
        }
    }
}
