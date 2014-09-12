using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using AWSSDK_DotNet.IntegrationTests.Utils;

using Amazon.S3;
using Amazon.S3.Model;
using Amazon.S3.Util;


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
    }
}
