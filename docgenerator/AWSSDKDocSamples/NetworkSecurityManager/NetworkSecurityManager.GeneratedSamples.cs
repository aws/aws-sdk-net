using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Amazon.NetworkSecurityManager;
using Amazon.NetworkSecurityManager.Model;

namespace AWSSDKDocSamples.Amazon.NetworkSecurityManager.Generated
{
    class NetworkSecurityManagerSamples : ISample
    {
        public void NetworkSecurityManagerCreateDeployment()
        {
            #region example-1

            var client = new AmazonNetworkSecurityManagerClient();
            var response = client.CreateDeployment(new CreateDeploymentRequest 
            {
                AssociatedPolicyList = new List<PolicyReference> {
                    new PolicyReference { PolicyIdentifier = "arn:aws:network-security-manager:us-east-1:123456789012:policy:xyz789" }
                },
                AssociatedScopeList = new List<ScopeReference> {
                    new ScopeReference { ScopeIdentifier = "arn:aws:network-security-manager:us-east-1:123456789012:scope:abc123" }
                },
                ClientToken = "550e8400-e29b-41d4-a716-446655440003",
                DeploymentConfiguration = new DeploymentConfiguration { EnableCrossAccountVisibility = false },
                DeploymentDescription = "Production deployment for US East 1 region",
                DeploymentName = "prod-us-east-1-deployment",
                IsPublished = false
            });

            string version = response.Version;
            List<AssociatedPolicy> associatedPolicyList = response.AssociatedPolicyList;
            List<AssociatedScope> associatedScopeList = response.AssociatedScopeList;
            string deploymentArn = response.DeploymentArn;
            DeploymentConfiguration deploymentConfiguration = response.DeploymentConfiguration;
            string deploymentDescription = response.DeploymentDescription;
            string deploymentId = response.DeploymentId;
            string deploymentName = response.DeploymentName;
            bool hasPublishedVersion = response.HasPublishedVersion;
            bool isSnapshot = response.IsSnapshot;
            string status = response.Status;
            string updateToken = response.UpdateToken;

            #endregion
        }

        public void NetworkSecurityManagerCreateDeploymentSnapshot()
        {
            #region example-1

            var client = new AmazonNetworkSecurityManagerClient();
            var response = client.CreateDeploymentSnapshot(new CreateDeploymentSnapshotRequest 
            {
                ClientToken = "550e8400-e29b-41d4-a716-446655440014",
                DeploymentIdentifier = "arn:aws:network-security-manager:us-east-1:123456789012:deployment:def456"
            });

            string version = response.Version;
            List<AssociatedPolicy> associatedPolicyList = response.AssociatedPolicyList;
            List<AssociatedScope> associatedScopeList = response.AssociatedScopeList;
            string deploymentArn = response.DeploymentArn;
            DeploymentConfiguration deploymentConfiguration = response.DeploymentConfiguration;
            string deploymentId = response.DeploymentId;
            string deploymentName = response.DeploymentName;
            bool isSnapshot = response.IsSnapshot;
            string status = response.Status;
            DateTime updatedAt = response.UpdatedAt;

            #endregion
        }

        public void NetworkSecurityManagerCreatePolicy()
        {
            #region example-1

            var client = new AmazonNetworkSecurityManagerClient();
            var response = client.CreatePolicy(new CreatePolicyRequest 
            {
                AssociatedTemplateAndRuleList = new List<TemplateOrRuleReference> {
                    new TemplateOrRuleReference { TemplateIdentifier = "arn:aws:network-security-manager:us-east-1:123456789012:template:xyz789" }
                },
                ClientToken = "550e8400-e29b-41d4-a716-446655440002",
                FirewallType = "WAF",
                IsPublished = false,
                PolicyConfiguration = new PolicyConfiguration {
                    RemediationEnabled = false,
                    ResourcesCleanUp = false,
                    WafConfig = new WafConfig {
                        ConflictResolution = "MERGE_WHERE_APPLICABLE",
                        ExistingCustomerWebACLResolution = "NO_REMEDIATION"
                    }
                },
                PolicyDescription = "WAF policy for web application protection",
                PolicyName = "web-app-waf-policy",
                Priority = 1
            });

            string version = response.Version;
            List<AssociatedTemplateOrRule> associatedTemplateAndRuleList = response.AssociatedTemplateAndRuleList;
            string firewallType = response.FirewallType;
            bool hasPublishedVersion = response.HasPublishedVersion;
            bool isSnapshot = response.IsSnapshot;
            string policyArn = response.PolicyArn;
            PolicyConfiguration policyConfiguration = response.PolicyConfiguration;
            string policyDescription = response.PolicyDescription;
            string policyId = response.PolicyId;
            string policyName = response.PolicyName;
            int priority = response.Priority;
            string status = response.Status;
            string updateToken = response.UpdateToken;

            #endregion
        }

