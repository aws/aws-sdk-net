using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Amazon.BCMDashboards;
using Amazon.BCMDashboards.Model;

namespace AWSSDKDocSamples.Amazon.BCMDashboards.Generated
{
    class BCMDashboardsSamples : ISample
    {
        public void BCMDashboardsCreateDashboard()
        {
            #region example-1

            var client = new AmazonBCMDashboardsClient();
            var response = client.CreateDashboard(new CreateDashboardRequest 
            {
                Name = "cost-dashboards",
                Description = "Dashboard for tracking costs",
                Widgets = new List<Widget> {
                    new Widget {
                        Configs = new List<WidgetConfig> {
                            new WidgetConfig {
                                DisplayConfig = new DisplayConfig { Graph = new Dictionary<string, GraphDisplayConfig> {
                                    { "costTrend", new GraphDisplayConfig { VisualType = "LINE" } }
                                } },
                                QueryParameters = new QueryParameters { CostAndUsage = new CostAndUsageQuery {
                                    Granularity = "MONTHLY",
                                    GroupBy = new List<GroupDefinition> {
                                        new GroupDefinition {
                                            Type = "DIMENSION",
                                            Key = "SERVICE"
                                        }
                                    },
                                    Metrics = new List<string> {
                                        "UnblendedCost"
                                    },
                                    TimeRange = new DateTimeRange {
                                        EndTime = new DateTimeValue {
                                            Type = "RELATIVE",
                                            Value = "now"
                                        },
                                        StartTime = new DateTimeValue {
                                            Type = "RELATIVE",
                                            Value = "-9M"
                                        }
                                    }
                                } }
                            }
                        },
                        Height = 7,
                        HorizontalOffset = 0,
                        Title = "Monthly Cost Trend",
                        Width = 4
                    }
                }
            });


            #endregion
        }

        public void BCMDashboardsDeleteDashboard()
        {
            #region example-1

            var client = new AmazonBCMDashboardsClient();
            var response = client.DeleteDashboard(new DeleteDashboardRequest 
            {
                Arn = "arn:aws:bcm-dashboards::123456789012:dashboard/abcd1234-ab12-12ab-1ab2-abcd1234efgh"
            });

            string arn = response.Arn;

            #endregion
        }

        public void BCMDashboardsGetDashboard()
        {
            #region example-1

            var client = new AmazonBCMDashboardsClient();
            var response = client.GetDashboard(new GetDashboardRequest 
            {
                Arn = "arn:aws:bcm-dashboards::123456789012:dashboard/abcd1234-ab12-12ab-1ab2-abcd1234efgh"
            });

            string name = response.Name;
            string type = response.Type;
            string arn = response.Arn;
            DateTime createdAt = response.CreatedAt;
            string description = response.Description;
            DateTime updatedAt = response.UpdatedAt;
            List<Widget> widgets = response.Widgets;

            #endregion
        }

        public void BCMDashboardsGetResourcePolicy()
        {
            #region example-1

            var client = new AmazonBCMDashboardsClient();
            var response = client.GetResourcePolicy(new GetResourcePolicyRequest 
            {
                ResourceArn = "arn:aws:bcm-dashboards::123456789012:dashboard/abcd1234-ab12-12ab-1ab2-abcd1234efgh"
            });

            string policyDocument = response.PolicyDocument;
            string resourceArn = response.ResourceArn;

            #endregion
        }

        public void BCMDashboardsListDashboards()
        {
            #region example-1

            var client = new AmazonBCMDashboardsClient();
            var response = client.ListDashboards(new ListDashboardsRequest 
            {
            });

            List<DashboardReference> dashboards = response.Dashboards;

            #endregion
        }

        public void BCMDashboardsListTagsForResource()
        {
            #region example-1

            var client = new AmazonBCMDashboardsClient();
            var response = client.ListTagsForResource(new ListTagsForResourceRequest 
            {
                ResourceArn = "arn:aws:bcm-dashboards::123456789012:dashboard/abcd1234-ab12-12ab-1ab2-abcd1234efgh"
            });

            List<ResourceTag> resourceTags = response.ResourceTags;

            #endregion
        }

        public void BCMDashboardsTagResource()
        {
            #region example-1

            var client = new AmazonBCMDashboardsClient();
            var response = client.TagResource(new TagResourceRequest 
            {
                ResourceArn = "arn:aws:bcm-dashboards::123456789012:dashboard/abcd1234-ab12-12ab-1ab2-abcd1234efgh",
                ResourceTags = new List<ResourceTag> {
                    new ResourceTag {
                        Key = "keyOne",
                        Value = "valueOne"
                    }
                }
            });


            #endregion
        }

        public void BCMDashboardsUntagResource()
        {
            #region example-1

            var client = new AmazonBCMDashboardsClient();
            var response = client.UntagResource(new UntagResourceRequest 
            {
                ResourceArn = "arn:aws:bcm-dashboards::123456789012:dashboard/abcd1234-ab12-12ab-1ab2-abcd1234efgh",
                ResourceTagKeys = new List<string> {
                    "keyOne"
                }
            });


            #endregion
        }

        public void BCMDashboardsUpdateDashboard()
        {
            #region example-1

            var client = new AmazonBCMDashboardsClient();
            var response = client.UpdateDashboard(new UpdateDashboardRequest 
            {
                Name = "cost-dashboards-updated",
                Arn = "arn:aws:bcm-dashboards::123456789012:dashboard/abcd1234-ab12-12ab-1ab2-abcd1234efgh",
                Description = "Dashboard for tracking costs version 2",
                Widgets = new List<Widget> {
                    new Widget {
                        Configs = new List<WidgetConfig> {
                            new WidgetConfig {
                                DisplayConfig = new DisplayConfig { Graph = new Dictionary<string, GraphDisplayConfig> {
                                    { "costTrend", new GraphDisplayConfig { VisualType = "LINE" } }
                                } },
                                QueryParameters = new QueryParameters { CostAndUsage = new CostAndUsageQuery {
                                    Granularity = "MONTHLY",
                                    GroupBy = new List<GroupDefinition> {
                                        new GroupDefinition {
                                            Type = "DIMENSION",
                                            Key = "SERVICE"
                                        }
                                    },
                                    Metrics = new List<string> {
                                        "UnblendedCost"
                                    },
                                    TimeRange = new DateTimeRange {
                                        EndTime = new DateTimeValue {
                                            Type = "RELATIVE",
                                            Value = "now"
                                        },
                                        StartTime = new DateTimeValue {
                                            Type = "RELATIVE",
                                            Value = "-3M"
                                        }
                                    }
                                } }
                            }
                        },
                        Height = 7,
                        HorizontalOffset = 2,
                        Title = "Monthly Cost Trend",
                        Width = 4
                    }
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