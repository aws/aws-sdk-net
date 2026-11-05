using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Amazon.AutoScaling;
using Amazon.AutoScaling.Model;

namespace AWSSDKDocSamples.Amazon.AutoScaling.Generated
{
    class AutoScalingSamples : ISample
    {
        public void AutoScalingAttachInstances()
        {
            #region AttachInstances-1

            var client = new AmazonAutoScalingClient();
            var response = client.AttachInstances(new AttachInstancesRequest
            {
                AutoScalingGroupName = "my-auto-scaling-group",
                InstanceIds = new List<string> {
                    "i-93633f9b"
                }
            });


            #endregion
        }

        public void AutoScalingAttachLoadBalancers()
        {
            #region AttachLoadBalancers-1

            var client = new AmazonAutoScalingClient();
            var response = client.AttachLoadBalancers(new AttachLoadBalancersRequest
            {
                AutoScalingGroupName = "my-auto-scaling-group",
                LoadBalancerNames = new List<string> {
                    "my-load-balancer"
                }
            });


            #endregion
        }

        public void AutoScalingAttachLoadBalancerTargetGroups()
        {
            #region AttachLoadBalancerTargetGroups-1

            var client = new AmazonAutoScalingClient();
            var response = client.AttachLoadBalancerTargetGroups(new AttachLoadBalancerTargetGroupsRequest
            {
                AutoScalingGroupName = "my-auto-scaling-group",
                TargetGroupARNs = new List<string> {
                    "arn:aws:elasticloadbalancing:us-west-2:123456789012:targetgroup/my-targets/73e2d6bc24d8a067"
                }
            });


            #endregion
        }

        public void AutoScalingAttachTrafficSources()
        {
            #region AttachTrafficSources-1

            var client = new AmazonAutoScalingClient();
            var response = client.AttachTrafficSources(new AttachTrafficSourcesRequest
            {
                AutoScalingGroupName = "my-auto-scaling-group",
                TrafficSources = new List<TrafficSourceIdentifier> {
                    new TrafficSourceIdentifier { Identifier = "arn:aws:elasticloadbalancing:us-west-2:123456789012:targetgroup/my-targets/73e2d6bc24d8a067" }
                }
            });


            #endregion
        }

        public void AutoScalingCancelInstanceRefresh()
        {
            #region CancelInstanceRefresh-1

            var client = new AmazonAutoScalingClient();
            var response = client.CancelInstanceRefresh(new CancelInstanceRefreshRequest
            {
                AutoScalingGroupName = "my-auto-scaling-group"
            });

            string instanceRefreshId = response.InstanceRefreshId;

            #endregion
        }

        public void AutoScalingCompleteLifecycleAction()
        {
            #region CompleteLifecycleAction-1

            var client = new AmazonAutoScalingClient();
            var response = client.CompleteLifecycleAction(new CompleteLifecycleActionRequest
            {
                AutoScalingGroupName = "my-auto-scaling-group",
                LifecycleActionResult = "CONTINUE",
                LifecycleActionToken = "bcd2f1b8-9a78-44d3-8a7a-4dd07d7cf635",
                LifecycleHookName = "my-lifecycle-hook"
            });


            #endregion
        }

        public void AutoScalingCreateAutoScalingGroup()
        {
            #region CreateAutoScalingGroup-1

            var client = new AmazonAutoScalingClient();
            var response = client.CreateAutoScalingGroup(new CreateAutoScalingGroupRequest
            {
                AutoScalingGroupName = "my-auto-scaling-group",
                HealthCheckGracePeriod = 300,
                HealthCheckType = "ELB",
                LaunchTemplate = new LaunchTemplateSpecification {
                    LaunchTemplateName = "my-template-for-auto-scaling",
                    Version = "$Default"
                },
                MaxSize = 3,
                MinSize = 1,
                TargetGroupARNs = new List<string> {
                    "arn:aws:elasticloadbalancing:us-west-2:123456789012:targetgroup/my-targets/73e2d6bc24d8a067"
                },
                VPCZoneIdentifier = "subnet-057fa0918fEXAMPLE, subnet-610acd08EXAMPLE"
            });


            #endregion
        }

