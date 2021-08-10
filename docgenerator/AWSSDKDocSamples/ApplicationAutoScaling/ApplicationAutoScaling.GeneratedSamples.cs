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
        public void ApplicationAutoScalingDeleteScalingPolicy()
        {
            #region to-delete-a-scaling-policy-1470863892689

            var client = new AmazonApplicationAutoScalingClient();
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

            var client = new AmazonApplicationAutoScalingClient();
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

            var client = new AmazonApplicationAutoScalingClient();
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

            var client = new AmazonApplicationAutoScalingClient();
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

            var client = new AmazonApplicationAutoScalingClient();
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
            #region to-apply-a-target-tracking-scaling-policy-with-a-predefined-metric-specification-1569364247984

            var client = new AmazonApplicationAutoScalingClient();
            var response = client.PutScalingPolicy(new PutScalingPolicyRequest 
            {
                PolicyName = "cpu75-target-tracking-scaling-policy",
                PolicyType = "TargetTrackingScaling",
                ResourceId = "service/default/web-app",
                ScalableDimension = "ecs:service:DesiredCount",
                ServiceNamespace = "ecs",
                TargetTrackingScalingPolicyConfiguration = new TargetTrackingScalingPolicyConfiguration {
                    PredefinedMetricSpecification = new PredefinedMetricSpecification { PredefinedMetricType = "ECSServiceAverageCPUUtilization" },
                    ScaleInCooldown = 60,
                    ScaleOutCooldown = 60,
                    TargetValue = 75
                }
            });

            List<Alarm> alarms = response.Alarms;
            string policyARN = response.PolicyARN;

            #endregion
        }

        public void ApplicationAutoScalingRegisterScalableTarget()
        {
            #region to-register-a-new-scalable-target-1470864910380

            var client = new AmazonApplicationAutoScalingClient();
            var response = client.RegisterScalableTarget(new RegisterScalableTargetRequest 
            {
                MaxCapacity = 10,
                MinCapacity = 1,
                ResourceId = "service/default/web-app",
                ScalableDimension = "ecs:service:DesiredCount",
                ServiceNamespace = "ecs"
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