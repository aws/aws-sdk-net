using Amazon;
using Amazon.S3;
using Amazon.S3.Model;
using System.Collections.Generic;
using System.Threading.Tasks;
using AWSSDK_DotNet.IntegrationTests.Tests.S3.Fixtures;
using Xunit;

namespace AWSSDK_DotNet.IntegrationTests.Tests.S3
{
    [Trait("Category", "S3")]
    public class IntelligentTieringTests : IClassFixture<S3BucketFixture>
    {
        private readonly AmazonS3Client _client;
        private readonly string _bucketName;
        private const string intelligentTieringId = "configId";

        public IntelligentTieringTests(S3BucketFixture fixture)
        {
            _client = fixture.Client;
            _bucketName = fixture.BucketName;
        }

        private PutBucketIntelligentTieringConfigurationRequest GeneratePutRequest(string id, IntelligentTieringFilter intelligentTieringfilter)
        {
            return new PutBucketIntelligentTieringConfigurationRequest
            {
                BucketName = _bucketName,
                IntelligentTieringId = id,
                IntelligentTieringConfiguration = new IntelligentTieringConfiguration
                {
                    IntelligentTieringId = id,
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

        [Fact]
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
            await _client.PutBucketIntelligentTieringConfigurationAsync(putBucketIntelligentTieringConfigurationRequest);

            var getBucketIntelligentTieringConfigurationRequest = new GetBucketIntelligentTieringConfigurationRequest
            {
                IntelligentTieringId = intelligentTieringId,
                BucketName = _bucketName
            };
            var getBucketIntelligentTieringConfigurationResponse = await S3TestUtils.WaitForConsistencyAsync(async () =>
            {
                var res = await _client.GetBucketIntelligentTieringConfigurationAsync(getBucketIntelligentTieringConfigurationRequest);
                return res.IntelligentTieringConfiguration?.IntelligentTieringId == getBucketIntelligentTieringConfigurationRequest.IntelligentTieringId ? res : null;
            });

            var getConfiguration = getBucketIntelligentTieringConfigurationResponse.IntelligentTieringConfiguration;
            var putConfiguration = putBucketIntelligentTieringConfigurationRequest.IntelligentTieringConfiguration;
            Assert.Equal(getConfiguration.IntelligentTieringId, putConfiguration.IntelligentTieringId);
            Assert.Equal(((IntelligentTieringTagPredicate)getConfiguration.IntelligentTieringFilter.IntelligentTieringFilterPredicate).Tag.Key, "tagK");
            Assert.Equal(((IntelligentTieringTagPredicate)getConfiguration.IntelligentTieringFilter.IntelligentTieringFilterPredicate).Tag.Value, "tagV");
        }

        [Fact]
        public async Task BucketIntelligentTieringConfigurationsPrefixFilterTest()
        {
            var putBucketIntelligentTieringConfigurationRequest = GeneratePutRequest(intelligentTieringId, new IntelligentTieringFilter
            {
                IntelligentTieringFilterPredicate = new IntelligentTieringPrefixPredicate("string")
            });
            await _client.PutBucketIntelligentTieringConfigurationAsync(putBucketIntelligentTieringConfigurationRequest);

            var getBucketIntelligentTieringConfigurationRequest = new GetBucketIntelligentTieringConfigurationRequest
            {
                IntelligentTieringId = intelligentTieringId,
                BucketName = _bucketName
            };

            var getBucketIntelligentTieringConfigurationResponse = await S3TestUtils.WaitForConsistencyAsync(async () =>
            {
                var res = await _client.GetBucketIntelligentTieringConfigurationAsync(getBucketIntelligentTieringConfigurationRequest);
                return res.IntelligentTieringConfiguration?.IntelligentTieringId == getBucketIntelligentTieringConfigurationRequest.IntelligentTieringId ? res : null;
            });

            var getConfiguration = getBucketIntelligentTieringConfigurationResponse.IntelligentTieringConfiguration;
            var putConfiguration = putBucketIntelligentTieringConfigurationRequest.IntelligentTieringConfiguration;
            Assert.Equal(getConfiguration.IntelligentTieringId, putConfiguration.IntelligentTieringId);
            Assert.Equal(((IntelligentTieringPrefixPredicate)getConfiguration.IntelligentTieringFilter.IntelligentTieringFilterPredicate).Prefix, "string");
        }

        [Fact]
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
            await _client.PutBucketIntelligentTieringConfigurationAsync(putBucketIntelligentTieringConfigurationRequest);

            var getBucketIntelligentTieringConfigurationRequest = new GetBucketIntelligentTieringConfigurationRequest
            {
                IntelligentTieringId = intelligentTieringId,
                BucketName = _bucketName
            };

            var getBucketIntelligentTieringConfigurationResponse = await S3TestUtils.WaitForConsistencyAsync(async () =>
            {
                var res = await _client.GetBucketIntelligentTieringConfigurationAsync(getBucketIntelligentTieringConfigurationRequest);
                return res.IntelligentTieringConfiguration?.IntelligentTieringId == getBucketIntelligentTieringConfigurationRequest.IntelligentTieringId ? res : null;
            });

            var getConfiguration = getBucketIntelligentTieringConfigurationResponse.IntelligentTieringConfiguration;
            var putConfiguration = putBucketIntelligentTieringConfigurationRequest.IntelligentTieringConfiguration;
            Assert.Equal(getConfiguration.IntelligentTieringId, putConfiguration.IntelligentTieringId);

            foreach (var predicate in ((IntelligentTieringNAryOperator)getConfiguration.IntelligentTieringFilter.IntelligentTieringFilterPredicate).Operands)
            {
                if (predicate is IntelligentTieringPrefixPredicate prefixPredicate)
                {
                    Assert.Equal(prefixPredicate.Prefix, "string");
                }
                else if (predicate is IntelligentTieringTagPredicate tagPredicate)
                {
                    Assert.Equal(tagPredicate.Tag.Key, "tagK");
                    Assert.Equal(tagPredicate.Tag.Value, "tagV");
                }
            }
        }

        [Fact]
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
            await _client.PutBucketIntelligentTieringConfigurationAsync(putBucketIntelligentTieringConfigurationRequest);

            var getBucketIntelligentTieringConfigurationRequest = new GetBucketIntelligentTieringConfigurationRequest
            {
                IntelligentTieringId = intelligentTieringId,
                BucketName = _bucketName
            };

            var getBucketIntelligentTieringConfigurationResponse = await S3TestUtils.WaitForConsistencyAsync(async () =>
            {
                var res = await _client.GetBucketIntelligentTieringConfigurationAsync(getBucketIntelligentTieringConfigurationRequest);
                return res.IntelligentTieringConfiguration?.IntelligentTieringId == getBucketIntelligentTieringConfigurationRequest.IntelligentTieringId ? res : null;
            });

            var getConfiguration = getBucketIntelligentTieringConfigurationResponse.IntelligentTieringConfiguration;
            var putConfiguration = putBucketIntelligentTieringConfigurationRequest.IntelligentTieringConfiguration;
            Assert.Equal(getConfiguration.IntelligentTieringId, putConfiguration.IntelligentTieringId);
            Assert.Equal(getConfiguration.Status, putConfiguration.Status);

            Assert.Equal(getConfiguration.Tierings.Count, putConfiguration.Tierings.Count);
            for (int i = 0; i < getConfiguration.Tierings.Count; i++)
            {
                var tiering_get = getConfiguration.Tierings[i];
                var tiering_put = putConfiguration.Tierings[i];
                Assert.Equal(tiering_get.Days, tiering_put.Days);
                Assert.Equal(tiering_get.AccessTier, tiering_put.AccessTier);
            }
        }

