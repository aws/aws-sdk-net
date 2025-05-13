using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Amazon.ECS;
using Amazon.ECS.Model;

namespace AWSSDKDocSamples.Amazon.ECS.Generated
{
    class ECSSamples : ISample
    {
        public void ECSCreateCapacityProvider()
        {
            #region to-create-a-capacity-provider--1733861347945

            var client = new AmazonECSClient();
            var response = client.CreateCapacityProvider(new CreateCapacityProviderRequest 
            {
                Name = "MyCapacityProvider",
                AutoScalingGroupProvider = new AutoScalingGroupProvider {
                    AutoScalingGroupArn = "arn:aws:autoscaling:us-east-1:123456789012:autoScalingGroup:57ffcb94-11f0-4d6d-bf60-3bac5EXAMPLE:autoScalingGroupName/MyASG",
                    ManagedScaling = new ManagedScaling {
                        Status = "ENABLED",
                        TargetCapacity = 100
                    },
                    ManagedTerminationProtection = "ENABLED"
                }
            });

            CapacityProvider capacityProvider = response.CapacityProvider;

            #endregion
        }

        public void ECSCreateCluster()
        {
            #region to-create-a-new-cluster-1472514079365

            var client = new AmazonECSClient();
            var response = client.CreateCluster(new CreateClusterRequest 
            {
                ClusterName = "my_cluster"
            });

            Cluster cluster = response.Cluster;

            #endregion
        }

        public void ECSCreateService()
        {
            #region to-create-a-new-service-1472512584282

            var client = new AmazonECSClient();
            var response = client.CreateService(new CreateServiceRequest 
            {
                DesiredCount = 10,
                ServiceName = "ecs-simple-service",
                TaskDefinition = "hello_world"
            });

            Service service = response.Service;

            #endregion
        }

        public void ECSCreateService()
        {
            #region to-create-a-new-service-behind-a-load-balancer-1472512484823

            var client = new AmazonECSClient();
            var response = client.CreateService(new CreateServiceRequest 
            {
                DesiredCount = 10,
                LoadBalancers = new List<LoadBalancer> {
                    new LoadBalancer {
                        ContainerName = "simple-app",
                        ContainerPort = 80,
                        LoadBalancerName = "EC2Contai-EcsElast-15DCDAURT3ZO2"
                    }
                },
                Role = "ecsServiceRole",
                ServiceName = "ecs-simple-service-elb",
                TaskDefinition = "console-sample-app-static"
            });

            Service service = response.Service;

            #endregion
        }

        public void ECSCreateTaskSet()
        {
            #region to-create-a-task-set-1733864092815

            var client = new AmazonECSClient();
            var response = client.CreateTaskSet(new CreateTaskSetRequest 
            {
                Cluster = "MyCluster",
                NetworkConfiguration = new NetworkConfiguration { AwsvpcConfiguration = new AwsVpcConfiguration {
                    SecurityGroups = new List<string> {
                        "sg-12344321"
                    },
                    Subnets = new List<string> {
                        "subnet-12344321"
                    }
                } },
                Service = "MyService",
                TaskDefinition = "MyTaskDefinition:2"
            });

            TaskSet taskSet = response.TaskSet;

            #endregion
        }

        public void ECSDeleteAccountSetting()
        {
            #region to-delete-the-account-setting-for-your-user-account-1549524548115

            var client = new AmazonECSClient();
            var response = client.DeleteAccountSetting(new DeleteAccountSettingRequest 
            {
                Name = "serviceLongArnFormat"
            });

            Setting setting = response.Setting;

            #endregion
        }

        public void ECSDeleteAccountSetting()
        {
            #region to-delete-the-account-setting-for-a-specific-iam-user-or-iam-role-1549524612917

            var client = new AmazonECSClient();
            var response = client.DeleteAccountSetting(new DeleteAccountSettingRequest 
            {
                Name = "containerInstanceLongArnFormat",
                PrincipalArn = "arn:aws:iam::<aws_account_id>:user/principalName"
            });

            Setting setting = response.Setting;

            #endregion
        }

