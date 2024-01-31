using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Amazon.CloudFormation;
using Amazon.CloudFormation.Model;

namespace AWSSDKDocSamples.Amazon.CloudFormation.Generated
{
    class CloudFormationSamples : ISample
    {
        public void CloudFormationCreateGeneratedTemplate()
        {
            #region to-create-a-generated-template

            var client = new AmazonCloudFormationClient();
            var response = client.CreateGeneratedTemplate(new CreateGeneratedTemplateRequest 
            {
                GeneratedTemplateName = "JazzyTemplate",
                Resources = new List<ResourceDefinition> {
                    new ResourceDefinition {
                        ResourceIdentifier = new Dictionary<string, string> {
                            { "BucketName", "jazz-bucket" }
                        },
                        ResourceType = "AWS::S3::Bucket"
                    },
                    new ResourceDefinition {
                        ResourceIdentifier = new Dictionary<string, string> {
                            { "DhcpOptionsId", "random-id123" }
                        },
                        ResourceType = "AWS::EC2::DHCPOptions"
                    }
                }
            });

            string generatedTemplateId = response.GeneratedTemplateId;

            #endregion
        }

        public void CloudFormationDeleteGeneratedTemplate()
        {
            #region to-delete-a-generated-template

            var client = new AmazonCloudFormationClient();
            var response = client.DeleteGeneratedTemplate(new DeleteGeneratedTemplateRequest 
            {
                GeneratedTemplateName = "JazzyTemplate"
            });


            #endregion
        }

        public void CloudFormationDescribeGeneratedTemplate()
        {
            #region to-describe-a-generated-template

            var client = new AmazonCloudFormationClient();
            var response = client.DescribeGeneratedTemplate(new DescribeGeneratedTemplateRequest 
            {
                GeneratedTemplateName = "JazzyTemplate"
            });

            DateTime creationTime = response.CreationTime;
            string generatedTemplateId = response.GeneratedTemplateId;
            string generatedTemplateName = response.GeneratedTemplateName;
            DateTime lastUpdatedTime = response.LastUpdatedTime;
            TemplateProgress progress = response.Progress;
            string status = response.Status;
            string statusReason = response.StatusReason;
            TemplateConfiguration templateConfiguration = response.TemplateConfiguration;
            int totalWarnings = response.TotalWarnings;

            #endregion
        }

        public void CloudFormationDescribeResourceScan()
        {
            #region to-describe-a-generated-template

            var client = new AmazonCloudFormationClient();
            var response = client.DescribeResourceScan(new DescribeResourceScanRequest 
            {
                ResourceScanId = "arn:aws:cloudformation:us-east-1:123456789012:resourceScan/c19304f6-c4f1-4ff8-8e1f-35162e41d7e1"
            });

            DateTime endTime = response.EndTime;
            double percentageCompleted = response.PercentageCompleted;
            string resourceScanId = response.ResourceScanId;
            List<string> resourceTypes = response.ResourceTypes;
            int resourcesRead = response.ResourcesRead;
            DateTime startTime = response.StartTime;
            string status = response.Status;

            #endregion
        }

        public void CloudFormationGetGeneratedTemplate()
        {
            #region to-get-a-generated-template-json

            var client = new AmazonCloudFormationClient();
            var response = client.GetGeneratedTemplate(new GetGeneratedTemplateRequest 
            {
                GeneratedTemplateName = "JazzyTemplate"
            });

            string status = response.Status;
            string templateBody = response.TemplateBody;

            #endregion
        }

        public void CloudFormationGetGeneratedTemplate()
        {
            #region to-get-a-generated-template-yaml

            var client = new AmazonCloudFormationClient();
            var response = client.GetGeneratedTemplate(new GetGeneratedTemplateRequest 
            {
                Format = "YAML",
                GeneratedTemplateName = "JazzyTemplate"
            });

            string status = response.Status;
            string templateBody = response.TemplateBody;

            #endregion
        }

        public void CloudFormationListGeneratedTemplates()
        {
            #region to-list-generated-templates

            var client = new AmazonCloudFormationClient();
            var response = client.ListGeneratedTemplates(new ListGeneratedTemplatesRequest 
            {
            });

            List<TemplateSummary> summaries = response.Summaries;

            #endregion
        }

