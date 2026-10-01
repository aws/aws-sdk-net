using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Amazon.SecurityHub;
using Amazon.SecurityHub.Model;

namespace AWSSDKDocSamples.Amazon.SecurityHub.Generated
{
    class SecurityHubSamples : ISample
    {
        public void SecurityHubAcceptAdministratorInvitation()
        {
            #region AcceptAdministratorInvitation-1

            var client = new AmazonSecurityHubClient();
            var response = client.AcceptAdministratorInvitation(new AcceptAdministratorInvitationRequest
            {
                AdministratorId = "123456789012",
                InvitationId = "7ab938c5d52d7904ad09f9e7c20cc4eb"
            });


            #endregion
        }

        public void SecurityHubBatchDeleteAutomationRules()
        {
            #region BatchDeleteAutomationRules-1

            var client = new AmazonSecurityHubClient();
            var response = client.BatchDeleteAutomationRules(new BatchDeleteAutomationRulesRequest
            {
                AutomationRulesArns = new List<string> {
                    "arn:aws:securityhub:us-east-1:123456789012:automation-rule/a1b2c3d4-5678-90ab-cdef-EXAMPLE11111",
                    "arn:aws:securityhub:us-east-1:123456789012:automation-rule/a1b2c3d4-5678-90ab-cdef-EXAMPLE22222"
                }
            });

            List<string> processedAutomationRules = response.ProcessedAutomationRules;
            List<UnprocessedAutomationRule> unprocessedAutomationRules = response.UnprocessedAutomationRules;

            #endregion
        }

        public void SecurityHubBatchDisableStandards()
        {
            #region BatchDisableStandards-1

            var client = new AmazonSecurityHubClient();
            var response = client.BatchDisableStandards(new BatchDisableStandardsRequest
            {
                StandardsSubscriptionArns = new List<string> {
                    "arn:aws:securityhub:us-west-1:123456789012:subscription/pci-dss/v/3.2.1"
                }
            });

            List<StandardsSubscription> standardsSubscriptions = response.StandardsSubscriptions;

            #endregion
        }

        public void SecurityHubBatchEnableStandards()
        {
            #region BatchEnableStandards-1

            var client = new AmazonSecurityHubClient();
            var response = client.BatchEnableStandards(new BatchEnableStandardsRequest
            {
                StandardsSubscriptionRequests = new List<StandardsSubscriptionRequest> {
                    new StandardsSubscriptionRequest { StandardsArn = "arn:aws:securityhub:us-west-1::standards/pci-dss/v/3.2.1" }
                }
            });

            List<StandardsSubscription> standardsSubscriptions = response.StandardsSubscriptions;

            #endregion
        }

        public void SecurityHubBatchGetAutomationRules()
        {
            #region BatchGetAutomationRules-1

            var client = new AmazonSecurityHubClient();
            var response = client.BatchGetAutomationRules(new BatchGetAutomationRulesRequest
            {
                AutomationRulesArns = new List<string> {
                    "arn:aws:securityhub:us-east-1:123456789012:automation-rule/a1b2c3d4-5678-90ab-cdef-EXAMPLE11111",
                    "arn:aws:securityhub:us-east-1:123456789012:automation-rule/a1b2c3d4-5678-90ab-cdef-EXAMPLE22222"
                }
            });

            List<AutomationRulesConfig> rules = response.Rules;

            #endregion
        }

        public void SecurityHubBatchGetConfigurationPolicyAssociations()
        {
            #region BatchGetConfigurationPolicyAssociations-1

            var client = new AmazonSecurityHubClient();
            var response = client.BatchGetConfigurationPolicyAssociations(new BatchGetConfigurationPolicyAssociationsRequest
            {
                ConfigurationPolicyAssociationIdentifiers = new List<ConfigurationPolicyAssociation> {
                    new ConfigurationPolicyAssociation { Target = new Target { AccountId = "111122223333" } },
                    new ConfigurationPolicyAssociation { Target = new Target { RootId = "r-f6g7h8i9j0example" } }
                }
            });

            List<ConfigurationPolicyAssociationSummary> configurationPolicyAssociations = response.ConfigurationPolicyAssociations;
            List<UnprocessedConfigurationPolicyAssociation> unprocessedConfigurationPolicyAssociations = response.UnprocessedConfigurationPolicyAssociations;

            #endregion
        }

        public void SecurityHubBatchGetSecurityControls()
        {
            #region BatchGetSecurityControls-1

            var client = new AmazonSecurityHubClient();
            var response = client.BatchGetSecurityControls(new BatchGetSecurityControlsRequest
            {
                SecurityControlIds = new List<string> {
                    "ACM.1",
                    "APIGateway.1"
                }
            });

            List<SecurityControl> securityControls = response.SecurityControls;

            #endregion
        }

        public void SecurityHubBatchImportFindings()
        {
            #region BatchImportFindings-1

            var client = new AmazonSecurityHubClient();
            var response = client.BatchImportFindings(new BatchImportFindingsRequest
            {
                Findings = new List<AwsSecurityFinding> {
                    new AwsSecurityFinding {
                        AwsAccountId = "123456789012",
                        CreatedAt = "2020-05-27T17:05:54.832Z",
                        Description = "Vulnerability in a CloudTrail trail",
                        FindingProviderFields = new FindingProviderFields {
                            Severity = new FindingProviderSeverity {
                                Label = "LOW",
                                Original = "10"
                            },
                            Types = new List<string> {
                                "Software and Configuration Checks/Vulnerabilities/CVE"
                            }
                        },
                        GeneratorId = "TestGeneratorId",
                        Id = "Id1",
                        ProductArn = "arn:aws:securityhub:us-west-1:123456789012:product/123456789012/default",
                        Resources = new List<Resource> {
                            new Resource {
                                Id = "arn:aws:cloudtrail:us-west-1:123456789012:trail/TrailName",
                                Partition = "aws",
                                Region = "us-west-1",
                                Type = "AwsCloudTrailTrail"
                            }
                        },
                        SchemaVersion = "2018-10-08",
                        Title = "CloudTrail trail vulnerability",
                        UpdatedAt = "2020-06-02T16:05:54.832Z"
                    }
                }
            });

            int? failedCount = response.FailedCount;
            List<ImportFindingsError> failedFindings = response.FailedFindings;
            int? successCount = response.SuccessCount;

            #endregion
        }

