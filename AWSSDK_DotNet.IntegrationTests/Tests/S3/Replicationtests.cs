using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AWSSDK_DotNet.IntegrationTests.Utils;
using Amazon.S3;
using Amazon.S3.Model;
using Amazon.S3.Util;

namespace AWSSDK_DotNet.IntegrationTests.Tests.S3
{
    [TestClass]
    public class Replicationtests : TestBase<AmazonS3Client>
    {
        [TestMethod]
        [TestCategory("S3")]
        public void TestReplicationConfiguration()
        {
            TestReplicationConfigurationForPrefix("foo-");
        }

        [TestMethod]
        [TestCategory("S3")]
        public void TestReplicationConfigurationNoPrefix()
        {
            TestReplicationConfigurationForPrefix(null);
        }


        private void TestReplicationConfigurationForPrefix(string prefix)
        {
            var bucketName = UtilityMethods.GenerateName();
            var storageClass = S3StorageClass.ReducedRedundancy;
            var euBucketName = "eu" + UtilityMethods.GenerateName();
            var euS3 = new AmazonS3Client(Amazon.RegionEndpoint.EUWest1);
            euS3.PutBucket(euBucketName);
            Client.PutBucket(bucketName);

            euS3.PutBucketVersioning(new PutBucketVersioningRequest
            {
                BucketName = euBucketName,
                VersioningConfig = new S3BucketVersioningConfig
                {
                    Status = VersionStatus.Enabled
                }
            });

            Client.PutBucketVersioning(new PutBucketVersioningRequest
            {
                BucketName = bucketName,
                VersioningConfig = new S3BucketVersioningConfig
                {
                    Status = VersionStatus.Enabled
                }
            });

            var roleArn = "arn:aws:iam::pikc123456:role/abcdef";
            var destinationBucketArn = "arn:aws:s3:::" + euBucketName;

            try
            {
                Client.PutBucketReplication(new PutBucketReplicationRequest { 
                    BucketName = bucketName,
                    Configuration = new ReplicationConfiguration
                    {
                        Role = roleArn,
                        Rules =
                        {
                            new ReplicationRule 
                            {
                                Id = UtilityMethods.GenerateName(),
                                Prefix = prefix,
                                Status = ReplicationRuleStatus.Enabled,
                                Destination = new ReplicationDestination
                                {
                                    BucketArn = destinationBucketArn,
                                    StorageClass = storageClass
                                }
                                
                            }
                        }
                    }
                });

                var config = Client.GetBucketReplication(new GetBucketReplicationRequest 
                { 
                    BucketName = bucketName
                }).Configuration;

                Assert.IsNotNull(config);
                Assert.IsNotNull(config.Role);
                Assert.AreEqual(roleArn, config.Role);
                Assert.IsNotNull(config.Rules);
                Assert.AreEqual(1, config.Rules.Count);

                var rule = config.Rules.First();

                Assert.IsNotNull(rule);
                Assert.IsNotNull(rule.Id);
                Assert.IsNotNull(rule.Prefix);
                if (string.IsNullOrEmpty(prefix))
                    Assert.AreEqual(string.Empty, rule.Prefix);
                else
                    Assert.AreEqual(prefix, rule.Prefix);
                Assert.AreEqual(destinationBucketArn, rule.Destination.BucketArn);
                Assert.AreEqual(storageClass, rule.Destination.StorageClass);

                Client.PutObject(new PutObjectRequest { 
                    BucketName = bucketName,
                    ContentBody = "foo",
                    Key = "foo-123"
                });

                var status = Client.GetObjectMetadata(new GetObjectMetadataRequest {
                    BucketName = bucketName,
                    Key = "foo-123"
                }).ReplicationStatus;

                Assert.IsNotNull(status);

                Client.DeleteBucketReplication(new DeleteBucketReplicationRequest { 
                    BucketName = bucketName
                });

                var noconfig = Client.GetBucketReplication(new GetBucketReplicationRequest {
                    BucketName = bucketName
                }).Configuration;

                Assert.IsFalse(noconfig.Rules.Any());
            }
            finally
            {
                AmazonS3Util.DeleteS3BucketWithObjects(euS3, euBucketName);
                AmazonS3Util.DeleteS3BucketWithObjects(Client, bucketName);
            }
        }
    }
}
