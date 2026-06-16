namespace AWSSDK_DotNet.IntegrationTests.Tests.DynamoDB.Fixtures
{
    /// <summary>
    /// Class-level fixture that creates only the NestedTable (GUID string Id hash key).
    /// Used as IClassFixture&lt;NestedTableFixture&gt; by test classes that use ModelA and derived types
    /// (ModelA1, ModelA2) which map to the NestedTable.
    /// Each test class gets its own isolated table (unique GUID prefix).
    /// </summary>
    public class NestedTableFixture : DynamoDBFixture
    {
        protected override DynamoDBTestTables TablesToCreate => DynamoDBTestTables.Nested;
    }
}
