using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Amazon.DynamoDBv2;
using Amazon.DynamoDBv2.Model;

namespace AWSSDKDocSamples.Amazon.DynamoDBv2.Generated
{
    class DynamoDBSamples : ISample
    {
        public void DynamoDBBatchGetItem()
        {
            #region BatchGetItem-1

            var client = new AmazonDynamoDBClient();
            var response = client.BatchGetItem(new BatchGetItemRequest
            {
                RequestItems = new Dictionary<string, KeysAndAttributes> {
                    { "Music", new KeysAndAttributes {
                        Keys = new List<Dictionary<string, AttributeValue>> {
                            new Dictionary<string, AttributeValue> {
                                { "Artist", new AttributeValue { S = "No One You Know" } },
                                { "SongTitle", new AttributeValue { S = "Call Me Today" } }
                            },
                            new Dictionary<string, AttributeValue> {
                                { "Artist", new AttributeValue { S = "Acme Band" } },
                                { "SongTitle", new AttributeValue { S = "Happy Day" } }
                            },
                            new Dictionary<string, AttributeValue> {
                                { "Artist", new AttributeValue { S = "No One You Know" } },
                                { "SongTitle", new AttributeValue { S = "Scared of My Shadow" } }
                            }
                        },
                        ProjectionExpression = "AlbumTitle"
                    } }
                }
            });

            Dictionary<string, List<Dictionary<string, AttributeValue>>> responses = response.Responses;

            #endregion
        }

        public void DynamoDBBatchWriteItem()
        {
            #region BatchWriteItem-1

            var client = new AmazonDynamoDBClient();
            var response = client.BatchWriteItem(new BatchWriteItemRequest
            {
                RequestItems = new Dictionary<string, List<WriteRequest>> {
                    { "Music", new List<WriteRequest> {
                        new WriteRequest { PutRequest = new PutRequest { Item = new Dictionary<string, AttributeValue> {
                            { "AlbumTitle", new AttributeValue { S = "Somewhat Famous" } },
                            { "Artist", new AttributeValue { S = "No One You Know" } },
                            { "SongTitle", new AttributeValue { S = "Call Me Today" } }
                        } } },
                        new WriteRequest { PutRequest = new PutRequest { Item = new Dictionary<string, AttributeValue> {
                            { "AlbumTitle", new AttributeValue { S = "Songs About Life" } },
                            { "Artist", new AttributeValue { S = "Acme Band" } },
                            { "SongTitle", new AttributeValue { S = "Happy Day" } }
                        } } },
                        new WriteRequest { PutRequest = new PutRequest { Item = new Dictionary<string, AttributeValue> {
                            { "AlbumTitle", new AttributeValue { S = "Blue Sky Blues" } },
                            { "Artist", new AttributeValue { S = "No One You Know" } },
                            { "SongTitle", new AttributeValue { S = "Scared of My Shadow" } }
                        } } }
                    } }
                }
            });


            #endregion
        }

        public void DynamoDBDeleteItem()
        {
            #region DeleteItem-1

            var client = new AmazonDynamoDBClient();
            var response = client.DeleteItem(new DeleteItemRequest
            {
                Key = new Dictionary<string, AttributeValue> {
                    { "Artist", new AttributeValue { S = "No One You Know" } },
                    { "SongTitle", new AttributeValue { S = "Scared of My Shadow" } }
                },
                TableName = "Music"
            });

            ConsumedCapacity consumedCapacity = response.ConsumedCapacity;

            #endregion
        }

        public void DynamoDBDeleteTable()
        {
            #region DeleteTable-1

            var client = new AmazonDynamoDBClient();
            var response = client.DeleteTable(new DeleteTableRequest
            {
                TableName = "Music"
            });

            TableDescription tableDescription = response.TableDescription;

            #endregion
        }

        public void DynamoDBDescribeLimits()
        {
            #region DescribeLimits-1

            var client = new AmazonDynamoDBClient();
            var response = client.DescribeLimits(new DescribeLimitsRequest
            {
            });

            long? accountMaxReadCapacityUnits = response.AccountMaxReadCapacityUnits;
            long? accountMaxWriteCapacityUnits = response.AccountMaxWriteCapacityUnits;
            long? tableMaxReadCapacityUnits = response.TableMaxReadCapacityUnits;
            long? tableMaxWriteCapacityUnits = response.TableMaxWriteCapacityUnits;

            #endregion
        }

        public void DynamoDBGetItem()
        {
            #region GetItem-1

            var client = new AmazonDynamoDBClient();
            var response = client.GetItem(new GetItemRequest
            {
                Key = new Dictionary<string, AttributeValue> {
                    { "Artist", new AttributeValue { S = "Acme Band" } },
                    { "SongTitle", new AttributeValue { S = "Happy Day" } }
                },
                TableName = "Music"
            });

            Dictionary<string, AttributeValue> item = response.Item;

            #endregion
        }

        public void DynamoDBListTables()
        {
            #region ListTables-1

            var client = new AmazonDynamoDBClient();
            var response = client.ListTables(new ListTablesRequest
            {
            });

            List<string> tableNames = response.TableNames;

            #endregion
        }

        public void DynamoDBPutItem()
        {
            #region PutItem-1

            var client = new AmazonDynamoDBClient();
            var response = client.PutItem(new PutItemRequest
            {
                Item = new Dictionary<string, AttributeValue> {
                    { "AlbumTitle", new AttributeValue { S = "Somewhat Famous" } },
                    { "Artist", new AttributeValue { S = "No One You Know" } },
                    { "SongTitle", new AttributeValue { S = "Call Me Today" } }
                },
                ReturnConsumedCapacity = "TOTAL",
                TableName = "Music"
            });

            ConsumedCapacity consumedCapacity = response.ConsumedCapacity;

            #endregion
        }

