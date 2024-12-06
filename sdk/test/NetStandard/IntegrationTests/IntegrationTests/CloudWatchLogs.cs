using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

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
        public async Task CRUDLogGroup()
        {
            var logGroupName = "sdk-dotnet-" + DateTime.UtcNow.Ticks;
            await Client.CreateLogGroupAsync(new CreateLogGroupRequest
            {
                LogGroupName = logGroupName
            });
            try
            {
                {
                    DescribeLogGroupsResponse response = await Client.DescribeLogGroupsAsync(new DescribeLogGroupsRequest
                        {
                            LogGroupNamePrefix = logGroupName
                        });

                    Assert.Single(response.LogGroups);
                    Assert.NotNull(response.LogGroups[0].Arn);
                    Assert.Null(response.LogGroups[0].RetentionInDays);

                    await Client.PutRetentionPolicyAsync(new PutRetentionPolicyRequest
                        {
                            LogGroupName = logGroupName,
                            RetentionInDays = 1
                        });

                    response = await Client.DescribeLogGroupsAsync(new DescribeLogGroupsRequest
                    {
                        LogGroupNamePrefix = logGroupName
                    });

                    Assert.Single(response.LogGroups);
                    Assert.Equal(1, response.LogGroups[0].RetentionInDays.GetValueOrDefault());
                }

                {
                    await Client.CreateLogStreamAsync(new CreateLogStreamRequest
                        {
                            LogGroupName = logGroupName,
                            LogStreamName = "sample"
                        });

                    DescribeLogStreamsResponse describeResponse = await Client.DescribeLogStreamsAsync(new DescribeLogStreamsRequest
                        {
                            LogGroupName = logGroupName,
                            LogStreamNamePrefix = "sample"
                        });

                    Assert.Single(describeResponse.LogStreams);
                    Assert.NotNull(describeResponse.LogStreams[0].Arn);

                    PutLogEventsResponse putResponse1 = await Client.PutLogEventsAsync(new PutLogEventsRequest
                        {
                            LogGroupName = logGroupName,
                            LogStreamName = "sample",
                            LogEvents = new List<InputLogEvent>
                            {
                                new InputLogEvent
                                {
                                    Message = "First Data",
                                    Timestamp = DateTime.UtcNow
                                }
                            }
                        });

                    // Pad the time so the 2 events are not at the same time.
                    UtilityMethods.Sleep(TimeSpan.FromSeconds(.1));

                    await Client.PutLogEventsAsync(new PutLogEventsRequest
                    {
                         SequenceToken = putResponse1.NextSequenceToken,
                        LogGroupName = logGroupName,
                        LogStreamName = "sample",
                        LogEvents = new List<InputLogEvent>
                            {
                                new InputLogEvent
                                {
                                    Message = "Second Data",
                                    Timestamp = DateTime.UtcNow
                                }
                            }
                    });

                    GetLogEventsResponse getResponse = null;

                    // Doing this in a loop to wait for the eventual consistency of the events
                    // being written to cloudwatch logs.
                    for (int i = 0; i < 20; i++)
                    {

                        getResponse = await Client.GetLogEventsAsync(new GetLogEventsRequest
                            {
                                LogGroupName = logGroupName,
                                LogStreamName = "sample",
                                StartTime = DateTime.UtcNow.AddDays(-2),
                                EndTime = DateTime.UtcNow
                            });

                        if (getResponse.Events.Count == 2)
                            break;

                        UtilityMethods.Sleep(TimeSpan.FromSeconds(2));
                    }

                    Assert.Equal(2, getResponse.Events.Count);
                    Assert.Equal("First Data", getResponse.Events[0].Message);
                    Assert.Equal(DateTime.UtcNow.Date, getResponse.Events[0].Timestamp.Value.Date);

                    Assert.Equal("Second Data", getResponse.Events[1].Message);
                    Assert.Equal(DateTime.UtcNow.Date, getResponse.Events[1].Timestamp.Value.Date);

                    Assert.True(getResponse.Events[0].Timestamp < getResponse.Events[1].Timestamp);
                }
            }
            finally
            {
                await Client.DeleteLogStreamAsync(new DeleteLogStreamRequest
                {
                    LogGroupName = logGroupName,
                    LogStreamName = "sample"
                });
                await Client.DeleteLogGroupAsync(new DeleteLogGroupRequest
                {
                    LogGroupName = logGroupName
                });
            }
        }
    }
}