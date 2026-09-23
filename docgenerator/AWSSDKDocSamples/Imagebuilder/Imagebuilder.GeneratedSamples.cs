using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Amazon.Imagebuilder;
using Amazon.Imagebuilder.Model;

namespace AWSSDKDocSamples.Amazon.Imagebuilder.Generated
{
    class ImagebuilderSamples : ISample
    {
        public void ImagebuilderCancelImageCreation()
        {
            #region cancel-an-image-build

            var client = new AmazonImagebuilderClient();
            var response = client.CancelImageCreation(new CancelImageCreationRequest 
            {
                ClientToken = "a1b2c3d4-5678-90ab-cdef-EXAMPLE77777",
                ImageBuildVersionArn = "arn:aws:imagebuilder:us-west-2:111122223333:image/my-example-recipe/1.0.0/1"
            });

            string clientToken = response.ClientToken;
            string imageBuildVersionArn = response.ImageBuildVersionArn;
            string requestId = response.RequestId;

            #endregion
        }

        public void ImagebuilderCancelLifecycleExecution()
        {
            #region cancel-a-lifecycle-execution

            var client = new AmazonImagebuilderClient();
            var response = client.CancelLifecycleExecution(new CancelLifecycleExecutionRequest 
            {
                ClientToken = "a1b2c3d4-5678-90ab-cdef-EXAMPLE97531",
                LifecycleExecutionId = "lce-401aefc3-a829-46f6-8fc2-91497988a503"
            });

            string lifecycleExecutionId = response.LifecycleExecutionId;

            #endregion
        }

        public void ImagebuilderCreateComponent()
        {
            #region create-a-component-from-an-inline-document

            var client = new AmazonImagebuilderClient();
            var response = client.CreateComponent(new CreateComponentRequest 
            {
                Name = "my-example-component",
                ClientToken = "a1b2c3d4-5678-90ab-cdef-EXAMPLE11111",
                Data = "name: InstallMyApp
description: Installs my application
schemaVersion: 1.0
phases:
  - name: build
    steps:
      - name: InstallApp
        action: ExecuteBash
        inputs:
          commands:
            - sudo yum -y install my-app
",
                Description = "Installs the latest version of my application",
                Platform = "Linux",
                SemanticVersion = "1.0.0"
            });

            string clientToken = response.ClientToken;
            string componentBuildVersionArn = response.ComponentBuildVersionArn;
            LatestVersionReferences latestVersionReferences = response.LatestVersionReferences;
            string requestId = response.RequestId;

            #endregion
        }

        public void ImagebuilderCreateComponent()
        {
            #region create-a-component-from-a-document-stored-in-amazon-s3

            var client = new AmazonImagebuilderClient();
            var response = client.CreateComponent(new CreateComponentRequest 
            {
                Name = "my-example-parameterized-component",
                ClientToken = "a1b2c3d4-5678-90ab-cdef-EXAMPLE10101",
                Description = "Installs a configurable version of my application",
                Platform = "Linux",
                SemanticVersion = "1.0.0",
                Uri = "s3://amzn-s3-demo-bucket/components/install-my-app.yaml"
            });

            string clientToken = response.ClientToken;
            string componentBuildVersionArn = response.ComponentBuildVersionArn;
            LatestVersionReferences latestVersionReferences = response.LatestVersionReferences;
            string requestId = response.RequestId;

            #endregion
        }

        public void ImagebuilderCreateContainerRecipe()
        {
            #region create-a-container-recipe-with-an-inline-dockerfile-template

            var client = new AmazonImagebuilderClient();
            var response = client.CreateContainerRecipe(new CreateContainerRecipeRequest 
            {
                Name = "my-example-container-recipe",
                ClientToken = "a1b2c3d4-5678-90ab-cdef-EXAMPLE99999",
                Components = new List<ComponentConfiguration> {
                    new ComponentConfiguration { ComponentArn = "arn:aws:imagebuilder:us-west-2:111122223333:component/my-example-container-component/1.0.0/1" }
                },
                ContainerType = "DOCKER",
                DockerfileTemplateData = "FROM {{{ imagebuilder:parentImage }}}
{{{ imagebuilder:environments }}}
{{{ imagebuilder:components }}}
",
                ParentImage = "amazonlinux:latest",
                SemanticVersion = "1.0.0",
                TargetRepository = new TargetContainerRepository {
                    RepositoryName = "my-example-container-repo",
                    Service = "ECR"
                }
            });

            string clientToken = response.ClientToken;
            string containerRecipeArn = response.ContainerRecipeArn;
            LatestVersionReferences latestVersionReferences = response.LatestVersionReferences;
            string requestId = response.RequestId;

            #endregion
        }

        public void ImagebuilderCreateContainerRecipe()
        {
            #region create-a-container-recipe-with-a-custom-build-instance-configuration

            var client = new AmazonImagebuilderClient();
            var response = client.CreateContainerRecipe(new CreateContainerRecipeRequest 
            {
                Name = "my-example-container-recipe",
                ClientToken = "a1b2c3d4-5678-90ab-cdef-EXAMPLE40404",
                Components = new List<ComponentConfiguration> {
                    new ComponentConfiguration { ComponentArn = "arn:aws:imagebuilder:us-west-2:111122223333:component/my-example-container-component/1.0.0/1" }
                },
                ContainerType = "DOCKER",
                Description = "A container recipe that builds on an ECS-optimized instance image with a larger build volume",
                DockerfileTemplateData = "FROM {{{ imagebuilder:parentImage }}}
{{{ imagebuilder:environments }}}
{{{ imagebuilder:components }}}
",
                InstanceConfiguration = new InstanceConfiguration {
                    BlockDeviceMappings = new List<InstanceBlockDeviceMapping> {
                        new InstanceBlockDeviceMapping {
                            DeviceName = "/dev/xvda",
                            Ebs = new EbsInstanceBlockDeviceSpecification {
                                DeleteOnTermination = true,
                                VolumeSize = 40,
                                VolumeType = "gp3"
                            }
                        }
                    },
                    Image = "ami-1234567890abcdef0"
                },
                ParentImage = "amazonlinux:latest",
                SemanticVersion = "1.1.0",
                TargetRepository = new TargetContainerRepository {
                    RepositoryName = "my-example-container-repo",
                    Service = "ECR"
                }
            });

            string clientToken = response.ClientToken;
            string containerRecipeArn = response.ContainerRecipeArn;
            LatestVersionReferences latestVersionReferences = response.LatestVersionReferences;
            string requestId = response.RequestId;

            #endregion
        }

        public void ImagebuilderCreateDistributionConfiguration()
        {
            #region create-a-distribution-configuration

            var client = new AmazonImagebuilderClient();
            var response = client.CreateDistributionConfiguration(new CreateDistributionConfigurationRequest 
            {
                Name = "my-example-distribution",
                ClientToken = "a1b2c3d4-5678-90ab-cdef-EXAMPLE44444",
                Description = "Copies the output AMI to a second Region",
                Distributions = new List<Distribution> {
                    new Distribution {
                        AmiDistributionConfiguration = new AmiDistributionConfiguration { Name = "my-example-image-{{ imagebuilder:buildDate }}" },
                        Region = "us-west-2"
                    },
                    new Distribution {
                        AmiDistributionConfiguration = new AmiDistributionConfiguration { Name = "my-example-image-{{ imagebuilder:buildDate }}" },
                        Region = "us-east-1"
                    }
                }
            });

            string clientToken = response.ClientToken;
            string distributionConfigurationArn = response.DistributionConfigurationArn;
            string requestId = response.RequestId;

            #endregion
        }

