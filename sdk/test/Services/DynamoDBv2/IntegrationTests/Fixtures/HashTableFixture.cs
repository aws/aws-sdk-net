namespace AWSSDK_DotNet.IntegrationTests.Tests.DynamoDB.Fixtures
{
    /// <summary>
    /// Class-level fixture that creates only HashTable (int Id hash key).
    /// Used as IClassFixture&lt;HashTableFixture&gt; by test classes that write Product, VersionedProduct,
    /// ProductFlat, ProductWithCreateTimestamp, or other models with numeric hash keys.
    /// Each test class gets its own isolated table (unique GUID prefix).
    /// </summary>
    public class HashTableFixture : DynamoDBFixture
    {
        protected override DynamoDBTestTables TablesToCreate => DynamoDBTestTables.Hash;
    }
}