        public void AutoScalingCreateAutoScalingGroup()
        {
            #region CreateAutoScalingGroup-2

            var client = new AmazonAutoScalingClient();
            var response = client.CreateAutoScalingGroup(new CreateAutoScalingGroupRequest
            {
                AutoScalingGroupName = "my-asg",
                DesiredCapacity = 3,
                MaxSize = 5,
                MinSize = 1,
                MixedInstancesPolicy = new MixedInstancesPolicy {
                    InstancesDistribution = new InstancesDistribution {
                        OnDemandBaseCapacity = 1,
                        OnDemandPercentageAboveBaseCapacity = 50,
                        SpotAllocationStrategy = "price-capacity-optimized"
                    },
                    LaunchTemplate = new LaunchTemplate {
                        LaunchTemplateSpecification = new LaunchTemplateSpecification {
                            LaunchTemplateName = "my-launch-template-for-x86",
                            Version = "$Default"
                        },
                        Overrides = new List<LaunchTemplateOverrides> {
                            new LaunchTemplateOverrides {
                                InstanceType = "c6g.large",
                                LaunchTemplateSpecification = new LaunchTemplateSpecification {
                                    LaunchTemplateName = "my-launch-template-for-arm",
                                    Version = "$Default"
                                }
                            },
                            new LaunchTemplateOverrides { InstanceType = "c5.large" },
                            new LaunchTemplateOverrides { InstanceType = "c5a.large" }
                        }
                    }
                },
                VPCZoneIdentifier = "subnet-057fa0918fEXAMPLE, subnet-610acd08EXAMPLE"
            });


            #endregion
        }

        public void AutoScalingCreateAutoScalingGroup()
        {
            #region CreateAutoScalingGroup-3

            var client = new AmazonAutoScalingClient();
            var response = client.CreateAutoScalingGroup(new CreateAutoScalingGroupRequest
            {
                AutoScalingGroupName = "my-asg",
                DesiredCapacity = 4,
                DesiredCapacityType = "units",
                MaxSize = 100,
                MinSize = 0,
                MixedInstancesPolicy = new MixedInstancesPolicy {
                    InstancesDistribution = new InstancesDistribution {
                        OnDemandPercentageAboveBaseCapacity = 50,
                        SpotAllocationStrategy = "price-capacity-optimized"
                    },
                    LaunchTemplate = new LaunchTemplate {
                        LaunchTemplateSpecification = new LaunchTemplateSpecification {
                            LaunchTemplateName = "my-template-for-auto-scaling",
                            Version = "$Default"
                        },
                        Overrides = new List<LaunchTemplateOverrides> {
                            new LaunchTemplateOverrides { InstanceRequirements = new InstanceRequirements {
                                CpuManufacturers = new List<string> {
                                    "intel"
                                },
                                MemoryMiB = new MemoryMiBRequest { Min = 16384 },
                                VCpuCount = new VCpuCountRequest {
                                    Max = 8,
                                    Min = 4
                                }
                            } }
                        }
                    }
                },
                VPCZoneIdentifier = "subnet-057fa0918fEXAMPLE, subnet-610acd08EXAMPLE"
            });


            #endregion
        }

        public void AutoScalingCreateAutoScalingGroup()
        {
            #region CreateAutoScalingGroup-4

            var client = new AmazonAutoScalingClient();
            var response = client.CreateAutoScalingGroup(new CreateAutoScalingGroupRequest
            {
                AutoScalingGroupName = "my-asg",
                CapacityReservationSpecification = new CapacityReservationSpecification { CapacityReservationTarget = new CapacityReservationTarget { CapacityReservationResourceGroupArns = new List<string> {
                    "arn:aws:resource-groups:us-east-1:123456789012:group/my-capacity-reservation-group"
                } } },
                DesiredCapacity = 5,
                MaxSize = 10,
                MinSize = 0,
                MixedInstancesPolicy = new MixedInstancesPolicy {
                    InstancesDistribution = new InstancesDistribution {
                        DistributionSegments = new List<DistributionSegment> {
                            new DistributionSegment { TargetCapacityTypes = new List<string> {
                                "on-demand-capacity-reservation",
                                "capacity-block",
                                "interruptible-capacity-reservation",
                                "on-demand"
                            } }
                        },
                        OnDemandAllocationStrategy = "prioritized"
                    },
                    LaunchTemplate = new LaunchTemplate {
                        LaunchTemplateSpecification = new LaunchTemplateSpecification {
                            LaunchTemplateName = "my-template-for-auto-scaling",
                            Version = "$Default"
                        },
                        Overrides = new List<LaunchTemplateOverrides> {
                            new LaunchTemplateOverrides { InstanceType = "m5.24xlarge" },
                            new LaunchTemplateOverrides { InstanceType = "p5.48xlarge" }
                        }
                    }
                },
                VPCZoneIdentifier = "subnet-057fa0918fEXAMPLE"
            });


            #endregion
        }

