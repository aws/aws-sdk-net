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
 * Do not modify this file. This file is generated from the ecs-2014-11-13.normal.json service model.
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
namespace Amazon.ECS.Model
{
    /// <summary>
    /// The Application Auto Scaling policy created by Amazon ECS when you create an Express
    /// service.
    /// </summary>
    public partial class ManagedApplicationAutoScalingPolicy
    {
        private string _arn;
        private string _metric;
        private string _policyType;
        private ManagedResourceStatus _status;
        private string _statusReason;
        private double? _targetValue;
        private DateTime? _updatedAt;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Application Auto Scaling policy associated with
        /// the Express service.
        /// </para>
        /// </summary>
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property Metric. 
        /// <para>
        /// The metric used for auto scaling decisions. The available metrics are <c>ECSServiceAverageCPUUtilization</c>,
        /// <c>ECSServiceAverageMemoryUtilization</c>, and <c>ALBRequestCOuntPerTarget</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Metric
        {
            get { return this._metric; }
            set { this._metric = value; }
        }

        // Check to see if Metric property is set
        internal bool IsSetMetric()
        {
            return this._metric != null;
        }

        /// <summary>
        /// Gets and sets the property PolicyType. 
        /// <para>
        /// The type of Application Auto Scaling policy associated with the Express service. Valid
        /// values are <c>TargetTrackingScaling</c>, <c>StepScaling</c>, and <c>PredictiveScaling</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string PolicyType
        {
            get { return this._policyType; }
            set { this._policyType = value; }
        }

        // Check to see if PolicyType property is set
        internal bool IsSetPolicyType()
        {
            return this._policyType != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of Application Auto Scaling policy creation.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ManagedResourceStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property StatusReason. 
        /// <para>
        /// Information about why the Application Auto Scaling policy is in the current status.
        /// </para>
        /// </summary>
        public string StatusReason
        {
            get { return this._statusReason; }
            set { this._statusReason = value; }
        }

        // Check to see if StatusReason property is set
        internal bool IsSetStatusReason()
        {
            return this._statusReason != null;
        }

        /// <summary>
        /// Gets and sets the property TargetValue. 
        /// <para>
        /// The target value for the auto scaling metric.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public double TargetValue
        {
            get { return this._targetValue.GetValueOrDefault(); }
            set { this._targetValue = value; }
        }

        // Check to see if TargetValue property is set
        internal bool IsSetTargetValue()
        {
            return this._targetValue.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The Unix timestamp for when the Application Auto Scaling policy was last updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime UpdatedAt
        {
            get { return this._updatedAt.GetValueOrDefault(); }
            set { this._updatedAt = value; }
        }

        // Check to see if UpdatedAt property is set
        internal bool IsSetUpdatedAt()
        {
            return this._updatedAt.HasValue; 
        }

    }
}