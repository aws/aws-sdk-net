using Amazon.DynamoDBv2;
using Amazon.DynamoDBv2.DataModel;
using Amazon.DynamoDBv2.Model;
using AWSSDK_DotNet.IntegrationTests.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AWSSDK_DotNet.IntegrationTests.Tests.DynamoDB.Fixtures
{
    /// <summary>
    /// Extends <see cref="SearchVectorsFixture"/> by seeding the search vectors table with
    /// the fixed dataset used by <see cref="DataModelSearchVectorsTableTests"/>.
    /// Data is written once during fixture setup so tests are read-only and GSI propagation
    /// is complete before the first test method runs.
    /// </summary>
    public class DataModelSearchVectorsTableFixture : SearchVectorsFixture
    {
        public override async ValueTask InitializeAsync()
        {
            await base.InitializeAsync();
            await SeedTableAsync();
            await WaitForVectorIndexConvergenceAsync();
        }

        private async Task SeedTableAsync()
        {
            var context = new DynamoDBContext(Client, new DynamoDBContextConfig
            {
                TableNamePrefix = TableNamePrefix,
                Conversion = DynamoDBEntryConversion.V2
            });

            var entities = new List<SearchVectorsEntity>
            {
                // Indexed: valid vector + valid HASH + valid inline filters.
                new SearchVectorsEntity
                {
                    Id = "1",
                    VectorHash = "catalog-a",
                    VectorInlineFilter1 = "books",
                    VectorInlineFilter2 = 10,
                    VectorEmbedding = DataModelSearchVectorsTableFixture.CreateSearchVector(0),
                    NonIndexedData = "meta-1"
                },
                new SearchVectorsEntity
                {
                    Id = "2",
                    VectorHash = "catalog-a",
                    VectorInlineFilter1 = "books",
                    VectorInlineFilter2 = 20,
                    VectorEmbedding = CreateSearchVector(1),
                    NonIndexedData = "meta-2"
                },
                new SearchVectorsEntity
                {
                    Id = "21",
                    VectorHash = "catalog-b",
                    VectorInlineFilter1 = "electronics",
                    VectorInlineFilter2 = 30,
                    VectorEmbedding = CreateSearchVector(2),
                    NonIndexedData = "meta-21"
                },
                new SearchVectorsEntity
                {
                    Id = "3",
                    VectorHash = "catalog-b",
                    VectorInlineFilter1 = "electronics",
                    VectorInlineFilter2 = 40,
                    VectorEmbedding = CreateSearchVector(3),
                    NonIndexedData = "meta-3"
                },

                // Indexed: inline filters are optional.
                new SearchVectorsEntity
                {
                    Id = "4",
                    VectorHash = "catalog-c",
                    VectorEmbedding = CreateSearchVector(4),
                    NonIndexedData = "meta-4"
                },

                // Not indexed: missing vector attribute.
                new SearchVectorsEntity
                {
                    Id = "5",
                    VectorHash = "catalog-c",
                    VectorInlineFilter1 = "toys",
                    VectorInlineFilter2 = 50,
                    NonIndexedData = "meta-5"
                },

                // Not indexed for VectorIndex (which requires VectorHash): missing HASH partition key for that search schema
                new SearchVectorsEntity
                {
                    Id = "6",
                    VectorInlineFilter1 = "toys",
                    VectorInlineFilter2 = 60,
                    VectorEmbedding = CreateSearchVector(5),
                    NonIndexedData = "meta-6"
                }
            };

            foreach (var entity in entities)
            {
                await context.SaveAsync(entity);
            }


            // Remove vector attribute after write so this item is removed from the vector index.
            var removeVectorEntity = new SearchVectorsEntity
            {
                Id = "7",
                VectorHash = "catalog-d",
                VectorInlineFilter1 = "games",
                VectorInlineFilter2 = 70,
                VectorEmbedding = CreateSearchVector(6),
                NonIndexedData = "meta-7"
            };

            await context.SaveAsync(removeVectorEntity);

            removeVectorEntity.VectorEmbedding = null;
            await context.SaveAsync(removeVectorEntity);

        }

        private async Task WaitForVectorIndexConvergenceAsync()
        {
            var expectedIndexedIds = new HashSet<string>
            {
                "1", "2", "21", "3", "4", "6"
            };

            await UtilityMethods.WaitUntilAsync(async () =>
            {
                var request = new SearchVectorsRequest
                {
                    TableName = SearchVectorsTableName,
                    IndexName = "VectorIndexNoHash",
                    SearchVector = CreateSearchVectorAttributeValues(0),
                    TopK = 10
                };

                var response = await Client.SearchVectorsAsync(request).ConfigureAwait(false);
                var observedIds = response.SearchResults.Select(r => r.Item["Id"].S);
                var observedSet = new HashSet<string>(observedIds);

                return observedSet.SetEquals(expectedIndexedIds);
            }, sleepSeconds: 1, maxWaitSeconds: 120).ConfigureAwait(false);
        }

        private static List<AttributeValue> CreateSearchVectorAttributeValues(int hotIndex)
        {
            var vector = CreateSearchVector(hotIndex);
            var values = new List<AttributeValue>(vector.Count);

            foreach (var item in vector)
            {
                values.Add(new AttributeValue { N = item.ToString("R", System.Globalization.CultureInfo.InvariantCulture) });
            }

            return values;
        }

        internal static List<float> CreateSearchVector(int hotIndex)
        {
            var vector = new List<float>(1536);
            for (var i = 0; i < 1536; i++)
            {
                vector.Add(i == hotIndex ? 1f : 0f);
            }

            return vector;
        }
    }
}
