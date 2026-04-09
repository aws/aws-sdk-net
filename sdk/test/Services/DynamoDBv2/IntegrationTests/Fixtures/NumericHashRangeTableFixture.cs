namespace AWSSDK_DotNet.IntegrationTests.Tests.DynamoDB.Fixtures
{
    /// <summary>
    /// Class-level fixture that creates only NumericHashRangeTable (DateTime CreationTime hash key + string Name range key).
    /// Used as IClassFixture&lt;NumericHashRangeTableFixture&gt; by test classes that use AnnotatedNumericEpochEmployee
    /// or other models that map to the NumericHashRangeTable.
    /// Each test class gets its own isolated table (unique GUID prefix).
    /// </summary>
    public class NumericHashRangeTableFixture : DynamoDBFixture
    {
        protected override DynamoDBTestTables TablesToCreate => DynamoDBTestTables.NumericHashRange;
    }
}