        public void AutoScalingCreateAutoScalingGroup()
        {
            #region CreateAutoScalingGroup-5

            var client = new AmazonAutoScalingClient();
            var response = client.CreateAutoScalingGroup(new CreateAutoScalingGroupRequest
            {
                AutoScalingGroupName = "my-auto-scaling-group",
                DefaultInstanceWarmup = 120,
                LaunchTemplate = new LaunchTemplateSpecification {
                    LaunchTemplateName = "my-template-for-auto-scaling",
                    Version = "$Default"
                },
                MaxInstanceLifetime = 2592000,
                MaxSize = 3,
                MinSize = 1,
                VPCZoneIdentifier = "subnet-057fa0918fEXAMPLE"
            });


            #endregion
        }

        public void AutoScalingCreateLaunchConfiguration()
        {
            #region CreateLaunchConfiguration-1

            var client = new AmazonAutoScalingClient();
            var response = client.CreateLaunchConfiguration(new CreateLaunchConfigurationRequest
            {
                IamInstanceProfile = "my-iam-role",
                ImageId = "ami-12345678",
                InstanceType = "m3.medium",
                LaunchConfigurationName = "my-launch-config",
                SecurityGroups = new List<string> {
                    "sg-eb2af88e"
                }
            });


            #endregion
        }

        public void AutoScalingCreateOrUpdateTags()
        {
            #region CreateOrUpdateTags-1

            var client = new AmazonAutoScalingClient();
            var response = client.CreateOrUpdateTags(new CreateOrUpdateTagsRequest
            {
                Tags = new List<Tag> {
                    new Tag {
                        Key = "Role",
                        PropagateAtLaunch = true,
                        ResourceId = "my-auto-scaling-group",
                        ResourceType = "auto-scaling-group",
                        Value = "WebServer"
                    },
                    new Tag {
                        Key = "Dept",
                        PropagateAtLaunch = true,
                        ResourceId = "my-auto-scaling-group",
                        ResourceType = "auto-scaling-group",
                        Value = "Research"
                    }
                }
            });


            #endregion
        }

        public void AutoScalingDeleteAutoScalingGroup()
        {
            #region DeleteAutoScalingGroup-1

            var client = new AmazonAutoScalingClient();
            var response = client.DeleteAutoScalingGroup(new DeleteAutoScalingGroupRequest
            {
                AutoScalingGroupName = "my-auto-scaling-group"
            });


            #endregion
        }

        public void AutoScalingDeleteAutoScalingGroup()
        {
            #region DeleteAutoScalingGroup-2

            var client = new AmazonAutoScalingClient();
            var response = client.DeleteAutoScalingGroup(new DeleteAutoScalingGroupRequest
            {
                AutoScalingGroupName = "my-auto-scaling-group",
                ForceDelete = true
            });


            #endregion
        }

        public void AutoScalingDeleteLaunchConfiguration()
        {
            #region DeleteLaunchConfiguration-1

            var client = new AmazonAutoScalingClient();
            var response = client.DeleteLaunchConfiguration(new DeleteLaunchConfigurationRequest
            {
                LaunchConfigurationName = "my-launch-config"
            });


            #endregion
        }

        public void AutoScalingDeleteLifecycleHook()
        {
            #region DeleteLifecycleHook-1

            var client = new AmazonAutoScalingClient();
            var response = client.DeleteLifecycleHook(new DeleteLifecycleHookRequest
            {
                AutoScalingGroupName = "my-auto-scaling-group",
                LifecycleHookName = "my-lifecycle-hook"
            });


            #endregion
        }

        public void AutoScalingDeleteNotificationConfiguration()
        {
            #region DeleteNotificationConfiguration-1

            var client = new AmazonAutoScalingClient();
            var response = client.DeleteNotificationConfiguration(new DeleteNotificationConfigurationRequest
            {
                AutoScalingGroupName = "my-auto-scaling-group",
                TopicARN = "arn:aws:sns:us-west-2:123456789012:my-sns-topic"
            });


            #endregion
        }

        public void AutoScalingDeletePolicy()
        {
            #region DeletePolicy-1

            var client = new AmazonAutoScalingClient();
            var response = client.DeletePolicy(new DeletePolicyRequest
            {
                AutoScalingGroupName = "my-auto-scaling-group",
                PolicyName = "my-step-scale-out-policy"
            });


            #endregion
        }