        public void ECSDeleteAttributes()
        {
            #region to-delete-a-custom-attribute-from-an-amazon-ecs-instance-1733867267541

            var client = new AmazonECSClient();
            var response = client.DeleteAttributes(new DeleteAttributesRequest 
            {
                Attributes = new List<Attribute> {
                    new Attribute {
                        Name = "stack",
                        TargetId = "aws:ecs:us-west-2:130757420319:container-instance/1c3be8ed-df30-47b4-8f1e-6e68ebd01f34"
                    }
                }
            });

            List<Attribute> attributes = response.Attributes;

            #endregion
        }

        public void ECSDeleteCapacityProvider()
        {
            #region to-delete-a-specified-capacity-provider-1733868702678

            var client = new AmazonECSClient();
            var response = client.DeleteCapacityProvider(new DeleteCapacityProviderRequest 
            {
                CapacityProvider = "arn:aws:ecs:us-west-2:123456789012:capacity-provider/ExampleCapacityProvider"
            });

            CapacityProvider capacityProvider = response.CapacityProvider;

            #endregion
        }

        public void ECSDeleteCluster()
        {
            #region to-delete-an-empty-cluster-1472512705352

            var client = new AmazonECSClient();
            var response = client.DeleteCluster(new DeleteClusterRequest 
            {
                Cluster = "my_cluster"
            });

            Cluster cluster = response.Cluster;

            #endregion
        }

        public void ECSDeleteService()
        {
            #region e8183e38-f86e-4390-b811-f74f30a6007d

            var client = new AmazonECSClient();
            var response = client.DeleteService(new DeleteServiceRequest 
            {
                Service = "my-http-service"
            });


            #endregion
        }

        public void ECSDeleteTaskDefinitions()
        {
            #region to-delete-a-task-definition-that-has-been-deregistered-1733940790186

            var client = new AmazonECSClient();
            var response = client.DeleteTaskDefinitions(new DeleteTaskDefinitionsRequest 
            {
                TaskDefinitions = new List<string> {
                    "Example-task-definition:1"
                }
            });

            List<Failure> failures = response.Failures;
            List<TaskDefinition> taskDefinitions = response.TaskDefinitions;

            #endregion
        }

        public void ECSDeleteTaskSet()
        {
            #region to-delete-a-task-set-within-a-service-that-uses-the-external-deployment-controller-type-1733949897807

            var client = new AmazonECSClient();
            var response = client.DeleteTaskSet(new DeleteTaskSetRequest 
            {
                Cluster = "MyCluster",
                Force = true,
                Service = "MyService",
                TaskSet = "arn:aws:ecs:us-west-2:123456789012:task-set/MyCluster/MyService/ecs-svc/1234567890123456789"
            });

            TaskSet taskSet = response.TaskSet;

            #endregion
        }

        public void ECSDeregisterContainerInstance()
        {
            #region bf624927-cf64-4f4b-8b7e-c024a4e682f6

            var client = new AmazonECSClient();
            var response = client.DeregisterContainerInstance(new DeregisterContainerInstanceRequest 
            {
                Cluster = "default",
                ContainerInstance = "container_instance_UUID",
                Force = true
            });


            #endregion
        }

        public void ECSDeregisterTaskDefinition()
        {
            #region to-deregister-a-revision-of-a-task-definition-1733950214421

            var client = new AmazonECSClient();
            var response = client.DeregisterTaskDefinition(new DeregisterTaskDefinitionRequest 
            {
                TaskDefinition = "fargate-task:1"
            });

            TaskDefinition taskDefinition = response.TaskDefinition;

            #endregion
        }

        public void ECSDescribeCapacityProviders()
        {
            #region to-describe-all-capacity-providers-1733951199913

            var client = new AmazonECSClient();
            var response = client.DescribeCapacityProviders(new DescribeCapacityProvidersRequest 
            {
            });

            List<CapacityProvider> capacityProviders = response.CapacityProviders;

            #endregion
        }

        public void ECSDescribeCapacityProviders()
        {
            #region to-describe-a-specific-capacity-provider-1733951378688

            var client = new AmazonECSClient();
            var response = client.DescribeCapacityProviders(new DescribeCapacityProvidersRequest 
            {
                CapacityProviders = new List<string> {
                    "MyCapacityProvider"
                },
                Include = new List<string> {
                    "TAGS"
                }
            });

            List<CapacityProvider> capacityProviders = response.CapacityProviders;

            #endregion
        }

