using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Amazon.Batch;
using Amazon.Batch.Model;

namespace AWSSDKDocSamples.Amazon.Batch.Generated
{
    class BatchSamples : ISample
    {
        static IAmazonBatch client = new AmazonBatchClient();
        public void BatchCancelJob()
        {
            #region to-cancel-a-job-1481152314733

            var response = client.CancelJob(new CancelJobRequest 
            {
                JobId = "1d828f65-7a4d-42e8-996d-3b900ed59dc4",
                Reason = "Cancelling job."
            });


            #endregion
        }

        public void BatchCreateComputeEnvironment()
        {
            #region to-create-a-managed-ec2-compute-environment-1481152600017

            var response = client.CreateComputeEnvironment(new CreateComputeEnvironmentRequest 
            {
                Type = "MANAGED",
                ComputeEnvironmentName = "C4OnDemand",
                ComputeResources = new ComputeResource {
                    Type = "EC2",
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
                    }
                },
                ServiceRole = "arn:aws:iam::012345678910:role/AWSBatchServiceRole",
                State = "ENABLED"
            });

            string computeEnvironmentArn = response.ComputeEnvironmentArn;
            string computeEnvironmentName = response.ComputeEnvironmentName;

            #endregion
        }

        public void BatchCreateComputeEnvironment()
        {
            #region to-create-a-managed-ec2-spot-compute-environment-1481152844190

            var response = client.CreateComputeEnvironment(new CreateComputeEnvironmentRequest 
            {
                Type = "MANAGED",
                ComputeEnvironmentName = "M4Spot",
                ComputeResources = new ComputeResource {
                    Type = "SPOT",
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
                    }
                },
                ServiceRole = "arn:aws:iam::012345678910:role/AWSBatchServiceRole",
                State = "ENABLED"
            });

            string computeEnvironmentArn = response.ComputeEnvironmentArn;
            string computeEnvironmentName = response.ComputeEnvironmentName;

            #endregion
        }

        public void BatchCreateJobQueue()
        {
            #region to-create-a-job-queue-with-a-single-compute-environment-1481152967946

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
            #region to-create-a-job-queue-with-multiple-compute-environments-1481153027051

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

        public void BatchDeleteComputeEnvironment()
        {
            #region to-delete-a-compute-environment-1481153105644

            var response = client.DeleteComputeEnvironment(new DeleteComputeEnvironmentRequest 
            {
                ComputeEnvironment = "P2OnDemand"
            });


            #endregion
        }

        public void BatchDeleteJobQueue()
        {
            #region to-delete-a-job-queue-1481153508134

            var response = client.DeleteJobQueue(new DeleteJobQueueRequest 
            {
                JobQueue = "GPGPU"
            });


            #endregion
        }

        public void BatchDeregisterJobDefinition()
        {
            #region to-deregister-a-job-definition-1481153579565

            var response = client.DeregisterJobDefinition(new DeregisterJobDefinitionRequest 
            {
                JobDefinition = "sleep10"
            });


            #endregion
        }

        public void BatchDescribeComputeEnvironments()
        {
            #region to-describe-a-compute-environment-1481153713334

            var response = client.DescribeComputeEnvironments(new DescribeComputeEnvironmentsRequest 
            {
                ComputeEnvironments = new List<string> {
                    "P2OnDemand"
                }
            });

            List<ComputeEnvironmentDetail> computeEnvironments = response.ComputeEnvironments;

            #endregion
        }

        public void BatchDescribeJobDefinitions()
        {
            #region to-describe-active-job-definitions-1481153895831

            var response = client.DescribeJobDefinitions(new DescribeJobDefinitionsRequest 
            {
                Status = "ACTIVE"
            });

            List<JobDefinition> jobDefinitions = response.JobDefinitions;

            #endregion
        }

        public void BatchDescribeJobQueues()
        {
            #region to-describe-a-job-queue-1481153995804

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
            #region to-describe-a-specific-job-1481154090490

            var response = client.DescribeJobs(new DescribeJobsRequest 
            {
                Jobs = new List<string> {
                    "24fa2d7a-64c4-49d2-8b47-f8da4fbde8e9"
                }
            });

            List<JobDetail> jobs = response.Jobs;

            #endregion
        }

        public void BatchListJobs()
        {
            #region to-list-running-jobs-1481154202164

            var response = client.ListJobs(new ListJobsRequest 
            {
                JobQueue = "HighPriority"
            });

            List<JobSummary> jobSummaryList = response.JobSummaryList;

            #endregion
        }

        public void BatchListJobs()
        {
            #region to-list-submitted-jobs-1481154251623

            var response = client.ListJobs(new ListJobsRequest 
            {
                JobQueue = "HighPriority",
                JobStatus = "SUBMITTED"
            });

            List<JobSummary> jobSummaryList = response.JobSummaryList;

            #endregion
        }

        public void BatchRegisterJobDefinition()
        {
            #region to-register-a-job-definition-1481154325325

            var response = client.RegisterJobDefinition(new RegisterJobDefinitionRequest 
            {
                Type = "container",
                ContainerProperties = new ContainerProperties {
                    Command = new List<string> {
                        "sleep",
                        "10"
                    },
                    Image = "busybox",
                    Memory = 128,
                    Vcpus = 1
                },
                JobDefinitionName = "sleep10"
            });

            string jobDefinitionArn = response.JobDefinitionArn;
            string jobDefinitionName = response.JobDefinitionName;
            integer revision = response.Revision;

            #endregion
        }

        public void BatchSubmitJob()
        {
            #region to-submit-a-job-to-a-queue-1481154481673

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

        public void BatchTerminateJob()
        {
            #region to-terminate-a-job-1481154558276

            var response = client.TerminateJob(new TerminateJobRequest 
            {
                JobId = "61e743ed-35e4-48da-b2de-5c8333821c84",
                Reason = "Terminating job."
            });


            #endregion
        }

        public void BatchUpdateComputeEnvironment()
        {
            #region to-update-a-compute-environment-1481154702731

            var response = client.UpdateComputeEnvironment(new UpdateComputeEnvironmentRequest 
            {
                ComputeEnvironment = "P2OnDemand",
                State = "DISABLED"
            });

            string computeEnvironmentArn = response.ComputeEnvironmentArn;
            string computeEnvironmentName = response.ComputeEnvironmentName;

            #endregion
        }

        public void BatchUpdateJobQueue()
        {
            #region to-update-a-job-queue-1481154806981

            var response = client.UpdateJobQueue(new UpdateJobQueueRequest 
            {
                JobQueue = "GPGPU",
                State = "DISABLED"
            });

            string jobQueueArn = response.JobQueueArn;
            string jobQueueName = response.JobQueueName;

            #endregion
        }

        
        # region ISample Members
        public virtual void Run()
        {

        }
        # endregion

    }
}