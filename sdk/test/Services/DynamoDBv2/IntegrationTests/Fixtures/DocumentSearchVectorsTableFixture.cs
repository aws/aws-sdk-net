using Amazon.DynamoDBv2;
using Amazon.DynamoDBv2.DocumentModel;
using Amazon.DynamoDBv2.Model;
using AWSSDK_DotNet.IntegrationTests.Utils;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AWSSDK_DotNet.IntegrationTests.Tests.DynamoDB.Fixtures
{
    /// <summary>
    /// Extends <see cref="SearchVectorsFixture"/> by seeding the vector-search table with
    /// deterministic embeddings and inline-filter attributes for integration tests.
    /// </summary>
    public class DocumentSearchVectorsTableFixture : SearchVectorsFixture
    {
        public override async ValueTask InitializeAsync()
        {
            await base.InitializeAsync();
            await SeedTableAsync();
            await WaitForVectorIndexConvergenceAsync();
        }

        private async Task SeedTableAsync()
        {
            var table = Table.LoadTable(Client, SearchVectorsTableName, DynamoDBEntryConversion.V2, true);
            var docs = new List<Document>
            {
                // Indexed: valid vector + valid HASH + valid inline filters.
                new Document 
                { 
                    ["Id"] = "1",
                    ["VectorHash"] = "catalog-a",
                    ["VectorInlineFilter1"] = "books",
                    ["VectorInlineFilter2"] = 10,
                    ["VectorEmbedding"] = CreateEmbedding(0)
                },
                new Document 
                { 
                    ["Id"] = "2",
                    ["VectorHash"] = "catalog-a",
                    ["VectorInlineFilter1"] = "books",
                    ["VectorInlineFilter2"] = 20,
                    ["VectorEmbedding"] = CreateEmbedding(1)
                },
                new Document
                { 
                    ["Id"] = "21",
                    ["VectorHash"] = "catalog-b",
                    ["VectorInlineFilter1"] = "electronics",
                    ["VectorInlineFilter2"] = 30,
                    ["VectorEmbedding"] = CreateEmbedding(2)
                },
                new Document 
                {
                    ["Id"] = "3",
                    ["VectorHash"] = "catalog-b",
                    ["VectorInlineFilter1"] = "electronics",
                    ["VectorInlineFilter2"] = 40,
                    ["VectorEmbedding"] = CreateEmbedding(3)
                },

                // Indexed: inline filters are optional.
                new Document 
                {
                    ["Id"] = "4",
                    ["VectorHash"] = "catalog-c",
                    ["VectorEmbedding"] = CreateEmbedding(4)
                },

                // Not indexed: missing vector attribute.
                new Document
                {
                    ["Id"] = "5",
                    ["VectorHash"] = "catalog-c",
                    ["VectorInlineFilter1"] = "toys",
                    ["VectorInlineFilter2"] = 50
                },

                new Document    
                {
                    ["Id"] = "6",
                    ["VectorInlineFilter1"] = "toys",
                    ["VectorInlineFilter2"] = 60,
                    ["VectorEmbedding"] = CreateEmbedding(5)
                },
            };

            foreach (var doc in docs)
            {
                await table.PutItemAsync(doc);
            }

            // Remove vector attribute after write so this item is removed from the vector index.
            var removeVector = new Document
            {
                ["Id"] = "7",
                ["VectorHash"] = "catalog-d",
                ["VectorInlineFilter1"] = "games",
                ["VectorInlineFilter2"] = 70,
                ["VectorEmbedding"] = CreateEmbedding(6)
            };

            await table.PutItemAsync(removeVector);
            await Client.UpdateItemAsync(new UpdateItemRequest
            {
                TableName = SearchVectorsTableName,
                Key = new Dictionary<string, AttributeValue>
                {
                    { "Id", new AttributeValue { S = "7" } }
                },
                UpdateExpression = "REMOVE #V",
                ExpressionAttributeNames = new Dictionary<string, string>
                {
                    { "#V", "VectorEmbedding" }
                }
            });

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

        private static DynamoDBList CreateEmbedding(int hotIndex)
        {
            var entries = new List<DynamoDBEntry>(1536);
            for (var i = 0; i < 1536; i++)
            {
                var value = i == hotIndex ? "1" : "0";
                entries.Add(new Primitive(value, true));
            }

            return new DynamoDBList(entries);
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
    }
}
