using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Amazon.Inspector;
using Amazon.Inspector.Model;

namespace AWSSDKDocSamples.Amazon.Inspector.Generated
{
    class InspectorSamples : ISample
    {
        public void InspectorAddAttributesToFindings()
        {
            #region AddAttributesToFindings-1

            var client = new AmazonInspectorClient();
            var response = client.AddAttributesToFindings(new AddAttributesToFindingsRequest
            {
                Attributes = new List<Attribute> {
                    new Attribute {
                        Key = "Example",
                        Value = "example"
                    }
                },
                FindingArns = new List<string> {
                    "arn:aws:inspector:us-west-2:123456789012:target/0-0kFIPusq/template/0-8l1VIE0D/run/0-Z02cjjug/finding/0-T8yM9mEU"
                }
            });

            Dictionary<string, FailedItemDetails> failedItems = response.FailedItems;

            #endregion
        }

        public void InspectorCreateAssessmentTarget()
        {
            #region CreateAssessmentTarget-1

            var client = new AmazonInspectorClient();
            var response = client.CreateAssessmentTarget(new CreateAssessmentTargetRequest
            {
                AssessmentTargetName = "ExampleAssessmentTarget",
                ResourceGroupArn = "arn:aws:inspector:us-west-2:123456789012:resourcegroup/0-AB6DMKnv"
            });

            string assessmentTargetArn = response.AssessmentTargetArn;

            #endregion
        }

        public void InspectorCreateAssessmentTemplate()
        {
            #region CreateAssessmentTemplate-1

            var client = new AmazonInspectorClient();
            var response = client.CreateAssessmentTemplate(new CreateAssessmentTemplateRequest
            {
                AssessmentTargetArn = "arn:aws:inspector:us-west-2:123456789012:target/0-nvgVhaxX",
                AssessmentTemplateName = "ExampleAssessmentTemplate",
                DurationInSeconds = 180,
                RulesPackageArns = new List<string> {
                    "arn:aws:inspector:us-west-2:758058086616:rulespackage/0-11B9DBXp"
                },
                UserAttributesForFindings = new List<Attribute> {
                    new Attribute {
                        Key = "Example",
                        Value = "example"
                    }
                }
            });

            string assessmentTemplateArn = response.AssessmentTemplateArn;

            #endregion
        }

        public void InspectorCreateResourceGroup()
        {
            #region CreateResourceGroup-1

            var client = new AmazonInspectorClient();
            var response = client.CreateResourceGroup(new CreateResourceGroupRequest
            {
                ResourceGroupTags = new List<ResourceGroupTag> {
                    new ResourceGroupTag {
                        Key = "Name",
                        Value = "example"
                    }
                }
            });

            string resourceGroupArn = response.ResourceGroupArn;

            #endregion
        }

        public void InspectorDeleteAssessmentRun()
        {
            #region DeleteAssessmentRun-1

            var client = new AmazonInspectorClient();
            var response = client.DeleteAssessmentRun(new DeleteAssessmentRunRequest
            {
                AssessmentRunArn = "arn:aws:inspector:us-west-2:123456789012:target/0-nvgVhaxX/template/0-it5r2S4T/run/0-11LMTAVe"
            });


            #endregion
        }

        public void InspectorDeleteAssessmentTarget()
        {
            #region DeleteAssessmentTarget-1

            var client = new AmazonInspectorClient();
            var response = client.DeleteAssessmentTarget(new DeleteAssessmentTargetRequest
            {
                AssessmentTargetArn = "arn:aws:inspector:us-west-2:123456789012:target/0-0kFIPusq"
            });


            #endregion
        }

        public void InspectorDeleteAssessmentTemplate()
        {
            #region DeleteAssessmentTemplate-1

            var client = new AmazonInspectorClient();
            var response = client.DeleteAssessmentTemplate(new DeleteAssessmentTemplateRequest
            {
                AssessmentTemplateArn = "arn:aws:inspector:us-west-2:123456789012:target/0-nvgVhaxX/template/0-it5r2S4T"
            });


            #endregion
        }

        public void InspectorDescribeRulesPackages()
        {
            #region DescribeRulesPackages-1

            var client = new AmazonInspectorClient();
            var response = client.DescribeRulesPackages(new DescribeRulesPackagesRequest
            {
                RulesPackageArns = new List<string> {
                    "arn:aws:inspector:us-west-2:758058086616:rulespackage/0-JJOtZiqQ"
                }
            });

            Dictionary<string, FailedItemDetails> failedItems = response.FailedItems;
            List<RulesPackage> rulesPackages = response.RulesPackages;

            #endregion
        }