        public void NetworkSecurityManagerCreatePolicySnapshot()
        {
            #region example-1

            var client = new AmazonNetworkSecurityManagerClient();
            var response = client.CreatePolicySnapshot(new CreatePolicySnapshotRequest 
            {
                ClientToken = "550e8400-e29b-41d4-a716-446655440013",
                PolicyIdentifier = "arn:aws:network-security-manager:us-east-1:123456789012:policy:xyz789"
            });

            string version = response.Version;
            List<AssociatedTemplateOrRule> associatedTemplateAndRuleList = response.AssociatedTemplateAndRuleList;
            string firewallType = response.FirewallType;
            bool isSnapshot = response.IsSnapshot;
            string policyArn = response.PolicyArn;
            PolicyConfiguration policyConfiguration = response.PolicyConfiguration;
            string policyId = response.PolicyId;
            string policyName = response.PolicyName;
            int priority = response.Priority;
            string status = response.Status;
            DateTime updatedAt = response.UpdatedAt;

            #endregion
        }

        public void NetworkSecurityManagerCreateRule()
        {
            #region example-1

            var client = new AmazonNetworkSecurityManagerClient();
            var response = client.CreateRule(new CreateRuleRequest 
            {
                ClientToken = "550e8400-e29b-41d4-a716-446655440000",
                Configuration = new JsonDocument {  },
                FirewallType = "WAF",
                IsPublished = false,
                RuleDescription = "Blocks requests from known malicious IP addresses",
                RuleName = "block-known-bad-ips",
                RuleType = "INSPECTION"
            });

            string version = response.Version;
            JsonDocument configuration = response.Configuration;
            string firewallType = response.FirewallType;
            bool hasPublishedVersion = response.HasPublishedVersion;
            bool isSnapshot = response.IsSnapshot;
            string ruleArn = response.RuleArn;
            string ruleDescription = response.RuleDescription;
            string ruleId = response.RuleId;
            string ruleName = response.RuleName;
            string ruleType = response.RuleType;
            string status = response.Status;
            string updateToken = response.UpdateToken;

            #endregion
        }

        public void NetworkSecurityManagerCreateRuleSnapshot()
        {
            #region example-1

            var client = new AmazonNetworkSecurityManagerClient();
            var response = client.CreateRuleSnapshot(new CreateRuleSnapshotRequest 
            {
                ClientToken = "550e8400-e29b-41d4-a716-446655440011",
                RuleIdentifier = "arn:aws:network-security-manager:us-east-1:123456789012:rule:abc123"
            });

            string version = response.Version;
            JsonDocument configuration = response.Configuration;
            string firewallType = response.FirewallType;
            bool isSnapshot = response.IsSnapshot;
            string ruleArn = response.RuleArn;
            string ruleId = response.RuleId;
            string ruleName = response.RuleName;
            string ruleType = response.RuleType;
            string status = response.Status;
            DateTime updatedAt = response.UpdatedAt;

            #endregion
        }

        public void NetworkSecurityManagerCreateScope()
        {
            #region example-1

            var client = new AmazonNetworkSecurityManagerClient();
            var response = client.CreateScope(new CreateScopeRequest 
            {
                ClientToken = "550e8400-e29b-41d4-a716-446655440001",
                IsPublished = true,
                ScopeConfiguration = new ScopeConfiguration {
                    AccountFilter = new AccountFilter { IncludeAll = new Unit {  } },
                    ResourceScopes = new Dictionary<string, ResourceScope> {
                        
                    }
                },
                ScopeDescription = "Scope covering all production web application resources",
                ScopeName = "production-web-apps"
            });

            string version = response.Version;
            bool hasPublishedVersion = response.HasPublishedVersion;
            bool isSnapshot = response.IsSnapshot;
            string scopeArn = response.ScopeArn;
            ScopeConfiguration scopeConfiguration = response.ScopeConfiguration;
            string scopeDescription = response.ScopeDescription;
            string scopeId = response.ScopeId;
            string scopeName = response.ScopeName;
            string status = response.Status;
            string updateToken = response.UpdateToken;

            #endregion
        }

