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
    public class S3ExpiresUnmarshallTest
    {
        [DataRow("2034-01-01T00:00:00Z", true)]
        [DataRow("2023-11-02 08:43:04 -0400", true)]
        [DataRow("Invalid Date", false)]
        [DataRow("access plus 1 month", false)]
        [DataRow("2023-10-12 23:00:00 UTC", false)]
        [DataRow("Thu, 01 Jan 1970 00:00:00 UTC", false)]
        [DataRow("Tue, 15 Apr 2014 07:17:09 UTC", false)]
        [DataRow("10/21/2018", true)]
        [DataRow("Expires: Thu, 9 Sep 2013 14:19:41 GMT", false)]
        [DataRow("01 dec 2100", true)]
        [DataRow("Sun, 31 Aug 2031 20:56:53 GMT+00:00", false)]
        [DataRow("Sun, 22 Oct 23 00:45:02 UTC", false)]
        [DataRow("access plus 1 month", false)]
        [DataRow("{ts '2023-10-10 09:27:14'}", false)]
        [DataRow("Tue, 01 Jan 2014 12:00:00 GMT", false)]
        [DataRow("Sat, 10 Jan 2049 00:00:00 GMT", false)]
        [DataRow("Thu, 31 Dec 2057 23:55:55 GMT", false)]
        [DataTestMethod]
        [TestCategory("S3")]
        public void GetObjectMetadataUnmarshallHandleInvalidDates(string expiresValue, bool isValidDate)
        {
            var responseData = new WebResponseData()
            {
                Headers = new Dictionary<string, string>
                {
                    { "Expires", expiresValue },
                    { "x-amzn-RequestId", "test-request-id" }
                }
            };

            var context = new XmlUnmarshallerContext(new MemoryStream(), false, responseData);
            var response = (GetObjectMetadataResponse)
                GetObjectMetadataResponseUnmarshaller.Instance.UnmarshallResponse(context);

            Assert.AreEqual(response.ExpiresString, expiresValue);
        }
    }
}
