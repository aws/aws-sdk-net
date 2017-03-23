using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Amazon.ApplicationAutoScaling;
using Amazon.ApplicationAutoScaling.Model;

namespace AWSSDKDocSamples.Amazon.ApplicationAutoScaling.Generated
{
    class ApplicationAutoScalingSamples : ISample
    {
        static IAmazonApplicationAutoScaling client = new AmazonApplicationAutoScalingClient();
        public void ApplicationAutoScalingDeleteScalingPolicy()
        {
            #region to-delete-a-scaling-policy-1470863892689

            var response = client.DeleteScalingPolicy(new DeleteScalingPolicyRequest 
            {
                PolicyName = "web-app-cpu-lt-25",
                ResourceId = "service/default/web-app",
                ScalableDimension = "ecs:service:DesiredCount",
                ServiceNamespace = "ecs"
            });


            #endregion
        }

        public void ApplicationAutoScalingDeregisterScalableTarget()
        {
            #region to-deregister-a-scalable-target-1470864164895

            var response = client.DeregisterScalableTarget(new DeregisterScalableTargetRequest 
            {
                ResourceId = "service/default/web-app",
                ScalableDimension = "ecs:service:DesiredCount",
                ServiceNamespace = "ecs"
            });


            #endregion
        }

        public void ApplicationAutoScalingDescribeScalableTargets()
        {
            #region to-describe-scalable-targets-1470864286961

            var response = client.DescribeScalableTargets(new DescribeScalableTargetsRequest 
            {
                ServiceNamespace = "ecs"
            });

            List<ScalableTarget> scalableTargets = response.ScalableTargets;

            #endregion
        }

        public void ApplicationAutoScalingDescribeScalingActivities()
        {
            #region to-describe-scaling-activities-for-a-scalable-target-1470864398629

            var response = client.DescribeScalingActivities(new DescribeScalingActivitiesRequest 
            {
                ResourceId = "service/default/web-app",
                ScalableDimension = "ecs:service:DesiredCount",
                ServiceNamespace = "ecs"
            });

            List<ScalingActivity> scalingActivities = response.ScalingActivities;

            #endregion
        }

        public void ApplicationAutoScalingDescribeScalingPolicies()
        {
            #region to-describe-scaling-policies-1470864609734

            var response = client.DescribeScalingPolicies(new DescribeScalingPoliciesRequest 
            {
                ServiceNamespace = "ecs"
            });

            string nextToken = response.NextToken;
            List<ScalingPolicy> scalingPolicies = response.ScalingPolicies;

            #endregion
        }

        public void ApplicationAutoScalingPutScalingPolicy()
        {
            #region to-apply-a-scaling-policy-to-an-amazon-ecs-service-1470864779862

            var response = client.PutScalingPolicy(new PutScalingPolicyRequest 
            {
                PolicyName = "web-app-cpu-gt-75",
                PolicyType = "StepScaling",
                ResourceId = "service/default/web-app",
                ScalableDimension = "ecs:service:DesiredCount",
                ServiceNamespace = "ecs",
                StepScalingPolicyConfiguration = new StepScalingPolicyConfiguration {
                    AdjustmentType = "PercentChangeInCapacity",
                    Cooldown = 60,
                    StepAdjustments = new List<StepAdjustment> {
                        new StepAdjustment {
                            MetricIntervalLowerBound = 0,
                            ScalingAdjustment = 200
                        }
                    }
                }
            });

            string policyARN = response.PolicyARN;

            #endregion
        }

        public void ApplicationAutoScalingPutScalingPolicy()
        {
            #region to-apply-a-scaling-policy-to-an-amazon-ec2-spot-fleet-1472073278469

            var response = client.PutScalingPolicy(new PutScalingPolicyRequest 
            {
                PolicyName = "fleet-cpu-gt-75",
                PolicyType = "StepScaling",
                ResourceId = "spot-fleet-request/sfr-45e69d8a-be48-4539-bbf3-3464e99c50c3",
                ScalableDimension = "ec2:spot-fleet-request:TargetCapacity",
                ServiceNamespace = "ec2",
                StepScalingPolicyConfiguration = new StepScalingPolicyConfiguration {
                    AdjustmentType = "PercentChangeInCapacity",
                    Cooldown = 180,
                    StepAdjustments = new List<StepAdjustment> {
                        new StepAdjustment {
                            MetricIntervalLowerBound = 0,
                            ScalingAdjustment = 200
                        }
                    }
                }
            });

            string policyARN = response.PolicyARN;

            #endregion
        }

        public void ApplicationAutoScalingRegisterScalableTarget()
        {
            #region to-register-a-new-scalable-target-1470864910380

            var response = client.RegisterScalableTarget(new RegisterScalableTargetRequest 
            {
                MaxCapacity = 10,
                MinCapacity = 1,
                ResourceId = "service/default/web-app",
                RoleARN = "arn:aws:iam::012345678910:role/ApplicationAutoscalingECSRole",
                ScalableDimension = "ecs:service:DesiredCount",
                ServiceNamespace = "ecs"
            });


            #endregion
        }

        public void ApplicationAutoScalingRegisterScalableTarget()
        {
            #region to-register-an-ec2-spot-fleet-as-a-scalable-target-1472072899649

            var response = client.RegisterScalableTarget(new RegisterScalableTargetRequest 
            {
                MaxCapacity = 10,
                MinCapacity = 1,
                ResourceId = "spot-fleet-request/sfr-45e69d8a-be48-4539-bbf3-3464e99c50c3",
                RoleARN = "arn:aws:iam::012345678910:role/ApplicationAutoscalingSpotRole",
                ScalableDimension = "ec2:spot-fleet-request:TargetCapacity",
                ServiceNamespace = "ec2"
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