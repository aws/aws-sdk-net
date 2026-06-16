using Amazon.DynamoDBv2.DataModel;
using System;

namespace AWSSDK_DotNet.IntegrationTests.Tests.DynamoDB
{
    /// <summary>
    /// Class representing items in the table [TableNamePrefix]HashTable
    /// Two fields are being stored as epoch seconds, two are not.
    /// </summary>
    public class EpochEmployee : Employee
    {
        [DynamoDBProperty(StoreAsEpoch = true)]
        public virtual DateTime CreationTime { get; set; }

        [DynamoDBProperty(StoreAsEpoch = true)]
        public DateTime EpochDate2 { get; set; }

        [DynamoDBProperty(StoreAsEpoch = false)]
        public DateTime NonEpochDate1 { get; set; }

        public DateTime NonEpochDate2 { get; set; }

        [DynamoDBProperty(StoreAsEpoch = true)]
        public DateTime? NullableEpochDate1 { get; set; }

        [DynamoDBProperty(StoreAsEpoch = true)]
        public DateTime? NullableEpochDate2 { get; set; }

        [DynamoDBProperty(StoreAsEpochLong = true)]
        public DateTime LongEpochDate1 { get; set; }

        [DynamoDBProperty(StoreAsEpochLong = true)]
        public DateTime LongEpochDate2 { get; set; }

        [DynamoDBProperty(StoreAsEpochLong = true)]
        public DateTime? NullableLongEpochDate1 { get; set; }

        [DynamoDBProperty(StoreAsEpochLong = true)]
        public DateTime? NullableLongEpochDate2 { get; set; }
    }

    /// <summary>
    /// Annotated class representing items in the table [TableNamePrefix]HashTable
    /// Two fields are being stored as epoch seconds, two are not.
    /// </summary>
    [DynamoDBTable("NumericHashRangeTable")]
    public class AnnotatedEpochEmployee
    {
        [DynamoDBRangeKey] public string Name { get; set; }

        public int Age { get; set; }

        // Hash key
        [DynamoDBHashKey(StoreAsEpoch = true)] public virtual DateTime CreationTime { get; set; }

        [DynamoDBProperty(StoreAsEpoch = true)]
        public DateTime EpochDate2 { get; set; }

        [DynamoDBProperty(StoreAsEpoch = false)]
        public DateTime NonEpochDate1 { get; set; }

        public DateTime NonEpochDate2 { get; set; }
    }

    /// <summary>
    /// Class representing items in the table [TableNamePrefix]NumericHashRangeTable.
    /// </summary>
    [DynamoDBTable("NumericHashRangeTable")]
    public class NumericEpochEmployee : EpochEmployee
    {
    }

    /// <summary>
    /// Class representing items in the table [TableNamePrefix]NumericHashRangeTable.
    /// </summary>
    [DynamoDBTable("NumericHashRangeTable")]
    public class AnnotatedNumEpochEmployee : AnnotatedEpochEmployee
    {
    }

    /// <summary>
    /// Class representing items in the table [TableNamePrefix]NumericHashRangeTable.
    /// </summary>
    [DynamoDBTable("BadEmployeeHashRangeTable")]
    public class BadNumericEpochEmployee : NumericEpochEmployee
    {
        [DynamoDBProperty(StoreAsEpoch = true, StoreAsEpochLong = true)]
        public DateTime BadLongEpochDate { get; set; }
    }

    /// <summary>
    /// Same structure as <see cref="NumericEpochEmployee"/>, but the Hash key is annotated
    /// </summary>
    [DynamoDBTable("NumericHashRangeTable")]
    public class AnnotatedNumericEpochEmployee : EpochEmployee
    {
        [DynamoDBHashKey(StoreAsEpoch = true)] public override DateTime CreationTime { get; set; }

        [DynamoDBRangeKey] public override string Name { get; set; }
    }

    /// <summary>
    /// Table with a property converter on range key.
    /// </summary>
    [DynamoDBTable("NumericHashRangeTable")]
    public class PropertyConverterEmployee
    {
        [DynamoDBHashKey(StoreAsEpoch = true)] public DateTime CreationTime { get; set; }

        [DynamoDBRangeKey]
        [DynamoDBProperty(Converter = typeof(EnumAsStringConverter<Status>))]
        public Status Name { get; set; }
    }
}
