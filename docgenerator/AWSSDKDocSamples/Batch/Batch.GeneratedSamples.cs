using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Amazon.Batch;
using Amazon.Batch.Model;

namespace AWSSDKDocSamples.Amazon.Batch.Generated
{
    class BatchSamples : ISample
    {
        public void BatchCancelJob()
        {
            #region CancelJob-1

            var client = new AmazonBatchClient();
            var response = client.CancelJob(new CancelJobRequest
            {
                JobId = "1d828f65-7a4d-42e8-996d-3b900ed59dc4",
                Reason = "Cancelling job."
            });


            #endregion
        }

        public void BatchCancelJobs()
        {
            #region CancelJobs-1

            var client = new AmazonBatchClient();
            var response = client.CancelJobs(new CancelJobsRequest
            {
                Jobs = new List<string> {
                    "1d828f65-7a4d-42e8-996d-3b900ed59dc4",
                    "b3d0f26e-6d3a-4a5b-9c2e-7f4a1b2c3d4e"
                },
                Reason = "Cancelling jobs."
            });

            List<CancelJobsErrorDetail> errors = response.Errors;
            List<string> successful = response.Successful;

            #endregion
        }

        public void BatchCreateComputeEnvironment()
        {
            #region CreateComputeEnvironment-1

            var client = new AmazonBatchClient();
            var response = client.CreateComputeEnvironment(new CreateComputeEnvironmentRequest
            {
                ComputeEnvironmentName = "C4OnDemand",
                ComputeResources = new ComputeResource {
                    DesiredvCpus = 48,
                    Ec2KeyPair = "id_rsa",
                    InstanceRole = "ecsInstanceRole",
                    InstanceTypes = new List<string> {
                        "c4.large",
                        "c4.xlarge",
                        "c4.2xlarge",
                        "c4.4xlarge",
                        "c4.8xlarge"
                    },
                    MaxvCpus = 128,
                    MinvCpus = 0,
                    SecurityGroupIds = new List<string> {
                        "sg-cf5093b2"
                    },
                    Subnets = new List<string> {
                        "subnet-220c0e0a",
                        "subnet-1a95556d",
                        "subnet-978f6dce"
                    },
                    Tags = new Dictionary<string, string> {
                        { "Name", "Batch Instance - C4OnDemand" }
                    },
                    Type = "EC2"
                },
                ServiceRole = "arn:aws:iam::012345678910:role/AWSBatchServiceRole",
                State = "ENABLED",
                Type = "MANAGED"
            });

            string computeEnvironmentArn = response.ComputeEnvironmentArn;
            string computeEnvironmentName = response.ComputeEnvironmentName;

            #endregion
        }

        public void BatchCreateComputeEnvironment()
        {
            #region CreateComputeEnvironment-2

            var client = new AmazonBatchClient();
            var response = client.CreateComputeEnvironment(new CreateComputeEnvironmentRequest
            {
                ComputeEnvironmentName = "M4Spot",
                ComputeResources = new ComputeResource {
                    BidPercentage = 20,
                    DesiredvCpus = 4,
                    Ec2KeyPair = "id_rsa",
                    InstanceRole = "ecsInstanceRole",
                    InstanceTypes = new List<string> {
                        "m4"
                    },
                    MaxvCpus = 128,
                    MinvCpus = 0,
                    SecurityGroupIds = new List<string> {
                        "sg-cf5093b2"
                    },
                    SpotIamFleetRole = "arn:aws:iam::012345678910:role/aws-ec2-spot-fleet-role",
                    Subnets = new List<string> {
                        "subnet-220c0e0a",
                        "subnet-1a95556d",
                        "subnet-978f6dce"
                    },
                    Tags = new Dictionary<string, string> {
                        { "Name", "Batch Instance - M4Spot" }
                    },
                    Type = "SPOT"
                },
                ServiceRole = "arn:aws:iam::012345678910:role/AWSBatchServiceRole",
                State = "ENABLED",
                Type = "MANAGED"
            });

            string computeEnvironmentArn = response.ComputeEnvironmentArn;
            string computeEnvironmentName = response.ComputeEnvironmentName;

            #endregion
        }

