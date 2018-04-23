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
        public static string CreateBucket(IAmazonS3 s3Client)
        {
            string bucketName = UtilityMethods.SDK_TEST_PREFIX + DateTime.Now.Ticks;
            s3Client.PutBucket(new PutBucketRequest { BucketName = bucketName });
            return bucketName;
        }

        public static string CreateBucketWithWait(IAmazonS3 s3Client)
        {
            string bucketName = CreateBucket(s3Client);
            WaitForBucket(s3Client, bucketName, 30);
            return bucketName;
        }

        public static void WaitForBucket(IAmazonS3 client, string bucketName, int maxSeconds)
        {
            var sleeper = new UtilityMethods.ListSleeper(500, 1000, 2000, 5000);
            UtilityMethods.WaitUntil(()=> { return AmazonS3Util.DoesS3BucketExist(client, bucketName); }, sleeper, 30);
        }

        public static void WaitForObject(IAmazonS3 client, string bucketName, string key, int maxSeconds)
        {
            var sleeper = new UtilityMethods.ListSleeper(500, 1000, 2000, 5000);
            UtilityMethods.WaitUntilSuccess(() => { client.GetObject(bucketName, key); }, sleeper, 30);
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