        public void SecurityHubBatchUpdateAutomationRules()
        {
            #region BatchUpdateAutomationRules-1

            var client = new AmazonSecurityHubClient();
            var response = client.BatchUpdateAutomationRules(new BatchUpdateAutomationRulesRequest
            {
                UpdateAutomationRulesRequestItems = new List<UpdateAutomationRulesRequestItem> {
                    new UpdateAutomationRulesRequestItem {
                        RuleArn = "arn:aws:securityhub:us-east-1:123456789012:automation-rule/a1b2c3d4-5678-90ab-cdef-EXAMPLE11111",
                        RuleOrder = 15,
                        RuleStatus = "ENABLED"
                    },
                    new UpdateAutomationRulesRequestItem {
                        RuleArn = "arn:aws:securityhub:us-east-1:123456789012:automation-rule/a1b2c3d4-5678-90ab-cdef-EXAMPLE22222",
                        RuleStatus = "DISABLED"
                    }
                }
            });

            List<string> processedAutomationRules = response.ProcessedAutomationRules;

            #endregion
        }

        public void SecurityHubBatchUpdateFindings()
        {
            #region BatchUpdateFindings-1

            var client = new AmazonSecurityHubClient();
            var response = client.BatchUpdateFindings(new BatchUpdateFindingsRequest
            {
                Confidence = 80,
                Criticality = 80,
                FindingIdentifiers = new List<AwsSecurityFindingIdentifier> {
                    new AwsSecurityFindingIdentifier {
                        Id = "arn:aws:securityhub:us-west-1:123456789012:subscription/pci-dss/v/3.2.1/PCI.Lambda.2/finding/a1b2c3d4-5678-90ab-cdef-EXAMPLE11111",
                        ProductArn = "arn:aws:securityhub:us-west-1::product/aws/securityhub"
                    },
                    new AwsSecurityFindingIdentifier {
                        Id = "arn:aws:securityhub:us-west-1:123456789012:subscription/pci-dss/v/3.2.1/PCI.Lambda.2/finding/a1b2c3d4-5678-90ab-cdef-EXAMPLE22222",
                        ProductArn = "arn:aws:securityhub:us-west-1::product/aws/securityhub"
                    }
                },
                Note = new NoteUpdate {
                    Text = "Known issue that is not a risk.",
                    UpdatedBy = "user1"
                },
                RelatedFindings = new List<RelatedFinding> {
                    new RelatedFinding {
                        Id = "arn:aws:securityhub:us-west-1:123456789012:subscription/pci-dss/v/3.2.1/PCI.Lambda.2/finding/a1b2c3d4-5678-90ab-cdef-EXAMPLE33333",
                        ProductArn = "arn:aws:securityhub:us-west-1::product/aws/securityhub"
                    }
                },
                Severity = new SeverityUpdate { Label = "LOW" },
                Types = new List<string> {
                    "Software and Configuration Checks/Vulnerabilities/CVE"
                },
                UserDefinedFields = new Dictionary<string, string> {
                    { "reviewedByCio", "true" }
                },
                VerificationState = "TRUE_POSITIVE",
                Workflow = new WorkflowUpdate { Status = "RESOLVED" }
            });

            List<AwsSecurityFindingIdentifier> processedFindings = response.ProcessedFindings;
            List<BatchUpdateFindingsUnprocessedFinding> unprocessedFindings = response.UnprocessedFindings;

            #endregion
        }

        public void SecurityHubBatchUpdateStandardsControlAssociations()
        {
            #region BatchUpdateStandardsControlAssociations-1

            var client = new AmazonSecurityHubClient();
            var response = client.BatchUpdateStandardsControlAssociations(new BatchUpdateStandardsControlAssociationsRequest
            {
                StandardsControlAssociationUpdates = new List<StandardsControlAssociationUpdate> {
                    new StandardsControlAssociationUpdate {
                        AssociationStatus = "DISABLED",
                        SecurityControlId = "CloudTrail.1",
                        StandardsArn = "arn:aws:securityhub:::ruleset/sample-standard/v/1.1.0",
                        UpdatedReason = "Not relevant to environment"
                    },
                    new StandardsControlAssociationUpdate {
                        AssociationStatus = "DISABLED",
                        SecurityControlId = "CloudWatch.12",
                        StandardsArn = "arn:aws:securityhub:::ruleset/cis-aws-foundations-benchmark/v/1.2.0",
                        UpdatedReason = "Not relevant to environment"
                    }
                }
            });

            List<UnprocessedStandardsControlAssociationUpdate> unprocessedAssociationUpdates = response.UnprocessedAssociationUpdates;

            #endregion
        }

        public void SecurityHubCreateActionTarget()
        {
            #region CreateActionTarget-1

            var client = new AmazonSecurityHubClient();
            var response = client.CreateActionTarget(new CreateActionTargetRequest
            {
                Description = "Action to send the finding for remediation tracking",
                Id = "Remediation",
                Name = "Send to remediation"
            });

            string actionTargetArn = response.ActionTargetArn;

            #endregion
        }

