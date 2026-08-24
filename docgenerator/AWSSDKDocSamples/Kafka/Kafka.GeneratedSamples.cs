using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Amazon.Kafka;
using Amazon.Kafka.Model;

namespace AWSSDKDocSamples.Amazon.Kafka.Generated
{
    class KafkaSamples : ISample
    {
        public void KafkaCreateChannel()
        {
            #region to-create-an-s3-data-channel-1700000000000

            var client = new AmazonKafkaClient();
            var response = client.CreateChannel(new CreateChannelRequest 
            {
                ClusterArn = "arn:aws:kafka:us-east-1:111122223333:cluster/example-cluster/abcd1234-a123-4b56-c789-abc0def9012a-1",
                ChannelName = "example-s3-channel",
                TopicConfigurationList = new List<TopicConfiguration> {
                    new TopicConfiguration {
                        TopicArn = "arn:aws:kafka:us-east-1:111122223333:topic/example-cluster/abcd1234-a123-4b56-c789-abc0def9012a-1/example-topic",
                        RecordConverter = new RecordConverter { ValueConverter = "STRING" }
                    }
                },
                S3DestinationConfiguration = new S3DestinationConfiguration {
                    ServiceExecutionRoleArn = "arn:aws:iam::111122223333:role/example-channel-execution-role",
                    DataFreshnessInSeconds = 300,
                    DeadLetterQueueS3 = new DeadLetterQueueS3 {
                        BucketArn = "arn:aws:s3:::example-dlq-bucket",
                        ErrorOutputPrefix = "errorPrefix/",
                        ExpectedBucketOwner = "111122223333"
                    },
                    Storage = new S3Storage {
                        BucketArn = "arn:aws:s3:::example-destination-bucket",
                        CompressionType = "GZIP",
                        StorageClass = "STANDARD",
                        OutputPrefix = "channel-output/",
                        OutputKeyTemplate = "!{channel-id}/!{topic-name}/year=!{yyyy}/month=!{MM}/day=!{dd}/hour=!{HH}/minute=!{mm}/!{topic-name}+!{partition-id}+!{sequence-number}",
                        ExpectedBucketOwner = "111122223333"
                    }
                }
            });

            string channelArn = response.ChannelArn;
            string clusterOperationArn = response.ClusterOperationArn;

            #endregion
        }

        public void KafkaCreateChannel()
        {
            #region to-create-an-iceberg-data-channel-1700000000001

            var client = new AmazonKafkaClient();
            var response = client.CreateChannel(new CreateChannelRequest 
            {
                ClusterArn = "arn:aws:kafka:us-east-1:111122223333:cluster/example-cluster/abcd1234-a123-4b56-c789-abc0def9012a-1",
                ChannelName = "example-iceberg-channel",
                TopicConfigurationList = new List<TopicConfiguration> {
                    new TopicConfiguration {
                        TopicArn = "arn:aws:kafka:us-east-1:111122223333:topic/example-cluster/abcd1234-a123-4b56-c789-abc0def9012a-1/example-topic",
                        RecordConverter = new RecordConverter { ValueConverter = "JSON" },
                        RecordSchema = new RecordSchema { GsrArn = "arn:aws:glue:us-east-1:111122223333:registry/example-registry" }
                    }
                },
                IcebergDestinationConfiguration = new IcebergDestinationConfiguration {
                    AppendOnly = true,
                    Catalog = new Catalog {
                        CatalogArn = "arn:aws:glue:us-east-1:111122223333:catalog",
                        WarehouseLocation = "s3://example-warehouse-bucket/warehouse/"
                    },
                    TableCreation = new TableCreation { EnableTableCreation = true },
                    SchemaEvolution = new SchemaEvolution { EnableSchemaEvolution = false },
                    DestinationTableList = new List<DestinationTable> {
                        new DestinationTable {
                            DestinationDatabaseName = "example_database",
                            DestinationTableName = "example_table",
                            PartitionSpec = new PartitionSpec {
                                PartitionStrategy = "TIME_HOUR",
                                SourceList = new List<PartitionSource> {
                                    new PartitionSource { SourceName = "event_timestamp" }
                                }
                            }
                        }
                    },
                    DataFreshnessInSeconds = 300,
                    DeadLetterQueueS3 = new DeadLetterQueueS3 {
                        BucketArn = "arn:aws:s3:::example-dlq-bucket",
                        ErrorOutputPrefix = "errorPrefix/",
                        ExpectedBucketOwner = "111122223333"
                    },
                    ServiceExecutionRoleArn = "arn:aws:iam::111122223333:role/example-channel-execution-role"
                }
            });

            string channelArn = response.ChannelArn;
            string clusterOperationArn = response.ClusterOperationArn;

            #endregion
        }

