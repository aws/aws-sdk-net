using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Amazon.BedrockAgentCore;
using Amazon.BedrockAgentCore.Model;

namespace AWSSDKDocSamples.Amazon.BedrockAgentCore.Generated
{
    class BedrockAgentCoreSamples : ISample
    {
        public void BedrockAgentCoreInvokeWebSearch()
        {
            #region InvokeWebSearch-1

            var client = new AmazonBedrockAgentCoreClient();
            var response = client.InvokeWebSearch(new InvokeWebSearchRequest
            {
                Filters = new WebSearchFilters {
                    DomainFilter = new DomainFilter { Include = new List<string> {
                        "example.com"
                    } },
                    PublishedDateFilter = new PublishedDateFilter { PublishedAfter = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc) }
                },
                MaxResults = 1,
                SearchQuery = "Amazon Bedrock AgentCore web search",
                WebSearchId = "web-search.v1"
            });

            List<WebSearchResult> results = response.Results;

            #endregion
        }

        #region ISample Members
        public virtual void Run()
        {
        }
        #endregion
    }
}
