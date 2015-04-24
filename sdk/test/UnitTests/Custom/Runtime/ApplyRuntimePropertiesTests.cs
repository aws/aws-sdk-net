using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Amazon.Runtime;
using System.IO;
using AWSSDK_DotNet35.UnitTests;
using Amazon.S3.Model;
using Amazon.S3.Model.Internal.MarshallTransformations;
using Amazon.Runtime.Internal.Util;
using System.Threading;
using System.Net;
using Amazon.S3;
using Amazon;
using Amazon.Util.Internal;

namespace AWSSDK.UnitTests.Runtime
{
    [TestClass]
    public class ApplyRuntimePropertiesTests
    {
        [TestMethod]
        public void SetHttpVerb()
        {
            var request = new GetPreSignedUrlRequest();
            var values = new Dictionary<string, object> { { "Verb", "DELETE" } };

            InternalSDKUtils.ApplyValues(request, values);

            Assert.AreEqual(request.Verb, HttpVerb.DELETE);
        }

        [TestMethod]
        public void SetAutoCloseStream()
        {
            var request = new PutObjectRequest();
            var values = new Dictionary<string, object> { { "AutoCloseStream", false } };

            InternalSDKUtils.ApplyValues(request, values);

            Assert.AreEqual(request.AutoCloseStream, false);

            request = new PutObjectRequest();
            values = new Dictionary<string, object> { { "AutoCloseStream", true } };

            InternalSDKUtils.ApplyValues(request, values);

            Assert.AreEqual(request.AutoCloseStream, true);
        }
    }
}
