using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Amazon.Inspector2;
using Amazon.Inspector2.Model;

namespace AWSSDKDocSamples.Amazon.Inspector2.Generated
{
    class Inspector2Samples : ISample
    {
        public void Inspector2BatchGetFindingDetails()
        {
            #region example-1

            var client = new AmazonInspector2Client();
            var response = client.BatchGetFindingDetails(new BatchGetFindingDetailsRequest 
            {
                FindingArns = new List<string> {
                    "arn:aws:inspector2:eu-west-1:123456789012:finding/78b88cc9aa1d78b6e14fde90d774dde7",
                    "arn:aws:inspector2:eu-west-1:111111111111:finding/78b88cc9aa1d78b6e14fde90d874dde7"
                }
            });

            List<FindingDetailsError> errors = response.Errors;
            List<FindingDetail> findingDetails = response.FindingDetails;

            #endregion
        }

        public void Inspector2CreateCisScanConfiguration()
        {
            #region example-1

            var client = new AmazonInspector2Client();
            var response = client.CreateCisScanConfiguration(new CreateCisScanConfigurationRequest 
            {
                ScanName = "sample",
                Schedule = new Schedule { Daily = new DailySchedule { StartTime = new Time {
                    TimeOfDay = "12:34",
                    Timezone = "UTC"
                } } },
                SecurityLevel = "LEVEL_1",
                Targets = new CreateCisTargets {
                    AccountIds = new List<string> {
                        "SELF"
                    },
                    TargetResourceTags = new Dictionary<string, List<string>> {
                        { "key", new List<string> {
                            "value"
                        } }
                    }
                }
            });

            string scanConfigurationArn = response.ScanConfigurationArn;

            #endregion
        }

        public void Inspector2DeleteCisScanConfiguration()
        {
            #region example-1

            var client = new AmazonInspector2Client();
            var response = client.DeleteCisScanConfiguration(new DeleteCisScanConfigurationRequest 
            {
                ScanConfigurationArn = "arn:aws:inspector2:us-east-1:123412341234:owner/123412341234/cis-configuration/624b746d-e080-44ae-8c1d-48e653365a38"
            });

            string scanConfigurationArn = response.ScanConfigurationArn;

            #endregion
        }

        public void Inspector2GetCisScanReport()
        {
            #region example-1

            var client = new AmazonInspector2Client();
            var response = client.GetCisScanReport(new GetCisScanReportRequest 
            {
                ReportFormat = "PDF",
                ScanArn = "arn:aws:inspector2:us-east-1:123412341234:owner/123412341234/cis-scan/624b746d-e080-44ae-8c1d-48e653365a38"
            });

            string status = response.Status;
            string url = response.Url;

            #endregion
        }

        public void Inspector2GetCisScanResultDetails()
        {
            #region example-1

            var client = new AmazonInspector2Client();
            var response = client.GetCisScanResultDetails(new GetCisScanResultDetailsRequest 
            {
                AccountId = "123412341234",
                ScanArn = "arn:aws:inspector2:us-east-1:123412341234:owner/123412341234/cis-scan/624b746d-e080-44ae-8c1d-48e653365a38",
                TargetResourceId = "i-12341234"
            });

            List<CisScanResultDetails> scanResultDetails = response.ScanResultDetails;

            #endregion
        }

        public void Inspector2ListCisScanConfigurations()
        {
            #region example-1

            var client = new AmazonInspector2Client();
            var response = client.ListCisScanConfigurations(new ListCisScanConfigurationsRequest 
            {
            });

            List<CisScanConfiguration> scanConfigurations = response.ScanConfigurations;

            #endregion
        }

        public void Inspector2ListCisScanResultsAggregatedByChecks()
        {
            #region example-1

            var client = new AmazonInspector2Client();
            var response = client.ListCisScanResultsAggregatedByChecks(new ListCisScanResultsAggregatedByChecksRequest 
            {
                ScanArn = "arn:aws:inspector2:us-east-1:123412341234:owner/123412341234/cis-scan/624b746d-e080-44ae-8c1d-48e653365a38"
            });

            List<CisCheckAggregation> checkAggregations = response.CheckAggregations;

            #endregion
        }

        public void Inspector2ListCisScanResultsAggregatedByTargetResource()
        {
            #region example-1

            var client = new AmazonInspector2Client();
            var response = client.ListCisScanResultsAggregatedByTargetResource(new ListCisScanResultsAggregatedByTargetResourceRequest 
            {
                ScanArn = "arn:aws:inspector2:us-east-1:123412341234:owner/123412341234/cis-scan/624b746d-e080-44ae-8c1d-48e653365a38"
            });

            List<CisTargetResourceAggregation> targetResourceAggregations = response.TargetResourceAggregations;

            #endregion
        }