        public void SecurityHubCreateAutomationRule()
        {
            #region CreateAutomationRule-1

            var client = new AmazonSecurityHubClient();
            var response = client.CreateAutomationRule(new CreateAutomationRuleRequest
            {
                Actions = new List<AutomationRulesAction> {
                    new AutomationRulesAction {
                        FindingFieldsUpdate = new AutomationRulesFindingFieldsUpdate {
                            Note = new NoteUpdate {
                                Text = "This is a critical S3 bucket, please look into this ASAP",
                                UpdatedBy = "test-user"
                            },
                            Severity = new SeverityUpdate { Label = "CRITICAL" }
                        },
                        Type = "FINDING_FIELDS_UPDATE"
                    }
                },
                Criteria = new AutomationRulesFindingFilters {
                    ComplianceStatus = new List<StringFilter> {
                        new StringFilter {
                            Comparison = "EQUALS",
                            Value = "FAILED"
                        }
                    },
                    ProductName = new List<StringFilter> {
                        new StringFilter {
                            Comparison = "EQUALS",
                            Value = "Security Hub"
                        }
                    },
                    RecordState = new List<StringFilter> {
                        new StringFilter {
                            Comparison = "EQUALS",
                            Value = "ACTIVE"
                        }
                    },
                    ResourceId = new List<StringFilter> {
                        new StringFilter {
                            Comparison = "EQUALS",
                            Value = "arn:aws:s3:::examplebucket/developers/design_info.doc"
                        }
                    },
                    WorkflowStatus = new List<StringFilter> {
                        new StringFilter {
                            Comparison = "EQUALS",
                            Value = "NEW"
                        }
                    }
                },
                Description = "Elevate finding severity to Critical for important resources",
                IsTerminal = false,
                RuleName = "Elevate severity for important resources",
                RuleOrder = 1,
                RuleStatus = "ENABLED",
                Tags = new Dictionary<string, string> {
                    { "important-resources-rule", "s3-bucket" }
                }
            });

            string ruleArn = response.RuleArn;

            #endregion
        }

        public void SecurityHubCreateConfigurationPolicy()
        {
            #region CreateConfigurationPolicy-1

            var client = new AmazonSecurityHubClient();
            var response = client.CreateConfigurationPolicy(new CreateConfigurationPolicyRequest
            {
                ConfigurationPolicy = new Policy { SecurityHub = new SecurityHubPolicy {
                    EnabledStandardIdentifiers = new List<string> {
                        "arn:aws:securityhub:us-east-1::standards/aws-foundational-security-best-practices/v/1.0.0",
                        "arn:aws:securityhub:::ruleset/cis-aws-foundations-benchmark/v/1.2.0"
                    },
                    SecurityControlsConfiguration = new SecurityControlsConfiguration {
                        DisabledSecurityControlIdentifiers = new List<string> {
                            "CloudWatch.1"
                        },
                        SecurityControlCustomParameters = new List<SecurityControlCustomParameter> {
                            new SecurityControlCustomParameter {
                                Parameters = new Dictionary<string, ParameterConfiguration> {
                                    { "daysToExpiration", new ParameterConfiguration {
                                        Value = new ParameterValue { Integer = 14 },
                                        ValueType = "CUSTOM"
                                    } }
                                },
                                SecurityControlId = "ACM.1"
                            }
                        }
                    },
                    ServiceEnabled = true
                } },
                Description = "Configuration policy for testing FSBP and CIS",
                Name = "TestConfigurationPolicy"
            });

            string arn = response.Arn;
            Policy configurationPolicy = response.ConfigurationPolicy;
            DateTime? createdAt = response.CreatedAt;
            string description = response.Description;
            string id = response.Id;
            string name = response.Name;
            DateTime? updatedAt = response.UpdatedAt;

            #endregion
        }

        public void SecurityHubCreateConnector()
        {
            #region CreateConnector-1

            var client = new AmazonSecurityHubClient();
            var response = client.CreateConnector(new CreateConnectorRequest
            {
                Description = "Connector for Azure tenant monitoring",
                Name = "MyAzureConnector",
                Provider = new CspmProviderConfiguration { Azure = new AzureProviderConfiguration {
                    AWSConfigConnectorArn = "arn:aws:config:us-east-1:123456789012:connector/azure-connector-1234",
                    AzureRegions = new List<string> {
                        "eastus",
                        "westus2"
                    },
                    ScopeConfiguration = new AzureScopeConfiguration { ScopeType = "TENANT" }
                } }
            });

            string connectorArn = response.ConnectorArn;
            string connectorId = response.ConnectorId;
            CspmEnablementStatus enablementStatus = response.EnablementStatus;

            #endregion
        }

        public void SecurityHubCreateFindingAggregator()
        {
            #region CreateFindingAggregator-1

            var client = new AmazonSecurityHubClient();
            var response = client.CreateFindingAggregator(new CreateFindingAggregatorRequest
            {
                RegionLinkingMode = "SPECIFIED_REGIONS",
                Regions = new List<string> {
                    "us-west-1",
                    "us-west-2"
                }
            });

            string findingAggregationRegion = response.FindingAggregationRegion;
            string findingAggregatorArn = response.FindingAggregatorArn;
            string regionLinkingMode = response.RegionLinkingMode;
            List<string> regions = response.Regions;

            #endregion
        }

        public void SecurityHubCreateInsight()
        {
            #region CreateInsight-1

            var client = new AmazonSecurityHubClient();
            var response = client.CreateInsight(new CreateInsightRequest
            {
                Filters = new AwsSecurityFindingFilters {
                    ResourceType = new List<StringFilter> {
                        new StringFilter {
                            Comparison = "EQUALS",
                            Value = "AwsIamRole"
                        }
                    },
                    SeverityLabel = new List<StringFilter> {
                        new StringFilter {
                            Comparison = "EQUALS",
                            Value = "CRITICAL"
                        }
                    }
                },
                GroupByAttribute = "ResourceId",
                Name = "Critical role findings"
            });

            string insightArn = response.InsightArn;

            #endregion
        }