        public void ECSDescribeClusters()
        {
            #region ba88d100-9672-4231-80da-a4bd210bf728

            var client = new AmazonECSClient();
            var response = client.DescribeClusters(new DescribeClustersRequest 
            {
                Clusters = new List<string> {
                    "default"
                }
            });

            List<Cluster> clusters = response.Clusters;
            List<Failure> failures = response.Failures;

            #endregion
        }

        public void ECSDescribeContainerInstances()
        {
            #region c8f439de-eb27-4269-8ca7-2c0a7ba75ab0

            var client = new AmazonECSClient();
            var response = client.DescribeContainerInstances(new DescribeContainerInstancesRequest 
            {
                Cluster = "default",
                ContainerInstances = new List<string> {
                    "f2756532-8f13-4d53-87c9-aed50dc94cd7"
                }
            });

            List<ContainerInstance> containerInstances = response.ContainerInstances;
            List<Failure> failures = response.Failures;

            #endregion
        }

        public void ECSDescribeServiceDeployments()
        {
            #region to-describe-a-service-deployment--1733954961143

            var client = new AmazonECSClient();
            var response = client.DescribeServiceDeployments(new DescribeServiceDeploymentsRequest 
            {
                ServiceDeploymentArns = new List<string> {
                    "arn:aws:ecs:us-west-2:123456789012:service-deployment/example/sd-example/NCWGC2ZR-taawPAYrIaU5"
                }
            });

            List<Failure> failures = response.Failures;
            List<ServiceDeployment> serviceDeployments = response.ServiceDeployments;

            #endregion
        }

        public void ECSDescribeServiceRevisions()
        {
            #region to-describe-a-service-revision--1734033215738

            var client = new AmazonECSClient();
            var response = client.DescribeServiceRevisions(new DescribeServiceRevisionsRequest 
            {
                ServiceRevisionArns = new List<string> {
                    "arn:aws:ecs:us-west-2:123456789012:service-revision/testc/sd1/4980306466373577095"
                }
            });

            List<Failure> failures = response.Failures;
            List<ServiceRevision> serviceRevisions = response.ServiceRevisions;

            #endregion
        }

        public void ECSDescribeServices()
        {
            #region to-describe-a-service-1472513256350

            var client = new AmazonECSClient();
            var response = client.DescribeServices(new DescribeServicesRequest 
            {
                Services = new List<string> {
                    "ecs-simple-service"
                }
            });

            List<Failure> failures = response.Failures;
            List<Service> services = response.Services;

            #endregion
        }

        public void ECSDescribeTaskDefinition()
        {
            #region 4c21eeb1-f1da-4a08-8c44-297fc8d0ea88

            var client = new AmazonECSClient();
            var response = client.DescribeTaskDefinition(new DescribeTaskDefinitionRequest 
            {
                TaskDefinition = "hello_world:8"
            });

            TaskDefinition taskDefinition = response.TaskDefinition;

            #endregion
        }

        public void ECSDescribeTasks()
        {
            #region a90b0cde-f965-4946-b55e-cfd8cc54e827

            var client = new AmazonECSClient();
            var response = client.DescribeTasks(new DescribeTasksRequest 
            {
                Tasks = new List<string> {
                    "c5cba4eb-5dad-405e-96db-71ef8eefe6a8"
                }
            });

            List<Failure> failures = response.Failures;
            List<Task> tasks = response.Tasks;

            #endregion
        }

        public void ECSDescribeTaskSets()
        {
            #region to-describe-a-task-set--1734035629507

            var client = new AmazonECSClient();
            var response = client.DescribeTaskSets(new DescribeTaskSetsRequest 
            {
                Cluster = "MyCluster",
                Service = "MyService",
                TaskSets = new List<string> {
                    "arn:aws:ecs:us-west-2:123456789012:task-set/MyCluster/MyService/ecs-svc/1234567890123456789"
                }
            });

            List<Failure> failures = response.Failures;
            List<TaskSet> taskSets = response.TaskSets;

            #endregion
        }

