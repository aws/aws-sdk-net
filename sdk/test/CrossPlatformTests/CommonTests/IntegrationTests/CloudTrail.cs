using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

using Amazon.CloudTrail;
using Amazon.CloudTrail.Model;

using Amazon.S3;
using Amazon.S3.Model;
using Amazon.S3.Util;

using NUnit.Framework;
using CommonTests.Framework;

namespace CommonTests.IntegrationTests
{
    [TestFixture]
    public class CloudTrail : TestBase<AmazonCloudTrailClient>
    {
        private static string _trailStorageBucketName = "sdk-dotnet-integ-test-trail-bucket-" + DateTime.Now.Ticks;
        private const string S3_PREFIX = "folder";

        static AmazonS3Client s3Client;

        [OneTimeSetUp]
        public void ClassInitialize()
        {
            s3Client = CreateClient<AmazonS3Client>();
            try
            {
                UtilityMethods.DeleteBucketWithObjectsAsync(s3Client, _trailStorageBucketName);
                //AmazonS3Util.DeleteS3BucketWithObjects(s3Client, _trailStorageBucketName);
            }
            catch (Exception) { }

            s3Client.PutBucketAsync(new PutBucketRequest
            {
                BucketName = _trailStorageBucketName,
                CannedACL = S3CannedACL.BucketOwnerFullControl
            }).Wait();

            var policy = UtilityMethods.GetResourceText("CloudTrailBucketPolicy.json");

            // Inject newly created bucket and current account id
            policy = policy.Replace("{BucketName}", _trailStorageBucketName)
                .Replace("{Prefix}", S3_PREFIX)
                .Replace("{AccountId}", UtilityMethods.AccountId);

            s3Client.PutBucketPolicyAsync(new PutBucketPolicyRequest
            {
                BucketName = _trailStorageBucketName,
                Policy = policy
            }).Wait();
        }

        [OneTimeTearDown]
        public void Cleanup()
        {
            var trails = Client.DescribeTrailsAsync().Result;
            foreach (var trail in trails.TrailList)
            {
                if (trail.Name.Contains("dotnet-integ-test"))
                {
                    Client.DeleteTrailAsync(new DeleteTrailRequest
                    {
                        Name = trail.Name
                    }).Wait();
                }
            }

            //AmazonS3Util.DeleteS3BucketWithObjects(s3Client, _trailStorageBucketName);
            UtilityMethods.DeleteBucketWithObjectsAsync(s3Client, _trailStorageBucketName);

            BaseClean();

            s3Client.Dispose();
            s3Client = null;
        }

        [Test]
        [Category("CloudTrail")]
        public void CloudTrailIntegrationTest()
        {
            var trailsCount = Client.DescribeTrailsAsync().Result.TrailList.Count;

            // Cloud Trail is already setup for this account so skip the test to not disturb
            // the settings.
            if (trailsCount != 0)
                return;

            var trailName = "dotnet-integ-test-trail-" + DateTime.Now.Ticks;
            var trail = Client.CreateTrailAsync(new CreateTrailRequest
            {
                Name = trailName,
                IncludeGlobalServiceEvents = true,
                S3BucketName = _trailStorageBucketName,
                S3KeyPrefix = S3_PREFIX
            }).Result;
            Assert.AreEqual(trail.Name, trailName);
            Assert.AreEqual(trail.IncludeGlobalServiceEvents, true);
            Assert.AreEqual(trail.S3BucketName, _trailStorageBucketName);
            Assert.AreEqual(trail.S3KeyPrefix, S3_PREFIX);
            Assert.AreEqual(trail.SnsTopicName, null);
            UtilityMethods.Sleep(TimeSpan.FromSeconds(5));

            var trails = Client.DescribeTrailsAsync().Result.TrailList;
            Assert.AreEqual(trails.Count, trailsCount + 1);

            var trailStatus = Client.GetTrailStatusAsync(new GetTrailStatusRequest
            {
                Name = trailName
            }).Result;
            Assert.AreEqual(trailStatus.IsLogging, false);

            Client.StartLoggingAsync(new StartLoggingRequest
            {
                Name = trailName
            }).Wait();
            UtilityMethods.Sleep(TimeSpan.FromSeconds(5));

            trailStatus = Client.GetTrailStatusAsync(new GetTrailStatusRequest
            {
                Name = trailName
            }).Result;
            Assert.AreEqual(trailStatus.IsLogging, true);

            var endTime = DateTime.UtcNow;
            var startTime = endTime.AddMinutes(-30);

            var request = new LookupEventsRequest
            {
                StartTime = startTime,
                EndTime = endTime,
            };
            var allEvents = LookupAllEvents(request).ToList();

            if (allEvents.Count > 0)
            {
                var resourceNamesMap = new Dictionary<string, int>();
                foreach (var e in allEvents)
                {
                    var resources = e.Resources;
                    foreach (var r in resources)
                    {
                        if (!resourceNamesMap.ContainsKey(r.ResourceName))
                            resourceNamesMap[r.ResourceName] = 0;
                        resourceNamesMap[r.ResourceName]++;
                    }
                }

                var firstResourceNameKVP = resourceNamesMap.First();
                request.LookupAttributes = new List<LookupAttribute>
                {
                    new LookupAttribute
                    {
                        AttributeKey = LookupAttributeKey.ResourceName,
                        AttributeValue = firstResourceNameKVP.Key
                    }
                };
                var filteredEvents = LookupAllEvents(request).ToList();
                Assert.AreEqual(firstResourceNameKVP.Value, filteredEvents.Count);
            }

            Client.StopLoggingAsync(new StopLoggingRequest
            {
                Name = trailName
            }).Wait();
            UtilityMethods.Sleep(TimeSpan.FromSeconds(2));

            Client.DeleteTrailAsync(new DeleteTrailRequest
            {
                Name = trailName
            }).Wait();
        }

        private IEnumerable<Event> LookupAllEvents(LookupEventsRequest request = null)
        {
            if (request == null)
                request = new LookupEventsRequest();
            do
            {
                var result = Client.LookupEventsAsync(request).Result;
                request.NextToken = result.NextToken;

                var events = result.Events;
                foreach (var e in events)
                    yield return e;

            } while (!string.IsNullOrEmpty(request.NextToken));
        }
    }
}