        public void SecurityHubCreateMembers()
        {
            #region CreateMembers-1

            var client = new AmazonSecurityHubClient();
            var response = client.CreateMembers(new CreateMembersRequest
            {
                AccountDetails = new List<AccountDetails> {
                    new AccountDetails { AccountId = "123456789012" },
                    new AccountDetails { AccountId = "111122223333" }
                }
            });

            List<Result> unprocessedAccounts = response.UnprocessedAccounts;

            #endregion
        }

        public void SecurityHubDeclineInvitations()
        {
            #region DeclineInvitations-1

            var client = new AmazonSecurityHubClient();
            var response = client.DeclineInvitations(new DeclineInvitationsRequest
            {
                AccountIds = new List<string> {
                    "123456789012",
                    "111122223333"
                }
            });

            List<Result> unprocessedAccounts = response.UnprocessedAccounts;

            #endregion
        }

        public void SecurityHubDeleteActionTarget()
        {
            #region DeleteActionTarget-1

            var client = new AmazonSecurityHubClient();
            var response = client.DeleteActionTarget(new DeleteActionTargetRequest
            {
                ActionTargetArn = "arn:aws:securityhub:us-west-1:123456789012:action/custom/Remediation"
            });

            string actionTargetArn = response.ActionTargetArn;

            #endregion
        }

        public void SecurityHubDeleteConfigurationPolicy()
        {
            #region DeleteConfigurationPolicy-1

            var client = new AmazonSecurityHubClient();
            var response = client.DeleteConfigurationPolicy(new DeleteConfigurationPolicyRequest
            {
                Identifier = "arn:aws:securityhub:us-east-1:123456789012:configuration-policy/a1b2c3d4-5678-90ab-cdef-EXAMPLE11111"
            });


            #endregion
        }

        public void SecurityHubDeleteConnector()
        {
            #region DeleteConnector-1

            var client = new AmazonSecurityHubClient();
            var response = client.DeleteConnector(new DeleteConnectorRequest
            {
                ConnectorId = "cspm-a1b2c3d4-5678-90ab-cdef-EXAMPLE11111"
            });

            CspmEnablementStatus enablementStatus = response.EnablementStatus;

            #endregion
        }

        public void SecurityHubDeleteFindingAggregator()
        {
            #region DeleteFindingAggregator-1

            var client = new AmazonSecurityHubClient();
            var response = client.DeleteFindingAggregator(new DeleteFindingAggregatorRequest
            {
                FindingAggregatorArn = "arn:aws:securityhub:us-east-1:123456789012:finding-aggregator/a1b2c3d4-5678-90ab-cdef-EXAMPLE11111"
            });


            #endregion
        }

        public void SecurityHubDeleteInsight()
        {
            #region DeleteInsight-1

            var client = new AmazonSecurityHubClient();
            var response = client.DeleteInsight(new DeleteInsightRequest
            {
                InsightArn = "arn:aws:securityhub:us-west-1:123456789012:insight/123456789012/custom/a1b2c3d4-5678-90ab-cdef-EXAMPLE11111"
            });

            string insightArn = response.InsightArn;

            #endregion
        }

        public void SecurityHubDeleteInvitations()
        {
            #region DeleteInvitations-1

            var client = new AmazonSecurityHubClient();
            var response = client.DeleteInvitations(new DeleteInvitationsRequest
            {
                AccountIds = new List<string> {
                    "123456789012"
                }
            });

            List<Result> unprocessedAccounts = response.UnprocessedAccounts;

            #endregion
        }

        public void SecurityHubDeleteMembers()
        {
            #region DeleteMembers-1

            var client = new AmazonSecurityHubClient();
            var response = client.DeleteMembers(new DeleteMembersRequest
            {
                AccountIds = new List<string> {
                    "123456789111",
                    "123456789222"
                }
            });

            List<Result> unprocessedAccounts = response.UnprocessedAccounts;

            #endregion
        }

        public void SecurityHubDescribeActionTargets()
        {
            #region DescribeActionTargets-1

            var client = new AmazonSecurityHubClient();
            var response = client.DescribeActionTargets(new DescribeActionTargetsRequest
            {
                ActionTargetArns = new List<string> {
                    "arn:aws:securityhub:us-west-1:123456789012:action/custom/Remediation"
                }
            });

            List<ActionTarget> actionTargets = response.ActionTargets;

            #endregion
        }

        public void SecurityHubDescribeHub()
        {
            #region DescribeHub-1

            var client = new AmazonSecurityHubClient();
            var response = client.DescribeHub(new DescribeHubRequest
            {
                HubArn = "arn:aws:securityhub:us-west-1:123456789012:hub/default"
            });

            bool? autoEnableControls = response.AutoEnableControls;
            ControlFindingGenerator controlFindingGenerator = response.ControlFindingGenerator;
            string hubArn = response.HubArn;
            string subscribedAt = response.SubscribedAt;

            #endregion
        }

        public void SecurityHubDescribeOrganizationConfiguration()
        {
            #region DescribeOrganizationConfiguration-1

            var client = new AmazonSecurityHubClient();
            var response = client.DescribeOrganizationConfiguration(new DescribeOrganizationConfigurationRequest
            {
            });

            bool? autoEnable = response.AutoEnable;
            AutoEnableStandards autoEnableStandards = response.AutoEnableStandards;
            bool? memberAccountLimitReached = response.MemberAccountLimitReached;
            OrganizationConfiguration organizationConfiguration = response.OrganizationConfiguration;

            #endregion
        }

        public void SecurityHubDescribeProducts()
        {
            #region DescribeProducts-1

            var client = new AmazonSecurityHubClient();
            var response = client.DescribeProducts(new DescribeProductsRequest
            {
                MaxResults = 1,
                NextToken = "NULL",
                ProductArn = "arn:aws:securityhub:us-east-1:517716713836:product/crowdstrike/crowdstrike-falcon"
            });

            string nextToken = response.NextToken;
            List<Product> products = response.Products;

            #endregion
        }

