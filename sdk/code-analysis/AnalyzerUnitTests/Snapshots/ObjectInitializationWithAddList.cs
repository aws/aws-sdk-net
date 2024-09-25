using Amazon.DynamoDBv2.Model;
using System;

namespace Playground
{
    public class TheCode
    {
        public void ObjectInitializationWithAddList()
        {
            var request = new PutItemRequest
            {
                Item =
                {
                    { "foo", new AttributeValue{S = "bar" } }
                }
            };

            Console.WriteLine(request.Item.Count);
        }
    }
}