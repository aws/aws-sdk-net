using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Amazon.S3Tables;
using Amazon.S3Tables.Model;

namespace AWSSDKDocSamples.Amazon.S3Tables.Generated
{
    class S3TablesSamples : ISample
    {
        public void S3TablesGetTableBucketLogging()
        {
            #region GetTableBucketLogging-1

            var client = new AmazonS3TablesClient();
            var response = client.GetTableBucketLogging(new GetTableBucketLoggingRequest
            {
                TableBucketARN = "arn:aws:s3tables:us-east-1:111122223333:bucket/amzn-s3-demo-table-bucket"
            });

            TableBucketLoggingStatus tableBucketLoggingStatus = response.TableBucketLoggingStatus;

            #endregion
        }

        public void S3TablesGetTableBucketLogging()
        {
            #region GetTableBucketLogging-2

            var client = new AmazonS3TablesClient();
            var response = client.GetTableBucketLogging(new GetTableBucketLoggingRequest
            {
                TableBucketARN = "arn:aws:s3tables:us-east-1:111122223333:bucket/amzn-s3-demo-table-bucket"
            });

            TableBucketLoggingStatus tableBucketLoggingStatus = response.TableBucketLoggingStatus;

            #endregion
        }

        public void S3TablesPutTableBucketLogging()
        {
            #region PutTableBucketLogging-1

            var client = new AmazonS3TablesClient();
            var response = client.PutTableBucketLogging(new PutTableBucketLoggingRequest
            {
                TableBucketARN = "arn:aws:s3tables:us-east-1:111122223333:bucket/amzn-s3-demo-table-bucket",
                TableBucketLoggingStatus = new TableBucketLoggingStatus { LoggingEnabled = new LoggingEnabled {
                    TargetBucket = "amzn-s3-demo-destination-bucket",
                    TargetObjectKeyFormat = new TargetObjectKeyFormat { PartitionedPrefix = new PartitionedPrefix { PartitionDateSource = "EventTime" } },
                    TargetPrefix = "logs/"
                } }
            });


            #endregion
        }

        public void S3TablesPutTableBucketLogging()
        {
            #region PutTableBucketLogging-2

            var client = new AmazonS3TablesClient();
            var response = client.PutTableBucketLogging(new PutTableBucketLoggingRequest
            {
                TableBucketARN = "arn:aws:s3tables:us-east-1:111122223333:bucket/amzn-s3-demo-table-bucket",
                TableBucketLoggingStatus = new TableBucketLoggingStatus {  }
            });


            #endregion
        }

        #region ISample Members
        public virtual void Run()
        {
        }
        #endregion
    }
}
