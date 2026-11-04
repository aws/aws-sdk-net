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

namespace Amazon.AutoScaling.Model
{
    /// <summary>
    /// Describes a lifecycle hook. A lifecycle hook lets you create solutions that are aware
    /// of events in the Auto Scaling instance lifecycle, and then perform a custom action
    /// on instances when the corresponding lifecycle event occurs.
    /// </summary>
    public partial class LifecycleHook
    {
        /// <summary>
        /// Gets and sets the property AutoScalingGroupName. 
        /// <para>
        /// The name of the Auto Scaling group for the lifecycle hook.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string AutoScalingGroupName { get; set; }

        /// <summary>
        /// Checks to see if the AutoScalingGroupName property is set.
        /// </summary>
        internal bool IsSetAutoScalingGroupName() => this.AutoScalingGroupName != null;

        /// <summary>
        /// Gets and sets the property DefaultResult. 
        /// <para>
        /// The action the Auto Scaling group takes when the lifecycle hook timeout elapses or
        /// if an unexpected failure occurs.
        /// </para>
        ///  
        /// <para>
        /// Valid values: <c>CONTINUE</c> | <c>ABANDON</c> 
        /// </para>
        /// </summary>
        public string DefaultResult { get; set; }

        /// <summary>
        /// Checks to see if the DefaultResult property is set.
        /// </summary>
        internal bool IsSetDefaultResult() => this.DefaultResult != null;

        /// <summary>
        /// Gets and sets the property GlobalTimeout. 
        /// <para>
        /// The maximum time, in seconds, that an instance can remain in a wait state. The maximum
        /// is 172800 seconds (48 hours) or 100 times <c>HeartbeatTimeout</c>, whichever is smaller.
        /// </para>
        /// </summary>
        public int? GlobalTimeout { get; set; }

        /// <summary>
        /// Checks to see if the GlobalTimeout property is set.
        /// </summary>
        internal bool IsSetGlobalTimeout() => this.GlobalTimeout.HasValue;

        /// <summary>
        /// Gets and sets the property HeartbeatTimeout. 
        /// <para>
        /// The maximum time, in seconds, that can elapse before the lifecycle hook times out.
        /// If the lifecycle hook times out, Amazon EC2 Auto Scaling performs the action that
        /// you specified in the <c>DefaultResult</c> property.
        /// </para>
        /// </summary>
        public int? HeartbeatTimeout { get; set; }

        /// <summary>
        /// Checks to see if the HeartbeatTimeout property is set.
        /// </summary>
        internal bool IsSetHeartbeatTimeout() => this.HeartbeatTimeout.HasValue;

        /// <summary>
        /// Gets and sets the property LifecycleHookName. 
        /// <para>
        /// The name of the lifecycle hook.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string LifecycleHookName { get; set; }

        /// <summary>
        /// Checks to see if the LifecycleHookName property is set.
        /// </summary>
        internal bool IsSetLifecycleHookName() => this.LifecycleHookName != null;

        /// <summary>
        /// Gets and sets the property LifecycleTransition. 
        /// <para>
        /// The lifecycle transition.
        /// </para>
        ///  
        /// <para>
        /// Valid values: <c>autoscaling:EC2_INSTANCE_LAUNCHING</c> | <c>autoscaling:EC2_INSTANCE_TERMINATING</c>
        /// 
        /// </para>
        /// </summary>
        public string LifecycleTransition { get; set; }

        /// <summary>
        /// Checks to see if the LifecycleTransition property is set.
        /// </summary>
        internal bool IsSetLifecycleTransition() => this.LifecycleTransition != null;

        /// <summary>
        /// Gets and sets the property NotificationMetadata. 
        /// <para>
        /// Additional information that is included any time Amazon EC2 Auto Scaling sends a message
        /// to the notification target.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 4000)]
        public string NotificationMetadata { get; set; }

        /// <summary>
        /// Checks to see if the NotificationMetadata property is set.
        /// </summary>
        internal bool IsSetNotificationMetadata() => this.NotificationMetadata != null;

        /// <summary>
        /// Gets and sets the property NotificationTargetARN. 
        /// <para>
        /// The ARN of the target that Amazon EC2 Auto Scaling sends notifications to when an
        /// instance is in a wait state for the lifecycle hook.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 255)]
        public string NotificationTargetARN { get; set; }

        /// <summary>
        /// Checks to see if the NotificationTargetARN property is set.
        /// </summary>
        internal bool IsSetNotificationTargetARN() => this.NotificationTargetARN != null;

        /// <summary>
        /// Gets and sets the property RoleARN. 
        /// <para>
        /// The ARN of the IAM role that allows the Auto Scaling group to publish to the specified
        /// notification target (an Amazon SNS topic or an Amazon SQS queue).
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string RoleARN { get; set; }

        /// <summary>
        /// Checks to see if the RoleARN property is set.
        /// </summary>
        internal bool IsSetRoleARN() => this.RoleARN != null;
    }
}
