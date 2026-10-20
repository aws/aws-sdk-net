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

namespace Amazon.ECS.Model
{
    /// <summary>
    /// The Application Auto Scaling policy created by Amazon ECS when you create an Express
    /// service.
    /// </summary>
    public partial class ManagedApplicationAutoScalingPolicy
    {
        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Application Auto Scaling policy associated with
        /// the Express service.
        /// </para>
        /// </summary>
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property Metric. 
        /// <para>
        /// The metric used for auto scaling decisions. The available metrics are <c>ECSServiceAverageCPUUtilization</c>,
        /// <c>ECSServiceAverageMemoryUtilization</c>, and <c>ALBRequestCOuntPerTarget</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Metric { get; set; }

        /// <summary>
        /// Checks to see if the Metric property is set.
        /// </summary>
        internal bool IsSetMetric() => this.Metric != null;

        /// <summary>
        /// Gets and sets the property PolicyType. 
        /// <para>
        /// The type of Application Auto Scaling policy associated with the Express service. Valid
        /// values are <c>TargetTrackingScaling</c>, <c>StepScaling</c>, and <c>PredictiveScaling</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string PolicyType { get; set; }

        /// <summary>
        /// Checks to see if the PolicyType property is set.
        /// </summary>
        internal bool IsSetPolicyType() => this.PolicyType != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of Application Auto Scaling policy creation.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ManagedResourceStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property StatusReason. 
        /// <para>
        /// Information about why the Application Auto Scaling policy is in the current status.
        /// </para>
        /// </summary>
        public string StatusReason { get; set; }

        /// <summary>
        /// Checks to see if the StatusReason property is set.
        /// </summary>
        internal bool IsSetStatusReason() => this.StatusReason != null;

        /// <summary>
        /// Gets and sets the property TargetValue. 
        /// <para>
        /// The target value for the auto scaling metric.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public double? TargetValue { get; set; }

        /// <summary>
        /// Checks to see if the TargetValue property is set.
        /// </summary>
        internal bool IsSetTargetValue() => this.TargetValue.HasValue;

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The Unix timestamp for when the Application Auto Scaling policy was last updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the UpdatedAt property is set.
        /// </summary>
        internal bool IsSetUpdatedAt() => this.UpdatedAt.HasValue;
    }
}