        public void InspectorGetTelemetryMetadata()
        {
            #region GetTelemetryMetadata-1

            var client = new AmazonInspectorClient();
            var response = client.GetTelemetryMetadata(new GetTelemetryMetadataRequest
            {
                AssessmentRunArn = "arn:aws:inspector:us-west-2:123456789012:target/0-0kFIPusq/template/0-4r1V2mAw/run/0-MKkpXXPE"
            });

            List<TelemetryMetadata> telemetryMetadata = response.TelemetryMetadata;

            #endregion
        }

        public void InspectorListAssessmentRunAgents()
        {
            #region ListAssessmentRunAgents-1

            var client = new AmazonInspectorClient();
            var response = client.ListAssessmentRunAgents(new ListAssessmentRunAgentsRequest
            {
                AssessmentRunArn = "arn:aws:inspector:us-west-2:123456789012:target/0-0kFIPusq/template/0-4r1V2mAw/run/0-MKkpXXPE",
                MaxResults = 123
            });

            List<AssessmentRunAgent> assessmentRunAgents = response.AssessmentRunAgents;
            string nextToken = response.NextToken;

            #endregion
        }

        public void InspectorListAssessmentRuns()
        {
            #region ListAssessmentRuns-1

            var client = new AmazonInspectorClient();
            var response = client.ListAssessmentRuns(new ListAssessmentRunsRequest
            {
                AssessmentTemplateArns = new List<string> {
                    "arn:aws:inspector:us-west-2:123456789012:target/0-0kFIPusq/template/0-4r1V2mAw"
                },
                MaxResults = 123
            });

            List<string> assessmentRunArns = response.AssessmentRunArns;
            string nextToken = response.NextToken;

            #endregion
        }

        public void InspectorListAssessmentTargets()
        {
            #region ListAssessmentTargets-1

            var client = new AmazonInspectorClient();
            var response = client.ListAssessmentTargets(new ListAssessmentTargetsRequest
            {
                MaxResults = 123
            });

            List<string> assessmentTargetArns = response.AssessmentTargetArns;
            string nextToken = response.NextToken;

            #endregion
        }

        public void InspectorListAssessmentTemplates()
        {
            #region ListAssessmentTemplates-1

            var client = new AmazonInspectorClient();
            var response = client.ListAssessmentTemplates(new ListAssessmentTemplatesRequest
            {
                AssessmentTargetArns = new List<string> {
                    "arn:aws:inspector:us-west-2:123456789012:target/0-0kFIPusq"
                },
                MaxResults = 123
            });

            List<string> assessmentTemplateArns = response.AssessmentTemplateArns;
            string nextToken = response.NextToken;

            #endregion
        }

        public void InspectorListFindings()
        {
            #region ListFindings-1

            var client = new AmazonInspectorClient();
            var response = client.ListFindings(new ListFindingsRequest
            {
                AssessmentRunArns = new List<string> {
                    "arn:aws:inspector:us-west-2:123456789012:target/0-0kFIPusq/template/0-4r1V2mAw/run/0-MKkpXXPE"
                },
                MaxResults = 123
            });

            List<string> findingArns = response.FindingArns;
            string nextToken = response.NextToken;

            #endregion
        }

        public void InspectorListRulesPackages()
        {
            #region ListRulesPackages-1

            var client = new AmazonInspectorClient();
            var response = client.ListRulesPackages(new ListRulesPackagesRequest
            {
                MaxResults = 123
            });

            string nextToken = response.NextToken;
            List<string> rulesPackageArns = response.RulesPackageArns;

            #endregion
        }

        public void InspectorListTagsForResource()
        {
            #region ListTagsForResource-1

            var client = new AmazonInspectorClient();
            var response = client.ListTagsForResource(new ListTagsForResourceRequest
            {
                ResourceArn = "arn:aws:inspector:us-west-2:123456789012:target/0-0kFIPusq/template/0-gcwFliYu"
            });

            List<Tag> tags = response.Tags;

            #endregion
        }

