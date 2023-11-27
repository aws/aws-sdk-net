using System;
using System.Collections.Generic;
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
            #region to-accept-an-invitation-be-a-member-account-1674849870467

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
            #region to-delete-one-or-more-automation-rules-1684769550318

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
            #region to-disable-one-or-more-security-standards-1674851507200

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
            #region to-enable-security-standards-1683233792239

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
            #region to-update-one-ore-more-automation-rules-1684771025347

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
            #region to-get-configuration-associations-for-a-batch-of-targets-1695178953302

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
            #region to-get-security-control-details--1683234478355

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

        public void SecurityHubBatchGetStandardsControlAssociations()
        {
            #region to-get-enablement-status-of-a-batch-of-controls-1683301618357

            var client = new AmazonSecurityHubClient();
            var response = client.BatchGetStandardsControlAssociations(new BatchGetStandardsControlAssociationsRequest 
            {
                StandardsControlAssociationIds = new List<StandardsControlAssociationId> {
                    new StandardsControlAssociationId {
                        SecurityControlId = "CloudTrail.1",
                        StandardsArn = "arn:aws:securityhub:::ruleset/cis-aws-foundations-benchmark/v/1.2.0"
                    },
                    new StandardsControlAssociationId {
                        SecurityControlId = "CloudWatch.12",
                        StandardsArn = "arn:aws:securityhub:::ruleset/cis-aws-foundations-benchmark/v/1.2.0"
                    }
                }
            });

            List<StandardsControlAssociationDetail> standardsControlAssociationDetails = response.StandardsControlAssociationDetails;

            #endregion
        }

        public void SecurityHubBatchImportFindings()
        {
            #region to-import-security-findings-from-a-third-party-provider-to-security-hub-1675090935260

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

            int failedCount = response.FailedCount;
            List<ImportFindingsError> failedFindings = response.FailedFindings;
            int successCount = response.SuccessCount;

            #endregion
        }

        public void SecurityHubBatchUpdateAutomationRules()
        {
            #region to-update-one-ore-more-automation-rules-1684771025347

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
            #region to-update-security-hub-findings-1675183938248

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
            #region to-update-enablement-status-of-a-batch-of-controls-1683300378416

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
            #region to-create-a-custom-action-target-1675184966299

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
            #region to-create-an-automation-rule-1684768393507

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
            #region to-create-a-configuration-policy-1695172470099

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
            DateTime createdAt = response.CreatedAt;
            string description = response.Description;
            string id = response.Id;
            string name = response.Name;
            DateTime updatedAt = response.UpdatedAt;

            #endregion
        }

        public void SecurityHubCreateFindingAggregator()
        {
            #region to-enable-cross-region-aggregation-1674766716226

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
            #region to-create-a-custom-insight-1675354046628

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
            #region to-add-a-member-account-1675354709996

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
            #region to-decline-invitation-to-become-a-member-account-1675448487605

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
            #region to-delete-a-custom-action-target-1675449272793

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
            #region to-delete-a-configuration-policy-1695174614062

            var client = new AmazonSecurityHubClient();
            var response = client.DeleteConfigurationPolicy(new DeleteConfigurationPolicyRequest 
            {
                Identifier = "arn:aws:securityhub:us-east-1:123456789012:configuration-policy/a1b2c3d4-5678-90ab-cdef-EXAMPLE11111"
            });


            #endregion
        }

        public void SecurityHubDeleteFindingAggregator()
        {
            #region to-delete-a-finding-aggregator-1675701750629

            var client = new AmazonSecurityHubClient();
            var response = client.DeleteFindingAggregator(new DeleteFindingAggregatorRequest 
            {
                FindingAggregatorArn = "arn:aws:securityhub:us-east-1:123456789012:finding-aggregator/a1b2c3d4-5678-90ab-cdef-EXAMPLE11111"
            });


            #endregion
        }

        public void SecurityHubDeleteInsight()
        {
            #region to-delete-a-custom-insight-1675702697204

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
            #region to-delete-a-custom-insight-1675702697204

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
            #region to-delete-a-member-account-1675883040513

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
            #region to-return-custom-action-targets-1675883682038

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
            #region to-return-details-about-hub-resource-1675884542597

            var client = new AmazonSecurityHubClient();
            var response = client.DescribeHub(new DescribeHubRequest 
            {
                HubArn = "arn:aws:securityhub:us-west-1:123456789012:hub/default"
            });

            bool autoEnableControls = response.AutoEnableControls;
            string controlFindingGenerator = response.ControlFindingGenerator;
            string hubArn = response.HubArn;
            string subscribedAt = response.SubscribedAt;

            #endregion
        }

        public void SecurityHubDescribeOrganizationConfiguration()
        {
            #region to-get-information-about-organization-configuration-1676059786304

            var client = new AmazonSecurityHubClient();
            var response = client.DescribeOrganizationConfiguration(new DescribeOrganizationConfigurationRequest 
            {
            });

            bool autoEnable = response.AutoEnable;
            string autoEnableStandards = response.AutoEnableStandards;
            bool memberAccountLimitReached = response.MemberAccountLimitReached;
            OrganizationConfiguration organizationConfiguration = response.OrganizationConfiguration;

            #endregion
        }

        public void SecurityHubDescribeProducts()
        {
            #region to-get-information-about-security-hub-integrations-1676061228533

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
            #region to-get-available-security-hub-standards-1676307464661

            var client = new AmazonSecurityHubClient();
            var response = client.DescribeStandards(new DescribeStandardsRequest 
            {
            });

            List<Standard> standards = response.Standards;

            #endregion
        }

        public void SecurityHubDescribeStandardsControls()
        {
            #region to-get-a-list-of-controls-for-a-security-standard-1676308027759

            var client = new AmazonSecurityHubClient();
            var response = client.DescribeStandardsControls(new DescribeStandardsControlsRequest 
            {
                MaxResults = 2,
                NextToken = "NULL",
                StandardsSubscriptionArn = "arn:aws:securityhub:us-west-1:123456789012:subscription/pci-dss/v/3.2.1"
            });

            List<StandardsControl> controls = response.Controls;
            string nextToken = response.NextToken;

            #endregion
        }

        public void SecurityHubDisableImportFindingsForProduct()
        {
            #region to-end-a-security-hub-integration-1676480035650

            var client = new AmazonSecurityHubClient();
            var response = client.DisableImportFindingsForProduct(new DisableImportFindingsForProductRequest 
            {
                ProductSubscriptionArn = "arn:aws:securityhub:us-east-1:517716713836:product/crowdstrike/crowdstrike-falcon"
            });


            #endregion
        }

        public void SecurityHubDisableOrganizationAdminAccount()
        {
            #region to-remove-a-security-hub-administrator-account-1676480521876

            var client = new AmazonSecurityHubClient();
            var response = client.DisableOrganizationAdminAccount(new DisableOrganizationAdminAccountRequest 
            {
                AdminAccountId = "123456789012"
            });


            #endregion
        }

        public void SecurityHubDisableSecurityHub()
        {
            #region to-deactivate-security-hub-1676583894245

            var client = new AmazonSecurityHubClient();
            var response = client.DisableSecurityHub(new DisableSecurityHubRequest 
            {
            });


            #endregion
        }

        public void SecurityHubDisassociateFromAdministratorAccount()
        {
            #region to-disassociate-requesting-account-from-administrator-account-1676584168509

            var client = new AmazonSecurityHubClient();
            var response = client.DisassociateFromAdministratorAccount(new DisassociateFromAdministratorAccountRequest 
            {
            });


            #endregion
        }

        public void SecurityHubDisassociateMembers()
        {
            #region to-disassociate-member-accounts-from-administrator-account-1676918349164

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
            #region to-activate-an-integration-1676918918114

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
            #region to-designate-a-security-hub-administrator-1676998319851

            var client = new AmazonSecurityHubClient();
            var response = client.EnableOrganizationAdminAccount(new EnableOrganizationAdminAccountRequest 
            {
                AdminAccountId = "123456789012"
            });


            #endregion
        }

        public void SecurityHubEnableSecurityHub()
        {
            #region to-activate-security-hub-1676998538599

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

        public void SecurityHubGetAdministratorAccount()
        {
            #region to-get-details-about-the-security-hub-administrator-account-1676998997182

            var client = new AmazonSecurityHubClient();
            var response = client.GetAdministratorAccount(new GetAdministratorAccountRequest 
            {
            });

            Invitation administrator = response.Administrator;

            #endregion
        }

        public void SecurityHubGetConfigurationPolicy()
        {
            #region to-get-details-about-a-configuration-policy-1695173701103

            var client = new AmazonSecurityHubClient();
            var response = client.GetConfigurationPolicy(new GetConfigurationPolicyRequest 
            {
                Identifier = "arn:aws:securityhub:us-east-1:123456789012:configuration-policy/a1b2c3d4-5678-90ab-cdef-EXAMPLE11111"
            });

            string arn = response.Arn;
            Policy configurationPolicy = response.ConfigurationPolicy;
            DateTime createdAt = response.CreatedAt;
            string description = response.Description;
            string id = response.Id;
            string name = response.Name;
            DateTime updatedAt = response.UpdatedAt;

            #endregion
        }

        public void SecurityHubGetConfigurationPolicyAssociation()
        {
            #region to-get-details-about-a-configuration-association-1695177816371

            var client = new AmazonSecurityHubClient();
            var response = client.GetConfigurationPolicyAssociation(new GetConfigurationPolicyAssociationRequest 
            {
                Target = new Target { AccountId = "111122223333" }
            });

            string associationStatus = response.AssociationStatus;
            string associationStatusMessage = response.AssociationStatusMessage;
            string associationType = response.AssociationType;
            string configurationPolicyId = response.ConfigurationPolicyId;
            string targetId = response.TargetId;
            string targetType = response.TargetType;
            DateTime updatedAt = response.UpdatedAt;

            #endregion
        }

        public void SecurityHubGetEnabledStandards()
        {
            #region to-return-a-list-of-enabled-standards-1677090731129

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
            #region to-get-cross-region-aggregation-details-1677091474868

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

        public void SecurityHubGetFindingHistory()
        {
            #region to-get-finding-history-1680270012186

            var client = new AmazonSecurityHubClient();
            var response = client.GetFindingHistory(new GetFindingHistoryRequest 
            {
                EndTime = DateTime.UtcNow,
                FindingIdentifier = new AwsSecurityFindingIdentifier {
                    Id = "a1b2c3d4-5678-90ab-cdef-EXAMPLE11111",
                    ProductArn = "arn:aws:securityhub:us-west-2:123456789012:product/123456789012/default"
                },
                MaxResults = 2,
                StartTime = new DateTime(2021, 9, 30, 3, 53, 35, DateTimeKind.Utc)
            });

            List<FindingHistoryRecord> records = response.Records;

            #endregion
        }

        public void SecurityHubGetFindings()
        {
            #region to-get-a-list-of-findings-1677181069931

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
            #region to-get-the-results-of-a-security-hub-insight-1677182822019

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
            #region to-get-details-of-a-security-hub-insight-1677774127203

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
            #region to-get-a-count-of-membership-invitations-1677774568793

            var client = new AmazonSecurityHubClient();
            var response = client.GetInvitationsCount(new GetInvitationsCountRequest 
            {
            });

            int invitationsCount = response.InvitationsCount;

            #endregion
        }

        public void SecurityHubGetMembers()
        {
            #region to-get-member-account-details-1677774956489

            var client = new AmazonSecurityHubClient();
            var response = client.GetMembers(new GetMembersRequest 
            {
                AccountIds = new List<string> {
                    "444455556666",
                    "777788889999"
                }
            });

            List<Member> members = response.Members;
            List<Result> unprocessedAccounts = response.UnprocessedAccounts;

            #endregion
        }

        public void SecurityHubGetSecurityControlDefinition()
        {
            #region to-get-the-definition-of-a-security-control-1699283789356

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
            #region to-invite-accounts-to-become-members-1677775500860

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
            #region to-list-automation-rules-1684770582059

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
            #region to-view-a-list-of-configuration-policies-1695173268602

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
            #region to-list-configuration-associations-1695177309791

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

        public void SecurityHubListEnabledProductsForImport()
        {
            #region to-list-arns-for-enabled-integrations-1678294870020

            var client = new AmazonSecurityHubClient();
            var response = client.ListEnabledProductsForImport(new ListEnabledProductsForImportRequest 
            {
            });

            List<string> productSubscriptions = response.ProductSubscriptions;

            #endregion
        }

        public void SecurityHubListFindingAggregators()
        {
            #region to-update-the-enablement-status-of-a-standard-control-1678912506444

            var client = new AmazonSecurityHubClient();
            var response = client.ListFindingAggregators(new ListFindingAggregatorsRequest 
            {
            });

            List<FindingAggregator> findingAggregators = response.FindingAggregators;

            #endregion
        }

        public void SecurityHubListInvitations()
        {
            #region to-list-membership-invitations-to-calling-account-1678295758285

            var client = new AmazonSecurityHubClient();
            var response = client.ListInvitations(new ListInvitationsRequest 
            {
            });

            List<Invitation> invitations = response.Invitations;

            #endregion
        }

        public void SecurityHubListMembers()
        {
            #region to-list-member-account-details-1678385639113

            var client = new AmazonSecurityHubClient();
            var response = client.ListMembers(new ListMembersRequest 
            {
            });

            List<Member> members = response.Members;

            #endregion
        }

        public void SecurityHubListOrganizationAdminAccounts()
        {
            #region to-list-administrator-acccounts-for-an-organization-1678386548110

            var client = new AmazonSecurityHubClient();
            var response = client.ListOrganizationAdminAccounts(new ListOrganizationAdminAccountsRequest 
            {
            });

            List<AdminAccount> adminAccounts = response.AdminAccounts;

            #endregion
        }

        public void SecurityHubListSecurityControlDefinitions()
        {
            #region to-list-security-controls-that-apply-to-a-standard-1678386912894

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

        public void SecurityHubListStandardsControlAssociations()
        {
            #region to-say-whether-standard-1678389297986

            var client = new AmazonSecurityHubClient();
            var response = client.ListStandardsControlAssociations(new ListStandardsControlAssociationsRequest 
            {
                SecurityControlId = "S3.1"
            });

            List<StandardsControlAssociationSummary> standardsControlAssociationSummaries = response.StandardsControlAssociationSummaries;

            #endregion
        }

        public void SecurityHubListTagsForResource()
        {
            #region to-get-a-list-of-tags-for-a-resource-1678477883796

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
            #region to-associate-a-configuration-with-a-target-1695176455638

            var client = new AmazonSecurityHubClient();
            var response = client.StartConfigurationPolicyAssociation(new StartConfigurationPolicyAssociationRequest 
            {
                ConfigurationPolicyIdentifier = "arn:aws:securityhub:us-east-1:123456789012:configuration-policy/a1b2c3d4-5678-90ab-cdef-EXAMPLE11111",
                Target = new Target { AccountId = "111122223333" }
            });

            string associationStatus = response.AssociationStatus;
            string associationStatusMessage = response.AssociationStatusMessage;
            string associationType = response.AssociationType;
            string configurationPolicyId = response.ConfigurationPolicyId;
            string targetId = response.TargetId;
            string targetType = response.TargetType;
            DateTime updatedAt = response.UpdatedAt;

            #endregion
        }

        public void SecurityHubStartConfigurationPolicyDisassociation()
        {
            #region to-disassociate-a-configuration-from-a-target-1695177176748

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
            #region to-tag-a-resource-1678478687320

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
            #region to-remove-tags-from-a-resource-1678478903748

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
            #region to-update-the-name-and-description-of-a-custom-action-target-1678814873015

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
            #region to-update-a-configuration-policy-1695174120555

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
            DateTime createdAt = response.CreatedAt;
            string description = response.Description;
            string id = response.Id;
            string name = response.Name;
            DateTime updatedAt = response.UpdatedAt;

            #endregion
        }

        public void SecurityHubUpdateFindingAggregator()
        {
            #region to-update-cross-region-aggregation-settings-1678815536396

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
            #region to-update-an-insight-1678816280498

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
            #region to-update-organization-configuration-1678911630846

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
            #region to-update-security-control-properties-1699282942434

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
            #region to-update-security-hub-settings-1678912194496

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
            #region to-update-the-enablement-status-of-a-standard-control-1678912506444

            var client = new AmazonSecurityHubClient();
            var response = client.UpdateStandardsControl(new UpdateStandardsControlRequest 
            {
                ControlStatus = "DISABLED",
                DisabledReason = "Not applicable to my service",
                StandardsControlArn = "arn:aws:securityhub:us-west-1:123456789012:control/pci-dss/v/3.2.1/PCI.AutoScaling.1"
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