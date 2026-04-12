using Amazon.DynamoDBv2.DataModel;

namespace AWSSDK_DotNet.IntegrationTests.Tests.DynamoDB
{
    /// <summary>
    /// A class has a flattened property, which itself contains another flattened property.
    /// </summary>
    [DynamoDBTable("HashTable")]
    public class EmployeeNonFlat
    {
        [DynamoDBHashKey("Id")]
        public int EmployeeId { get; set; }

        [DynamoDBFlatten]
        public ContactInfo Contact { get; set; }
    }

    public class ContactInfo
    {
        public string Email { get; set; }

        [DynamoDBFlatten]
        public Address Address { get; set; }
    }

    /// <summary>
    /// A class has a flattened structure
    /// </summary>
    [DynamoDBTable("HashTable")]
    public class EmployeeFlatten
    {
        [DynamoDBHashKey("Id")]
        public int EmployeeId { get; set; }

        public string Email { get; set; }

        public string Street { get; set; }

        public string City { get; set; }
    }

    [DynamoDBTable("HashTable")]
    public class Order
    {
        [DynamoDBHashKey]
        public int Id { get; set; }

        [DynamoDBFlatten]
        public PaymentInfo Payment { get; set; }

        public string CompanyInfo { get; set; }
    }

    public class PaymentInfo
    {
        [DynamoDBGlobalSecondaryIndexHashKey("GlobalIndex", AttributeName = "Company")]
        public string CompanyName { get; set; }

        [DynamoDBGlobalSecondaryIndexRangeKey("GlobalIndex")]
        public int Price { get; set; }
    }

    /// <summary>
    /// A flattened property contains a property with a custom converter.
    /// </summary>
    [DynamoDBTable("HashTable")]
    public class Event
    {
        [DynamoDBHashKey]
        public int Id { get; set; }

        [DynamoDBFlatten]
        public EventDetails Details { get; set; }
    }

    public class EventDetails
    {
        [DynamoDBProperty(typeof(DateTimeUtcConverter))]
        public System.DateTime EventDate { get; set; }
    }
}
