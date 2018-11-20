/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the autoscaling-plans-2018-01-06.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.AutoScalingPlans.Model
{
    /// <summary>
    /// Describes a scaling instruction for a scalable resource.
    /// 
    ///  
    /// <para>
    /// The scaling instruction is used in combination with a scaling plan, which is a set
    /// of instructions for configuring dynamic scaling and predictive scaling for the scalable
    /// resources in your application. Each scaling instruction applies to one resource.
    /// </para>
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
    ///  
    /// <para>
    /// For more information, see the <a href="http://docs.aws.amazon.com/autoscaling/plans/userguide/what-is-aws-auto-scaling.html">AWS
    /// Auto Scaling User Guide</a>.
    /// </para>
    /// </summary>
    public partial class ScalingInstruction
    {
        private CustomizedLoadMetricSpecification _customizedLoadMetricSpecification;
        private bool? _disableDynamicScaling;
        private int? _maxCapacity;
        private int? _minCapacity;
        private PredefinedLoadMetricSpecification _predefinedLoadMetricSpecification;
        private PredictiveScalingMaxCapacityBehavior _predictiveScalingMaxCapacityBehavior;
        private int? _predictiveScalingMaxCapacityBuffer;
        private PredictiveScalingMode _predictiveScalingMode;
        private string _resourceId;
        private ScalableDimension _scalableDimension;
        private ScalingPolicyUpdateBehavior _scalingPolicyUpdateBehavior;
        private int? _scheduledActionBufferTime;
        private ServiceNamespace _serviceNamespace;
        private List<TargetTrackingConfiguration> _targetTrackingConfigurations = new List<TargetTrackingConfiguration>();

        /// <summary>
        /// Gets and sets the property CustomizedLoadMetricSpecification. 
        /// <para>
        /// The customized load metric to use for predictive scaling. This parameter or a <b>PredefinedLoadMetricSpecification</b>
        /// is required when configuring predictive scaling, and cannot be used otherwise. 
        /// </para>
        /// </summary>
        public CustomizedLoadMetricSpecification CustomizedLoadMetricSpecification
        {
            get { return this._customizedLoadMetricSpecification; }
            set { this._customizedLoadMetricSpecification = value; }
        }

        // Check to see if CustomizedLoadMetricSpecification property is set
        internal bool IsSetCustomizedLoadMetricSpecification()
        {
            return this._customizedLoadMetricSpecification != null;
        }

        /// <summary>
        /// Gets and sets the property DisableDynamicScaling. 
        /// <para>
        /// Controls whether dynamic scaling by AWS Auto Scaling is disabled. When dynamic scaling
        /// is enabled, AWS Auto Scaling creates target tracking scaling policies based on the
        /// specified target tracking configurations. 
        /// </para>
        ///  
        /// <para>
        /// The default is enabled (<code>false</code>). 
        /// </para>
        /// </summary>
        public bool DisableDynamicScaling
        {
            get { return this._disableDynamicScaling.GetValueOrDefault(); }
            set { this._disableDynamicScaling = value; }
        }

        // Check to see if DisableDynamicScaling property is set
        internal bool IsSetDisableDynamicScaling()
        {
            return this._disableDynamicScaling.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaxCapacity. 
        /// <para>
        /// The maximum capacity of the resource. The exception to this upper limit is if you
        /// specify a non-default setting for <b>PredictiveScalingMaxCapacityBehavior</b>. 
        /// </para>
        /// </summary>
        public int MaxCapacity
        {
            get { return this._maxCapacity.GetValueOrDefault(); }
            set { this._maxCapacity = value; }
        }

        // Check to see if MaxCapacity property is set
        internal bool IsSetMaxCapacity()
        {
            return this._maxCapacity.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MinCapacity. 
        /// <para>
        /// The minimum capacity of the resource. 
        /// </para>
        /// </summary>
        public int MinCapacity
        {
            get { return this._minCapacity.GetValueOrDefault(); }
            set { this._minCapacity = value; }
        }

        // Check to see if MinCapacity property is set
        internal bool IsSetMinCapacity()
        {
            return this._minCapacity.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PredefinedLoadMetricSpecification. 
        /// <para>
        /// The predefined load metric to use for predictive scaling. This parameter or a <b>CustomizedLoadMetricSpecification</b>
        /// is required when configuring predictive scaling, and cannot be used otherwise. 
        /// </para>
        /// </summary>
        public PredefinedLoadMetricSpecification PredefinedLoadMetricSpecification
        {
            get { return this._predefinedLoadMetricSpecification; }
            set { this._predefinedLoadMetricSpecification = value; }
        }

        // Check to see if PredefinedLoadMetricSpecification property is set
        internal bool IsSetPredefinedLoadMetricSpecification()
        {
            return this._predefinedLoadMetricSpecification != null;
        }

        /// <summary>
        /// Gets and sets the property PredictiveScalingMaxCapacityBehavior. 
        /// <para>
        /// Defines the behavior that should be applied if the forecast capacity approaches or
        /// exceeds the maximum capacity specified for the resource. The default value is <code>SetForecastCapacityToMaxCapacity</code>.
        /// </para>
        ///  
        /// <para>
        /// The following are possible values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>SetForecastCapacityToMaxCapacity</code> - AWS Auto Scaling cannot scale resource
        /// capacity higher than the maximum capacity. The maximum capacity is enforced as a hard
        /// limit. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>SetMaxCapacityToForecastCapacity</code> - AWS Auto Scaling may scale resource
        /// capacity higher than the maximum capacity to equal but not exceed forecast capacity.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>SetMaxCapacityAboveForecastCapacity</code> - AWS Auto Scaling may scale resource
        /// capacity higher than the maximum capacity by a specified buffer value. The intention
        /// is to give the target tracking scaling policy extra capacity if unexpected traffic
        /// occurs. 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Only valid when configuring predictive scaling.
        /// </para>
        /// </summary>
        public PredictiveScalingMaxCapacityBehavior PredictiveScalingMaxCapacityBehavior
        {
            get { return this._predictiveScalingMaxCapacityBehavior; }
            set { this._predictiveScalingMaxCapacityBehavior = value; }
        }

        // Check to see if PredictiveScalingMaxCapacityBehavior property is set
        internal bool IsSetPredictiveScalingMaxCapacityBehavior()
        {
            return this._predictiveScalingMaxCapacityBehavior != null;
        }

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
        /// is set to <code>SetMaxCapacityAboveForecastCapacity</code>, and cannot be used otherwise.
        /// </para>
        ///  
        /// <para>
        /// The range is 1-100.
        /// </para>
        /// </summary>
        public int PredictiveScalingMaxCapacityBuffer
        {
            get { return this._predictiveScalingMaxCapacityBuffer.GetValueOrDefault(); }
            set { this._predictiveScalingMaxCapacityBuffer = value; }
        }

        // Check to see if PredictiveScalingMaxCapacityBuffer property is set
        internal bool IsSetPredictiveScalingMaxCapacityBuffer()
        {
            return this._predictiveScalingMaxCapacityBuffer.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PredictiveScalingMode. 
        /// <para>
        /// The predictive scaling mode. The default value is <code>ForecastAndScale</code>. Otherwise,
        /// AWS Auto Scaling forecasts capacity but does not create any scheduled scaling actions
        /// based on the capacity forecast. 
        /// </para>
        /// </summary>
        public PredictiveScalingMode PredictiveScalingMode
        {
            get { return this._predictiveScalingMode; }
            set { this._predictiveScalingMode = value; }
        }

        // Check to see if PredictiveScalingMode property is set
        internal bool IsSetPredictiveScalingMode()
        {
            return this._predictiveScalingMode != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceId. 
        /// <para>
        /// The ID of the resource. This string consists of the resource type and unique identifier.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Auto Scaling group - The resource type is <code>autoScalingGroup</code> and the unique
        /// identifier is the name of the Auto Scaling group. Example: <code>autoScalingGroup/my-asg</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ECS service - The resource type is <code>service</code> and the unique identifier
        /// is the cluster name and service name. Example: <code>service/default/sample-webapp</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Spot Fleet request - The resource type is <code>spot-fleet-request</code> and the
        /// unique identifier is the Spot Fleet request ID. Example: <code>spot-fleet-request/sfr-73fbd2ce-aa30-494c-8788-1cee4EXAMPLE</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// DynamoDB table - The resource type is <code>table</code> and the unique identifier
        /// is the resource ID. Example: <code>table/my-table</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// DynamoDB global secondary index - The resource type is <code>index</code> and the
        /// unique identifier is the resource ID. Example: <code>table/my-table/index/my-table-index</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Aurora DB cluster - The resource type is <code>cluster</code> and the unique identifier
        /// is the cluster name. Example: <code>cluster:my-db-cluster</code>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string ResourceId
        {
            get { return this._resourceId; }
            set { this._resourceId = value; }
        }

        // Check to see if ResourceId property is set
        internal bool IsSetResourceId()
        {
            return this._resourceId != null;
        }

        /// <summary>
        /// Gets and sets the property ScalableDimension. 
        /// <para>
        /// The scalable dimension associated with the resource.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>autoscaling:autoScalingGroup:DesiredCapacity</code> - The desired capacity
        /// of an Auto Scaling group.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>ecs:service:DesiredCount</code> - The desired task count of an ECS service.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>ec2:spot-fleet-request:TargetCapacity</code> - The target capacity of a Spot
        /// Fleet request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>dynamodb:table:ReadCapacityUnits</code> - The provisioned read capacity for
        /// a DynamoDB table.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>dynamodb:table:WriteCapacityUnits</code> - The provisioned write capacity for
        /// a DynamoDB table.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>dynamodb:index:ReadCapacityUnits</code> - The provisioned read capacity for
        /// a DynamoDB global secondary index.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>dynamodb:index:WriteCapacityUnits</code> - The provisioned write capacity for
        /// a DynamoDB global secondary index.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>rds:cluster:ReadReplicaCount</code> - The count of Aurora Replicas in an Aurora
        /// DB cluster. Available for Aurora MySQL-compatible edition.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public ScalableDimension ScalableDimension
        {
            get { return this._scalableDimension; }
            set { this._scalableDimension = value; }
        }

        // Check to see if ScalableDimension property is set
        internal bool IsSetScalableDimension()
        {
            return this._scalableDimension != null;
        }

        /// <summary>
        /// Gets and sets the property ScalingPolicyUpdateBehavior. 
        /// <para>
        /// Controls whether a resource's externally created scaling policies are kept or replaced.
        /// 
        /// </para>
        ///  
        /// <para>
        /// The default value is <code>KeepExternalPolicies</code>. If the parameter is set to
        /// <code>ReplaceExternalPolicies</code>, any scaling policies that are external to AWS
        /// Auto Scaling are deleted and new target tracking scaling policies created. 
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
        public ScalingPolicyUpdateBehavior ScalingPolicyUpdateBehavior
        {
            get { return this._scalingPolicyUpdateBehavior; }
            set { this._scalingPolicyUpdateBehavior = value; }
        }

        // Check to see if ScalingPolicyUpdateBehavior property is set
        internal bool IsSetScalingPolicyUpdateBehavior()
        {
            return this._scalingPolicyUpdateBehavior != null;
        }

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
        public int ScheduledActionBufferTime
        {
            get { return this._scheduledActionBufferTime.GetValueOrDefault(); }
            set { this._scheduledActionBufferTime = value; }
        }

        // Check to see if ScheduledActionBufferTime property is set
        internal bool IsSetScheduledActionBufferTime()
        {
            return this._scheduledActionBufferTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ServiceNamespace. 
        /// <para>
        /// The namespace of the AWS service.
        /// </para>
        /// </summary>
        public ServiceNamespace ServiceNamespace
        {
            get { return this._serviceNamespace; }
            set { this._serviceNamespace = value; }
        }

        // Check to see if ServiceNamespace property is set
        internal bool IsSetServiceNamespace()
        {
            return this._serviceNamespace != null;
        }

        /// <summary>
        /// Gets and sets the property TargetTrackingConfigurations. 
        /// <para>
        /// The structure that defines new target tracking configurations (up to 10). Each of
        /// these structures includes a specific scaling metric and a target value for the metric,
        /// along with various parameters to use with dynamic scaling. 
        /// </para>
        ///  
        /// <para>
        /// With predictive scaling and dynamic scaling, the resource scales based on the target
        /// tracking configuration that provides the largest capacity for both scale in and scale
        /// out. 
        /// </para>
        ///  
        /// <para>
        /// Condition: The scaling metric must be unique across target tracking configurations.
        /// </para>
        /// </summary>
        public List<TargetTrackingConfiguration> TargetTrackingConfigurations
        {
            get { return this._targetTrackingConfigurations; }
            set { this._targetTrackingConfigurations = value; }
        }

        // Check to see if TargetTrackingConfigurations property is set
        internal bool IsSetTargetTrackingConfigurations()
        {
            return this._targetTrackingConfigurations != null && this._targetTrackingConfigurations.Count > 0; 
        }

    }
}