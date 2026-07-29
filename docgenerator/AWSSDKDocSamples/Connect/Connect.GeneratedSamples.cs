using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Amazon.Connect;
using Amazon.Connect.Model;

namespace AWSSDKDocSamples.Amazon.Connect.Generated
{
    class ConnectSamples : ISample
    {
        public void ConnectSearchRules()
        {
            #region searchrules-1719100000000

            var client = new AmazonConnectClient();
            var response = client.SearchRules(new SearchRulesRequest 
            {
                InstanceId = "12345678-1234-1234-1234-123456789012",
                MaxResults = 10,
                SearchCriteria = new RulesSearchCriteria { StringCondition = new StringCondition {
                    ComparisonType = "EXACT",
                    FieldName = "PublishStatus",
                    Value = "PUBLISHED"
                } }
            });

            long approximateTotalCount = response.ApproximateTotalCount;
            List<RuleSearchSummary> rules = response.Rules;

            #endregion
        }

        
        # region ISample Members
        public virtual void Run()
        {

        }
        # endregion

    }
}