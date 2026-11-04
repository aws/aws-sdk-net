using System;
using System.Collections.Generic;
using System.IO;
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
            #region CreateGeneratedTemplate-1

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
            #region DeleteGeneratedTemplate-1

            var client = new AmazonCloudFormationClient();
            var response = client.DeleteGeneratedTemplate(new DeleteGeneratedTemplateRequest
            {
                GeneratedTemplateName = "JazzyTemplate"
            });


            #endregion
        }

        public void CloudFormationGetGeneratedTemplate()
        {
            #region GetGeneratedTemplate-1

            var client = new AmazonCloudFormationClient();
            var response = client.GetGeneratedTemplate(new GetGeneratedTemplateRequest
            {
                GeneratedTemplateName = "JazzyTemplate"
            });

            GeneratedTemplateStatus status = response.Status;
            string templateBody = response.TemplateBody;

            #endregion
        }

        public void CloudFormationGetGeneratedTemplate()
        {
            #region GetGeneratedTemplate-2

            var client = new AmazonCloudFormationClient();
            var response = client.GetGeneratedTemplate(new GetGeneratedTemplateRequest
            {
                Format = "YAML",
                GeneratedTemplateName = "JazzyTemplate"
            });

            GeneratedTemplateStatus status = response.Status;
            string templateBody = response.TemplateBody;

            #endregion
        }

        public void CloudFormationListResourceScanRelatedResources()
        {
            #region ListResourceScanRelatedResources-1

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
            #region ListResourceScanResources-1

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
            #region ListResourceScanResources-2

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

        public void CloudFormationStartResourceScan()
        {
            #region StartResourceScan-1

            var client = new AmazonCloudFormationClient();
            var response = client.StartResourceScan(new StartResourceScanRequest
            {
            });

            string resourceScanId = response.ResourceScanId;

            #endregion
        }

        public void CloudFormationUpdateGeneratedTemplate()
        {
            #region UpdateGeneratedTemplate-1

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

        public void CloudFormationUpdateGeneratedTemplate()
        {
            #region UpdateGeneratedTemplate-2

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
            #region UpdateGeneratedTemplate-3

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

        #region ISample Members
        public virtual void Run()
        {
        }
        #endregion
    }
}