        public void NetworkSecurityManagerCreateScopeSnapshot()
        {
            #region example-1

            var client = new AmazonNetworkSecurityManagerClient();
            var response = client.CreateScopeSnapshot(new CreateScopeSnapshotRequest 
            {
                ClientToken = "550e8400-e29b-41d4-a716-446655440010",
                ScopeIdentifier = "arn:aws:network-security-manager:us-east-1:123456789012:scope:abc123"
            });

            string version = response.Version;
            bool isSnapshot = response.IsSnapshot;
            string scopeArn = response.ScopeArn;
            ScopeConfiguration scopeConfiguration = response.ScopeConfiguration;
            string scopeId = response.ScopeId;
            string scopeName = response.ScopeName;
            string status = response.Status;
            DateTime updatedAt = response.UpdatedAt;

            #endregion
        }

        public void NetworkSecurityManagerCreateTemplate()
        {
            #region example-1

            var client = new AmazonNetworkSecurityManagerClient();
            var response = client.CreateTemplate(new CreateTemplateRequest 
            {
                AssociatedRuleList = new List<RuleReference> {
                    new RuleReference { RuleIdentifier = "arn:aws:network-security-manager:us-east-1:123456789012:rule:abc123" }
                },
                ClientToken = "550e8400-e29b-41d4-a716-446655440004",
                FirewallType = "WAF",
                IsPublished = true,
                TemplateDescription = "Standard WAF template with baseline rule groups",
                TemplateName = "standard-waf-template"
            });

            string version = response.Version;
            List<AssociatedRule> associatedRuleList = response.AssociatedRuleList;
            string firewallType = response.FirewallType;
            bool hasPublishedVersion = response.HasPublishedVersion;
            bool isSnapshot = response.IsSnapshot;
            string status = response.Status;
            string templateArn = response.TemplateArn;
            string templateDescription = response.TemplateDescription;
            string templateId = response.TemplateId;
            string templateName = response.TemplateName;
            string updateToken = response.UpdateToken;

            #endregion
        }

        public void NetworkSecurityManagerCreateTemplateSnapshot()
        {
            #region example-1

            var client = new AmazonNetworkSecurityManagerClient();
            var response = client.CreateTemplateSnapshot(new CreateTemplateSnapshotRequest 
            {
                ClientToken = "550e8400-e29b-41d4-a716-446655440012",
                TemplateIdentifier = "arn:aws:network-security-manager:us-east-1:123456789012:template:xyz789"
            });

            string version = response.Version;
            List<AssociatedRule> associatedRuleList = response.AssociatedRuleList;
            string firewallType = response.FirewallType;
            bool isSnapshot = response.IsSnapshot;
            string status = response.Status;
            string templateArn = response.TemplateArn;
            string templateId = response.TemplateId;
            string templateName = response.TemplateName;
            DateTime updatedAt = response.UpdatedAt;

            #endregion
        }

        public void NetworkSecurityManagerDeleteAdminAccount()
        {
            #region example-1

            var client = new AmazonNetworkSecurityManagerClient();
            var response = client.DeleteAdminAccount(new DeleteAdminAccountRequest 
            {
                AccountId = "234567890123"
            });


            #endregion
        }

        public void NetworkSecurityManagerDeleteDeployment()
        {
            #region example-1

            var client = new AmazonNetworkSecurityManagerClient();
            var response = client.DeleteDeployment(new DeleteDeploymentRequest 
            {
                DeploymentIdentifier = "arn:aws:network-security-manager:us-east-1:123456789012:deployment:def456"
            });


            #endregion
        }

        public void NetworkSecurityManagerDeletePolicy()
        {
            #region example-1

            var client = new AmazonNetworkSecurityManagerClient();
            var response = client.DeletePolicy(new DeletePolicyRequest 
            {
                PolicyIdentifier = "arn:aws:network-security-manager:us-east-1:123456789012:policy:xyz789"
            });


            #endregion
        }

        public void NetworkSecurityManagerDeleteRule()
        {
            #region example-1

            var client = new AmazonNetworkSecurityManagerClient();
            var response = client.DeleteRule(new DeleteRuleRequest 
            {
                RuleIdentifier = "arn:aws:network-security-manager:us-east-1:123456789012:rule:abc123"
            });


            #endregion
        }

        public void NetworkSecurityManagerDeleteScope()
        {
            #region example-1

            var client = new AmazonNetworkSecurityManagerClient();
            var response = client.DeleteScope(new DeleteScopeRequest 
            {
                ScopeIdentifier = "arn:aws:network-security-manager:us-east-1:123456789012:scope:abc123"
            });


            #endregion
        }

