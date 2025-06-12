using Amazon.SQS;
using Amazon.SQS.Model;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AWSSDKDocSamples.SQS
{
    class SQSSamples : ISample
    {
        public static async Task SQSReceiveMessage()
        {
            #region SQSReceiveMessage
            var client = new AmazonSQSClient();

            var request = new ReceiveMessageRequest
            {
                MessageSystemAttributeNames = new List<string>() { "All" },
                MaxNumberOfMessages = 5,
                QueueUrl = "https://sqs.us-east-1.amazonaws.com/80398EXAMPLE/MyTestQueue",
                VisibilityTimeout = (int)TimeSpan.FromMinutes(10).TotalSeconds,
                WaitTimeSeconds = (int)TimeSpan.FromSeconds(5).TotalSeconds
            };

            var response = await client.ReceiveMessageAsync(request);

            if (response.Messages != null)
            {
                foreach (var message in response.Messages)
                {
                    Console.WriteLine("For message ID '" + message.MessageId + "':");
                    Console.WriteLine("  Body: " + message.Body);
                    Console.WriteLine("  Receipt handle: " + message.ReceiptHandle);
                    Console.WriteLine("  MD5 of body: " + message.MD5OfBody);
                    Console.WriteLine("  MD5 of message attributes: " +
                      message.MD5OfMessageAttributes);
                    Console.WriteLine("  Attributes:");

                    foreach (var attr in message.Attributes)
                    {
                        Console.WriteLine("    " + attr.Key + ": " + attr.Value);
                    }
                }
            }
            else
            {
                Console.WriteLine("No messages received.");
            }
            #endregion

            Console.ReadLine();
        }

        public static async Task SQSSendMessage()
        {
            #region SQSSendMessage
            var client = new AmazonSQSClient();

            var request = new SendMessageRequest
            {
                DelaySeconds = (int)TimeSpan.FromSeconds(5).TotalSeconds,
                MessageAttributes = new Dictionary<string, MessageAttributeValue>
        {
          {
            "MyNameAttribute", new MessageAttributeValue
              { DataType = "String", StringValue = "John Doe" }
          },
          {
            "MyAddressAttribute", new MessageAttributeValue
              { DataType = "String", StringValue = "123 Main St." }
          },
          {
            "MyRegionAttribute", new MessageAttributeValue
              { DataType = "String", StringValue = "Any Town, United States" }
          }
        },
                MessageBody = "John Doe customer information.",
                QueueUrl = "https://sqs.us-east-1.amazonaws.com/80398EXAMPLE/MyTestQueue"
            };

            var response = await client.SendMessageAsync(request);

            Console.WriteLine("For message ID '" + response.MessageId + "':");
            Console.WriteLine("  MD5 of message attributes: " +
              response.MD5OfMessageAttributes);
            Console.WriteLine("  MD5 of message body: " + response.MD5OfMessageBody);
            #endregion

            Console.ReadLine();
        }

        public static async Task SQSDeleteMessage()
        {
            #region SQSDeleteMessage
            var client = new AmazonSQSClient();

            var request = new ReceiveMessageRequest
            {
                MessageSystemAttributeNames = new List<string>() { "All" },
                MaxNumberOfMessages = 5,
                QueueUrl = "https://sqs.us-east-1.amazonaws.com/80398EXAMPLE/MyTestQueue",
                VisibilityTimeout = (int)TimeSpan.FromMinutes(10).TotalSeconds,
                WaitTimeSeconds = (int)TimeSpan.FromSeconds(5).TotalSeconds
            };

            var response = await client.ReceiveMessageAsync(request);

            if (response.Messages != null)
            {
                foreach (var message in response.Messages)
                {
                    Console.Write("Message ID '" + message.MessageId + "' ");

                    var delRequest = new DeleteMessageRequest
                    {
                        QueueUrl = "https://sqs.us-east-1.amazonaws.com/80398EXAMPLE/MyTestQueue",
                        ReceiptHandle = message.ReceiptHandle
                    };

                    var delResponse = await client.DeleteMessageAsync(delRequest);
                }
            }
            else
            {
                Console.WriteLine("No messages to delete.");
            }
            #endregion

            Console.ReadLine();
        }

        public static async Task SQSDeleteMessageBatch()
        {
            #region SQSDeleteMessageBatch
            var client = new AmazonSQSClient();

            var request = new ReceiveMessageRequest
            {
                MessageSystemAttributeNames = new List<string>() { "All" },
                MaxNumberOfMessages = 5,
                QueueUrl = "https://sqs.us-east-1.amazonaws.com/80398EXAMPLE/MyTestQueue",
                VisibilityTimeout = (int)TimeSpan.FromMinutes(10).TotalSeconds,
                WaitTimeSeconds = (int)TimeSpan.FromSeconds(5).TotalSeconds
            };

            var response = await client.ReceiveMessageAsync(request);
            var batchEntries = new List<DeleteMessageBatchRequestEntry>();

            if (response.Messages != null)
            {
                foreach (var message in response.Messages)
                {
                    var batchEntry = new DeleteMessageBatchRequestEntry
                    {
                        Id = message.MessageId,
                        ReceiptHandle = message.ReceiptHandle
                    };

                    batchEntries.Add(batchEntry);
                }

                var delRequest = new DeleteMessageBatchRequest
                {
                    Entries = batchEntries,
                    QueueUrl = "https://sqs.us-east-1.amazonaws.com/80398EXAMPLE/MyTestQueue"
                };

                var delResponse = await client.DeleteMessageBatchAsync(delRequest);

                if (delResponse.Failed != null)
                {
                    Console.WriteLine("Failed deletions:");

                    foreach (var failure in delResponse.Failed)
                    {
                        Console.WriteLine("  For ID '" + failure.Id + "': ");
                        Console.WriteLine("    Code = " + failure.Code);
                        Console.WriteLine("    Message = " + failure.Message);
                        Console.WriteLine("    Sender's fault? = " + failure.SenderFault);
                    }
                }

                if (delResponse.Successful != null)
                {
                    Console.WriteLine("Successful deletions:");

                    foreach (var success in delResponse.Successful)
                    {
                        Console.WriteLine("  ID '" + success.Id + "'");
                    }
                }
            }
            else
            {
                Console.WriteLine("No messages to delete.");
            }
            #endregion

            Console.ReadLine();
        }

        public static async Task SQSCreateQueue()
        {
            #region SQSCreateQueue
            var client = new AmazonSQSClient();

            var attrs = new Dictionary<string, string>();

            // Maximum message size of 256 KiB (1,024 bytes * 256 KiB = 262,144 bytes).
            int maxMessage = 256 * 1024;

            attrs.Add(QueueAttributeName.DelaySeconds,
              TimeSpan.FromSeconds(5).TotalSeconds.ToString());
            attrs.Add(QueueAttributeName.MaximumMessageSize, maxMessage.ToString());
            attrs.Add(QueueAttributeName.MessageRetentionPeriod,
              TimeSpan.FromDays(4).TotalSeconds.ToString());
            attrs.Add(QueueAttributeName.ReceiveMessageWaitTimeSeconds,
              TimeSpan.FromSeconds(5).TotalSeconds.ToString());
            attrs.Add(QueueAttributeName.VisibilityTimeout,
              TimeSpan.FromHours(12).TotalSeconds.ToString());

            var request = new CreateQueueRequest
            {
                Attributes = attrs,
                QueueName = "MyTestQueue"
            };

            var response = await client.CreateQueueAsync(request);

            Console.WriteLine("Queue URL: " + response.QueueUrl);
            #endregion

            Console.ReadLine();
        }

        public static async Task SQSGetQueueUrl()
        {
            #region SQSGetQueueUrl
            var client = new AmazonSQSClient();

            var request = new GetQueueUrlRequest
            {
                QueueName = "MyTestQueue",
                QueueOwnerAWSAccountId = "80398EXAMPLE"
            };

            var response = await client.GetQueueUrlAsync(request);

            Console.WriteLine("Queue URL: " + response.QueueUrl);
            #endregion

            Console.ReadLine();
        }

        public static async Task SQSListQueues()
        {
            #region SQSListQueues
            var client = new AmazonSQSClient();

            // List all queues that start with "My".
            var request = new ListQueuesRequest
            {
                QueueNamePrefix = "My"
            };

            var response = await client.ListQueuesAsync(request);

            if (response.QueueUrls != null)
            {
                Console.WriteLine("Queue URLs:");

                foreach (var url in response.QueueUrls)
                {
                    Console.WriteLine("  " + url);
                }
            }
            else
            {
                Console.WriteLine("No matching queues.");
            }
            #endregion

            Console.ReadLine();
        }

        public static async Task SQSSendMessageBatch()
        {
            #region SQSSendMessageBatch
            var client = new AmazonSQSClient();

            var entry1 = new SendMessageBatchRequestEntry
            {
                DelaySeconds = 0,
                Id = "Entry1",
                MessageAttributes = new Dictionary<string, MessageAttributeValue>
                {
                    {
                        "MyNameAttribute", new MessageAttributeValue
                            { DataType = "String", StringValue = "John Doe" }
                    },
                    {
                        "MyAddressAttribute", new MessageAttributeValue
                            { DataType = "String", StringValue = "123 Main St." }
                    },
                    {
                        "MyRegionAttribute", new MessageAttributeValue
                            { DataType = "String", StringValue = "Any Town, United States" }
                    }
                },
                MessageBody = "John Doe customer information."
            };

            var entry2 = new SendMessageBatchRequestEntry
            {
                DelaySeconds = 0,
                Id = "Entry2",
                MessageAttributes = new Dictionary<string, MessageAttributeValue>
        {
          {
            "MyNameAttribute", new MessageAttributeValue
              { DataType = "String", StringValue = "Jane Doe" }
          },
          {
            "MyAddressAttribute", new MessageAttributeValue
              { DataType = "String", StringValue = "456 Center Road" }
          },
          {
            "MyRegionAttribute", new MessageAttributeValue
              { DataType = "String", StringValue = "Any City, United States" }
          }
        },
                MessageBody = "Jane Doe customer information."
            };

            var entry3 = new SendMessageBatchRequestEntry
            {
                DelaySeconds = 0,
                Id = "Entry3",
                MessageAttributes = new Dictionary<string, MessageAttributeValue>
        {
          {
            "MyNameAttribute", new MessageAttributeValue
              { DataType = "String", StringValue = "Richard Doe" }
          },
          {
            "MyAddressAttribute", new MessageAttributeValue
              { DataType = "String", StringValue = "789 East Blvd." }
          },
          {
            "MyRegionAttribute", new MessageAttributeValue
              { DataType = "String", StringValue = "Anywhere, United States" }
          }
        },
                MessageBody = "Richard Doe customer information."
            };

            var request = new SendMessageBatchRequest
            {
                Entries = new List<SendMessageBatchRequestEntry>() { entry1, entry2, entry3 },
                QueueUrl = "https://sqs.us-east-1.amazonaws.com/80398EXAMPLE/MyTestQueue"
            };

            var response = await client.SendMessageBatchAsync(request);

            if (response.Successful != null)
            {
                Console.WriteLine("Successfully sent:");

                foreach (var success in response.Successful)
                {
                    Console.WriteLine("  For ID: '" + success.Id + "':");
                    Console.WriteLine("    Message ID = " + success.MessageId);
                    Console.WriteLine("    MD5 of message attributes = " +
                      success.MD5OfMessageAttributes);
                    Console.WriteLine("    MD5 of message body = " +
                      success.MD5OfMessageBody);
                }
            }

            if (response.Failed != null)
            {
                Console.WriteLine("Failed to be sent:");

                foreach (var fail in response.Failed)
                {
                    Console.WriteLine("  For ID '" + fail.Id + "':");
                    Console.WriteLine("    Code = " + fail.Code);
                    Console.WriteLine("    Message = " + fail.Message);
                    Console.WriteLine("    Sender's fault? = " +
                      fail.SenderFault);
                }
            }
            #endregion

            Console.ReadLine();
        }

        public static async Task SQSGetQueueAttributes()
        {
            #region SQSGetQueueAttributes
            var client = new AmazonSQSClient();

            var request = new GetQueueAttributesRequest
            {
                QueueUrl = "https://sqs.us-east-1.amazonaws.com/80398EXAMPLE/MyTestQueue",
                AttributeNames = new List<string>() { "All" }
            };

            var response = await client.GetQueueAttributesAsync(request);

            Console.WriteLine("Attributes for queue ARN '" + response.QueueARN + "':");
            Console.WriteLine("  Approximate number of messages:" +
              response.ApproximateNumberOfMessages);
            Console.WriteLine("  Approximate number of messages delayed: " +
              response.ApproximateNumberOfMessagesDelayed);
            Console.WriteLine("  Approximate number of messages not visible: " +
              response.ApproximateNumberOfMessagesNotVisible);
            Console.WriteLine("  Queue created on: " + response.CreatedTimestamp);
            Console.WriteLine("  Delay seconds: " + response.DelaySeconds);
            Console.WriteLine("  Queue last modified on: " +
              response.LastModifiedTimestamp);
            Console.WriteLine("  Maximum message size: " +
              response.MaximumMessageSize);
            Console.WriteLine("  Message retention period: " +
              response.MessageRetentionPeriod);
            Console.WriteLine("  Visibility timeout: " + response.VisibilityTimeout);
            Console.WriteLine("  Policy: " + response.Policy);
            Console.WriteLine("  Attributes:");

            foreach (var attr in response.Attributes)
            {
                Console.WriteLine("    " + attr.Key + ": " + attr.Value);
            }
            #endregion

            Console.ReadLine();
        }

        public static async Task SQSChangeMessageVisibility()
        {
            #region SQSChangeMessageVisibility
            var client = new AmazonSQSClient();

            var url = "https://sqs.us-east-1.amazonaws.com/80398EXAMPLE/MyTestQueue";

            // Receive messages.
            var rcvRequest = new ReceiveMessageRequest
            {
                MessageSystemAttributeNames = new List<string>() { "All" },
                QueueUrl = url
            };

            var rcvResponse = await client.ReceiveMessageAsync(rcvRequest);

            // Change visibility timeout for each message.
            if (rcvResponse.Messages != null)
            {
                foreach (var message in rcvResponse.Messages)
                {
                    var visRequest = new ChangeMessageVisibilityRequest
                    {
                        QueueUrl = url,
                        ReceiptHandle = message.ReceiptHandle,
                        VisibilityTimeout = (int)TimeSpan.FromMinutes(10).TotalSeconds
                    };

                    await client.ChangeMessageVisibilityAsync(visRequest);
                }
            }
            else
            {
                Console.WriteLine("No messages to change visibility for.");
            }
            #endregion
        }

        public static async Task SQSSetQueueAttributes()
        {
            #region SQSSetQueueAttributes
            var client = new AmazonSQSClient();

            var attrs = new Dictionary<string, string>();

            // Maximum message size of 128 KiB (1,024 bytes * 128 KiB = 131,072 bytes).
            int maxMessage = 128 * 1024;

            attrs.Add(QueueAttributeName.DelaySeconds,
              TimeSpan.FromSeconds(5).TotalSeconds.ToString());
            attrs.Add(QueueAttributeName.MaximumMessageSize, maxMessage.ToString());
            attrs.Add(QueueAttributeName.MessageRetentionPeriod,
              TimeSpan.FromDays(1).TotalSeconds.ToString());
            attrs.Add(QueueAttributeName.ReceiveMessageWaitTimeSeconds,
              TimeSpan.FromSeconds(5).TotalSeconds.ToString());
            attrs.Add(QueueAttributeName.VisibilityTimeout,
              TimeSpan.FromHours(1).TotalSeconds.ToString());
            // Dead-letter queue attributes.
            attrs.Add(QueueAttributeName.RedrivePolicy,
              "{\"maxReceiveCount\":" +
              "\"5\"," +
              "\"deadLetterTargetArn\":" +
              "\"arn:aws:sqs:us-east-1:80398EXAMPLE:MyTestDeadLetterQueue\"}");

            var request = new SetQueueAttributesRequest
            {
                Attributes = attrs,
                QueueUrl = "https://sqs.us-east-1.amazonaws.com/80398EXAMPLE/MyTestQueue"
            };

            await client.SetQueueAttributesAsync(request);
            #endregion
        }

        public static async Task SQSChangeMessageVisibilityBatch()
        {
            #region SQSChangeMessageVisibilityBatch
            var client = new AmazonSQSClient();

            var url = "https://sqs.us-east-1.amazonaws.com/80398EXAMPLE/MyTestQueue";

            // Receive messages.
            var msgRequest = new ReceiveMessageRequest
            {
                MessageSystemAttributeNames = new List<string>() { "All" },
                QueueUrl = url
            };

            var msgResponse = await client.ReceiveMessageAsync(msgRequest);

            // Change visibility timeout for each message.
            if (msgResponse.Messages != null)
            {
                var entries = new List<ChangeMessageVisibilityBatchRequestEntry>();

                int numMessages = 0;

                foreach (var message in msgResponse.Messages)
                {
                    numMessages += 1;

                    var entry = new ChangeMessageVisibilityBatchRequestEntry
                    {
                        Id = "Entry" + numMessages.ToString(),
                        ReceiptHandle = message.ReceiptHandle,
                        VisibilityTimeout = (int)TimeSpan.FromMinutes(10).TotalSeconds
                    };

                    entries.Add(entry);
                }

                var batRequest = new ChangeMessageVisibilityBatchRequest
                {
                    Entries = entries,
                    QueueUrl = url
                };

                var batResponse = await client.ChangeMessageVisibilityBatchAsync(batRequest);

                Console.WriteLine("Successes: " + batResponse.Successful?.Count +
                  ", Failures: " + batResponse.Failed?.Count);

                if (batResponse.Successful != null)
                {
                    foreach (var success in batResponse.Successful)
                    {
                        Console.WriteLine("  Success ID " + success.Id);
                    }
                }

                if (batResponse.Failed != null)
                {
                    foreach (var fail in batResponse.Failed)
                    {
                        Console.WriteLine("  Failure ID " + fail.Id + ":");
                        Console.WriteLine("    Code: " + fail.Code);
                        Console.WriteLine("    Message: " + fail.Message);
                        Console.WriteLine("    Sender's fault?: " + fail.SenderFault);
                    }
                }
            }
            #endregion

            Console.ReadLine();
        }

        public static async Task SQSDeleteQueue()
        {
            #region SQSDeleteQueue
            var client = new AmazonSQSClient();

            var request = new DeleteQueueRequest
            {
                QueueUrl = "https://sqs.us-east-1.amazonaws.com/80398EXAMPLE/MyTestQueue"
            };

            await client.DeleteQueueAsync(request);
            #endregion
        }

        public static async Task SQSAddPermission()
        {
            #region SQSAddPermission
            var client = new AmazonSQSClient();

            var request = new AddPermissionRequest
            {
                Actions = new List<string>() { "GetQueueAttributes", "GetQueueUrl" },
                AWSAccountIds = new List<string>() { "80398EXAMPLE" },
                Label = "JohnDoeCanAccessQueues",
                QueueUrl = "https://sqs.us-east-1.amazonaws.com/80398EXAMPLE/MyTestQueue"
            };

            await client.AddPermissionAsync(request);
            #endregion
        }

        public static async Task SQSListDeadLetterSourceQueues()
        {
            #region SQSListDeadLetterSourceQueues
            var client = new AmazonSQSClient();

            var request = new ListDeadLetterSourceQueuesRequest
            {
                QueueUrl = "https://sqs.us-east-1.amazonaws.com/80398EXAMPLE/MyTestDeadLetterQueue"
            };

            var response = await client.ListDeadLetterSourceQueuesAsync(request);

            if (response.QueueUrls != null)
            {
                Console.WriteLine("Dead letter source queues:");

                foreach (var url in response.QueueUrls)
                {
                    Console.WriteLine("  " + url);
                }
            }
            else
            {
                Console.WriteLine("No dead letter source queues.");
            }
            #endregion

            Console.ReadLine();
        }

        public static async Task SQSRemovePermission()
        {
            #region SQSRemovePermission
            var client = new AmazonSQSClient();

            var request = new RemovePermissionRequest
            {
                Label = "JohnDoeCanAccessQueues",
                QueueUrl = "https://sqs.us-east-1.amazonaws.com/80398EXAMPLE/MyTestQueue"
            };

            await client.RemovePermissionAsync(request);
            #endregion
        }

        #region ISample Members
        public virtual Task Run()
        {
            return Task.CompletedTask;
        }
        #endregion
    }
}