        public void SecurityHubDescribeStandards()
        {
            #region DescribeStandards-1

            var client = new AmazonSecurityHubClient();
            var response = client.DescribeStandards(new DescribeStandardsRequest
            {
                Providers = new List<string> {
                    "Azure"
                }
            });

            List<Standard> standards = response.Standards;

            #endregion
        }

        public void SecurityHubDescribeStandards()
        {
            #region DescribeStandards-2

            var client = new AmazonSecurityHubClient();
            var response = client.DescribeStandards(new DescribeStandardsRequest
            {
            });

            List<Standard> standards = response.Standards;

            #endregion
        }

        public void SecurityHubDisableImportFindingsForProduct()
        {
            #region DisableImportFindingsForProduct-1

            var client = new AmazonSecurityHubClient();
            var response = client.DisableImportFindingsForProduct(new DisableImportFindingsForProductRequest
            {
                ProductSubscriptionArn = "arn:aws:securityhub:us-east-1:517716713836:product/crowdstrike/crowdstrike-falcon"
            });


            #endregion
        }

        public void SecurityHubDisableOrganizationAdminAccount()
        {
            #region DisableOrganizationAdminAccount-1

            var client = new AmazonSecurityHubClient();
            var response = client.DisableOrganizationAdminAccount(new DisableOrganizationAdminAccountRequest
            {
                AdminAccountId = "123456789012"
            });


            #endregion
        }

        public void SecurityHubDisableSecurityHub()
        {
            #region DisableSecurityHub-1

            var client = new AmazonSecurityHubClient();
            var response = client.DisableSecurityHub(new DisableSecurityHubRequest
            {
            });


            #endregion
        }

        public void SecurityHubDisassociateFromAdministratorAccount()
        {
            #region DisassociateFromAdministratorAccount-1

            var client = new AmazonSecurityHubClient();
            var response = client.DisassociateFromAdministratorAccount(new DisassociateFromAdministratorAccountRequest
            {
            });


            #endregion
        }

        public void SecurityHubDisassociateMembers()
        {
            #region DisassociateMembers-1

            var client = new AmazonSecurityHubClient();
            var response = client.DisassociateMembers(new DisassociateMembersRequest
            {
                AccountIds = new List<string> {
                    "123456789012",
                    "111122223333"
                }
            });


            #endregion
        }

        public void SecurityHubEnableImportFindingsForProduct()
        {
            #region EnableImportFindingsForProduct-1

            var client = new AmazonSecurityHubClient();
            var response = client.EnableImportFindingsForProduct(new EnableImportFindingsForProductRequest
            {
                ProductArn = "arn:aws:securityhub:us-east-1:517716713836:product/crowdstrike/crowdstrike-falcon"
            });

            string productSubscriptionArn = response.ProductSubscriptionArn;

            #endregion
        }

        public void SecurityHubEnableOrganizationAdminAccount()
        {
            #region EnableOrganizationAdminAccount-1

            var client = new AmazonSecurityHubClient();
            var response = client.EnableOrganizationAdminAccount(new EnableOrganizationAdminAccountRequest
            {
                AdminAccountId = "123456789012"
            });


            #endregion
        }

        public void SecurityHubEnableSecurityHub()
        {
            #region EnableSecurityHub-1

            var client = new AmazonSecurityHubClient();
            var response = client.EnableSecurityHub(new EnableSecurityHubRequest
            {
                EnableDefaultStandards = true,
                Tags = new Dictionary<string, string> {
                    { "Department", "Security" }
                }
            });


            #endregion
        }

        public void SecurityHubGetConfigurationPolicy()
        {
            #region GetConfigurationPolicy-1

            var client = new AmazonSecurityHubClient();
            var response = client.GetConfigurationPolicy(new GetConfigurationPolicyRequest
            {
                Identifier = "arn:aws:securityhub:us-east-1:123456789012:configuration-policy/a1b2c3d4-5678-90ab-cdef-EXAMPLE11111"
            });

            string arn = response.Arn;
            Policy configurationPolicy = response.ConfigurationPolicy;
            DateTime? createdAt = response.CreatedAt;
            string description = response.Description;
            string id = response.Id;
            string name = response.Name;
            DateTime? updatedAt = response.UpdatedAt;

            #endregion
        }

        public void SecurityHubGetConfigurationPolicyAssociation()
        {
            #region GetConfigurationPolicyAssociation-1

            var client = new AmazonSecurityHubClient();
            var response = client.GetConfigurationPolicyAssociation(new GetConfigurationPolicyAssociationRequest
            {
                Target = new Target { AccountId = "111122223333" }
            });

            ConfigurationPolicyAssociationStatus associationStatus = response.AssociationStatus;
            string associationStatusMessage = response.AssociationStatusMessage;
            AssociationType associationType = response.AssociationType;
            string configurationPolicyId = response.ConfigurationPolicyId;
            string targetId = response.TargetId;
            TargetType targetType = response.TargetType;
            DateTime? updatedAt = response.UpdatedAt;

            #endregion
        }

        public void SecurityHubGetConnector()
        {
            #region GetConnector-1

            var client = new AmazonSecurityHubClient();
            var response = client.GetConnector(new GetConnectorRequest
            {
                ConnectorId = "cspm-a1b2c3d4-5678-90ab-cdef-EXAMPLE11111"
            });

            string connectorArn = response.ConnectorArn;
            string connectorId = response.ConnectorId;
            DateTime? createdAt = response.CreatedAt;
            string createdBy = response.CreatedBy;
            string description = response.Description;
            CspmHealthCheck health = response.Health;
            DateTime? lastUpdatedAt = response.LastUpdatedAt;
            string name = response.Name;
            CspmProviderDetail providerDetail = response.ProviderDetail;

            #endregion
        }

