using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Amazon.CloudWatchOmni;
using Amazon.CloudWatchOmni.Model;

namespace AWSSDKDocSamples.Amazon.CloudWatchOmni.Generated
{
    class CloudWatchOmniSamples : ISample
    {
        public void CloudWatchOmniCreateAccessGrant()
        {
            #region example-1

            var client = new AmazonCloudWatchOmniClient();
            var response = client.CreateAccessGrant(new CreateAccessGrantRequest 
            {
                Name = "analyst-read-access",
                ClientToken = "3f2a9c1e-7b04-4d8a-9e15-6c2b8d0f4a73",
                DomainId = "d-1a2b3c4d5e",
                Permission = "CUSTOM",
                Principal = new AccessGrantPrincipal {
                    PrincipalId = "94b6c7d8-1a2b-4c3d-9e4f-5a6b7c8d9e0f",
                    PrincipalType = "IDC_USER"
                },
                ScopedActions = new List<ScopedActions> {
                    new ScopedActions {
                        Actions = new List<string> {
                            "cloudwatch:GetOmniDashboard",
                            "cloudwatch:UpdateOmniDashboard"
                        },
                        Resources = new List<ResourceScope> {
                            new ResourceScope {
                                ResourceArns = new List<string> {
                                    "arn:aws:cloudwatch:us-east-1:123456789012:omni-dashboard/c3d4e5f6-7a8b-4c9d-8e0f-1a2b3c4d5e6f"
                                },
                                ResourceType = "OmniDashboard"
                            }
                        }
                    }
                },
                SpaceId = "a1b2c3d4-5e6f-4a3b-8c9d-0e1f2a3b4c5d",
                Tags = new Dictionary<string, string> {
                    { "Team", "observability" }
                }
            });

            AccessGrant accessGrant = response.AccessGrant;

            #endregion
        }

        public void CloudWatchOmniCreateAccessProfile()
        {
            #region example-1

            var client = new AmazonCloudWatchOmniClient();
            var response = client.CreateAccessProfile(new CreateAccessProfileRequest 
            {
                Name = "Analyst read-only profile",
                ClientToken = "3f2a9c1e-7b04-4d8a-9e15-6c2b8d0f4a73",
                Description = "Read-only access for analysts.",
                SpaceId = "a1b2c3d4-5e6f-4a3b-8c9d-0e1f2a3b4c5d",
                Tags = new Dictionary<string, string> {
                    { "Team", "observability" }
                }
            });

            AccessProfile accessProfile = response.AccessProfile;

            #endregion
        }

        public void CloudWatchOmniCreateAlert()
        {
            #region example-1

            var client = new AmazonCloudWatchOmniClient();
            var response = client.CreateAlert(new CreateAlertRequest 
            {
                Name = "service-error-count-elevated",
                ClientToken = "3f2a9c1e-7b04-4d8a-9e15-6c2b8d0f4a73",
                Description = "Alerts when a service logs more errors than its accepted rate.",
                NotificationRules = new List<NotificationRule> {
                    new NotificationRule {
                        Target = new NotificationTarget {
                            Metadata = new Dictionary<string, string> {
                                { "channel", "oncall-alerts" }
                            },
                            Type = "slack",
                            Arn = "arn:aws:cloudwatch:us-east-1:123456789012:integration/a1b2c3d4-5e6f-4a3b-8c9d-0e1f2a3b4c5d"
                        },
                        Trigger = new NotificationTrigger { StateValues = new List<string> {
                            "CRITICAL"
                        } }
                    }
                },
                NotificationsEnabled = true,
                ProfileId = "analyst-readonly",
                Rule = new Rule { TelemetryRule = new TelemetryRule {
                    Condition = new AlertCondition {
                        Comparator = "GT",
                        CriticalThreshold = 200,
                        ThresholdField = "error_count",
                        ThresholdMode = "FIELD_VALUE",
                        WarningThreshold = 50
                    },
                    Evaluation = new AlertEvaluation {
                        IntervalSeconds = 300,
                        PendingDurationSeconds = 600,
                        RecoveryDurationSeconds = 300
                    },
                    NoData = new NoData { TreatAs = "NODATA" },
                    Query = new AlertRuleQuery {
                        Expression = "SELECT resource['attributes']['service.name'] AS service, COUNT(*) AS error_count FROM \"logs.default\" WHERE severityText = 'ERROR' GROUP BY service",
                        Language = "SQL"
                    }
                } },
                SpaceId = "a1b2c3d4-5e6f-4a3b-8c9d-0e1f2a3b4c5d",
                Tags = new Dictionary<string, string> {
                    { "Team", "observability" }
                }
            });

            Alert alert = response.Alert;

            #endregion
        }