        public void AutoScalingDeleteScheduledAction()
        {
            #region DeleteScheduledAction-1

            var client = new AmazonAutoScalingClient();
            var response = client.DeleteScheduledAction(new DeleteScheduledActionRequest
            {
                AutoScalingGroupName = "my-auto-scaling-group",
                ScheduledActionName = "my-scheduled-action"
            });


            #endregion
        }

        public void AutoScalingDeleteTags()
        {
            #region DeleteTags-1

            var client = new AmazonAutoScalingClient();
            var response = client.DeleteTags(new DeleteTagsRequest
            {
                Tags = new List<Tag> {
                    new Tag {
                        Key = "Dept",
                        ResourceId = "my-auto-scaling-group",
                        ResourceType = "auto-scaling-group",
                        Value = "Research"
                    }
                }
            });


            #endregion
        }

        public void AutoScalingDescribeAccountLimits()
        {
            #region DescribeAccountLimits-1

            var client = new AmazonAutoScalingClient();
            var response = client.DescribeAccountLimits(new DescribeAccountLimitsRequest
            {
            });

            int? maxNumberOfAutoScalingGroups = response.MaxNumberOfAutoScalingGroups;
            int? maxNumberOfLaunchConfigurations = response.MaxNumberOfLaunchConfigurations;
            int? numberOfAutoScalingGroups = response.NumberOfAutoScalingGroups;
            int? numberOfLaunchConfigurations = response.NumberOfLaunchConfigurations;

            #endregion
        }

        public void AutoScalingDescribeAdjustmentTypes()
        {
            #region DescribeAdjustmentTypes-1

            var client = new AmazonAutoScalingClient();
            var response = client.DescribeAdjustmentTypes(new DescribeAdjustmentTypesRequest
            {
            });

            List<AdjustmentType> adjustmentTypes = response.AdjustmentTypes;

            #endregion
        }

        public void AutoScalingDescribeAutoScalingGroups()
        {
            #region DescribeAutoScalingGroups-1

            var client = new AmazonAutoScalingClient();
            var response = client.DescribeAutoScalingGroups(new DescribeAutoScalingGroupsRequest
            {
                AutoScalingGroupNames = new List<string> {
                    "my-auto-scaling-group"
                }
            });

            List<AutoScalingGroup> autoScalingGroups = response.AutoScalingGroups;

            #endregion
        }

        public void AutoScalingDescribeAutoScalingInstances()
        {
            #region DescribeAutoScalingInstances-1

            var client = new AmazonAutoScalingClient();
            var response = client.DescribeAutoScalingInstances(new DescribeAutoScalingInstancesRequest
            {
                InstanceIds = new List<string> {
                    "i-05b4f7d5be44822a6"
                }
            });

            List<AutoScalingInstanceDetails> autoScalingInstances = response.AutoScalingInstances;

            #endregion
        }

        public void AutoScalingDescribeAutoScalingNotificationTypes()
        {
            #region DescribeAutoScalingNotificationTypes-1

            var client = new AmazonAutoScalingClient();
            var response = client.DescribeAutoScalingNotificationTypes(new DescribeAutoScalingNotificationTypesRequest
            {
            });

            List<string> autoScalingNotificationTypes = response.AutoScalingNotificationTypes;

            #endregion
        }

        public void AutoScalingDescribeLaunchConfigurations()
        {
            #region DescribeLaunchConfigurations-1

            var client = new AmazonAutoScalingClient();
            var response = client.DescribeLaunchConfigurations(new DescribeLaunchConfigurationsRequest
            {
                LaunchConfigurationNames = new List<string> {
                    "my-launch-config"
                }
            });

            List<LaunchConfiguration> launchConfigurations = response.LaunchConfigurations;

            #endregion
        }

        public void AutoScalingDescribeLifecycleHooks()
        {
            #region DescribeLifecycleHooks-1

            var client = new AmazonAutoScalingClient();
            var response = client.DescribeLifecycleHooks(new DescribeLifecycleHooksRequest
            {
                AutoScalingGroupName = "my-auto-scaling-group"
            });

            List<LifecycleHook> lifecycleHooks = response.LifecycleHooks;

            #endregion
        }