        public void SecurityHubGetEnabledStandards()
        {
            #region GetEnabledStandards-1

            var client = new AmazonSecurityHubClient();
            var response = client.GetEnabledStandards(new GetEnabledStandardsRequest
            {
                StandardsSubscriptionArns = new List<string> {
                    "arn:aws:securityhub:us-west-1:123456789012:subscription/pci-dss/v/3.2.1"
                }
            });

            List<StandardsSubscription> standardsSubscriptions = response.StandardsSubscriptions;

            #endregion
        }

        public void SecurityHubGetFindingAggregator()
        {
            #region GetFindingAggregator-1

            var client = new AmazonSecurityHubClient();
            var response = client.GetFindingAggregator(new GetFindingAggregatorRequest
            {
                FindingAggregatorArn = "arn:aws:securityhub:us-east-1:123456789012:finding-aggregator/a1b2c3d4-5678-90ab-cdef-EXAMPLE11111"
            });

            string findingAggregationRegion = response.FindingAggregationRegion;
            string findingAggregatorArn = response.FindingAggregatorArn;
            string regionLinkingMode = response.RegionLinkingMode;
            List<string> regions = response.Regions;

            #endregion
        }

        public void SecurityHubGetFindings()
        {
            #region GetFindings-1

            var client = new AmazonSecurityHubClient();
            var response = client.GetFindings(new GetFindingsRequest
            {
                Filters = new AwsSecurityFindingFilters { AwsAccountId = new List<StringFilter> {
                    new StringFilter {
                        Comparison = "PREFIX",
                        Value = "123456789012"
                    }
                } },
                MaxResults = 1
            });

            List<AwsSecurityFinding> findings = response.Findings;

            #endregion
        }

        public void SecurityHubGetInsightResults()
        {
            #region GetInsightResults-1

            var client = new AmazonSecurityHubClient();
            var response = client.GetInsightResults(new GetInsightResultsRequest
            {
                InsightArn = "arn:aws:securityhub:us-west-1:123456789012:insight/123456789012/custom/a1b2c3d4-5678-90ab-cdef-EXAMPLE11111"
            });

            InsightResults insightResults = response.InsightResults;

            #endregion
        }

        public void SecurityHubGetInsights()
        {
            #region GetInsights-1

            var client = new AmazonSecurityHubClient();
            var response = client.GetInsights(new GetInsightsRequest
            {
                InsightArns = new List<string> {
                    "arn:aws:securityhub:us-west-1:123456789012:insight/123456789012/custom/a1b2c3d4-5678-90ab-cdef-EXAMPLE11111"
                }
            });

            List<Insight> insights = response.Insights;

            #endregion
        }

        public void SecurityHubGetInvitationsCount()
        {
            #region GetInvitationsCount-1

            var client = new AmazonSecurityHubClient();
            var response = client.GetInvitationsCount(new GetInvitationsCountRequest
            {
            });

            int? invitationsCount = response.InvitationsCount;

            #endregion
        }

        public void SecurityHubGetSecurityControlDefinition()
        {
            #region GetSecurityControlDefinition-1

            var client = new AmazonSecurityHubClient();
            var response = client.GetSecurityControlDefinition(new GetSecurityControlDefinitionRequest
            {
                SecurityControlId = "EC2.4"
            });

            SecurityControlDefinition securityControlDefinition = response.SecurityControlDefinition;

            #endregion
        }

        public void SecurityHubInviteMembers()
        {
            #region InviteMembers-1

            var client = new AmazonSecurityHubClient();
            var response = client.InviteMembers(new InviteMembersRequest
            {
                AccountIds = new List<string> {
                    "111122223333",
                    "444455556666"
                }
            });

            List<Result> unprocessedAccounts = response.UnprocessedAccounts;

            #endregion
        }

        public void SecurityHubListAutomationRules()
        {
            #region ListAutomationRules-1

            var client = new AmazonSecurityHubClient();
            var response = client.ListAutomationRules(new ListAutomationRulesRequest
            {
                MaxResults = 2,
                NextToken = "example-token"
            });

            List<AutomationRulesMetadata> automationRulesMetadata = response.AutomationRulesMetadata;
            string nextToken = response.NextToken;

            #endregion
        }

        public void SecurityHubListConfigurationPolicies()
        {
            #region ListConfigurationPolicies-1

            var client = new AmazonSecurityHubClient();
            var response = client.ListConfigurationPolicies(new ListConfigurationPoliciesRequest
            {
                MaxResults = 1,
                NextToken = "U1FsdGVkX19nBV2zoh+Gou9NgnulLJHWpn9xnG4hqSOhvw3o2JqjI86QDxdf"
            });

            List<ConfigurationPolicySummary> configurationPolicySummaries = response.ConfigurationPolicySummaries;
            string nextToken = response.NextToken;

            #endregion
        }

        public void SecurityHubListConfigurationPolicyAssociations()
        {
            #region ListConfigurationPolicyAssociations-1

            var client = new AmazonSecurityHubClient();
            var response = client.ListConfigurationPolicyAssociations(new ListConfigurationPolicyAssociationsRequest
            {
                Filters = new AssociationFilters { AssociationType = "APPLIED" },
                MaxResults = 1,
                NextToken = "U1FsdGVkX19nBV2zoh+Gou9NgnulLJHWpn9xnG4hqSOhvw3o2JqjI86QDxdf"
            });

            List<ConfigurationPolicyAssociationSummary> configurationPolicyAssociationSummaries = response.ConfigurationPolicyAssociationSummaries;
            string nextToken = response.NextToken;

            #endregion
        }

        public void SecurityHubListConnectors()
        {
            #region ListConnectors-1

            var client = new AmazonSecurityHubClient();
            var response = client.ListConnectors(new ListConnectorsRequest
            {
                MaxResults = 10
            });

            List<CspmConnectorSummary> connectors = response.Connectors;

            #endregion
        }

        public void SecurityHubListEnabledProductsForImport()
        {
            #region ListEnabledProductsForImport-1

            var client = new AmazonSecurityHubClient();
            var response = client.ListEnabledProductsForImport(new ListEnabledProductsForImportRequest
            {
            });

            List<string> productSubscriptions = response.ProductSubscriptions;

            #endregion
        }

