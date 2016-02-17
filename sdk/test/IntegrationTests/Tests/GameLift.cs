using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Amazon.GameLift;
using Amazon.GameLift.Model;
using AWSSDK_DotNet.IntegrationTests.Utils;
using AWSSDK_DotNet.IntegrationTests.Tests;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;

namespace AWSSDK_DotNet.IntegrationTests.Tests
{
    [TestClass]
    public class GameLift : TestBase<AmazonGameLiftClient>
    {
        private static List<string> createdBuilds = new List<string>();

        [ClassCleanup]
        public static void Cleanup()
        {
            foreach(var build in createdBuilds)
            {
                Client.DeleteBuild(build);
            }

            BaseClean();
        }

        [TestMethod]
        [TestCategory("GameLift")]
        public void CrudCalls()
        {
            var originalBuilds = GetAllBuilds().ToList();

            var timestamp = DateTime.Now.ToFileTime().ToString();
            var newBuild = Client.CreateBuild(new CreateBuildRequest
            {
                Name = "TestBuild-" + timestamp,
                Version = timestamp
            }).Build;
            createdBuilds.Add(newBuild.BuildId);

            var builds = GetAllBuilds().ToList();
            Assert.AreNotEqual(originalBuilds.Count, builds.Count);

            Client.UpdateBuild(new UpdateBuildRequest
            {
                BuildId = newBuild.BuildId,
                Name = newBuild.Name + "_2",
                Version = newBuild.Version + "_2"
            });

            var uploadCreds = Client.RequestUploadCredentials(newBuild.BuildId);
            var storageLocation = uploadCreds.StorageLocation;
            var credentials = uploadCreds.UploadCredentials;
            using(var s3client = new Amazon.S3.AmazonS3Client(credentials))
            {
                var putResponse = s3client.PutObject(new Amazon.S3.Model.PutObjectRequest
                {
                    BucketName = storageLocation.Bucket,
                    Key = storageLocation.Key,
                    ContentBody = "test content"
                });
                Console.WriteLine(putResponse.ContentLength);
            }

            Client.DeleteBuild(newBuild.BuildId);
            createdBuilds.Remove(newBuild.BuildId);

            builds = GetAllBuilds().ToList();
            Assert.AreEqual(originalBuilds.Count, builds.Count);
        }

        private static IEnumerable<Build> GetAllBuilds(BuildStatus status = null)
        {
            var request = new ListBuildsRequest
            {
                Status = status
            };
            do
            {
                var response = Client.ListBuilds(request);
                request.NextToken = response.NextToken;
                foreach (var build in response.Builds)
                    yield return build;
            } while (!string.IsNullOrEmpty(request.NextToken));
        }
    }
}