        public void ECSExecuteCommand()
        {
            #region to-run-a-command-remotely-on-a-container-in-a-task-1734037663312

            var client = new AmazonECSClient();
            var response = client.ExecuteCommand(new ExecuteCommandRequest 
            {
                Cluster = "MyCluster",
                Command = "/bin/sh",
                Container = "MyContainer",
                Interactive = true,
                Task = "arn:aws:ecs:us-east-1:123456789012:task/MyCluster/d789e94343414c25b9f6bd59eEXAMPLE"
            });

            string clusterArn = response.ClusterArn;
            string containerArn = response.ContainerArn;
            string containerName = response.ContainerName;
            bool interactive = response.Interactive;
            Session session = response.Session;
            string taskArn = response.TaskArn;

            #endregion
        }

        public void ECSGetTaskProtection()
        {
            #region get-the-protection-status-for-a-single-task-2022-11-02T06:56:32.553Z

            var client = new AmazonECSClient();
            var response = client.GetTaskProtection(new GetTaskProtectionRequest 
            {
                Cluster = "test-task-protection",
                Tasks = new List<string> {
                    "b8b1cf532d0e46ba8d44a40d1de16772"
                }
            });

            List<Failure> failures = response.Failures;
            List<ProtectedTask> protectedTasks = response.ProtectedTasks;

            #endregion
        }

        public void ECSListAccountSettings()
        {
            #region to-view-your-account-settings-1549524118170

            var client = new AmazonECSClient();
            var response = client.ListAccountSettings(new ListAccountSettingsRequest 
            {
                EffectiveSettings = true
            });

            List<Setting> settings = response.Settings;

            #endregion
        }

        public void ECSListAccountSettings()
        {
            #region to-view-the-account-settings-for-a-specific-iam-user-or-iam-role-1549524237932

            var client = new AmazonECSClient();
            var response = client.ListAccountSettings(new ListAccountSettingsRequest 
            {
                EffectiveSettings = true,
                PrincipalArn = "arn:aws:iam::<aws_account_id>:user/principalName"
            });

            List<Setting> settings = response.Settings;

            #endregion
        }

        public void ECSListAttributes()
        {
            #region to-list-container-instances-that-have-a-specific-attribute-1734368946577

            var client = new AmazonECSClient();
            var response = client.ListAttributes(new ListAttributesRequest 
            {
                AttributeName = "stack",
                AttributeValue = "production",
                Cluster = "MyCluster",
                TargetType = "container-instance"
            });

            List<Attribute> attributes = response.Attributes;

            #endregion
        }

        public void ECSListClusters()
        {
            #region e337d059-134f-4125-ba8e-4f499139facf

            var client = new AmazonECSClient();
            var response = client.ListClusters(new ListClustersRequest 
            {
            });

            List<string> clusterArns = response.ClusterArns;

            #endregion
        }

        public void ECSListContainerInstances()
        {
            #region 62a82a94-713c-4e18-8420-1d2b2ba9d484

            var client = new AmazonECSClient();
            var response = client.ListContainerInstances(new ListContainerInstancesRequest 
            {
                Cluster = "default"
            });

            List<string> containerInstanceArns = response.ContainerInstanceArns;

            #endregion
        }

        public void ECSListServiceDeployments()
        {
            #region to-list-service-deployments-that-meet-the-specified-criteria-1734370445427

            var client = new AmazonECSClient();
            var response = client.ListServiceDeployments(new ListServiceDeploymentsRequest 
            {
                Cluster = "example",
                Service = "sd-example",
                Status = new List<string> {
                    "SUCCESSFUL"
                }
            });

            List<ServiceDeploymentBrief> serviceDeployments = response.ServiceDeployments;

            #endregion
        }

        public void ECSListServices()
        {
            #region 1d9a8037-4e0e-4234-a528-609656809a3a

            var client = new AmazonECSClient();
            var response = client.ListServices(new ListServicesRequest 
            {
            });

            List<string> serviceArns = response.ServiceArns;

            #endregion
        }

        public void ECSListTagsForResource()
        {
            #region to-list-the-tags-for-a-cluster-1540582700259

            var client = new AmazonECSClient();
            var response = client.ListTagsForResource(new ListTagsForResourceRequest 
            {
                ResourceArn = "arn:aws:ecs:region:aws_account_id:cluster/dev"
            });

            List<Tag> tags = response.Tags;

            #endregion
        }