        public void SecurityHubListFindingAggregators()
        {
            #region ListFindingAggregators-1

            var client = new AmazonSecurityHubClient();
            var response = client.ListFindingAggregators(new ListFindingAggregatorsRequest
            {
            });

            List<FindingAggregator> findingAggregators = response.FindingAggregators;

            #endregion
        }

        public void SecurityHubListOrganizationAdminAccounts()
        {
            #region ListOrganizationAdminAccounts-1

            var client = new AmazonSecurityHubClient();
            var response = client.ListOrganizationAdminAccounts(new ListOrganizationAdminAccountsRequest
            {
            });

            List<AdminAccount> adminAccounts = response.AdminAccounts;

            #endregion
        }

        public void SecurityHubListSecurityControlDefinitions()
        {
            #region ListSecurityControlDefinitions-1

            var client = new AmazonSecurityHubClient();
            var response = client.ListSecurityControlDefinitions(new ListSecurityControlDefinitionsRequest
            {
                MaxResults = 3,
                Providers = new List<string> {
                    "Azure"
                }
            });

            string nextToken = response.NextToken;
            List<SecurityControlDefinition> securityControlDefinitions = response.SecurityControlDefinitions;

            #endregion
        }

        public void SecurityHubListSecurityControlDefinitions()
        {
            #region ListSecurityControlDefinitions-2

            var client = new AmazonSecurityHubClient();
            var response = client.ListSecurityControlDefinitions(new ListSecurityControlDefinitionsRequest
            {
                MaxResults = 3,
                NextToken = "NULL",
                StandardsArn = "arn:aws:securityhub:::standards/aws-foundational-security-best-practices/v/1.0.0"
            });

            string nextToken = response.NextToken;
            List<SecurityControlDefinition> securityControlDefinitions = response.SecurityControlDefinitions;

            #endregion
        }

        public void SecurityHubListTagsForResource()
        {
            #region ListTagsForResource-1

            var client = new AmazonSecurityHubClient();
            var response = client.ListTagsForResource(new ListTagsForResourceRequest
            {
                ResourceArn = "arn:aws:securityhub:us-west-1:123456789012:hub/default"
            });

            Dictionary<string, string> tags = response.Tags;

            #endregion
        }

        public void SecurityHubStartConfigurationPolicyAssociation()
        {
            #region StartConfigurationPolicyAssociation-1

            var client = new AmazonSecurityHubClient();
            var response = client.StartConfigurationPolicyAssociation(new StartConfigurationPolicyAssociationRequest
            {
                ConfigurationPolicyIdentifier = "arn:aws:securityhub:us-east-1:123456789012:configuration-policy/a1b2c3d4-5678-90ab-cdef-EXAMPLE11111",
                Target = new Target { AccountId = "111122223333" }
            });

            ConfigurationPolicyAssociationStatus associationStatus = response.AssociationStatus;
            string associationStatusMessage = response.AssociationStatusMessage;
            AssociationType associationType = response.AssociationType;
            string configurationPolicyId = response.ConfigurationPolicyId;
            string targetId = response.TargetId;
            TargetType targetType = response.TargetType;
            DateTime? updatedAt = response.UpdatedAt;

            #endregion
        }

        public void SecurityHubStartConfigurationPolicyDisassociation()
        {
            #region StartConfigurationPolicyDisassociation-1

            var client = new AmazonSecurityHubClient();
            var response = client.StartConfigurationPolicyDisassociation(new StartConfigurationPolicyDisassociationRequest
            {
                ConfigurationPolicyIdentifier = "SELF_MANAGED_SECURITY_HUB",
                Target = new Target { RootId = "r-f6g7h8i9j0example" }
            });


            #endregion
        }

        public void SecurityHubTagResource()
        {
            #region TagResource-1

            var client = new AmazonSecurityHubClient();
            var response = client.TagResource(new TagResourceRequest
            {
                ResourceArn = "arn:aws:securityhub:us-west-1:123456789012:hub/default",
                Tags = new Dictionary<string, string> {
                    { "Area", "USMidwest" },
                    { "Department", "Operations" }
                }
            });


            #endregion
        }

        public void SecurityHubUntagResource()
        {
            #region UntagResource-1

            var client = new AmazonSecurityHubClient();
            var response = client.UntagResource(new UntagResourceRequest
            {
                ResourceArn = "arn:aws:securityhub:us-west-1:123456789012:hub/default",
                TagKeys = new List<string> {
                    "Department"
                }
            });


            #endregion
        }

        public void SecurityHubUpdateActionTarget()
        {
            #region UpdateActionTarget-1

            var client = new AmazonSecurityHubClient();
            var response = client.UpdateActionTarget(new UpdateActionTargetRequest
            {
                ActionTargetArn = "arn:aws:securityhub:us-west-1:123456789012:action/custom/Remediation",
                Description = "Sends specified findings to customer service chat",
                Name = "Chat custom action"
            });


            #endregion
        }