        public void InspectorPreviewAgents()
        {
            #region PreviewAgents-1

            var client = new AmazonInspectorClient();
            var response = client.PreviewAgents(new PreviewAgentsRequest
            {
                MaxResults = 123,
                PreviewAgentsArn = "arn:aws:inspector:us-west-2:123456789012:target/0-0kFIPusq"
            });

            List<AgentPreview> agentPreviews = response.AgentPreviews;
            string nextToken = response.NextToken;

            #endregion
        }

        public void InspectorRegisterCrossAccountAccessRole()
        {
            #region RegisterCrossAccountAccessRole-1

            var client = new AmazonInspectorClient();
            var response = client.RegisterCrossAccountAccessRole(new RegisterCrossAccountAccessRoleRequest
            {
                RoleArn = "arn:aws:iam::123456789012:role/inspector"
            });


            #endregion
        }

        public void InspectorRemoveAttributesFromFindings()
        {
            #region RemoveAttributesFromFindings-1

            var client = new AmazonInspectorClient();
            var response = client.RemoveAttributesFromFindings(new RemoveAttributesFromFindingsRequest
            {
                AttributeKeys = new List<string> {
                    "key=Example,value=example"
                },
                FindingArns = new List<string> {
                    "arn:aws:inspector:us-west-2:123456789012:target/0-0kFIPusq/template/0-8l1VIE0D/run/0-Z02cjjug/finding/0-T8yM9mEU"
                }
            });

            Dictionary<string, FailedItemDetails> failedItems = response.FailedItems;

            #endregion
        }

        public void InspectorSetTagsForResource()
        {
            #region SetTagsForResource-1

            var client = new AmazonInspectorClient();
            var response = client.SetTagsForResource(new SetTagsForResourceRequest
            {
                ResourceArn = "arn:aws:inspector:us-west-2:123456789012:target/0-nvgVhaxX/template/0-7sbz2Kz0",
                Tags = new List<Tag> {
                    new Tag {
                        Key = "Example",
                        Value = "example"
                    }
                }
            });


            #endregion
        }

        public void InspectorStartAssessmentRun()
        {
            #region StartAssessmentRun-1

            var client = new AmazonInspectorClient();
            var response = client.StartAssessmentRun(new StartAssessmentRunRequest
            {
                AssessmentRunName = "examplerun",
                AssessmentTemplateArn = "arn:aws:inspector:us-west-2:123456789012:target/0-nvgVhaxX/template/0-it5r2S4T"
            });

            string assessmentRunArn = response.AssessmentRunArn;

            #endregion
        }

        public void InspectorStopAssessmentRun()
        {
            #region StopAssessmentRun-1

            var client = new AmazonInspectorClient();
            var response = client.StopAssessmentRun(new StopAssessmentRunRequest
            {
                AssessmentRunArn = "arn:aws:inspector:us-west-2:123456789012:target/0-nvgVhaxX/template/0-it5r2S4T/run/0-11LMTAVe"
            });


            #endregion
        }

        public void InspectorSubscribeToEvent()
        {
            #region SubscribeToEvent-1

            var client = new AmazonInspectorClient();
            var response = client.SubscribeToEvent(new SubscribeToEventRequest
            {
                Event = "ASSESSMENT_RUN_COMPLETED",
                ResourceArn = "arn:aws:inspector:us-west-2:123456789012:target/0-nvgVhaxX/template/0-7sbz2Kz0",
                TopicArn = "arn:aws:sns:us-west-2:123456789012:exampletopic"
            });


            #endregion
        }

        public void InspectorUnsubscribeFromEvent()
        {
            #region UnsubscribeFromEvent-1

            var client = new AmazonInspectorClient();
            var response = client.UnsubscribeFromEvent(new UnsubscribeFromEventRequest
            {
                Event = "ASSESSMENT_RUN_COMPLETED",
                ResourceArn = "arn:aws:inspector:us-west-2:123456789012:target/0-nvgVhaxX/template/0-7sbz2Kz0",
                TopicArn = "arn:aws:sns:us-west-2:123456789012:exampletopic"
            });


            #endregion
        }

        public void InspectorUpdateAssessmentTarget()
        {
            #region UpdateAssessmentTarget-1

            var client = new AmazonInspectorClient();
            var response = client.UpdateAssessmentTarget(new UpdateAssessmentTargetRequest
            {
                AssessmentTargetArn = "arn:aws:inspector:us-west-2:123456789012:target/0-nvgVhaxX",
                AssessmentTargetName = "Example",
                ResourceGroupArn = "arn:aws:inspector:us-west-2:123456789012:resourcegroup/0-yNbgL5Pt"
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