        public void ImagebuilderCreateDistributionConfiguration()
        {
            #region create-a-distribution-configuration-with-launch-permissions-and-a-launch-template-update

            var client = new AmazonImagebuilderClient();
            var response = client.CreateDistributionConfiguration(new CreateDistributionConfigurationRequest 
            {
                Name = "my-example-distribution",
                ClientToken = "a1b2c3d4-5678-90ab-cdef-EXAMPLE56789",
                Description = "Distributes the output AMI to two Regions and shares it with another account",
                Distributions = new List<Distribution> {
                    new Distribution {
                        AmiDistributionConfiguration = new AmiDistributionConfiguration { Name = "my-example-image-{{ imagebuilder:buildDate }}" },
                        LaunchTemplateConfigurations = new List<LaunchTemplateConfiguration> {
                            new LaunchTemplateConfiguration {
                                LaunchTemplateId = "lt-1234567890abcdef0",
                                SetDefaultVersion = true
                            }
                        },
                        Region = "us-west-2"
                    },
                    new Distribution {
                        AmiDistributionConfiguration = new AmiDistributionConfiguration {
                            Name = "my-example-image-{{ imagebuilder:buildDate }}",
                            LaunchPermission = new LaunchPermissionConfiguration { UserIds = new List<string> {
                                "444455556666"
                            } }
                        },
                        Region = "us-east-1"
                    }
                }
            });

            string clientToken = response.ClientToken;
            string distributionConfigurationArn = response.DistributionConfigurationArn;
            string requestId = response.RequestId;

            #endregion
        }

        public void ImagebuilderCreateImage()
        {
            #region create-an-image

            var client = new AmazonImagebuilderClient();
            var response = client.CreateImage(new CreateImageRequest 
            {
                ClientToken = "a1b2c3d4-5678-90ab-cdef-EXAMPLEeeeee",
                ImageRecipeArn = "arn:aws:imagebuilder:us-west-2:111122223333:image-recipe/my-example-recipe/1.0.0",
                InfrastructureConfigurationArn = "arn:aws:imagebuilder:us-west-2:111122223333:infrastructure-configuration/my-example-infrastructure"
            });

            string clientToken = response.ClientToken;
            string imageBuildVersionArn = response.ImageBuildVersionArn;
            LatestVersionReferences latestVersionReferences = response.LatestVersionReferences;
            string requestId = response.RequestId;

            #endregion
        }

        public void ImagebuilderCreateImage()
        {
            #region create-an-image-with-custom-build-and-parallel-test-workflows

            var client = new AmazonImagebuilderClient();
            var response = client.CreateImage(new CreateImageRequest 
            {
                ClientToken = "a1b2c3d4-5678-90ab-cdef-EXAMPLE01234",
                ExecutionRole = "arn:aws:iam::111122223333:role/aws-service-role/imagebuilder.amazonaws.com/AWSServiceRoleForImageBuilder",
                ImageRecipeArn = "arn:aws:imagebuilder:us-west-2:111122223333:image-recipe/my-example-recipe/1.0.0",
                InfrastructureConfigurationArn = "arn:aws:imagebuilder:us-west-2:111122223333:infrastructure-configuration/my-example-infrastructure",
                Workflows = new List<WorkflowConfiguration> {
                    new WorkflowConfiguration { WorkflowArn = "arn:aws:imagebuilder:us-west-2:111122223333:workflow/build/my-example-workflow/1.0.0/1" },
                    new WorkflowConfiguration {
                        ParallelGroup = "post-build-tests",
                        WorkflowArn = "arn:aws:imagebuilder:us-west-2:111122223333:workflow/test/my-example-integration-tests/1.0.0/1"
                    },
                    new WorkflowConfiguration {
                        ParallelGroup = "post-build-tests",
                        WorkflowArn = "arn:aws:imagebuilder:us-west-2:111122223333:workflow/test/my-example-compliance-tests/1.0.0/1"
                    }
                }
            });

            string clientToken = response.ClientToken;
            string imageBuildVersionArn = response.ImageBuildVersionArn;
            LatestVersionReferences latestVersionReferences = response.LatestVersionReferences;
            string requestId = response.RequestId;

            #endregion
        }

        public void ImagebuilderCreateImagePipeline()
        {
            #region create-an-image-pipeline

            var client = new AmazonImagebuilderClient();
            var response = client.CreateImagePipeline(new CreateImagePipelineRequest 
            {
                Name = "my-example-pipeline",
                ClientToken = "a1b2c3d4-5678-90ab-cdef-EXAMPLE55555",
                Description = "Builds a new version of my image every Sunday",
                DistributionConfigurationArn = "arn:aws:imagebuilder:us-west-2:111122223333:distribution-configuration/my-example-distribution",
                ImageRecipeArn = "arn:aws:imagebuilder:us-west-2:111122223333:image-recipe/my-example-recipe/1.0.0",
                InfrastructureConfigurationArn = "arn:aws:imagebuilder:us-west-2:111122223333:infrastructure-configuration/my-example-infrastructure",
                Schedule = new Schedule {
                    PipelineExecutionStartCondition = "EXPRESSION_MATCH_AND_DEPENDENCY_UPDATES_AVAILABLE",
                    ScheduleExpression = "cron(0 9 ? * SUN *)"
                },
                Status = "ENABLED"
            });

            string clientToken = response.ClientToken;
            string imagePipelineArn = response.ImagePipelineArn;
            string requestId = response.RequestId;

            #endregion
        }

        public void ImagebuilderCreateImagePipeline()
        {
            #region create-an-image-pipeline-with-scanning-custom-workflows-and-an-auto-disable-policy

            var client = new AmazonImagebuilderClient();
            var response = client.CreateImagePipeline(new CreateImagePipelineRequest 
            {
                Name = "my-example-pipeline",
                ClientToken = "a1b2c3d4-5678-90ab-cdef-EXAMPLE30303",
                Description = "Builds a scanned image with my custom build workflow on Sunday mornings when dependency updates are available",
                DistributionConfigurationArn = "arn:aws:imagebuilder:us-west-2:111122223333:distribution-configuration/my-example-distribution",
                ExecutionRole = "arn:aws:iam::111122223333:role/aws-service-role/imagebuilder.amazonaws.com/AWSServiceRoleForImageBuilder",
                ImageRecipeArn = "arn:aws:imagebuilder:us-west-2:111122223333:image-recipe/my-example-recipe/1.1.0",
                ImageScanningConfiguration = new ImageScanningConfiguration { ImageScanningEnabled = true },
                InfrastructureConfigurationArn = "arn:aws:imagebuilder:us-west-2:111122223333:infrastructure-configuration/my-example-infrastructure",
                Schedule = new Schedule {
                    AutoDisablePolicy = new AutoDisablePolicy { FailureCount = 3 },
                    PipelineExecutionStartCondition = "EXPRESSION_MATCH_AND_DEPENDENCY_UPDATES_AVAILABLE",
                    ScheduleExpression = "cron(0 9 ? * SUN *)",
                    Timezone = "America/Los_Angeles"
                },
                Status = "ENABLED",
                Workflows = new List<WorkflowConfiguration> {
                    new WorkflowConfiguration { WorkflowArn = "arn:aws:imagebuilder:us-west-2:111122223333:workflow/build/my-example-workflow/1.0.0/1" }
                }
            });

            string clientToken = response.ClientToken;
            string imagePipelineArn = response.ImagePipelineArn;
            string requestId = response.RequestId;

            #endregion
        }

        public void ImagebuilderCreateImageRecipe()
        {
            #region create-an-image-recipe

            var client = new AmazonImagebuilderClient();
            var response = client.CreateImageRecipe(new CreateImageRecipeRequest 
            {
                Name = "my-example-recipe",
                ClientToken = "a1b2c3d4-5678-90ab-cdef-EXAMPLE22222",
                Components = new List<ComponentConfiguration> {
                    new ComponentConfiguration { ComponentArn = "arn:aws:imagebuilder:us-west-2:111122223333:component/my-example-component/1.0.0/1" }
                },
                Description = "An image recipe that installs my application on Amazon Linux 2023",
                ParentImage = "arn:aws:imagebuilder:us-west-2:aws:image/amazon-linux-2023-x86/x.x.x",
                SemanticVersion = "1.0.0"
            });

            string clientToken = response.ClientToken;
            string imageRecipeArn = response.ImageRecipeArn;
            LatestVersionReferences latestVersionReferences = response.LatestVersionReferences;
            string requestId = response.RequestId;

            #endregion
        }

