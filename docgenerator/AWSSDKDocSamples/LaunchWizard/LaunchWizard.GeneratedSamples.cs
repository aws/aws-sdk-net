using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Amazon.LaunchWizard;
using Amazon.LaunchWizard.Model;

namespace AWSSDKDocSamples.Amazon.LaunchWizard.Generated
{
    class LaunchWizardSamples : ISample
    {
        public void LaunchWizardCreateDeployment()
        {
            #region example-1

            var client = new AmazonLaunchWizardClient();
            var response = client.CreateDeployment(new CreateDeploymentRequest 
            {
                Name = "TestDeployment1",
                DeploymentPatternName = "SapHanaSingle",
                DryRun = false,
                Specifications = new Dictionary<string, string> {
                    { "CreateSecurityGroup", "No" },
                    { "DisableDeploymentRollback", "Yes" },
                    { "EnableEbsVolumeEncryption", "Yes" },
                    { "KeyPairName", "keyName" },
                    { "ProxyServerAddress", "http://xyz.abc.com:8080" },
                    { "SapSysGroupId", "5003" },
                    { "SapVirtualIPOptIn", "No" },
                    { "SaveDeploymentArtifacts", "No" },
                    { "SnsTopicArn", "arn:aws:sns:us-east-1:111111222222:snsNameUsEast1.fifo" },
                    { "Timezone", "Pacific/Wake" },
                    { "VpcId", "vpc-1234566" }
                },
                WorkloadName = "SAP"
            });

            string deploymentId = response.DeploymentId;

            #endregion
        }

        public void LaunchWizardCreateDeployment()
        {
            #region example-2

            var client = new AmazonLaunchWizardClient();
            var response = client.CreateDeployment(new CreateDeploymentRequest 
            {
                Name = "TestDeployment2",
                DeploymentPatternName = "SapHanaSingle",
                DryRun = false,
                Specifications = new Dictionary<string, string> {
                    { "CreateSecurityGroup", "No" },
                    { "DisableDeploymentRollback", "Yes" },
                    { "EnableEbsVolumeEncryption", "Yes" },
                    { "KeyPairName", "keyName" },
                    { "ProxyServerAddress", "http://xyz.abc.com:8080" },
                    { "SapSysGroupId", "5003" },
                    { "SapVirtualIPOptIn", "No" },
                    { "SaveDeploymentArtifacts", "No" },
                    { "SnsTopicArn", "arn:aws:sns:us-east-1:111111222222:snsNameUsEast1.fifo" },
                    { "Timezone", "Pacific/Wake" },
                    { "VpcId", "vpc-1234566" }
                },
                Tags = new Dictionary<string, string> {
                    { "key1", "val1" },
                    { "key2", "val2" }
                },
                WorkloadName = "SAP"
            });

            string deploymentId = response.DeploymentId;

            #endregion
        }

        public void LaunchWizardDeleteDeployment()
        {
            #region example-1

            var client = new AmazonLaunchWizardClient();
            var response = client.DeleteDeployment(new DeleteDeploymentRequest 
            {
                DeploymentId = "4c1b59c1-659c-467f-b6e9-6ef6f9d28e1d"
            });

            string status = response.Status;
            string statusReason = response.StatusReason;

            #endregion
        }

        public void LaunchWizardGetDeployment()
        {
            #region example-1

            var client = new AmazonLaunchWizardClient();
            var response = client.GetDeployment(new GetDeploymentRequest 
            {
                DeploymentId = "1111111-1111-1111-1111-111111111111"
            });

            DeploymentData deployment = response.Deployment;

            #endregion
        }

        public void LaunchWizardGetWorkload()
        {
            #region example-1

            var client = new AmazonLaunchWizardClient();
            var response = client.GetWorkload(new GetWorkloadRequest 
            {
                WorkloadName = "SAP"
            });

            WorkloadData workload = response.Workload;

            #endregion
        }

        public void LaunchWizardGetWorkloadDeploymentPattern()
        {
            #region example-1

            var client = new AmazonLaunchWizardClient();
            var response = client.GetWorkloadDeploymentPattern(new GetWorkloadDeploymentPatternRequest 
            {
                DeploymentPatternName = "adSelfManagedNewVpc",
                WorkloadName = "MicrosoftActiveDirectory"
            });

            WorkloadDeploymentPatternData workloadDeploymentPattern = response.WorkloadDeploymentPattern;

            #endregion
        }

        public void LaunchWizardListDeploymentEvents()
        {
            #region example-1

            var client = new AmazonLaunchWizardClient();
            var response = client.ListDeploymentEvents(new ListDeploymentEventsRequest 
            {
                DeploymentId = "4c1b59c1-659c-467f-b6e9-6ef6f9d28e1d"
            });

            List<DeploymentEventDataSummary> deploymentEvents = response.DeploymentEvents;

            #endregion
        }

        public void LaunchWizardListDeploymentPatternVersions()
        {
            #region example-1

            var client = new AmazonLaunchWizardClient();
            var response = client.ListDeploymentPatternVersions(new ListDeploymentPatternVersionsRequest 
            {
                DeploymentPatternName = "default",
                WorkloadName = "security-automations-for-aws-waf"
            });

            List<DeploymentPatternVersionDataSummary> deploymentPatternVersions = response.DeploymentPatternVersions;

            #endregion
        }

