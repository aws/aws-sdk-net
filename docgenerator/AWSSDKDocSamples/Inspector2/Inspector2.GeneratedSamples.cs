using System;
using System.Collections.Generic;
using System.IO;
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
            #region BatchGetFindingDetails-1

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
            #region CreateCisScanConfiguration-1

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

        public void Inspector2CreateConnector()
        {
            #region CreateConnector-1

            var client = new AmazonInspector2Client();
            var response = client.CreateConnector(new CreateConnectorRequest
            {
                Description = "Azure subscription scanner",
                Name = "my-azure-connector",
                Provider = "AZURE",
                ProviderDetail = new ProviderDetailCreate { Azure = new AzureProviderDetailCreate {
                    AutoInstallVMScanner = true,
                    AwsConfigConnectorArn = "arn:aws:config:us-east-1:123456789012:connector/azure/a7bc5463-04ce-4b52-901e-f26f7292a4a7/2fbed4bd-5b95-4947-a751-8defc76ecdae",
                    AzureRegions = new List<string> {
                        "eastus"
                    },
                    ScopeConfiguration = new AzureScopeConfigurationInput { VmScanning = new ScopeConfigurationInput {
                        ScopeType = "SUBSCRIPTION",
                        ScopeValues = new List<string> {
                            "552802f5-1492-4184-bbae-7291c9939b16"
                        }
                    } }
                } },
                Tags = new Dictionary<string, string> {
                    { "env", "prod" },
                    { "owner", "security-team" }
                }
            });

            string connectorArn = response.ConnectorArn;

            #endregion
        }

        public void Inspector2DeleteCisScanConfiguration()
        {
            #region DeleteCisScanConfiguration-1

            var client = new AmazonInspector2Client();
            var response = client.DeleteCisScanConfiguration(new DeleteCisScanConfigurationRequest
            {
                ScanConfigurationArn = "arn:aws:inspector2:us-east-1:123412341234:owner/123412341234/cis-configuration/624b746d-e080-44ae-8c1d-48e653365a38"
            });

            string scanConfigurationArn = response.ScanConfigurationArn;

            #endregion
        }

        public void Inspector2DeleteConnector()
        {
            #region DeleteConnector-1

            var client = new AmazonInspector2Client();
            var response = client.DeleteConnector(new DeleteConnectorRequest
            {
                ConnectorArn = "arn:aws:inspector2:us-east-1:123456789012:connector/6ccf8549-b52b-57ca-bf52-a2266da3c53a"
            });


            #endregion
        }

        public void Inspector2GetCisScanReport()
        {
            #region GetCisScanReport-1

            var client = new AmazonInspector2Client();
            var response = client.GetCisScanReport(new GetCisScanReportRequest
            {
                ReportFormat = "PDF",
                ScanArn = "arn:aws:inspector2:us-east-1:123412341234:owner/123412341234/cis-scan/624b746d-e080-44ae-8c1d-48e653365a38"
            });

            CisReportStatus status = response.Status;
            string url = response.Url;

            #endregion
        }

        public void Inspector2GetCisScanResultDetails()
        {
            #region GetCisScanResultDetails-1

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
            #region ListCisScanConfigurations-1

            var client = new AmazonInspector2Client();
            var response = client.ListCisScanConfigurations(new ListCisScanConfigurationsRequest
            {
            });

            List<CisScanConfiguration> scanConfigurations = response.ScanConfigurations;

            #endregion
        }

        public void Inspector2ListCisScanResultsAggregatedByChecks()
        {
            #region ListCisScanResultsAggregatedByChecks-1

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
            #region ListCisScanResultsAggregatedByTargetResource-1

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
            #region ListCisScans-1

            var client = new AmazonInspector2Client();
            var response = client.ListCisScans(new ListCisScansRequest
            {
            });

            List<CisScan> scans = response.Scans;

            #endregion
        }

        public void Inspector2ListConnectors()
        {
            #region ListConnectors-1

            var client = new AmazonInspector2Client();
            var response = client.ListConnectors(new ListConnectorsRequest
            {
                FilterCriteria = new ConnectorFilterCriteria {
                    ConnectorType = new List<ConnectorTypeFilter> {
                        new ConnectorTypeFilter {
                            Comparison = "EQUALS",
                            Value = "CUSTOMER_MANAGED"
                        }
                    },
                    Provider = new List<ProviderFilter> {
                        new ProviderFilter {
                            Comparison = "EQUALS",
                            Value = "AZURE"
                        }
                    }
                },
                MaxResults = 10
            });

            List<Connector> items = response.Items;

            #endregion
        }

        public void Inspector2ListConnectorScanConfigurations()
        {
            #region ListConnectorScanConfigurations-1

            var client = new AmazonInspector2Client();
            var response = client.ListConnectorScanConfigurations(new ListConnectorScanConfigurationsRequest
            {
                AwsConfigConnectorArns = new List<string> {
                    "arn:aws:config:us-east-1:123456789012:connector/azure/a7bc5463-04ce-4b52-901e-f26f7292a4a7/2fbed4bd-5b95-4947-a751-8defc76ecdae"
                },
                MaxResults = 10
            });

            List<ConnectorScanConfigurationItem> scanConfigurations = response.ScanConfigurations;

            #endregion
        }

        public void Inspector2SendCisSessionHealth()
        {
            #region SendCisSessionHealth-1

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
            #region SendCisSessionTelemetry-1

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
            #region StartCisSession-1

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
            #region StopCisSession-1

            var client = new AmazonInspector2Client();
            var response = client.StopCisSession(new StopCisSessionRequest
            {
                Message = new StopCisSessionMessage {
                    BenchmarkProfile = "xccdf_org.cisecurity.benchmarks_profile_Level_1",
                    BenchmarkVersion = "2.0.0",
                    ComputePlatform = new ComputePlatform {
                        Product = "ubuntu",
                        Vendor = "canonical",
                        Version = "20.04"
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
            #region UpdateCisScanConfiguration-1

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

        public void Inspector2UpdateConnector()
        {
            #region UpdateConnector-1

            var client = new AmazonInspector2Client();
            var response = client.UpdateConnector(new UpdateConnectorRequest
            {
                ConnectorArn = "arn:aws:inspector2:us-east-1:123456789012:connector/6ccf8549-b52b-57ca-bf52-a2266da3c53a",
                ProviderDetail = new ProviderDetailUpdate { Azure = new AzureProviderDetailUpdate { AzureRegions = new List<string> {
                    "eastus",
                    "westus"
                } } }
            });

            string connectorArn = response.ConnectorArn;

            #endregion
        }

        public void Inspector2UpdateConnectorScanConfiguration()
        {
            #region UpdateConnectorScanConfiguration-1

            var client = new AmazonInspector2Client();
            var response = client.UpdateConnectorScanConfiguration(new UpdateConnectorScanConfigurationRequest
            {
                AwsConfigConnectorArn = "arn:aws:config:us-east-1:123456789012:connector/azure/a7bc5463-04ce-4b52-901e-f26f7292a4a7/2fbed4bd-5b95-4947-a751-8defc76ecdae",
                ScanConfiguration = new ConnectorScanConfiguration { ContainerImageScanning = new ConnectorContainerImageScanConfiguration {
                    PullDuration = "DAYS_14",
                    PushDuration = "DAYS_30"
                } }
            });


            #endregion
        }

        #region ISample Members
        public virtual void Run()
        {
        }
        #endregion
    }
}
