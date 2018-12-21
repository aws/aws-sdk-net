using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Amazon.AutoScaling;
using Amazon.AutoScaling.Model;

namespace AWSSDKDocSamples.Amazon.AutoScaling.Generated
{
    class AutoScalingSamples : ISample
    {
        static IAmazonAutoScaling client = new AmazonAutoScalingClient();
        public void AutoScalingAttachInstances()
        {
            #region autoscaling-attach-instances-1

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
            #region autoscaling-attach-load-balancers-1

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
            #region autoscaling-attach-load-balancer-target-groups-1

            var response = client.AttachLoadBalancerTargetGroups(new AttachLoadBalancerTargetGroupsRequest 
            {
                AutoScalingGroupName = "my-auto-scaling-group",
                TargetGroupARNs = new List<string> {
                    "arn:aws:elasticloadbalancing:us-west-2:123456789012:targetgroup/my-targets/73e2d6bc24d8a067"
                }
            });


            #endregion
        }

        public void AutoScalingCompleteLifecycleAction()
        {
            #region autoscaling-complete-lifecycle-action-1

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
            #region autoscaling-create-auto-scaling-group-1

            var response = client.CreateAutoScalingGroup(new CreateAutoScalingGroupRequest 
            {
                AutoScalingGroupName = "my-auto-scaling-group",
                LaunchConfigurationName = "my-launch-config",
                MaxSize = 3,
                MinSize = 1,
                VPCZoneIdentifier = "subnet-4176792c"
            });


            #endregion
        }

        public void AutoScalingCreateAutoScalingGroup()
        {
            #region autoscaling-create-auto-scaling-group-2

            var response = client.CreateAutoScalingGroup(new CreateAutoScalingGroupRequest 
            {
                AutoScalingGroupName = "my-auto-scaling-group",
                AvailabilityZones = new List<string> {
                    "us-west-2c"
                },
                HealthCheckGracePeriod = 120,
                HealthCheckType = "ELB",
                LaunchConfigurationName = "my-launch-config",
                LoadBalancerNames = new List<string> {
                    "my-load-balancer"
                },
                MaxSize = 3,
                MinSize = 1
            });


            #endregion
        }

        public void AutoScalingCreateAutoScalingGroup()
        {
            #region autoscaling-create-auto-scaling-group-3

            var response = client.CreateAutoScalingGroup(new CreateAutoScalingGroupRequest 
            {
                AutoScalingGroupName = "my-auto-scaling-group",
                HealthCheckGracePeriod = 120,
                HealthCheckType = "ELB",
                LaunchConfigurationName = "my-launch-config",
                MaxSize = 3,
                MinSize = 1,
                TargetGroupARNs = new List<string> {
                    "arn:aws:elasticloadbalancing:us-west-2:123456789012:targetgroup/my-targets/73e2d6bc24d8a067"
                },
                VPCZoneIdentifier = "subnet-4176792c, subnet-65ea5f08"
            });


            #endregion
        }

        public void AutoScalingCreateLaunchConfiguration()
        {
            #region autoscaling-create-launch-configuration-1

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
            #region autoscaling-create-or-update-tags-1

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
            #region autoscaling-delete-auto-scaling-group-1

            var response = client.DeleteAutoScalingGroup(new DeleteAutoScalingGroupRequest 
            {
                AutoScalingGroupName = "my-auto-scaling-group"
            });


            #endregion
        }

        public void AutoScalingDeleteAutoScalingGroup()
        {
            #region autoscaling-delete-auto-scaling-group-2

            var response = client.DeleteAutoScalingGroup(new DeleteAutoScalingGroupRequest 
            {
                AutoScalingGroupName = "my-auto-scaling-group",
                ForceDelete = true
            });


            #endregion
        }

        public void AutoScalingDeleteLaunchConfiguration()
        {
            #region autoscaling-delete-launch-configuration-1

            var response = client.DeleteLaunchConfiguration(new DeleteLaunchConfigurationRequest 
            {
                LaunchConfigurationName = "my-launch-config"
            });


            #endregion
        }

