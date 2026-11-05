/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using Amazon.Glacier.Model;
using Amazon.SimpleNotificationService.Model;
using Amazon.SQS.Model;
using Amazon.SQS.Util;

namespace Amazon.Glacier.Transfer.Internal
{
    internal partial class DownloadFileCommand : IDisposable
    {
        internal async Task ExecuteAsync()
        {
            await this.setupTopicAndQueueAsync().ConfigureAwait(false);
            try
            {
                var jobId = await initiateJobAsync().ConfigureAwait(false);
                await processQueueAsync(jobId).ConfigureAwait(false);
            }
            finally
            {
                this.tearDownTopicAndQueueAsync().Wait();
            }
        }
        async Task processQueueAsync(string jobId)
        {
            Message message = await readNextMessageAsync().ConfigureAwait(false);
            await processMessageAsync(message, jobId).ConfigureAwait(false);
            await this.sqsClient.DeleteMessageAsync(new DeleteMessageRequest() { QueueUrl = this.queueUrl, ReceiptHandle = message.ReceiptHandle }).ConfigureAwait(false);
        }

        async Task processMessageAsync(Message message, string jobId)
        {
            var messageJobId = getJobIdFromMessage(message);
            if (messageJobId == null)
                return;

            var command = new DownloadJobCommand(this.manager, this.vaultName, jobId, this.filePath, this.options);
            await command.ExecuteAsync().ConfigureAwait(false);
        }

        /// <summary>
        /// Poll messages from the queue.  Given the download process takes many hours there is extra
        /// long retry logic.
        /// </summary>
        /// <returns>The next message in the queue;</returns>
        async Task<Message> readNextMessageAsync()
        {
            int retryAttempts = 0;
            var receiveRequest = new ReceiveMessageRequest() { QueueUrl = this.queueUrl, MaxNumberOfMessages = 1 };
            while (true)
            {
                try
                {
                    var receiveResponse = await this.sqsClient.ReceiveMessageAsync(receiveRequest).ConfigureAwait(false);
                    retryAttempts = 0;

                    if (receiveResponse.Messages.Count == 0)
                    {
                        await Task.Delay((int)(this.options.PollingInterval * 1000 * 60)).ConfigureAwait(false);
                        continue;
                    }

                    return receiveResponse.Messages[0];
                }
                catch (Exception)
                {
                    retryAttempts++;
                    if (retryAttempts <= MAX_OPERATION_RETRY)
                        Task.Delay(1000 * 60).Wait();
                    else
                        throw;
                }
            }
        }

        async Task<string> initiateJobAsync()
        {
            var request = new InitiateJobRequest()
            {
                AccountId = this.options.AccountId,
                VaultName = this.vaultName,
                JobParameters = new JobParameters()
                {
                    ArchiveId = this.archiveId,
                    SNSTopic = topicArn,
                    Type = "archive-retrieval"
                }
            };
            ((Amazon.Runtime.Internal.IAmazonWebServiceRequest)request).AddBeforeRequestHandler(new ArchiveTransferManager.UserAgentPostFix("DownloadArchive").UserAgentRequestEventHandlerSync);

            var response = await this.manager.GlacierClient.InitiateJobAsync(request).ConfigureAwait(false);
            return response.JobId;
        }

        internal async Task setupTopicAndQueueAsync()
        {
            var guidStr = Guid.NewGuid().ToString("N");
            this.topicArn = (await this.snsClient.CreateTopicAsync(new CreateTopicRequest() { Name = "GlacierDownload-" + guidStr }).ConfigureAwait(false)).TopicArn;
            this.queueUrl = (await this.sqsClient.CreateQueueAsync(new CreateQueueRequest() { QueueName = "GlacierDownload-" + guidStr }).ConfigureAwait(false)).QueueUrl;
            this.queueArn = (await this.sqsClient.GetQueueAttributesAsync(new GetQueueAttributesRequest() { QueueUrl = this.queueUrl, AttributeNames = new List<string> { SQSConstants.ATTRIBUTE_QUEUE_ARN } }).ConfigureAwait(false)).Attributes[SQSConstants.ATTRIBUTE_QUEUE_ARN];

            await this.snsClient.SubscribeAsync(new SubscribeRequest()
            {
                Endpoint = this.queueArn,
                Protocol = "sqs",
                TopicArn = this.topicArn
            }).ConfigureAwait(false);

            var policy = SQS_POLICY.Replace("{QuereArn}", this.queueArn).Replace("{TopicArn}", this.topicArn);
            var setQueueAttributesRequest = new SetQueueAttributesRequest()
            {
                QueueUrl = this.queueUrl
            };
            setQueueAttributesRequest.Attributes.Add("Policy", policy);

            await this.sqsClient.SetQueueAttributesAsync(setQueueAttributesRequest).ConfigureAwait(false);
        }

        internal async Task tearDownTopicAndQueueAsync()
        {
            await this.snsClient.DeleteTopicAsync(new DeleteTopicRequest() { TopicArn = this.topicArn }).ConfigureAwait(false);
            await this.sqsClient.DeleteQueueAsync(new DeleteQueueRequest() { QueueUrl = this.queueUrl }).ConfigureAwait(false);
        }
    }
}
