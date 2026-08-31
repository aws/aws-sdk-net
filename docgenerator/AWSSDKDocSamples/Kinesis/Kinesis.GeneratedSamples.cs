using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Amazon.Kinesis;
using Amazon.Kinesis.Model;

namespace AWSSDKDocSamples.Amazon.Kinesis.Generated
{
    class KinesisSamples : ISample
    {
        public void KinesisCreateChannel()
        {
            #region create-channel-example-1

            var client = new AmazonKinesisClient();
            var response = client.CreateChannel(new CreateChannelRequest 
            {
                ChannelName = "my-channel-name",
                EncryptionConfiguration = new ChannelEncryptionConfiguration {
                    EncryptionType = "KMS",
                    KeyId = "arn:aws:kms:us-east-1:123456789012:key/1234abcd-12ab-34cd-56ef-1234567890ab"
                },
                LoggingConfiguration = new ChannelLoggingConfiguration { CloudWatchLogs = new CloudWatchLogs {
                    Enabled = true,
                    LogGroupName = "/aws/kinesis/my-channel",
                    LogStreamName = "my-channel-log-stream"
                } },
                S3DestinationConfiguration = new S3DestinationConfiguration {
                    DeadLetterQueueS3Configuration = new DeadLetterQueueS3Configuration {
                        BucketARN = "arn:aws:s3:::my-channel-dlq-bucket",
                        ExpectedBucketOwner = "123456789012"
                    },
                    StorageConfiguration = new S3StorageConfiguration {
                        BucketARN = "arn:aws:s3:::my-channel-bucket",
                        CompressionType = "ZSTD",
                        ExpectedBucketOwner = "123456789012"
                    }
                },
                ServiceExecutionRoleARN = "arn:aws:iam::123456789012:role/my-channel-role",
                StreamConfigurationList = new List<ChannelStreamConfiguration> {
                    new ChannelStreamConfiguration {
                        RecordConfiguration = new RecordConfiguration { RecordFormatType = "JSON" },
                        StreamARN = "arn:aws:kinesis:us-east-1:123456789012:stream/my-stream-name"
                    }
                }
            });

            ChannelDescription channelDescription = response.ChannelDescription;

            #endregion
        }

        public void KinesisCreateChannel()
        {
            #region create-channel-example-2

            var client = new AmazonKinesisClient();
            var response = client.CreateChannel(new CreateChannelRequest 
            {
                ChannelName = "my-channel-name",
                EncryptionConfiguration = new ChannelEncryptionConfiguration {
                    EncryptionType = "KMS",
                    KeyId = "arn:aws:kms:us-east-1:123456789012:key/1234abcd-12ab-34cd-56ef-1234567890ab"
                },
                LoggingConfiguration = new ChannelLoggingConfiguration { CloudWatchLogs = new CloudWatchLogs {
                    Enabled = true,
                    LogGroupName = "/aws/kinesis/my-channel",
                    LogStreamName = "my-channel-log-stream"
                } },
                S3TablesDestinationConfiguration = new S3TablesDestinationConfiguration {
                    DeadLetterQueueS3Configuration = new DeadLetterQueueS3Configuration {
                        BucketARN = "arn:aws:s3:::my-channel-dlq-bucket",
                        ExpectedBucketOwner = "123456789012"
                    },
                    S3TablesConfigurationList = new List<S3TablesConfiguration> {
                        new S3TablesConfiguration {
                            CompressionType = "ZSTD",
                            Namespace = "my_namespace",
                            PartitionSpec = new PartitionSpec { PartitionFields = new List<PartitionField> {
                                new PartitionField {
                                    SourceName = "creation_ts",
                                    Transform = "TIME_HOUR"
                                }
                            } },
                            TableBucketARN = "arn:aws:s3tables:us-east-1:123456789012:bucket/my-table-bucket",
                            TableName = "my_table"
                        }
                    }
                },
                ServiceExecutionRoleARN = "arn:aws:iam::123456789012:role/my-channel-role",
                StreamConfigurationList = new List<ChannelStreamConfiguration> {
                    new ChannelStreamConfiguration {
                        RecordConfiguration = new RecordConfiguration {
                            GSRSchemaARN = "arn:aws:glue:us-east-1:123456789012:schema/my-registry/my-schema",
                            RecordFormatType = "JSON"
                        },
                        StreamARN = "arn:aws:kinesis:us-east-1:123456789012:stream/my-stream-name"
                    }
                }
            });

            ChannelDescription channelDescription = response.ChannelDescription;

            #endregion
        }

        public void KinesisDeleteChannel()
        {
            #region delete-channel-example-1

            var client = new AmazonKinesisClient();
            var response = client.DeleteChannel(new DeleteChannelRequest 
            {
                ChannelARN = "arn:aws:kinesis:us-east-1:123456789012:channel/my-channel-id"
            });


            #endregion
        }

        public void KinesisDescribeChannel()
        {
            #region describe-channel-example-1

            var client = new AmazonKinesisClient();
            var response = client.DescribeChannel(new DescribeChannelRequest 
            {
                ChannelARN = "arn:aws:kinesis:us-east-1:123456789012:channel/my-channel-id"
            });

            ChannelDescription channelDescription = response.ChannelDescription;

            #endregion
        }

        public void KinesisListChannels()
        {
            #region list-channels-example-1

            var client = new AmazonKinesisClient();
            var response = client.ListChannels(new ListChannelsRequest 
            {
            });

            List<ChannelSummary> channelSummaries = response.ChannelSummaries;

            #endregion
        }

        public void KinesisListChannels()
        {
            #region list-channels-example-2

            var client = new AmazonKinesisClient();
            var response = client.ListChannels(new ListChannelsRequest 
            {
                MaxResults = 10,
                StreamFilter = new List<StreamFilter> {
                    new StreamFilter { StreamARN = "arn:aws:kinesis:us-east-1:123456789012:stream/my-stream-name" }
                }
            });

            List<ChannelSummary> channelSummaries = response.ChannelSummaries;
            string nextToken = response.NextToken;

            #endregion
        }

        public void KinesisUpdateChannel()
        {
            #region update-channel-example-1

            var client = new AmazonKinesisClient();
            var response = client.UpdateChannel(new UpdateChannelRequest 
            {
                ChannelARN = "arn:aws:kinesis:us-east-1:123456789012:channel/my-channel-id",
                LoggingConfiguration = new ChannelLoggingUpdateInput { CloudWatchLogs = new CloudWatchLogsUpdateInput {
                    Enabled = true,
                    LogGroupName = "/aws/kinesis/my-channel",
                    LogStreamName = "my-channel-log-stream"
                } },
                S3DestinationConfiguration = new S3DestinationUpdateInput { DataFreshnessInSeconds = 600 }
            });

            ChannelDescription channelDescription = response.ChannelDescription;

            #endregion
        }

        
        # region ISample Members
        public virtual void Run()
        {

        }
        # endregion

    }
}