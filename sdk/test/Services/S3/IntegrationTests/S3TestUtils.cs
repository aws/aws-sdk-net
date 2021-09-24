using Amazon;
using Amazon.S3;
using Amazon.S3.Model;
using Amazon.S3.Util;
using Amazon.S3Control;
using Amazon.S3Control.Model;
using AWSSDK_DotNet.IntegrationTests.Utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using System.Net;
using System.Threading;

namespace AWSSDK_DotNet.IntegrationTests.Tests.S3
{
    public static class S3TestUtils
    {
        private const int MAX_SPIN_LOOPS = 100;

        public static string CreateBucket(IAmazonS3 s3Client)
        {
            string bucketName = UtilityMethods.SDK_TEST_PREFIX + DateTime.Now.Ticks;
            s3Client.PutBucket(new PutBucketRequest { BucketName = bucketName });
            return bucketName;
        }
                
        public static string CreateBucket(IAmazonS3 s3Client, PutBucketRequest bucketRequest)
        {
            string bucketName = UtilityMethods.SDK_TEST_PREFIX + DateTime.Now.Ticks;
            bucketRequest.BucketName = bucketName;
            s3Client.PutBucket(bucketRequest);
            return bucketName;
        }

        public static string CreateBucketWithWait(IAmazonS3 s3Client)
        {
            string bucketName = CreateBucket(s3Client);
            WaitForBucket(s3Client, bucketName);
            return bucketName;
        }

        public static string CreateBucketWithWait(IAmazonS3 s3Client, PutBucketRequest bucketRequest)
        {
            string bucketName = CreateBucket(s3Client, bucketRequest);
            WaitForBucket(s3Client, bucketName);
            return bucketName;
        }

        public static void WaitForBucket(IAmazonS3 client, string bucketName)
        {
            WaitForBucket(client, bucketName, 30);
        }

        public static void WaitForBucket(IAmazonS3 client, string bucketName, int maxSeconds)
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
        /// Creates an S3 Multi-Region Access Point and waits for it to be ready
        /// </summary>
        /// <param name="s3ControlClient">S3Control client to create the MRAP with</param>
        /// <param name="mrapRequest">Prepared CreateMultiRegionAccessPoint request</param>
        /// <returns>Alias of the new Multi-Region Access Point</returns>
        public static string CreateMRAPWithWait(IAmazonS3Control s3ControlClient, CreateMultiRegionAccessPointRequest mrapRequest)
        {
            var asyncRequestArn = s3ControlClient.CreateMultiRegionAccessPoint(mrapRequest).RequestTokenARN;

            var mrapAlias = UtilityMethods.WaitUntilSuccess(() =>
            {
                var request = new GetMultiRegionAccessPointRequest
                {
                    AccountId = mrapRequest.AccountId,
                    Name = mrapRequest.Details.Name
                };

                var response = s3ControlClient.GetMultiRegionAccessPoint(request);

                if (response.AccessPoint.Status == MultiRegionAccessPointStatus.READY)
                {
                    return response.AccessPoint.Alias;
                }
                else
                {
                    throw new Exception("S3 Multi-Region Access Point not ready yet, will continue waiting.");
                }
            });

            return mrapAlias;
        }

        /// <summary>
        /// Deletes an S3 Multi-Region Access Point and waits for the delete to succeed
        /// </summary>
        /// <param name="s3ControlClient">S3Control client to delete the MRAP with</param>
        /// <param name="deleteRequest">Prepared DeleteMultiRegionAccessPoint request</param>
        public static void DeleteMRAPWithWait(IAmazonS3Control s3ControlClient, DeleteMultiRegionAccessPointRequest deleteRequest)
        {
            var asyncRequestArn = s3ControlClient.DeleteMultiRegionAccessPoint(deleteRequest).RequestTokenARN;

            UtilityMethods.WaitUntilSuccess(() =>
            {
                var request = new DescribeMultiRegionAccessPointOperationRequest
                {
                    AccountId = deleteRequest.AccountId,
                    RequestTokenARN = asyncRequestArn
                };

                var response = s3ControlClient.DescribeMultiRegionAccessPointOperation(request);

                if (response.AsyncOperation.RequestStatus == "SUCCEEDED")
                {
                    return;
                }
                else
                {
                    throw new Exception("S3 Multi-Region Access Point not deleted yet, will continue waiting.");
                }
            });
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
                Expires = DateTime.Now + TimeSpan.FromDays(5)
            });

            var httpRequest = HttpWebRequest.Create(presignedUrl);
            using (var httpResponse = httpRequest.GetResponse())
            using (var reader = new StreamReader(httpResponse.GetResponseStream()))
            {
                var content = reader.ReadToEnd();
                Assert.AreEqual(testContent, content);
            }
        }

        public static IDisposable UseSignatureVersion4(bool newValue)
        {
            return new SigV4Disposable(newValue);
        }

        public static void TestWithVariableSigV4(Action action, bool useSigV4)
        {
            using(var sigv4 = UseSignatureVersion4(useSigV4))
            {
                action();
            }
        }


        private class SigV4Disposable : IDisposable
        {
            private bool OldSigV4;
            public SigV4Disposable(bool newSigV4)
            {
                OldSigV4 = AWSConfigsS3.UseSignatureVersion4;
                AWSConfigsS3.UseSignatureVersion4 = newSigV4;
            }

            public void Dispose()
            {
                AWSConfigsS3.UseSignatureVersion4 = OldSigV4;
            }
        }
    }
}
