using System;
using System.Collections.Generic;
using System.Threading;

using Amazon.CloudWatchLogs;
using Amazon.CloudWatchLogs.Model;
using Xunit;
using Amazon.DNXCore.IntegrationTests;

namespace Amazon.DNXCore.IntegrationTests
{
    
    public class CloudWatchLogs : TestBase<AmazonCloudWatchLogsClient>
    {        
        [Fact]
        [Trait(CategoryAttribute,"CloudWatchLogs")]
        public void CRUDLogGroup()
        {
            var logGroupName = "sdk-dotnet-" + DateTime.Now.Ticks;
            Client.CreateLogGroupAsync(new CreateLogGroupRequest
            {
                LogGroupName = logGroupName
            }).Wait();
            try
            {
                {
                    DescribeLogGroupsResponse response = Client.DescribeLogGroupsAsync(new DescribeLogGroupsRequest
                        {
                            LogGroupNamePrefix = logGroupName
                        }).Result;

                    Assert.Equal(1, response.LogGroups.Count);
                    Assert.NotNull(response.LogGroups[0].Arn);
                    Assert.Null(response.LogGroups[0].RetentionInDays);

                    Client.PutRetentionPolicyAsync(new PutRetentionPolicyRequest
                        {
                            LogGroupName = logGroupName,
                            RetentionInDays = 1
                        }).Wait();

                    response = Client.DescribeLogGroupsAsync(new DescribeLogGroupsRequest
                    {
                        LogGroupNamePrefix = logGroupName
                    }).Result;

                    Assert.Equal(1, response.LogGroups.Count);
                    Assert.Equal(1, response.LogGroups[0].RetentionInDays.GetValueOrDefault());
                }

                {
                    Client.CreateLogStreamAsync(new CreateLogStreamRequest
                        {
                            LogGroupName = logGroupName,
                            LogStreamName = "sample"
                        }).Wait();

                    DescribeLogStreamsResponse describeResponse = Client.DescribeLogStreamsAsync(new DescribeLogStreamsRequest
                        {
                            LogGroupName = logGroupName,
                            LogStreamNamePrefix = "sample"
                        }).Result;

                    Assert.Equal(1, describeResponse.LogStreams.Count);
                    Assert.NotNull(describeResponse.LogStreams[0].Arn);

                    PutLogEventsResponse putResponse1 = Client.PutLogEventsAsync(new PutLogEventsRequest
                        {
                            LogGroupName = logGroupName,
                            LogStreamName = "sample",
                            LogEvents = new List<InputLogEvent>
                            {
                                new InputLogEvent
                                {
                                    Message = "First Data",
                                    Timestamp = DateTime.Now
                                }
                            }
                        }).Result;

                    // Pad the time so the 2 events are not at the same time.
                    UtilityMethods.Sleep(TimeSpan.FromSeconds(.1));

                    Client.PutLogEventsAsync(new PutLogEventsRequest
                    {
                         SequenceToken = putResponse1.NextSequenceToken,
                        LogGroupName = logGroupName,
                        LogStreamName = "sample",
                        LogEvents = new List<InputLogEvent>
                            {
                                new InputLogEvent
                                {
                                    Message = "Second Data",
                                    Timestamp = DateTime.Now
                                }
                            }
                    }).Wait();

                    GetLogEventsResponse getResponse = null;

                    // Doing this in a loop to wait for the eventual consistency of the events
                    // being written to cloudwatch logs.
                    for (int i = 0; i < 20; i++)
                    {

                        getResponse = Client.GetLogEventsAsync(new GetLogEventsRequest
                            {
                                LogGroupName = logGroupName,
                                LogStreamName = "sample",
                                StartTime = DateTime.Now.AddDays(-2),
                                EndTime = DateTime.Now
                            }).Result;

                        if (getResponse.Events.Count == 2)
                            break;

                        UtilityMethods.Sleep(TimeSpan.FromSeconds(2));
                    }

                    Assert.Equal(2, getResponse.Events.Count);
                    Assert.Equal("First Data", getResponse.Events[0].Message);
                    Assert.Equal(DateTime.UtcNow.Date, getResponse.Events[0].Timestamp.Date);

                    Assert.Equal("Second Data", getResponse.Events[1].Message);
                    Assert.Equal(DateTime.UtcNow.Date, getResponse.Events[1].Timestamp.Date);

                    Assert.True(getResponse.Events[0].Timestamp < getResponse.Events[1].Timestamp);


                    Client.DeleteLogStreamAsync(new DeleteLogStreamRequest
                        {
                            LogGroupName = logGroupName,
                            LogStreamName = "sample"
                        }).Wait();
                }
            }
            finally
            {
                Client.DeleteLogGroupAsync(new DeleteLogGroupRequest
                    {
                        LogGroupName = logGroupName
                    }).Wait();
            }
        }
    }
}