        public void LaunchWizardListDeploymentPatternVersions()
        {
            #region example-2

            var client = new AmazonLaunchWizardClient();
            var response = client.ListDeploymentPatternVersions(new ListDeploymentPatternVersionsRequest 
            {
                DeploymentPatternName = "default",
                Filters = new List<DeploymentPatternVersionFilter> {
                    new DeploymentPatternVersionFilter {
                        Name = "updateFromVersion",
                        Values = new List<string> {
                            "4.0.2"
                        }
                    }
                },
                WorkloadName = "security-automations-for-aws-waf"
            });

            List<DeploymentPatternVersionDataSummary> deploymentPatternVersions = response.DeploymentPatternVersions;

            #endregion
        }

        public void LaunchWizardListDeployments()
        {
            #region example-1

            var client = new AmazonLaunchWizardClient();
            var response = client.ListDeployments(new ListDeploymentsRequest 
            {
                Filters = new List<DeploymentFilter> {
                    new DeploymentFilter {
                        Name = "DEPLOYMENT_STATUS",
                        Values = new List<string> {
                            "IN_PROGRESS"
                        }
                    }
                }
            });

            List<DeploymentDataSummary> deployments = response.Deployments;

            #endregion
        }

        public void LaunchWizardListTagsForResource()
        {
            #region example-1

            var client = new AmazonLaunchWizardClient();
            var response = client.ListTagsForResource(new ListTagsForResourceRequest 
            {
                ResourceArn = "arn:aws:launchwizard:us-east-1:123456789012:deployment/11111111-1111-1111-1111-111111111111"
            });

            Dictionary<string, string> tags = response.Tags;

            #endregion
        }

        public void LaunchWizardListWorkloadDeploymentPatterns()
        {
            #region example-1

            var client = new AmazonLaunchWizardClient();
            var response = client.ListWorkloadDeploymentPatterns(new ListWorkloadDeploymentPatternsRequest 
            {
                WorkloadName = "SAP"
            });

            List<WorkloadDeploymentPatternDataSummary> workloadDeploymentPatterns = response.WorkloadDeploymentPatterns;

            #endregion
        }

        public void LaunchWizardListWorkloads()
        {
            #region example-1

            var client = new AmazonLaunchWizardClient();
            var response = client.ListWorkloads(new ListWorkloadsRequest 
            {
            });

            List<WorkloadDataSummary> workloads = response.Workloads;

            #endregion
        }

        public void LaunchWizardTagResource()
        {
            #region example-1

            var client = new AmazonLaunchWizardClient();
            var response = client.TagResource(new TagResourceRequest 
            {
                ResourceArn = "arn:aws:launchwizard:us-east-1:123456789012:deployment/11111111-1111-1111-1111-111111111111",
                Tags = new Dictionary<string, string> {
                    { "key1", "value1" },
                    { "key2", "value2" }
                }
            });


            #endregion
        }

        public void LaunchWizardUntagResource()
        {
            #region example-1

            var client = new AmazonLaunchWizardClient();
            var response = client.UntagResource(new UntagResourceRequest 
            {
                ResourceArn = "arn:aws:launchwizard:us-east-1:123456789012:deployment/11111111-1111-1111-1111-111111111111",
                TagKeys = new List<string> {
                    "key1",
                    "key2"
                }
            });


            #endregion
        }

        public void LaunchWizardUpdateDeployment()
        {
            #region example-1

            var client = new AmazonLaunchWizardClient();
            var response = client.UpdateDeployment(new UpdateDeploymentRequest 
            {
                DeploymentId = "4c1b59c1-659c-467f-b6e9-6ef6f9d28e1d",
                DryRun = false,
                Specifications = new Dictionary<string, string> {
                    { "CreateSecurityGroup", "No" },
                    { "DeploymentArtifactsS3Uri", "aws-bucket-name" },
                    { "DisableDeploymentRollback", "No" },
                    { "EnableEbsVolumeEncryption", "No" },
                    { "KeyPairName", "keyName" },
                    { "ProxyServerAddress", "http://mno.abc.com:8080" },
                    { "SapSysGroupId", "5003" },
                    { "SapVirtualIPOptIn", "No" },
                    { "SaveDeploymentArtifacts", "Yes" },
                    { "SnsTopicArn", "arn:aws:sns:us-east-1:111111222222:snsNameUsEast1.fifo" },
                    { "Timezone", "Pacific/Wake" },
                    { "VpcId", "vpc-1234567" }
                }
            });

            DeploymentDataSummary deployment = response.Deployment;

            #endregion
        }

        public void LaunchWizardUpdateDeployment()
        {
            #region example-2

            var client = new AmazonLaunchWizardClient();
            var response = client.UpdateDeployment(new UpdateDeploymentRequest 
            {
                DeploymentId = "4c1b59c1-659c-467f-b6e9-6ef6f9d28e1d",
                DeploymentPatternVersionName = "2.0.0",
                DryRun = false,
                Specifications = new Dictionary<string, string> {
                    { "CreateSecurityGroup", "No" },
                    { "DeploymentArtifactsS3Uri", "aws-bucket-name" },
                    { "DisableDeploymentRollback", "No" },
                    { "EnableEbsVolumeEncryption", "No" },
                    { "KeyPairName", "keyName" },
                    { "NewParameter", "Allow" },
                    { "ProxyServerAddress", "http://mno.abc.com:8080" },
                    { "SapSysGroupId", "5003" },
                    { "SapVirtualIPOptIn", "No" },
                    { "SaveDeploymentArtifacts", "Yes" },
                    { "SnsTopicArn", "arn:aws:sns:us-east-1:111111222222:snsNameUsEast1.fifo" },
                    { "Timezone", "Pacific/Wake" },
                    { "VpcId", "vpc-1234567" }
                }
            });

            DeploymentDataSummary deployment = response.Deployment;

            #endregion
        }

        
        # region ISample Members
        public virtual void Run()
        {

        }
        # endregion

    }
}