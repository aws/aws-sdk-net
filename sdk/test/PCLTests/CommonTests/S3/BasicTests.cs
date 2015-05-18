using Amazon.S3;
using Amazon.S3.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonTests.S3
{
    public class BasicTests : TestBase<AmazonS3Client>
    {
        public void Test1()
        {
            var bucketName = "pcl-bucket-test-" + DateTime.Now.ToFileTime();
            Client.PutBucketAsync(new PutBucketRequest
            {
                BucketName = bucketName
            });

            try
            {
                var buckets = Client.ListBucketsAsync(new ListBucketsRequest()).Result.Buckets;
                var bucketExists = buckets.Single(b => b.BucketName.Equals(bucketName, StringComparison.OrdinalIgnoreCase)) != null;

                if (!bucketExists)
                    throw new Exception();
            }
            finally
            {
                Client.DeleteBucketAsync(new DeleteBucketRequest
                {
                    BucketName = bucketName
                }).Wait();
            }
        }
    }
}
