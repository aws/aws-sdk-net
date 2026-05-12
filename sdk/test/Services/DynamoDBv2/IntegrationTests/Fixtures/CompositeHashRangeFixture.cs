namespace AWSSDK_DotNet.IntegrationTests.Tests.DynamoDB.Fixtures
{
    /// <summary>
    /// Class-level fixture that creates only CompositeHashRangeTable (int Id hash key + string Status range key).
    /// Each test class gets its own isolated table (unique GUID prefix).
    /// </summary>
    public class CompositeHashRangeFixture : DynamoDBFixture
    {
        protected override DynamoDBTestTables TablesToCreate => DynamoDBTestTables.CompositeHashRange;
    }
}
