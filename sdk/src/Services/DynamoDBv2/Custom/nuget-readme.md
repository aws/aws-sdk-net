# AWSSDK.DynamoDBv2

The AWS SDK for .NET client for Amazon DynamoDB. The package offers three ways to work with a table, from the most convenient to the most direct.

## Object persistence model

Map your own classes to tables with attributes and let `DynamoDBContext` convert them.

```csharp
using Amazon.DynamoDBv2;
using Amazon.DynamoDBv2.DataModel;

var client = new AmazonDynamoDBClient();
var context = new DynamoDBContextBuilder()
    .WithDynamoDBClient(() => client)
    .Build();

await context.SaveAsync(new Book { Id = "1", Title = "Dune" });
var book = await context.LoadAsync<Book>("1");

[DynamoDBTable("Books")]
public class Book
{
    [DynamoDBHashKey]
    public string Id { get; set; }
    public string Title { get; set; }
}
```

A context created with `DynamoDBContextBuilder` does not call `DescribeTable` to look up a table's keys and indexes, so describe them with attributes on the class, as `[DynamoDBHashKey]` does above.

## Document model

Work with items as `Document` objects, without defining classes.

```csharp
using Amazon.DynamoDBv2;
using Amazon.DynamoDBv2.DocumentModel;

var client = new AmazonDynamoDBClient();
var table = new TableBuilder(client, "Books")
    .AddHashKey("Id", DynamoDBEntryType.String)
    .Build();

await table.PutItemAsync(new Document { ["Id"] = "1", ["Title"] = "Dune" });
var document = await table.GetItemAsync("1");
```

## Low-level client

`AmazonDynamoDBClient` exposes every DynamoDB API operation with its request and response types.

```csharp
using Amazon.DynamoDBv2;
using Amazon.DynamoDBv2.Model;

var client = new AmazonDynamoDBClient();
var response = await client.GetItemAsync(new GetItemRequest
{
    TableName = "Books",
    Key = new Dictionary<string, AttributeValue> { ["Id"] = new AttributeValue { S = "1" } }
});
```

## Resources

- [Using Amazon DynamoDB NoSQL databases](https://docs.aws.amazon.com/sdk-for-net/v4/developer-guide/dynamodb-intro.html)
- [Migrating to version 4](https://docs.aws.amazon.com/sdk-for-net/v4/developer-guide/net-dg-v4.html)
- [Developer Guide](https://docs.aws.amazon.com/sdk-for-net/v4/developer-guide/welcome.html)
- [API Reference](https://docs.aws.amazon.com/sdkfornet/v4/apidocs/)
- [Source and issues](https://github.com/aws/aws-sdk-net)
