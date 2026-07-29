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
        public void ArtifactCreateComplianceInquiry()
        {
            #region example-1

            var client = new AmazonArtifactClient();
            var response = client.CreateComplianceInquiry(new CreateComplianceInquiryRequest 
            {
                Name = "My Compliance Inquiry",
                ClientToken = "unique-client-token-1234",
                InquiryContent = new InquiryContent { Query = "Is my workload compliant with SOC 2?" },
                SupportMode = "AI_ONLY"
            });

            InquirySummary complianceInquirySummary = response.ComplianceInquirySummary;

            #endregion
        }

        public void ArtifactExportComplianceInquiry()
        {
            #region example-1

            var client = new AmazonArtifactClient();
            var response = client.ExportComplianceInquiry(new ExportComplianceInquiryRequest 
            {
                ComplianceInquiryId = "compliance-inquiry-abcdef0123456789",
                IncludeCitations = true,
                QueryIdentifiers = new List<int> {
                    1,
                    2
                }
            });

            string documentPresignedUrl = response.DocumentPresignedUrl;

            #endregion
        }

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

        public void ArtifactGetComplianceInquiryMetadata()
        {
            #region example-1

            var client = new AmazonArtifactClient();
            var response = client.GetComplianceInquiryMetadata(new GetComplianceInquiryMetadataRequest 
            {
                ComplianceInquiryId = "compliance-inquiry-abcdef0123456789"
            });

            InquiryDetail complianceInquiryDetail = response.ComplianceInquiryDetail;

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

        public void ArtifactListComplianceInquiries()
        {
            #region example-1

            var client = new AmazonArtifactClient();
            var response = client.ListComplianceInquiries(new ListComplianceInquiriesRequest 
            {
                MaxResults = 10
            });

            List<InquirySummary> complianceInquiries = response.ComplianceInquiries;

            #endregion
        }

        public void ArtifactListComplianceInquiryQueries()
        {
            #region example-1

            var client = new AmazonArtifactClient();
            var response = client.ListComplianceInquiryQueries(new ListComplianceInquiryQueriesRequest 
            {
                ComplianceInquiryId = "compliance-inquiry-abcdef0123456789",
                MaxResults = 10
            });

            List<QuerySummary> queries = response.Queries;

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

        public void ArtifactListReportVersions()
        {
            #region example-1

            var client = new AmazonArtifactClient();
            var response = client.ListReportVersions(new ListReportVersionsRequest 
            {
                ReportId = "report-abcdef0123456789"
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