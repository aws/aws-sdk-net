/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618,CS1570

namespace Amazon.AutoScalingPlans.Model
{
    /// <summary>
    /// Describes a scaling instruction for a scalable resource in a scaling plan. Each scaling
    /// instruction applies to one resource.
    /// 
    ///  
    /// <para>
    /// AWS Auto Scaling creates target tracking scaling policies based on the scaling instructions.
    /// Target tracking scaling policies adjust the capacity of your scalable resource as
    /// required to maintain resource utilization at the target value that you specified.
    /// 
    /// </para>
    ///  
    /// <para>
    /// AWS Auto Scaling also configures predictive scaling for your Amazon EC2 Auto Scaling
    /// groups using a subset of parameters, including the load metric, the scaling metric,
    /// the target value for the scaling metric, the predictive scaling mode (forecast and
    /// scale or forecast only), and the desired behavior when the forecast capacity exceeds
    /// the maximum capacity of the resource. With predictive scaling, AWS Auto Scaling generates
    /// forecasts with traffic predictions for the two days ahead and schedules scaling actions
    /// that proactively add and remove resource capacity to match the forecast. 
    /// </para>
    ///  <important> 
    /// <para>
    /// We recommend waiting a minimum of 24 hours after creating an Auto Scaling group to
    /// configure predictive scaling. At minimum, there must be 24 hours of historical data
    /// to generate a forecast. For more information, see <a href="https://docs.aws.amazon.com/autoscaling/plans/userguide/gs-best-practices.html">Best
    /// Practices for AWS Auto Scaling</a> in the <i>AWS Auto Scaling User Guide</i>.
    /// </para>
    ///  </important>
    /// </summary>
    public partial class ScalingInstruction
    {
        /// <summary>
        /// Gets and sets the property CustomizedLoadMetricSpecification. 
        /// <para>
        /// The customized load metric to use for predictive scaling. This parameter or a <b>PredefinedLoadMetricSpecification</b>
        /// is required when configuring predictive scaling, and cannot be used otherwise. 
        /// </para>
        /// </summary>
        public CustomizedLoadMetricSpecification CustomizedLoadMetricSpecification { get; set; }

        /// <summary>
        /// Checks to see if the CustomizedLoadMetricSpecification property is set.
        /// </summary>
        internal bool IsSetCustomizedLoadMetricSpecification() => this.CustomizedLoadMetricSpecification != null;

        /// <summary>
        /// Gets and sets the property DisableDynamicScaling. 
        /// <para>
        /// Controls whether dynamic scaling by AWS Auto Scaling is disabled. When dynamic scaling
        /// is enabled, AWS Auto Scaling creates target tracking scaling policies based on the
        /// specified target tracking configurations. 
        /// </para>
        ///  
        /// <para>
        /// The default is enabled (<c>false</c>). 
        /// </para>
        /// </summary>
        public bool? DisableDynamicScaling { get; set; }

        /// <summary>
        /// Checks to see if the DisableDynamicScaling property is set.
        /// </summary>
        internal bool IsSetDisableDynamicScaling() => this.DisableDynamicScaling.HasValue;

        /// <summary>
        /// Gets and sets the property MaxCapacity. 
        /// <para>
        /// The maximum capacity of the resource. The exception to this upper limit is if you
        /// specify a non-default setting for <b>PredictiveScalingMaxCapacityBehavior</b>. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public int? MaxCapacity { get; set; }

        /// <summary>
        /// Checks to see if the MaxCapacity property is set.
        /// </summary>
        internal bool IsSetMaxCapacity() => this.MaxCapacity.HasValue;

        /// <summary>
        /// Gets and sets the property MinCapacity. 
        /// <para>
        /// The minimum capacity of the resource. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public int? MinCapacity { get; set; }

        /// <summary>
        /// Checks to see if the MinCapacity property is set.
        /// </summary>
        internal bool IsSetMinCapacity() => this.MinCapacity.HasValue;

        /// <summary>
        /// Gets and sets the property PredefinedLoadMetricSpecification. 
        /// <para>
        /// The predefined load metric to use for predictive scaling. This parameter or a <b>CustomizedLoadMetricSpecification</b>
        /// is required when configuring predictive scaling, and cannot be used otherwise. 
        /// </para>
        /// </summary>
        public PredefinedLoadMetricSpecification PredefinedLoadMetricSpecification { get; set; }

        /// <summary>
        /// Checks to see if the PredefinedLoadMetricSpecification property is set.
        /// </summary>
        internal bool IsSetPredefinedLoadMetricSpecification() => this.PredefinedLoadMetricSpecification != null;

