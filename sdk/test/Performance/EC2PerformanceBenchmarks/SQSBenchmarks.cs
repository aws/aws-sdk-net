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
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Amazon.SQS;
using Amazon.SQS.Model;
using BenchmarkDotNet.Attributes;

namespace AWSSDK.Benchmarks
{
    [MemoryDiagnoser]
    public class SQSBenchmarks
    {
        private IAmazonSQS _sqsClient;
        private string _sqsQueueUrl;
        private string _messageBody;
        private string _queueName;
        private static Random random = new Random();
        private SendMessageRequest _sendMessageRequest;
        private Dictionary<string, MessageAttributeValue> _messageAttributes;
        private List<string> _attributeNames;
        private ReceiveMessageRequest _receiveMessageRequest;

        [GlobalSetup(Target = nameof(SQSSendMessageAsync))]
        public async Task SetupForSendMessage()
        {
            var queueName = "SQSBenchmarkQueue" + random.Next(1, 100000);
            _sqsClient = new AmazonSQSClient();
            var createQueueRequest = new CreateQueueRequest
            {
                QueueName = queueName
            };
            CreateQueueResponse responseCreate = await _sqsClient.CreateQueueAsync(createQueueRequest).ConfigureAwait(false);
            _sqsQueueUrl = responseCreate.QueueUrl;
            _messageBody = Utils.CreateMessage(Constants.KiloSize * 10);
            _messageAttributes = new Dictionary<string, MessageAttributeValue> {
                {"AttributeA",new MessageAttributeValue{DataType = "String", StringValue = "TestingA" } },
                {"AttributeB",new MessageAttributeValue{DataType = "String", StringValue = "TestingB" } },
                {"AttributeC",new MessageAttributeValue{DataType = "String", StringValue = "TestingC" } },
                {"AttributeD",new MessageAttributeValue{DataType = "String", StringValue = "TestingD" } },
                {"AttributeE",new MessageAttributeValue{DataType = "String", StringValue = "TestingE" } }
            };
            _sendMessageRequest = new SendMessageRequest
            {
                QueueUrl = _sqsQueueUrl,
                MessageBody = _messageBody,
                MessageAttributes = _messageAttributes,
            };
        }

        /// <summary>
        ///  Test sendMessageAsync for SQS with a message body of 10k string and 5 message attributes
        /// </summary>
        [Benchmark]
        public async Task SQSSendMessageAsync()
        {
            await _sqsClient.SendMessageAsync(this._sendMessageRequest).ConfigureAwait(false);
        }

        [GlobalCleanup(Target = nameof(SQSSendMessageAsync))]
        public async Task CleanupForSendMessage()
        {
            await _sqsClient.DeleteQueueAsync(_sqsQueueUrl).ConfigureAwait(false);
        }

        [GlobalSetup(Target = nameof(SQSReceiveMessageAsync))]
        public async Task SetupForReceiveMessage()
        {
            _sqsClient = new AmazonSQSClient();
            var queueName = "SQSBenchmarkQueue" + random.Next(1, 100000);
            var createQueueRequest = new CreateQueueRequest
            {
                QueueName = queueName
            };
            CreateQueueResponse responseCreate = await _sqsClient.CreateQueueAsync(createQueueRequest).ConfigureAwait(false);
            _sqsQueueUrl = responseCreate.QueueUrl;
            Console.WriteLine("SQS Queue Url: {0}", _sqsQueueUrl);
            _messageBody = Utils.CreateMessage(Constants.KiloSize * 10);
            _messageAttributes = new Dictionary<string, MessageAttributeValue> {
                {"AttributeA",new MessageAttributeValue{DataType = "String", StringValue = "TestingA" } },
                {"AttributeB",new MessageAttributeValue{DataType = "String", StringValue = "TestingB" } },
                {"AttributeC",new MessageAttributeValue{DataType = "String", StringValue = "TestingC" } },
                {"AttributeD",new MessageAttributeValue{DataType = "String", StringValue = "TestingD" } },
                {"AttributeE",new MessageAttributeValue{DataType = "String", StringValue = "TestingE" } }
            };
            var entries = new List<SendMessageBatchRequest>();
            for (int i = 0 ; i < 10; i++)
            {
                var sendMessageBatchRequestEntries = new List<SendMessageBatchRequestEntry>();
                for(int j = 0; j < 10; j++)
                {
                    var entry = new SendMessageBatchRequestEntry
                    {
                        MessageBody = _messageBody,
                        MessageAttributes = _messageAttributes,
                        Id = random.Next(1, 1000000000).ToString()
                    };
                    sendMessageBatchRequestEntries.Add(entry);
                }
                var sendMessageBatchRequest = new SendMessageBatchRequest
                {
                    Entries = sendMessageBatchRequestEntries,
                    QueueUrl = _sqsQueueUrl
                };
                entries.Add(sendMessageBatchRequest);
            }
            foreach(var entry in entries)
            {
                await this._sqsClient.SendMessageBatchAsync(entry);
            }
            _attributeNames = new List<string> { "All" };
            _receiveMessageRequest = new ReceiveMessageRequest
            {
                AttributeNames = _attributeNames,
                MaxNumberOfMessages = 10,
                QueueUrl = _sqsQueueUrl
            };
        }

        /// <summary>
        /// Test SQS Receive Message with MaxNumberOfMessages set to 10 and Attribute names set to ["All"].
        /// Queue filled with messages with message body of 10k string and 5 message attributes
        /// </summary>
        [Benchmark]
        public async Task SQSReceiveMessageAsync()
        {
            await _sqsClient.ReceiveMessageAsync(_receiveMessageRequest).ConfigureAwait(false);
        }

        [GlobalCleanup]
        public async Task CleanupForReceiveMessage()
        {
            await _sqsClient.DeleteQueueAsync(_sqsQueueUrl).ConfigureAwait(false);
        }
    }
}