        public void NetworkSecurityManagerDeleteTemplate()
        {
            #region example-1

            var client = new AmazonNetworkSecurityManagerClient();
            var response = client.DeleteTemplate(new DeleteTemplateRequest 
            {
                TemplateIdentifier = "arn:aws:network-security-manager:us-east-1:123456789012:template:xyz789"
            });


            #endregion
        }

        public void NetworkSecurityManagerGenerateRuleConfiguration()
        {
            #region example-1

            var client = new AmazonNetworkSecurityManagerClient();
            var response = client.GenerateRuleConfiguration(new GenerateRuleConfigurationRequest 
            {
                ClientToken = "550e8400-e29b-41d4-a716-446655440015",
                Prompt = "Create a rate limiting rule that blocks IP addresses sending more than 2000 requests in 5 minutes",
                RuleFirewallType = "WAF",
                RuleType = "INSPECTION"
            });

            string configuration = response.Configuration;

            #endregion
        }

        public void NetworkSecurityManagerGetAdminAccount()
        {
            #region example-1

            var client = new AmazonNetworkSecurityManagerClient();
            var response = client.GetAdminAccount(new GetAdminAccountRequest 
            {
                AccountId = "234567890123"
            });

            AdminAccountDetails adminAccountDetails = response.AdminAccountDetails;

            #endregion
        }

        public void NetworkSecurityManagerGetDeployment()
        {
            #region example-1

            var client = new AmazonNetworkSecurityManagerClient();
            var response = client.GetDeployment(new GetDeploymentRequest 
            {
                DeploymentIdentifier = "arn:aws:network-security-manager:us-east-1:123456789012:deployment:def456"
            });

            string version = response.Version;
            List<AssociatedPolicy> associatedPolicyList = response.AssociatedPolicyList;
            List<AssociatedScope> associatedScopeList = response.AssociatedScopeList;
            string deploymentArn = response.DeploymentArn;
            DeploymentConfiguration deploymentConfiguration = response.DeploymentConfiguration;
            List<DeploymentCoverageEntry> deploymentCoverage = response.DeploymentCoverage;
            string deploymentDescription = response.DeploymentDescription;
            string deploymentId = response.DeploymentId;
            string deploymentName = response.DeploymentName;
            bool hasPublishedVersion = response.HasPublishedVersion;
            bool isSnapshot = response.IsSnapshot;
            string status = response.Status;
            string updateToken = response.UpdateToken;

            #endregion
        }

        public void NetworkSecurityManagerGetPolicy()
        {
            #region example-1

            var client = new AmazonNetworkSecurityManagerClient();
            var response = client.GetPolicy(new GetPolicyRequest 
            {
                PolicyIdentifier = "arn:aws:network-security-manager:us-east-1:123456789012:policy:xyz789"
            });

            string version = response.Version;
            List<AssociatedTemplateOrRule> associatedTemplateAndRuleList = response.AssociatedTemplateAndRuleList;
            string firewallType = response.FirewallType;
            bool hasPublishedVersion = response.HasPublishedVersion;
            bool isSnapshot = response.IsSnapshot;
            string policyArn = response.PolicyArn;
            PolicyConfiguration policyConfiguration = response.PolicyConfiguration;
            string policyDescription = response.PolicyDescription;
            string policyId = response.PolicyId;
            string policyName = response.PolicyName;
            int priority = response.Priority;
            string status = response.Status;
            string updateToken = response.UpdateToken;

            #endregion
        }

        public void NetworkSecurityManagerGetRule()
        {
            #region example-1

            var client = new AmazonNetworkSecurityManagerClient();
            var response = client.GetRule(new GetRuleRequest 
            {
                RuleIdentifier = "arn:aws:network-security-manager:us-east-1:123456789012:rule:abc123"
            });

            string version = response.Version;
            JsonDocument configuration = response.Configuration;
            string firewallType = response.FirewallType;
            bool hasPublishedVersion = response.HasPublishedVersion;
            bool isSnapshot = response.IsSnapshot;
            string ruleArn = response.RuleArn;
            string ruleDescription = response.RuleDescription;
            string ruleId = response.RuleId;
            string ruleName = response.RuleName;
            string ruleType = response.RuleType;
            string status = response.Status;
            string updateToken = response.UpdateToken;

            #endregion
        }