        public void AutoScalingDescribeLifecycleHookTypes()
        {
            #region DescribeLifecycleHookTypes-1

            var client = new AmazonAutoScalingClient();
            var response = client.DescribeLifecycleHookTypes(new DescribeLifecycleHookTypesRequest
            {
            });

            List<string> lifecycleHookTypes = response.LifecycleHookTypes;

            #endregion
        }

        public void AutoScalingDescribeLoadBalancers()
        {
            #region DescribeLoadBalancers-1

            var client = new AmazonAutoScalingClient();
            var response = client.DescribeLoadBalancers(new DescribeLoadBalancersRequest
            {
                AutoScalingGroupName = "my-auto-scaling-group"
            });

            List<LoadBalancerState> loadBalancers = response.LoadBalancers;

            #endregion
        }

        public void AutoScalingDescribeLoadBalancerTargetGroups()
        {
            #region DescribeLoadBalancerTargetGroups-1

            var client = new AmazonAutoScalingClient();
            var response = client.DescribeLoadBalancerTargetGroups(new DescribeLoadBalancerTargetGroupsRequest
            {
                AutoScalingGroupName = "my-auto-scaling-group"
            });

            List<LoadBalancerTargetGroupState> loadBalancerTargetGroups = response.LoadBalancerTargetGroups;

            #endregion
        }

        public void AutoScalingDescribeMetricCollectionTypes()
        {
            #region DescribeMetricCollectionTypes-1

            var client = new AmazonAutoScalingClient();
            var response = client.DescribeMetricCollectionTypes(new DescribeMetricCollectionTypesRequest
            {
            });

            List<MetricGranularityType> granularities = response.Granularities;
            List<MetricCollectionType> metrics = response.Metrics;

            #endregion
        }

        public void AutoScalingDescribeNotificationConfigurations()
        {
            #region DescribeNotificationConfigurations-1

            var client = new AmazonAutoScalingClient();
            var response = client.DescribeNotificationConfigurations(new DescribeNotificationConfigurationsRequest
            {
                AutoScalingGroupNames = new List<string> {
                    "my-auto-scaling-group"
                }
            });

            List<NotificationConfiguration> notificationConfigurations = response.NotificationConfigurations;

            #endregion
        }

        public void AutoScalingDescribePolicies()
        {
            #region DescribePolicies-1

            var client = new AmazonAutoScalingClient();
            var response = client.DescribePolicies(new DescribePoliciesRequest
            {
                AutoScalingGroupName = "my-auto-scaling-group"
            });

            List<ScalingPolicy> scalingPolicies = response.ScalingPolicies;

            #endregion
        }

        public void AutoScalingDescribeScalingActivities()
        {
            #region DescribeScalingActivities-1

            var client = new AmazonAutoScalingClient();
            var response = client.DescribeScalingActivities(new DescribeScalingActivitiesRequest
            {
                AutoScalingGroupName = "my-auto-scaling-group"
            });

            List<Activity> activities = response.Activities;

            #endregion
        }

        public void AutoScalingDescribeScalingProcessTypes()
        {
            #region DescribeScalingProcessTypes-1

            var client = new AmazonAutoScalingClient();
            var response = client.DescribeScalingProcessTypes(new DescribeScalingProcessTypesRequest
            {
            });

            List<ProcessType> processes = response.Processes;

            #endregion
        }

        public void AutoScalingDescribeScheduledActions()
        {
            #region DescribeScheduledActions-1

            var client = new AmazonAutoScalingClient();
            var response = client.DescribeScheduledActions(new DescribeScheduledActionsRequest
            {
                AutoScalingGroupName = "my-auto-scaling-group"
            });

            List<ScheduledUpdateGroupAction> scheduledUpdateGroupActions = response.ScheduledUpdateGroupActions;

            #endregion
        }

        public void AutoScalingDescribeTags()
        {
            #region DescribeTags-1

            var client = new AmazonAutoScalingClient();
            var response = client.DescribeTags(new DescribeTagsRequest
            {
                Filters = new List<Filter> {
                    new Filter {
                        Name = "auto-scaling-group",
                        Values = new List<string> {
                            "my-auto-scaling-group"
                        }
                    }
                }
            });

            List<TagDescription> tags = response.Tags;

            #endregion
        }

        public void AutoScalingDescribeTerminationPolicyTypes()
        {
            #region DescribeTerminationPolicyTypes-1

            var client = new AmazonAutoScalingClient();
            var response = client.DescribeTerminationPolicyTypes(new DescribeTerminationPolicyTypesRequest
            {
            });

            List<string> terminationPolicyTypes = response.TerminationPolicyTypes;

            #endregion
        }