        public void AutoScalingDeleteLifecycleHook()
        {
            #region autoscaling-delete-lifecycle-hook-1

            var response = client.DeleteLifecycleHook(new DeleteLifecycleHookRequest 
            {
                AutoScalingGroupName = "my-auto-scaling-group",
                LifecycleHookName = "my-lifecycle-hook"
            });


            #endregion
        }

        public void AutoScalingDeleteNotificationConfiguration()
        {
            #region autoscaling-delete-notification-configuration-1

            var response = client.DeleteNotificationConfiguration(new DeleteNotificationConfigurationRequest 
            {
                AutoScalingGroupName = "my-auto-scaling-group",
                TopicARN = "arn:aws:sns:us-west-2:123456789012:my-sns-topic"
            });


            #endregion
        }

        public void AutoScalingDeletePolicy()
        {
            #region autoscaling-delete-policy-1

            var response = client.DeletePolicy(new DeletePolicyRequest 
            {
                AutoScalingGroupName = "my-auto-scaling-group",
                PolicyName = "ScaleIn"
            });


            #endregion
        }

        public void AutoScalingDeleteScheduledAction()
        {
            #region autoscaling-delete-scheduled-action-1

            var response = client.DeleteScheduledAction(new DeleteScheduledActionRequest 
            {
                AutoScalingGroupName = "my-auto-scaling-group",
                ScheduledActionName = "my-scheduled-action"
            });


            #endregion
        }

        public void AutoScalingDeleteTags()
        {
            #region autoscaling-delete-tags-1

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
            #region autoscaling-describe-account-limits-1

            var response = client.DescribeAccountLimits(new DescribeAccountLimitsRequest 
            {
            });

            integer maxNumberOfAutoScalingGroups = response.MaxNumberOfAutoScalingGroups;
            integer maxNumberOfLaunchConfigurations = response.MaxNumberOfLaunchConfigurations;
            integer numberOfAutoScalingGroups = response.NumberOfAutoScalingGroups;
            integer numberOfLaunchConfigurations = response.NumberOfLaunchConfigurations;

            #endregion
        }

        public void AutoScalingDescribeAdjustmentTypes()
        {
            #region autoscaling-describe-adjustment-types-1

            var response = client.DescribeAdjustmentTypes(new DescribeAdjustmentTypesRequest 
            {
            });

            List<AdjustmentType> adjustmentTypes = response.AdjustmentTypes;

            #endregion
        }

        public void AutoScalingDescribeAutoScalingGroups()
        {
            #region autoscaling-describe-auto-scaling-groups-1

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
            #region autoscaling-describe-auto-scaling-instances-1

            var response = client.DescribeAutoScalingInstances(new DescribeAutoScalingInstancesRequest 
            {
                InstanceIds = new List<string> {
                    "i-4ba0837f"
                }
            });

            List<AutoScalingInstanceDetails> autoScalingInstances = response.AutoScalingInstances;

            #endregion
        }

        public void AutoScalingDescribeAutoScalingNotificationTypes()
        {
            #region autoscaling-describe-auto-scaling-notification-types-1

            var response = client.DescribeAutoScalingNotificationTypes(new DescribeAutoScalingNotificationTypesRequest 
            {
            });

            List<string> autoScalingNotificationTypes = response.AutoScalingNotificationTypes;

            #endregion
        }

        public void AutoScalingDescribeLaunchConfigurations()
        {
            #region autoscaling-describe-launch-configurations-1

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
            #region autoscaling-describe-lifecycle-hooks-1

            var response = client.DescribeLifecycleHooks(new DescribeLifecycleHooksRequest 
            {
                AutoScalingGroupName = "my-auto-scaling-group"
            });

            List<LifecycleHook> lifecycleHooks = response.LifecycleHooks;

            #endregion
        }

        public void AutoScalingDescribeLifecycleHookTypes()
        {
            #region autoscaling-describe-lifecycle-hook-types-1

            var response = client.DescribeLifecycleHookTypes(new DescribeLifecycleHookTypesRequest 
            {
            });

            List<string> lifecycleHookTypes = response.LifecycleHookTypes;

            #endregion
        }

        public void AutoScalingDescribeLoadBalancers()
        {
            #region autoscaling-describe-load-balancers-1

            var response = client.DescribeLoadBalancers(new DescribeLoadBalancersRequest 
            {
                AutoScalingGroupName = "my-auto-scaling-group"
            });

            List<LoadBalancerState> loadBalancers = response.LoadBalancers;

            #endregion
        }

