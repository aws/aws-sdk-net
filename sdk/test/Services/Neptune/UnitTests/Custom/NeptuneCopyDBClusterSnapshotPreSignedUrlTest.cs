﻿using System;
using Amazon.Neptune;
using Amazon.Neptune.Model;
using Amazon.Neptune.Model.Internal.MarshallTransformations;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Amazon.Neptune.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using AWSSDK_DotNet.CommonTest.Utils;
using Amazon;
using Amazon.Runtime.Internal.Auth;
using System.Reflection;
using AWSSDK_DotNet35.UnitTests.TestTools;

namespace AWSSDK.UnitTests
{
    [TestClass]
    public class NeptuneCopyDBClusterSnapshotPreSignedUrlTest
    {
        private static readonly RegionEndpoint clientRegion = RegionEndpoint.USWest2;
        private static readonly string accessKey = "akid";
        private static readonly string secretKey = "secret";
        private static readonly string sourceRegion = "us-east-1";
        private static readonly string kmsKeyId = "238f8ec9-420a-0690-8ec9-009f34fc3ef5";
        private static readonly string sourceDBClusterSnapshotIdentifier = "arn:aws:rds:us-east-1:123456789012:cluster-snapshot:source-db-cluster-snapshot";
        private static readonly string targetDBClusterSnapshotIdentifier = "target-db-cluster-snapshot";
        private static readonly DateTime fixedSigningDate = new DateTime(2020, 8, 27, 0, 0, 0, DateTimeKind.Utc);

        [TestMethod]
        [TestCategory("Neptune")]
        public void HandleNonPreSignedUrlRequest()
        {
            DateFaker.Run(fixedSigningDate, () =>
            {
                var request = new CopyDBClusterSnapshotRequest
                {
                    KmsKeyId = kmsKeyId,
                    SourceDBClusterSnapshotIdentifier = sourceDBClusterSnapshotIdentifier,
                    TargetDBClusterSnapshotIdentifier = targetDBClusterSnapshotIdentifier
                };

                RunPreInvoke(request);
                Assert.IsNull(request.PreSignedUrl);
            });
        }

        [TestMethod]
        [TestCategory("Neptune")]
        public void HandlePreSignedUrlRequestNoSourceRegion()
        {
            DateFaker.Run(fixedSigningDate, () =>
            {
                var request = new CopyDBClusterSnapshotRequest
                {
                    KmsKeyId = kmsKeyId,
                    SourceDBClusterSnapshotIdentifier = sourceDBClusterSnapshotIdentifier,
                    TargetDBClusterSnapshotIdentifier = targetDBClusterSnapshotIdentifier,
                    PreSignedUrl = "https://aws.com"
                };

                RunPreInvoke(request);
                Assert.AreEqual("https://aws.com", request.PreSignedUrl);
            });
        }

        [TestMethod]
        [TestCategory("Neptune")]
        public void HandlePreSignedUrlRequest()
        {
            DateFaker.Run(fixedSigningDate, () =>
            {
                var request = new CopyDBClusterSnapshotRequest
                {
                    KmsKeyId = kmsKeyId,
                    SourceDBClusterSnapshotIdentifier = sourceDBClusterSnapshotIdentifier,
                    TargetDBClusterSnapshotIdentifier = targetDBClusterSnapshotIdentifier,
                    SourceRegion = sourceRegion
                };

                RunPreInvoke(request);

                Assert.IsNotNull(request.PreSignedUrl);
                Assert.IsTrue(request.PreSignedUrl.Contains("Signature=01eda84cb84ff1558373f4759aaf76aa4b7be8664241a58f6906ae842a0a9d74"));
            });
        }

        private void RunPreInvoke(AmazonWebServiceRequest request)
        {
            var credentials = new BasicAWSCredentials(accessKey, secretKey);
            var handler = new PreSignedUrlRequestHandler(credentials);
            var requestContext = new RequestContext(false, new NullSigner());
            var responseContext = new ResponseContext();
            var executionContext = new ExecutionContext(requestContext, responseContext);
            var marshaller = new CopyDBClusterSnapshotRequestMarshaller();
            var clientConfig = new AmazonNeptuneConfig();

            clientConfig.RegionEndpoint = clientRegion;
            requestContext.OriginalRequest = request;
            requestContext.Marshaller = marshaller;
            requestContext.ClientConfig = clientConfig;

            ReflectionHelpers.Invoke(handler, "PreInvoke", executionContext);
        }
    }
}
