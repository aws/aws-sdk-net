using Amazon.DynamoDBv2.Model;
using Amazon.DynamoDBv2.Model.Internal.MarshallTransformations;
using Amazon.Runtime.Internal.Transform;
using AWSSDK_DotNet.UnitTests.TestTools;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using System.Net;
using System.Text;

namespace AWSSDK_DotNet.UnitTests
{
    [TestClass]
    public class ErrorMarshallerTests
    {
        /// <summary>
        /// Reported in https://github.com/aws/aws-sdk-net/issues/3764
        /// </summary>
        [TestMethod]
        [TestCategory("DynamoDBv2")]
        public void ErrorMarshaller_IgnoresNestedPropertiesForException() 
        {
            var content = @"{
                ""__type"": ""com.amazonaws.dynamodb.v20120810#ConditionalCheckFailedException"",
                ""Item"": {
                    ""Dictionary"": {
                        ""M"": {
                            ""keyThatEndsWithCode"": {
                                ""M"": {
                                    ""Foo"": {
                                        ""S"": ""bar""
                                    }
                                }
                            }
                        }
                    },
                    ""Key"": {
                        ""S"": ""Key""
                    }
                },
                ""Message"": ""The conditional request failed""
            }";

            var webResponseData = new WebResponseData();
            webResponseData.StatusCode = HttpStatusCode.BadRequest;
            webResponseData.Headers["Content-Type"] = "application/x-amz-json-1.0";

            var stream = new MemoryStream(Encoding.ASCII.GetBytes(content));
            var context = new JsonUnmarshallerContext(stream, true, webResponseData);
            
            var response = new PutItemResponseUnmarshaller().UnmarshallException(context, null, HttpStatusCode.BadRequest);
            var actualException = response as ConditionalCheckFailedException;
            Assert.IsNotNull(actualException);
            
            Assert.IsNotNull(actualException.Item);
            Assert.AreEqual(2, actualException.Item.Count);
            Assert.IsNotNull(actualException.Item["Dictionary"].M["keyThatEndsWithCode"]);
            Assert.IsNotNull(actualException.Item["Key"].S);
        }
    }
}