        public void BatchCreateComputeEnvironment()
        {
            #region CreateComputeEnvironment-3

            var client = new AmazonBatchClient();
            var response = client.CreateComputeEnvironment(new CreateComputeEnvironmentRequest
            {
                ComputeEnvironmentName = "my-reserved-managed-instances-ce",
                ComputeResources = new ComputeResource {
                    ManagedInstancesProvider = new ManagedInstancesProvider {
                        InfrastructureRoleArn = "arn:aws:iam::123456789012:role/ecsInfrastructureRole",
                        InstanceLaunchTemplate = new InstanceLaunchTemplate {
                            CapacityReservations = new CapacityReservationRequest {
                                ReservationGroupArn = "arn:aws:ec2:us-east-1:123456789012:capacity-reservation-group/my-reservation-group",
                                ReservationPreference = "RESERVATIONS_FIRST"
                            },
                            Ec2InstanceProfileArn = "arn:aws:iam::123456789012:instance-profile/ecsInstanceProfile",
                            InstanceRequirements = new InstanceRequirementsRequest { AllowedInstanceTypes = new List<string> {
                                "m5.xlarge",
                                "m5.2xlarge"
                            } },
                            NetworkConfiguration = new ManagedInstancesNetworkConfiguration {
                                SecurityGroups = new List<string> {
                                    "sg-abcde012"
                                },
                                Subnets = new List<string> {
                                    "subnet-abcde012",
                                    "subnet-bcde012a"
                                }
                            }
                        }
                    },
                    MaxvCpus = 512,
                    Type = "ECS_MANAGED_INSTANCES"
                },
                State = "ENABLED",
                Type = "MANAGED"
            });

            string computeEnvironmentArn = response.ComputeEnvironmentArn;
            string computeEnvironmentName = response.ComputeEnvironmentName;

            #endregion
        }

        public void BatchCreateComputeEnvironment()
        {
            #region CreateComputeEnvironment-4

            var client = new AmazonBatchClient();
            var response = client.CreateComputeEnvironment(new CreateComputeEnvironmentRequest
            {
                ComputeEnvironmentName = "my-managed-instances-ce",
                ComputeResources = new ComputeResource {
                    ManagedInstancesProvider = new ManagedInstancesProvider {
                        InfrastructureRoleArn = "arn:aws:iam::123456789012:role/ecsInfrastructureRole",
                        InstanceLaunchTemplate = new InstanceLaunchTemplate {
                            Ec2InstanceProfileArn = "arn:aws:iam::123456789012:instance-profile/ecsInstanceProfile",
                            NetworkConfiguration = new ManagedInstancesNetworkConfiguration {
                                SecurityGroups = new List<string> {
                                    "sg-abcde012"
                                },
                                Subnets = new List<string> {
                                    "subnet-abcde012",
                                    "subnet-bcde012a"
                                }
                            }
                        }
                    },
                    MaxvCpus = 256,
                    Type = "ECS_MANAGED_INSTANCES"
                },
                State = "ENABLED",
                Type = "MANAGED"
            });

            string computeEnvironmentArn = response.ComputeEnvironmentArn;
            string computeEnvironmentName = response.ComputeEnvironmentName;

            #endregion
        }

        public void BatchCreateComputeEnvironment()
        {
            #region CreateComputeEnvironment-5

            var client = new AmazonBatchClient();
            var response = client.CreateComputeEnvironment(new CreateComputeEnvironmentRequest
            {
                ComputeEnvironmentName = "my-spot-managed-instances-ce",
                ComputeResources = new ComputeResource {
                    ManagedInstancesProvider = new ManagedInstancesProvider {
                        InfrastructureRoleArn = "arn:aws:iam::123456789012:role/ecsInfrastructureRole",
                        InstanceLaunchTemplate = new InstanceLaunchTemplate {
                            CapacityOptionType = "SPOT",
                            Ec2InstanceProfileArn = "arn:aws:iam::123456789012:instance-profile/ecsInstanceProfile",
                            InstanceRequirements = new InstanceRequirementsRequest { AllowedInstanceTypes = new List<string> {
                                "m5.large",
                                "m5.xlarge",
                                "m6i.large",
                                "m6i.xlarge"
                            } },
                            NetworkConfiguration = new ManagedInstancesNetworkConfiguration {
                                SecurityGroups = new List<string> {
                                    "sg-abcde012"
                                },
                                Subnets = new List<string> {
                                    "subnet-abcde012",
                                    "subnet-bcde012a"
                                }
                            }
                        }
                    },
                    MaxvCpus = 1000,
                    Type = "ECS_MANAGED_INSTANCES"
                },
                State = "ENABLED",
                Type = "MANAGED"
            });

            string computeEnvironmentArn = response.ComputeEnvironmentArn;
            string computeEnvironmentName = response.ComputeEnvironmentName;

            #endregion
        }

