using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Amazon.DynamoDBv2;
using Amazon.DynamoDBv2.Model;

namespace AWSSDKDocSamples.DynamoDB.Generated
{
    class Amazon.DynamoDBv2Samples : ISample
    {
        public void DynamoDBBatchGetItem()
        {
            #region batch-get-item-1435614252853
            var client = new AmazonDynamoDBClient();

            var response = client.BatchGetItem(new BatchGetItemRequest 
            {
                RequestItems = new Dictionary<string, KeysAndAttributes> {
                    { "tablename1", new KeysAndAttributes {
                        Keys = new List<map> {
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
                        ExpressionAttributeNames = new Dictionary<string, AttributeName> {
                            { "name1", "attr3" },
                            { "name2", "attr4" }
                        }
                    } },
                    { "tablename2", new KeysAndAttributes {
                        Keys = new List<map> {
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
                        ExpressionAttributeNames = new Dictionary<string, AttributeName> {
                            { "name1", "attr3" },
                            { "name2", "attr4" }
                        }
                    } }
                },
                ReturnConsumedCapacity = "NONE"
            });
            #endregion
        }

        
        # region ISample Members
        public virtual void Run()
        {

        }
        # endregion

    }
}