        public void NetworkSecurityManagerGetRule()
        {
            #region example-2

            var client = new AmazonNetworkSecurityManagerClient();
            var response = client.GetRule(new GetRuleRequest 
            {
                RuleIdentifier = "arn:aws:network-security-manager:us-east-1:123456789012:rule:abc123:3"
            });

            string version = response.Version;
            JsonDocument configuration = response.Configuration;
            string firewallType = response.FirewallType;
            bool isSnapshot = response.IsSnapshot;
            string ruleArn = response.RuleArn;
            string ruleDescription = response.RuleDescription;
            string ruleId = response.RuleId;
            string ruleName = response.RuleName;
            string ruleType = response.RuleType;
            string status = response.Status;

            #endregion
        }

        public void NetworkSecurityManagerGetScope()
        {
            #region example-1

            var client = new AmazonNetworkSecurityManagerClient();
            var response = client.GetScope(new GetScopeRequest 
            {
                ScopeIdentifier = "arn:aws:network-security-manager:us-east-1:123456789012:scope:abc123"
            });

            string version = response.Version;
            bool hasPublishedVersion = response.HasPublishedVersion;
            bool isSnapshot = response.IsSnapshot;
            string scopeArn = response.ScopeArn;
            ScopeConfiguration scopeConfiguration = response.ScopeConfiguration;
            string scopeDescription = response.ScopeDescription;
            string scopeId = response.ScopeId;
            string scopeName = response.ScopeName;
            string status = response.Status;
            string updateToken = response.UpdateToken;

            #endregion
        }

        public void NetworkSecurityManagerGetTemplate()
        {
            #region example-1

            var client = new AmazonNetworkSecurityManagerClient();
            var response = client.GetTemplate(new GetTemplateRequest 
            {
                TemplateIdentifier = "arn:aws:network-security-manager:us-east-1:123456789012:template:xyz789"
            });

            string version = response.Version;
            List<AssociatedRule> associatedRuleList = response.AssociatedRuleList;
            string firewallType = response.FirewallType;
            bool hasPublishedVersion = response.HasPublishedVersion;
            bool isSnapshot = response.IsSnapshot;
            string status = response.Status;
            string templateArn = response.TemplateArn;
            string templateDescription = response.TemplateDescription;
            string templateId = response.TemplateId;
            string templateName = response.TemplateName;
            string updateToken = response.UpdateToken;

            #endregion
        }

        public void NetworkSecurityManagerListAdminAccounts()
        {
            #region example-1

            var client = new AmazonNetworkSecurityManagerClient();
            var response = client.ListAdminAccounts(new ListAdminAccountsRequest 
            {
                MaxResults = 10
            });

            List<AdminAccountSummary> adminAccounts = response.AdminAccounts;

            #endregion
        }

        public void NetworkSecurityManagerListAggregateResourceSynchronizationStatuses()
        {
            #region example-1

            var client = new AmazonNetworkSecurityManagerClient();
            var response = client.ListAggregateResourceSynchronizationStatuses(new ListAggregateResourceSynchronizationStatusesRequest 
            {
                MaxResults = 10,
                SynchronizationStatus = "IN_SYNC"
            });

            List<ResourceSynchronizationStatusSummary> resourceSynchronizationStatuses = response.ResourceSynchronizationStatuses;

            #endregion
        }

        public void NetworkSecurityManagerListDeployments()
        {
            #region example-1

            var client = new AmazonNetworkSecurityManagerClient();
            var response = client.ListDeployments(new ListDeploymentsRequest 
            {
                MaxResults = 10,
                Status = "ACTIVE"
            });

            List<DeploymentSummary> deployments = response.Deployments;

            #endregion
        }

        public void NetworkSecurityManagerListDeploymentSnapshots()
        {
            #region example-1

            var client = new AmazonNetworkSecurityManagerClient();
            var response = client.ListDeploymentSnapshots(new ListDeploymentSnapshotsRequest 
            {
                DeploymentIdentifier = "arn:aws:network-security-manager:us-east-1:123456789012:deployment:def456",
                MaxResults = 10
            });

            List<DeploymentSummary> snapshots = response.Snapshots;

            #endregion
        }

        public void NetworkSecurityManagerListPolicies()
        {
            #region example-1

            var client = new AmazonNetworkSecurityManagerClient();
            var response = client.ListPolicies(new ListPoliciesRequest 
            {
                MaxResults = 10,
                Status = "ACTIVE"
            });

            List<PolicySummary> policies = response.Policies;

            #endregion
        }

        public void NetworkSecurityManagerListPolicySnapshots()
        {
            #region example-1

            var client = new AmazonNetworkSecurityManagerClient();
            var response = client.ListPolicySnapshots(new ListPolicySnapshotsRequest 
            {
                MaxResults = 10,
                PolicyIdentifier = "arn:aws:network-security-manager:us-east-1:123456789012:policy:xyz789"
            });

            List<PolicySummary> snapshots = response.Snapshots;

            #endregion
        }