        public void SecurityHubUpdateConfigurationPolicy()
        {
            #region UpdateConfigurationPolicy-1

            var client = new AmazonSecurityHubClient();
            var response = client.UpdateConfigurationPolicy(new UpdateConfigurationPolicyRequest
            {
                ConfigurationPolicy = new Policy { SecurityHub = new SecurityHubPolicy {
                    EnabledStandardIdentifiers = new List<string> {
                        "arn:aws:securityhub:us-east-1::standards/aws-foundational-security-best-practices/v/1.0.0",
                        "arn:aws:securityhub:::ruleset/cis-aws-foundations-benchmark/v/1.2.0"
                    },
                    SecurityControlsConfiguration = new SecurityControlsConfiguration {
                        DisabledSecurityControlIdentifiers = new List<string> {
                            "CloudWatch.1",
                            "CloudWatch.2"
                        },
                        SecurityControlCustomParameters = new List<SecurityControlCustomParameter> {
                            new SecurityControlCustomParameter {
                                Parameters = new Dictionary<string, ParameterConfiguration> {
                                    { "daysToExpiration", new ParameterConfiguration {
                                        Value = new ParameterValue { Integer = 21 },
                                        ValueType = "CUSTOM"
                                    } }
                                },
                                SecurityControlId = "ACM.1"
                            }
                        }
                    },
                    ServiceEnabled = true
                } },
                Description = "Updated configuration policy for testing FSBP and CIS",
                Identifier = "arn:aws:securityhub:us-east-1:123456789012:configuration-policy/a1b2c3d4-5678-90ab-cdef-EXAMPLE11111",
                Name = "TestConfigurationPolicy",
                UpdatedReason = "Enabling ACM.2"
            });

            string arn = response.Arn;
            Policy configurationPolicy = response.ConfigurationPolicy;
            DateTime? createdAt = response.CreatedAt;
            string description = response.Description;
            string id = response.Id;
            string name = response.Name;
            DateTime? updatedAt = response.UpdatedAt;

            #endregion
        }

        public void SecurityHubUpdateConnector()
        {
            #region UpdateConnector-1

            var client = new AmazonSecurityHubClient();
            var response = client.UpdateConnector(new UpdateConnectorRequest
            {
                ConnectorId = "cspm-a1b2c3d4-5678-90ab-cdef-EXAMPLE11111",
                Description = "Updated connector description",
                Provider = new CspmProviderUpdateConfiguration { Azure = new AzureUpdateConfiguration {
                    AzureRegions = new List<string> {
                        "eastus",
                        "westus2",
                        "northeurope"
                    },
                    ScopeConfiguration = new AzureScopeConfiguration {
                        ScopeType = "SUBSCRIPTION",
                        ScopeValues = new List<string> {
                            "sub-1234-5678-abcd",
                            "sub-9012-3456-efgh"
                        }
                    }
                } }
            });

            CspmConnectorStatus connectorStatus = response.ConnectorStatus;
            CspmEnablementStatus enablementStatus = response.EnablementStatus;

            #endregion
        }

        public void SecurityHubUpdateFindingAggregator()
        {
            #region UpdateFindingAggregator-1

            var client = new AmazonSecurityHubClient();
            var response = client.UpdateFindingAggregator(new UpdateFindingAggregatorRequest
            {
                FindingAggregatorArn = "arn:aws:securityhub:us-east-1:123456789012:finding-aggregator/a1b2c3d4-5678-90ab-cdef-EXAMPLE11111",
                RegionLinkingMode = "SPECIFIED_REGIONS",
                Regions = new List<string> {
                    "us-west-1",
                    "us-west-2"
                }
            });

            string findingAggregationRegion = response.FindingAggregationRegion;
            string findingAggregatorArn = response.FindingAggregatorArn;
            string regionLinkingMode = response.RegionLinkingMode;
            List<string> regions = response.Regions;

            #endregion
        }

        public void SecurityHubUpdateInsight()
        {
            #region UpdateInsight-1

            var client = new AmazonSecurityHubClient();
            var response = client.UpdateInsight(new UpdateInsightRequest
            {
                Filters = new AwsSecurityFindingFilters {
                    ResourceType = new List<StringFilter> {
                        new StringFilter {
                            Comparison = "EQUALS",
                            Value = "AwsIamRole"
                        }
                    },
                    SeverityLabel = new List<StringFilter> {
                        new StringFilter {
                            Comparison = "EQUALS",
                            Value = "HIGH"
                        }
                    }
                },
                InsightArn = "arn:aws:securityhub:us-west-1:123456789012:insight/123456789012/custom/a1b2c3d4-5678-90ab-cdef-EXAMPLE11111",
                Name = "High severity role findings"
            });


            #endregion
        }

        public void SecurityHubUpdateOrganizationConfiguration()
        {
            #region UpdateOrganizationConfiguration-1

            var client = new AmazonSecurityHubClient();
            var response = client.UpdateOrganizationConfiguration(new UpdateOrganizationConfigurationRequest
            {
                AutoEnable = false,
                AutoEnableStandards = "NONE",
                OrganizationConfiguration = new OrganizationConfiguration { ConfigurationType = "CENTRAL" }
            });


            #endregion
        }

        public void SecurityHubUpdateSecurityControl()
        {
            #region UpdateSecurityControl-1

            var client = new AmazonSecurityHubClient();
            var response = client.UpdateSecurityControl(new UpdateSecurityControlRequest
            {
                LastUpdateReason = "Comply with internal requirements",
                Parameters = new Dictionary<string, ParameterConfiguration> {
                    { "maxCredentialUsageAge", new ParameterConfiguration {
                        Value = new ParameterValue { Integer = 15 },
                        ValueType = "CUSTOM"
                    } }
                },
                SecurityControlId = "ACM.1"
            });


            #endregion
        }

        public void SecurityHubUpdateSecurityHubConfiguration()
        {
            #region UpdateSecurityHubConfiguration-1

            var client = new AmazonSecurityHubClient();
            var response = client.UpdateSecurityHubConfiguration(new UpdateSecurityHubConfigurationRequest
            {
                AutoEnableControls = true,
                ControlFindingGenerator = "SECURITY_CONTROL"
            });


            #endregion
        }

        public void SecurityHubUpdateStandardsControl()
        {
            #region UpdateStandardsControl-1

            var client = new AmazonSecurityHubClient();
            var response = client.UpdateStandardsControl(new UpdateStandardsControlRequest
            {
                ControlStatus = "DISABLED",
                DisabledReason = "Not applicable to my service",
                StandardsControlArn = "arn:aws:securityhub:us-west-1:123456789012:control/pci-dss/v/3.2.1/PCI.AutoScaling.1"
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
