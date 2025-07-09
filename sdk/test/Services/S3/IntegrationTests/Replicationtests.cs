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
        [Ignore("This test is disabled, it depends on a preexisiting role arn:aws:iam::pikc123456:role/abcdef which does not exist. The test should create it's own role instead.")]
        [TestMethod]
        [TestCategory("S3")]
        public void TestReplicationConfiguration()
        {
            TestReplicationConfigurationForPrefix("foo-");
        }

        [Ignore("This test is disabled, it depends on a preexisiting role arn:aws:iam::pikc123456:role/abcdef which does not exist. The test should create it's own role instead.")]
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

            S3TestUtils.WaitForBucket(euS3, euBucketName);
            S3TestUtils.WaitForBucket(Client, bucketName);

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

            WaitForEnabledVersioning(euS3, euBucketName);
            WaitForEnabledVersioning(Client, bucketName);

            var roleArn = "arn:aws:iam::pikc123456:role/abcdef";
            var destinationBucketArn = "arn:aws:s3:::" + euBucketName;

            try
            {
                Client.PutBucketReplication(new PutBucketReplicationRequest 
                { 
                    BucketName = bucketName,
                    Configuration = new ReplicationConfiguration
                    {
                        Role = roleArn,
                        Rules = new List<ReplicationRule>
                        {
                            new ReplicationRule
                            {
                                Id = UtilityMethods.GenerateName(),
                                Filter = new ReplicationRuleFilter
                                {
                                    Prefix = prefix
                                },
                                Status = ReplicationRuleStatus.Enabled,
                                Destination = new ReplicationDestination
                                {
                                    BucketArn = destinationBucketArn,
                                    StorageClass = storageClass
                                },
                                Priority = 1,
                                DeleteMarkerReplication = new DeleteMarkerReplication
                                {
                                    Status = DeleteMarkerReplicationStatus.Enabled
                                }
                            }
                        }
                    }
                });
                                
                var config = S3TestUtils.WaitForConsistency(() =>
                {
                    var res = Client.GetBucketReplication(new GetBucketReplicationRequest
                    {
                        BucketName = bucketName
                    });
                    return res.Configuration?.Role == roleArn ? res.Configuration : null;
                });

                Assert.IsNotNull(config);
                Assert.IsNotNull(config.Role);
                Assert.AreEqual(roleArn, config.Role);
                Assert.IsNotNull(config.Rules);
                Assert.AreEqual(1, config.Rules.Count);

                var rule = config.Rules.First();

                Assert.IsNotNull(rule);
                Assert.IsNotNull(rule.Id);
                if (string.IsNullOrEmpty(prefix))
                    Assert.AreEqual(null, rule.Filter.Prefix);
                else
                    Assert.AreEqual(prefix, rule.Filter.Prefix);
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
                                
                var noconfig = S3TestUtils.WaitForConsistency(() =>
                {
                    var res = Client.GetBucketReplication(new GetBucketReplicationRequest
                    {
                        BucketName = bucketName
                    });
                    return res.Configuration?.Rules.Any() == false ? res.Configuration : null;
                });

                Assert.IsFalse(noconfig.Rules.Any());
            }
            finally
            {
                AmazonS3Util.DeleteS3BucketWithObjects(euS3, euBucketName);
                AmazonS3Util.DeleteS3BucketWithObjects(Client, bucketName);
            }
        }

        private void WaitForEnabledVersioning(IAmazonS3 client, string bucketName)
        {
            S3TestUtils.WaitForConsistency(() =>
            {
                var res = client.GetBucketVersioning(new GetBucketVersioningRequest
                {
                    BucketName = bucketName
                });
                return res.VersioningConfig?.Status == VersionStatus.Enabled ? res : null;
            });
        }
    }
}