        public void CloudWatchOmniCreateAlert()
        {
            #region example-2

            var client = new AmazonCloudWatchOmniClient();
            var response = client.CreateAlert(new CreateAlertRequest 
            {
                Name = "service-checkout-5xx-responses",
                Description = "Counts checkout responses that returned a server error.",
                NotificationsEnabled = false,
                ProfileId = "analyst-readonly",
                Rule = new Rule { TelemetryRule = new TelemetryRule {
                    Condition = new AlertCondition {
                        Comparator = "GT",
                        CriticalThreshold = 50,
                        ThresholdMode = "COUNT_OF_RESULTS",
                        WarningThreshold = 10
                    },
                    Evaluation = new AlertEvaluation {
                        IntervalSeconds = 60,
                        PendingDurationSeconds = 120
                    },
                    NoData = new NoData { TreatAs = "OK" },
                    Query = new AlertRuleQuery {
                        Expression = "SELECT * FROM \"logs.default\" WHERE resource['attributes']['service.name'] = 'checkout' AND attributes['http.response.status_code'] >= 500",
                        Language = "SQL"
                    }
                } },
                SpaceId = "a1b2c3d4-5e6f-4a3b-8c9d-0e1f2a3b4c5d"
            });

            Alert alert = response.Alert;

            #endregion
        }

        public void CloudWatchOmniCreateAlert()
        {
            #region example-3

            var client = new AmazonCloudWatchOmniClient();
            var response = client.CreateAlert(new CreateAlertRequest 
            {
                Name = "checkout-error-rate-promql",
                Description = "Alerts on the checkout server error rate over a five-minute window.",
                NotificationRules = new List<NotificationRule> {
                    new NotificationRule {
                        Target = new NotificationTarget {
                            Type = "sns",
                            Arn = "arn:aws:sns:us-east-1:123456789012:checkout-oncall"
                        },
                        Trigger = new NotificationTrigger { StateValues = new List<string> {
                            "WARNING",
                            "CRITICAL"
                        } }
                    }
                },
                ProfileId = "analyst-readonly",
                Rule = new Rule { TelemetryRule = new TelemetryRule {
                    Condition = new AlertCondition {
                        Comparator = "GT",
                        CriticalThreshold = 0.1,
                        ThresholdField = "value",
                        ThresholdMode = "FIELD_VALUE",
                        WarningThreshold = 0.05
                    },
                    Evaluation = new AlertEvaluation {
                        IntervalSeconds = 300,
                        PendingDurationSeconds = 300
                    },
                    NoData = new NoData { TreatAs = "NODATA" },
                    Query = new AlertRuleQuery {
                        Expression = "sum by (service_name) (rate(http_server_errors_total{service_name=\"checkout\"}[5m]))",
                        Language = "PROMQL"
                    }
                } },
                SpaceId = "a1b2c3d4-5e6f-4a3b-8c9d-0e1f2a3b4c5d"
            });

            Alert alert = response.Alert;

            #endregion
        }

        public void CloudWatchOmniCreateDomain()
        {
            #region example-1

            var client = new AmazonCloudWatchOmniClient();
            var response = client.CreateDomain(new CreateDomainRequest 
            {
                Name = "prod-observability",
                ClientToken = "3f2a9c1e-7b04-4d8a-9e15-6c2b8d0f4a73",
                IdentityProviderConfiguration = new IdentityProviderConfiguration { IdentityCenterConfiguration = new IdentityCenterConfiguration { IdentityCenterInstanceArn = "arn:aws:sso:::instance/ssoins-1234567890abcdef" } },
                IdentityProviders = new List<string> {
                    "IDC"
                },
                Tags = new Dictionary<string, string> {
                    { "Team", "observability" }
                }
            });

            Domain domain = response.Domain;

            #endregion
        }

        public void CloudWatchOmniCreateDomainAccessGrantForOrganization()
        {
            #region example-1

            var client = new AmazonCloudWatchOmniClient();
            var response = client.CreateDomainAccessGrantForOrganization(new CreateDomainAccessGrantForOrganizationRequest 
            {
                Name = "org-domain-admin",
                ClientToken = "3f2a9c1e-7b04-4d8a-9e15-6c2b8d0f4a73",
                DomainId = "d-1a2b3c4d5e",
                Permission = "ADMIN",
                Principal = new OrganizationAccessGrantPrincipal {
                    PrincipalId = "94b6c7d8-1a2b-4c3d-9e4f-5a6b7c8d9e0f",
                    PrincipalType = "IDC_USER"
                },
                Tags = new Dictionary<string, string> {
                    { "Team", "observability" }
                }
            });

            OrganizationAccessGrant accessGrant = response.AccessGrant;

            #endregion
        }