        public void ImagebuilderCreateImageRecipe()
        {
            #region create-an-image-recipe-with-component-parameters-and-block-device-mappings

            var client = new AmazonImagebuilderClient();
            var response = client.CreateImageRecipe(new CreateImageRecipeRequest 
            {
                Name = "my-example-recipe",
                BlockDeviceMappings = new List<InstanceBlockDeviceMapping> {
                    new InstanceBlockDeviceMapping {
                        DeviceName = "/dev/xvda",
                        Ebs = new EbsInstanceBlockDeviceSpecification {
                            DeleteOnTermination = true,
                            Encrypted = true,
                            VolumeSize = 30,
                            VolumeType = "gp3"
                        }
                    }
                },
                ClientToken = "a1b2c3d4-5678-90ab-cdef-EXAMPLE20202",
                Components = new List<ComponentConfiguration> {
                    new ComponentConfiguration {
                        ComponentArn = "arn:aws:imagebuilder:us-west-2:111122223333:component/my-example-parameterized-component/1.0.0/1",
                        Parameters = new List<ComponentParameter> {
                            new ComponentParameter {
                                Name = "AppVersion",
                                Value = new List<string> {
                                    "2.5.0"
                                }
                            }
                        }
                    }
                },
                Description = "Installs a specific version of my application on Amazon Linux 2023 with a larger encrypted root volume",
                ParentImage = "arn:aws:imagebuilder:us-west-2:aws:image/amazon-linux-2023-x86/x.x.x",
                SemanticVersion = "1.1.0"
            });

            string clientToken = response.ClientToken;
            string imageRecipeArn = response.ImageRecipeArn;
            LatestVersionReferences latestVersionReferences = response.LatestVersionReferences;
            string requestId = response.RequestId;

            #endregion
        }

        public void ImagebuilderCreateInfrastructureConfiguration()
        {
            #region create-an-infrastructure-configuration

            var client = new AmazonImagebuilderClient();
            var response = client.CreateInfrastructureConfiguration(new CreateInfrastructureConfigurationRequest 
            {
                Name = "my-example-infrastructure",
                ClientToken = "a1b2c3d4-5678-90ab-cdef-EXAMPLE33333",
                Description = "An infrastructure configuration for Amazon Linux builds",
                InstanceProfileName = "EC2InstanceProfileForImageBuilder",
                InstanceTypes = new List<string> {
                    "t3.medium",
                    "t3.large"
                },
                TerminateInstanceOnFailure = true
            });

            string clientToken = response.ClientToken;
            string infrastructureConfigurationArn = response.InfrastructureConfigurationArn;
            string requestId = response.RequestId;

            #endregion
        }

        public void ImagebuilderCreateInfrastructureConfiguration()
        {
            #region create-an-infrastructure-configuration-with-instance-placement-and-metadata-options

            var client = new AmazonImagebuilderClient();
            var response = client.CreateInfrastructureConfiguration(new CreateInfrastructureConfigurationRequest 
            {
                Name = "my-example-infrastructure",
                ClientToken = "a1b2c3d4-5678-90ab-cdef-EXAMPLE98765",
                Description = "An infrastructure configuration that pins build instances to one Availability Zone and requires IMDSv2",
                InstanceMetadataOptions = new InstanceMetadataOptions {
                    HttpPutResponseHopLimit = 2,
                    HttpTokens = "required"
                },
                InstanceProfileName = "my-example-instance-role",
                Placement = new Placement { AvailabilityZone = "us-west-2a" },
                ResourceTags = new Dictionary<string, string> {
                    { "CostCenter", "12345" },
                    { "Environment", "test" }
                },
                TerminateInstanceOnFailure = true
            });

            string clientToken = response.ClientToken;
            string infrastructureConfigurationArn = response.InfrastructureConfigurationArn;
            string requestId = response.RequestId;

            #endregion
        }

        public void ImagebuilderCreateLifecyclePolicy()
        {
            #region create-a-lifecycle-policy

            var client = new AmazonImagebuilderClient();
            var response = client.CreateLifecyclePolicy(new CreateLifecyclePolicyRequest 
            {
                Name = "my-example-lifecycle-policy",
                ClientToken = "a1b2c3d4-5678-90ab-cdef-EXAMPLE13579",
                ExecutionRole = "arn:aws:iam::111122223333:role/my-example-lifecycle-role",
                PolicyDetails = new List<LifecyclePolicyDetail> {
                    new LifecyclePolicyDetail {
                        Action = new LifecyclePolicyDetailAction { Type = "DELETE" },
                        Filter = new LifecyclePolicyDetailFilter {
                            Type = "AGE",
                            Value = 6,
                            Unit = "MONTHS"
                        }
                    }
                },
                ResourceSelection = new LifecyclePolicyResourceSelection { TagMap = new Dictionary<string, string> {
                    { "Environment", "test" }
                } },
                ResourceType = "AMI_IMAGE"
            });

            string clientToken = response.ClientToken;
            string lifecyclePolicyArn = response.LifecyclePolicyArn;

            #endregion
        }

        public void ImagebuilderCreateLifecyclePolicy()
        {
            #region create-a-lifecycle-policy-with-exclusion-rules

            var client = new AmazonImagebuilderClient();
            var response = client.CreateLifecyclePolicy(new CreateLifecyclePolicyRequest 
            {
                Name = "my-example-lifecycle-policy",
                ClientToken = "a1b2c3d4-5678-90ab-cdef-EXAMPLE43210",
                ExecutionRole = "arn:aws:iam::111122223333:role/my-example-lifecycle-role",
                PolicyDetails = new List<LifecyclePolicyDetail> {
                    new LifecyclePolicyDetail {
                        Action = new LifecyclePolicyDetailAction { Type = "DELETE" },
                        ExclusionRules = new LifecyclePolicyDetailExclusionRules { Amis = new LifecyclePolicyDetailExclusionRulesAmis {
                            LastLaunched = new LifecyclePolicyDetailExclusionRulesAmisLastLaunched {
                                Value = 30,
                                Unit = "DAYS"
                            },
                            TagMap = new Dictionary<string, string> {
                                { "Retention", "keep" }
                            }
                        } },
                        Filter = new LifecyclePolicyDetailFilter {
                            Type = "AGE",
                            Value = 6,
                            Unit = "MONTHS"
                        }
                    }
                },
                ResourceSelection = new LifecyclePolicyResourceSelection { Recipes = new List<LifecyclePolicyResourceSelectionRecipe> {
                    new LifecyclePolicyResourceSelectionRecipe {
                        Name = "my-example-recipe",
                        SemanticVersion = "1.0.0"
                    }
                } },
                ResourceType = "AMI_IMAGE"
            });

            string clientToken = response.ClientToken;
            string lifecyclePolicyArn = response.LifecyclePolicyArn;

            #endregion
        }

        public void ImagebuilderCreateWorkflow()
        {
            #region create-a-build-workflow-from-an-inline-document

            var client = new AmazonImagebuilderClient();
            var response = client.CreateWorkflow(new CreateWorkflowRequest 
            {
                Name = "my-example-workflow",
                Type = "BUILD",
                ClientToken = "a1b2c3d4-5678-90ab-cdef-EXAMPLE54321",
                Data = "name: my-example-workflow
description: Workflow to build an AMI
schemaVersion: 1.0
steps:
  - name: LaunchBuildInstance
    action: LaunchInstance
    onFailure: Abort
    inputs:
      waitFor: ssmAgent
  - name: ApplyBuildComponents
    action: ExecuteComponents
    onFailure: Abort
    inputs:
      instanceId.$: $.stepOutputs.LaunchBuildInstance.instanceId
  - name: CreateOutputAMI
    action: CreateImage
    onFailure: Abort
    inputs:
      instanceId.$: $.stepOutputs.LaunchBuildInstance.instanceId
  - name: TerminateBuildInstance
    action: TerminateInstance
    onFailure: Continue
    inputs:
      instanceId.$: $.stepOutputs.LaunchBuildInstance.instanceId
",
                Description = "Workflow to build an AMI",
                SemanticVersion = "1.0.0"
            });

            string clientToken = response.ClientToken;
            LatestVersionReferences latestVersionReferences = response.LatestVersionReferences;
            string workflowBuildVersionArn = response.WorkflowBuildVersionArn;

            #endregion
        }

