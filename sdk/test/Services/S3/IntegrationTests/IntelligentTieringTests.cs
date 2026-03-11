using Amazon;
using Amazon.S3;
using Amazon.S3.Model;
using Amazon.S3.Util;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AWSSDK_DotNet.IntegrationTests.Tests.S3
{
    [TestClass]
    [TestCategory("S3")]
    public class IntelligentTieringTests : TestBase<AmazonS3Client>
    {
        public static string bucketName;
        public const string intelligentTieringId = "configId";

        private PutBucketIntelligentTieringConfigurationRequest GeneratePutRequest(string intelligentTieringId, IntelligentTieringFilter intelligentTieringfilter)
        {
            return new PutBucketIntelligentTieringConfigurationRequest
            {
                BucketName = bucketName,
                IntelligentTieringId = intelligentTieringId,
                IntelligentTieringConfiguration = new IntelligentTieringConfiguration
                {
                    IntelligentTieringId = intelligentTieringId,
                    Status = IntelligentTieringStatus.Enabled,
                    IntelligentTieringFilter = intelligentTieringfilter,
                    Tierings = new List<Tiering>
                    {
                        new Tiering
                        {
                            Days = 90,
                            AccessTier = IntelligentTieringAccessTier.ARCHIVE_ACCESS
                        }
                    }
                }
            };
        }

        [TestInitialize]
        public async Task Init()
        {
            bucketName = await S3TestUtils.CreateBucketWithWaitAsync(Client);
        }

        [TestCleanup]
        public async Task Cleanup()
        {
            await AmazonS3Util.DeleteS3BucketWithObjectsAsync(Client, bucketName);
        }

        [TestMethod]
        public async Task BucketIntelligentTieringConfigurationsTagFilterTest()
        {
            var putBucketIntelligentTieringConfigurationRequest = GeneratePutRequest(intelligentTieringId, new IntelligentTieringFilter
            {
                IntelligentTieringFilterPredicate = new IntelligentTieringTagPredicate(new Tag
                {
                    Key = "tagK",
                    Value = "tagV"
                })
            });
            await Client.PutBucketIntelligentTieringConfigurationAsync(putBucketIntelligentTieringConfigurationRequest);

            var getBucketIntelligentTieringConfigurationRequest = new GetBucketIntelligentTieringConfigurationRequest
            {
                IntelligentTieringId = intelligentTieringId,
                BucketName = bucketName
            };
            var getBucketIntelligentTieringConfigurationResponse = await S3TestUtils.WaitForConsistencyAsync(async () =>
            {
                var res = await Client.GetBucketIntelligentTieringConfigurationAsync(getBucketIntelligentTieringConfigurationRequest);
                return res.IntelligentTieringConfiguration?.IntelligentTieringId == getBucketIntelligentTieringConfigurationRequest.IntelligentTieringId ? res : null;
            });

            var getConfiguration = getBucketIntelligentTieringConfigurationResponse.IntelligentTieringConfiguration;
            var putConfiguration = putBucketIntelligentTieringConfigurationRequest.IntelligentTieringConfiguration;
            Assert.AreEqual(getConfiguration.IntelligentTieringId, putConfiguration.IntelligentTieringId);
            Assert.AreEqual(((IntelligentTieringTagPredicate)getConfiguration.IntelligentTieringFilter.IntelligentTieringFilterPredicate).Tag.Key, "tagK");
            Assert.AreEqual(((IntelligentTieringTagPredicate)getConfiguration.IntelligentTieringFilter.IntelligentTieringFilterPredicate).Tag.Value, "tagV");
        }

        [TestMethod]
        public async Task BucketIntelligentTieringConfigurationsPrefixFilterTest()
        {
            var putBucketIntelligentTieringConfigurationRequest = GeneratePutRequest(intelligentTieringId, new IntelligentTieringFilter
            {
                IntelligentTieringFilterPredicate = new IntelligentTieringPrefixPredicate("string")
            });
            await Client.PutBucketIntelligentTieringConfigurationAsync(putBucketIntelligentTieringConfigurationRequest);

            var getBucketIntelligentTieringConfigurationRequest = new GetBucketIntelligentTieringConfigurationRequest
            {
                IntelligentTieringId = intelligentTieringId,
                BucketName = bucketName
            };

            var getBucketIntelligentTieringConfigurationResponse = await S3TestUtils.WaitForConsistencyAsync(async () =>
            {
                var res = await Client.GetBucketIntelligentTieringConfigurationAsync(getBucketIntelligentTieringConfigurationRequest);
                return res.IntelligentTieringConfiguration?.IntelligentTieringId == getBucketIntelligentTieringConfigurationRequest.IntelligentTieringId ? res : null;
            });

            var getConfiguration = getBucketIntelligentTieringConfigurationResponse.IntelligentTieringConfiguration;
            var putConfiguration = putBucketIntelligentTieringConfigurationRequest.IntelligentTieringConfiguration;
            Assert.AreEqual(getConfiguration.IntelligentTieringId, putConfiguration.IntelligentTieringId);
            Assert.AreEqual(((IntelligentTieringPrefixPredicate)getConfiguration.IntelligentTieringFilter.IntelligentTieringFilterPredicate).Prefix, "string");
        }

        [TestMethod]
        public async Task BucketIntelligentTieringConfigurationsAndFilterTest()
        {
            var list = new List<IntelligentTieringFilterPredicate>
            {
                new IntelligentTieringPrefixPredicate("string"),
                new IntelligentTieringTagPredicate(new Tag
                {
                    Key = "tagK",
                    Value = "tagV"
                })
            };

            var putBucketIntelligentTieringConfigurationRequest = GeneratePutRequest(intelligentTieringId, new IntelligentTieringFilter
            {
                IntelligentTieringFilterPredicate = new IntelligentTieringAndOperator(list)
            });
            await Client.PutBucketIntelligentTieringConfigurationAsync(putBucketIntelligentTieringConfigurationRequest);

            var getBucketIntelligentTieringConfigurationRequest = new GetBucketIntelligentTieringConfigurationRequest
            {
                IntelligentTieringId = intelligentTieringId,
                BucketName = bucketName
            };

            var getBucketIntelligentTieringConfigurationResponse = await S3TestUtils.WaitForConsistencyAsync(async () =>
            {
                var res = await Client.GetBucketIntelligentTieringConfigurationAsync(getBucketIntelligentTieringConfigurationRequest);
                return res.IntelligentTieringConfiguration?.IntelligentTieringId == getBucketIntelligentTieringConfigurationRequest.IntelligentTieringId ? res : null;
            });

            var getConfiguration = getBucketIntelligentTieringConfigurationResponse.IntelligentTieringConfiguration;
            var putConfiguration = putBucketIntelligentTieringConfigurationRequest.IntelligentTieringConfiguration;
            Assert.AreEqual(getConfiguration.IntelligentTieringId, putConfiguration.IntelligentTieringId);

            foreach (var predicate in ((IntelligentTieringNAryOperator)getConfiguration.IntelligentTieringFilter.IntelligentTieringFilterPredicate).Operands)
            {
                if (predicate is IntelligentTieringPrefixPredicate prefixPredicate)
                {
                    Assert.AreEqual(prefixPredicate.Prefix, "string");
                }
                else if (predicate is IntelligentTieringTagPredicate tagPredicate)
                {
                    Assert.AreEqual(tagPredicate.Tag.Key, "tagK");
                    Assert.AreEqual(tagPredicate.Tag.Value, "tagV");
                }
            }
        }

        [TestMethod]
        public async Task BucketIntelligentTieringConfigurationsTieringListTest()
        {
            var intelligentTieringFilter = new IntelligentTieringFilter
            {
                IntelligentTieringFilterPredicate = new IntelligentTieringPrefixPredicate("string")
            };

            var tiering = new Tiering
            {
                Days = 180,
                AccessTier = IntelligentTieringAccessTier.DEEP_ARCHIVE_ACCESS
            };

            var putBucketIntelligentTieringConfigurationRequest = GeneratePutRequest(intelligentTieringId, intelligentTieringFilter);
            putBucketIntelligentTieringConfigurationRequest.IntelligentTieringConfiguration.Tierings.Add(tiering);
            await Client.PutBucketIntelligentTieringConfigurationAsync(putBucketIntelligentTieringConfigurationRequest);

            var getBucketIntelligentTieringConfigurationRequest = new GetBucketIntelligentTieringConfigurationRequest
            {
                IntelligentTieringId = intelligentTieringId,
                BucketName = bucketName
            };

            var getBucketIntelligentTieringConfigurationResponse = await S3TestUtils.WaitForConsistencyAsync(async () =>
            {
                var res = await Client.GetBucketIntelligentTieringConfigurationAsync(getBucketIntelligentTieringConfigurationRequest);
                return res.IntelligentTieringConfiguration?.IntelligentTieringId == getBucketIntelligentTieringConfigurationRequest.IntelligentTieringId ? res : null;
            });

            var getConfiguration = getBucketIntelligentTieringConfigurationResponse.IntelligentTieringConfiguration;
            var putConfiguration = putBucketIntelligentTieringConfigurationRequest.IntelligentTieringConfiguration;
            Assert.AreEqual(getConfiguration.IntelligentTieringId, putConfiguration.IntelligentTieringId);
            Assert.AreEqual(getConfiguration.Status, putConfiguration.Status);

            Assert.AreEqual(getConfiguration.Tierings.Count, putConfiguration.Tierings.Count);
            for (int i = 0; i < getConfiguration.Tierings.Count; i++)
            {
                var tiering_get = getConfiguration.Tierings[i];
                var tiering_put = putConfiguration.Tierings[i];
                Assert.AreEqual(tiering_get.Days, tiering_put.Days);
                Assert.AreEqual(tiering_get.AccessTier, tiering_put.AccessTier);
            }
        }

        [TestMethod]
        public async Task ListBucketIntelligentTiering()
        {
            var intelligentTieringFilter = new IntelligentTieringFilter
            {
                IntelligentTieringFilterPredicate = new IntelligentTieringPrefixPredicate("string")
            };

            var putBucketIntelligentTieringConfigurationRequest_1 = GeneratePutRequest("config-1", intelligentTieringFilter);
            var putBucketIntelligentTieringConfigurationRequest_2 = GeneratePutRequest("config-2", intelligentTieringFilter);
            await Client.PutBucketIntelligentTieringConfigurationAsync(putBucketIntelligentTieringConfigurationRequest_1);
            await Client.PutBucketIntelligentTieringConfigurationAsync(putBucketIntelligentTieringConfigurationRequest_2);

            var listResponse = await Client.ListBucketIntelligentTieringConfigurationsAsync(new ListBucketIntelligentTieringConfigurationsRequest
            {
                BucketName = bucketName
            });
            Assert.AreEqual(listResponse.IntelligentTieringConfigurationList.Count, 2);
        }
        
        [TestMethod]
        public async Task DeleteBucketIntelligentTieringConfigurationTest()
        {
            var putBucketIntelligentTieringConfigurationRequest = GeneratePutRequest(intelligentTieringId, new IntelligentTieringFilter
            {
                IntelligentTieringFilterPredicate = new IntelligentTieringPrefixPredicate("string")
            });
            await Client.PutBucketIntelligentTieringConfigurationAsync(putBucketIntelligentTieringConfigurationRequest);

            await Client.DeleteBucketIntelligentTieringConfigurationAsync(new DeleteBucketIntelligentTieringConfigurationRequest
            {
                BucketName = bucketName,
                IntelligentTieringId = intelligentTieringId
            });

            var listResponse = await Client.ListBucketIntelligentTieringConfigurationsAsync(new ListBucketIntelligentTieringConfigurationsRequest
            {
                BucketName = bucketName
            });

            if (AWSConfigs.InitializeCollections)
            {
                Assert.AreEqual(listResponse.IntelligentTieringConfigurationList.Count, 0);
            }
            else
            {
                Assert.IsNull(listResponse.IntelligentTieringConfigurationList);
            }
        }
    }
}
