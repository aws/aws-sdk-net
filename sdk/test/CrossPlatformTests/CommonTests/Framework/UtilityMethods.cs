using Amazon.S3;
using Amazon.S3.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonTests.Framework
{
    internal class UtilityMethods
    {
        public const string SDK_TEST_PREFIX = "aws-net-sdk";

        public async static Task<string> CreateBucketAsync(IAmazonS3 s3Client)
        {
            string bucketName = UtilityMethods.SDK_TEST_PREFIX + DateTime.Now.Ticks;
            await s3Client.PutBucketAsync(new PutBucketRequest { BucketName = bucketName });
            return bucketName;
        }
    }
}