        public void CloudWatchOmniCreateDomainForOrganization()
        {
            #region example-1

            var client = new AmazonCloudWatchOmniClient();
            var response = client.CreateDomainForOrganization(new CreateDomainForOrganizationRequest 
            {
                Name = "prod-observability-org",
                ClientToken = "3f2a9c1e-7b04-4d8a-9e15-6c2b8d0f4a73",
                DomainAccessRoleArn = "arn:aws:iam::123456789012:role/CloudWatchOrganizationDomainAccessRole",
                IdentityProviderConfiguration = new IdentityProviderConfiguration { IdentityCenterConfiguration = new IdentityCenterConfiguration { IdentityCenterInstanceArn = "arn:aws:sso:::instance/ssoins-1234567890abcdef" } },
                IdentityProviders = new List<string> {
                    "IDC"
                },
                Tags = new Dictionary<string, string> {
                    { "Team", "observability" }
                }
            });

            OrganizationDomain organizationDomain = response.OrganizationDomain;

            #endregion
        }

        public void CloudWatchOmniCreateIntegration()
        {
            #region example-1

            var client = new AmazonCloudWatchOmniClient();
            var response = client.CreateIntegration(new CreateIntegrationRequest 
            {
                Name = "my-aws-integration",
                ClientToken = "b3f8c7d6-5b4a-4c3d-9e2f-1a0b2c3d4e5f",
                IntegrationType = "AWS_INTEGRATION",
                RoleArn = "arn:aws:iam::123456789012:role/service-role/CloudWatchIntegrationRole"
            });

            Integration integration = response.Integration;

            #endregion
        }

        public void CloudWatchOmniCreateOmniDashboard()
        {
            #region example-1

            var client = new AmazonCloudWatchOmniClient();
            var response = client.CreateOmniDashboard(new CreateOmniDashboardRequest 
            {
                Name = "service-health-overview",
                Body = "{\"widgets\":[{\"type\":\"metric\",\"x\":0,\"y\":0,\"width\":12,\"height\":6,\"properties\":{\"metrics\":[[\"AWS/Lambda\",\"Errors\",\"FunctionName\",\"OrderProcessor\"]],\"region\":\"us-east-1\",\"title\":\"Lambda Errors\"}}]}",
                ClientToken = "3f2a9c1e-7b04-4d8a-9e15-6c2b8d0f4a73",
                Description = "Overview of service health metrics.",
                SpaceId = "a1b2c3d4-5e6f-4a3b-8c9d-0e1f2a3b4c5d",
                Tags = new Dictionary<string, string> {
                    { "Team", "observability" }
                }
            });

            OmniDashboard omniDashboard = response.OmniDashboard;

            #endregion
        }

        public void CloudWatchOmniCreateOneTimeDeepLinkCode()
        {
            #region example-1

            var client = new AmazonCloudWatchOmniClient();
            var response = client.CreateOneTimeDeepLinkCode(new CreateOneTimeDeepLinkCodeRequest 
            {
                DomainId = "d-1a2b3c4d5e",
                RedirectUrl = "https://d-1a2b3c4d5e.cloudwatch-omni.global.app.aws/auth/callback",
                TtlSeconds = 300
            });

            string code = response.Code;
            string deepLinkUrl = response.DeepLinkUrl;
            DateTime expiresAt = response.ExpiresAt;

            #endregion
        }

        public void CloudWatchOmniCreateSpace()
        {
            #region example-1

            var client = new AmazonCloudWatchOmniClient();
            var response = client.CreateSpace(new CreateSpaceRequest 
            {
                Name = "prod-observability",
                AgentCoreEvaluationRoleArn = "arn:aws:iam::123456789012:role/CloudWatchAgentCoreEvaluationRole",
                ClientToken = "3f2a9c1e-7b04-4d8a-9e15-6c2b8d0f4a73",
                DataAccessRoleArn = "arn:aws:iam::123456789012:role/CloudWatchSpaceDataAccessRole",
                DomainId = "d-1a2b3c4d5e",
                EncryptionConfiguration = new EncryptionConfiguration {
                    EncryptionStrategy = "CUSTOMER_MANAGED",
                    KmsKeyArn = "arn:aws:kms:us-east-1:123456789012:key/1a2b3c4d-5e6f-4a3b-8c9d-0e1f2a3b4c5d"
                },
                Tags = new Dictionary<string, string> {
                    { "Team", "observability" }
                }
            });

            Space space = response.Space;

            #endregion
        }

        public void CloudWatchOmniCreateView()
        {
            #region example-1

            var client = new AmazonCloudWatchOmniClient();
            var response = client.CreateView(new CreateViewRequest 
            {
                Name = "view.service_errors",
                ClientToken = "3f2a9c1e-7b04-4d8a-9e15-6c2b8d0f4a73",
                Definition = "SELECT resource['attributes']['service.name'] AS service, COUNT(*) AS error_count FROM \"logs.default\" WHERE severityText = 'ERROR' GROUP BY service",
                Description = "Error counts by service",
                Tags = new Dictionary<string, string> {
                    { "Team", "observability" }
                }
            });

            string name = response.Name;
            string type = response.Type;
            string arn = response.Arn;
            DateTime createdAt = response.CreatedAt;
            string definition = response.Definition;
            string description = response.Description;
            DateTime updatedAt = response.UpdatedAt;

            #endregion
        }