        public void ECSListTaskDefinitionFamilies()
        {
            #region b5c89769-1d94-4ca2-a79e-8069103c7f75

            var client = new AmazonECSClient();
            var response = client.ListTaskDefinitionFamilies(new ListTaskDefinitionFamiliesRequest 
            {
            });

            List<string> families = response.Families;

            #endregion
        }

        public void ECSListTaskDefinitionFamilies()
        {
            #region 8a4cf9a6-42c1-4fe3-852d-99ac8968e11b

            var client = new AmazonECSClient();
            var response = client.ListTaskDefinitionFamilies(new ListTaskDefinitionFamiliesRequest 
            {
                FamilyPrefix = "hpcc"
            });

            List<string> families = response.Families;

            #endregion
        }

        public void ECSListTaskDefinitions()
        {
            #region b381ebaf-7eba-4d60-b99b-7f6ae49d3d60

            var client = new AmazonECSClient();
            var response = client.ListTaskDefinitions(new ListTaskDefinitionsRequest 
            {
            });

            List<string> taskDefinitionArns = response.TaskDefinitionArns;

            #endregion
        }

        public void ECSListTaskDefinitions()
        {
            #region 734e7afd-753a-4bc2-85d0-badddce10910

            var client = new AmazonECSClient();
            var response = client.ListTaskDefinitions(new ListTaskDefinitionsRequest 
            {
                FamilyPrefix = "wordpress"
            });

            List<string> taskDefinitionArns = response.TaskDefinitionArns;

            #endregion
        }

        public void ECSListTasks()
        {
            #region 9a6ec707-1a77-45d0-b2eb-516b5dd9e924

            var client = new AmazonECSClient();
            var response = client.ListTasks(new ListTasksRequest 
            {
                Cluster = "default"
            });

            List<string> taskArns = response.TaskArns;

            #endregion
        }

        public void ECSListTasks()
        {
            #region 024bf3b7-9cbb-44e3-848f-9d074e1fecce

            var client = new AmazonECSClient();
            var response = client.ListTasks(new ListTasksRequest 
            {
                Cluster = "default",
                ContainerInstance = "f6bbb147-5370-4ace-8c73-c7181ded911f"
            });

            List<string> taskArns = response.TaskArns;

            #endregion
        }

        public void ECSPutAccountSetting()
        {
            #region to-modify-the-account-settings-for-your-iam-user-account-1549523130939

            var client = new AmazonECSClient();
            var response = client.PutAccountSetting(new PutAccountSettingRequest 
            {
                Name = "serviceLongArnFormat",
                Value = "enabled"
            });

            Setting setting = response.Setting;

            #endregion
        }

        public void ECSPutAccountSetting()
        {
            #region to-modify-the-account-settings-for-a-specific-iam-user-or-iam-role-1549523518390

            var client = new AmazonECSClient();
            var response = client.PutAccountSetting(new PutAccountSettingRequest 
            {
                Name = "containerInstanceLongArnFormat",
                Value = "enabled",
                PrincipalArn = "arn:aws:iam::<aws_account_id>:user/principalName"
            });

            Setting setting = response.Setting;

            #endregion
        }

        public void ECSPutAccountSettingDefault()
        {
            #region to-modify-the-default-account-settings-for-all-iam-users-or-roles-on-your-account-1549523794603

            var client = new AmazonECSClient();
            var response = client.PutAccountSettingDefault(new PutAccountSettingDefaultRequest 
            {
                Name = "serviceLongArnFormat",
                Value = "enabled"
            });

            Setting setting = response.Setting;

            #endregion
        }

        public void ECSPutAttributes()
        {
            #region to-create-or-update-an-attribute-on-a-resource-1734382423405

            var client = new AmazonECSClient();
            var response = client.PutAttributes(new PutAttributesRequest 
            {
                Attributes = new List<Attribute> {
                    new Attribute {
                        Name = "stack",
                        Value = "production",
                        TargetId = "arn:aws:ecs:us-west-2:123456789012:container-instance/1c3be8ed-df30-47b4-8f1e-6e68ebd01f34"
                    }
                },
                Cluster = "MyCluster"
            });

            List<Attribute> attributes = response.Attributes;

            #endregion
        }

