namespace AWSSDK_DotNet.IntegrationTests.Tests.DynamoDB.Fixtures
{
    /// <summary>
    /// Class-level fixture that creates HashRangeTable and NumericHashRangeTable.
    /// Used as IClassFixture&lt;TTLTablesFixture&gt; by TTLTests.
    /// Each test class gets its own isolated table set (unique GUID prefix).
    /// </summary>
    public class TTLTablesFixture : DynamoDBFixture
    {
        protected override DynamoDBTestTables TablesToCreate =>
            DynamoDBTestTables.HashRange |
            DynamoDBTestTables.NumericHashRange;
    }
}