        public void ImagebuilderDeleteComponent()
        {
            #region delete-a-component-build-version

            var client = new AmazonImagebuilderClient();
            var response = client.DeleteComponent(new DeleteComponentRequest 
            {
                ComponentBuildVersionArn = "arn:aws:imagebuilder:us-west-2:111122223333:component/my-example-component/1.0.0/1"
            });

            string componentBuildVersionArn = response.ComponentBuildVersionArn;
            string requestId = response.RequestId;

            #endregion
        }

        public void ImagebuilderDeleteContainerRecipe()
        {
            #region delete-a-container-recipe

            var client = new AmazonImagebuilderClient();
            var response = client.DeleteContainerRecipe(new DeleteContainerRecipeRequest 
            {
                ContainerRecipeArn = "arn:aws:imagebuilder:us-west-2:111122223333:container-recipe/my-example-container-recipe/1.0.0"
            });

            string containerRecipeArn = response.ContainerRecipeArn;
            string requestId = response.RequestId;

            #endregion
        }

        public void ImagebuilderDeleteDistributionConfiguration()
        {
            #region delete-a-distribution-configuration

            var client = new AmazonImagebuilderClient();
            var response = client.DeleteDistributionConfiguration(new DeleteDistributionConfigurationRequest 
            {
                DistributionConfigurationArn = "arn:aws:imagebuilder:us-west-2:111122223333:distribution-configuration/my-example-distribution-configuration"
            });

            string distributionConfigurationArn = response.DistributionConfigurationArn;
            string requestId = response.RequestId;

            #endregion
        }

        public void ImagebuilderDeleteImage()
        {
            #region delete-an-image-build-version

            var client = new AmazonImagebuilderClient();
            var response = client.DeleteImage(new DeleteImageRequest 
            {
                ImageBuildVersionArn = "arn:aws:imagebuilder:us-west-2:111122223333:image/my-example-recipe/1.0.0/1"
            });

            string imageBuildVersionArn = response.ImageBuildVersionArn;
            string requestId = response.RequestId;

            #endregion
        }

        public void ImagebuilderDeleteImagePipeline()
        {
            #region delete-an-image-pipeline

            var client = new AmazonImagebuilderClient();
            var response = client.DeleteImagePipeline(new DeleteImagePipelineRequest 
            {
                ImagePipelineArn = "arn:aws:imagebuilder:us-west-2:111122223333:image-pipeline/my-example-pipeline"
            });

            string imagePipelineArn = response.ImagePipelineArn;
            string requestId = response.RequestId;

            #endregion
        }

        public void ImagebuilderDeleteImageRecipe()
        {
            #region delete-an-image-recipe

            var client = new AmazonImagebuilderClient();
            var response = client.DeleteImageRecipe(new DeleteImageRecipeRequest 
            {
                ImageRecipeArn = "arn:aws:imagebuilder:us-west-2:111122223333:image-recipe/my-example-recipe/1.0.0"
            });

            string imageRecipeArn = response.ImageRecipeArn;
            string requestId = response.RequestId;

            #endregion
        }

        public void ImagebuilderDeleteInfrastructureConfiguration()
        {
            #region delete-an-infrastructure-configuration

            var client = new AmazonImagebuilderClient();
            var response = client.DeleteInfrastructureConfiguration(new DeleteInfrastructureConfigurationRequest 
            {
                InfrastructureConfigurationArn = "arn:aws:imagebuilder:us-west-2:111122223333:infrastructure-configuration/my-example-infrastructure"
            });

            string infrastructureConfigurationArn = response.InfrastructureConfigurationArn;
            string requestId = response.RequestId;

            #endregion
        }

        public void ImagebuilderDeleteLifecyclePolicy()
        {
            #region delete-a-lifecycle-policy

            var client = new AmazonImagebuilderClient();
            var response = client.DeleteLifecyclePolicy(new DeleteLifecyclePolicyRequest 
            {
                LifecyclePolicyArn = "arn:aws:imagebuilder:us-west-2:111122223333:lifecycle-policy/my-example-lifecycle-policy"
            });

            string lifecyclePolicyArn = response.LifecyclePolicyArn;

            #endregion
        }

        public void ImagebuilderDeleteWorkflow()
        {
            #region delete-a-workflow-build-version

            var client = new AmazonImagebuilderClient();
            var response = client.DeleteWorkflow(new DeleteWorkflowRequest 
            {
                WorkflowBuildVersionArn = "arn:aws:imagebuilder:us-west-2:111122223333:workflow/build/my-example-workflow/1.0.0/1"
            });

            string workflowBuildVersionArn = response.WorkflowBuildVersionArn;

            #endregion
        }

        public void ImagebuilderDistributeImage()
        {
            #region distribute-an-existing-ami

            var client = new AmazonImagebuilderClient();
            var response = client.DistributeImage(new DistributeImageRequest 
            {
                ClientToken = "a1b2c3d4-5678-90ab-cdef-EXAMPLE86420",
                DistributionConfigurationArn = "arn:aws:imagebuilder:us-west-2:111122223333:distribution-configuration/my-example-distribution-configuration",
                ExecutionRole = "arn:aws:iam::111122223333:role/aws-service-role/imagebuilder.amazonaws.com/AWSServiceRoleForImageBuilder",
                SourceImage = "ami-1234567890abcdef0"
            });

            string clientToken = response.ClientToken;
            string imageBuildVersionArn = response.ImageBuildVersionArn;

            #endregion
        }

        public void ImagebuilderGetComponent()
        {
            #region get-the-details-of-a-component-build-version

            var client = new AmazonImagebuilderClient();
            var response = client.GetComponent(new GetComponentRequest 
            {
                ComponentBuildVersionArn = "arn:aws:imagebuilder:us-west-2:111122223333:component/my-example-component/1.0.0/1"
            });

            Component component = response.Component;
            LatestVersionReferences latestVersionReferences = response.LatestVersionReferences;
            string requestId = response.RequestId;

            #endregion
        }

        public void ImagebuilderGetComponentPolicy()
        {
            #region get-the-resource-policy-for-a-component

            var client = new AmazonImagebuilderClient();
            var response = client.GetComponentPolicy(new GetComponentPolicyRequest 
            {
                ComponentArn = "arn:aws:imagebuilder:us-west-2:111122223333:component/my-shared-component/1.0.0/1"
            });

            string policy = response.Policy;
            string requestId = response.RequestId;

            #endregion
        }

        public void ImagebuilderGetContainerRecipe()
        {
            #region get-the-details-of-a-container-recipe

            var client = new AmazonImagebuilderClient();
            var response = client.GetContainerRecipe(new GetContainerRecipeRequest 
            {
                ContainerRecipeArn = "arn:aws:imagebuilder:us-west-2:111122223333:container-recipe/my-example-container-recipe/1.0.0"
            });

            ContainerRecipe containerRecipe = response.ContainerRecipe;
            LatestVersionReferences latestVersionReferences = response.LatestVersionReferences;
            string requestId = response.RequestId;

            #endregion
        }

        public void ImagebuilderGetContainerRecipePolicy()
        {
            #region get-the-policy-attached-to-a-container-recipe

            var client = new AmazonImagebuilderClient();
            var response = client.GetContainerRecipePolicy(new GetContainerRecipePolicyRequest 
            {
                ContainerRecipeArn = "arn:aws:imagebuilder:us-west-2:111122223333:container-recipe/my-example-container-recipe-shared/1.0.0"
            });

            string policy = response.Policy;
            string requestId = response.RequestId;

            #endregion
        }

        public void ImagebuilderGetDistributionConfiguration()
        {
            #region get-the-details-of-a-distribution-configuration

            var client = new AmazonImagebuilderClient();
            var response = client.GetDistributionConfiguration(new GetDistributionConfigurationRequest 
            {
                DistributionConfigurationArn = "arn:aws:imagebuilder:us-west-2:111122223333:distribution-configuration/my-example-distribution"
            });

            DistributionConfiguration distributionConfiguration = response.DistributionConfiguration;
            string requestId = response.RequestId;

            #endregion
        }

        public void ImagebuilderGetImage()
        {
            #region check-the-status-of-an-image-build

            var client = new AmazonImagebuilderClient();
            var response = client.GetImage(new GetImageRequest 
            {
                ImageBuildVersionArn = "arn:aws:imagebuilder:us-west-2:111122223333:image/my-example-recipe/1.0.0/1"
            });

            Image image = response.Image;
            string requestId = response.RequestId;

            #endregion
        }