        /// <summary>
        /// Gets and sets the property PredictiveScalingMaxCapacityBehavior. 
        /// <para>
        /// Defines the behavior that should be applied if the forecast capacity approaches or
        /// exceeds the maximum capacity specified for the resource. The default value is <c>SetForecastCapacityToMaxCapacity</c>.
        /// </para>
        ///  
        /// <para>
        /// The following are possible values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>SetForecastCapacityToMaxCapacity</c> - AWS Auto Scaling cannot scale resource
        /// capacity higher than the maximum capacity. The maximum capacity is enforced as a hard
        /// limit. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>SetMaxCapacityToForecastCapacity</c> - AWS Auto Scaling may scale resource capacity
        /// higher than the maximum capacity to equal but not exceed forecast capacity.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>SetMaxCapacityAboveForecastCapacity</c> - AWS Auto Scaling may scale resource
        /// capacity higher than the maximum capacity by a specified buffer value. The intention
        /// is to give the target tracking scaling policy extra capacity if unexpected traffic
        /// occurs. 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Only valid when configuring predictive scaling.
        /// </para>
        /// </summary>
        public PredictiveScalingMaxCapacityBehavior PredictiveScalingMaxCapacityBehavior { get; set; }

        /// <summary>
        /// Checks to see if the PredictiveScalingMaxCapacityBehavior property is set.
        /// </summary>
        internal bool IsSetPredictiveScalingMaxCapacityBehavior() => this.PredictiveScalingMaxCapacityBehavior != null;

        /// <summary>
        /// Gets and sets the property PredictiveScalingMaxCapacityBuffer. 
        /// <para>
        /// The size of the capacity buffer to use when the forecast capacity is close to or exceeds
        /// the maximum capacity. The value is specified as a percentage relative to the forecast
        /// capacity. For example, if the buffer is 10, this means a 10 percent buffer, such that
        /// if the forecast capacity is 50, and the maximum capacity is 40, then the effective
        /// maximum capacity is 55.
        /// </para>
        ///  
        /// <para>
        /// Only valid when configuring predictive scaling. Required if the <b>PredictiveScalingMaxCapacityBehavior</b>
        /// is set to <c>SetMaxCapacityAboveForecastCapacity</c>, and cannot be used otherwise.
        /// </para>
        ///  
        /// <para>
        /// The range is 1-100.
        /// </para>
        /// </summary>
        public int? PredictiveScalingMaxCapacityBuffer { get; set; }

        /// <summary>
        /// Checks to see if the PredictiveScalingMaxCapacityBuffer property is set.
        /// </summary>
        internal bool IsSetPredictiveScalingMaxCapacityBuffer() => this.PredictiveScalingMaxCapacityBuffer.HasValue;

        /// <summary>
        /// Gets and sets the property PredictiveScalingMode. 
        /// <para>
        /// The predictive scaling mode. The default value is <c>ForecastAndScale</c>. Otherwise,
        /// AWS Auto Scaling forecasts capacity but does not create any scheduled scaling actions
        /// based on the capacity forecast. 
        /// </para>
        /// </summary>
        public PredictiveScalingMode PredictiveScalingMode { get; set; }

        /// <summary>
        /// Checks to see if the PredictiveScalingMode property is set.
        /// </summary>
        internal bool IsSetPredictiveScalingMode() => this.PredictiveScalingMode != null;

        /// <summary>
        /// Gets and sets the property ResourceId. 
        /// <para>
        /// The ID of the resource. This string consists of the resource type and unique identifier.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Auto Scaling group - The resource type is <c>autoScalingGroup</c> and the unique identifier
        /// is the name of the Auto Scaling group. Example: <c>autoScalingGroup/my-asg</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ECS service - The resource type is <c>service</c> and the unique identifier is the
        /// cluster name and service name. Example: <c>service/default/sample-webapp</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Spot Fleet request - The resource type is <c>spot-fleet-request</c> and the unique
        /// identifier is the Spot Fleet request ID. Example: <c>spot-fleet-request/sfr-73fbd2ce-aa30-494c-8788-1cee4EXAMPLE</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// DynamoDB table - The resource type is <c>table</c> and the unique identifier is the
        /// resource ID. Example: <c>table/my-table</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// DynamoDB global secondary index - The resource type is <c>index</c> and the unique
        /// identifier is the resource ID. Example: <c>table/my-table/index/my-table-index</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Aurora DB cluster - The resource type is <c>cluster</c> and the unique identifier
        /// is the cluster name. Example: <c>cluster:my-db-cluster</c>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 1600)]
        public string ResourceId { get; set; }

        /// <summary>
        /// Checks to see if the ResourceId property is set.
        /// </summary>
        internal bool IsSetResourceId() => this.ResourceId != null;

