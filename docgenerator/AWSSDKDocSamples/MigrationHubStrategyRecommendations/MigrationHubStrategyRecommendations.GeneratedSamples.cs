using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Amazon.MigrationHubStrategyRecommendations;
using Amazon.MigrationHubStrategyRecommendations.Model;

namespace AWSSDKDocSamples.Amazon.MigrationHubStrategyRecommendations.Generated
{
    class MigrationHubStrategyRecommendationsSamples : ISample
    {
        public void MigrationHubStrategyRecommendationsListAnalyzableServers()
        {
            #region ListAnalyzableServers-1

            var client = new AmazonMigrationHubStrategyRecommendationsClient();
            var response = client.ListAnalyzableServers(new ListAnalyzableServersRequest
            {
                MaxResults = 100,
                Sort = "ASC"
            });

            List<AnalyzableServerSummary> analyzableServers = response.AnalyzableServers;

            #endregion
        }

        #region ISample Members
        public virtual void Run()
        {
        }
        #endregion
    }
}