        public void ImagebuilderGetImagePipeline()
        {
            #region get-the-details-of-an-image-pipeline

            var client = new AmazonImagebuilderClient();
            var response = client.GetImagePipeline(new GetImagePipelineRequest 
            {
                ImagePipelineArn = "arn:aws:imagebuilder:us-west-2:111122223333:image-pipeline/my-example-pipeline"
            });

            ImagePipeline imagePipeline = response.ImagePipeline;
            string requestId = response.RequestId;

            #endregion
        }

        public void ImagebuilderGetImagePolicy()
        {
            #region retrieve-the-resource-policy-for-an-image

            var client = new AmazonImagebuilderClient();
            var response = client.GetImagePolicy(new GetImagePolicyRequest 
            {
                ImageArn = "arn:aws:imagebuilder:us-west-2:111122223333:image/my-example-recipe/1.0.0/1"
            });

            string policy = response.Policy;
            string requestId = response.RequestId;

            #endregion
        }

        public void ImagebuilderGetImageRecipe()
        {
            #region get-the-details-of-an-image-recipe

            var client = new AmazonImagebuilderClient();
            var response = client.GetImageRecipe(new GetImageRecipeRequest 
            {
                ImageRecipeArn = "arn:aws:imagebuilder:us-west-2:111122223333:image-recipe/my-example-app-recipe/1.0.0"
            });

            ImageRecipe imageRecipe = response.ImageRecipe;
            LatestVersionReferences latestVersionReferences = response.LatestVersionReferences;
            string requestId = response.RequestId;

            #endregion
        }

        public void ImagebuilderGetImageRecipePolicy()
        {
            #region get-the-resource-policy-for-an-image-recipe

            var client = new AmazonImagebuilderClient();
            var response = client.GetImageRecipePolicy(new GetImageRecipePolicyRequest 
            {
                ImageRecipeArn = "arn:aws:imagebuilder:us-west-2:111122223333:image-recipe/my-example-recipe/1.0.0"
            });

            string policy = response.Policy;
            string requestId = response.RequestId;

            #endregion
        }

        public void ImagebuilderGetInfrastructureConfiguration()
        {
            #region get-the-details-of-an-infrastructure-configuration

            var client = new AmazonImagebuilderClient();
            var response = client.GetInfrastructureConfiguration(new GetInfrastructureConfigurationRequest 
            {
                InfrastructureConfigurationArn = "arn:aws:imagebuilder:us-west-2:111122223333:infrastructure-configuration/my-example-infrastructure-configuration"
            });

            InfrastructureConfiguration infrastructureConfiguration = response.InfrastructureConfiguration;
            string requestId = response.RequestId;

            #endregion
        }

        public void ImagebuilderGetLifecycleExecution()
        {
            #region get-the-details-of-a-lifecycle-execution

            var client = new AmazonImagebuilderClient();
            var response = client.GetLifecycleExecution(new GetLifecycleExecutionRequest 
            {
                LifecycleExecutionId = "lce-401aefc3-a829-46f6-8fc2-91497988a503"
            });

            LifecycleExecution lifecycleExecution = response.LifecycleExecution;

            #endregion
        }

        public void ImagebuilderGetLifecyclePolicy()
        {
            #region get-the-details-of-a-lifecycle-policy

            var client = new AmazonImagebuilderClient();
            var response = client.GetLifecyclePolicy(new GetLifecyclePolicyRequest 
            {
                LifecyclePolicyArn = "arn:aws:imagebuilder:us-west-2:111122223333:lifecycle-policy/my-example-lifecycle-policy"
            });

            LifecyclePolicy lifecyclePolicy = response.LifecyclePolicy;

            #endregion
        }

        public void ImagebuilderGetWorkflow()
        {
            #region get-the-details-of-a-workflow-build-version

            var client = new AmazonImagebuilderClient();
            var response = client.GetWorkflow(new GetWorkflowRequest 
            {
                WorkflowBuildVersionArn = "arn:aws:imagebuilder:us-west-2:111122223333:workflow/build/my-example-workflow/1.0.0/1"
            });

            LatestVersionReferences latestVersionReferences = response.LatestVersionReferences;
            Workflow workflow = response.Workflow;

            #endregion
        }

        public void ImagebuilderGetWorkflowExecution()
        {
            #region get-the-runtime-details-for-a-workflow-execution

            var client = new AmazonImagebuilderClient();
            var response = client.GetWorkflowExecution(new GetWorkflowExecutionRequest 
            {
                WorkflowExecutionId = "wf-165b1cb6-3a62-4618-a021-94ddcbe32908"
            });

            string type = response.Type;
            string endTime = response.EndTime;
            string imageBuildVersionArn = response.ImageBuildVersionArn;
            string requestId = response.RequestId;
            string startTime = response.StartTime;
            string status = response.Status;
            int totalStepCount = response.TotalStepCount;
            int totalStepsFailed = response.TotalStepsFailed;
            int totalStepsSkipped = response.TotalStepsSkipped;
            int totalStepsSucceeded = response.TotalStepsSucceeded;
            string workflowBuildVersionArn = response.WorkflowBuildVersionArn;
            string workflowExecutionId = response.WorkflowExecutionId;

            #endregion
        }

        public void ImagebuilderGetWorkflowStepExecution()
        {
            #region get-the-runtime-details-of-a-workflow-step

            var client = new AmazonImagebuilderClient();
            var response = client.GetWorkflowStepExecution(new GetWorkflowStepExecutionRequest 
            {
                StepExecutionId = "step-2e6fef0d-657c-4b7e-8706-ff24da9afa01"
            });

            string name = response.Name;
            string action = response.Action;
            string endTime = response.EndTime;
            string imageBuildVersionArn = response.ImageBuildVersionArn;
            string inputs = response.Inputs;
            string onFailure = response.OnFailure;
            string outputs = response.Outputs;
            string requestId = response.RequestId;
            string startTime = response.StartTime;
            string status = response.Status;
            string stepExecutionId = response.StepExecutionId;
            int timeoutSeconds = response.TimeoutSeconds;
            string workflowBuildVersionArn = response.WorkflowBuildVersionArn;
            string workflowExecutionId = response.WorkflowExecutionId;

            #endregion
        }

        public void ImagebuilderImportComponent()
        {
            #region import-a-component-from-a-shell-script

            var client = new AmazonImagebuilderClient();
            var response = client.ImportComponent(new ImportComponentRequest 
            {
                Name = "my-example-imported-component",
                Type = "BUILD",
                ClientToken = "a1b2c3d4-5678-90ab-cdef-EXAMPLE88888",
                Data = "sudo yum update -y
sudo yum -y install my-app
",
                Description = "Installs my application from an imported shell script",
                Format = "SHELL",
                Platform = "Linux",
                SemanticVersion = "1.0.0"
            });

            string clientToken = response.ClientToken;
            string componentBuildVersionArn = response.ComponentBuildVersionArn;
            string requestId = response.RequestId;

            #endregion
        }

        public void ImagebuilderImportDiskImage()
        {
            #region import-a-windows-11-iso-disk-image

            var client = new AmazonImagebuilderClient();
            var response = client.ImportDiskImage(new ImportDiskImageRequest 
            {
                Name = "my-example-imported-image",
                ClientToken = "a1b2c3d4-5678-90ab-cdef-EXAMPLE12345",
                InfrastructureConfigurationArn = "arn:aws:imagebuilder:us-west-2:111122223333:infrastructure-configuration/my-example-infrastructure",
                OsVersion = "Microsoft Windows 11",
                Platform = "Windows",
                SemanticVersion = "1.0.0",
                Uri = "s3://amzn-s3-demo-bucket/Win11_23H2_English_x64.iso"
            });

            string clientToken = response.ClientToken;
            string imageBuildVersionArn = response.ImageBuildVersionArn;

            #endregion
        }

