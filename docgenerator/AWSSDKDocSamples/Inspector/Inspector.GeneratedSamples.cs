using System;
using System.Collections.Generic;
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
            #region add-attributes-to-findings-1481063856401

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
            #region create-assessment-target-1481063953657

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
            #region create-assessment-template-1481064046719

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
            #region create-resource-group-1481064169037

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
            #region delete-assessment-run-1481064251629

            var client = new AmazonInspectorClient();
            var response = client.DeleteAssessmentRun(new DeleteAssessmentRunRequest 
            {
                AssessmentRunArn = "arn:aws:inspector:us-west-2:123456789012:target/0-nvgVhaxX/template/0-it5r2S4T/run/0-11LMTAVe"
            });


            #endregion
        }

        public void InspectorDeleteAssessmentTarget()
        {
            #region delete-assessment-target-1481064309029

            var client = new AmazonInspectorClient();
            var response = client.DeleteAssessmentTarget(new DeleteAssessmentTargetRequest 
            {
                AssessmentTargetArn = "arn:aws:inspector:us-west-2:123456789012:target/0-0kFIPusq"
            });


            #endregion
        }

        public void InspectorDeleteAssessmentTemplate()
        {
            #region delete-assessment-template-1481064364074

            var client = new AmazonInspectorClient();
            var response = client.DeleteAssessmentTemplate(new DeleteAssessmentTemplateRequest 
            {
                AssessmentTemplateArn = "arn:aws:inspector:us-west-2:123456789012:target/0-nvgVhaxX/template/0-it5r2S4T"
            });


            #endregion
        }

        public void InspectorDescribeAssessmentRuns()
        {
            #region describte-assessment-runs-1481064424352

            var client = new AmazonInspectorClient();
            var response = client.DescribeAssessmentRuns(new DescribeAssessmentRunsRequest 
            {
                AssessmentRunArns = new List<string> {
                    "arn:aws:inspector:us-west-2:123456789012:target/0-0kFIPusq/template/0-4r1V2mAw/run/0-MKkpXXPE"
                }
            });

            List<AssessmentRun> assessmentRuns = response.AssessmentRuns;
            Dictionary<string, FailedItemDetails> failedItems = response.FailedItems;

            #endregion
        }

        public void InspectorDescribeAssessmentTargets()
        {
            #region describte-assessment-targets-1481064527735

            var client = new AmazonInspectorClient();
            var response = client.DescribeAssessmentTargets(new DescribeAssessmentTargetsRequest 
            {
                AssessmentTargetArns = new List<string> {
                    "arn:aws:inspector:us-west-2:123456789012:target/0-0kFIPusq"
                }
            });

            List<AssessmentTarget> assessmentTargets = response.AssessmentTargets;
            Dictionary<string, FailedItemDetails> failedItems = response.FailedItems;

            #endregion
        }

        public void InspectorDescribeAssessmentTemplates()
        {
            #region describte-assessment-templates-1481064606829

            var client = new AmazonInspectorClient();
            var response = client.DescribeAssessmentTemplates(new DescribeAssessmentTemplatesRequest 
            {
                AssessmentTemplateArns = new List<string> {
                    "arn:aws:inspector:us-west-2:123456789012:target/0-0kFIPusq/template/0-4r1V2mAw"
                }
            });

            List<AssessmentTemplate> assessmentTemplates = response.AssessmentTemplates;
            Dictionary<string, FailedItemDetails> failedItems = response.FailedItems;

            #endregion
        }

        public void InspectorDescribeCrossAccountAccessRole()
        {
            #region describte-cross-account-access-role-1481064682267

            var client = new AmazonInspectorClient();
            var response = client.DescribeCrossAccountAccessRole(new DescribeCrossAccountAccessRoleRequest 
            {
            });

            DateTime registeredAt = response.RegisteredAt;
            string roleArn = response.RoleArn;
            bool valid = response.Valid;

            #endregion
        }

        public void InspectorDescribeFindings()
        {
            #region describte-findings-1481064771803

            var client = new AmazonInspectorClient();
            var response = client.DescribeFindings(new DescribeFindingsRequest 
            {
                FindingArns = new List<string> {
                    "arn:aws:inspector:us-west-2:123456789012:target/0-0kFIPusq/template/0-4r1V2mAw/run/0-MKkpXXPE/finding/0-HwPnsDm4"
                }
            });

            Dictionary<string, FailedItemDetails> failedItems = response.FailedItems;
            List<Finding> findings = response.Findings;

            #endregion
        }

        public void InspectorDescribeResourceGroups()
        {
            #region describe-resource-groups-1481065787743

            var client = new AmazonInspectorClient();
            var response = client.DescribeResourceGroups(new DescribeResourceGroupsRequest 
            {
                ResourceGroupArns = new List<string> {
                    "arn:aws:inspector:us-west-2:123456789012:resourcegroup/0-PyGXopAI"
                }
            });

            Dictionary<string, FailedItemDetails> failedItems = response.FailedItems;
            List<ResourceGroup> resourceGroups = response.ResourceGroups;

            #endregion
        }

        public void InspectorDescribeRulesPackages()
        {
            #region describe-rules-packages-1481069641979

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
            #region get-telemetry-metadata-1481066021297

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
            #region list-assessment-run-agents-1481918140642

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
            #region list-assessment-runs-1481066340844

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
            #region list-assessment-targets-1481066540849

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
            #region list-assessment-templates-1481066623520

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

        public void InspectorListEventSubscriptions()
        {
            #region list-event-subscriptions-1481068376945

            var client = new AmazonInspectorClient();
            var response = client.ListEventSubscriptions(new ListEventSubscriptionsRequest 
            {
                MaxResults = 123,
                ResourceArn = "arn:aws:inspector:us-west-2:123456789012:target/0-nvgVhaxX/template/0-7sbz2Kz0"
            });

            string nextToken = response.NextToken;
            List<Subscription> subscriptions = response.Subscriptions;

            #endregion
        }

        public void InspectorListFindings()
        {
            #region list-findings-1481066840611

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
            #region list-rules-packages-1481066954883

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
            #region list-tags-for-resource-1481067025240

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
            #region preview-agents-1481067101888

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
            #region register-cross-account-access-role-1481067178301

            var client = new AmazonInspectorClient();
            var response = client.RegisterCrossAccountAccessRole(new RegisterCrossAccountAccessRoleRequest 
            {
                RoleArn = "arn:aws:iam::123456789012:role/inspector"
            });


            #endregion
        }

        public void InspectorRemoveAttributesFromFindings()
        {
            #region remove-attributes-from-findings-1481067246548

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
            #region set-tags-for-resource-1481067329646

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
            #region start-assessment-run-1481067407484

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
            #region stop-assessment-run-1481067502857

            var client = new AmazonInspectorClient();
            var response = client.StopAssessmentRun(new StopAssessmentRunRequest 
            {
                AssessmentRunArn = "arn:aws:inspector:us-west-2:123456789012:target/0-nvgVhaxX/template/0-it5r2S4T/run/0-11LMTAVe"
            });


            #endregion
        }

        public void InspectorSubscribeToEvent()
        {
            #region subscribe-to-event-1481067686031

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
            #region unsubscribe-from-event-1481067781705

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
            #region update-assessment-target-1481067866692

            var client = new AmazonInspectorClient();
            var response = client.UpdateAssessmentTarget(new UpdateAssessmentTargetRequest 
            {
                AssessmentTargetArn = "arn:aws:inspector:us-west-2:123456789012:target/0-nvgVhaxX",
                AssessmentTargetName = "Example",
                ResourceGroupArn = "arn:aws:inspector:us-west-2:123456789012:resourcegroup/0-yNbgL5Pt"
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