        public void NetworkSecurityManagerListResourceAssociations()
        {
            #region example-1

            var client = new AmazonNetworkSecurityManagerClient();
            var response = client.ListResourceAssociations(new ListResourceAssociationsRequest 
            {
                MaxResults = 10,
                ResourceIdentifier = "arn:aws:network-security-manager:us-east-1:123456789012:rule:abc123"
            });

            List<ResourceAssociation> resourceAssociations = response.ResourceAssociations;

            #endregion
        }

        public void NetworkSecurityManagerListResourceSynchronizationStatuses()
        {
            #region example-1

            var client = new AmazonNetworkSecurityManagerClient();
            var response = client.ListResourceSynchronizationStatuses(new ListResourceSynchronizationStatusesRequest 
            {
                DeploymentIdentifier = "arn:aws:network-security-manager:us-east-1:123456789012:deployment:def456",
                MaxResults = 10,
                SynchronizationStatus = "OUT_OF_SYNC"
            });

            List<ResourceSynchronizationStatusSummary> resourceSynchronizationStatuses = response.ResourceSynchronizationStatuses;

            #endregion
        }

        public void NetworkSecurityManagerListRules()
        {
            #region example-1

            var client = new AmazonNetworkSecurityManagerClient();
            var response = client.ListRules(new ListRulesRequest 
            {
                MaxResults = 10,
                Status = "ACTIVE"
            });

            List<RuleSummary> rules = response.Rules;

            #endregion
        }

        public void NetworkSecurityManagerListRuleSnapshots()
        {
            #region example-1

            var client = new AmazonNetworkSecurityManagerClient();
            var response = client.ListRuleSnapshots(new ListRuleSnapshotsRequest 
            {
                MaxResults = 10,
                RuleIdentifier = "arn:aws:network-security-manager:us-east-1:123456789012:rule:abc123"
            });

            List<RuleSummary> snapshots = response.Snapshots;

            #endregion
        }

        public void NetworkSecurityManagerListScopes()
        {
            #region example-1

            var client = new AmazonNetworkSecurityManagerClient();
            var response = client.ListScopes(new ListScopesRequest 
            {
                MaxResults = 10,
                Status = "ACTIVE"
            });

            string nextToken = response.NextToken;
            List<ScopeSummary> scopes = response.Scopes;

            #endregion
        }

        public void NetworkSecurityManagerListScopeSnapshots()
        {
            #region example-1

            var client = new AmazonNetworkSecurityManagerClient();
            var response = client.ListScopeSnapshots(new ListScopeSnapshotsRequest 
            {
                MaxResults = 10,
                ScopeIdentifier = "arn:aws:network-security-manager:us-east-1:123456789012:scope:abc123"
            });

            List<ScopeSummary> snapshots = response.Snapshots;

            #endregion
        }

        public void NetworkSecurityManagerListTagsForResource()
        {
            #region example-1

            var client = new AmazonNetworkSecurityManagerClient();
            var response = client.ListTagsForResource(new ListTagsForResourceRequest 
            {
                ResourceArn = "arn:aws:network-security-manager:us-east-1:123456789012:policy:xyz789"
            });

            Dictionary<string, string> tags = response.Tags;

            #endregion
        }

        public void NetworkSecurityManagerListTemplates()
        {
            #region example-1

            var client = new AmazonNetworkSecurityManagerClient();
            var response = client.ListTemplates(new ListTemplatesRequest 
            {
                MaxResults = 10,
                Status = "ACTIVE"
            });

            List<TemplateSummary> templates = response.Templates;

            #endregion
        }

        public void NetworkSecurityManagerListTemplateSnapshots()
        {
            #region example-1

            var client = new AmazonNetworkSecurityManagerClient();
            var response = client.ListTemplateSnapshots(new ListTemplateSnapshotsRequest 
            {
                MaxResults = 10,
                TemplateIdentifier = "arn:aws:network-security-manager:us-east-1:123456789012:template:xyz789"
            });

            List<TemplateSummary> snapshots = response.Snapshots;

            #endregion
        }

