using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading;
using AWSSDK_DotNet.IntegrationTests.Utils;

using Amazon.CloudWatchLogs;
using Amazon.CloudWatchLogs.Model;

namespace AWSSDK_DotNet.IntegrationTests.Tests
{
    [TestClass]
    public class CloudWatchLogs : TestBase<AmazonCloudWatchLogsClient>
    {
        [ClassCleanup]
        public static void Cleanup()
        {
            BaseClean();
        }

        [TestMethod]
        [TestCategory("CloudWatchLogs")]
        public void CRUDLogGroup()
        {
            var logGroupName = "sdk-dotnet-" + DateTime.Now.Ticks;
            Client.CreateLogGroup(new CreateLogGroupRequest
            {
                LogGroupName = logGroupName
            });
            try
            {
                {
                    DescribeLogGroupsResponse response = Client.DescribeLogGroups(new DescribeLogGroupsRequest
                        {
                            LogGroupNamePrefix = logGroupName
                        });

                    Assert.AreEqual(1, response.LogGroups.Count);
                    Assert.IsNotNull(response.LogGroups[0].Arn);
                    Assert.IsNull(response.LogGroups[0].RetentionInDays);

                    Client.PutRetentionPolicy(new PutRetentionPolicyRequest
                        {
                            LogGroupName = logGroupName,
                            RetentionInDays = 1
                        });

                    response = Client.DescribeLogGroups(new DescribeLogGroupsRequest
                    {
                        LogGroupNamePrefix = logGroupName
                    });

                    Assert.AreEqual(1, response.LogGroups.Count);
                    Assert.AreEqual(1, response.LogGroups[0].RetentionInDays.GetValueOrDefault());
                }

                {
                    Client.CreateLogStream(new CreateLogStreamRequest
                        {
                            LogGroupName = logGroupName,
                            LogStreamName = "sample"
                        });

                    DescribeLogStreamsResponse describeResponse = Client.DescribeLogStreams(new DescribeLogStreamsRequest
                        {
                            LogGroupName = logGroupName,
                            LogStreamNamePrefix = "sample"
                        });

                    Assert.AreEqual(1, describeResponse.LogStreams.Count);
                    Assert.IsNotNull(describeResponse.LogStreams[0].Arn);

                    PutLogEventsResponse putResponse1 = Client.PutLogEvents(new PutLogEventsRequest
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
                        });

                    // Pad the time so the 2 events are not at the same time.
                    Thread.Sleep(10);

                    Client.PutLogEvents(new PutLogEventsRequest
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
                    });

                    GetLogEventsResponse getResponse = null;

                    // Doing this in a loop to wait for the eventual consistency of the events
                    // being written to cloudwatch logs.
                    for (int i = 0; i < 20; i++)
                    {

                        getResponse = Client.GetLogEvents(new GetLogEventsRequest
                            {
                                LogGroupName = logGroupName,
                                LogStreamName = "sample",
                                StartTime = DateTime.Now.AddDays(-2),
                                EndTime = DateTime.Now
                            });

                        if (getResponse.Events.Count == 2)
                            break;

                        Thread.Sleep(1000 * 2);
                    }

                    Assert.AreEqual(2, getResponse.Events.Count);
                    Assert.AreEqual("First Data", getResponse.Events[0].Message);
                    Assert.AreEqual(DateTime.UtcNow.Date, getResponse.Events[0].Timestamp.Date);

                    Assert.AreEqual("Second Data", getResponse.Events[1].Message);
                    Assert.AreEqual(DateTime.UtcNow.Date, getResponse.Events[1].Timestamp.Date);

                    Assert.IsTrue(getResponse.Events[0].Timestamp < getResponse.Events[1].Timestamp);


                    Client.DeleteLogStream(new DeleteLogStreamRequest
                        {
                            LogGroupName = logGroupName,
                            LogStreamName = "sample"
                        });
                }
            }
            finally
            {
                Client.DeleteLogGroup(new DeleteLogGroupRequest
                    {
                        LogGroupName = logGroupName
                    });
            }
        }
    }
}