        public void ImagebuilderImportVmImage()
        {
            #region import-a-virtual-machine-as-an-image-builder-image

            var client = new AmazonImagebuilderClient();
            var response = client.ImportVmImage(new ImportVmImageRequest 
            {
                Name = "my-example-imported-image",
                ClientToken = "a1b2c3d4-5678-90ab-cdef-EXAMPLE00000",
                OsVersion = "Amazon Linux 2",
                Platform = "Linux",
                SemanticVersion = "1.0.0",
                VmImportTaskId = "import-ami-1234567890abcdef0"
            });

            string clientToken = response.ClientToken;
            string imageArn = response.ImageArn;
            string requestId = response.RequestId;

            #endregion
        }

        public void ImagebuilderListComponentBuildVersions()
        {
            #region list-the-build-versions-of-a-component

            var client = new AmazonImagebuilderClient();
            var response = client.ListComponentBuildVersions(new ListComponentBuildVersionsRequest 
            {
                ComponentVersionArn = "arn:aws:imagebuilder:us-west-2:111122223333:component/my-example-component/1.0.0"
            });

            List<ComponentSummary> componentSummaryList = response.ComponentSummaryList;
            string requestId = response.RequestId;

            #endregion
        }

        public void ImagebuilderListComponents()
        {
            #region list-components-that-you-own

            var client = new AmazonImagebuilderClient();
            var response = client.ListComponents(new ListComponentsRequest 
            {
                Filters = new List<Filter> {
                    new Filter {
                        Name = "platform",
                        Values = new List<string> {
                            "Linux"
                        }
                    }
                },
                Owner = "Self"
            });

            List<ComponentVersion> componentVersionList = response.ComponentVersionList;
            string requestId = response.RequestId;

            #endregion
        }

        public void ImagebuilderListContainerRecipes()
        {
            #region list-the-container-recipes-you-own

            var client = new AmazonImagebuilderClient();
            var response = client.ListContainerRecipes(new ListContainerRecipesRequest 
            {
                Owner = "Self"
            });

            List<ContainerRecipeSummary> containerRecipeSummaryList = response.ContainerRecipeSummaryList;
            string requestId = response.RequestId;

            #endregion
        }

        public void ImagebuilderListDistributionConfigurations()
        {
            #region list-distribution-configurations-that-match-a-name-filter

            var client = new AmazonImagebuilderClient();
            var response = client.ListDistributionConfigurations(new ListDistributionConfigurationsRequest 
            {
                Filters = new List<Filter> {
                    new Filter {
                        Name = "name",
                        Values = new List<string> {
                            "my-example-distribution-configuration"
                        }
                    }
                }
            });

            List<DistributionConfigurationSummary> distributionConfigurationSummaryList = response.DistributionConfigurationSummaryList;
            string requestId = response.RequestId;

            #endregion
        }

        public void ImagebuilderListImageBuildVersions()
        {
            #region list-the-build-versions-of-an-image

            var client = new AmazonImagebuilderClient();
            var response = client.ListImageBuildVersions(new ListImageBuildVersionsRequest 
            {
                ImageVersionArn = "arn:aws:imagebuilder:us-west-2:111122223333:image/my-example-recipe/1.0.0"
            });

            List<ImageSummary> imageSummaryList = response.ImageSummaryList;
            string requestId = response.RequestId;

            #endregion
        }

        public void ImagebuilderListImagePackages()
        {
            #region list-the-packages-in-an-image-build-version

            var client = new AmazonImagebuilderClient();
            var response = client.ListImagePackages(new ListImagePackagesRequest 
            {
                ImageBuildVersionArn = "arn:aws:imagebuilder:us-west-2:111122223333:image/my-example-recipe/1.0.0/1"
            });

            List<ImagePackage> imagePackageList = response.ImagePackageList;
            string requestId = response.RequestId;

            #endregion
        }

        public void ImagebuilderListImagePipelineImages()
        {
            #region list-the-images-that-an-image-pipeline-created

            var client = new AmazonImagebuilderClient();
            var response = client.ListImagePipelineImages(new ListImagePipelineImagesRequest 
            {
                ImagePipelineArn = "arn:aws:imagebuilder:us-west-2:111122223333:image-pipeline/my-example-pipeline"
            });

            List<ImageSummary> imageSummaryList = response.ImageSummaryList;
            string requestId = response.RequestId;

            #endregion
        }

        public void ImagebuilderListImagePipelines()
        {
            #region list-image-pipelines-filtered-by-name

            var client = new AmazonImagebuilderClient();
            var response = client.ListImagePipelines(new ListImagePipelinesRequest 
            {
                Filters = new List<Filter> {
                    new Filter {
                        Name = "name",
                        Values = new List<string> {
                            "my-example-pipeline"
                        }
                    }
                }
            });

            List<ImagePipeline> imagePipelineList = response.ImagePipelineList;
            string requestId = response.RequestId;

            #endregion
        }

        public void ImagebuilderListImageRecipes()
        {
            #region list-the-image-recipes-that-you-own

            var client = new AmazonImagebuilderClient();
            var response = client.ListImageRecipes(new ListImageRecipesRequest 
            {
                Owner = "Self"
            });

            List<ImageRecipeSummary> imageRecipeSummaryList = response.ImageRecipeSummaryList;
            string requestId = response.RequestId;

            #endregion
        }

        public void ImagebuilderListImages()
        {
            #region list-images-that-you-own

            var client = new AmazonImagebuilderClient();
            var response = client.ListImages(new ListImagesRequest 
            {
                ByName = false,
                Owner = "Self"
            });

            List<ImageVersion> imageVersionList = response.ImageVersionList;
            string requestId = response.RequestId;

            #endregion
        }

        public void ImagebuilderListImageScanFindingAggregations()
        {
            #region list-image-scan-finding-aggregations-for-an-image-pipeline

            var client = new AmazonImagebuilderClient();
            var response = client.ListImageScanFindingAggregations(new ListImageScanFindingAggregationsRequest 
            {
                Filter = new Filter {
                    Name = "imagePipelineArn",
                    Values = new List<string> {
                        "arn:aws:imagebuilder:us-west-2:111122223333:image-pipeline/my-example-pipeline"
                    }
                }
            });

            string aggregationType = response.AggregationType;
            string requestId = response.RequestId;

            #endregion
        }

        public void ImagebuilderListImageScanFindings()
        {
            #region list-vulnerability-findings-for-an-image-build

            var client = new AmazonImagebuilderClient();
            var response = client.ListImageScanFindings(new ListImageScanFindingsRequest 
            {
                Filters = new List<ImageScanFindingsFilter> {
                    new ImageScanFindingsFilter {
                        Name = "imageBuildVersionArn",
                        Values = new List<string> {
                            "arn:aws:imagebuilder:us-west-2:111122223333:image/my-example-recipe/1.0.0/1"
                        }
                    }
                }
            });

            List<ImageScanFinding> findings = response.Findings;
            string requestId = response.RequestId;

            #endregion
        }

        public void ImagebuilderListInfrastructureConfigurations()
        {
            #region list-infrastructure-configurations-by-name

            var client = new AmazonImagebuilderClient();
            var response = client.ListInfrastructureConfigurations(new ListInfrastructureConfigurationsRequest 
            {
                Filters = new List<Filter> {
                    new Filter {
                        Name = "name",
                        Values = new List<string> {
                            "my-example-infrastructure-configuration"
                        }
                    }
                }
            });

            List<InfrastructureConfigurationSummary> infrastructureConfigurationSummaryList = response.InfrastructureConfigurationSummaryList;
            string requestId = response.RequestId;

            #endregion
        }

        public void ImagebuilderListLifecycleExecutionResources()
        {
            #region list-the-resources-that-a-lifecycle-execution-acted-on

            var client = new AmazonImagebuilderClient();
            var response = client.ListLifecycleExecutionResources(new ListLifecycleExecutionResourcesRequest 
            {
                LifecycleExecutionId = "lce-401aefc3-a829-46f6-8fc2-91497988a503"
            });

            string lifecycleExecutionId = response.LifecycleExecutionId;
            LifecycleExecutionState lifecycleExecutionState = response.LifecycleExecutionState;
            List<LifecycleExecutionResource> resources = response.Resources;

            #endregion
        }

        public void ImagebuilderListLifecycleExecutions()
        {
            #region list-lifecycle-executions-for-an-image-build-version

            var client = new AmazonImagebuilderClient();
            var response = client.ListLifecycleExecutions(new ListLifecycleExecutionsRequest 
            {
                ResourceArn = "arn:aws:imagebuilder:us-west-2:111122223333:image/my-example-recipe/1.0.0/1"
            });

            List<LifecycleExecution> lifecycleExecutions = response.LifecycleExecutions;

            #endregion
        }

