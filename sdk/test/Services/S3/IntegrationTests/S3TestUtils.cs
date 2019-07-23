using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using AWSSDK_DotNet.IntegrationTests.Utils;

using Amazon.S3;
using Amazon.S3.Model;
using Amazon.S3.Util;
using System.Threading;
using Amazon;

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