        public void AutoScalingDescribeTrafficSources()
        {
            #region DescribeTrafficSources-1

            var client = new AmazonAutoScalingClient();
            var response = client.DescribeTrafficSources(new DescribeTrafficSourcesRequest
            {
                AutoScalingGroupName = "my-auto-scaling-group"
            });

            string nextToken = response.NextToken;
            List<TrafficSourceState> trafficSources = response.TrafficSources;

            #endregion
        }

        public void AutoScalingDetachInstances()
        {
            #region DetachInstances-1

            var client = new AmazonAutoScalingClient();
            var response = client.DetachInstances(new DetachInstancesRequest
            {
                AutoScalingGroupName = "my-auto-scaling-group",
                InstanceIds = new List<string> {
                    "i-93633f9b"
                },
                ShouldDecrementDesiredCapacity = true
            });

            List<Activity> activities = response.Activities;

            #endregion
        }

        public void AutoScalingDetachLoadBalancers()
        {
            #region DetachLoadBalancers-1

            var client = new AmazonAutoScalingClient();
            var response = client.DetachLoadBalancers(new DetachLoadBalancersRequest
            {
                AutoScalingGroupName = "my-auto-scaling-group",
                LoadBalancerNames = new List<string> {
                    "my-load-balancer"
                }
            });


            #endregion
        }

        public void AutoScalingDetachLoadBalancerTargetGroups()
        {
            #region DetachLoadBalancerTargetGroups-1

            var client = new AmazonAutoScalingClient();
            var response = client.DetachLoadBalancerTargetGroups(new DetachLoadBalancerTargetGroupsRequest
            {
                AutoScalingGroupName = "my-auto-scaling-group",
                TargetGroupARNs = new List<string> {
                    "arn:aws:elasticloadbalancing:us-west-2:123456789012:targetgroup/my-targets/73e2d6bc24d8a067"
                }
            });


            #endregion
        }

        public void AutoScalingDetachTrafficSources()
        {
            #region DetachTrafficSources-1

            var client = new AmazonAutoScalingClient();
            var response = client.DetachTrafficSources(new DetachTrafficSourcesRequest
            {
                AutoScalingGroupName = "my-auto-scaling-group",
                TrafficSources = new List<TrafficSourceIdentifier> {
                    new TrafficSourceIdentifier { Identifier = "arn:aws:elasticloadbalancing:us-west-2:123456789012:targetgroup/my-targets/73e2d6bc24d8a067" }
                }
            });


            #endregion
        }

        public void AutoScalingDisableMetricsCollection()
        {
            #region DisableMetricsCollection-1

            var client = new AmazonAutoScalingClient();
            var response = client.DisableMetricsCollection(new DisableMetricsCollectionRequest
            {
                AutoScalingGroupName = "my-auto-scaling-group",
                Metrics = new List<string> {
                    "GroupDesiredCapacity"
                }
            });


            #endregion
        }

        public void AutoScalingEnableMetricsCollection()
        {
            #region EnableMetricsCollection-1

            var client = new AmazonAutoScalingClient();
            var response = client.EnableMetricsCollection(new EnableMetricsCollectionRequest
            {
                AutoScalingGroupName = "my-auto-scaling-group",
                Granularity = "1Minute"
            });


            #endregion
        }

        public void AutoScalingEnterStandby()
        {
            #region EnterStandby-1

            var client = new AmazonAutoScalingClient();
            var response = client.EnterStandby(new EnterStandbyRequest
            {
                AutoScalingGroupName = "my-auto-scaling-group",
                InstanceIds = new List<string> {
                    "i-93633f9b"
                },
                ShouldDecrementDesiredCapacity = true
            });

            List<Activity> activities = response.Activities;

            #endregion
        }

        public void AutoScalingExecutePolicy()
        {
            #region ExecutePolicy-1

            var client = new AmazonAutoScalingClient();
            var response = client.ExecutePolicy(new ExecutePolicyRequest
            {
                AutoScalingGroupName = "my-auto-scaling-group",
                BreachThreshold = 50,
                MetricValue = 59,
                PolicyName = "my-step-scale-out-policy"
            });


            #endregion
        }

        public void AutoScalingExitStandby()
        {
            #region ExitStandby-1

            var client = new AmazonAutoScalingClient();
            var response = client.ExitStandby(new ExitStandbyRequest
            {
                AutoScalingGroupName = "my-auto-scaling-group",
                InstanceIds = new List<string> {
                    "i-93633f9b"
                }
            });

            List<Activity> activities = response.Activities;

            #endregion
        }

