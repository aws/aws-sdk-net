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

        public void ApplicationAutoScalingDeleteScheduledAction()
        {
            #region to-delete-a-scheduled-action-1677963329606

            var client = new AmazonApplicationAutoScalingClient();
            var response = client.DeleteScheduledAction(new DeleteScheduledActionRequest 
            {
                ResourceId = "fleet/sample-fleet",
                ScalableDimension = "appstream:fleet:DesiredCapacity",
                ScheduledActionName = "my-recurring-action",
                ServiceNamespace = "appstream"
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

        public void ApplicationAutoScalingDescribeScheduledActions()
        {
            #region to-describe-scheduled-actions-1677965249349

            var client = new AmazonApplicationAutoScalingClient();
            var response = client.DescribeScheduledActions(new DescribeScheduledActionsRequest 
            {
                ServiceNamespace = "dynamodb"
            });

            List<ScheduledAction> scheduledActions = response.ScheduledActions;

            #endregion
        }

        public void ApplicationAutoScalingListTagsForResource()
        {
            #region to-list-tags-for-a-scalable-target-1677971474903

            var client = new AmazonApplicationAutoScalingClient();
            var response = client.ListTagsForResource(new ListTagsForResourceRequest 
            {
                ResourceARN = "arn:aws:application-autoscaling:us-west-2:123456789012:scalable-target/1234abcd56ab78cd901ef1234567890ab123"
            });

            Dictionary<string, string> tags = response.Tags;

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

        public void ApplicationAutoScalingPutScheduledAction()
        {
            #region to-create-a-recurring-scheduled-action-1677970068621

            var client = new AmazonApplicationAutoScalingClient();
            var response = client.PutScheduledAction(new PutScheduledActionRequest 
            {
                ResourceId = "table/TestTable",
                ScalableDimension = "dynamodb:table:WriteCapacityUnits",
                ScalableTargetAction = new ScalableTargetAction { MinCapacity = 6 },
                Schedule = "cron(15 12 * * ? *)",
                ScheduledActionName = "my-recurring-action",
                ServiceNamespace = "dynamodb"
            });


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

        public void ApplicationAutoScalingTagResource()
        {
            #region to-add-a-tag-to-a-scalable-target-1677970764620

            var client = new AmazonApplicationAutoScalingClient();
            var response = client.TagResource(new TagResourceRequest 
            {
                ResourceARN = "arn:aws:application-autoscaling:us-west-2:123456789012:scalable-target/1234abcd56ab78cd901ef1234567890ab123",
                Tags = new Dictionary<string, string> {
                    { "environment", "production" }
                }
            });


            #endregion
        }

        public void ApplicationAutoScalingUntagResource()
        {
            #region to-remove-a-tag-from-a-scalable-target-1677971117168

            var client = new AmazonApplicationAutoScalingClient();
            var response = client.UntagResource(new UntagResourceRequest 
            {
                ResourceARN = "arn:aws:application-autoscaling:us-west-2:123456789012:scalable-target/1234abcd56ab78cd901ef1234567890ab123",
                TagKeys = new List<string> {
                    "environment"
                }
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