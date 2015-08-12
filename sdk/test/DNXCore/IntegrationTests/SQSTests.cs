using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Amazon.SQS;
using Amazon.SQS.Model;

using Xunit;

namespace Amazon.DNXCore.IntegrationTests
{
    public class SQSTests
    {
        [Fact]
        public async Task ListQueues()
        {
            using (var client = new AmazonSQSClient(RegionEndpoint.USEast1))
            {
                var request = new ListQueuesRequest();
                var response = await client.ListQueuesAsync(request);
                Assert.NotNull(response.ResponseMetadata.Metadata);
                Assert.NotNull(response.QueueUrls);
            }
        }

        [Fact]
        public async Task SendAndReceiveMessage()
        {
            using (var client = new AmazonSQSClient(RegionEndpoint.USEast1))
            {
                var createQueueRequest = new CreateQueueRequest()
                {
                    QueueName = "aws-sdk-net-" + DateTime.Now.Ticks
                };
                var createQueueResponse = await client.CreateQueueAsync(createQueueRequest);
                try
                {
                    var sendMessageRequest = new SendMessageRequest
                    {
                        QueueUrl = createQueueResponse.QueueUrl,
                        MessageBody = "Hello"
                    };
                    await client.SendMessageAsync(sendMessageRequest);

                    var receiveRequest = new ReceiveMessageRequest { QueueUrl = createQueueResponse.QueueUrl };
                    var receiveResponse = await client.ReceiveMessageAsync(receiveRequest);

                    Assert.True(receiveResponse.Messages.Count == 1);
                    Assert.Equal(sendMessageRequest.MessageBody, receiveResponse.Messages[0].Body);

                    await client.DeleteMessageAsync(new DeleteMessageRequest
                    {
                        QueueUrl = createQueueResponse.QueueUrl,
                        ReceiptHandle = receiveResponse.Messages[0].ReceiptHandle
                    });
                }
                finally
                {
                    await client.DeleteQueueAsync(new DeleteQueueRequest
                    {
                        QueueUrl = createQueueResponse.QueueUrl
                    });
                }       
            }
        }
    }
}