        public void AutoScalingPutLifecycleHook()
        {
            #region PutLifecycleHook-1

            var client = new AmazonAutoScalingClient();
            var response = client.PutLifecycleHook(new PutLifecycleHookRequest
            {
                AutoScalingGroupName = "my-auto-scaling-group",
                DefaultResult = "CONTINUE",
                HeartbeatTimeout = 300,
                LifecycleHookName = "my-launch-lifecycle-hook",
                LifecycleTransition = "autoscaling:EC2_INSTANCE_LAUNCHING"
            });


            #endregion
        }

        public void AutoScalingPutNotificationConfiguration()
        {
            #region PutNotificationConfiguration-1

            var client = new AmazonAutoScalingClient();
            var response = client.PutNotificationConfiguration(new PutNotificationConfigurationRequest
            {
                AutoScalingGroupName = "my-auto-scaling-group",
                NotificationTypes = new List<string> {
                    "autoscaling:TEST_NOTIFICATION"
                },
                TopicARN = "arn:aws:sns:us-west-2:123456789012:my-sns-topic"
            });


            #endregion
        }

        public void AutoScalingPutScalingPolicy()
        {
            #region PutScalingPolicy-1

            var client = new AmazonAutoScalingClient();
            var response = client.PutScalingPolicy(new PutScalingPolicyRequest
            {
                AutoScalingGroupName = "my-auto-scaling-group",
                PolicyName = "alb1000-target-tracking-scaling-policy",
                PolicyType = "TargetTrackingScaling",
                TargetTrackingConfiguration = new TargetTrackingConfiguration {
                    PredefinedMetricSpecification = new PredefinedMetricSpecification {
                        PredefinedMetricType = "ALBRequestCountPerTarget",
                        ResourceLabel = "app/my-alb/778d41231b141a0f/targetgroup/my-alb-target-group/943f017f100becff"
                    },
                    TargetValue = 1000
                }
            });

            List<Alarm> alarms = response.Alarms;
            string policyARN = response.PolicyARN;

            #endregion
        }

        public void AutoScalingPutScheduledUpdateGroupAction()
        {
            #region PutScheduledUpdateGroupAction-1

            var client = new AmazonAutoScalingClient();
            var response = client.PutScheduledUpdateGroupAction(new PutScheduledUpdateGroupActionRequest
            {
                AutoScalingGroupName = "my-auto-scaling-group",
                DesiredCapacity = 4,
                EndTime = new DateTime(2014, 5, 12, 8, 0, 0, DateTimeKind.Utc),
                MaxSize = 6,
                MinSize = 2,
                ScheduledActionName = "my-scheduled-action",
                StartTime = new DateTime(2014, 5, 12, 8, 0, 0, DateTimeKind.Utc)
            });


            #endregion
        }

        public void AutoScalingPutWarmPool()
        {
            #region PutWarmPool-1

            var client = new AmazonAutoScalingClient();
            var response = client.PutWarmPool(new PutWarmPoolRequest
            {
                AutoScalingGroupName = "my-auto-scaling-group",
                InstanceReusePolicy = new InstanceReusePolicy { ReuseOnScaleIn = true },
                MinSize = 30,
                PoolState = "Hibernated"
            });


            #endregion
        }

        public void AutoScalingRecordLifecycleActionHeartbeat()
        {
            #region RecordLifecycleActionHeartbeat-1

            var client = new AmazonAutoScalingClient();
            var response = client.RecordLifecycleActionHeartbeat(new RecordLifecycleActionHeartbeatRequest
            {
                AutoScalingGroupName = "my-auto-scaling-group",
                LifecycleActionToken = "bcd2f1b8-9a78-44d3-8a7a-4dd07d7cf635",
                LifecycleHookName = "my-lifecycle-hook"
            });


            #endregion
        }

        public void AutoScalingResumeProcesses()
        {
            #region ResumeProcesses-1

            var client = new AmazonAutoScalingClient();
            var response = client.ResumeProcesses(new ResumeProcessesRequest
            {
                AutoScalingGroupName = "my-auto-scaling-group",
                ScalingProcesses = new List<string> {
                    "AlarmNotification"
                }
            });


            #endregion
        }

