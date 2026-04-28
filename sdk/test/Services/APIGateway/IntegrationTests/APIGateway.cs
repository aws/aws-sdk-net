using Amazon.APIGateway;
using Amazon.APIGateway.Model;
using AWSSDK_DotNet.IntegrationTests.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace AWSSDK_DotNet.IntegrationTests.Tests
{
    /// <summary>
    /// xUnit fixture that creates a single REST API once for the lifetime of the
    /// <see cref="APIGatewayTests"/> class and tears it down afterwards.
    /// </summary>
    public class APIGatewayFixture : IAsyncLifetime
    {
        private static readonly string Timestamp = DateTime.UtcNow.ToFileTime().ToString();

        public AmazonAPIGatewayClient Client { get; private set; }
        public string RestApiId { get; private set; }
        public string ApiName { get; } = "dotnet-test-" + Timestamp;
        public string ApiDescription { get; } = "RestApi created by dotnet tests at " + Timestamp;

        public async ValueTask InitializeAsync()
        {
            Client = new AmazonAPIGatewayClient();
            RetryUtilities.ConfigureClient(Client);

            var createRestApi = await Client.CreateRestApiAsync(new CreateRestApiRequest
            {
                Name = ApiName,
                Description = ApiDescription
            });

            Assert.Equal(ApiDescription, createRestApi.Description);
            Assert.Equal(ApiName, createRestApi.Name);
            Assert.False(string.IsNullOrEmpty(createRestApi.Id));
            Assert.NotEqual(DateTime.SpecifyKind(default, DateTimeKind.Utc), createRestApi.CreatedDate);
            RestApiId = createRestApi.Id;
        }

        public async ValueTask DisposeAsync()
        {
            if (!string.IsNullOrEmpty(RestApiId))
            {
                await Client.DeleteRestApiAsync(new DeleteRestApiRequest
                {
                    RestApiId = RestApiId
                });
            }

            Client?.Dispose();
        }
    }

    [Trait("Category", "APIGateway")]
    public class APIGatewayTests : IClassFixture<APIGatewayFixture>
    {
        private readonly AmazonAPIGatewayClient _client;
        private readonly string _restApiId;
        private readonly string _apiName;
        private readonly string _apiDescription;

        public APIGatewayTests(APIGatewayFixture fixture)
        {
            _client = fixture.Client;
            _restApiId = fixture.RestApiId;
            _apiName = fixture.ApiName;
            _apiDescription = fixture.ApiDescription;
        }

        [Fact]
        public async Task TestResources()
        {
            var allResources = (await GetResources()).ToList();
            var rootResource = allResources.SingleOrDefault(r => r.ParentId == null);
            Assert.NotNull(rootResource);

            var pathPart = "test";
            var createResponse = await _client.CreateResourceAsync(new CreateResourceRequest
            {
                RestApiId = _restApiId,
                ParentId = rootResource.Id,
                PathPart = pathPart
            });

            var resourceId = createResponse.Id;
            var resources = (await GetResources()).ToList();
            var resource = resources.Single(r => r.Id == resourceId);
            Assert.Equal(pathPart, resource.PathPart);
            Assert.Equal(rootResource.Path + pathPart, resource.Path);
            Assert.Equal(2, resources.Count);

            await _client.PutMethodAsync(new PutMethodRequest
            {
                RestApiId = _restApiId,
                ResourceId = resourceId,
                AuthorizationType = "AWS_IAM",
                HttpMethod = "PUT"
            });

            await _client.PutIntegrationAsync(new PutIntegrationRequest
            {
                RestApiId = _restApiId,
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
                RestApiId = _restApiId
            };

            do
            {
                var response = await _client.GetResourcesAsync(request);
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

        [Fact]
        public async Task TestRestApiCalls()
        {
            var apis = (await GetRestApis()).ToList();
            var api = apis.Single(r => string.Equals(r.Id, _restApiId));
            Assert.NotNull(api);

            await Assert.ThrowsAsync<NotFoundException>(() =>
                _client.GetRestApiAsync(new GetRestApiRequest { RestApiId = "fakeid" })
            );

            var getRestApi = await _client.GetRestApiAsync(new GetRestApiRequest
            {
                RestApiId = _restApiId
            });
            Assert.Equal(_apiDescription, getRestApi.Description);
            Assert.Equal(_apiName, getRestApi.Name);
            Assert.False(string.IsNullOrEmpty(getRestApi.Id));
            Assert.NotEqual(DateTime.SpecifyKind(default, DateTimeKind.Utc), getRestApi.CreatedDate);

            var newDescription = "New description!";
            await _client.UpdateRestApiAsync(new UpdateRestApiRequest
            {
                RestApiId = _restApiId,
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

            getRestApi = await _client.GetRestApiAsync(new GetRestApiRequest
            {
                RestApiId = _restApiId
            });
            Assert.Equal(newDescription, getRestApi.Description);
            Assert.Equal(_apiName, getRestApi.Name);
            Assert.False(string.IsNullOrEmpty(getRestApi.Id));
            Assert.NotEqual(DateTime.SpecifyKind(default, DateTimeKind.Utc), getRestApi.CreatedDate);

            await _client.UpdateRestApiAsync(new UpdateRestApiRequest
            {
                RestApiId = _restApiId,
                PatchOperations = new List<PatchOperation>
                {
                    new PatchOperation
                    {
                        Op = Op.Replace,
                        Path = "/description",
                        Value = _apiDescription
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
                var response = await _client.GetRestApisAsync(request);
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

        [Fact]
        public async Task TestOtherOperations()
        {
            var account = await _client.GetAccountAsync(new GetAccountRequest());
            Assert.NotNull(account);
            Assert.NotNull(account.ThrottleSettings);
            Assert.NotEqual(0, account.ThrottleSettings.BurstLimit);
            Assert.NotEqual(0, account.ThrottleSettings.RateLimit);

            var allCerts = (await GetAllCerts()).ToList();
            var certDescription = "something";

            var clientCert = await _client.GenerateClientCertificateAsync(new GenerateClientCertificateRequest
            {
                Description = certDescription
            });
            Assert.NotNull(clientCert);
            Assert.Equal(certDescription, clientCert.Description);
            Assert.NotEqual(DateTime.SpecifyKind(default, DateTimeKind.Utc), clientCert.CreatedDate);
            Assert.NotEqual(DateTime.SpecifyKind(default, DateTimeKind.Utc), clientCert.ExpirationDate);
            Assert.True(clientCert.ExpirationDate > clientCert.CreatedDate);
            Assert.False(string.IsNullOrEmpty(clientCert.PemEncodedCertificate));
            Assert.False(string.IsNullOrEmpty(clientCert.ClientCertificateId));

            var updatedCerts = (await GetAllCerts()).ToList();
            Assert.NotEqual(allCerts.Count, updatedCerts.Count);

            await _client.DeleteClientCertificateAsync(new DeleteClientCertificateRequest
            {
                ClientCertificateId = clientCert.ClientCertificateId
            });
        }

        private async Task<IEnumerable<ClientCertificate>> GetAllCerts()
        {
            var certificates = new List<ClientCertificate>();
            var request = new GetClientCertificatesRequest();
            do
            {
                var response = await _client.GetClientCertificatesAsync(request);
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
