using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using AWSSDK_DotNet.IntegrationTests.Utils;

using Amazon.AWSSupport;
using Amazon.AWSSupport.Model;
using Amazon;
using System.IO;
using System.Text;
using Amazon.APIGateway.Model;
using Amazon.APIGateway;

namespace AWSSDK_DotNet.IntegrationTests.Tests
{
    [TestClass]
    public class APIGatewayTests : TestBase<Amazon.APIGateway.AmazonAPIGatewayClient>
    {
        [ClassCleanup]
        public static void ClassCleanup()
        {
            if (!string.IsNullOrEmpty(restApiId))
            {
                Client.DeleteRestApi(new DeleteRestApiRequest
                {
                    RestApiId = restApiId
                });
            }

            BaseClean();
        }

        private static string restApiId = null;
        private static string timestamp = DateTime.Now.ToFileTime().ToString();
        private static string apiName = "dotnet-test-" + timestamp;
        private static string apiDescription = "RestApi created by dotnet tests at " + timestamp;

        [ClassInitialize]
        public static void ClassInitialize(TestContext testContext)
        {
            var createRestApi = Client.CreateRestApi(new CreateRestApiRequest
            {
                Name = apiName,
                Description = apiDescription                    
            });
            Assert.AreEqual(apiDescription, createRestApi.Description);
            Assert.AreEqual(apiName, createRestApi.Name);
            Assert.IsFalse(string.IsNullOrEmpty(createRestApi.Id));
            Assert.AreNotEqual(default(DateTime), createRestApi.CreatedDate);
            restApiId = createRestApi.Id;
        }

        [TestMethod]
        [TestCategory("APIGateWay")]
        public void TestResources()
        {
            var allResources = GetResources().ToList();
            var rootResource = allResources.SingleOrDefault(r => r.ParentId == null);
            Assert.IsNotNull(rootResource);

            var pathPart = "test";
            var resourceId = Client.CreateResource(new CreateResourceRequest
            {
                RestApiId = restApiId,
                ParentId = rootResource.Id,
                PathPart = pathPart
            }).Id;

            var resources = GetResources().ToList();
            var resource = resources.Single(r => r.Id == resourceId);
            Assert.AreEqual(pathPart, resource.PathPart);
            Assert.AreEqual(rootResource.Path + pathPart, resource.Path);
            Assert.AreEqual(2, resources.Count);

            Client.PutMethod(new PutMethodRequest
            {
                RestApiId = restApiId,
                ResourceId = resourceId,
                AuthorizationType = "AWS_IAM",
                HttpMethod = "PUT"
            });

            Client.PutIntegration(new PutIntegrationRequest 
            {
                RestApiId = restApiId,
                ResourceId = resourceId,
                HttpMethod = "PUT",
                Type = IntegrationType.MOCK,
                Uri = "http://foo.bar",
                IntegrationHttpMethod = "GET"
            });
        }

        private IEnumerable<Resource> GetResources()
        {
            var request = new GetResourcesRequest
            {
                RestApiId = restApiId
            };
            do
            {
                var response = Client.GetResources(request);
                request.Position = response.Position;

                foreach (var r in response.Items)
                    yield return r;

            } while (!string.IsNullOrEmpty(request.Position));
        }

        [TestMethod]
        [TestCategory("APIGateWay")]
        public void TestRestApiCalls()
        {
            var apis = GetRestApis().ToList();
            var api = apis.Single(r => string.Equals(r.Id, restApiId));
            Assert.IsNotNull(api);

            AssertExtensions.ExpectException(() => Client.GetRestApi(new GetRestApiRequest
            {
                RestApiId = "fakeid"
            }));

            var getRestApi = Client.GetRestApi(new GetRestApiRequest
            {
                RestApiId = restApiId
            });
            Assert.AreEqual(apiDescription, getRestApi.Description);
            Assert.AreEqual(apiName, getRestApi.Name);
            Assert.IsFalse(string.IsNullOrEmpty(getRestApi.Id));
            Assert.AreNotEqual(default(DateTime), getRestApi.CreatedDate);

            var newDescription = "New description!";
            Client.UpdateRestApi(new UpdateRestApiRequest
            {
                RestApiId = restApiId,
                PatchOperations = new List<PatchOperation>
                {
                    new PatchOperation
                    {
                        Op = Op.Replace,
                        Path = "/description",
                        Value = newDescription
                    }
                }
            });

            getRestApi = Client.GetRestApi(new GetRestApiRequest
            {
                RestApiId = restApiId
            });
            Assert.AreEqual(newDescription, getRestApi.Description);
            Assert.AreEqual(apiName, getRestApi.Name);
            Assert.IsFalse(string.IsNullOrEmpty(getRestApi.Id));
            Assert.AreNotEqual(default(DateTime), getRestApi.CreatedDate);

            Client.UpdateRestApi(new UpdateRestApiRequest
            {
                RestApiId = restApiId,
                PatchOperations = new List<PatchOperation>
                {
                    new PatchOperation
                    {
                        Op = Op.Replace,
                        Path = "/description",
                        Value = apiDescription
                    }
                }
            });
        }

        private IEnumerable<RestApi> GetRestApis()
        {
            var request = new GetRestApisRequest { Limit = 1 };
            do
            {
                var response = Client.GetRestApis(request);
                request.Position = response.Position;
                foreach (var r in response.Items)
                    yield return r;
            } while (!string.IsNullOrEmpty(request.Position));
        }

        [TestMethod]
        [TestCategory("APIGateWay")]
        public void TestOtherOperations()
        {
            var account = Client.GetAccount(new GetAccountRequest());
            Assert.IsNotNull(account);
            Assert.IsNotNull(account.ThrottleSettings);
            Assert.AreNotEqual(0, account.ThrottleSettings.BurstLimit);
            Assert.AreNotEqual(0, account.ThrottleSettings.RateLimit);

            var allCerts = GetAllCerts().ToList();

            var certDescription = "something";
            var clientCert = Client.GenerateClientCertificate(new GenerateClientCertificateRequest
            {
                Description = certDescription
            });
            Assert.IsNotNull(clientCert);
            Assert.AreEqual(certDescription, clientCert.Description);
            Assert.AreNotEqual(default(DateTime), clientCert.CreatedDate);
            Assert.AreNotEqual(default(DateTime), clientCert.ExpirationDate);
            Assert.IsTrue(clientCert.ExpirationDate > clientCert.CreatedDate);
            Assert.IsFalse(string.IsNullOrEmpty(clientCert.PemEncodedCertificate));
            Assert.IsFalse(string.IsNullOrEmpty(clientCert.ClientCertificateId));

            var updatedCerts = GetAllCerts().ToList();
            Assert.AreNotEqual(allCerts.Count, updatedCerts.Count);

            Client.DeleteClientCertificate(new DeleteClientCertificateRequest
            {
                ClientCertificateId = clientCert.ClientCertificateId
            });
        }

        private static IEnumerable<ClientCertificate> GetAllCerts()
        {
            var request = new GetClientCertificatesRequest();
            do
            {
                var response = Client.GetClientCertificates(request);
                request.Position = response.Position;
                foreach (var cert in response.Items)
                    yield return cert;
            } while (!string.IsNullOrEmpty(request.Position));
        }
    }
}
