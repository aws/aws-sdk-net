using System;
using System.Collections.Generic;
using System.IO;
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
            #region CancelImageCreation-1

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
            #region CancelLifecycleExecution-1

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
            #region CreateComponent-1

            var client = new AmazonImagebuilderClient();
            var response = client.CreateComponent(new CreateComponentRequest
            {
                ClientToken = "a1b2c3d4-5678-90ab-cdef-EXAMPLE10101",
                Description = "Installs a configurable version of my application",
                Name = "my-example-parameterized-component",
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

        public void ImagebuilderCreateComponent()
        {
            #region CreateComponent-2

            var client = new AmazonImagebuilderClient();
            var response = client.CreateComponent(new CreateComponentRequest
            {
                ClientToken = "a1b2c3d4-5678-90ab-cdef-EXAMPLE11111",
                Data = "name: InstallMyApp\ndescription: Installs my application\nschemaVersion: 1.0\nphases:\n  - name: build\n    steps:\n      - name: InstallApp\n        action: ExecuteBash\n        inputs:\n          commands:\n            - sudo yum -y install my-app\n",
                Description = "Installs the latest version of my application",
                Name = "my-example-component",
                Platform = "Linux",
                SemanticVersion = "1.0.0"
            });

            string clientToken = response.ClientToken;
            string componentBuildVersionArn = response.ComponentBuildVersionArn;
            LatestVersionReferences latestVersionReferences = response.LatestVersionReferences;
            string requestId = response.RequestId;

            #endregion
        }

        public void ImagebuilderCreateContainerRecipe()
        {
            #region CreateContainerRecipe-1

            var client = new AmazonImagebuilderClient();
            var response = client.CreateContainerRecipe(new CreateContainerRecipeRequest
            {
                ClientToken = "a1b2c3d4-5678-90ab-cdef-EXAMPLE40404",
                Components = new List<ComponentConfiguration> {
                    new ComponentConfiguration { ComponentArn = "arn:aws:imagebuilder:us-west-2:111122223333:component/my-example-container-component/1.0.0/1" }
                },
                ContainerType = "DOCKER",
                Description = "A container recipe that builds on an ECS-optimized instance image with a larger build volume",
                DockerfileTemplateData = "FROM {{{ imagebuilder:parentImage }}}\n{{{ imagebuilder:environments }}}\n{{{ imagebuilder:components }}}\n",
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
                Name = "my-example-container-recipe",
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

        public void ImagebuilderCreateContainerRecipe()
        {
            #region CreateContainerRecipe-2

            var client = new AmazonImagebuilderClient();
            var response = client.CreateContainerRecipe(new CreateContainerRecipeRequest
            {
                ClientToken = "a1b2c3d4-5678-90ab-cdef-EXAMPLE99999",
                Components = new List<ComponentConfiguration> {
                    new ComponentConfiguration { ComponentArn = "arn:aws:imagebuilder:us-west-2:111122223333:component/my-example-container-component/1.0.0/1" }
                },
                ContainerType = "DOCKER",
                DockerfileTemplateData = "FROM {{{ imagebuilder:parentImage }}}\n{{{ imagebuilder:environments }}}\n{{{ imagebuilder:components }}}\n",
                Name = "my-example-container-recipe",
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

        public void ImagebuilderCreateDistributionConfiguration()
        {
            #region CreateDistributionConfiguration-1

            var client = new AmazonImagebuilderClient();
            var response = client.CreateDistributionConfiguration(new CreateDistributionConfigurationRequest
            {
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
                },
                Name = "my-example-distribution"
            });

            string clientToken = response.ClientToken;
            string distributionConfigurationArn = response.DistributionConfigurationArn;
            string requestId = response.RequestId;

            #endregion
        }

        public void ImagebuilderCreateDistributionConfiguration()
        {
            #region CreateDistributionConfiguration-2

            var client = new AmazonImagebuilderClient();
            var response = client.CreateDistributionConfiguration(new CreateDistributionConfigurationRequest
            {
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
                            LaunchPermission = new LaunchPermissionConfiguration { UserIds = new List<string> {
                                "444455556666"
                            } },
                            Name = "my-example-image-{{ imagebuilder:buildDate }}"
                        },
                        Region = "us-east-1"
                    }
                },
                Name = "my-example-distribution"
            });

            string clientToken = response.ClientToken;
            string distributionConfigurationArn = response.DistributionConfigurationArn;
            string requestId = response.RequestId;

            #endregion
        }

        public void ImagebuilderCreateImage()
        {
            #region CreateImage-1

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
            #region CreateImage-2

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
            #region CreateImagePipeline-1

            var client = new AmazonImagebuilderClient();
            var response = client.CreateImagePipeline(new CreateImagePipelineRequest
            {
                ClientToken = "a1b2c3d4-5678-90ab-cdef-EXAMPLE55555",
                Description = "Builds a new version of my image every Sunday",
                DistributionConfigurationArn = "arn:aws:imagebuilder:us-west-2:111122223333:distribution-configuration/my-example-distribution",
                ImageRecipeArn = "arn:aws:imagebuilder:us-west-2:111122223333:image-recipe/my-example-recipe/1.0.0",
                InfrastructureConfigurationArn = "arn:aws:imagebuilder:us-west-2:111122223333:infrastructure-configuration/my-example-infrastructure",
                Name = "my-example-pipeline",
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
            #region CreateImagePipeline-2

            var client = new AmazonImagebuilderClient();
            var response = client.CreateImagePipeline(new CreateImagePipelineRequest
            {
                ClientToken = "a1b2c3d4-5678-90ab-cdef-EXAMPLE30303",
                Description = "Builds a scanned image with my custom build workflow on Sunday mornings when dependency updates are available",
                DistributionConfigurationArn = "arn:aws:imagebuilder:us-west-2:111122223333:distribution-configuration/my-example-distribution",
                ExecutionRole = "arn:aws:iam::111122223333:role/aws-service-role/imagebuilder.amazonaws.com/AWSServiceRoleForImageBuilder",
                ImageRecipeArn = "arn:aws:imagebuilder:us-west-2:111122223333:image-recipe/my-example-recipe/1.1.0",
                ImageScanningConfiguration = new ImageScanningConfiguration { ImageScanningEnabled = true },
                InfrastructureConfigurationArn = "arn:aws:imagebuilder:us-west-2:111122223333:infrastructure-configuration/my-example-infrastructure",
                Name = "my-example-pipeline",
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
            #region CreateImageRecipe-1

            var client = new AmazonImagebuilderClient();
            var response = client.CreateImageRecipe(new CreateImageRecipeRequest
            {
                ClientToken = "a1b2c3d4-5678-90ab-cdef-EXAMPLE22222",
                Components = new List<ComponentConfiguration> {
                    new ComponentConfiguration { ComponentArn = "arn:aws:imagebuilder:us-west-2:111122223333:component/my-example-component/1.0.0/1" }
                },
                Description = "An image recipe that installs my application on Amazon Linux 2023",
                Name = "my-example-recipe",
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
            #region CreateImageRecipe-2

            var client = new AmazonImagebuilderClient();
            var response = client.CreateImageRecipe(new CreateImageRecipeRequest
            {
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
                Name = "my-example-recipe",
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
            #region CreateInfrastructureConfiguration-1

            var client = new AmazonImagebuilderClient();
            var response = client.CreateInfrastructureConfiguration(new CreateInfrastructureConfigurationRequest
            {
                ClientToken = "a1b2c3d4-5678-90ab-cdef-EXAMPLE33333",
                Description = "An infrastructure configuration for Amazon Linux builds",
                InstanceProfileName = "EC2InstanceProfileForImageBuilder",
                InstanceTypes = new List<string> {
                    "t3.medium",
                    "t3.large"
                },
                Name = "my-example-infrastructure",
                TerminateInstanceOnFailure = true
            });

            string clientToken = response.ClientToken;
            string infrastructureConfigurationArn = response.InfrastructureConfigurationArn;
            string requestId = response.RequestId;

            #endregion
        }

        public void ImagebuilderCreateInfrastructureConfiguration()
        {
            #region CreateInfrastructureConfiguration-2

            var client = new AmazonImagebuilderClient();
            var response = client.CreateInfrastructureConfiguration(new CreateInfrastructureConfigurationRequest
            {
                ClientToken = "a1b2c3d4-5678-90ab-cdef-EXAMPLE98765",
                Description = "An infrastructure configuration that pins build instances to one Availability Zone and requires IMDSv2",
                InstanceMetadataOptions = new InstanceMetadataOptions {
                    HttpPutResponseHopLimit = 2,
                    HttpTokens = "required"
                },
                InstanceProfileName = "my-example-instance-role",
                Name = "my-example-infrastructure",
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
            #region CreateLifecyclePolicy-1

            var client = new AmazonImagebuilderClient();
            var response = client.CreateLifecyclePolicy(new CreateLifecyclePolicyRequest
            {
                ClientToken = "a1b2c3d4-5678-90ab-cdef-EXAMPLE13579",
                ExecutionRole = "arn:aws:iam::111122223333:role/my-example-lifecycle-role",
                Name = "my-example-lifecycle-policy",
                PolicyDetails = new List<LifecyclePolicyDetail> {
                    new LifecyclePolicyDetail {
                        Action = new LifecyclePolicyDetailAction { Type = "DELETE" },
                        Filter = new LifecyclePolicyDetailFilter {
                            Type = "AGE",
                            Unit = "MONTHS",
                            Value = 6
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
            #region CreateLifecyclePolicy-2

            var client = new AmazonImagebuilderClient();
            var response = client.CreateLifecyclePolicy(new CreateLifecyclePolicyRequest
            {
                ClientToken = "a1b2c3d4-5678-90ab-cdef-EXAMPLE43210",
                ExecutionRole = "arn:aws:iam::111122223333:role/my-example-lifecycle-role",
                Name = "my-example-lifecycle-policy",
                PolicyDetails = new List<LifecyclePolicyDetail> {
                    new LifecyclePolicyDetail {
                        Action = new LifecyclePolicyDetailAction { Type = "DELETE" },
                        ExclusionRules = new LifecyclePolicyDetailExclusionRules { Amis = new LifecyclePolicyDetailExclusionRulesAmis {
                            LastLaunched = new LifecyclePolicyDetailExclusionRulesAmisLastLaunched {
                                Unit = "DAYS",
                                Value = 30
                            },
                            TagMap = new Dictionary<string, string> {
                                { "Retention", "keep" }
                            }
                        } },
                        Filter = new LifecyclePolicyDetailFilter {
                            Type = "AGE",
                            Unit = "MONTHS",
                            Value = 6
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
            #region CreateWorkflow-1

            var client = new AmazonImagebuilderClient();
            var response = client.CreateWorkflow(new CreateWorkflowRequest
            {
                ClientToken = "a1b2c3d4-5678-90ab-cdef-EXAMPLE54321",
                Data = "name: my-example-workflow\ndescription: Workflow to build an AMI\nschemaVersion: 1.0\nsteps:\n  - name: LaunchBuildInstance\n    action: LaunchInstance\n    onFailure: Abort\n    inputs:\n      waitFor: ssmAgent\n  - name: ApplyBuildComponents\n    action: ExecuteComponents\n    onFailure: Abort\n    inputs:\n      instanceId.$: $.stepOutputs.LaunchBuildInstance.instanceId\n  - name: CreateOutputAMI\n    action: CreateImage\n    onFailure: Abort\n    inputs:\n      instanceId.$: $.stepOutputs.LaunchBuildInstance.instanceId\n  - name: TerminateBuildInstance\n    action: TerminateInstance\n    onFailure: Continue\n    inputs:\n      instanceId.$: $.stepOutputs.LaunchBuildInstance.instanceId\n",
                Description = "Workflow to build an AMI",
                Name = "my-example-workflow",
                SemanticVersion = "1.0.0",
                Type = "BUILD"
            });

            string clientToken = response.ClientToken;
            LatestVersionReferences latestVersionReferences = response.LatestVersionReferences;
            string workflowBuildVersionArn = response.WorkflowBuildVersionArn;

            #endregion
        }

        public void ImagebuilderDeleteComponent()
        {
            #region DeleteComponent-1

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
            #region DeleteContainerRecipe-1

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
            #region DeleteDistributionConfiguration-1

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
            #region DeleteImage-1

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
            #region DeleteImagePipeline-1

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
            #region DeleteImageRecipe-1

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
            #region DeleteInfrastructureConfiguration-1

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
            #region DeleteLifecyclePolicy-1

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
            #region DeleteWorkflow-1

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
            #region DistributeImage-1

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
            #region GetComponent-1

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
            #region GetComponentPolicy-1

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
            #region GetContainerRecipe-1

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
            #region GetContainerRecipePolicy-1

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
            #region GetDistributionConfiguration-1

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
            #region GetImage-1

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
            #region GetImagePipeline-1

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
            #region GetImagePolicy-1

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
            #region GetImageRecipe-1

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
            #region GetImageRecipePolicy-1

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
            #region GetInfrastructureConfiguration-1

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
            #region GetLifecycleExecution-1

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
            #region GetLifecyclePolicy-1

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
            #region GetWorkflow-1

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
            #region GetWorkflowExecution-1

            var client = new AmazonImagebuilderClient();
            var response = client.GetWorkflowExecution(new GetWorkflowExecutionRequest
            {
                WorkflowExecutionId = "wf-165b1cb6-3a62-4618-a021-94ddcbe32908"
            });

            string endTime = response.EndTime;
            string imageBuildVersionArn = response.ImageBuildVersionArn;
            string requestId = response.RequestId;
            string startTime = response.StartTime;
            WorkflowExecutionStatus status = response.Status;
            int? totalStepCount = response.TotalStepCount;
            int? totalStepsFailed = response.TotalStepsFailed;
            int? totalStepsSkipped = response.TotalStepsSkipped;
            int? totalStepsSucceeded = response.TotalStepsSucceeded;
            WorkflowType type = response.Type;
            string workflowBuildVersionArn = response.WorkflowBuildVersionArn;
            string workflowExecutionId = response.WorkflowExecutionId;

            #endregion
        }

        public void ImagebuilderGetWorkflowStepExecution()
        {
            #region GetWorkflowStepExecution-1

            var client = new AmazonImagebuilderClient();
            var response = client.GetWorkflowStepExecution(new GetWorkflowStepExecutionRequest
            {
                StepExecutionId = "step-2e6fef0d-657c-4b7e-8706-ff24da9afa01"
            });

            string action = response.Action;
            string endTime = response.EndTime;
            string imageBuildVersionArn = response.ImageBuildVersionArn;
            string inputs = response.Inputs;
            string name = response.Name;
            string onFailure = response.OnFailure;
            string outputs = response.Outputs;
            string requestId = response.RequestId;
            string startTime = response.StartTime;
            WorkflowStepExecutionStatus status = response.Status;
            string stepExecutionId = response.StepExecutionId;
            int? timeoutSeconds = response.TimeoutSeconds;
            string workflowBuildVersionArn = response.WorkflowBuildVersionArn;
            string workflowExecutionId = response.WorkflowExecutionId;

            #endregion
        }

        public void ImagebuilderImportComponent()
        {
            #region ImportComponent-1

            var client = new AmazonImagebuilderClient();
            var response = client.ImportComponent(new ImportComponentRequest
            {
                ClientToken = "a1b2c3d4-5678-90ab-cdef-EXAMPLE88888",
                Data = "sudo yum update -y\nsudo yum -y install my-app\n",
                Description = "Installs my application from an imported shell script",
                Format = "SHELL",
                Name = "my-example-imported-component",
                Platform = "Linux",
                SemanticVersion = "1.0.0",
                Type = "BUILD"
            });

            string clientToken = response.ClientToken;
            string componentBuildVersionArn = response.ComponentBuildVersionArn;
            string requestId = response.RequestId;

            #endregion
        }

        public void ImagebuilderImportDiskImage()
        {
            #region ImportDiskImage-1

            var client = new AmazonImagebuilderClient();
            var response = client.ImportDiskImage(new ImportDiskImageRequest
            {
                ClientToken = "a1b2c3d4-5678-90ab-cdef-EXAMPLE12345",
                InfrastructureConfigurationArn = "arn:aws:imagebuilder:us-west-2:111122223333:infrastructure-configuration/my-example-infrastructure",
                Name = "my-example-imported-image",
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
            #region ImportVmImage-1

            var client = new AmazonImagebuilderClient();
            var response = client.ImportVmImage(new ImportVmImageRequest
            {
                ClientToken = "a1b2c3d4-5678-90ab-cdef-EXAMPLE00000",
                Name = "my-example-imported-image",
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
            #region ListComponentBuildVersions-1

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
            #region ListComponents-1

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
            #region ListContainerRecipes-1

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
            #region ListDistributionConfigurations-1

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
            #region ListImageBuildVersions-1

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
            #region ListImagePackages-1

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
            #region ListImagePipelineImages-1

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
            #region ListImagePipelines-1

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
            #region ListImageRecipes-1

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
            #region ListImages-1

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
            #region ListImageScanFindingAggregations-1

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
            #region ListImageScanFindings-1

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
            #region ListInfrastructureConfigurations-1

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
            #region ListLifecycleExecutionResources-1

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
            #region ListLifecycleExecutions-1

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
            #region ListLifecyclePolicies-1

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
            #region ListTagsForResource-1

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
            #region ListWaitingWorkflowSteps-1

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
            #region ListWorkflowBuildVersions-1

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
            #region ListWorkflowExecutions-1

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
            #region ListWorkflows-1

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
            #region ListWorkflowStepExecutions-1

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
            #region PutComponentPolicy-1

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
            #region PutContainerRecipePolicy-1

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
            #region PutImagePolicy-1

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
            #region PutImageRecipePolicy-1

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
            #region RetryImage-1

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
            #region SendWorkflowStepAction-1

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
            #region StartImagePipelineExecution-1

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
            #region StartResourceStateUpdate-1

            var client = new AmazonImagebuilderClient();
            var response = client.StartResourceStateUpdate(new StartResourceStateUpdateRequest
            {
                ClientToken = "a1b2c3d4-5678-90ab-cdef-EXAMPLE24680",
                ExecutionRole = "arn:aws:iam::111122223333:role/my-example-state-update-role",
                IncludeResources = new ResourceStateUpdateIncludeResources { Amis = true },
                ResourceArn = "arn:aws:imagebuilder:us-west-2:111122223333:image/my-example-recipe/1.0.0/1",
                State = new ResourceState { Status = "DEPRECATED" },
                UpdateAt = new DateTime(2026, 9, 11, 21, 20, 0, DateTimeKind.Utc)
            });

            string lifecycleExecutionId = response.LifecycleExecutionId;
            string resourceArn = response.ResourceArn;

            #endregion
        }

        public void ImagebuilderTagResource()
        {
            #region TagResource-1

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
            #region UntagResource-1

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
            #region UpdateDistributionConfiguration-1

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
            #region UpdateImagePipeline-1

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
            #region UpdateInfrastructureConfiguration-1

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
            #region UpdateLifecyclePolicy-1

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
                            IncludeResources = new LifecyclePolicyDetailActionIncludeResources {
                                Amis = true,
                                Snapshots = true
                            },
                            Type = "DELETE"
                        },
                        Filter = new LifecyclePolicyDetailFilter {
                            RetainAtLeast = 3,
                            Type = "AGE",
                            Unit = "MONTHS",
                            Value = 12
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

        #region ISample Members
        public virtual void Run()
        {
        }
        #endregion
    }
}
