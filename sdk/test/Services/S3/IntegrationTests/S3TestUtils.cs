using Amazon;
using Amazon.S3;
using Amazon.S3.Model;
using Amazon.S3.Util;
using Amazon.S3Control;
using Amazon.S3Control.Model;
using Amazon.SecurityToken;
using Amazon.SecurityToken.Model;
using AWSSDK_DotNet.IntegrationTests.Utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Threading;

namespace AWSSDK_DotNet.IntegrationTests.Tests.S3
{
    public static class S3TestUtils
    {
        private const int MAX_SPIN_LOOPS = 100;
        private const string TEST_MRAP_NAME = UtilityMethods.SDK_TEST_PREFIX + "-for-mrap-tests";

        public static string CreateBucket(IAmazonS3 s3Client)
        {
            string bucketName = UtilityMethods.SDK_TEST_PREFIX + DateTime.UtcNow.Ticks;

            s3Client.PutBucket(new PutBucketRequest { BucketName = bucketName });
            return bucketName;
        }

        public static string CreateBucket(IAmazonS3 s3Client, PutBucketRequest bucketRequest)
        {
            string bucketName = string.IsNullOrEmpty(bucketRequest.BucketName) ?
                UtilityMethods.SDK_TEST_PREFIX + DateTime.UtcNow.Ticks :
                bucketRequest.BucketName;

            bucketRequest.BucketName = bucketName;

            s3Client.PutBucket(bucketRequest);
            return bucketName;
        }
        public static string CreateS3ExpressBucketWithWait(IAmazonS3 s3Client, string regionCode, bool setPublicACLs = false)
        {
            string bucketName = $"{UtilityMethods.SDK_TEST_PREFIX}-{DateTime.UtcNow.Ticks}--{regionCode}--x-s3";

            s3Client.PutBucket(new PutBucketRequest
            {
                BucketName = bucketName,
                PutBucketConfiguration = new PutBucketConfiguration
                {
                    BucketInfo = new BucketInfo { DataRedundancy = DataRedundancy.SingleAvailabilityZone, Type = BucketType.Directory },
                    Location = new LocationInfo { Name = regionCode, Type = LocationType.AvailabilityZone }
                }
            });
            WaitForBucket(s3Client, bucketName, true);


            return bucketName;
        }
        public static string CreateBucketWithWait(IAmazonS3 s3Client, bool setPublicACLs = false)
        {
            string bucketName = CreateBucket(s3Client);
            WaitForBucket(s3Client, bucketName);
            if (setPublicACLs)
            {
                SetPublicBucketACLs(s3Client, bucketName);
            }
            return bucketName;
        }

        public static string CreateBucketWithWait(IAmazonS3 s3Client, PutBucketRequest bucketRequest, bool setPublicACLs = false)
        {
            string bucketName = CreateBucket(s3Client, bucketRequest);
            WaitForBucket(s3Client, bucketName);
            if (setPublicACLs)
            {
                SetPublicBucketACLs(s3Client, bucketName);
            }
            return bucketName;
        }

        private static void SetPublicBucketACLs(IAmazonS3 client, string bucketName)
        {
            client.PutBucketOwnershipControls(new PutBucketOwnershipControlsRequest
            {
                BucketName = bucketName,
                OwnershipControls = new OwnershipControls
                {
                    Rules = new List<OwnershipControlsRule>
                        {
                            new OwnershipControlsRule{ObjectOwnership = ObjectOwnership.BucketOwnerPreferred}
                        }
                }
            });

            client.PutPublicAccessBlock(new Amazon.S3.Model.PutPublicAccessBlockRequest
            {
                BucketName = bucketName,
                PublicAccessBlockConfiguration = new Amazon.S3.Model.PublicAccessBlockConfiguration
                {
                    BlockPublicAcls = false
                }
            });
        }


        public static void WaitForBucket(IAmazonS3 client, string bucketName, bool skipDoubleCheck = false)
        {
            var sleeper = UtilityMethods.ListSleeper.Create();
            UtilityMethods.WaitUntilSuccess(() => {
                //Check if a bucket exists by trying to put an object in it
                var key = Guid.NewGuid().ToString() + "_existskey";

                var res = client.PutObject(new PutObjectRequest
                {
                    BucketName = bucketName,
                    Key = key,
                    ContentBody = "exists..."
                });

                try
                {
                    client.Delete(bucketName, key, null);
                }
                catch
                {
                    Console.WriteLine($"Eventual consistency error: failed to delete key {key} from bucket {bucketName}");
                }

                return true;
            });

            if (skipDoubleCheck) return;

            //Double check the bucket still exists using the DoesBucketExistV2 method
            var exists = S3TestUtils.WaitForConsistency(() =>
            {
                return AmazonS3Util.DoesS3BucketExistV2(client, bucketName) ? (bool?)true : null;
            });
        }