        /// <summary>
        /// Gets and sets the property ScalableDimension. 
        /// <para>
        /// The scalable dimension associated with the resource.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>autoscaling:autoScalingGroup:DesiredCapacity</c> - The desired capacity of an
        /// Auto Scaling group.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ecs:service:DesiredCount</c> - The desired task count of an ECS service.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ec2:spot-fleet-request:TargetCapacity</c> - The target capacity of a Spot Fleet
        /// request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>dynamodb:table:ReadCapacityUnits</c> - The provisioned read capacity for a DynamoDB
        /// table.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>dynamodb:table:WriteCapacityUnits</c> - The provisioned write capacity for a DynamoDB
        /// table.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>dynamodb:index:ReadCapacityUnits</c> - The provisioned read capacity for a DynamoDB
        /// global secondary index.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>dynamodb:index:WriteCapacityUnits</c> - The provisioned write capacity for a DynamoDB
        /// global secondary index.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>rds:cluster:ReadReplicaCount</c> - The count of Aurora Replicas in an Aurora DB
        /// cluster. Available for Aurora MySQL-compatible edition and Aurora PostgreSQL-compatible
        /// edition.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required = true)]
        public ScalableDimension ScalableDimension { get; set; }

        /// <summary>
        /// Checks to see if the ScalableDimension property is set.
        /// </summary>
        internal bool IsSetScalableDimension() => this.ScalableDimension != null;

        /// <summary>
        /// Gets and sets the property ScalingPolicyUpdateBehavior. 
        /// <para>
        /// Controls whether a resource's externally created scaling policies are kept or replaced.
        /// 
        /// </para>
        ///  
        /// <para>
        /// The default value is <c>KeepExternalPolicies</c>. If the parameter is set to <c>ReplaceExternalPolicies</c>,
        /// any scaling policies that are external to AWS Auto Scaling are deleted and new target
        /// tracking scaling policies created. 
        /// </para>
        ///  
        /// <para>
        /// Only valid when configuring dynamic scaling. 
        /// </para>
        ///  
        /// <para>
        /// Condition: The number of existing policies to be replaced must be less than or equal
        /// to 50. If there are more than 50 policies to be replaced, AWS Auto Scaling keeps all
        /// existing policies and does not create new ones.
        /// </para>
        /// </summary>
        public ScalingPolicyUpdateBehavior ScalingPolicyUpdateBehavior { get; set; }

        /// <summary>
        /// Checks to see if the ScalingPolicyUpdateBehavior property is set.
        /// </summary>
        internal bool IsSetScalingPolicyUpdateBehavior() => this.ScalingPolicyUpdateBehavior != null;

        /// <summary>
        /// Gets and sets the property ScheduledActionBufferTime. 
        /// <para>
        /// The amount of time, in seconds, to buffer the run time of scheduled scaling actions
        /// when scaling out. For example, if the forecast says to add capacity at 10:00 AM, and
        /// the buffer time is 5 minutes, then the run time of the corresponding scheduled scaling
        /// action will be 9:55 AM. The intention is to give resources time to be provisioned.
        /// For example, it can take a few minutes to launch an EC2 instance. The actual amount
        /// of time required depends on several factors, such as the size of the instance and
        /// whether there are startup scripts to complete. 
        /// </para>
        ///  
        /// <para>
        /// The value must be less than the forecast interval duration of 3600 seconds (60 minutes).
        /// The default is 300 seconds. 
        /// </para>
        ///  
        /// <para>
        /// Only valid when configuring predictive scaling. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public int? ScheduledActionBufferTime { get; set; }

        /// <summary>
        /// Checks to see if the ScheduledActionBufferTime property is set.
        /// </summary>
        internal bool IsSetScheduledActionBufferTime() => this.ScheduledActionBufferTime.HasValue;

        /// <summary>
        /// Gets and sets the property ServiceNamespace. 
        /// <para>
        /// The namespace of the AWS service.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ServiceNamespace ServiceNamespace { get; set; }

        /// <summary>
        /// Checks to see if the ServiceNamespace property is set.
        /// </summary>
        internal bool IsSetServiceNamespace() => this.ServiceNamespace != null;

        /// <summary>
        /// Gets and sets the property TargetTrackingConfigurations. 
        /// <para>
        /// The target tracking configurations (up to 10). Each of these structures must specify
        /// a unique scaling metric and a target value for the metric. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<TargetTrackingConfiguration> TargetTrackingConfigurations { get; set; } = AWSConfigs.InitializeCollections ? new List<TargetTrackingConfiguration>() : null;

        /// <summary>
        /// Checks to see if the TargetTrackingConfigurations property is set.
        /// </summary>
        internal bool IsSetTargetTrackingConfigurations() => this.TargetTrackingConfigurations != null && (this.TargetTrackingConfigurations.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
