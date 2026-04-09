using Amazon.DynamoDBv2.DataModel;

namespace AWSSDK_DotNet.IntegrationTests.Tests.DynamoDB
{
    [DynamoDBTable("HashTable")]
    public class TtlTestItem
    {
        [DynamoDBHashKey]
        public int Id { get; set; }

        public string Data { get; set; }

        [DynamoDBProperty("TTL")]
        public long Ttl { get; set; }
    }

    [DynamoDBTable("HashTable")]
    public class OrderIndex
    {
        [DynamoDBHashKey]
        public int Id { get; set; }

        [DynamoDBProperty("Company")]
        public string CompanyName { get; set; }

        [DynamoDBGlobalSecondaryIndexHashKey("GlobalIndex")]
        public string CompanyInfo { get; set; }

        [DynamoDBGlobalSecondaryIndexRangeKey("GlobalIndex")]
        public int Price { get; set; }
    }

    [DynamoDBTable("HashRangeTable")]
    public class AnnotatedRangeTable
    {
        [DynamoDBHashKey] public string Name { get; set; }

        [DynamoDBRangeKey] internal int Age { get; set; }
    }

    [DynamoDBTable("HashRangeTable")]
    public class IgnoreAnnotatedRangeTable : AnnotatedRangeTable
    {
        [DynamoDBIgnore] internal int IgnoreAttribute { get; set; }
    }

    [DynamoDBTable("HashRangeTable")]
    public class AnnotatedRangeTable2 : AnnotatedRangeTable
    {
        internal int NotAnnotatedAttribute { get; set; }
    }

    /// <summary>
    /// Table with a property converter.
    /// </summary>
    [DynamoDBTable("HashTable")]
    public class PropertyConverterTable
    {
        [DynamoDBHashKey]
        public int Id { get; set; }

        public NameType PropertyWithGlobalConverter { get; set; }

        [DynamoDBProperty(Converter = typeof(NameTypeLowerCaseConverter<NameType>))]
        public NameType PropertyWithPropertyConvertor { get; set; }
    }

    public class NameType
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
    }

    [DynamoDBTable("CompositeHashRangeTable")]
    public class CompositeHashRangeEntity
    {
        [DynamoDBHashKey]
        [DynamoDBGlobalSecondaryIndexHashKey("GSI4", Order = 1)]
        public int Id { get; set; }

        [DynamoDBRangeKey]
        [DynamoDBGlobalSecondaryIndexRangeKey("GSI3", Order = 1)]
        [DynamoDBGlobalSecondaryIndexRangeKey("GSI4", Order = 1)]
        public string Status { get; set; }

        [DynamoDBGlobalSecondaryIndexHashKey("GSI1")]
        [DynamoDBGlobalSecondaryIndexHashKey("GSI3", Order = 1)]
        [DynamoDBGlobalSecondaryIndexHashKey("GSI2", Order = 2)]
        [DynamoDBGlobalSecondaryIndexHashKey("GSI4", Order = 2)]
        public string UserName { get; set; }

        [DynamoDBGlobalSecondaryIndexRangeKey("GSI1")]
        [DynamoDBGlobalSecondaryIndexRangeKey("GSI2")]
        public int Timestamp { get; set; }

        [DynamoDBGlobalSecondaryIndexHashKey("GSI2", Order = 1)]
        [DynamoDBGlobalSecondaryIndexHashKey("GSI4", Order = 3)]
        public string OrderId { get; set; }

        [DynamoDBGlobalSecondaryIndexHashKey("GSI3", Order = 2)]
        [DynamoDBGlobalSecondaryIndexHashKey("GSI4", Order = 4)]
        public string Region { get; set; }

        [DynamoDBGlobalSecondaryIndexRangeKey("GSI3", Order = 2)]
        [DynamoDBGlobalSecondaryIndexRangeKey("GSI4", Order = 2)]
        public string Category { get; set; }

        [DynamoDBGlobalSecondaryIndexRangeKey("GSI4", Order = 3)]
        public int Amount { get; set; }

        [DynamoDBGlobalSecondaryIndexRangeKey("GSI4", Order = 4)]
        public int Priority { get; set; }
    }

    public class Base
    {
        public virtual int Age { get; set; }
    }

    [DynamoDBTable("HashRangeTable")]
    public class Derived : Base
    {
        [DynamoDBHashKey]
        public string Name { get; set; }

        [DynamoDBRangeKey]
        public override int Age { get; set; }

        public string Data { get; set; }
    }

    public class BaseClassExample
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public string Data { get; set; }
    }

    [DynamoDBTable("HashRangeTable")]
    public class DerivedClassExample : BaseClassExample
    {
        [DynamoDBHashKey]
        public new string Name
        {
            get => base.Name;
            set => base.Name = value;
        }

        [DynamoDBRangeKey]
        public new int Age { get; set; }
    }
}