        public void BatchCreateConsumableResource()
        {
            #region CreateConsumableResource-1

            var client = new AmazonBatchClient();
            var response = client.CreateConsumableResource(new CreateConsumableResourceRequest
            {
                ConsumableResourceName = "myConsumableResource",
                ResourceType = "REPLENISHABLE",
                Tags = new Dictionary<string, string> {
                    { "Department", "Engineering" },
                    { "User", "JaneDoe" }
                },
                TotalQuantity = 123
            });

            string consumableResourceArn = response.ConsumableResourceArn;
            string consumableResourceName = response.ConsumableResourceName;

            #endregion
        }

        public void BatchCreateJobQueue()
        {
            #region CreateJobQueue-1

            var client = new AmazonBatchClient();
            var response = client.CreateJobQueue(new CreateJobQueueRequest
            {
                ComputeEnvironmentOrder = new List<ComputeEnvironmentOrder> {
                    new ComputeEnvironmentOrder {
                        ComputeEnvironment = "M4Spot",
                        Order = 1
                    }
                },
                JobQueueName = "LowPriority",
                Priority = 1,
                State = "ENABLED"
            });

            string jobQueueArn = response.JobQueueArn;
            string jobQueueName = response.JobQueueName;

            #endregion
        }

        public void BatchCreateJobQueue()
        {
            #region CreateJobQueue-2

            var client = new AmazonBatchClient();
            var response = client.CreateJobQueue(new CreateJobQueueRequest
            {
                ComputeEnvironmentOrder = new List<ComputeEnvironmentOrder> {
                    new ComputeEnvironmentOrder {
                        ComputeEnvironment = "my-managed-instances-ce",
                        Order = 1
                    }
                },
                JobQueueName = "ManagedInstancesQueue",
                Priority = 10,
                State = "ENABLED"
            });

            string jobQueueArn = response.JobQueueArn;
            string jobQueueName = response.JobQueueName;

            #endregion
        }

        public void BatchCreateJobQueue()
        {
            #region CreateJobQueue-3

            var client = new AmazonBatchClient();
            var response = client.CreateJobQueue(new CreateJobQueueRequest
            {
                ComputeEnvironmentOrder = new List<ComputeEnvironmentOrder> {
                    new ComputeEnvironmentOrder {
                        ComputeEnvironment = "C4OnDemand",
                        Order = 1
                    },
                    new ComputeEnvironmentOrder {
                        ComputeEnvironment = "M4Spot",
                        Order = 2
                    }
                },
                JobQueueName = "HighPriority",
                Priority = 10,
                State = "ENABLED"
            });

            string jobQueueArn = response.JobQueueArn;
            string jobQueueName = response.JobQueueName;

            #endregion
        }

        public void BatchCreateJobQueue()
        {
            #region CreateJobQueue-4

            var client = new AmazonBatchClient();
            var response = client.CreateJobQueue(new CreateJobQueueRequest
            {
                ComputeEnvironmentOrder = new List<ComputeEnvironmentOrder> {
                    new ComputeEnvironmentOrder {
                        ComputeEnvironment = "my-managed-instances-ce",
                        Order = 1
                    },
                    new ComputeEnvironmentOrder {
                        ComputeEnvironment = "my-spot-managed-instances-ce",
                        Order = 2
                    }
                },
                JobQueueName = "ManagedInstancesMixedQueue",
                Priority = 5,
                State = "ENABLED"
            });

            string jobQueueArn = response.JobQueueArn;
            string jobQueueName = response.JobQueueName;

            #endregion
        }

