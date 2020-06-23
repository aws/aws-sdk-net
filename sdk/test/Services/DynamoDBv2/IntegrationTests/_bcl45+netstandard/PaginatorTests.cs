using Amazon.DynamoDBv2;
using Amazon.DynamoDBv2.DocumentModel;
using Amazon.DynamoDBv2.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace AWSSDK_DotNet.IntegrationTests.Tests.DynamoDB
{
    public partial class DynamoDBTests : TestBase<AmazonDynamoDBClient>
    {
        /// <summary>
        /// Test the Scan, Query, and BatchGetItem paginators together on the same set of data
        /// </summary>
        [TestMethod]
        [TestCategory("DynamoDBv2")]
        public void TestScanAndQueryPaginators()
        {
            // Clear tables
            CleanupTables();

            Table hashTable;
            Table hashRangeTable;
            Table numericHashRangeTable;

            LoadTables(DynamoDBEntryConversion.V2, out hashTable, out hashRangeTable, out numericHashRangeTable);

            var itemCount = 10;
            var batchWrite = hashRangeTable.CreateBatchWrite();
            var name = "Borg";
            // Put items
            for (int i = 0; i < itemCount; i++)
            {
                Document doc = new Document();
                doc["Name"] = name;
                doc["Age"] = 1 + i;
                doc["Company"] = "Big River";
                doc["Score"] = 120 + i;
                doc["IsTester"] = true;
                doc["Manager"] = "Kirk";
                batchWrite.AddDocumentToPut(doc);
            }
            batchWrite.Execute();

            // Test ScanPaginator
            var scanRequest = new ScanRequest(hashRangeTableName);
            scanRequest.Limit = 1;

            var scanPaginator = Client.Paginators.Scan(scanRequest);
            // There'll be an extra, empty response at the end indicating we're done
           Assert.AreEqual(itemCount+1, scanPaginator.Responses.ToList().Count);

            // Test QueryPaginator
            var queryRequest = new QueryRequest()
            {
                TableName = hashRangeTableName,
                Limit = 1,
                KeyConditionExpression = "#H = :name",
                ExpressionAttributeNames = new Dictionary<string, string>
                {
                    { "#H", "Name" }
                },
                ExpressionAttributeValues = new Dictionary<string, AttributeValue>
                {
                    { ":name", new AttributeValue { S = name } }
                }
            };

            var queryPaginator = Client.Paginators.Query(queryRequest);
            // There'll be an extra, empty response at the end indicating we're done
            Assert.AreEqual(itemCount+1, queryPaginator.Responses.ToList().Count);      

            // Test BatchGetItemPaginator
            var batchGetRequest = new BatchGetItemRequest(new Dictionary<string, KeysAndAttributes>
            {
                {
                    hashRangeTableName,
                    new KeysAndAttributes
                    {
                        Keys = new List<Dictionary<string,AttributeValue>>
                        {
                            new Dictionary<string, AttributeValue>
                            {
                                { "Name", new AttributeValue { S = name} },
                                { "Age", new AttributeValue { N = "1" } }
                            }
                        }
                    }
                }
            });

            var batchPaginator = Client.Paginators.BatchGetItem(batchGetRequest);
            var responses = batchPaginator.Responses.ToList();
            Assert.AreEqual(1, responses.Count);    // there should be one BatchGetItem response
            Assert.AreEqual(1, responses[0].Responses.Count);   // with one item matching the above request
        }

        [TestMethod]
        [TestCategory("DynamoDBv2")]
        public void TestListTablesPaginator()
        {
            var tableNamesViaGetTables = GetTableNamesHelper().ToList();

            var request = new ListTablesRequest();
            request.Limit = 1;

            var listTablesPaginator = Client.Paginators.ListTables(request);          
            var tableNamesViaPaginator = listTablesPaginator.TableNames.ToList();

            tableNamesViaGetTables.Sort();
            tableNamesViaPaginator.Sort();

            Assert.AreEqual(tableNamesViaGetTables.Count, tableNamesViaPaginator.Count);
            CollectionAssert.AreEquivalent(tableNamesViaGetTables, tableNamesViaPaginator);            
        }
    }
}
