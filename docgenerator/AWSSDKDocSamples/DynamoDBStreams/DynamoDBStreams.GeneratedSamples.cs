using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Amazon.DynamoDBStreams;
using Amazon.DynamoDBStreams.Model;

namespace AWSSDKDocSamples.Amazon.DynamoDBStreams.Generated
{
    class DynamoDBStreamsSamples : ISample
    {
        public void DynamoDBStreamsGetShardIterator()
        {
            #region GetShardIterator-1

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
            #region ListStreams-1

            var client = new AmazonDynamoDBStreamsClient();
            var response = client.ListStreams(new ListStreamsRequest
            {
            });

            List<StreamSummary> streams = response.Streams;

            #endregion
        }

        #region ISample Members
        public virtual void Run()
        {
        }
        #endregion
    }
}