        public void AutoScalingSetDesiredCapacity()
        {
            #region SetDesiredCapacity-1

            var client = new AmazonAutoScalingClient();
            var response = client.SetDesiredCapacity(new SetDesiredCapacityRequest
            {
                AutoScalingGroupName = "my-auto-scaling-group",
                DesiredCapacity = 2,
                HonorCooldown = true
            });


            #endregion
        }

        public void AutoScalingSetInstanceHealth()
        {
            #region SetInstanceHealth-1

            var client = new AmazonAutoScalingClient();
            var response = client.SetInstanceHealth(new SetInstanceHealthRequest
            {
                HealthStatus = "Unhealthy",
                InstanceId = "i-93633f9b"
            });


            #endregion
        }

        public void AutoScalingSetInstanceProtection()
        {
            #region SetInstanceProtection-1

            var client = new AmazonAutoScalingClient();
            var response = client.SetInstanceProtection(new SetInstanceProtectionRequest
            {
                AutoScalingGroupName = "my-auto-scaling-group",
                InstanceIds = new List<string> {
                    "i-93633f9b"
                },
                ProtectedFromScaleIn = true
            });


            #endregion
        }

        public void AutoScalingSetInstanceProtection()
        {
            #region SetInstanceProtection-2

            var client = new AmazonAutoScalingClient();
            var response = client.SetInstanceProtection(new SetInstanceProtectionRequest
            {
                AutoScalingGroupName = "my-auto-scaling-group",
                InstanceIds = new List<string> {
                    "i-93633f9b"
                },
                ProtectedFromScaleIn = false
            });


            #endregion
        }

        public void AutoScalingStartInstanceRefresh()
        {
            #region StartInstanceRefresh-1

            var client = new AmazonAutoScalingClient();
            var response = client.StartInstanceRefresh(new StartInstanceRefreshRequest
            {
                AutoScalingGroupName = "my-auto-scaling-group",
                DesiredConfiguration = new DesiredConfiguration { LaunchTemplate = new LaunchTemplateSpecification {
                    LaunchTemplateName = "my-template-for-auto-scaling",
                    Version = "$Latest"
                } },
                Preferences = new RefreshPreferences {
                    AlarmSpecification = new AlarmSpecification { Alarms = new List<string> {
                        "my-alarm"
                    } },
                    AutoRollback = true,
                    InstanceWarmup = 200,
                    MaxHealthyPercentage = 120,
                    MinHealthyPercentage = 90
                }
            });

            string instanceRefreshId = response.InstanceRefreshId;

            #endregion
        }

        public void AutoScalingSuspendProcesses()
        {
            #region SuspendProcesses-1

            var client = new AmazonAutoScalingClient();
            var response = client.SuspendProcesses(new SuspendProcessesRequest
            {
                AutoScalingGroupName = "my-auto-scaling-group",
                ScalingProcesses = new List<string> {
                    "AlarmNotification"
                }
            });


            #endregion
        }

        public void AutoScalingTerminateInstanceInAutoScalingGroup()
        {
            #region TerminateInstanceInAutoScalingGroup-1

            var client = new AmazonAutoScalingClient();
            var response = client.TerminateInstanceInAutoScalingGroup(new TerminateInstanceInAutoScalingGroupRequest
            {
                InstanceId = "i-93633f9b",
                ShouldDecrementDesiredCapacity = false
            });


            #endregion
        }

        public void AutoScalingTerminateInstanceInAutoScalingGroup()
        {
            #region TerminateInstanceInAutoScalingGroup-2

            var client = new AmazonAutoScalingClient();
            var response = client.TerminateInstanceInAutoScalingGroup(new TerminateInstanceInAutoScalingGroupRequest
            {
                AutoScalingGroupName = "my-asg",
                InstanceIds = new List<string> {
                    "i-93633f9b",
                    "i-ab4d5e6f7"
                },
                ShouldDecrementDesiredCapacity = false
            });

            List<Activity> activities = response.Activities;

            #endregion
        }

        public void AutoScalingUpdateAutoScalingGroup()
        {
            #region UpdateAutoScalingGroup-1

            var client = new AmazonAutoScalingClient();
            var response = client.UpdateAutoScalingGroup(new UpdateAutoScalingGroupRequest
            {
                AutoScalingGroupName = "my-auto-scaling-group",
                LaunchTemplate = new LaunchTemplateSpecification {
                    LaunchTemplateName = "my-template-for-auto-scaling",
                    Version = "2"
                },
                MaxSize = 5,
                MinSize = 1,
                NewInstancesProtectedFromScaleIn = true
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
