namespace AWSSDK_DotNet.IntegrationTests.Tests.DynamoDB.Fixtures
{
    /// <summary>
    /// Class-level fixture that creates only HashRangeTable (string Name hash key + number Age range key).
    /// Used as IClassFixture&lt;HashRangeTableFixture&gt; by <see cref="DocumentHashRangeTests"/> and <see cref="JSONTests"/>.
    /// Each test class gets its own isolated table (unique GUID prefix).
    /// </summary>
    public class HashRangeTableFixture : DynamoDBFixture
    {
        protected override DynamoDBTestTables TablesToCreate => DynamoDBTestTables.HashRange;
    }
}