        public void ECSPutClusterCapacityProviders()
        {
            #region to-add-an-existing-capacity-provider-to-a-cluster-1734385195698

            var client = new AmazonECSClient();
            var response = client.PutClusterCapacityProviders(new PutClusterCapacityProvidersRequest 
            {
                CapacityProviders = new List<string> {
                    "MyCapacityProvider1",
                    "MyCapacityProvider2"
                },
                Cluster = "MyCluster",
                DefaultCapacityProviderStrategy = new List<CapacityProviderStrategyItem> {
                    new CapacityProviderStrategyItem {
                        CapacityProvider = "MyCapacityProvider1",
                        Weight = 1
                    },
                    new CapacityProviderStrategyItem {
                        CapacityProvider = "MyCapacityProvider2",
                        Weight = 1
                    }
                }
            });

            Cluster cluster = response.Cluster;

            #endregion
        }

        public void ECSPutClusterCapacityProviders()
        {
            #region to-remove-a-capacity-provider-from-a-cluster-1734386641517

            var client = new AmazonECSClient();
            var response = client.PutClusterCapacityProviders(new PutClusterCapacityProvidersRequest 
            {
                CapacityProviders = new List<string> {
                    "MyCapacityProvider1"
                },
                Cluster = "MyCluster",
                DefaultCapacityProviderStrategy = new List<CapacityProviderStrategyItem> {
                    new CapacityProviderStrategyItem {
                        Base = 0,
                        CapacityProvider = "MyCapacityProvider1",
                        Weight = 1
                    }
                }
            });

            Cluster cluster = response.Cluster;

            #endregion
        }

        public void ECSPutClusterCapacityProviders()
        {
            #region to-remove-all-capacity-providers-from-a-cluster-1734387170874

            var client = new AmazonECSClient();
            var response = client.PutClusterCapacityProviders(new PutClusterCapacityProvidersRequest 
            {
                CapacityProviders = new List<string> {
                    
                },
                Cluster = "MyCluster",
                DefaultCapacityProviderStrategy = new List<CapacityProviderStrategyItem> {
                    
                }
            });

            Cluster cluster = response.Cluster;

            #endregion
        }

        public void ECSRegisterTaskDefinition()
        {
            #region to-register-a-task-definition-1470764550877

            var client = new AmazonECSClient();
            var response = client.RegisterTaskDefinition(new RegisterTaskDefinitionRequest 
            {
                ContainerDefinitions = new List<ContainerDefinition> {
                    new ContainerDefinition {
                        Name = "sleep",
                        Command = new List<string> {
                            "sleep",
                            "360"
                        },
                        Cpu = 10,
                        Essential = true,
                        Image = "public.ecr.aws/docker/library/busybox:latest",
                        Memory = 10
                    }
                },
                Family = "sleep360",
                TaskRoleArn = "",
                Volumes = new List<Volume> {
                    
                }
            });

            TaskDefinition taskDefinition = response.TaskDefinition;

            #endregion
        }

        public void ECSRunTask()
        {
            #region 6f238c83-a133-42cd-ab3d-abeca0560445

            var client = new AmazonECSClient();
            var response = client.RunTask(new RunTaskRequest 
            {
                Cluster = "default",
                TaskDefinition = "sleep360:1"
            });

            List<Task> tasks = response.Tasks;

            #endregion
        }

        public void ECSStartTask()
        {
            #region to-start-a-new-task-1734455482966

            var client = new AmazonECSClient();
            var response = client.StartTask(new StartTaskRequest 
            {
                Cluster = "MyCluster",
                ContainerInstances = new List<string> {
                    "4c543eed-f83f-47da-b1d8-3d23f1da4c64"
                },
                TaskDefinition = "hello-world"
            });

            List<Failure> failures = response.Failures;
            List<Task> tasks = response.Tasks;

            #endregion
        }

        public void ECSStopServiceDeployment()
        {
            #region to-stop-service-deployment-1734638754369

            var client = new AmazonECSClient();
            var response = client.StopServiceDeployment(new StopServiceDeploymentRequest 
            {
                ServiceDeploymentArn = "arn:aws:ecs:us-east-1:123456789012:service-deployment/MyCluster/MyService/r9i43YFjvgF_xlg7m2eJ1r",
                StopType = "ROLLBACK"
            });

            string serviceDeploymentArn = response.ServiceDeploymentArn;

            #endregion
        }