        public void CloudFormationListResourceScanRelatedResources()
        {
            #region to-list-resource-scan-related-resources

            var client = new AmazonCloudFormationClient();
            var response = client.ListResourceScanRelatedResources(new ListResourceScanRelatedResourcesRequest 
            {
                ResourceScanId = "arn:aws:cloudformation:us-east-1:123456789012:resourceScan/c19304f6-c4f1-4ff8-8e1f-35162e41d7e1",
                Resources = new List<ScannedResourceIdentifier> {
                    new ScannedResourceIdentifier {
                        ResourceIdentifier = new Dictionary<string, string> {
                            { "BucketName", "jazz-bucket" }
                        },
                        ResourceType = "AWS::S3::Bucket"
                    },
                    new ScannedResourceIdentifier {
                        ResourceIdentifier = new Dictionary<string, string> {
                            { "DhcpOptionsId", "random-id123" }
                        },
                        ResourceType = "AWS::EC2::DHCPOptions"
                    }
                }
            });

            List<ScannedResource> relatedResources = response.RelatedResources;

            #endregion
        }

        public void CloudFormationListResourceScanResources()
        {
            #region to-list-resource-scan-resources

            var client = new AmazonCloudFormationClient();
            var response = client.ListResourceScanResources(new ListResourceScanResourcesRequest 
            {
                ResourceScanId = "arn:aws:cloudformation:us-east-1:123456789012:resourceScan/c19304f6-c4f1-4ff8-8e1f-35162e41d7e1"
            });

            string nextToken = response.NextToken;
            List<ScannedResource> resources = response.Resources;

            #endregion
        }

        public void CloudFormationListResourceScanResources()
        {
            #region to-list-resource-scan-resources-with-resource-type-prefix

            var client = new AmazonCloudFormationClient();
            var response = client.ListResourceScanResources(new ListResourceScanResourcesRequest 
            {
                ResourceScanId = "arn:aws:cloudformation:us-east-1:123456789012:resourceScan/c19304f6-c4f1-4ff8-8e1f-35162e41d7e1",
                ResourceTypePrefix = "AWS::S3"
            });

            string nextToken = response.NextToken;
            List<ScannedResource> resources = response.Resources;

            #endregion
        }

        public void CloudFormationListResourceScans()
        {
            #region to-list-resource-scans

            var client = new AmazonCloudFormationClient();
            var response = client.ListResourceScans(new ListResourceScansRequest 
            {
            });

            List<ResourceScanSummary> resourceScanSummaries = response.ResourceScanSummaries;

            #endregion
        }

        public void CloudFormationStartResourceScan()
        {
            #region to-start-a-generated-template

            var client = new AmazonCloudFormationClient();
            var response = client.StartResourceScan(new StartResourceScanRequest 
            {
            });

            string resourceScanId = response.ResourceScanId;

            #endregion
        }

        public void CloudFormationUpdateGeneratedTemplate()
        {
            #region to-update-a-generated-template-new-name

            var client = new AmazonCloudFormationClient();
            var response = client.UpdateGeneratedTemplate(new UpdateGeneratedTemplateRequest 
            {
                GeneratedTemplateName = "JazzyTemplate",
                NewGeneratedTemplateName = "JazzierTemplate"
            });

            string generatedTemplateId = response.GeneratedTemplateId;

            #endregion
        }

        public void CloudFormationUpdateGeneratedTemplate()
        {
            #region to-update-a-generated-template-remove-resources

            var client = new AmazonCloudFormationClient();
            var response = client.UpdateGeneratedTemplate(new UpdateGeneratedTemplateRequest 
            {
                GeneratedTemplateName = "JazzyTemplate",
                RemoveResources = new List<string> {
                    "LogicalResourceId1",
                    "LogicalResourceId2"
                }
            });

            string generatedTemplateId = response.GeneratedTemplateId;

            #endregion
        }

        public void CloudFormationUpdateGeneratedTemplate()
        {
            #region to-update-a-generated-template-add-resources

            var client = new AmazonCloudFormationClient();
            var response = client.UpdateGeneratedTemplate(new UpdateGeneratedTemplateRequest 
            {
                AddResources = new List<ResourceDefinition> {
                    new ResourceDefinition {
                        ResourceIdentifier = new Dictionary<string, string> {
                            { "BucketName", "jazz-bucket" }
                        },
                        ResourceType = "AWS::S3::Bucket"
                    },
                    new ResourceDefinition {
                        ResourceIdentifier = new Dictionary<string, string> {
                            { "DhcpOptionsId", "random-id123" }
                        },
                        ResourceType = "AWS::EC2::DHCPOptions"
                    }
                },
                GeneratedTemplateName = "JazzyTemplate"
            });

            string generatedTemplateId = response.GeneratedTemplateId;

            #endregion
        }

        
        # region ISample Members
        public virtual void Run()
        {

        }
        # endregion

    }
}