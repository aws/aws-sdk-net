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

using Amazon.CloudWatchLogs;
using Amazon.CloudWatchLogs.Model;
using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWSSDK.Benchmarks
{
    [MemoryDiagnoser]
    public class CloudwatchLogsBenchmarks
    {
        private IAmazonCloudWatchLogs _cloudWatchLogsClient;
        private List<InputLogEvent> _logEvents;
        private PutLogEventsRequest _putLogEventsRequest;
        private static Random random = new Random();
        private string _logGroupName;
        private string _logStreamName;

        [GlobalSetup(Target = nameof(CloudWatchLogsPutLogEventsAsync))]
        public async Task SetupForPutLogEvents()
        {
            _cloudWatchLogsClient = new AmazonCloudWatchLogsClient();
            _logGroupName = Utils.GenerateName("testLogGroup");
            _logStreamName = Utils.GenerateName("testLogStream");
            _logEvents = new List<InputLogEvent>();
            //2bytes = 1 character
            var message = Utils.CreateMessage(200);
            for(int i = 0; i < 100; i++)
            {
                var inputLogEvent = new InputLogEvent
                {
                    Message = message,
                    Timestamp = DateTime.UtcNow
                };
                _logEvents.Add(inputLogEvent);
            }
            var createLogGroupRequest = new CreateLogGroupRequest
            {
                LogGroupName = _logGroupName
            };
            await _cloudWatchLogsClient.CreateLogGroupAsync(createLogGroupRequest).ConfigureAwait(false);
            var createLogStreamRequest = new CreateLogStreamRequest
            {
                LogGroupName = _logGroupName,
                LogStreamName = _logStreamName
            };
            await _cloudWatchLogsClient.CreateLogStreamAsync(createLogStreamRequest).ConfigureAwait(false);
            _putLogEventsRequest = new PutLogEventsRequest
            {
                LogEvents = _logEvents,
                LogGroupName = _logGroupName,
                LogStreamName = _logStreamName
            };
        }

        /// <summary>
        /// Test CloudWatchLogs PutLogEvents with 100 LogEvents with message that is 100 characters long.
        /// </summary>
        [Benchmark]
        public async Task CloudWatchLogsPutLogEventsAsync()
        {
            await _cloudWatchLogsClient.PutLogEventsAsync(_putLogEventsRequest).ConfigureAwait(false);
        }

        [GlobalCleanup(Target = nameof(CloudWatchLogsPutLogEventsAsync))]
        public async Task CleanupPutLogEvents()
        {
            var deleteLogStreamRequest = new DeleteLogStreamRequest
            {
                LogGroupName = _logGroupName,
                LogStreamName = _logStreamName
            };
            var deleteLogGroupRequest = new DeleteLogGroupRequest
            {
                LogGroupName = _logGroupName
            };
            await _cloudWatchLogsClient.DeleteLogStreamAsync(deleteLogStreamRequest).ConfigureAwait(false);
            await _cloudWatchLogsClient.DeleteLogGroupAsync(deleteLogGroupRequest).ConfigureAwait(false);
        }
    }
}