        public void BatchDeleteComputeEnvironment()
        {
            #region DeleteComputeEnvironment-1

            var client = new AmazonBatchClient();
            var response = client.DeleteComputeEnvironment(new DeleteComputeEnvironmentRequest
            {
                ComputeEnvironment = "P2OnDemand"
            });


            #endregion
        }

        public void BatchDeleteConsumableResource()
        {
            #region DeleteConsumableResource-1

            var client = new AmazonBatchClient();
            var response = client.DeleteConsumableResource(new DeleteConsumableResourceRequest
            {
                ConsumableResource = "myConsumableResource"
            });


            #endregion
        }

        public void BatchDeleteJobQueue()
        {
            #region DeleteJobQueue-1

            var client = new AmazonBatchClient();
            var response = client.DeleteJobQueue(new DeleteJobQueueRequest
            {
                JobQueue = "GPGPU"
            });


            #endregion
        }

        public void BatchDeregisterJobDefinition()
        {
            #region DeregisterJobDefinition-1

            var client = new AmazonBatchClient();
            var response = client.DeregisterJobDefinition(new DeregisterJobDefinitionRequest
            {
                JobDefinition = "sleep10"
            });


            #endregion
        }

        public void BatchDescribeComputeEnvironments()
        {
            #region DescribeComputeEnvironments-1

            var client = new AmazonBatchClient();
            var response = client.DescribeComputeEnvironments(new DescribeComputeEnvironmentsRequest
            {
                ComputeEnvironments = new List<string> {
                    "P2OnDemand"
                }
            });

            List<ComputeEnvironmentDetail> computeEnvironments = response.ComputeEnvironments;

            #endregion
        }

        public void BatchDescribeConsumableResource()
        {
            #region DescribeConsumableResource-1

            var client = new AmazonBatchClient();
            var response = client.DescribeConsumableResource(new DescribeConsumableResourceRequest
            {
                ConsumableResource = "myConsumableResource"
            });

            long? availableQuantity = response.AvailableQuantity;
            string consumableResourceArn = response.ConsumableResourceArn;
            string consumableResourceName = response.ConsumableResourceName;
            long? createdAt = response.CreatedAt;
            long? inUseQuantity = response.InUseQuantity;
            string resourceType = response.ResourceType;
            Dictionary<string, string> tags = response.Tags;
            long? totalQuantity = response.TotalQuantity;

            #endregion
        }

        public void BatchDescribeJobDefinitions()
        {
            #region DescribeJobDefinitions-1

            var client = new AmazonBatchClient();
            var response = client.DescribeJobDefinitions(new DescribeJobDefinitionsRequest
            {
                Status = "ACTIVE"
            });

            List<JobDefinition> jobDefinitions = response.JobDefinitions;

            #endregion
        }

        public void BatchDescribeJobQueues()
        {
            #region DescribeJobQueues-1

            var client = new AmazonBatchClient();
            var response = client.DescribeJobQueues(new DescribeJobQueuesRequest
            {
                JobQueues = new List<string> {
                    "HighPriority"
                }
            });

            List<JobQueueDetail> jobQueues = response.JobQueues;

            #endregion
        }

        public void BatchDescribeJobs()
        {
            #region DescribeJobs-1

            var client = new AmazonBatchClient();
            var response = client.DescribeJobs(new DescribeJobsRequest
            {
                Jobs = new List<string> {
                    "24fa2d7a-64c4-49d2-8b47-f8da4fbde8e9"
                }
            });

            List<JobDetail> jobs = response.Jobs;

            #endregion
        }

        public void BatchListConsumableResources()
        {
            #region ListConsumableResources-1

            var client = new AmazonBatchClient();
            var response = client.ListConsumableResources(new ListConsumableResourcesRequest
            {
                Filters = new List<KeyValuesPair> {
                    new KeyValuesPair {
                        Name = "CONSUMABLE_RESOURCE_NAME",
                        Values = new List<string> {
                            "my*"
                        }
                    }
                },
                MaxResults = 123
            });

            List<ConsumableResourceSummary> consumableResources = response.ConsumableResources;

            #endregion
        }

        public void BatchListJobs()
        {
            #region ListJobs-1

            var client = new AmazonBatchClient();
            var response = client.ListJobs(new ListJobsRequest
            {
                JobQueue = "HighPriority"
            });

            List<JobSummary> jobSummaryList = response.JobSummaryList;

            #endregion
        }