        public void ImagebuilderListLifecyclePolicies()
        {
            #region list-enabled-lifecycle-policies

            var client = new AmazonImagebuilderClient();
            var response = client.ListLifecyclePolicies(new ListLifecyclePoliciesRequest 
            {
                Filters = new List<Filter> {
                    new Filter {
                        Name = "status",
                        Values = new List<string> {
                            "ENABLED"
                        }
                    }
                }
            });

            List<LifecyclePolicySummary> lifecyclePolicySummaryList = response.LifecyclePolicySummaryList;

            #endregion
        }

        public void ImagebuilderListTagsForResource()
        {
            #region list-the-tags-for-a-resource

            var client = new AmazonImagebuilderClient();
            var response = client.ListTagsForResource(new ListTagsForResourceRequest 
            {
                ResourceArn = "arn:aws:imagebuilder:us-west-2:111122223333:component/my-example-component/1.0.0/1"
            });

            Dictionary<string, string> tags = response.Tags;

            #endregion
        }

        public void ImagebuilderListWaitingWorkflowSteps()
        {
            #region list-workflow-steps-that-are-waiting-for-an-action

            var client = new AmazonImagebuilderClient();
            var response = client.ListWaitingWorkflowSteps(new ListWaitingWorkflowStepsRequest 
            {
                MaxResults = 25
            });

            List<WorkflowStepExecution> steps = response.Steps;

            #endregion
        }

        public void ImagebuilderListWorkflowBuildVersions()
        {
            #region list-the-build-versions-of-a-workflow

            var client = new AmazonImagebuilderClient();
            var response = client.ListWorkflowBuildVersions(new ListWorkflowBuildVersionsRequest 
            {
                WorkflowVersionArn = "arn:aws:imagebuilder:us-west-2:111122223333:workflow/build/my-example-workflow/1.0.0"
            });

            List<WorkflowSummary> workflowSummaryList = response.WorkflowSummaryList;

            #endregion
        }

        public void ImagebuilderListWorkflowExecutions()
        {
            #region list-the-workflow-runtime-instances-for-an-image-build-version

            var client = new AmazonImagebuilderClient();
            var response = client.ListWorkflowExecutions(new ListWorkflowExecutionsRequest 
            {
                ImageBuildVersionArn = "arn:aws:imagebuilder:us-west-2:111122223333:image/my-example-recipe/1.0.0/1"
            });

            string imageBuildVersionArn = response.ImageBuildVersionArn;
            string requestId = response.RequestId;
            List<WorkflowExecutionMetadata> workflowExecutions = response.WorkflowExecutions;

            #endregion
        }

        public void ImagebuilderListWorkflows()
        {
            #region list-workflows-that-you-own

            var client = new AmazonImagebuilderClient();
            var response = client.ListWorkflows(new ListWorkflowsRequest 
            {
                Owner = "Self"
            });

            List<WorkflowVersion> workflowVersionList = response.WorkflowVersionList;

            #endregion
        }

        public void ImagebuilderListWorkflowStepExecutions()
        {
            #region list-the-steps-that-ran-in-a-workflow-execution

            var client = new AmazonImagebuilderClient();
            var response = client.ListWorkflowStepExecutions(new ListWorkflowStepExecutionsRequest 
            {
                WorkflowExecutionId = "wf-165b1cb6-3a62-4618-a021-94ddcbe32908"
            });

            string imageBuildVersionArn = response.ImageBuildVersionArn;
            string requestId = response.RequestId;
            List<WorkflowStepMetadata> steps = response.Steps;
            string workflowBuildVersionArn = response.WorkflowBuildVersionArn;
            string workflowExecutionId = response.WorkflowExecutionId;

            #endregion
        }

        public void ImagebuilderPutComponentPolicy()
        {
            #region share-a-component-with-another-account

            var client = new AmazonImagebuilderClient();
            var response = client.PutComponentPolicy(new PutComponentPolicyRequest 
            {
                ComponentArn = "arn:aws:imagebuilder:us-west-2:111122223333:component/my-shared-component/1.0.0/1",
                Policy = "{\"Version\": \"2012-10-17\", \"Statement\": [{\"Effect\": \"Allow\", \"Principal\": {\"AWS\": \"arn:aws:iam::444455556666:root\"}, \"Action\": [\"imagebuilder:GetComponent\", \"imagebuilder:ListComponents\"], \"Resource\": [\"arn:aws:imagebuilder:us-west-2:111122223333:component/my-shared-component/1.0.0/1\"]}]}"
            });

            string componentArn = response.ComponentArn;
            string requestId = response.RequestId;

            #endregion
        }

        public void ImagebuilderPutContainerRecipePolicy()
        {
            #region share-a-container-recipe-with-another-account

            var client = new AmazonImagebuilderClient();
            var response = client.PutContainerRecipePolicy(new PutContainerRecipePolicyRequest 
            {
                ContainerRecipeArn = "arn:aws:imagebuilder:us-west-2:111122223333:container-recipe/my-example-container-recipe-shared/1.0.0",
                Policy = "{\"Version\": \"2012-10-17\", \"Statement\": [{\"Sid\": \"AllowSharedAccountContainerRecipeAccess\", \"Effect\": \"Allow\", \"Principal\": {\"AWS\": \"arn:aws:iam::444455556666:root\"}, \"Action\": [\"imagebuilder:GetContainerRecipe\", \"imagebuilder:ListContainerRecipes\"], \"Resource\": \"arn:aws:imagebuilder:us-west-2:111122223333:container-recipe/my-example-container-recipe-shared/1.0.0\"}]}"
            });

            string containerRecipeArn = response.ContainerRecipeArn;
            string requestId = response.RequestId;

            #endregion
        }

        public void ImagebuilderPutImagePolicy()
        {
            #region share-an-image-with-another-aws-account

            var client = new AmazonImagebuilderClient();
            var response = client.PutImagePolicy(new PutImagePolicyRequest 
            {
                ImageArn = "arn:aws:imagebuilder:us-west-2:111122223333:image/my-example-recipe/1.0.0/1",
                Policy = "{\"Version\": \"2012-10-17\", \"Statement\": [{\"Effect\": \"Allow\", \"Principal\": {\"AWS\": \"arn:aws:iam::444455556666:root\"}, \"Action\": [\"imagebuilder:GetImage\", \"imagebuilder:ListImages\"], \"Resource\": [\"arn:aws:imagebuilder:us-west-2:111122223333:image/my-example-recipe/1.0.0/1\"]}]}"
            });

            string imageArn = response.ImageArn;
            string requestId = response.RequestId;

            #endregion
        }

        public void ImagebuilderPutImageRecipePolicy()
        {
            #region share-an-image-recipe-with-another-account

            var client = new AmazonImagebuilderClient();
            var response = client.PutImageRecipePolicy(new PutImageRecipePolicyRequest 
            {
                ImageRecipeArn = "arn:aws:imagebuilder:us-west-2:111122223333:image-recipe/my-example-recipe/1.0.0",
                Policy = "{\"Version\": \"2012-10-17\", \"Statement\": [{\"Effect\": \"Allow\", \"Principal\": {\"AWS\": \"arn:aws:iam::444455556666:root\"}, \"Action\": [\"imagebuilder:GetImageRecipe\", \"imagebuilder:ListImageRecipes\"], \"Resource\": \"arn:aws:imagebuilder:us-west-2:111122223333:image-recipe/my-example-recipe/1.0.0\"}]}"
            });

            string imageRecipeArn = response.ImageRecipeArn;
            string requestId = response.RequestId;

            #endregion
        }

        public void ImagebuilderRetryImage()
        {
            #region retry-an-image-build

            var client = new AmazonImagebuilderClient();
            var response = client.RetryImage(new RetryImageRequest 
            {
                ClientToken = "a1b2c3d4-5678-90ab-cdef-EXAMPLEfffff",
                ImageBuildVersionArn = "arn:aws:imagebuilder:us-west-2:111122223333:image/my-example-recipe/1.0.0/1"
            });

            string clientToken = response.ClientToken;
            string imageBuildVersionArn = response.ImageBuildVersionArn;

            #endregion
        }