        public void KafkaDeleteChannel()
        {
            #region to-delete-a-data-channel-1700000000005

            var client = new AmazonKafkaClient();
            var response = client.DeleteChannel(new DeleteChannelRequest 
            {
                ClusterArn = "arn:aws:kafka:us-east-1:111122223333:cluster/example-cluster/abcd1234-a123-4b56-c789-abc0def9012a-1",
                ChannelArn = "arn:aws:kafka:us-east-1:111122223333:channel/example-cluster/abcd1234-a123-4b56-c789-abc0def9012a-1/example-s3-channel"
            });

            string channelArn = response.ChannelArn;
            string clusterOperationArn = response.ClusterOperationArn;

            #endregion
        }

        public void KafkaDescribeChannel()
        {
            #region to-describe-a-data-channel-1700000000002

            var client = new AmazonKafkaClient();
            var response = client.DescribeChannel(new DescribeChannelRequest 
            {
                ClusterArn = "arn:aws:kafka:us-east-1:111122223333:cluster/example-cluster/abcd1234-a123-4b56-c789-abc0def9012a-1",
                ChannelArn = "arn:aws:kafka:us-east-1:111122223333:channel/example-cluster/abcd1234-a123-4b56-c789-abc0def9012a-1/example-s3-channel"
            });

            string channelArn = response.ChannelArn;
            string channelName = response.ChannelName;
            string status = response.Status;
            string destinationType = response.DestinationType;
            DateTime creationTime = response.CreationTime;
            List<TopicConfiguration> topicConfigurationList = response.TopicConfigurationList;
            S3DestinationConfiguration s3DestinationConfiguration = response.S3DestinationConfiguration;

            #endregion
        }

        public void KafkaListChannels()
        {
            #region to-list-data-channels-1700000000003

            var client = new AmazonKafkaClient();
            var response = client.ListChannels(new ListChannelsRequest 
            {
                ClusterArn = "arn:aws:kafka:us-east-1:111122223333:cluster/example-cluster/abcd1234-a123-4b56-c789-abc0def9012a-1",
                MaxResults = 10
            });

            List<ChannelInfo> channels = response.Channels;

            #endregion
        }

        public void KafkaUpdateChannel()
        {
            #region to-update-a-data-channel-1700000000004

            var client = new AmazonKafkaClient();
            var response = client.UpdateChannel(new UpdateChannelRequest 
            {
                ClusterArn = "arn:aws:kafka:us-east-1:111122223333:cluster/example-cluster/abcd1234-a123-4b56-c789-abc0def9012a-1",
                ChannelArn = "arn:aws:kafka:us-east-1:111122223333:channel/example-cluster/abcd1234-a123-4b56-c789-abc0def9012a-1/example-s3-channel",
                S3DestinationUpdate = new S3DestinationUpdate { DataFreshnessInSeconds = 600 }
            });

            string channelArn = response.ChannelArn;
            string clusterOperationArn = response.ClusterOperationArn;

            #endregion
        }

        
        # region ISample Members
        public virtual void Run()
        {

        }
        # endregion

    }
}