        public void BatchListJobs()
        {
            #region ListJobs-2

            var client = new AmazonBatchClient();
            var response = client.ListJobs(new ListJobsRequest
            {
                JobQueue = "HighPriority",
                JobStatus = "SUBMITTED"
            });

            List<JobSummary> jobSummaryList = response.JobSummaryList;

            #endregion
        }

        public void BatchListJobsByConsumableResource()
        {
            #region ListJobsByConsumableResource-1

            var client = new AmazonBatchClient();
            var response = client.ListJobsByConsumableResource(new ListJobsByConsumableResourceRequest
            {
                ConsumableResource = "myConsumableResource",
                Filters = new List<KeyValuesPair> {
                    new KeyValuesPair {
                        Name = "CONSUMABLE_RESOURCE_NAME",
                        Values = new List<string> {
                            "my*"
                        }
                    }
                },
                MaxResults = 123
            });

            List<ListJobsByConsumableResourceSummary> jobs = response.Jobs;

            #endregion
        }

        public void BatchListTagsForResource()
        {
            #region ListTagsForResource-1

            var client = new AmazonBatchClient();
            var response = client.ListTagsForResource(new ListTagsForResourceRequest
            {
                ResourceArn = "arn:aws:batch:us-east-1:123456789012:job-definition/sleep30:1"
            });

            Dictionary<string, string> tags = response.Tags;

            #endregion
        }

        public void BatchRegisterJobDefinition()
        {
            #region RegisterJobDefinition-1

            var client = new AmazonBatchClient();
            var response = client.RegisterJobDefinition(new RegisterJobDefinitionRequest
            {
                ContainerProperties = new ContainerProperties {
                    Command = new List<string> {
                        "sleep",
                        "30"
                    },
                    Image = "busybox",
                    ResourceRequirements = new List<ResourceRequirement> {
                        new ResourceRequirement {
                            Type = "MEMORY",
                            Value = "128"
                        },
                        new ResourceRequirement {
                            Type = "VCPU",
                            Value = "1"
                        }
                    }
                },
                JobDefinitionName = "sleep30",
                Tags = new Dictionary<string, string> {
                    { "Department", "Engineering" },
                    { "User", "JaneDoe" }
                },
                Type = "container"
            });

            string jobDefinitionArn = response.JobDefinitionArn;
            string jobDefinitionName = response.JobDefinitionName;
            int? revision = response.Revision;

            #endregion
        }

        public void BatchRegisterJobDefinition()
        {
            #region RegisterJobDefinition-2

            var client = new AmazonBatchClient();
            var response = client.RegisterJobDefinition(new RegisterJobDefinitionRequest
            {
                EcsProperties = new EcsProperties { TaskProperties = new List<EcsTaskProperties> {
                    new EcsTaskProperties {
                        Containers = new List<TaskContainerProperties> {
                            new TaskContainerProperties {
                                Command = new List<string> {
                                    "nvidia-smi"
                                },
                                Image = "123456789012.dkr.ecr.us-east-1.amazonaws.com/my-gpu-image:latest",
                                Name = "main",
                                ResourceRequirements = new List<ResourceRequirement> {
                                    new ResourceRequirement {
                                        Type = "VCPU",
                                        Value = "4"
                                    },
                                    new ResourceRequirement {
                                        Type = "MEMORY",
                                        Value = "16384"
                                    },
                                    new ResourceRequirement {
                                        Type = "GPU",
                                        Value = "1"
                                    }
                                }
                            }
                        },
                        ExecutionRoleArn = "arn:aws:iam::123456789012:role/ecsTaskExecutionRole"
                    }
                } },
                JobDefinitionName = "my-gpu-managed-instances-job-def",
                PlatformCapabilities = new List<string> {
                    "MANAGED_INSTANCES"
                },
                Type = "container"
            });

            string jobDefinitionArn = response.JobDefinitionArn;
            string jobDefinitionName = response.JobDefinitionName;
            int? revision = response.Revision;

            #endregion
        }

