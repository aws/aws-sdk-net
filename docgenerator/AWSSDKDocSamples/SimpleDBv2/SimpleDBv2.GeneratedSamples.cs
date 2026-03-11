using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Amazon.SimpleDBv2;
using Amazon.SimpleDBv2.Model;

namespace AWSSDKDocSamples.Amazon.SimpleDBv2.Generated
{
    class SimpleDBv2Samples : ISample
    {
        public void SimpleDBv2GetExport()
        {
            #region example-1

            var client = new AmazonSimpleDBv2Client();
            var response = client.GetExport(new GetExportRequest 
            {
                ExportArn = "arn:aws:sdb:us-east-1:123456789012:export/abc123"
            });

            string clientToken = response.ClientToken;
            string domainName = response.DomainName;
            string exportArn = response.ExportArn;
            DateTime exportDataCutoffTime = response.ExportDataCutoffTime;
            string exportStatus = response.ExportStatus;
            DateTime requestedAt = response.RequestedAt;
            string s3Bucket = response.S3Bucket;

            #endregion
        }

        public void SimpleDBv2ListExports()
        {
            #region example-1

            var client = new AmazonSimpleDBv2Client();
            var response = client.ListExports(new ListExportsRequest 
            {
            });

            List<ExportSummary> exportSummaries = response.ExportSummaries;

            #endregion
        }

        public void SimpleDBv2StartDomainExport()
        {
            #region example-1

            var client = new AmazonSimpleDBv2Client();
            var response = client.StartDomainExport(new StartDomainExportRequest 
            {
                DomainName = "my-domain",
                S3Bucket = "my-export-bucket"
            });

            string clientToken = response.ClientToken;
            string exportArn = response.ExportArn;
            DateTime requestedAt = response.RequestedAt;

            #endregion
        }

        
        # region ISample Members
        public virtual void Run()
        {

        }
        # endregion

    }
}