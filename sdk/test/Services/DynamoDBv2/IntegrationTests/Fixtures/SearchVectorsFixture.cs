using Amazon.DynamoDBv2;

namespace AWSSDK_DotNet.IntegrationTests.Tests.DynamoDB.Fixtures
{
    /// <summary>
    /// Class-level fixture that creates only the vector-search test table (SearchVectorsTable) and its vector indexes.
    /// Each test class gets its own isolated table (unique GUID prefix).
    /// </summary>
    public class SearchVectorsFixture : DynamoDBFixture
    {
        protected override DynamoDBTestTables TablesToCreate => DynamoDBTestTables.SearchVectorsFixture;
    }
}
