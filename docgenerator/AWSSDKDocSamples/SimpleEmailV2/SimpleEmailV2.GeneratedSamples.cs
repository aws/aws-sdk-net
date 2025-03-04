using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Amazon.SimpleEmailV2;
using Amazon.SimpleEmailV2.Model;

namespace AWSSDKDocSamples.Amazon.SimpleEmailV2.Generated
{
    class SimpleEmailServiceV2Samples : ISample
    {
        public void SimpleEmailServiceV2CancelExportJob()
        {
            #region cancel-export-job-1685699696331

            var client = new AmazonSimpleEmailServiceV2Client();
            var response = client.CancelExportJob(new CancelExportJobRequest 
            {
                JobId = "ef28cf62-9d8e-4b60-9283-b09816c99a99"
            });


            #endregion
        }

        public void SimpleEmailServiceV2CreateExportJob()
        {
            #region create-export-job-1685701853690

            var client = new AmazonSimpleEmailServiceV2Client();
            var response = client.CreateExportJob(new CreateExportJobRequest 
            {
                ExportDataSource = new ExportDataSource { MetricsDataSource = new MetricsDataSource {
                    Dimensions = new Dictionary<string, List<string>> {
                        { "ISP", new List<string> {
                            "*"
                        } }
                    },
                    EndDate = new DateTime(2023, 7, 2, 12, 0, 0, DateTimeKind.Utc),
                    Metrics = new List<ExportMetric> {
                        new ExportMetric {
                            Aggregation = "VOLUME",
                            Name = "SEND"
                        },
                        new ExportMetric {
                            Aggregation = "VOLUME",
                            Name = "COMPLAINT"
                        },
                        new ExportMetric {
                            Aggregation = "RATE",
                            Name = "COMPLAINT"
                        }
                    },
                    Namespace = "VDM",
                    StartDate = new DateTime(2023, 7, 1, 12, 0, 0, DateTimeKind.Utc)
                } },
                ExportDestination = new ExportDestination { DataFormat = "CSV" }
            });

            string jobId = response.JobId;

            #endregion
        }

        public void SimpleEmailServiceV2CreateExportJob()
        {
            #region create-export-job-1689957853323

            var client = new AmazonSimpleEmailServiceV2Client();
            var response = client.CreateExportJob(new CreateExportJobRequest 
            {
                ExportDataSource = new ExportDataSource { MessageInsightsDataSource = new MessageInsightsDataSource {
                    EndDate = new DateTime(2023, 7, 2, 12, 0, 0, DateTimeKind.Utc),
                    Exclude = new MessageInsightsFilters { FromEmailAddress = new List<string> {
                        "hello@example.com"
                    } },
                    Include = new MessageInsightsFilters { Subject = new List<string> {
                        "Hello"
                    } },
                    StartDate = new DateTime(2023, 7, 1, 12, 0, 0, DateTimeKind.Utc)
                } },
                ExportDestination = new ExportDestination { DataFormat = "CSV" }
            });

            string jobId = response.JobId;

            #endregion
        }

        public void SimpleEmailServiceV2GetExportJob()
        {
            #region get-export-job-1685699942772

            var client = new AmazonSimpleEmailServiceV2Client();
            var response = client.GetExportJob(new GetExportJobRequest 
            {
                JobId = "ef28cf62-9d8e-4b60-9283-b09816c99a99"
            });

            DateTime createdTimestamp = response.CreatedTimestamp;
            ExportDataSource exportDataSource = response.ExportDataSource;
            ExportDestination exportDestination = response.ExportDestination;
            string exportSourceType = response.ExportSourceType;
            string jobId = response.JobId;
            string jobStatus = response.JobStatus;
            ExportStatistics statistics = response.Statistics;

            #endregion
        }

        public void SimpleEmailServiceV2GetMessageInsights()
        {
            #region get-message-insights-1689955713493

            var client = new AmazonSimpleEmailServiceV2Client();
            var response = client.GetMessageInsights(new GetMessageInsightsRequest 
            {
                MessageId = "000000000000ab00-0a000aa0-1234-0a0a-1234-0a0aaa0aa00a-000000"
            });

            List<MessageTag> emailTags = response.EmailTags;
            string fromEmailAddress = response.FromEmailAddress;
            List<EmailInsights> insights = response.Insights;
            string messageId = response.MessageId;
            string subject = response.Subject;

            #endregion
        }

        public void SimpleEmailServiceV2ListExportJobs()
        {
            #region list-export-jobs-1685702074256

            var client = new AmazonSimpleEmailServiceV2Client();
            var response = client.ListExportJobs(new ListExportJobsRequest 
            {
                ExportSourceType = "METRICS_DATA",
                JobStatus = "PROCESSING",
                PageSize = 25
            });

            List<ExportJobSummary> exportJobs = response.ExportJobs;

            #endregion
        }

        public void SimpleEmailServiceV2PutConfigurationSetArchivingOptions()
        {
            #region put-configuration-set-archiving-options-example-1737363685

            var client = new AmazonSimpleEmailServiceV2Client();
            var response = client.PutConfigurationSetArchivingOptions(new PutConfigurationSetArchivingOptionsRequest 
            {
                ArchiveArn = "arn:aws:ses:us-west-2:123456789012:mailmanager-archive/a-abcdefghijklmnopqrstuvwxyz",
                ConfigurationSetName = "sample-configuration-name"
            });


            #endregion
        }

        public void SimpleEmailServiceV2PutDedicatedIpPoolScalingAttributes()
        {
            #region put-dedicated-ip-pool-scaling-attributes-example-1683639172

            var client = new AmazonSimpleEmailServiceV2Client();
            var response = client.PutDedicatedIpPoolScalingAttributes(new PutDedicatedIpPoolScalingAttributesRequest 
            {
                PoolName = "sample-ses-pool",
                ScalingMode = "MANAGED"
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