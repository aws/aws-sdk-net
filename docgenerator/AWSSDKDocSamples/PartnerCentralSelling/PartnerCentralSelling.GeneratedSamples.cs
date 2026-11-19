using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Amazon.PartnerCentralSelling;
using Amazon.PartnerCentralSelling.Model;

namespace AWSSDKDocSamples.Amazon.PartnerCentralSelling.Generated
{
    class PartnerCentralSellingSamples : ISample
    {
        public void PartnerCentralSellingListEngagementGroups()
        {
            #region ListEngagementGroups-1

            var client = new AmazonPartnerCentralSellingClient();
            var response = client.ListEngagementGroups(new ListEngagementGroupsRequest
            {
                Catalog = "AWS",
                MaxResults = 10,
                ReadinessLevel = "SalesReady",
                Sort = new EngagementGroupSort {
                    SortBy = "Count",
                    SortOrder = "DESCENDING"
                }
            });

            List<EngagementGroupSummary> engagementGroupSummaries = response.EngagementGroupSummaries;

            #endregion
        }

        public void PartnerCentralSellingSearchEngagements()
        {
            #region SearchEngagements-1

            var client = new AmazonPartnerCentralSellingClient();
            var response = client.SearchEngagements(new SearchEngagementsRequest
            {
                Catalog = "AWS",
                Filter = new EngagementSearchFilter { EqualsTo = new EngagementSearchPredicate {
                    Key = "ProspectingCustomerCountry",
                    Value = new EngagementSearchFilterValue { StringValue = "US" }
                } },
                Keyword = "data analytics",
                MaxResults = 20,
                Sort = new EngagementSearchSort {
                    SortBy = "CreatedAt",
                    SortOrder = "DESCENDING"
                }
            });

            List<EngagementSearchSummary> engagementSearchSummaries = response.EngagementSearchSummaries;

            #endregion
        }

        #region ISample Members
        public virtual void Run()
        {
        }
        #endregion
    }
}
