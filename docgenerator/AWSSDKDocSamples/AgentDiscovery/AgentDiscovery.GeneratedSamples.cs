using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Amazon.AgentDiscovery;
using Amazon.AgentDiscovery.Model;

namespace AWSSDKDocSamples.Amazon.AgentDiscovery.Generated
{
    class AgentDiscoverySamples : ISample
    {
        public void AgentDiscoverySearchPublicRecords()
        {
            #region SearchPublicRecords-1

            var client = new AmazonAgentDiscoveryClient();
            var response = client.SearchPublicRecords(new SearchPublicRecordsRequest
            {
                Filters = new global::Amazon.Runtime.Documents.Document {
                    { "recordType", new global::Amazon.Runtime.Documents.Document {
                        { "$eq", "AGENT" }
                    } }
                },
                MaxResults = 1,
                SearchQuery = "book a flight"
            });

            string nextToken = response.NextToken;
            List<PublicRecord> records = response.Records;

            #endregion
        }

        #region ISample Members
        public virtual void Run()
        {
        }
        #endregion
    }
}
