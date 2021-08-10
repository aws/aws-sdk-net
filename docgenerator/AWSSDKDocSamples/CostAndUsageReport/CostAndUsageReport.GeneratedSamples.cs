using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Amazon.CostAndUsageReport;
using Amazon.CostAndUsageReport.Model;

namespace AWSSDKDocSamples.Amazon.CostAndUsageReport.Generated
{
    class CostAndUsageReportSamples : ISample
    {
        public void CostAndUsageReportDeleteReportDefinition()
        {
            #region to-delete-a-report

            var client = new AmazonCostAndUsageReportClient();
            var response = client.DeleteReportDefinition(new DeleteReportDefinitionRequest 
            {
                ReportName = "ExampleReport"
            });


            #endregion
        }

        public void CostAndUsageReportDescribeReportDefinitions()
        {
            #region to-retrieve-report-definitions

            var client = new AmazonCostAndUsageReportClient();
            var response = client.DescribeReportDefinitions(new DescribeReportDefinitionsRequest 
            {
                MaxResults = 5
            });

            List<ReportDefinition> reportDefinitions = response.ReportDefinitions;

            #endregion
        }

        public void CostAndUsageReportPutReportDefinition()
        {
            #region to-create-a-report-definitions

            var client = new AmazonCostAndUsageReportClient();
            var response = client.PutReportDefinition(new PutReportDefinitionRequest 
            {
                ReportDefinition = new ReportDefinition {
                    AdditionalArtifacts = new List<string> {
                        "REDSHIFT",
                        "QUICKSIGHT"
                    },
                    AdditionalSchemaElements = new List<string> {
                        "RESOURCES"
                    },
                    Compression = "ZIP",
                    Format = "textORcsv",
                    ReportName = "ExampleReport",
                    S3Bucket = "example-s3-bucket",
                    S3Prefix = "exampleprefix",
                    S3Region = "us-east-1",
                    TimeUnit = "DAILY"
                }
            });


            #endregion
        }

        
        # region ISample Members
        public virtual void Run()
        {

        }
        # endregion

    }
}