        public void CloudWatchOmniDeleteAccessGrant()
        {
            #region example-1

            var client = new AmazonCloudWatchOmniClient();
            var response = client.DeleteAccessGrant(new DeleteAccessGrantRequest 
            {
                GrantId = "7f3e9d21-4c8b-4f6a-b1d2-3e4f5a6b7c8d"
            });


            #endregion
        }

        public void CloudWatchOmniDeleteAccessProfile()
        {
            #region example-1

            var client = new AmazonCloudWatchOmniClient();
            var response = client.DeleteAccessProfile(new DeleteAccessProfileRequest 
            {
                ProfileId = "analyst-readonly",
                SpaceId = "a1b2c3d4-5e6f-4a3b-8c9d-0e1f2a3b4c5d"
            });


            #endregion
        }

        public void CloudWatchOmniDeleteAlert()
        {
            #region example-1

            var client = new AmazonCloudWatchOmniClient();
            var response = client.DeleteAlert(new DeleteAlertRequest 
            {
                AlertId = "c3d4e5f67a8b4c9d8e0f1a2b3c4d5e6f",
                SpaceId = "a1b2c3d4-5e6f-4a3b-8c9d-0e1f2a3b4c5d"
            });


            #endregion
        }

        public void CloudWatchOmniDeleteDomain()
        {
            #region example-1

            var client = new AmazonCloudWatchOmniClient();
            var response = client.DeleteDomain(new DeleteDomainRequest 
            {
                DomainId = "d-1a2b3c4d5e"
            });


            #endregion
        }

        public void CloudWatchOmniDeleteDomainAccessGrantForOrganization()
        {
            #region example-1

            var client = new AmazonCloudWatchOmniClient();
            var response = client.DeleteDomainAccessGrantForOrganization(new DeleteDomainAccessGrantForOrganizationRequest 
            {
                GrantId = "7f3e9d21-4c8b-4f6a-b1d2-3e4f5a6b7c8d"
            });


            #endregion
        }

        public void CloudWatchOmniDeleteDomainForOrganization()
        {
            #region example-1

            var client = new AmazonCloudWatchOmniClient();
            var response = client.DeleteDomainForOrganization(new DeleteDomainForOrganizationRequest 
            {
                DomainId = "d-9z8y7x6w5v"
            });


            #endregion
        }

        public void CloudWatchOmniDeleteIntegration()
        {
            #region example-1

            var client = new AmazonCloudWatchOmniClient();
            var response = client.DeleteIntegration(new DeleteIntegrationRequest 
            {
                Identifier = new IntegrationIdentifier { IntegrationId = "a1b2c3d4-5e6f-4a3b-8c9d-0e1f2a3b4c5d" }
            });


            #endregion
        }

        public void CloudWatchOmniDeleteOmniDashboard()
        {
            #region example-1

            var client = new AmazonCloudWatchOmniClient();
            var response = client.DeleteOmniDashboard(new DeleteOmniDashboardRequest 
            {
                DashboardId = "c3d4e5f6-7a8b-4c9d-8e0f-1a2b3c4d5e6f",
                SpaceId = "a1b2c3d4-5e6f-4a3b-8c9d-0e1f2a3b4c5d"
            });


            #endregion
        }

        public void CloudWatchOmniDeleteSpace()
        {
            #region example-1

            var client = new AmazonCloudWatchOmniClient();
            var response = client.DeleteSpace(new DeleteSpaceRequest 
            {
                SpaceId = "a1b2c3d4-5e6f-4a3b-8c9d-0e1f2a3b4c5d"
            });


            #endregion
        }

        public void CloudWatchOmniDeleteView()
        {
            #region example-1

            var client = new AmazonCloudWatchOmniClient();
            var response = client.DeleteView(new DeleteViewRequest 
            {
                Name = "view.service_errors"
            });


            #endregion
        }

        public void CloudWatchOmniGetAccessGrant()
        {
            #region example-1

            var client = new AmazonCloudWatchOmniClient();
            var response = client.GetAccessGrant(new GetAccessGrantRequest 
            {
                GrantId = "7f3e9d21-4c8b-4f6a-b1d2-3e4f5a6b7c8d"
            });

            AccessGrant accessGrant = response.AccessGrant;

            #endregion
        }

