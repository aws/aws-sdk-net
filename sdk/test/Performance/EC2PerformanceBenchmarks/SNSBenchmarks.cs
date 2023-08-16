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

using Amazon.SimpleNotificationService;
using Amazon.SimpleNotificationService.Model;
using AWSSDK.Benchmarks;
using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWSSDK.Benchmarks
{
    [MemoryDiagnoser]
    public class SNSBenchmarks
    {
        private static Random random = new Random();
        private IAmazonSimpleNotificationService _snsClient;
        private string _topicName;
        private string _topicArn;
        private PublishRequest _publishRequest;

        [GlobalSetup]
        public async Task SetupForPublish()
        {
            _snsClient = new AmazonSimpleNotificationServiceClient();
            _topicName = "TestTopic" + random.Next(1, 10000).ToString();
            var response = await _snsClient.CreateTopicAsync(_topicName).ConfigureAwait(false);
            _topicArn = response.TopicArn;
            var messageBody = Utils.CreateMessage(Constants.KiloSize * 10);
            var messageAttributes = new Dictionary<string, MessageAttributeValue> {
                {"AttributeA",new MessageAttributeValue{DataType = "String", StringValue = "TestingA" } },
                {"AttributeB",new MessageAttributeValue{DataType = "String", StringValue = "TestingB" } },
                {"AttributeC",new MessageAttributeValue{DataType = "String", StringValue = "TestingC" } },
                {"AttributeD",new MessageAttributeValue{DataType = "String", StringValue = "TestingD" } },
                {"AttributeE",new MessageAttributeValue{DataType = "String", StringValue = "TestingE" } }
            };
            _publishRequest = new PublishRequest
            {
                Message = messageBody,
                MessageAttributes = messageAttributes,
                TopicArn = _topicArn
            };

        }

        /// <summary>
        /// Testing publishing a message with 10K body size and 5 message attributes.
        /// </summary>
        [Benchmark]
        public async Task SNSPublishAsync()
        {
            await _snsClient.PublishAsync(_publishRequest).ConfigureAwait(false);
        }

        [GlobalCleanup] 
        public async void Cleanup() 
        {
            await _snsClient.DeleteTopicAsync(_topicName).ConfigureAwait(false);
        }
    }
}
