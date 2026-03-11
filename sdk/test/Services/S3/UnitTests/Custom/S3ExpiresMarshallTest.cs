using System;
using System.IO;
using System.Collections.Generic;
using Amazon.Runtime.Internal.Transform;
using Amazon.S3.Model;
using Amazon.S3.Model.Internal.MarshallTransformations;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AWSSDK_DotNet.UnitTests.TestTools;

namespace AWSSDK.UnitTests
{
    [TestClass]
    public class S3ExpiresMarshallTest
    {
        [TestMethod]
        [TestCategory("S3")]
        public void GetObjectRequest_ResponseExpires_Set()
        {
            var date1 = DateTime.UtcNow.AddHours(1);
            var request = new GetObjectRequest
            {
                BucketName = "example-bucket",
                Key = "example-key",
                ResponseExpires = date1
            };

            var marshalledRequest = 
                GetObjectRequestMarshaller.Instance.Marshall(request);
            var marshalledResponseExpires = marshalledRequest.Parameters["response-expires"];
            Assert.AreEqual(S3Transforms.ToStringValue(date1), marshalledResponseExpires);
        }

        [TestMethod]
        [TestCategory("S3")]
        public void GetObjectRequest_ResponseHeadersOverrides_Expires_Set()
        {
            var date1 = DateTime.UtcNow.AddHours(1);
            var request = new GetObjectRequest
            {
                BucketName = "example-bucket",
                Key = "example-key",
                ResponseHeaderOverrides = new ResponseHeaderOverrides
                {
                    Expires = S3Transforms.ToStringValue(date1)
                }
            };

            var marshalledRequest =
                GetObjectRequestMarshaller.Instance.Marshall(request);
            var marshalledResponseExpires = marshalledRequest.Parameters["response-expires"];
            Assert.AreEqual(S3Transforms.ToStringValue(date1), marshalledResponseExpires);
        }

        [TestMethod]
        [TestCategory("S3")]
        public void GetObjectRequest_ResponseExpiresAndResponseHeadersOverrides_Set()
        {
            var date1 = DateTime.UtcNow.AddHours(1);
            var date2 = DateTime.UtcNow.AddHours(2);
            var request = new GetObjectRequest
            {
                BucketName = "example-bucket",
                Key = "example-key",
                ResponseExpires = date1,
                ResponseHeaderOverrides = new ResponseHeaderOverrides
                {
                    Expires = S3Transforms.ToStringValue(date2)
                }
            };

            var marshalledRequest =
                GetObjectRequestMarshaller.Instance.Marshall(request);
            var marshalledResponseExpires = marshalledRequest.Parameters["response-expires"];
            Assert.AreEqual(S3Transforms.ToStringValue(date1), marshalledResponseExpires);
        }
    }
}