        public void ECSStopTask()
        {
            #region to-stop-a-task-1734457210346

            var client = new AmazonECSClient();
            var response = client.StopTask(new StopTaskRequest 
            {
                Cluster = "MyCluster",
                Reason = "testing stop task.",
                Task = "1dc5c17a-422b-4dc4-b493-371970c6c4d6"
            });

            Task task = response.Task;

            #endregion
        }

        public void ECSTagResource()
        {
            #region to-tag-a-cluster-1540581863751

            var client = new AmazonECSClient();
            var response = client.TagResource(new TagResourceRequest 
            {
                ResourceArn = "arn:aws:ecs:region:aws_account_id:cluster/dev",
                Tags = new List<Tag> {
                    new Tag {
                        Key = "team",
                        Value = "dev"
                    }
                }
            });


            #endregion
        }

        public void ECSUntagResource()
        {
            #region to-untag-a-cluster-1540582546056

            var client = new AmazonECSClient();
            var response = client.UntagResource(new UntagResourceRequest 
            {
                ResourceArn = "arn:aws:ecs:region:aws_account_id:cluster/dev",
                TagKeys = new List<string> {
                    "team"
                }
            });


            #endregion
        }

        public void ECSUpdateCapacityProvider()
        {
            #region to-update-a-capacity-providers-parameters-1734557290198

            var client = new AmazonECSClient();
            var response = client.UpdateCapacityProvider(new UpdateCapacityProviderRequest 
            {
                Name = "MyCapacityProvider",
                AutoScalingGroupProvider = new AutoScalingGroupProviderUpdate { ManagedScaling = new ManagedScaling {
                    InstanceWarmupPeriod = 150,
                    Status = "ENABLED",
                    TargetCapacity = 90
                } }
            });

            CapacityProvider capacityProvider = response.CapacityProvider;

            #endregion
        }

        public void ECSUpdateCluster()
        {
            #region to-update-a-clusters-observability-settings-1734626018966

            var client = new AmazonECSClient();
            var response = client.UpdateCluster(new UpdateClusterRequest 
            {
                Cluster = "ECS-project-update-cluster",
                Settings = new List<ClusterSetting> {
                    new ClusterSetting {
                        Name = "containerInsights",
                        Value = "enhanced"
                    }
                }
            });

            Cluster cluster = response.Cluster;

            #endregion
        }

        public void ECSUpdateCluster()
        {
            #region to-update-a-clusters-service-connect-defaults-1734626891648

            var client = new AmazonECSClient();
            var response = client.UpdateCluster(new UpdateClusterRequest 
            {
                Cluster = "ECS-project-update-cluster",
                ServiceConnectDefaults = new ClusterServiceConnectDefaultsRequest { Namespace = "test" }
            });

            Cluster cluster = response.Cluster;

            #endregion
        }

        public void ECSUpdateClusterSettings()
        {
            #region to-update-a-clusters-settings-1734628004887

            var client = new AmazonECSClient();
            var response = client.UpdateClusterSettings(new UpdateClusterSettingsRequest 
            {
                Cluster = "default",
                Settings = new List<ClusterSetting> {
                    new ClusterSetting {
                        Name = "containerInsights",
                        Value = "enabled"
                    }
                }
            });

            Cluster cluster = response.Cluster;

            #endregion
        }

        public void ECSUpdateContainerAgent()
        {
            #region to-update-the-container-agent-version-on-a-container-instance-1734628653210

            var client = new AmazonECSClient();
            var response = client.UpdateContainerAgent(new UpdateContainerAgentRequest 
            {
                Cluster = "MyCluster",
                ContainerInstance = "53ac7152-dcd1-4102-81f5-208962864132"
            });

            ContainerInstance containerInstance = response.ContainerInstance;

            #endregion
        }

