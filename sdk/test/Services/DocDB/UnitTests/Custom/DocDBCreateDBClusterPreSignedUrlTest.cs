using Amazon;
using Amazon.DocDB;
using Amazon.DocDB.Internal;
using Amazon.DocDB.Model;
using Amazon.DocDB.Model.Internal.MarshallTransformations;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using AWSSDK_DotNet.CommonTest.Utils;
using AWSSDK_DotNet.UnitTests.TestTools;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace AWSSDK.UnitTests
{
    /// <summary>
    /// This test doesn't test the correctness of the PreSignedUrl.
    /// It only tests that PreSignedUrlRequestHandler fills in the PresignedUrlProperty
    /// when it should, and passes requests through untouched when it should.
    /// Correctness will be tested when each individual use case is added.
    /// i.e. When we real request classes are made to implement IPreSignedUrlRequest.
    /// </summary>
    [TestClass]
    public class DocDBCreateDBClusterPreSignedUrlTest
    {
        private static readonly RegionEndpoint clientRegion = RegionEndpoint.USWest2;
        private static readonly string accessKey = "akid";
        private static readonly string secretKey = "secret";
        private static readonly string sourceRegion = "us-east-1";
        private static readonly string kmsKeyId = "238f8ec9-420a-0690-8ec9-009f34fc3ef5";
        private static readonly string dBClusterIdentifier = "db-cluster";
        private static readonly string engine = "aurora";
        private static readonly bool storageEncrypted = true;
        private static readonly string masterUsername = "username";
        private static readonly string masterPassword = "password";
        private static readonly DateTime fixedSigningDate = new DateTime(2020, 8, 27, 0, 0, 0, DateTimeKind.Utc);

        [TestMethod]
        [TestCategory("DocDB")]
        public void HandleNonPreSignedUrlRequest()
        {
            DateFaker.Run(fixedSigningDate, () =>
            {
                var request = new CreateDBClusterRequest
                {
                    KmsKeyId = kmsKeyId,
                    DBClusterIdentifier = dBClusterIdentifier,
                    Engine = engine,
                    StorageEncrypted = storageEncrypted,
                    MasterUsername = masterUsername,
                    MasterUserPassword = masterPassword
                };

                RunPreInvoke(request);
                Assert.IsNull(request.PreSignedUrl);
            });
        }

        [TestMethod]
        [TestCategory("DocDB")]
        public void HandlePreSignedUrlRequestNoSourceRegion()
        {
            DateFaker.Run(fixedSigningDate, () =>
            {
                var request = new CreateDBClusterRequest
                {
                    KmsKeyId = kmsKeyId,
                    DBClusterIdentifier = dBClusterIdentifier,
                    Engine = engine,
                    StorageEncrypted = storageEncrypted,
                    MasterUsername = masterUsername,
                    MasterUserPassword = masterPassword,
                    PreSignedUrl = "https://aws.com"
                };

                RunPreInvoke(request);
                Assert.AreEqual("https://aws.com", request.PreSignedUrl);
            });
        }

        [TestMethod]
        [TestCategory("DocDB")]
        public void HandlePreSignedUrlRequest()
        {
            DateFaker.Run(fixedSigningDate, () =>
            {
                var request = new CreateDBClusterRequest
                {
                    KmsKeyId = kmsKeyId,
                    DBClusterIdentifier = dBClusterIdentifier,
                    Engine = engine,
                    StorageEncrypted = storageEncrypted,
                    MasterUsername = masterUsername,
                    MasterUserPassword = masterPassword,
                    SourceRegion = sourceRegion
                };

                RunPreInvoke(request);

                Assert.IsNotNull(request.PreSignedUrl);
                Assert.IsTrue(request.PreSignedUrl.Contains("Signature=015e49149a19b1f97a40e472ac8f6da55fb559c86834a3664a279fab99063e44"));
            });
        }

        private void RunPreInvoke(AmazonWebServiceRequest request)
        {
            var credentials = new BasicAWSCredentials(accessKey, secretKey);
            var handler = new PreSignedUrlRequestHandler(credentials);
            var requestContext = new RequestContext(false, new NullSigner());
            var responseContext = new ResponseContext();
            var executionContext = new ExecutionContext(requestContext, responseContext);
            var marshaller = new CreateDBClusterRequestMarshaller();
            var clientConfig = new AmazonDocDBConfig();

            clientConfig.RegionEndpoint = clientRegion;
            requestContext.OriginalRequest = request;
            requestContext.Marshaller = marshaller;
            requestContext.ClientConfig = clientConfig;

            ReflectionHelpers.Invoke(handler, "PreInvoke", executionContext);
        }
    }
}
