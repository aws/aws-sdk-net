using Amazon.DynamoDBv2.DataModel;
using Amazon.DynamoDBv2.DocumentModel;

namespace AWSSDK.Benchmarks.MockedDynamoDB;

public class UppercaseStringConverter : IPropertyConverter
{
    public DynamoDBEntry ToEntry(object value)
    {
        return new Primitive(value?.ToString()?.ToUpperInvariant(), true);
    }

    public object FromEntry(DynamoDBEntry entry)
    {
        return entry.AsString();
    }
}
