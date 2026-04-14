using Amazon.GameLift;
using Amazon.GameLift.Model;
using Amazon.S3;
using Amazon.S3.Model;
using AWSSDK_DotNet.IntegrationTests.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Xunit;

namespace AWSSDK_DotNet.IntegrationTests.Tests
{
    /// <summary>
    /// xUnit fixture that owns a single <see cref="AmazonGameLiftClient"/> for the lifetime
    /// of the <see cref="GameLiftTests"/> class.
    /// </summary>
    public class GameLiftClientFixture : IAsyncLifetime
    {
        public AmazonGameLiftClient Client { get; private set; }

        public ValueTask InitializeAsync()
        {
            Client = new AmazonGameLiftClient();
            RetryUtilities.ConfigureClient(Client);
            return default;
        }

        public ValueTask DisposeAsync()
        {
            Client?.Dispose();
            return default;
        }
    }

    [Trait("Category", "GameLift")]
    public class GameLiftTests : IClassFixture<GameLiftClientFixture>, IAsyncLifetime
    {
        private readonly AmazonGameLiftClient _client;

        // Tracks builds created by this test instance so DisposeAsync can clean up.
        private readonly List<string> _createdBuilds = new List<string>();

        public GameLiftTests(GameLiftClientFixture fixture)
        {
            _client = fixture.Client;
        }

        public ValueTask InitializeAsync() => default;

        public async ValueTask DisposeAsync()
        {
            foreach (var buildId in _createdBuilds)
            {
                await _client.DeleteBuildAsync(buildId);
            }
        }

        [Fact]
        public async Task CrudCalls()
        {
            var originalBuilds = (await GetAllBuilds()).ToList();

            var createResponse = await _client.CreateBuildAsync(new CreateBuildRequest
            {
                Name = UtilityMethods.GenerateName("TestBuild-"),
                Version = DateTime.UtcNow.ToFileTime().ToString(),
                OperatingSystem = Amazon.GameLift.OperatingSystem.AMAZON_LINUX_2
            });

            var newBuild = createResponse.Build;
            _createdBuilds.Add(newBuild.BuildId);

            var builds = (await GetAllBuilds()).ToList();
            Assert.NotEqual(originalBuilds.Count, builds.Count);

            await _client.UpdateBuildAsync(new UpdateBuildRequest
            {
                BuildId = newBuild.BuildId,
                Name = newBuild.Name + "_2",
                Version = newBuild.Version + "_2"
            });

            var uploadCreds = await _client.RequestUploadCredentialsAsync(newBuild.BuildId);
            var storageLocation = uploadCreds.StorageLocation;
            var credentials = uploadCreds.UploadCredentials;

            using (var s3client = new AmazonS3Client(credentials))
            {
                var putResponse = await s3client.PutObjectAsync(new PutObjectRequest
                {
                    BucketName = storageLocation.Bucket,
                    Key = storageLocation.Key,
                    ContentBody = "test content"
                });
                Assert.Equal(HttpStatusCode.OK, putResponse.HttpStatusCode);
            }

            await _client.DeleteBuildAsync(newBuild.BuildId);
            _createdBuilds.Remove(newBuild.BuildId);

            builds = (await GetAllBuilds()).ToList();
            Assert.Equal(originalBuilds.Count, builds.Count);
        }

        private async Task<IEnumerable<Build>> GetAllBuilds(BuildStatus status = null)
        {
            var builds = new List<Build>();
            var request = new ListBuildsRequest
            {
                Status = status
            };

            do
            {
                var response = await _client.ListBuildsAsync(request);
                request.NextToken = response.NextToken;

                if (response.Builds != null)
                {
                    builds.AddRange(response.Builds);
                }
            } while (!string.IsNullOrEmpty(request.NextToken));
            return builds;
        }
    }
}