        public static void WaitForObject(IAmazonS3 client, string bucketName, string key, int maxSeconds)
        {
            var sleeper = UtilityMethods.ListSleeper.Create();
            UtilityMethods.WaitUntilSuccess(() => { client.GetObject(bucketName, key); }, sleeper, maxSeconds);
        }

        /// <summary>
        /// Gets a long-lived S3 Multi-Region Access Point for running integration tests against if
        /// if exists in the current account. If not, creates it and waits for it to be ready.
        /// </summary>
        /// <param name="s3ControlClient">S3Control client to create the MRAP with</param>
        /// <param name="s3Client">S3 client to create the backing bucket with</param>
        /// <returns>ARN of the new Multi-Region Access Point</returns>
        public static string GetOrCreateTestMRAP(IAmazonS3Control s3ControlClient, IAmazonS3 s3Client)
        {
            var accountId = new AmazonSecurityTokenServiceClient().GetCallerIdentity(new GetCallerIdentityRequest()).Account;

            // If the MRAP already exists, return it
            var mrapArn = CheckIfMRAPExists(s3ControlClient, accountId, TEST_MRAP_NAME);
            if (!string.IsNullOrEmpty(mrapArn))
            {
                return mrapArn;
            }

            // Otherwise the MRAP doesn't exist, so we must create it, starting with the backing bucket.
            var putBucketRequest = new PutBucketRequest { BucketName = $"{accountId}-{TEST_MRAP_NAME}" };
            var backingBucketName = CreateBucketWithWait(s3Client, putBucketRequest);

            var createMrapRequest = new CreateMultiRegionAccessPointRequest
            {
                AccountId = accountId,
                Details = new CreateMultiRegionAccessPointInput
                {
                    Name = TEST_MRAP_NAME,
                    Regions = new List<Region>
                    {
                        new Region
                        {
                            Bucket = backingBucketName
                        }
                    }
                }
            };

            // Initiate the MRAP creation
            var asyncRequestArn = s3ControlClient.CreateMultiRegionAccessPoint(createMrapRequest).RequestTokenARN;

            // Wait until its status is READY
            UtilityMethods.WaitUntilSuccess(() =>
            {
                var request = new GetMultiRegionAccessPointRequest
                {
                    AccountId = accountId,
                    Name = TEST_MRAP_NAME
                };

                var response = s3ControlClient.GetMultiRegionAccessPoint(request);

                if (response.AccessPoint.Status == MultiRegionAccessPointStatus.READY)
                {
                    // Wait for SSL provisioning to finish
                    Thread.Sleep(TimeSpan.FromMinutes(1));

                    return $"arn:aws:s3::{accountId}:accesspoint/{response.AccessPoint.Alias}";
                }
                else
                {
                    throw new Exception("S3 Multi-Region Access Point not ready yet, will continue waiting.");
                }
            });

            throw new Exception($"{nameof(GetOrCreateTestMRAP)} timed out while creating a new Multi-Region Access Point");
        }

        /// <summary>
        /// Checks if an S3 multi-region access point already exists.
        /// Note: does not validate that the MRAP is ready.
        /// </summary>
        /// <param name="s3ControlClient">S3Control client</param>
        /// <param name="accountId">AWS account ID that is expected to contain the MRAP</param>
        /// <param name="mrapName">Name of the multi-region access point</param>
        /// <returns>The MRAP's ARN if it exists, an empty string otherwise</returns>
        private static string CheckIfMRAPExists(IAmazonS3Control s3ControlClient, string accountId, string mrapName)
        {
            var request = new ListMultiRegionAccessPointsRequest { AccountId = accountId };
            var paginatorForAccessPoints = s3ControlClient.Paginators.ListMultiRegionAccessPoints(request);
            
            foreach (var response in paginatorForAccessPoints.Responses)
            {
                if (response.AccessPoints == null)
                {
                    continue;
                }

                foreach (var accessPoint in response.AccessPoints)
                {
                    if (accessPoint.Name == mrapName)
                    {
                        return $"arn:aws:s3::{accountId}:accesspoint/{accessPoint.Alias}";
                    }
                }
            }

            return "";
        }

