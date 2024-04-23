using Amazon;
using Amazon.S3;
using Amazon.S3.Model;
using Amazon.S3.Util;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace AWSSDK_DotNet.IntegrationTests.Tests.S3
{
    /// <summary>
    /// Tests for IntelligentTieringConfiguration
    /// </summary>
    [TestClass]
    public class IntelligentTieringTests : TestBase<AmazonS3Client>
    {
        public static string bucketName;
        public const string intelligentTieringId = "configId";

        private PutBucketIntelligentTieringConfigurationRequest GeneratePutRequest (string intelligentTieringId, IntelligentTieringFilter intelligentTieringfilter)
		{
            PutBucketIntelligentTieringConfigurationRequest putBucketIntelligentTieringConfigurationRequest = new PutBucketIntelligentTieringConfigurationRequest()
            {
                BucketName = bucketName,
                IntelligentTieringId = intelligentTieringId,
                IntelligentTieringConfiguration = new IntelligentTieringConfiguration()
                {
                    IntelligentTieringId = intelligentTieringId,
                    Status = IntelligentTieringStatus.Enabled,
                    IntelligentTieringFilter = intelligentTieringfilter,
                    Tierings = new List<Tiering>()
                    {
                        new Tiering()
                        {
                            Days = 90,
                            AccessTier = IntelligentTieringAccessTier.ARCHIVE_ACCESS
                        }
                    }

                }
            };
            return putBucketIntelligentTieringConfigurationRequest;
        }

        [TestInitialize]
        public void Init()
        {
            bucketName = S3TestUtils.CreateBucketWithWait(Client);
        }

        [TestCleanup]
        public void Cleanup()
        {
           AmazonS3Util.DeleteS3BucketWithObjects(Client, bucketName);
        }

        [TestCategory("S3")]
        [TestMethod]
        public void BucketIntelligentTieringConfigurationsTagFilterTest()
        {
            Tag tag = new Tag()
            {
                Key = "tagK",
                Value = "tagV"
            };
            var intelligentTieringFilter = new IntelligentTieringFilter()
            {
                IntelligentTieringFilterPredicate = new IntelligentTieringTagPredicate(tag)
            };

            var putBucketIntelligentTieringConfigurationRequest = GeneratePutRequest(intelligentTieringId, intelligentTieringFilter);
            var putBucketIntelligentTieringConfigurationResponse = Client.PutBucketIntelligentTieringConfiguration(putBucketIntelligentTieringConfigurationRequest);

            GetBucketIntelligentTieringConfigurationRequest getBucketIntelligentTieringConfigurationRequest = new GetBucketIntelligentTieringConfigurationRequest()
            {
                IntelligentTieringId = intelligentTieringId,
                BucketName = bucketName
            };
                        
            var getBucketIntelligentTieringConfigurationResponse = S3TestUtils.WaitForConsistency(() =>
            {
                var res = Client.GetBucketIntelligentTieringConfiguration(getBucketIntelligentTieringConfigurationRequest);
                return res.IntelligentTieringConfiguration?.IntelligentTieringId == getBucketIntelligentTieringConfigurationRequest.IntelligentTieringId ? res : null;
            });

            var getConfiguration = getBucketIntelligentTieringConfigurationResponse.IntelligentTieringConfiguration;
            var putConfiguration = putBucketIntelligentTieringConfigurationRequest.IntelligentTieringConfiguration;
            Assert.AreEqual(getConfiguration.IntelligentTieringId, putConfiguration.IntelligentTieringId);
            Assert.AreEqual(((IntelligentTieringTagPredicate)getConfiguration.IntelligentTieringFilter.IntelligentTieringFilterPredicate).Tag.Key, "tagK");
            Assert.AreEqual(((IntelligentTieringTagPredicate)getConfiguration.IntelligentTieringFilter.IntelligentTieringFilterPredicate).Tag.Value, "tagV");
        }

        [TestCategory("S3")]
        [TestMethod]
        public void BucketIntelligentTieringConfigurationsPrefixFilterTest()
        {
            var intelligentTieringFilter = new IntelligentTieringFilter()
            {
                IntelligentTieringFilterPredicate = new IntelligentTieringPrefixPredicate("string")
            };

            var putBucketIntelligentTieringConfigurationRequest = GeneratePutRequest(intelligentTieringId, intelligentTieringFilter);
            var putBucketIntelligentTieringConfigurationResponse = Client.PutBucketIntelligentTieringConfiguration(putBucketIntelligentTieringConfigurationRequest);

            GetBucketIntelligentTieringConfigurationRequest getBucketIntelligentTieringConfigurationRequest = new GetBucketIntelligentTieringConfigurationRequest()
            {
                IntelligentTieringId = intelligentTieringId,
                BucketName = bucketName
            };

            var getBucketIntelligentTieringConfigurationResponse = S3TestUtils.WaitForConsistency(() =>
            {
                var res = Client.GetBucketIntelligentTieringConfiguration(getBucketIntelligentTieringConfigurationRequest);
                return res.IntelligentTieringConfiguration?.IntelligentTieringId == getBucketIntelligentTieringConfigurationRequest.IntelligentTieringId ? res : null;
            });

            var getConfiguration = getBucketIntelligentTieringConfigurationResponse.IntelligentTieringConfiguration;
            var putConfiguration = putBucketIntelligentTieringConfigurationRequest.IntelligentTieringConfiguration;
			Assert.AreEqual(getConfiguration.IntelligentTieringId, putConfiguration.IntelligentTieringId);
			Assert.AreEqual(((IntelligentTieringPrefixPredicate)getConfiguration.IntelligentTieringFilter.IntelligentTieringFilterPredicate).Prefix, "string");
        }

        [TestCategory("S3")]
        [TestMethod]
        public void BucketIntelligentTieringConfigurationsAndFilterTest()
        {
            Tag tag = new Tag()
            {
                Key = "tagK",
                Value = "tagV"
            };
            List<IntelligentTieringFilterPredicate> list = new List<IntelligentTieringFilterPredicate>();
            list.Add(new IntelligentTieringPrefixPredicate("string"));
            list.Add(new IntelligentTieringTagPredicate(tag));

            var intelligentTieringFilter = new IntelligentTieringFilter()
            {
                IntelligentTieringFilterPredicate = new IntelligentTieringAndOperator(list)
            };
            var putBucketIntelligentTieringConfigurationRequest = GeneratePutRequest(intelligentTieringId, intelligentTieringFilter);
            var putBucketIntelligentTieringConfigurationResponse = Client.PutBucketIntelligentTieringConfiguration(putBucketIntelligentTieringConfigurationRequest);

            GetBucketIntelligentTieringConfigurationRequest getBucketIntelligentTieringConfigurationRequest = new GetBucketIntelligentTieringConfigurationRequest()
            {
                IntelligentTieringId = intelligentTieringId,
                BucketName = bucketName
            };

            var getBucketIntelligentTieringConfigurationResponse = S3TestUtils.WaitForConsistency(() =>
            {
                var res = Client.GetBucketIntelligentTieringConfiguration(getBucketIntelligentTieringConfigurationRequest);
                return res.IntelligentTieringConfiguration?.IntelligentTieringId == getBucketIntelligentTieringConfigurationRequest.IntelligentTieringId ? res : null;
            });

            var getConfiguration = getBucketIntelligentTieringConfigurationResponse.IntelligentTieringConfiguration;
            var putConfiguration = putBucketIntelligentTieringConfigurationRequest.IntelligentTieringConfiguration;
            Assert.AreEqual(getConfiguration.IntelligentTieringId, putConfiguration.IntelligentTieringId);

            foreach (var predicate in ((IntelligentTieringNAryOperator)getConfiguration.IntelligentTieringFilter.IntelligentTieringFilterPredicate).Operands)
            {
                if (predicate is IntelligentTieringPrefixPredicate)
                {
                    Assert.AreEqual(((IntelligentTieringPrefixPredicate)predicate).Prefix, "string");
                }
                else if (predicate is IntelligentTieringTagPredicate)
                {
                    Assert.AreEqual(((IntelligentTieringTagPredicate)predicate).Tag.Key, "tagK");
                    Assert.AreEqual(((IntelligentTieringTagPredicate)predicate).Tag.Value, "tagV");
                }
            }
        }

        [TestCategory("S3")]
        [TestMethod]
        public void BucketIntelligentTieringConfigurationsTieringListTest()
		{
            var intelligentTieringFilter = new IntelligentTieringFilter()
            {
                IntelligentTieringFilterPredicate = new IntelligentTieringPrefixPredicate("string")
            };

            var tiering = new Tiering()
            {
                Days = 180,
                AccessTier = IntelligentTieringAccessTier.DEEP_ARCHIVE_ACCESS
            };

            var putBucketIntelligentTieringConfigurationRequest = GeneratePutRequest(intelligentTieringId, intelligentTieringFilter);
            putBucketIntelligentTieringConfigurationRequest.IntelligentTieringConfiguration.Tierings.Add(tiering);
            var putBucketIntelligentTieringConfigurationResponse = Client.PutBucketIntelligentTieringConfiguration(putBucketIntelligentTieringConfigurationRequest);

            GetBucketIntelligentTieringConfigurationRequest getBucketIntelligentTieringConfigurationRequest = new GetBucketIntelligentTieringConfigurationRequest()
            {
                IntelligentTieringId = intelligentTieringId,
                BucketName = bucketName
            };

            var getBucketIntelligentTieringConfigurationResponse = S3TestUtils.WaitForConsistency(() =>
            {
                var res = Client.GetBucketIntelligentTieringConfiguration(getBucketIntelligentTieringConfigurationRequest);
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

        [TestCategory("S3")]
        [TestMethod]
        public void ListBucketIntelligentTiering()
        {
            var intelligentTieringFilter = new IntelligentTieringFilter()
            {
                IntelligentTieringFilterPredicate = new IntelligentTieringPrefixPredicate("string")
            };

            var putBucketIntelligentTieringConfigurationRequest_1 = GeneratePutRequest("config-1", intelligentTieringFilter);
            var putBucketIntelligentTieringConfigurationRequest_2 = GeneratePutRequest("config-2", intelligentTieringFilter);

            Client.PutBucketIntelligentTieringConfiguration(putBucketIntelligentTieringConfigurationRequest_1);
            Client.PutBucketIntelligentTieringConfiguration(putBucketIntelligentTieringConfigurationRequest_2);

            ListBucketIntelligentTieringConfigurationsRequest listBucketIntelligentTieringConfigurationsRequest = new ListBucketIntelligentTieringConfigurationsRequest()
            {
                BucketName = bucketName
            };

            var listBucketIntelligentTieringConfigurationsResponse = Client.ListBucketIntelligentTieringConfigurations(listBucketIntelligentTieringConfigurationsRequest);
            Assert.AreEqual(listBucketIntelligentTieringConfigurationsResponse.IntelligentTieringConfigurationList.Count, 2);
        }

        [TestCategory("S3")]
        [TestMethod]
        public void DeleteBucketIntelligentTieringConfigurationTest()
		{
            var intelligentTieringFilter = new IntelligentTieringFilter()
            {
                IntelligentTieringFilterPredicate = new IntelligentTieringPrefixPredicate("string")
            };

            var putBucketIntelligentTieringConfigurationRequest = GeneratePutRequest(intelligentTieringId, intelligentTieringFilter);
            Client.PutBucketIntelligentTieringConfiguration(putBucketIntelligentTieringConfigurationRequest);

            DeleteBucketIntelligentTieringConfigurationRequest deleteBucketIntelligentTieringConfigurationRequest = new DeleteBucketIntelligentTieringConfigurationRequest()
            {
                BucketName = bucketName,
                IntelligentTieringId = intelligentTieringId
            };
            var deleteBucketIntelligentTieringConfigurationResponse = Client.DeleteBucketIntelligentTieringConfiguration(deleteBucketIntelligentTieringConfigurationRequest);

            ListBucketIntelligentTieringConfigurationsRequest listBucketIntelligentTieringConfigurationsRequest = new ListBucketIntelligentTieringConfigurationsRequest()
            {
                BucketName = bucketName
            };

            var listBucketIntelligentTieringConfigurationsResponse = Client.ListBucketIntelligentTieringConfigurations(listBucketIntelligentTieringConfigurationsRequest);

            if (AWSConfigs.InitializeCollections)
                Assert.AreEqual(listBucketIntelligentTieringConfigurationsResponse.IntelligentTieringConfigurationList.Count, 0);
            else
                Assert.IsNull(listBucketIntelligentTieringConfigurationsResponse.IntelligentTieringConfigurationList);
        }
    }
}