        public void CloudWatchOmniGetAccessProfile()
        {
            #region example-1

            var client = new AmazonCloudWatchOmniClient();
            var response = client.GetAccessProfile(new GetAccessProfileRequest 
            {
                ProfileId = "analyst-readonly",
                SpaceId = "a1b2c3d4-5e6f-4a3b-8c9d-0e1f2a3b4c5d"
            });

            AccessProfile accessProfile = response.AccessProfile;

            #endregion
        }

        public void CloudWatchOmniGetAlert()
        {
            #region example-1

            var client = new AmazonCloudWatchOmniClient();
            var response = client.GetAlert(new GetAlertRequest 
            {
                AlertId = "c3d4e5f67a8b4c9d8e0f1a2b3c4d5e6f",
                SpaceId = "a1b2c3d4-5e6f-4a3b-8c9d-0e1f2a3b4c5d"
            });

            Alert alert = response.Alert;

            #endregion
        }

        public void CloudWatchOmniGetContextGraph()
        {
            #region example-1

            var client = new AmazonCloudWatchOmniClient();
            var response = client.GetContextGraph(new GetContextGraphRequest 
            {
                Depth = 1,
                EndTime = new DateTime(2026, 9, 16, 1, 0, 0, DateTimeKind.Utc),
                IncludeMetadata = false,
                MaxResults = 100,
                NodeFilters = new NodeFilters {
                    Namespace = new List<string> {
                        "ecommerce"
                    },
                    NodeType = "SERVICE"
                },
                StartTime = new DateTime(2026, 9, 16, 12, 0, 0, DateTimeKind.Utc)
            });

            string nextToken = response.NextToken;
            List<Node> nodes = response.Nodes;

            #endregion
        }

        public void CloudWatchOmniGetDomain()
        {
            #region example-1

            var client = new AmazonCloudWatchOmniClient();
            var response = client.GetDomain(new GetDomainRequest 
            {
                DomainId = "d-1a2b3c4d5e"
            });

            Domain domain = response.Domain;

            #endregion
        }

        public void CloudWatchOmniGetDomainAccessGrantForOrganization()
        {
            #region example-1

            var client = new AmazonCloudWatchOmniClient();
            var response = client.GetDomainAccessGrantForOrganization(new GetDomainAccessGrantForOrganizationRequest 
            {
                GrantId = "7f3e9d21-4c8b-4f6a-b1d2-3e4f5a6b7c8d"
            });

            OrganizationAccessGrant accessGrant = response.AccessGrant;

            #endregion
        }

        public void CloudWatchOmniGetDomainForOrganization()
        {
            #region example-1

            var client = new AmazonCloudWatchOmniClient();
            var response = client.GetDomainForOrganization(new GetDomainForOrganizationRequest 
            {
                DomainId = "d-9z8y7x6w5v"
            });

            OrganizationDomain organizationDomain = response.OrganizationDomain;

            #endregion
        }

        public void CloudWatchOmniGetIntegration()
        {
            #region example-1

            var client = new AmazonCloudWatchOmniClient();
            var response = client.GetIntegration(new GetIntegrationRequest 
            {
                Identifier = new IntegrationIdentifier { IntegrationId = "a1b2c3d4-5e6f-4a3b-8c9d-0e1f2a3b4c5d" }
            });

            Integration integration = response.Integration;

            #endregion
        }

        public void CloudWatchOmniGetIntelligenceConfiguration()
        {
            #region example-1

            var client = new AmazonCloudWatchOmniClient();
            var response = client.GetIntelligenceConfiguration(new GetIntelligenceConfigurationRequest 
            {
            });

            string accountId = response.AccountId;
            DateTime createdAt = response.CreatedAt;
            string kmsKeyArn = response.KmsKeyArn;
            DateTime updatedAt = response.UpdatedAt;

            #endregion
        }

        public void CloudWatchOmniGetOmniDashboard()
        {
            #region example-1

            var client = new AmazonCloudWatchOmniClient();
            var response = client.GetOmniDashboard(new GetOmniDashboardRequest 
            {
                DashboardId = "c3d4e5f6-7a8b-4c9d-8e0f-1a2b3c4d5e6f",
                SpaceId = "a1b2c3d4-5e6f-4a3b-8c9d-0e1f2a3b4c5d"
            });

            OmniDashboard omniDashboard = response.OmniDashboard;

            #endregion
        }

        public void CloudWatchOmniGetSpace()
        {
            #region example-1

            var client = new AmazonCloudWatchOmniClient();
            var response = client.GetSpace(new GetSpaceRequest 
            {
                SpaceId = "a1b2c3d4-5e6f-4a3b-8c9d-0e1f2a3b4c5d"
            });

            Space space = response.Space;

            #endregion
        }