        public void DynamoDBQuery()
        {
            #region Query-1

            var client = new AmazonDynamoDBClient();
            var response = client.Query(new QueryRequest
            {
                ExpressionAttributeValues = new Dictionary<string, AttributeValue> {
                    { ":v1", new AttributeValue { S = "No One You Know" } }
                },
                KeyConditionExpression = "Artist = :v1",
                ProjectionExpression = "SongTitle",
                TableName = "Music"
            });

            ConsumedCapacity consumedCapacity = response.ConsumedCapacity;
            int? count = response.Count;
            List<Dictionary<string, AttributeValue>> items = response.Items;
            int? scannedCount = response.ScannedCount;

            #endregion
        }

        public void DynamoDBScan()
        {
            #region Scan-1

            var client = new AmazonDynamoDBClient();
            var response = client.Scan(new ScanRequest
            {
                ExpressionAttributeNames = new Dictionary<string, string> {
                    { "#AT", "AlbumTitle" },
                    { "#ST", "SongTitle" }
                },
                ExpressionAttributeValues = new Dictionary<string, AttributeValue> {
                    { ":a", new AttributeValue { S = "No One You Know" } }
                },
                FilterExpression = "Artist = :a",
                ProjectionExpression = "#ST, #AT",
                TableName = "Music"
            });

            ConsumedCapacity consumedCapacity = response.ConsumedCapacity;
            int? count = response.Count;
            List<Dictionary<string, AttributeValue>> items = response.Items;
            int? scannedCount = response.ScannedCount;

            #endregion
        }

        public void DynamoDBSearchVectors()
        {
            #region SearchVectors-1

            var client = new AmazonDynamoDBClient();
            var response = client.SearchVectors(new SearchVectorsRequest
            {
                ExpressionAttributeValues = new Dictionary<string, AttributeValue> {
                    { ":cat", new AttributeValue { S = "Electronics" } }
                },
                IndexName = "cosine-product-idx",
                ProjectionExpression = "ProductName, Price",
                ReturnConsumedCapacity = "INDEXES",
                SearchConditionExpression = "Category = :cat",
                SearchVector = new List<AttributeValue> {
                    new AttributeValue { N = "0.12" },
                    new AttributeValue { N = "0.85" },
                    new AttributeValue { N = "0.44" },
                    new AttributeValue { N = "0.67" }
                },
                TableName = "Products",
                TopK = 3
            });

            VectorCapacity consumedCapacity = response.ConsumedCapacity;
            List<SearchResultItem> searchResults = response.SearchResults;

            #endregion
        }

        public void DynamoDBUpdateItem()
        {
            #region UpdateItem-1

            var client = new AmazonDynamoDBClient();
            var response = client.UpdateItem(new UpdateItemRequest
            {
                ExpressionAttributeNames = new Dictionary<string, string> {
                    { "#AT", "AlbumTitle" },
                    { "#Y", "Year" }
                },
                ExpressionAttributeValues = new Dictionary<string, AttributeValue> {
                    { ":t", new AttributeValue { S = "Louder Than Ever" } },
                    { ":y", new AttributeValue { N = "2015" } }
                },
                Key = new Dictionary<string, AttributeValue> {
                    { "Artist", new AttributeValue { S = "Acme Band" } },
                    { "SongTitle", new AttributeValue { S = "Happy Day" } }
                },
                ReturnValues = "ALL_NEW",
                TableName = "Music",
                UpdateExpression = "SET #Y = :y, #AT = :t"
            });

            Dictionary<string, AttributeValue> attributes = response.Attributes;

            #endregion
        }

        public void DynamoDBUpdateTable()
        {
            #region UpdateTable-1

            var client = new AmazonDynamoDBClient();
            var response = client.UpdateTable(new UpdateTableRequest
            {
                ProvisionedThroughput = new ProvisionedThroughput {
                    ReadCapacityUnits = 10,
                    WriteCapacityUnits = 10
                },
                TableName = "MusicCollection"
            });

            TableDescription tableDescription = response.TableDescription;

            #endregion
        }

        public void DynamoDBUpdateTable()
        {
            #region UpdateTable-2

            var client = new AmazonDynamoDBClient();
            var response = client.UpdateTable(new UpdateTableRequest
            {
                DisassociationProtectionEnabled = false,
                TableName = "MusicCollection"
            });

            TableDescription tableDescription = response.TableDescription;

            #endregion
        }

        public void DynamoDBUpdateTable()
        {
            #region UpdateTable-3

            var client = new AmazonDynamoDBClient();
            var response = client.UpdateTable(new UpdateTableRequest
            {
                ReplicaUpdates = new List<ReplicationGroupUpdate> {
                    new ReplicationGroupUpdate { Disassociate = new DisassociateReplicationGroupMemberAction {
                        DisassociationMode = "WAIT_FOR_REPLICATION",
                        RegionName = "us-west-2"
                    } }
                },
                TableName = "arn:aws:dynamodb:us-west-2:123456789012:table/MusicCollection"
            });

            TableDescription tableDescription = response.TableDescription;

            #endregion
        }

        #region ISample Members
        public virtual void Run()
        {
        }
        #endregion
    }
}