        public void AutoScalingDescribeLoadBalancerTargetGroups()
        {
            #region autoscaling-describe-load-balancer-target-groups-1

            var response = client.DescribeLoadBalancerTargetGroups(new DescribeLoadBalancerTargetGroupsRequest 
            {
                AutoScalingGroupName = "my-auto-scaling-group"
            });

            List<LoadBalancerTargetGroupState> loadBalancerTargetGroups = response.LoadBalancerTargetGroups;

            #endregion
        }

        public void AutoScalingDescribeMetricCollectionTypes()
        {
            #region autoscaling-describe-metric-collection-types-1

            var response = client.DescribeMetricCollectionTypes(new DescribeMetricCollectionTypesRequest 
            {
            });

            List<MetricGranularityType> granularities = response.Granularities;
            List<MetricCollectionType> metrics = response.Metrics;

            #endregion
        }

        public void AutoScalingDescribeNotificationConfigurations()
        {
            #region autoscaling-describe-notification-configurations-1

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
            #region autoscaling-describe-policies-1

            var response = client.DescribePolicies(new DescribePoliciesRequest 
            {
                AutoScalingGroupName = "my-auto-scaling-group"
            });

            List<ScalingPolicy> scalingPolicies = response.ScalingPolicies;

            #endregion
        }

        public void AutoScalingDescribeScalingActivities()
        {
            #region autoscaling-describe-scaling-activities-1

            var response = client.DescribeScalingActivities(new DescribeScalingActivitiesRequest 
            {
                AutoScalingGroupName = "my-auto-scaling-group"
            });

            List<Activity> activities = response.Activities;

            #endregion
        }

        public void AutoScalingDescribeScalingProcessTypes()
        {
            #region autoscaling-describe-scaling-process-types-1

            var response = client.DescribeScalingProcessTypes(new DescribeScalingProcessTypesRequest 
            {
            });

            List<ProcessType> processes = response.Processes;

            #endregion
        }

        public void AutoScalingDescribeScheduledActions()
        {
            #region autoscaling-describe-scheduled-actions-1

            var response = client.DescribeScheduledActions(new DescribeScheduledActionsRequest 
            {
                AutoScalingGroupName = "my-auto-scaling-group"
            });

            List<ScheduledUpdateGroupAction> scheduledUpdateGroupActions = response.ScheduledUpdateGroupActions;

            #endregion
        }

        public void AutoScalingDescribeTags()
        {
            #region autoscaling-describe-tags-1

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
            #region autoscaling-describe-termination-policy-types-1

            var response = client.DescribeTerminationPolicyTypes(new DescribeTerminationPolicyTypesRequest 
            {
            });

            List<string> terminationPolicyTypes = response.TerminationPolicyTypes;

            #endregion
        }

        public void AutoScalingDetachInstances()
        {
            #region autoscaling-detach-instances-1

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
            #region autoscaling-detach-load-balancers-1

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
            #region autoscaling-detach-load-balancer-target-groups-1

            var response = client.DetachLoadBalancerTargetGroups(new DetachLoadBalancerTargetGroupsRequest 
            {
                AutoScalingGroupName = "my-auto-scaling-group",
                TargetGroupARNs = new List<string> {
                    "arn:aws:elasticloadbalancing:us-west-2:123456789012:targetgroup/my-targets/73e2d6bc24d8a067"
                }
            });


            #endregion
        }

        public void AutoScalingDisableMetricsCollection()
        {
            #region autoscaling-disable-metrics-collection-1

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
            #region autoscaling-enable-metrics-collection-1

            var response = client.EnableMetricsCollection(new EnableMetricsCollectionRequest 
            {
                AutoScalingGroupName = "my-auto-scaling-group",
                Granularity = "1Minute"
            });


            #endregion
        }

        public void AutoScalingEnterStandby()
        {
            #region autoscaling-enter-standby-1

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
            #region autoscaling-execute-policy-1

            var response = client.ExecutePolicy(new ExecutePolicyRequest 
            {
                AutoScalingGroupName = "my-auto-scaling-group",
                HonorCooldown = true,
                PolicyName = "ScaleIn"
            });


            #endregion
        }