        public void BatchRegisterJobDefinition()
        {
            #region RegisterJobDefinition-3

            var client = new AmazonBatchClient();
            var response = client.RegisterJobDefinition(new RegisterJobDefinitionRequest
            {
                ContainerProperties = new ContainerProperties {
                    Command = new List<string> {
                        "sleep",
                        "10"
                    },
                    Image = "busybox",
                    ResourceRequirements = new List<ResourceRequirement> {
                        new ResourceRequirement {
                            Type = "MEMORY",
                            Value = "128"
                        },
                        new ResourceRequirement {
                            Type = "VCPU",
                            Value = "1"
                        }
                    }
                },
                JobDefinitionName = "sleep10",
                Type = "container"
            });

            string jobDefinitionArn = response.JobDefinitionArn;
            string jobDefinitionName = response.JobDefinitionName;
            int? revision = response.Revision;

            #endregion
        }

        public void BatchRegisterJobDefinition()
        {
            #region RegisterJobDefinition-4

            var client = new AmazonBatchClient();
            var response = client.RegisterJobDefinition(new RegisterJobDefinitionRequest
            {
                EcsProperties = new EcsProperties { TaskProperties = new List<EcsTaskProperties> {
                    new EcsTaskProperties {
                        Containers = new List<TaskContainerProperties> {
                            new TaskContainerProperties {
                                Command = new List<string> {
                                    "echo",
                                    "hello managed instances"
                                },
                                Image = "public.ecr.aws/amazonlinux/amazonlinux:2023",
                                Name = "main",
                                ResourceRequirements = new List<ResourceRequirement> {
                                    new ResourceRequirement {
                                        Type = "VCPU",
                                        Value = "1"
                                    },
                                    new ResourceRequirement {
                                        Type = "MEMORY",
                                        Value = "1024"
                                    }
                                }
                            }
                        },
                        ExecutionRoleArn = "arn:aws:iam::123456789012:role/ecsTaskExecutionRole"
                    }
                } },
                JobDefinitionName = "my-managed-instances-job-def",
                PlatformCapabilities = new List<string> {
                    "MANAGED_INSTANCES"
                },
                Type = "container"
            });

            string jobDefinitionArn = response.JobDefinitionArn;
            string jobDefinitionName = response.JobDefinitionName;
            int? revision = response.Revision;

            #endregion
        }

        public void BatchRegisterJobDefinition()
        {
            #region RegisterJobDefinition-5

            var client = new AmazonBatchClient();
            var response = client.RegisterJobDefinition(new RegisterJobDefinitionRequest
            {
                EcsProperties = new EcsProperties { TaskProperties = new List<EcsTaskProperties> {
                    new EcsTaskProperties {
                        Containers = new List<TaskContainerProperties> {
                            new TaskContainerProperties {
                                Command = new List<string> {
                                    "echo",
                                    "processing data"
                                },
                                Essential = true,
                                Image = "public.ecr.aws/amazonlinux/amazonlinux:2023",
                                Name = "main",
                                ResourceRequirements = new List<ResourceRequirement> {
                                    new ResourceRequirement {
                                        Type = "VCPU",
                                        Value = "2"
                                    },
                                    new ResourceRequirement {
                                        Type = "MEMORY",
                                        Value = "4096"
                                    }
                                }
                            },
                            new TaskContainerProperties {
                                Command = new List<string> {
                                    "echo",
                                    "logging sidecar"
                                },
                                Essential = false,
                                Image = "public.ecr.aws/amazonlinux/amazonlinux:2023",
                                Name = "sidecar",
                                ResourceRequirements = new List<ResourceRequirement> {
                                    new ResourceRequirement {
                                        Type = "VCPU",
                                        Value = "1"
                                    },
                                    new ResourceRequirement {
                                        Type = "MEMORY",
                                        Value = "512"
                                    }
                                }
                            }
                        },
                        ExecutionRoleArn = "arn:aws:iam::123456789012:role/ecsTaskExecutionRole"
                    }
                } },
                JobDefinitionName = "my-sidecar-managed-instances-job-def",
                PlatformCapabilities = new List<string> {
                    "MANAGED_INSTANCES"
                },
                Type = "container"
            });

            string jobDefinitionArn = response.JobDefinitionArn;
            string jobDefinitionName = response.JobDefinitionName;
            int? revision = response.Revision;

            #endregion
        }