        public void CloudWatchOmniGetSpaceCredentialsForOrganization()
        {
            #region example-1

            var client = new AmazonCloudWatchOmniClient();
            var response = client.GetSpaceCredentialsForOrganization(new GetSpaceCredentialsForOrganizationRequest 
            {
                Context = new SpaceCredentialRequestContext { SpaceId = "a1b2c3d4-5e6f-4a3b-8c9d-0e1f2a3b4c5d" },
                CredentialType = "SPACE_OPERATION"
            });

            AwsCredentials credentials = response.Credentials;

            #endregion
        }

        public void CloudWatchOmniGetTelemetryQueryResults()
        {
            #region example-1

            var client = new AmazonCloudWatchOmniClient();
            var response = client.GetTelemetryQueryResults(new GetTelemetryQueryResultsRequest 
            {
                MaxResults = 100,
                QueryId = "3b2a1c0d-7e6f-4a5b-8c9d-0e1f2a3b4c5d"
            });

            List<Dictionary<string, string>> rows = response.Rows;
            QueryStatistics statistics = response.Statistics;
            string status = response.Status;

            #endregion
        }

        public void CloudWatchOmniGetView()
        {
            #region example-1

            var client = new AmazonCloudWatchOmniClient();
            var response = client.GetView(new GetViewRequest 
            {
                Name = "view.service_errors"
            });

            string name = response.Name;
            string type = response.Type;
            string arn = response.Arn;
            DateTime createdAt = response.CreatedAt;
            string definition = response.Definition;
            string description = response.Description;
            DateTime updatedAt = response.UpdatedAt;

            #endregion
        }

        public void CloudWatchOmniListAccessGrants()
        {
            #region example-1

            var client = new AmazonCloudWatchOmniClient();
            var response = client.ListAccessGrants(new ListAccessGrantsRequest 
            {
                DomainId = "d-1a2b3c4d5e",
                MaxResults = 50,
                SpaceId = "a1b2c3d4-5e6f-4a3b-8c9d-0e1f2a3b4c5d"
            });

            List<AccessGrantSummary> items = response.Items;
            string nextToken = response.NextToken;

            #endregion
        }

        public void CloudWatchOmniListAccessProfiles()
        {
            #region example-1

            var client = new AmazonCloudWatchOmniClient();
            var response = client.ListAccessProfiles(new ListAccessProfilesRequest 
            {
                MaxResults = 50,
                SpaceId = "a1b2c3d4-5e6f-4a3b-8c9d-0e1f2a3b4c5d"
            });

            List<AccessProfileSummary> items = response.Items;
            string nextToken = response.NextToken;

            #endregion
        }

        public void CloudWatchOmniListAlerts()
        {
            #region example-1

            var client = new AmazonCloudWatchOmniClient();
            var response = client.ListAlerts(new ListAlertsRequest 
            {
                FilterCriteria = new AlertFilterCriteria {
                    NamePrefix = "service-",
                    StateValue = new List<string> {
                        "WARNING",
                        "CRITICAL"
                    }
                },
                MaxResults = 50,
                SortBy = "STATE",
                SortOrder = "DESC",
                SpaceId = "a1b2c3d4-5e6f-4a3b-8c9d-0e1f2a3b4c5d"
            });

            List<AlertSummary> items = response.Items;
            string nextToken = response.NextToken;

            #endregion
        }

        public void CloudWatchOmniListDomainAccessGrantsForOrganization()
        {
            #region example-1

            var client = new AmazonCloudWatchOmniClient();
            var response = client.ListDomainAccessGrantsForOrganization(new ListDomainAccessGrantsForOrganizationRequest 
            {
                DomainId = "d-1a2b3c4d5e",
                MaxResults = 50
            });

            List<OrganizationAccessGrantSummary> items = response.Items;
            string nextToken = response.NextToken;

            #endregion
        }

        public void CloudWatchOmniListDomains()
        {
            #region example-1

            var client = new AmazonCloudWatchOmniClient();
            var response = client.ListDomains(new ListDomainsRequest 
            {
            });

            List<DomainSummary> items = response.Items;

            #endregion
        }

        public void CloudWatchOmniListIntegrations()
        {
            #region example-1

            var client = new AmazonCloudWatchOmniClient();
            var response = client.ListIntegrations(new ListIntegrationsRequest 
            {
                IntegrationType = "AWS_INTEGRATION",
                MaxResults = 20
            });

            List<Integration> items = response.Items;
            string nextToken = response.NextToken;

            #endregion
        }

        public void CloudWatchOmniListOmniDashboards()
        {
            #region example-1

            var client = new AmazonCloudWatchOmniClient();
            var response = client.ListOmniDashboards(new ListOmniDashboardsRequest 
            {
                MaxResults = 50,
                SpaceId = "a1b2c3d4-5e6f-4a3b-8c9d-0e1f2a3b4c5d"
            });

            List<OmniDashboardSummary> items = response.Items;
            string nextToken = response.NextToken;

            #endregion
        }