        public void NetworkSecurityManagerPutAdminAccount()
        {
            #region example-1

            var client = new AmazonNetworkSecurityManagerClient();
            var response = client.PutAdminAccount(new PutAdminAccountRequest 
            {
                AccountId = "234567890123",
                AdminScope = new AdminScopeInput {
                    FirewallTypeScope = new AdminFirewallTypeScope {
                        AllFirewallTypesEnabled = false,
                        FirewallTypes = new List<string> {
                            "WAF"
                        }
                    },
                    ScopeFilter = new AdminScopeFilterInput { IncludeOnly = new AdminScopeSelectionInput { OrganizationalUnits = new List<string> {
                        "ou-abcd-12345678"
                    } } }
                },
                Priority = 2
            });

            AdminAccountDetails adminAccountDetails = response.AdminAccountDetails;

            #endregion
        }

        public void NetworkSecurityManagerTagResource()
        {
            #region example-1

            var client = new AmazonNetworkSecurityManagerClient();
            var response = client.TagResource(new TagResourceRequest 
            {
                ResourceArn = "arn:aws:network-security-manager:us-east-1:123456789012:policy:xyz789",
                Tags = new Dictionary<string, string> {
                    { "Environment", "Production" },
                    { "Team", "NetworkSecurity" }
                }
            });


            #endregion
        }

        public void NetworkSecurityManagerUntagResource()
        {
            #region example-1

            var client = new AmazonNetworkSecurityManagerClient();
            var response = client.UntagResource(new UntagResourceRequest 
            {
                ResourceArn = "arn:aws:network-security-manager:us-east-1:123456789012:policy:xyz789",
                TagKeys = new List<string> {
                    "Environment"
                }
            });


            #endregion
        }

        public void NetworkSecurityManagerUpdateDeployment()
        {
            #region example-1

            var client = new AmazonNetworkSecurityManagerClient();
            var response = client.UpdateDeployment(new UpdateDeploymentRequest 
            {
                AssociatedPolicyList = new List<PolicyReference> {
                    new PolicyReference { PolicyIdentifier = "arn:aws:network-security-manager:us-east-1:123456789012:policy:xyz789" }
                },
                AssociatedScopeList = new List<ScopeReference> {
                    new ScopeReference { ScopeIdentifier = "arn:aws:network-security-manager:us-east-1:123456789012:scope:abc123" }
                },
                DeploymentConfiguration = new DeploymentConfiguration { EnableCrossAccountVisibility = true },
                DeploymentDescription = "Production deployment for US East 1 region - updated",
                DeploymentIdentifier = "arn:aws:network-security-manager:us-east-1:123456789012:deployment:def456",
                IsPublished = true,
                UpdateToken = "f4a5b6c7-7d8e-4f9a-8b1c-1d2e3f4a5b6c"
            });

            string version = response.Version;
            List<AssociatedPolicy> associatedPolicyList = response.AssociatedPolicyList;
            List<AssociatedScope> associatedScopeList = response.AssociatedScopeList;
            string deploymentArn = response.DeploymentArn;
            DeploymentConfiguration deploymentConfiguration = response.DeploymentConfiguration;
            List<DeploymentCoverageEntry> deploymentCoverage = response.DeploymentCoverage;
            string deploymentDescription = response.DeploymentDescription;
            string deploymentId = response.DeploymentId;
            string deploymentName = response.DeploymentName;
            bool hasPublishedVersion = response.HasPublishedVersion;
            bool isSnapshot = response.IsSnapshot;
            string status = response.Status;
            string updateToken = response.UpdateToken;
            DateTime updatedAt = response.UpdatedAt;

            #endregion
        }

        public void NetworkSecurityManagerUpdatePolicy()
        {
            #region example-1

            var client = new AmazonNetworkSecurityManagerClient();
            var response = client.UpdatePolicy(new UpdatePolicyRequest 
            {
                AssociatedTemplateAndRuleList = new List<TemplateOrRuleReference> {
                    new TemplateOrRuleReference { TemplateIdentifier = "arn:aws:network-security-manager:us-east-1:123456789012:template:xyz789" }
                },
                IsPublished = true,
                PolicyConfiguration = new PolicyConfiguration {
                    RemediationEnabled = true,
                    ResourcesCleanUp = false,
                    WafConfig = new WafConfig {
                        ConflictResolution = "MERGE_WHERE_APPLICABLE",
                        ExistingCustomerWebACLResolution = "NO_REMEDIATION"
                    }
                },
                PolicyDescription = "WAF policy for web application protection - updated",
                PolicyIdentifier = "arn:aws:network-security-manager:us-east-1:123456789012:policy:xyz789",
                Priority = 2,
                UpdateToken = "e3f4a5b6-6c7d-4e8f-9a0b-0c1d2e3f4a5b"
            });

            string version = response.Version;
            List<AssociatedTemplateOrRule> associatedTemplateAndRuleList = response.AssociatedTemplateAndRuleList;
            string firewallType = response.FirewallType;
            bool hasPublishedVersion = response.HasPublishedVersion;
            bool isSnapshot = response.IsSnapshot;
            string policyArn = response.PolicyArn;
            PolicyConfiguration policyConfiguration = response.PolicyConfiguration;
            string policyDescription = response.PolicyDescription;
            string policyId = response.PolicyId;
            string policyName = response.PolicyName;
            int priority = response.Priority;
            string status = response.Status;
            string updateToken = response.UpdateToken;
            DateTime updatedAt = response.UpdatedAt;

            #endregion
        }