        public void BatchSubmitJob()
        {
            #region SubmitJob-1

            var client = new AmazonBatchClient();
            var response = client.SubmitJob(new SubmitJobRequest
            {
                JobDefinition = "sleep60",
                JobName = "example",
                JobQueue = "HighPriority"
            });

            string jobId = response.JobId;
            string jobName = response.JobName;

            #endregion
        }

        public void BatchTagResource()
        {
            #region TagResource-1

            var client = new AmazonBatchClient();
            var response = client.TagResource(new TagResourceRequest
            {
                ResourceArn = "arn:aws:batch:us-east-1:123456789012:job-definition/sleep30:1",
                Tags = new Dictionary<string, string> {
                    { "Stage", "Alpha" }
                }
            });


            #endregion
        }

        public void BatchTerminateJob()
        {
            #region TerminateJob-1

            var client = new AmazonBatchClient();
            var response = client.TerminateJob(new TerminateJobRequest
            {
                JobId = "61e743ed-35e4-48da-b2de-5c8333821c84",
                Reason = "Terminating job."
            });


            #endregion
        }

        public void BatchTerminateJobs()
        {
            #region TerminateJobs-1

            var client = new AmazonBatchClient();
            var response = client.TerminateJobs(new TerminateJobsRequest
            {
                Jobs = new List<string> {
                    "61e743ed-35e4-48da-b2de-5c8333821c84",
                    "b3d0f26e-6d3a-4a5b-9c2e-7f4a1b2c3d4e"
                },
                Reason = "Terminating jobs."
            });

            List<TerminateJobsErrorDetail> errors = response.Errors;
            List<string> successful = response.Successful;

            #endregion
        }

        public void BatchTerminateServiceJobs()
        {
            #region TerminateServiceJobs-1

            var client = new AmazonBatchClient();
            var response = client.TerminateServiceJobs(new TerminateServiceJobsRequest
            {
                Jobs = new List<string> {
                    "a4d6c728-8ee8-4c65-8e2a-9a5e8f4b7c3d",
                    "b3d0f26e-6d3a-4a5b-9c2e-7f4a1b2c3d4e"
                },
                Reason = "Job terminated by user request"
            });

            List<TerminateServiceJobsErrorDetail> errors = response.Errors;
            List<string> successful = response.Successful;

            #endregion
        }

        public void BatchUntagResource()
        {
            #region UntagResource-1

            var client = new AmazonBatchClient();
            var response = client.UntagResource(new UntagResourceRequest
            {
                ResourceArn = "arn:aws:batch:us-east-1:123456789012:job-definition/sleep30:1",
                TagKeys = new List<string> {
                    "Stage"
                }
            });


            #endregion
        }

        public void BatchUpdateComputeEnvironment()
        {
            #region UpdateComputeEnvironment-1

            var client = new AmazonBatchClient();
            var response = client.UpdateComputeEnvironment(new UpdateComputeEnvironmentRequest
            {
                ComputeEnvironment = "P2OnDemand",
                State = "DISABLED"
            });

            string computeEnvironmentArn = response.ComputeEnvironmentArn;
            string computeEnvironmentName = response.ComputeEnvironmentName;

            #endregion
        }

        public void BatchUpdateConsumableResource()
        {
            #region UpdateConsumableResource-1

            var client = new AmazonBatchClient();
            var response = client.UpdateConsumableResource(new UpdateConsumableResourceRequest
            {
                ConsumableResource = "myConsumableResource",
                Operation = "ADD",
                Quantity = 12
            });

            string consumableResourceArn = response.ConsumableResourceArn;
            string consumableResourceName = response.ConsumableResourceName;
            long? totalQuantity = response.TotalQuantity;

            #endregion
        }

        public void BatchUpdateJobQueue()
        {
            #region UpdateJobQueue-1

            var client = new AmazonBatchClient();
            var response = client.UpdateJobQueue(new UpdateJobQueueRequest
            {
                JobQueue = "GPGPU",
                State = "DISABLED"
            });

            string jobQueueArn = response.JobQueueArn;
            string jobQueueName = response.JobQueueName;

            #endregion
        }

        #region ISample Members
        public virtual void Run()
        {
        }
        #endregion
    }
}