        public void CloudWatchOmniListSpaces()
        {
            #region example-1

            var client = new AmazonCloudWatchOmniClient();
            var response = client.ListSpaces(new ListSpacesRequest 
            {
                DomainId = "d-1a2b3c4d5e",
                MaxResults = 50
            });

            List<SpaceSummary> items = response.Items;
            string nextToken = response.NextToken;

            #endregion
        }

        public void CloudWatchOmniListSpacesForOrganization()
        {
            #region example-1

            var client = new AmazonCloudWatchOmniClient();
            var response = client.ListSpacesForOrganization(new ListSpacesForOrganizationRequest 
            {
                MaxResults = 50
            });

            List<SpaceSummary> items = response.Items;
            string nextToken = response.NextToken;

            #endregion
        }

        public void CloudWatchOmniListTelemetryFields()
        {
            #region example-1

            var client = new AmazonCloudWatchOmniClient();
            var response = client.ListTelemetryFields(new ListTelemetryFieldsRequest 
            {
                DataSetName = "default",
                TelemetryType = "LOGS"
            });

            List<Field> fields = response.Fields;

            #endregion
        }

        public void CloudWatchOmniListTelemetryQuerySessions()
        {
            #region example-1

            var client = new AmazonCloudWatchOmniClient();
            var response = client.ListTelemetryQuerySessions(new ListTelemetryQuerySessionsRequest 
            {
                MaxResults = 10
            });

            string nextToken = response.NextToken;
            List<SessionSummary> sessions = response.Sessions;

            #endregion
        }

        public void CloudWatchOmniListViews()
        {
            #region example-1

            var client = new AmazonCloudWatchOmniClient();
            var response = client.ListViews(new ListViewsRequest 
            {
                Type = "USER",
                MaxResults = 10
            });

            List<ViewSummary> items = response.Items;
            string nextToken = response.NextToken;

            #endregion
        }

        public void CloudWatchOmniPutIntelligenceConfiguration()
        {
            #region example-1

            var client = new AmazonCloudWatchOmniClient();
            var response = client.PutIntelligenceConfiguration(new PutIntelligenceConfigurationRequest 
            {
                ClientToken = "b3f8c7d6-5b4a-4c3d-9e2f-1a0b2c3d4e5f",
                KmsKeyArn = "arn:aws:kms:us-east-1:123456789012:key/1a2b3c4d-5e6f-4a3b-8c9d-0e1f2a3b4c5d"
            });

            string accountId = response.AccountId;
            DateTime createdAt = response.CreatedAt;
            string kmsKeyArn = response.KmsKeyArn;
            DateTime updatedAt = response.UpdatedAt;

            #endregion
        }

        public void CloudWatchOmniSearchPrincipals()
        {
            #region example-1

            var client = new AmazonCloudWatchOmniClient();
            var response = client.SearchPrincipals(new SearchPrincipalsRequest 
            {
                DomainId = "d-1a2b3c4d5e",
                SearchQuery = "jane"
            });

            List<PrincipalSearchResult> results = response.Results;

            #endregion
        }

        public void CloudWatchOmniStartTelemetryQuery()
        {
            #region example-1

            var client = new AmazonCloudWatchOmniClient();
            var response = client.StartTelemetryQuery(new StartTelemetryQueryRequest 
            {
                QueryString = "SELECT `@timestamp`, `@message` FROM \"logs.default\" WHERE `@timestamp` BETWEEN NOW() - INTERVAL '1 HOUR' AND NOW() ORDER BY `@timestamp` DESC LIMIT 100",
                SessionId = "9f8c7d6e-5b4a-4c3d-9e2f-1a0b2c3d4e5f"
            });

            string queryId = response.QueryId;
            string sessionId = response.SessionId;

            #endregion
        }

        public void CloudWatchOmniStartTelemetryQuerySession()
        {
            #region example-1

            var client = new AmazonCloudWatchOmniClient();
            var response = client.StartTelemetryQuerySession(new StartTelemetryQuerySessionRequest 
            {
                SessionName = "prod-latency-investigation"
            });

            string sessionId = response.SessionId;

            #endregion
        }

        public void CloudWatchOmniStopTelemetryQuery()
        {
            #region example-1

            var client = new AmazonCloudWatchOmniClient();
            var response = client.StopTelemetryQuery(new StopTelemetryQueryRequest 
            {
                QueryId = "3b2a1c0d-7e6f-4a5b-8c9d-0e1f2a3b4c5d"
            });


            #endregion
        }

        public void CloudWatchOmniStopTelemetryQuerySession()
        {
            #region example-1

            var client = new AmazonCloudWatchOmniClient();
            var response = client.StopTelemetryQuerySession(new StopTelemetryQuerySessionRequest 
            {
                SessionId = "9f8c7d6e-5b4a-4c3d-9e2f-1a0b2c3d4e5f"
            });


            #endregion
        }