        public void ECSUpdateContainerInstancesState()
        {
            #region to-update-the-state-of-a-container-instance-1734630991280

            var client = new AmazonECSClient();
            var response = client.UpdateContainerInstancesState(new UpdateContainerInstancesStateRequest 
            {
                Cluster = "default",
                ContainerInstances = new List<string> {
                    "1c3be8ed-df30-47b4-8f1e-6e68ebd01f34"
                },
                Status = "DRAINING"
            });

            List<ContainerInstance> containerInstances = response.ContainerInstances;
            List<Failure> failures = response.Failures;

            #endregion
        }

        public void ECSUpdateService()
        {
            #region cc9e8900-0cc2-44d2-8491-64d1d3d37887

            var client = new AmazonECSClient();
            var response = client.UpdateService(new UpdateServiceRequest 
            {
                Service = "my-http-service",
                TaskDefinition = "amazon-ecs-sample"
            });


            #endregion
        }

        public void ECSUpdateService()
        {
            #region 9581d6c5-02e3-4140-8cc1-5a4301586633

            var client = new AmazonECSClient();
            var response = client.UpdateService(new UpdateServiceRequest 
            {
                DesiredCount = 10,
                Service = "my-http-service"
            });


            #endregion
        }

        public void ECSUpdateServicePrimaryTaskSet()
        {
            #region to-update-the-primary-task-set-for-a-service-1734637150370

            var client = new AmazonECSClient();
            var response = client.UpdateServicePrimaryTaskSet(new UpdateServicePrimaryTaskSetRequest 
            {
                Cluster = "MyCluster",
                PrimaryTaskSet = "arn:aws:ecs:us-west-2:123456789012:task-set/MyCluster/MyService/ecs-svc/1234567890123456789",
                Service = "MyService"
            });

            TaskSet taskSet = response.TaskSet;

            #endregion
        }

        public void ECSUpdateTaskProtection()
        {
            #region enable-the-protection-status-for-a-single-task-for-60-minutes-2022-11-02T06:56:32.553Z

            var client = new AmazonECSClient();
            var response = client.UpdateTaskProtection(new UpdateTaskProtectionRequest 
            {
                Cluster = "test-task-protection",
                ExpiresInMinutes = 60,
                ProtectionEnabled = true,
                Tasks = new List<string> {
                    "b8b1cf532d0e46ba8d44a40d1de16772"
                }
            });

            List<Failure> failures = response.Failures;
            List<ProtectedTask> protectedTasks = response.ProtectedTasks;

            #endregion
        }

        public void ECSUpdateTaskProtection()
        {
            #region enable-the-protection-status-for-a-single-task-with-default-expiresinminutes-2022-11-02T06:56:32.553Z

            var client = new AmazonECSClient();
            var response = client.UpdateTaskProtection(new UpdateTaskProtectionRequest 
            {
                Cluster = "test-task-protection",
                ProtectionEnabled = true,
                Tasks = new List<string> {
                    "b8b1cf532d0e46ba8d44a40d1de16772"
                }
            });

            List<Failure> failures = response.Failures;
            List<ProtectedTask> protectedTasks = response.ProtectedTasks;

            #endregion
        }

        public void ECSUpdateTaskProtection()
        {
            #region disable-scale-in-protection-on-a-single-task

            var client = new AmazonECSClient();
            var response = client.UpdateTaskProtection(new UpdateTaskProtectionRequest 
            {
                Cluster = "test-task-protection",
                ProtectionEnabled = false,
                Tasks = new List<string> {
                    "b8b1cf532d0e46ba8d44a40d1de16772"
                }
            });

            List<Failure> failures = response.Failures;
            List<ProtectedTask> protectedTasks = response.ProtectedTasks;

            #endregion
        }

        public void ECSUpdateTaskSet()
        {
            #region to-update-a-task-set-1734638754368

            var client = new AmazonECSClient();
            var response = client.UpdateTaskSet(new UpdateTaskSetRequest 
            {
                Cluster = "MyCluster",
                Scale = new Scale {
                    Value = 50,
                    Unit = "PERCENT"
                },
                Service = "MyService",
                TaskSet = "arn:aws:ecs:us-west-2:123456789012:task-set/MyCluster/MyService/ecs-svc/1234567890123456789"
            });

            TaskSet taskSet = response.TaskSet;

            #endregion
        }

        
        # region ISample Members
        public virtual void Run()
        {

        }
        # endregion

    }
}