using Amazon.GameLift;
using Amazon.GameLift.Model;
using Amazon.S3;
using Amazon.S3.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace AWSSDK_DotNet.IntegrationTests.Tests
{
    [TestClass]
    [TestCategory("GameLift")]
    public class GameLift : TestBase<AmazonGameLiftClient>
    {
        private static readonly List<string> createdBuilds = new List<string>();

        [ClassCleanup]
        public static async Task Cleanup()
        {
            foreach (var build in createdBuilds)
            {
                await Client.DeleteBuildAsync(build);
            }

            BaseClean();
        }

        [TestMethod]
        public async Task CrudCalls()
        {
            var originalBuilds = (await GetAllBuilds()).ToList();

            var timestamp = DateTime.UtcNow.ToFileTime().ToString();
            var createRespone = await Client.CreateBuildAsync(new CreateBuildRequest
            {
                Name = "TestBuild-" + timestamp,
                Version = timestamp,
                OperatingSystem = Amazon.GameLift.OperatingSystem.AMAZON_LINUX_2
            });

            var newBuild = createRespone.Build;
            createdBuilds.Add(newBuild.BuildId);

            var builds = (await GetAllBuilds()).ToList();
            Assert.AreNotEqual(originalBuilds.Count, builds.Count);

            await Client.UpdateBuildAsync(new UpdateBuildRequest
            {
                BuildId = newBuild.BuildId,
                Name = newBuild.Name + "_2",
                Version = newBuild.Version + "_2"
            });

            var uploadCreds = await Client.RequestUploadCredentialsAsync(newBuild.BuildId);
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
                Assert.AreEqual(HttpStatusCode.OK, putResponse.HttpStatusCode);
            }

            await Client.DeleteBuildAsync(newBuild.BuildId);
            createdBuilds.Remove(newBuild.BuildId);

            builds = (await GetAllBuilds()).ToList();
            Assert.AreEqual(originalBuilds.Count, builds.Count);
        }

        private static async Task<IEnumerable<Build>> GetAllBuilds(BuildStatus status = null)
        {
            var builds = new List<Build>();
            var request = new ListBuildsRequest
            {
                Status = status
            };

            do
            {
                var response = await Client.ListBuildsAsync(request);
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