        [Fact]
        public async Task ListBucketIntelligentTiering()
        {
            var intelligentTieringFilter = new IntelligentTieringFilter
            {
                IntelligentTieringFilterPredicate = new IntelligentTieringPrefixPredicate("string")
            };

            var putBucketIntelligentTieringConfigurationRequest_1 = GeneratePutRequest("config-1", intelligentTieringFilter);
            var putBucketIntelligentTieringConfigurationRequest_2 = GeneratePutRequest("config-2", intelligentTieringFilter);
            try
            {
                await _client.PutBucketIntelligentTieringConfigurationAsync(putBucketIntelligentTieringConfigurationRequest_1);
                await _client.PutBucketIntelligentTieringConfigurationAsync(putBucketIntelligentTieringConfigurationRequest_2);

                var listResponse = await _client.ListBucketIntelligentTieringConfigurationsAsync(new ListBucketIntelligentTieringConfigurationsRequest
                {
                    BucketName = _bucketName
                });
                Assert.NotNull(listResponse.IntelligentTieringConfigurationList);
            }
            finally
            {
                await _client.DeleteBucketIntelligentTieringConfigurationAsync(new DeleteBucketIntelligentTieringConfigurationRequest
                {
                    BucketName = _bucketName,
                    IntelligentTieringId = "config-1"
                });
                await _client.DeleteBucketIntelligentTieringConfigurationAsync(new DeleteBucketIntelligentTieringConfigurationRequest
                {
                    BucketName = _bucketName,
                    IntelligentTieringId = "config-2"
                });
            }
        }
        
        [Fact]
        public async Task DeleteBucketIntelligentTieringConfigurationTest()
        {
            var putBucketIntelligentTieringConfigurationRequest = GeneratePutRequest(intelligentTieringId, new IntelligentTieringFilter
            {
                IntelligentTieringFilterPredicate = new IntelligentTieringPrefixPredicate("string")
            });
            await _client.PutBucketIntelligentTieringConfigurationAsync(putBucketIntelligentTieringConfigurationRequest);

            await _client.DeleteBucketIntelligentTieringConfigurationAsync(new DeleteBucketIntelligentTieringConfigurationRequest
            {
                BucketName = _bucketName,
                IntelligentTieringId = intelligentTieringId
            });

            var listResponse = await _client.ListBucketIntelligentTieringConfigurationsAsync(new ListBucketIntelligentTieringConfigurationsRequest
            {
                BucketName = _bucketName
            });

            if (AWSConfigs.InitializeCollections)
            {
                Assert.Equal(listResponse.IntelligentTieringConfigurationList.Count, 0);
            }
            else
            {
                Assert.Null(listResponse.IntelligentTieringConfigurationList);
            }
        }
    }
}