        public void AutoScalingExitStandby()
        {
            #region autoscaling-exit-standby-1

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
            #region autoscaling-put-lifecycle-hook-1

            var response = client.PutLifecycleHook(new PutLifecycleHookRequest 
            {
                AutoScalingGroupName = "my-auto-scaling-group",
                LifecycleHookName = "my-lifecycle-hook",
                LifecycleTransition = "autoscaling:EC2_INSTANCE_LAUNCHING",
                NotificationTargetARN = "arn:aws:sns:us-west-2:123456789012:my-sns-topic --role-arn",
                RoleARN = "arn:aws:iam::123456789012:role/my-auto-scaling-role"
            });


            #endregion
        }

        public void AutoScalingPutNotificationConfiguration()
        {
            #region autoscaling-put-notification-configuration-1

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
            #region autoscaling-put-scaling-policy-1

            var response = client.PutScalingPolicy(new PutScalingPolicyRequest 
            {
                AdjustmentType = "ChangeInCapacity",
                AutoScalingGroupName = "my-auto-scaling-group",
                PolicyName = "ScaleIn",
                ScalingAdjustment = -1
            });

            string policyARN = response.PolicyARN;

            #endregion
        }

        public void AutoScalingPutScheduledUpdateGroupAction()
        {
            #region autoscaling-put-scheduled-update-group-action-1

            var response = client.PutScheduledUpdateGroupAction(new PutScheduledUpdateGroupActionRequest 
            {
                AutoScalingGroupName = "my-auto-scaling-group",
                DesiredCapacity = 4,
                EndTimeUtc = new DateTime(2014, 5, 12, 1, 0, 0, DateTimeKind.Utc),
                MaxSize = 6,
                MinSize = 2,
                ScheduledActionName = "my-scheduled-action",
                StartTimeUtc = new DateTime(2014, 5, 12, 1, 0, 0, DateTimeKind.Utc)
            });


            #endregion
        }

        public void AutoScalingRecordLifecycleActionHeartbeat()
        {
            #region autoscaling-record-lifecycle-action-heartbeat-1

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
            #region autoscaling-resume-processes-1

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
            #region autoscaling-set-desired-capacity-1

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
            #region autoscaling-set-instance-health-1

            var response = client.SetInstanceHealth(new SetInstanceHealthRequest 
            {
                HealthStatus = "Unhealthy",
                InstanceId = "i-93633f9b"
            });


            #endregion
        }

        public void AutoScalingSetInstanceProtection()
        {
            #region autoscaling-set-instance-protection-1

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
            #region autoscaling-set-instance-protection-2

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

        public void AutoScalingSuspendProcesses()
        {
            #region autoscaling-suspend-processes-1

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
            #region autoscaling-terminate-instance-in-auto-scaling-group-1

            var response = client.TerminateInstanceInAutoScalingGroup(new TerminateInstanceInAutoScalingGroupRequest 
            {
                InstanceId = "i-93633f9b",
                ShouldDecrementDesiredCapacity = false
            });


            #endregion
        }

        public void AutoScalingUpdateAutoScalingGroup()
        {
            #region autoscaling-update-auto-scaling-group-1

            var response = client.UpdateAutoScalingGroup(new UpdateAutoScalingGroupRequest 
            {
                AutoScalingGroupName = "my-auto-scaling-group",
                LaunchConfigurationName = "new-launch-config"
            });


            #endregion
        }

        public void AutoScalingUpdateAutoScalingGroup()
        {
            #region autoscaling-update-auto-scaling-group-2

            var response = client.UpdateAutoScalingGroup(new UpdateAutoScalingGroupRequest 
            {
                AutoScalingGroupName = "my-auto-scaling-group",
                MaxSize = 3,
                MinSize = 1
            });


            #endregion
        }

        public void AutoScalingUpdateAutoScalingGroup()
        {
            #region autoscaling-update-auto-scaling-group-3

            var response = client.UpdateAutoScalingGroup(new UpdateAutoScalingGroupRequest 
            {
                AutoScalingGroupName = "my-auto-scaling-group",
                NewInstancesProtectedFromScaleIn = true
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