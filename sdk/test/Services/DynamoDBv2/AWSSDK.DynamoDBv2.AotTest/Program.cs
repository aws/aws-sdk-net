using Amazon.DynamoDBv2;
using Amazon.DynamoDBv2.DataModel;
using Amazon.Runtime;

var config = new AmazonDynamoDBConfig { ServiceURL = $"http://localhost:8000" };
var credentials = new BasicAWSCredentials("access", "secret");
var dynamoDbClient = new AmazonDynamoDBClient(credentials, config);
var context = new DynamoDBContext(dynamoDbClient);

//var table = await dynamoDbClient.CreateTableAsync(new CreateTableRequest
//{
//    TableName = "TestTable",
//    AttributeDefinitions =
//    [
//        new AttributeDefinition
//        {
//            AttributeName = "Id",
//            AttributeType = ScalarAttributeType.S
//        }
//    ],
//    KeySchema =
//    [
//        new KeySchemaElement
//        {
//            AttributeName = "Id",
//            KeyType = KeyType.HASH
//        }
//    ],
//    ProvisionedThroughput = new ProvisionedThroughput
//    {
//        ReadCapacityUnits = 1,
//        WriteCapacityUnits = 1
//    }
//});

Console.WriteLine("Table created");

await context.SaveAsync(new TestType
{
    Id = "1",
    Name = "Test",
    Values = ["Value1", "Value2"],
    //SubType = new() { SubName = "Subname" }
});
Console.WriteLine("Item saved.");

var item = await context.LoadAsync<TestType>("1");
Console.WriteLine($"Item loaded: {item}");
Console.WriteLine($"Values: {string.Join(",", item.Values)}");

[DynamoDBTable("TestTable")]
record class TestType
{
    [DynamoDBHashKey]
    public string Id { get; set; }

    public string Name { get; set; }

    public HashSet<string> Values { get; set; }

    public SubType SubType { get; set; }
}

record class SubType
{
    public string SubName { get; set; }
}