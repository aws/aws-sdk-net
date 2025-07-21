using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Amazon.DynamoDBStreams;
using Amazon.DynamoDBStreams.Model;

namespace AWSSDKDocSamples.Amazon.DynamoDBStreams.Generated
{
    class DynamoDBStreamsSamples : ISample
    {
        public void DynamoDBStreamsDescribeStream()
        {
            #region to-describe-a-stream-with-a-given-stream-arn-1473457835200

            var client = new AmazonDynamoDBStreamsClient();
            var response = client.DescribeStream(new DescribeStreamRequest 
            {
                StreamArn = "arn:aws:dynamodb:us-west-2:111122223333:table/Forum/stream/2015-05-20T20:51:10.252"
            });

            StreamDescription streamDescription = response.StreamDescription;

            #endregion
        }

        public void DynamoDBStreamsGetRecords()
        {
            #region to-retrieve-all-the-stream-records-from-a-shard-1473707781419

            var client = new AmazonDynamoDBStreamsClient();
            var response = client.GetRecords(new GetRecordsRequest 
            {
                ShardIterator = "arn:aws:dynamodb:us-west-2:111122223333:table/Forum/stream/2015-05-20T20:51:10.252|1|AAAAAAAAAAEvJp6D+zaQ...  <remaining characters omitted> ..."
            });

            string nextShardIterator = response.NextShardIterator;
            List<Record> records = response.Records;

            #endregion
        }

        public void DynamoDBStreamsGetShardIterator()
        {
            #region to-obtain-a-shard-iterator-for-the-provided-stream-arn-and-shard-id-1473459941476

            var client = new AmazonDynamoDBStreamsClient();
            var response = client.GetShardIterator(new GetShardIteratorRequest 
            {
                ShardId = "00000001414576573621-f55eea83",
                ShardIteratorType = "TRIM_HORIZON",
                StreamArn = "arn:aws:dynamodb:us-west-2:111122223333:table/Forum/stream/2015-05-20T20:51:10.252"
            });

            string shardIterator = response.ShardIterator;

            #endregion
        }

        public void DynamoDBStreamsListStreams()
        {
            #region to-list-all-of-the-stream-arns--1473459534285

            var client = new AmazonDynamoDBStreamsClient();
            var response = client.ListStreams(new ListStreamsRequest 
            {
            });

            List<StreamSummary> streams = response.Streams;

            #endregion
        }

        
        # region ISample Members
        public virtual void Run()
        {

        }
        # endregion

    }
}