using Amazon.Runtime.Internal.Transform;
using Amazon.S3.Model;
using Amazon.S3.Model.Internal.MarshallTransformations;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using AWSSDK_DotNet.UnitTests.TestTools;
using System.IO;
using Amazon;
using Amazon.S3.Transfer;

namespace AWSSDK.UnitTests
{
    [TestClass]
    public class S3MetadataTest
    {

        [DataRow("bucket", "key", "metadata", "test", "test")]
        [DataRow("bucket", "key", "metadata", "£", "%C2%A3")]
        [DataRow("bucket", "key", "metadata", "no non ascii characters %", "no non ascii characters %")]
        [DataRow("bucket", "key", "metadata", "1 non ascii character £ %", "1 non ascii character %C2%A3 %")]
        [DataTestMethod]
        [TestCategory("S3")]
        public void PutObjectWithMetadataTest(string bucket, string key, string metadataKey,
            string metadataValue, string escapedMetadataValue)
        {
            AWSConfigsS3.EnableUnicodeEncodingForObjectMetadata = true;
            var metadataKeyHeader = $"x-amz-meta-{metadataKey}";
            var request = new PutObjectRequest() { BucketName = bucket, Key = key };
            request.Metadata.Add(metadataKey, metadataValue);
            var marshalledRequest = PutObjectRequestMarshaller.Instance.Marshall(request);
            Assert.AreEqual(marshalledRequest.Headers[metadataKeyHeader], escapedMetadataValue);
            AWSConfigsS3.EnableUnicodeEncodingForObjectMetadata = false;
        }

        [DataRow("metadata", "test", "test")]
        [DataRow("metadata", "£", "%C2%A3")]
        [DataRow("metadata", "no non ascii characters %", "no non ascii characters %")]
        [DataRow("metadata", "1 non ascii character £ %", "1 non ascii character %C2%A3 %")]
        [DataTestMethod]
        [TestCategory("S3")]
        public void GetObjectMetadataUnmarshallerTest(string metadataKey, 
            string metadataValue, string escapedMetadataValue)
        {
            AWSConfigsS3.EnableUnicodeEncodingForObjectMetadata = true;
            var metadataKeyHeader = $"x-amz-meta-{metadataKey}";
            var responseData = new WebResponseData()
            {
                Headers = new Dictionary<string, string> 
                {
                    { metadataKeyHeader, escapedMetadataValue }
                }
            };
            var context = new XmlUnmarshallerContext(new MemoryStream(), false, responseData);
            var response = (GetObjectMetadataResponse) 
                GetObjectMetadataResponseUnmarshaller.Instance.Unmarshall(context);
            Assert.AreEqual(response.Metadata[metadataKeyHeader], metadataValue);
            AWSConfigsS3.EnableUnicodeEncodingForObjectMetadata = false;
        }

        [TestMethod]
        [TestCategory("S3")]
        public void MetadataCollectionClearTest()
        {
            TransferUtilityUploadRequest uploadRequest = new TransferUtilityUploadRequest();

            uploadRequest.Metadata.Add("dummymetadata", "dummyvalue");
            uploadRequest.Metadata.Add("x-amz-meta-explicitmetadata", "value-explicitmetadata");
            Assert.AreEqual(2, uploadRequest.Metadata.Count);

            uploadRequest.Metadata.Clear();
            Assert.AreEqual(0, uploadRequest.Metadata.Count);
        }
    }
}
