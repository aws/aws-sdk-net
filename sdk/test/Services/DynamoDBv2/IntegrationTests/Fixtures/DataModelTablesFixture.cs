namespace AWSSDK_DotNet.IntegrationTests.Tests.DynamoDB.Fixtures
{
    /// <summary>
    /// Class-level fixture that creates Hash, HashRange, NumericHashRange, and CompositeHashRange tables.
    /// Used as IClassFixture&lt;DataModelTablesFixture&gt; by <see cref="DataModelMultiTableTests"/>, which exercises
    /// batch operations, multi-table transactions, and builder patterns across all table types.
    /// Each test class gets its own isolated table set (unique GUID prefix).
    /// </summary>
    public class DataModelTablesFixture : DynamoDBFixture
    {
        protected override DynamoDBTestTables TablesToCreate =>
            DynamoDBTestTables.Hash |
            DynamoDBTestTables.HashRange |
            DynamoDBTestTables.NumericHashRange |
            DynamoDBTestTables.CompositeHashRange;
    }
}
