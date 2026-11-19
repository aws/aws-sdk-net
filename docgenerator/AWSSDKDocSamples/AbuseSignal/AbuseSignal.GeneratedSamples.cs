using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Amazon.AbuseSignal;
using Amazon.AbuseSignal.Model;

namespace AWSSDKDocSamples.Amazon.AbuseSignal.Generated
{
    class AbuseSignalSamples : ISample
    {
        public void AbuseSignalCreateAbuseReport()
        {
            #region CreateAbuseReport-1

            var client = new AmazonAbuseSignalClient();
            var response = client.CreateAbuseReport(new CreateAbuseReportRequest
            {
                Report = new ReportData { Xarf = new global::Amazon.Runtime.Documents.Document(new Dictionary<string, global::Amazon.Runtime.Documents.Document>()) }
            });

            string correlationId = response.CorrelationId;
            string reportId = response.ReportId;

            #endregion
        }

        public void AbuseSignalGetAbuseReportStatus()
        {
            #region GetAbuseReportStatus-1

            var client = new AmazonAbuseSignalClient();
            var response = client.GetAbuseReportStatus(new GetAbuseReportStatusRequest
            {
                ReportId = "rpt5a8b3c2d1e4f6g7h8i9j0"
            });

            string description = response.Description;
            string reportId = response.ReportId;
            ReportSubmissionStatus status = response.Status;
            DateTime? submittedAt = response.SubmittedAt;

            #endregion
        }

        public void AbuseSignalListAbuseReportStatuses()
        {
            #region ListAbuseReportStatuses-1

            var client = new AmazonAbuseSignalClient();
            var response = client.ListAbuseReportStatuses(new ListAbuseReportStatusesRequest
            {
            });

            List<ReportStatusListItem> reports = response.Reports;

            #endregion
        }

        #region ISample Members
        public virtual void Run()
        {
        }
        #endregion
    }
}
