namespace AWSSDK_DotNet.IntegrationTests.Tests.DynamoDB.Fixtures
{
    /// <summary>
    /// Class-level fixture that creates HashTable and HashRangeTable.
    /// Used as IClassFixture&lt;HashTablesFixture&gt; by <see cref="DataModelHashRangeTests"/>,
    /// <see cref="DocumentMultiTableTests"/>, and <see cref="ServiceTests"/>.
    /// Each test class gets its own isolated table set (unique GUID prefix).
    /// </summary>
    public class HashTablesFixture : DynamoDBFixture
    {
        protected override DynamoDBTestTables TablesToCreate => DynamoDBTestTables.Hash | DynamoDBTestTables.HashRange;
    }
}
