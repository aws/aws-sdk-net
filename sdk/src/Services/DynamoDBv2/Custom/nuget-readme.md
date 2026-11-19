Besides the low-level client shown above, the package offers two higher-level ways to work with a table.

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

## Resources

- [Using Amazon DynamoDB NoSQL databases](https://docs.aws.amazon.com/sdk-for-net/v4/developer-guide/dynamodb-intro.html)
- [Migrating to version 4](https://docs.aws.amazon.com/sdk-for-net/v4/developer-guide/net-dg-v4.html)
- [Developer Guide](https://docs.aws.amazon.com/sdk-for-net/v4/developer-guide/welcome.html)
- [API Reference](https://docs.aws.amazon.com/sdkfornet/v4/apidocs/)
- [Source and issues](https://github.com/aws/aws-sdk-net)