        public void NetworkSecurityManagerUpdateRule()
        {
            #region example-1

            var client = new AmazonNetworkSecurityManagerClient();
            var response = client.UpdateRule(new UpdateRuleRequest 
            {
                Configuration = new JsonDocument {  },
                IsPublished = true,
                RuleDescription = "Blocks requests from known malicious IP addresses - updated list",
                RuleIdentifier = "arn:aws:network-security-manager:us-east-1:123456789012:rule:abc123",
                RuleType = "INSPECTION",
                UpdateToken = "c1d2e3f4-4a5b-4c6d-9e7f-8a9b0c1d2e3f"
            });

            string version = response.Version;
            JsonDocument configuration = response.Configuration;
            string firewallType = response.FirewallType;
            bool hasPublishedVersion = response.HasPublishedVersion;
            bool isSnapshot = response.IsSnapshot;
            string ruleArn = response.RuleArn;
            string ruleDescription = response.RuleDescription;
            string ruleId = response.RuleId;
            string ruleName = response.RuleName;
            string ruleType = response.RuleType;
            string status = response.Status;
            string updateToken = response.UpdateToken;
            DateTime updatedAt = response.UpdatedAt;

            #endregion
        }

        public void NetworkSecurityManagerUpdateScope()
        {
            #region example-1

            var client = new AmazonNetworkSecurityManagerClient();
            var response = client.UpdateScope(new UpdateScopeRequest 
            {
                IsPublished = true,
                ScopeConfiguration = new ScopeConfiguration {
                    AccountFilter = new AccountFilter { IncludeAll = new Unit {  } },
                    ResourceScopes = new Dictionary<string, ResourceScope> {
                        
                    }
                },
                ScopeDescription = "Scope covering all production web application resources in US East 1",
                ScopeIdentifier = "arn:aws:network-security-manager:us-east-1:123456789012:scope:abc123",
                UpdateToken = "b0c4d1e2-3f4a-4b5c-8d6e-7f8a9b0c1d2e"
            });

            string version = response.Version;
            bool hasPublishedVersion = response.HasPublishedVersion;
            bool isSnapshot = response.IsSnapshot;
            string scopeArn = response.ScopeArn;
            ScopeConfiguration scopeConfiguration = response.ScopeConfiguration;
            string scopeDescription = response.ScopeDescription;
            string scopeId = response.ScopeId;
            string scopeName = response.ScopeName;
            string status = response.Status;
            string updateToken = response.UpdateToken;
            DateTime updatedAt = response.UpdatedAt;

            #endregion
        }

        public void NetworkSecurityManagerUpdateTemplate()
        {
            #region example-1

            var client = new AmazonNetworkSecurityManagerClient();
            var response = client.UpdateTemplate(new UpdateTemplateRequest 
            {
                AssociatedRuleList = new List<RuleReference> {
                    new RuleReference { RuleIdentifier = "arn:aws:network-security-manager:us-east-1:123456789012:rule:abc123" }
                },
                IsPublished = true,
                TemplateDescription = "Standard WAF template with baseline rule groups - updated",
                TemplateIdentifier = "arn:aws:network-security-manager:us-east-1:123456789012:template:xyz789",
                UpdateToken = "d2e3f4a5-5b6c-4d7e-8f9a-9b0c1d2e3f4a"
            });

            string version = response.Version;
            List<AssociatedRule> associatedRuleList = response.AssociatedRuleList;
            string firewallType = response.FirewallType;
            bool hasPublishedVersion = response.HasPublishedVersion;
            bool isSnapshot = response.IsSnapshot;
            string status = response.Status;
            string templateArn = response.TemplateArn;
            string templateDescription = response.TemplateDescription;
            string templateId = response.TemplateId;
            string templateName = response.TemplateName;
            string updateToken = response.UpdateToken;
            DateTime updatedAt = response.UpdatedAt;

            #endregion
        }

        
        # region ISample Members
        public virtual void Run()
        {

        }
        # endregion

    }
}