using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Amazon.SQS;
using Amazon.SQS.Model;

using Xunit;

namespace Amazon.DNXCore.IntegrationTests
{
    public class SQSTests : TestBase<AmazonSQSClient>
    {
        [Fact]
        public async Task ListQueues()
        {
            var request = new ListQueuesRequest();
            var response = await Client.ListQueuesAsync(request);
            Assert.NotNull(response.ResponseMetadata.Metadata);

            if (AWSConfigs.InitializeCollections)
            {
                Assert.NotNull(response.QueueUrls);
            }
        }

        [Fact]
        public async Task SendAndReceiveMessage()
        {

            var createQueueRequest = new CreateQueueRequest()
            {
                QueueName = "aws-sdk-net-" + DateTime.UtcNow.Ticks
            };
            var createQueueResponse = await Client.CreateQueueAsync(createQueueRequest);
            try
            {
                var sendMessageRequest = new SendMessageRequest
                {
                    QueueUrl = createQueueResponse.QueueUrl,
                    MessageBody = "Hello"
                };
                await Client.SendMessageAsync(sendMessageRequest);

                var receiveRequest = new ReceiveMessageRequest { QueueUrl = createQueueResponse.QueueUrl };
                var receiveResponse = await Client.ReceiveMessageAsync(receiveRequest);

                Assert.True(receiveResponse.Messages.Count == 1);
                Assert.Equal(sendMessageRequest.MessageBody, receiveResponse.Messages[0].Body);

                await Client.DeleteMessageAsync(new DeleteMessageRequest
                {
                    QueueUrl = createQueueResponse.QueueUrl,
                    ReceiptHandle = receiveResponse.Messages[0].ReceiptHandle
                });
            }
            finally
            {
                await Client.DeleteQueueAsync(new DeleteQueueRequest
                {
                    QueueUrl = createQueueResponse.QueueUrl
                });
            }

        }
    }
}
