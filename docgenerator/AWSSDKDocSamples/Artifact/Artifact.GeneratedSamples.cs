using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Amazon.Artifact;
using Amazon.Artifact.Model;

namespace AWSSDKDocSamples.Amazon.Artifact.Generated
{
    class ArtifactSamples : ISample
    {
        public void ArtifactGetAccountSettings()
        {
            #region example-1

            var client = new AmazonArtifactClient();
            var response = client.GetAccountSettings(new GetAccountSettingsRequest 
            {
            });

            AccountSettings accountSettings = response.AccountSettings;

            #endregion
        }

        public void ArtifactGetReport()
        {
            #region example-1

            var client = new AmazonArtifactClient();
            var response = client.GetReport(new GetReportRequest 
            {
                ReportId = "report-abcdef0123456789",
                TermToken = "term-token-abcdefghijklm01234567890"
            });

            string documentPresignedUrl = response.DocumentPresignedUrl;

            #endregion
        }

        public void ArtifactGetReportMetadata()
        {
            #region example-1

            var client = new AmazonArtifactClient();
            var response = client.GetReportMetadata(new GetReportMetadataRequest 
            {
                ReportId = "report-bqhUJF3FrQZsMJpb"
            });

            ReportDetail reportDetails = response.ReportDetails;

            #endregion
        }

        public void ArtifactGetTermForReport()
        {
            #region example-1

            var client = new AmazonArtifactClient();
            var response = client.GetTermForReport(new GetTermForReportRequest 
            {
                ReportId = "report-abcdef0123456789"
            });

            string documentPresignedUrl = response.DocumentPresignedUrl;
            string termToken = response.TermToken;

            #endregion
        }

        public void ArtifactListCustomerAgreements()
        {
            #region example-1

            var client = new AmazonArtifactClient();
            var response = client.ListCustomerAgreements(new ListCustomerAgreementsRequest 
            {
            });

            List<CustomerAgreementSummary> customerAgreements = response.CustomerAgreements;
            string nextToken = response.NextToken;

            #endregion
        }

        public void ArtifactListReports()
        {
            #region example-1

            var client = new AmazonArtifactClient();
            var response = client.ListReports(new ListReportsRequest 
            {
            });

            string nextToken = response.NextToken;
            List<ReportSummary> reports = response.Reports;

            #endregion
        }

        public void ArtifactPutAccountSettings()
        {
            #region example-1

            var client = new AmazonArtifactClient();
            var response = client.PutAccountSettings(new PutAccountSettingsRequest 
            {
                NotificationSubscriptionStatus = "SUBSCRIBED"
            });

            AccountSettings accountSettings = response.AccountSettings;

            #endregion
        }

        
        # region ISample Members
        public virtual void Run()
        {

        }
        # endregion

    }
}