        public void ImagebuilderSendWorkflowStepAction()
        {
            #region stop-a-workflow-step-that-is-waiting-for-action

            var client = new AmazonImagebuilderClient();
            var response = client.SendWorkflowStepAction(new SendWorkflowStepActionRequest 
            {
                Action = "STOP",
                ClientToken = "a1b2c3d4-5678-90ab-cdef-EXAMPLE67890",
                ImageBuildVersionArn = "arn:aws:imagebuilder:us-west-2:111122223333:image/my-example-wait-recipe/1.0.0/1",
                StepExecutionId = "step-8eb24d7a-036e-46b5-94a3-90a5d8b5ac4a"
            });

            string clientToken = response.ClientToken;
            string imageBuildVersionArn = response.ImageBuildVersionArn;
            string stepExecutionId = response.StepExecutionId;

            #endregion
        }

        public void ImagebuilderStartImagePipelineExecution()
        {
            #region start-a-pipeline-build-manually

            var client = new AmazonImagebuilderClient();
            var response = client.StartImagePipelineExecution(new StartImagePipelineExecutionRequest 
            {
                ClientToken = "a1b2c3d4-5678-90ab-cdef-EXAMPLE66666",
                ImagePipelineArn = "arn:aws:imagebuilder:us-west-2:111122223333:image-pipeline/my-example-pipeline"
            });

            string clientToken = response.ClientToken;
            string imageBuildVersionArn = response.ImageBuildVersionArn;
            string requestId = response.RequestId;

            #endregion
        }

        public void ImagebuilderStartResourceStateUpdate()
        {
            #region schedule-an-image-build-version-for-deprecation

            var client = new AmazonImagebuilderClient();
            var response = client.StartResourceStateUpdate(new StartResourceStateUpdateRequest 
            {
                ClientToken = "a1b2c3d4-5678-90ab-cdef-EXAMPLE24680",
                ExecutionRole = "arn:aws:iam::111122223333:role/my-example-state-update-role",
                IncludeResources = new ResourceStateUpdateIncludeResources { Amis = true },
                ResourceArn = "arn:aws:imagebuilder:us-west-2:111122223333:image/my-example-recipe/1.0.0/1",
                State = new ResourceState { Status = "DEPRECATED" },
                UpdateAt = new DateTime(2026, 9, 11, 9, 20, 0, DateTimeKind.Utc)
            });

            string lifecycleExecutionId = response.LifecycleExecutionId;
            string resourceArn = response.ResourceArn;

            #endregion
        }

        public void ImagebuilderTagResource()
        {
            #region add-tags-to-a-component-build-version

            var client = new AmazonImagebuilderClient();
            var response = client.TagResource(new TagResourceRequest 
            {
                ResourceArn = "arn:aws:imagebuilder:us-west-2:111122223333:component/my-example-tagged-component/1.0.0/1",
                Tags = new Dictionary<string, string> {
                    { "CostCenter", "12345" },
                    { "Environment", "Production" }
                }
            });


            #endregion
        }

        public void ImagebuilderUntagResource()
        {
            #region remove-a-tag-from-a-resource

            var client = new AmazonImagebuilderClient();
            var response = client.UntagResource(new UntagResourceRequest 
            {
                ResourceArn = "arn:aws:imagebuilder:us-west-2:111122223333:component/my-example-tagged-component/1.0.0/1",
                TagKeys = new List<string> {
                    "CostCenter"
                }
            });


            #endregion
        }

        public void ImagebuilderUpdateDistributionConfiguration()
        {
            #region update-a-distribution-configuration

            var client = new AmazonImagebuilderClient();
            var response = client.UpdateDistributionConfiguration(new UpdateDistributionConfigurationRequest 
            {
                ClientToken = "a1b2c3d4-5678-90ab-cdef-EXAMPLEccccc",
                DistributionConfigurationArn = "arn:aws:imagebuilder:us-west-2:111122223333:distribution-configuration/my-example-distribution",
                Distributions = new List<Distribution> {
                    new Distribution {
                        AmiDistributionConfiguration = new AmiDistributionConfiguration { Name = "my-example-image-{{ imagebuilder:buildDate }}" },
                        Region = "us-west-2"
                    }
                }
            });

            string distributionConfigurationArn = response.DistributionConfigurationArn;
            string requestId = response.RequestId;

            #endregion
        }

        public void ImagebuilderUpdateImagePipeline()
        {
            #region update-an-image-pipeline

            var client = new AmazonImagebuilderClient();
            var response = client.UpdateImagePipeline(new UpdateImagePipelineRequest 
            {
                ClientToken = "a1b2c3d4-5678-90ab-cdef-EXAMPLEddddd",
                ImagePipelineArn = "arn:aws:imagebuilder:us-west-2:111122223333:image-pipeline/my-example-pipeline",
                ImageRecipeArn = "arn:aws:imagebuilder:us-west-2:111122223333:image-recipe/my-example-recipe/1.0.0",
                InfrastructureConfigurationArn = "arn:aws:imagebuilder:us-west-2:111122223333:infrastructure-configuration/my-example-infrastructure",
                Schedule = new Schedule {
                    PipelineExecutionStartCondition = "EXPRESSION_MATCH_AND_DEPENDENCY_UPDATES_AVAILABLE",
                    ScheduleExpression = "cron(0 6 * * ? *)"
                },
                Status = "ENABLED"
            });

            string imagePipelineArn = response.ImagePipelineArn;
            string requestId = response.RequestId;

            #endregion
        }

        public void ImagebuilderUpdateInfrastructureConfiguration()
        {
            #region update-an-infrastructure-configuration

            var client = new AmazonImagebuilderClient();
            var response = client.UpdateInfrastructureConfiguration(new UpdateInfrastructureConfigurationRequest 
            {
                ClientToken = "a1b2c3d4-5678-90ab-cdef-EXAMPLEbbbbb",
                Description = "An infrastructure configuration for Amazon Linux builds",
                InfrastructureConfigurationArn = "arn:aws:imagebuilder:us-west-2:111122223333:infrastructure-configuration/my-example-infrastructure",
                InstanceProfileName = "EC2InstanceProfileForImageBuilder",
                InstanceTypes = new List<string> {
                    "t3.large",
                    "t3.xlarge"
                },
                TerminateInstanceOnFailure = false
            });

            string infrastructureConfigurationArn = response.InfrastructureConfigurationArn;
            string requestId = response.RequestId;

            #endregion
        }

        public void ImagebuilderUpdateLifecyclePolicy()
        {
            #region update-a-lifecycle-policy

            var client = new AmazonImagebuilderClient();
            var response = client.UpdateLifecyclePolicy(new UpdateLifecyclePolicyRequest 
            {
                ClientToken = "a1b2c3d4-5678-90ab-cdef-EXAMPLEaaaaa",
                Description = "Deletes AMI images and their snapshots after 12 months, retaining the 3 most recent",
                ExecutionRole = "arn:aws:iam::111122223333:role/my-example-lifecycle-role",
                LifecyclePolicyArn = "arn:aws:imagebuilder:us-west-2:111122223333:lifecycle-policy/my-example-policy",
                PolicyDetails = new List<LifecyclePolicyDetail> {
                    new LifecyclePolicyDetail {
                        Action = new LifecyclePolicyDetailAction {
                            Type = "DELETE",
                            IncludeResources = new LifecyclePolicyDetailActionIncludeResources {
                                Amis = true,
                                Snapshots = true
                            }
                        },
                        Filter = new LifecyclePolicyDetailFilter {
                            Type = "AGE",
                            Value = 12,
                            RetainAtLeast = 3,
                            Unit = "MONTHS"
                        }
                    }
                },
                ResourceSelection = new LifecyclePolicyResourceSelection { TagMap = new Dictionary<string, string> {
                    { "environment", "production" }
                } },
                ResourceType = "AMI_IMAGE",
                Status = "ENABLED"
            });

            string lifecyclePolicyArn = response.LifecyclePolicyArn;

            #endregion
        }

        
        # region ISample Members
        public virtual void Run()
        {

        }
        # endregion

    }
}