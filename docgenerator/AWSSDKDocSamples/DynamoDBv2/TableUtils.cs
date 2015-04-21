using Amazon.DynamoDBv2;
using Amazon.DynamoDBv2.Model;
using AWSSDKDocSamples.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWSSDKDocSamples.DynamoDBv2
{
    public static class TableUtils
    {
        public static void ConfirmTableExistence(string tableName, IAmazonDynamoDB client, List<KeySchemaElement> tableSchema, List<AttributeDefinition> attributeDefinitions)
        {
            ConfirmTableExistence(tableName, client, tableSchema, attributeDefinitions, 10, 10);
        }
        public static void ConfirmTableExistence(string tableName, IAmazonDynamoDB client, List<KeySchemaElement> tableSchema, List<AttributeDefinition> attributeDefinitions, int reads, int writes)
        {
            Console.WriteLine("Confirming table " + tableName + " existence");
            string tableStatus = null;
            tableStatus = WaitUntilTableStable(tableName, client, tableStatus);

            if (string.IsNullOrEmpty(tableStatus))
            {
                Console.WriteLine("Creating table " + tableName);
                var tableDescription = client.CreateTable(new CreateTableRequest
                {
                    TableName = tableName,
                    ProvisionedThroughput = new ProvisionedThroughput { ReadCapacityUnits = reads, WriteCapacityUnits = writes },
                    KeySchema = tableSchema,
                    AttributeDefinitions = attributeDefinitions
                }).TableDescription;
                WaitUntilTableCreated(tableName, client);
            }
            else
            {
                Console.WriteLine("Not creating table " + tableName + ", status is " + tableStatus);
            }
        }

        public static void WaitUntilTableCreated(string tableName, IAmazonDynamoDB client)
        {
            Common.WaitUntil(() =>
            {
                string status = GetTableStatus(tableName, client);
                return !status.Equals("CREATING") && !status.Equals(string.Empty);
            });
        }
        public static void WaitUntilTableDeleted(string tableName, IAmazonDynamoDB client)
        {
            Common.WaitUntil(() => GetTableStatus(tableName, client) == null);
        }
        public static void WaitUntilTableActive(string tableName, IAmazonDynamoDB client)
        {
            Common.WaitUntil(() => GetTableStatus(tableName, client) == TableStatus.ACTIVE);
        }
        private static string WaitUntilTableStable(string tableName, IAmazonDynamoDB client, string tableStatus)
        {
            Common.WaitUntil(() =>
            {
                tableStatus = GetTableStatus(tableName, client);
                if (tableStatus == null)
                    return true;

                return
                    !tableStatus.Equals("DELETING", StringComparison.OrdinalIgnoreCase) &&
                    !tableStatus.Equals("CREATING", StringComparison.OrdinalIgnoreCase);
            });
            return tableStatus;
        }

        public static void DeleteTables(IAmazonDynamoDB client, string partialName)
        {
            DeleteTables(client, tableName => tableName.IndexOf(partialName, StringComparison.OrdinalIgnoreCase) >= 0);
        }
        public static void DeleteTable(IAmazonDynamoDB client, string tableName)
        {
            DeleteTables(client, name => string.Equals(name, tableName, StringComparison.Ordinal));
        }
        public static void DeleteTables(IAmazonDynamoDB client, Predicate<string> tableNameMatch)
        {
            try
            {
                var tableNames = client.ListTables().TableNames;
                foreach (var tableName in tableNames)
                {
                    DescribeTableResponse descResponse = client.DescribeTable(new DescribeTableRequest { TableName = tableName });
                    if (descResponse.Table == null)
                        continue;

                    TableDescription table = descResponse.Table;

                    if (table.TableStatus == TableStatus.ACTIVE && tableNameMatch(table.TableName))
                    {
                        Console.WriteLine("Table: {0}, {1}, {2}, {3}", table.TableName, table.TableStatus, table.ProvisionedThroughput.ReadCapacityUnits, table.ProvisionedThroughput.WriteCapacityUnits);
                        Console.WriteLine("Deleting table " + table.TableName + "...");
                        try
                        {
                            client.DeleteTable(new DeleteTableRequest { TableName = table.TableName });
                            WaitUntilTableDeleted(table.TableName, client);
                            Console.WriteLine("Succeeded!");
                        }
                        catch
                        {
                            Console.WriteLine("Failed!");
                        }
                    }
                }
                Console.WriteLine(tableNames.Count);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                throw;
            }
        }
        public static void DeleteTables(IAmazonDynamoDB client, params string[] tableNames)
        {
            DeleteTables(client, tableName => tableNames.Contains(tableName, StringComparer.Ordinal));
        }

        public static TableStatus GetTableStatus(string tableName, IAmazonDynamoDB client)
        {
            try
            {
                var table = client.DescribeTable(new DescribeTableRequest
                {
                    TableName = tableName
                }).Table;

                return table.TableStatus;
            }
            catch (AmazonDynamoDBException db)
            {
                if (db.ErrorCode == "ResourceNotFoundException")
                    return null;

                throw;
            }
        }
    }
}
