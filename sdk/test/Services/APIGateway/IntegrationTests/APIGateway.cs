using Amazon.APIGateway;
using Amazon.APIGateway.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AWSSDK_DotNet.IntegrationTests.Tests
{
    [TestClass]
    [TestCategory("APIGateway")]
    public class APIGatewayTests : TestBase<AmazonAPIGatewayClient>
    {
        [ClassCleanup]
        public static async Task ClassCleanup()
        {
            if (!string.IsNullOrEmpty(restApiId))
            {
                await Client.DeleteRestApiAsync(new DeleteRestApiRequest
                {
                    RestApiId = restApiId
                });
            }

            BaseClean();
        }

        private static string restApiId = null;
        private static string timestamp = DateTime.UtcNow.ToFileTime().ToString();
        private static string apiName = "dotnet-test-" + timestamp;
        private static string apiDescription = "RestApi created by dotnet tests at " + timestamp;

        [ClassInitialize]
        public static async Task ClassInitialize(TestContext testContext)
        {
            var createRestApi = await Client.CreateRestApiAsync(new CreateRestApiRequest
            {
                Name = apiName,
                Description = apiDescription
            });
            Assert.AreEqual(apiDescription, createRestApi.Description);
            Assert.AreEqual(apiName, createRestApi.Name);
            Assert.IsFalse(string.IsNullOrEmpty(createRestApi.Id));
            Assert.AreNotEqual(DateTime.SpecifyKind(default, DateTimeKind.Utc), createRestApi.CreatedDate);
            restApiId = createRestApi.Id;
        }

        [TestMethod]
        public async Task TestResources()
        {
            var allResources = (await GetResources()).ToList();
            var rootResource = allResources.SingleOrDefault(r => r.ParentId == null);
            Assert.IsNotNull(rootResource);

            var pathPart = "test";
            var createResponse = await Client.CreateResourceAsync(new CreateResourceRequest
            {
                RestApiId = restApiId,
                ParentId = rootResource.Id,
                PathPart = pathPart
            });

            var resourceId = createResponse.Id;
            var resources = (await GetResources()).ToList();
            var resource = resources.Single(r => r.Id == resourceId);
            Assert.AreEqual(pathPart, resource.PathPart);
            Assert.AreEqual(rootResource.Path + pathPart, resource.Path);
            Assert.AreEqual(2, resources.Count);

            await Client.PutMethodAsync(new PutMethodRequest
            {
                RestApiId = restApiId,
                ResourceId = resourceId,
                AuthorizationType = "AWS_IAM",
                HttpMethod = "PUT"
            });

            await Client.PutIntegrationAsync(new PutIntegrationRequest
            {
                RestApiId = restApiId,
                ResourceId = resourceId,
                HttpMethod = "PUT",
                Type = IntegrationType.MOCK,
                Uri = "http://foo.bar",
                IntegrationHttpMethod = "GET"
            });
        }

        private async Task<IEnumerable<Resource>> GetResources()
        {
            var resources = new List<Resource>();
            var request = new GetResourcesRequest
            {
                RestApiId = restApiId
            };

            do
            {
                var response = await Client.GetResourcesAsync(request);
                request.Position = response.Position;

                if (response.Items != null)
                {
                    foreach (var r in response.Items)
                    {
                        resources.Add(r);
                    }
                }

            } while (!string.IsNullOrEmpty(request.Position));
            return resources;
        }

        [TestMethod]
        public async Task TestRestApiCalls()
        {
            var apis = (await GetRestApis()).ToList();
            var api = apis.Single(r => string.Equals(r.Id, restApiId));
            Assert.IsNotNull(api);

            await Assert.ThrowsExceptionAsync<NotFoundException>(() =>
                Client.GetRestApiAsync(new GetRestApiRequest { RestApiId = "fakeid" })
            );

            var getRestApi = await Client.GetRestApiAsync(new GetRestApiRequest
            {
                RestApiId = restApiId
            });
            Assert.AreEqual(apiDescription, getRestApi.Description);
            Assert.AreEqual(apiName, getRestApi.Name);
            Assert.IsFalse(string.IsNullOrEmpty(getRestApi.Id));
            Assert.AreNotEqual(DateTime.SpecifyKind(default, DateTimeKind.Utc), getRestApi.CreatedDate);

            var newDescription = "New description!";
            await Client.UpdateRestApiAsync(new UpdateRestApiRequest
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

            getRestApi = await Client.GetRestApiAsync(new GetRestApiRequest
            {
                RestApiId = restApiId
            });
            Assert.AreEqual(newDescription, getRestApi.Description);
            Assert.AreEqual(apiName, getRestApi.Name);
            Assert.IsFalse(string.IsNullOrEmpty(getRestApi.Id));
            Assert.AreNotEqual(DateTime.SpecifyKind(default, DateTimeKind.Utc), getRestApi.CreatedDate);

            await Client.UpdateRestApiAsync(new UpdateRestApiRequest
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

        private async Task<IEnumerable<RestApi>> GetRestApis()
        {
            var apis = new List<RestApi>();
            var request = new GetRestApisRequest { Limit = 1 };
            do
            {
                var response = await Client.GetRestApisAsync(request);
                request.Position = response.Position;

                if (response.Items != null)
                {
                    foreach (var r in response.Items)
                    {
                        apis.Add(r);
                    }
                }
            } while (!string.IsNullOrEmpty(request.Position));
            return apis;
        }

        [TestMethod]
        public async Task TestOtherOperations()
        {
            var account = await Client.GetAccountAsync(new GetAccountRequest());
            Assert.IsNotNull(account);
            Assert.IsNotNull(account.ThrottleSettings);
            Assert.AreNotEqual(0, account.ThrottleSettings.BurstLimit);
            Assert.AreNotEqual(0, account.ThrottleSettings.RateLimit);

            var allCerts = (await GetAllCerts()).ToList();
            var certDescription = "something";

            var clientCert = await Client.GenerateClientCertificateAsync(new GenerateClientCertificateRequest
            {
                Description = certDescription
            });
            Assert.IsNotNull(clientCert);
            Assert.AreEqual(certDescription, clientCert.Description);
            Assert.AreNotEqual(DateTime.SpecifyKind(default, DateTimeKind.Utc), clientCert.CreatedDate);
            Assert.AreNotEqual(DateTime.SpecifyKind(default, DateTimeKind.Utc), clientCert.ExpirationDate);
            Assert.IsTrue(clientCert.ExpirationDate > clientCert.CreatedDate);
            Assert.IsFalse(string.IsNullOrEmpty(clientCert.PemEncodedCertificate));
            Assert.IsFalse(string.IsNullOrEmpty(clientCert.ClientCertificateId));

            var updatedCerts = (await GetAllCerts()).ToList();
            Assert.AreNotEqual(allCerts.Count, updatedCerts.Count);

            await Client.DeleteClientCertificateAsync(new DeleteClientCertificateRequest
            {
                ClientCertificateId = clientCert.ClientCertificateId
            });
        }

        private static async Task<IEnumerable<ClientCertificate>> GetAllCerts()
        {
            var certificates = new List<ClientCertificate>();
            var request = new GetClientCertificatesRequest();
            do
            {
                var response = await Client.GetClientCertificatesAsync(request);
                request.Position = response.Position;

                if (response.Items != null)
                {
                    foreach (var cert in response.Items)
                    {
                        certificates.Add(cert);
                    }
                }
            } while (!string.IsNullOrEmpty(request.Position));
            return certificates;
        }
    }
}