        /// <summary>
        /// Deletes all objects in a bucket.
        /// Based on DeleteS3BucketWithObjects, but 
        /// without deleting the bucket at the end.
        /// </summary>
        /// <param name="client">S3 Client</param>
        /// <param name="bucketName">Bucket whose objects to delete</param>
        public static void DeleteObjects(IAmazonS3 client, string bucketName)
        {
            var listVersionsRequest = new ListVersionsRequest
            {
                BucketName = bucketName
            };
            ListVersionsResponse listVersionsResponse;

            do
            {
                // List all the versions of all the objects in the bucket.
                listVersionsResponse = client.ListVersions(listVersionsRequest);

                if (listVersionsResponse.Versions == null || listVersionsResponse.Versions.Count == 0)
                {
                    // If the bucket has no objects we're finished
                    return;
                }

                var keyVersionList = new List<KeyVersion>(listVersionsResponse.Versions.Count);
                for (int index = 0; index < listVersionsResponse.Versions.Count; index++)
                {
                    keyVersionList.Add(new KeyVersion
                    {
                        Key = listVersionsResponse.Versions[index].Key,
                        VersionId = listVersionsResponse.Versions[index].VersionId
                    });
                }

                // Delete the current set of objects.
                client.DeleteObjects(new DeleteObjectsRequest
                {
                    BucketName = bucketName,
                    Objects = keyVersionList
                });

                // Set the markers to get next set of objects from the bucket.
                listVersionsRequest.KeyMarker = listVersionsResponse.NextKeyMarker;
                listVersionsRequest.VersionIdMarker = listVersionsResponse.NextVersionIdMarker;
            }
            // Continue listing objects and deleting them until the bucket is empty.
            while (listVersionsResponse.IsTruncated.GetValueOrDefault());
        }

        public static T WaitForConsistency<T>(Func<T> loadFunction)
        {
            //First try waiting up to 60 seconds.    
            var firstWaitSeconds = 60;
            try
            {
                return UtilityMethods.WaitUntilSuccess(loadFunction, 10, firstWaitSeconds);
            }
            catch
            {
                Console.WriteLine($"Eventual consistency wait: could not resolve eventual consistency after {firstWaitSeconds} seconds. Attempting to resolve...");
            }

            //Spin through request to try to get the expected result. As soon as we get a non null result use it.
            for (var spinCounter = 0; spinCounter < MAX_SPIN_LOOPS; spinCounter++)
            {
                try
                {
                    T result = loadFunction();
                    if (result != null)
                    {
                        if (spinCounter != 0)
                        {
                            //Only log that a wait happened if it didn't do it on the first time.
                            Console.WriteLine($"Eventual consistency wait successful on attempt {spinCounter + 1}.");
                        }

                        return result;
                    }
                }
                catch
                {
                }

                Thread.Sleep(0);
            }

            //If we don't have an ok result then spend the normal wait period to wait for eventual consistency.
            Console.WriteLine($"Eventual consistency wait: could not resolve eventual consistency after {MAX_SPIN_LOOPS}. Waiting normally...");
            var lastWaitSeconds = 240; //4 minute wait.
            return UtilityMethods.WaitUntilSuccess(loadFunction, 5, lastWaitSeconds);
        }

        /// <summary>
        /// Test helper that will put an S3 object then verify its content via a both a get and a presigned get
        /// </summary>
        /// <param name="s3Client">S3 client to put the object with</param>
        /// <param name="bucketName">Bucket name to put the object to</param>
        /// <param name="keyName">Object key</param>
        /// <param name="useChunkEncoding">Whether to use chunked encoding for the PutObject request</param>
        /// <param name="disablePayloadSigning">Whether to disable SigV4/V4a payload signing for the PutObject request</param>
        internal static void PutAndGetObjectTestHelper(IAmazonS3 s3Client, string bucketName, string keyName, bool useChunkEncoding = true, bool disablePayloadSigning = false)
        {
            const string testContent = "Some stuff to write as content";

            s3Client.PutObject(new PutObjectRequest
            {
                BucketName = bucketName,
                Key = keyName,
                ContentBody = testContent,
                UseChunkEncoding = useChunkEncoding,
                DisablePayloadSigning = disablePayloadSigning
            });

            var response = s3Client.GetObject(new GetObjectRequest
            {
                BucketName = bucketName,
                Key = keyName
            });

            using (var s = new StreamReader(response.ResponseStream))
            {
                var responseContent = s.ReadToEnd();
                Assert.AreEqual(testContent, responseContent);
            }

            var presignedUrl = s3Client.GetPreSignedURL(new GetPreSignedUrlRequest
            {
                BucketName = bucketName,
                Key = keyName,
                Verb = HttpVerb.GET,
                Expires = DateTime.UtcNow + TimeSpan.FromDays(5)
            });

            var httpRequest = HttpWebRequest.Create(presignedUrl);
            using (var httpResponse = httpRequest.GetResponse())
            using (var reader = new StreamReader(httpResponse.GetResponseStream()))
            {
                var content = reader.ReadToEnd();
                Assert.AreEqual(testContent, content);
            }
        }
    }
}
