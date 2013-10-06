/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System.IO;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading;

using Amazon.Glacier.Model;
using Amazon.Glacier.Transfer.Internal;
using Amazon.Util;

using Amazon.SimpleNotificationService;
using Amazon.SimpleNotificationService.Model;

using Amazon.SQS;
using Amazon.SQS.Model;

using ThirdParty.Json.LitJson;

namespace Amazon.Glacier.Transfer.Internal
{
    internal class DownloadFileCommand
    {
        internal const int MAX_OPERATION_RETRY = 5;
        const string SQS_POLICY = 
            "{" +
            "    \"Version\" : \"2008-10-17\"," +
            "    \"Statement\" : [" +
            "        {" +
            "            \"Sid\" : \"sns-rule\"," +
            "            \"Effect\" : \"Allow\"," +
            "            \"Principal\" : {" +
            "                \"AWS\" : \"*\"" +
            "            }," +
            "            \"Action\"    : \"sqs:SendMessage\"," +
            "            \"Resource\"  : \"{QuereArn}\"," +
            "            \"Condition\" : {" +
            "                \"ArnLike\" : {" +
            "                    \"aws:SourceArn\" : \"{TopicArn}\"" +
            "                }" +
            "            }" +
            "        }" +
            "    ]" +
            "}";

        ArchiveTransferManager manager;
        string vaultName;
        string archiveId;
        string filePath;
        DownloadOptions options;

        AmazonSimpleNotificationService snsClient;
        AmazonSQS sqsClient;

        string topicArn;
        string queueUrl;
        string queueArn;

        internal DownloadFileCommand(ArchiveTransferManager manager, string vaultName, string archiveId, string filePath, DownloadOptions options)
        {
            this.manager = manager;
            this.vaultName = vaultName;
            this.archiveId = archiveId;
            this.filePath = filePath;
            this.options = options;

            var credentials = ((AmazonGlacierClient)this.manager.GlacierClient).Credentials;
            var regionName = Util.AWSSDKUtils.DetermineRegion(((AmazonGlacierClient)this.manager.GlacierClient).ServiceURL);
            RegionEndpoint region = RegionEndpoint.GetBySystemName(regionName);

            this.snsClient = new AmazonSimpleNotificationServiceClient(credentials, region);
            this.sqsClient = new AmazonSQSClient(credentials, region);

            if (this.options == null)
                this.options = new DownloadOptions();
        }


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

                    if (receiveResponse.ReceiveMessageResult.Message.Count == 0)
                    {
                        Thread.Sleep((int)(this.options.PollingInterval * 1000 * 60));
                        continue;
                    }

                    return receiveResponse.ReceiveMessageResult.Message[0];
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

        void processMessage(Message message, string jobId)
        {
            var messageJobId = getJobIdFromMessage(message);
            if (messageJobId == null)
                return;

            var command = new DownloadJobCommand(this.manager, this.vaultName, jobId, this.filePath, this.options);
            command.Execute();
        }


        /// <summary>
        /// Parse the sqs message to make sure it contains the right job id and that the job was successful
        /// </summary>
        /// <param name="message"></param>
        string getJobIdFromMessage(Message message)
        {
            string json;

            // Some older AWS accounts send messages base 64 encoded.  Do a check to 
            // see if this is the start of a json document.  If not then base 64 decode the message.
            if (message.Body.Trim().StartsWith("{"))
                json = message.Body;
            else
                json = System.Text.Encoding.UTF8.GetString(Convert.FromBase64String(message.Body));

            Dictionary<string, string> outerLayer = JsonMapper.ToObject<Dictionary<string, string>>(json);
            Dictionary<string, object> fields = JsonMapper.ToObject<Dictionary<string, object>>(outerLayer["Message"]);

            string jobId = fields["JobId"] as string;

            string statusCode = fields["StatusCode"] as string;
            if (!string.Equals(statusCode, GlacierUtils.JOB_STATUS_SUCCEEDED, StringComparison.InvariantCultureIgnoreCase))
            {
                object statusMessage = "";
                fields.TryGetValue("StatusMessage", out statusMessage);
                throw new AmazonGlacierException(string.Format("Failed to download {0}: {1}", this.filePath, Convert.ToString(statusMessage)));
            }

            return jobId;
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
            request.BeforeRequestEvent += new UserAgentPostFix("DownloadArchive").UserAgentRequestEventHandlerSync;

            var response = this.manager.GlacierClient.InitiateJob(request);
            return response.InitiateJobResult.JobId;
        }

        internal void setupTopicAndQueue()
        {
            long ticks = DateTime.Now.Ticks;
            this.topicArn = this.snsClient.CreateTopic(new CreateTopicRequest() { Name = "GlacierDownload-" + ticks }).CreateTopicResult.TopicArn;
            this.queueUrl = this.sqsClient.CreateQueue(new CreateQueueRequest() { QueueName = "GlacierDownload-" + ticks }).CreateQueueResult.QueueUrl;
            this.queueArn = this.sqsClient.GetQueueAttributes(new GetQueueAttributesRequest() { QueueUrl = this.queueUrl, AttributeName = new List<string>{"QueueArn"} }).GetQueueAttributesResult.QueueARN;

            this.snsClient.Subscribe(new SubscribeRequest()
            {
                Endpoint = this.queueArn,
                Protocol = "sqs",
                TopicArn = this.topicArn
            });

            var policy = SQS_POLICY.Replace("{QuereArn}", this.queueArn).Replace("{TopicArn}", this.topicArn);
            this.sqsClient.SetQueueAttributes(new SetQueueAttributesRequest()
            {
                QueueUrl = this.queueUrl,
                Attribute = new List<Amazon.SQS.Model.Attribute>()
                {
                    new Amazon.SQS.Model.Attribute()
                    {
                        Name = "Policy",
                        Value = policy
                    }
                }
            });
        }

        internal void tearDownTopicAndQueue()
        {
            this.snsClient.DeleteTopic(new DeleteTopicRequest() { TopicArn = this.topicArn });
            this.sqsClient.DeleteQueue(new DeleteQueueRequest() { QueueUrl = this.queueUrl });
        }
    }
}
