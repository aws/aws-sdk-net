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
using System.Threading;

using Amazon.Glacier.Model;
using Amazon.SimpleNotificationService.Model;
using Amazon.SQS.Model;
using Amazon.SQS.Util;

namespace Amazon.Glacier.Transfer.Internal
{
    internal partial class DownloadFileCommand : IDisposable
    {

        internal void Execute()
        {
            this.setupTopicAndQueue();
            try
            {
                var jobId = initiateJob();
                processQueue(jobId);
            }
            finally
            {
                this.tearDownTopicAndQueue();
            }
        }
        void processQueue(string jobId)
        {
            Message message = readNextMessage();
            processMessage(message, jobId);
            this.sqsClient.DeleteMessage(new DeleteMessageRequest() { QueueUrl = this.queueUrl, ReceiptHandle = message.ReceiptHandle });
        }

        void processMessage(Message message, string jobId)
        {
            var messageJobId = getJobIdFromMessage(message);
            if (messageJobId == null)
                return;

            var command = new DownloadJobCommand(this.manager, this.vaultName, jobId, this.filePath, this.options);
            command.Execute();
        }

        /// <summary>
        /// Poll messages from the queue.  Given the download process takes many hours there is extra
        /// long retry logic.
        /// </summary>
        /// <returns>The next message in the queue;</returns>
        Message readNextMessage()
        {
            int retryAttempts = 0;
            var receiveRequest = new ReceiveMessageRequest() { QueueUrl = this.queueUrl, MaxNumberOfMessages = 1 };
            while (true)
            {
                try
                {
                    var receiveResponse = this.sqsClient.ReceiveMessage(receiveRequest);
                    retryAttempts = 0;

                    if (receiveResponse.Messages.Count == 0)
                    {
                        Thread.Sleep((int)(this.options.PollingInterval * 1000 * 60));
                        continue;
                    }

                    return receiveResponse.Messages[0];
                }
                catch (Exception)
                {
                    retryAttempts++;
                    if (retryAttempts <= MAX_OPERATION_RETRY)
                        Thread.Sleep(60 * 1000);
                    else
                        throw;
                }
            }
        }

        string initiateJob()
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

            var response = this.manager.GlacierClient.InitiateJob(request);
            return response.JobId;
        }

        internal void setupTopicAndQueue()
        {
            var guidStr = Guid.NewGuid().ToString("N");
            this.topicArn = this.snsClient.CreateTopic(new CreateTopicRequest() { Name = "GlacierDownload-" + guidStr }).TopicArn;
            this.queueUrl = this.sqsClient.CreateQueue(new CreateQueueRequest() { QueueName = "GlacierDownload-" + guidStr }).QueueUrl;
            this.queueArn = this.sqsClient.GetQueueAttributes(new GetQueueAttributesRequest() { QueueUrl = this.queueUrl, AttributeNames = new List<string> { SQSConstants.ATTRIBUTE_QUEUE_ARN } }).Attributes[SQSConstants.ATTRIBUTE_QUEUE_ARN];

            this.snsClient.Subscribe(new SubscribeRequest()
            {
                Endpoint = this.queueArn,
                Protocol = "sqs",
                TopicArn = this.topicArn
            });

            var policy = SQS_POLICY.Replace("{QuereArn}", this.queueArn).Replace("{TopicArn}", this.topicArn);
            var setQueueAttributesRequest = new SetQueueAttributesRequest()
            {
                QueueUrl = this.queueUrl
            };
            setQueueAttributesRequest.Attributes.Add("Policy", policy);

            this.sqsClient.SetQueueAttributes(setQueueAttributesRequest);
        }

        internal void tearDownTopicAndQueue()
        {
            this.snsClient.DeleteTopic(new DeleteTopicRequest() { TopicArn = this.topicArn });
            this.sqsClient.DeleteQueue(new DeleteQueueRequest() { QueueUrl = this.queueUrl });
        }
    }
}