        public void Inspector2ListCisScans()
        {
            #region example-1

            var client = new AmazonInspector2Client();
            var response = client.ListCisScans(new ListCisScansRequest 
            {
            });

            List<CisScan> scans = response.Scans;

            #endregion
        }

        public void Inspector2SendCisSessionHealth()
        {
            #region example-1

            var client = new AmazonInspector2Client();
            var response = client.SendCisSessionHealth(new SendCisSessionHealthRequest 
            {
                ScanJobId = "624b746d-e080-44ae-8c1d-48e653365a38",
                SessionToken = "624b746d-e080-44ae-8c1d-48e653365a31"
            });


            #endregion
        }

        public void Inspector2SendCisSessionTelemetry()
        {
            #region example-1

            var client = new AmazonInspector2Client();
            var response = client.SendCisSessionTelemetry(new SendCisSessionTelemetryRequest 
            {
                Messages = new List<CisSessionMessage> {
                    new CisSessionMessage {
                        CisRuleDetails = new MemoryStream(dGVzdCBleGFtcGxlCg==),
                        RuleId = "1.12.1",
                        Status = "FAILED"
                    },
                    new CisSessionMessage {
                        CisRuleDetails = new MemoryStream(dGVzdCBleGFtcGxlCg==dGVzdCBleGFtcGxlCg),
                        RuleId = "1.2.1",
                        Status = "PASSED"
                    }
                },
                ScanJobId = "624b746d-e080-44ae-8c1d-48e653365a38",
                SessionToken = "624b746d-e080-44ae-8c1d-48e653365a31"
            });


            #endregion
        }

        public void Inspector2StartCisSession()
        {
            #region example-1

            var client = new AmazonInspector2Client();
            var response = client.StartCisSession(new StartCisSessionRequest 
            {
                Message = new StartCisSessionMessage { SessionToken = "624b746d-e080-44ae-8c1d-48e653365a31" },
                ScanJobId = "624b746d-e080-44ae-8c1d-48e653365a38"
            });


            #endregion
        }

        public void Inspector2StopCisSession()
        {
            #region example-1

            var client = new AmazonInspector2Client();
            var response = client.StopCisSession(new StopCisSessionRequest 
            {
                Message = new StopCisSessionMessage {
                    BenchmarkProfile = "xccdf_org.cisecurity.benchmarks_profile_Level_1",
                    BenchmarkVersion = "2.0.0",
                    ComputePlatform = new ComputePlatform {
                        Version = "20.04",
                        Product = "ubuntu",
                        Vendor = "canonical"
                    },
                    Progress = new StopCisMessageProgress {
                        ErrorChecks = 1,
                        FailedChecks = 0,
                        InformationalChecks = 1,
                        NotApplicableChecks = 0,
                        NotEvaluatedChecks = 2,
                        SuccessfulChecks = 5,
                        TotalChecks = 10,
                        UnknownChecks = 0
                    },
                    Reason = "Failure Reason",
                    Status = "FAILED"
                },
                ScanJobId = "624b746d-e080-44ae-8c1d-48e653365a38",
                SessionToken = "624b746d-e080-44ae-8c1d-48e653365a31"
            });


            #endregion
        }

        public void Inspector2UpdateCisScanConfiguration()
        {
            #region example-1

            var client = new AmazonInspector2Client();
            var response = client.UpdateCisScanConfiguration(new UpdateCisScanConfigurationRequest 
            {
                ScanConfigurationArn = "arn:aws:inspector2:us-east-1:123412341234:owner/123412341234/cis-configuration/624b746d-e080-44ae-8c1d-48e653365a38",
                ScanName = "sample_new",
                Schedule = new Schedule { Daily = new DailySchedule { StartTime = new Time {
                    TimeOfDay = "12:56",
                    Timezone = "UTC"
                } } },
                SecurityLevel = "LEVEL_2",
                Targets = new UpdateCisTargets {
                    AccountIds = new List<string> {
                        "SELF"
                    },
                    TargetResourceTags = new Dictionary<string, List<string>> {
                        { "key2", new List<string> {
                            "value2"
                        } }
                    }
                }
            });

            string scanConfigurationArn = response.ScanConfigurationArn;

            #endregion
        }

        
        # region ISample Members
        public virtual void Run()
        {

        }
        # endregion

    }
}