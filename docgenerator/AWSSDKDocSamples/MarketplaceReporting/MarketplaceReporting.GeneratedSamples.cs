using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Amazon.MarketplaceReporting;
using Amazon.MarketplaceReporting.Model;

namespace AWSSDKDocSamples.Amazon.MarketplaceReporting.Generated
{
    class MarketplaceReportingSamples : ISample
    {
        public void MarketplaceReportingGetBuyerDashboard()
        {
            #region example-1

            var client = new AmazonMarketplaceReportingClient();
            var response = client.GetBuyerDashboard(new GetBuyerDashboardRequest 
            {
                DashboardIdentifier = "arn:aws:aws-marketplace::123456789012:AWSMarketplace/ReportingData/Agreement_V1/Dashboard/AgreementSummary_V1",
                EmbeddingDomains = new List<string> {
                    "https://*.amazon.com"
                }
            });

            string dashboardIdentifier = response.DashboardIdentifier;
            string embedUrl = response.EmbedUrl;
            List<string> embeddingDomains = response.EmbeddingDomains;

            #endregion
        }

        public void MarketplaceReportingGetBuyerDashboard()
        {
            #region example-2

            var client = new AmazonMarketplaceReportingClient();
            var response = client.GetBuyerDashboard(new GetBuyerDashboardRequest 
            {
                DashboardIdentifier = "arn:aws:aws-marketplace::123456789012:AWSMarketplace/ReportingData/BillingEvent_V1/Dashboard/CostAnalysis_V1",
                EmbeddingDomains = new List<string> {
                    "https://*.amazon.com"
                }
            });

            string dashboardIdentifier = response.DashboardIdentifier;
            string embedUrl = response.EmbedUrl;
            List<string> embeddingDomains = response.EmbeddingDomains;

            #endregion
        }

        
        # region ISample Members
        public virtual void Run()
        {

        }
        # endregion

    }
}