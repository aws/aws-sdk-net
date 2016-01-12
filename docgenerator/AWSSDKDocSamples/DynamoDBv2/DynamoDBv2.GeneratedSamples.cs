using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Amazon.DynamoDBv2;
using Amazon.DynamoDBv2.Model;

namespace AWSSDKDocSamples.Amazon.DynamoDBv2.Generated
{
    class DynamoDBSamples : ISample
    {
        static IAmazonDynamoDB client = new AmazonDynamoDBClient();
        public void DynamoDBBatchGetItem()
        {
            #region batch-get-item-1435614252853

            var response = client.BatchGetItem(new BatchGetItemRequest 
            {
                RequestItems = new Dictionary<string, KeysAndAttributes> {
                    { "tablename1", new KeysAndAttributes {
                        Keys = new List<Dictionary<string, AttributeValue>> {
                            new Dictionary<string, AttributeValue> {
                                { "key1", new AttributeValue { N = "NumberAttributeValue" } }
                            }
                        },
                        AttributesToGet = new List<string> {
                            "attr1",
                            "attr2"
                        },
                        ConsistentRead = true,
                        ProjectionExpression = "str1",
                        ExpressionAttributeNames = new Dictionary<string, string> {
                            { "name1", "attr3" },
                            { "name2", "attr4" }
                        }
                    } },
                    { "tablename2", new KeysAndAttributes {
                        Keys = new List<Dictionary<string, AttributeValue>> {
                            new Dictionary<string, AttributeValue> {
                                { "key2", new AttributeValue { BOOL = true } }
                            }
                        },
                        AttributesToGet = new List<string> {
                            "attr1",
                            "attr2"
                        },
                        ConsistentRead = false,
                        ProjectionExpression = "str2",
                        ExpressionAttributeNames = new Dictionary<string, string> {
                            { "name1", "attr3" },
                            { "name2", "attr4" }
                        }
                    } }
                },
                ReturnConsumedCapacity = "NONE"
            });

            Dictionary<string, List<Dictionary<string, AttributeValue>>> responses = response.Responses;
            List<ConsumedCapacity> consumedCapacity = response.ConsumedCapacity;

            #endregion
        }

        
        # region ISample Members
        public virtual void Run()
        {

        }
        # endregion

    }
}