        public void CloudWatchOmniUpdateAccessProfile()
        {
            #region example-1

            var client = new AmazonCloudWatchOmniClient();
            var response = client.UpdateAccessProfile(new UpdateAccessProfileRequest 
            {
                Description = "Read-only access for analysts and on-call responders.",
                ProfileId = "analyst-readonly",
                SpaceId = "a1b2c3d4-5e6f-4a3b-8c9d-0e1f2a3b4c5d"
            });

            AccessProfile accessProfile = response.AccessProfile;

            #endregion
        }

        public void CloudWatchOmniUpdateAlert()
        {
            #region example-1

            var client = new AmazonCloudWatchOmniClient();
            var response = client.UpdateAlert(new UpdateAlertRequest 
            {
                AlertId = "c3d4e5f67a8b4c9d8e0f1a2b3c4d5e6f",
                Rule = new Rule { TelemetryRule = new TelemetryRule { Condition = new AlertCondition {
                    Comparator = "GT",
                    CriticalThreshold = 400,
                    ThresholdField = "error_count",
                    ThresholdMode = "FIELD_VALUE",
                    WarningThreshold = 100
                } } },
                SpaceId = "a1b2c3d4-5e6f-4a3b-8c9d-0e1f2a3b4c5d"
            });


            #endregion
        }

        public void CloudWatchOmniUpdateDomain()
        {
            #region example-1

            var client = new AmazonCloudWatchOmniClient();
            var response = client.UpdateDomain(new UpdateDomainRequest 
            {
                Name = "prod-observability-metrics",
                DomainId = "d-1a2b3c4d5e"
            });

            Domain domain = response.Domain;

            #endregion
        }

        public void CloudWatchOmniUpdateDomainForOrganization()
        {
            #region example-1

            var client = new AmazonCloudWatchOmniClient();
            var response = client.UpdateDomainForOrganization(new UpdateDomainForOrganizationRequest 
            {
                Name = "prod-observability-org-metrics",
                DomainId = "d-9z8y7x6w5v"
            });

            OrganizationDomain organizationDomain = response.OrganizationDomain;

            #endregion
        }

        public void CloudWatchOmniUpdateIntegration()
        {
            #region example-1

            var client = new AmazonCloudWatchOmniClient();
            var response = client.UpdateIntegration(new UpdateIntegrationRequest 
            {
                Identifier = new IntegrationIdentifier { IntegrationId = "a1b2c3d4-5e6f-4a3b-8c9d-0e1f2a3b4c5d" },
                IntegrationAttributes = new Dictionary<string, string> {
                    { "notificationChannel", "ops-oncall" }
                }
            });

            Integration integration = response.Integration;

            #endregion
        }

        public void CloudWatchOmniUpdateOmniDashboard()
        {
            #region example-1

            var client = new AmazonCloudWatchOmniClient();
            var response = client.UpdateOmniDashboard(new UpdateOmniDashboardRequest 
            {
                Body = "{\"widgets\":[{\"type\":\"metric\",\"x\":0,\"y\":0,\"width\":24,\"height\":6,\"properties\":{\"metrics\":[[\"AWS/Lambda\",\"Errors\",\"FunctionName\",\"OrderProcessor\"],[\"AWS/Lambda\",\"Throttles\",\"FunctionName\",\"OrderProcessor\"]],\"region\":\"us-east-1\",\"title\":\"Lambda Errors and Throttles\"}}]}",
                DashboardId = "c3d4e5f6-7a8b-4c9d-8e0f-1a2b3c4d5e6f",
                SpaceId = "a1b2c3d4-5e6f-4a3b-8c9d-0e1f2a3b4c5d"
            });

            OmniDashboard omniDashboard = response.OmniDashboard;

            #endregion
        }

        public void CloudWatchOmniUpdateSpace()
        {
            #region example-1

            var client = new AmazonCloudWatchOmniClient();
            var response = client.UpdateSpace(new UpdateSpaceRequest 
            {
                Name = "prod-observability-team",
                SpaceId = "a1b2c3d4-5e6f-4a3b-8c9d-0e1f2a3b4c5d"
            });

            Space space = response.Space;

            #endregion
        }

        public void CloudWatchOmniUpdateView()
        {
            #region example-1

            var client = new AmazonCloudWatchOmniClient();
            var response = client.UpdateView(new UpdateViewRequest 
            {
                Name = "view.service_errors",
                Definition = "SELECT resource['attributes']['service.name'] AS service, COUNT(*) AS error_count FROM \"logs.default\" WHERE status['code'] IN ('2', 'ERROR') GROUP BY service"
            });

            string name = response.Name;
            string type = response.Type;
            string arn = response.Arn;
            DateTime createdAt = response.CreatedAt;
            string definition = response.Definition;
            string description = response.Description;
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