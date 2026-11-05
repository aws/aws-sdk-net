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
    /// Describes information used to specify a lifecycle hook for an Auto Scaling group.
    /// 
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/lifecycle-hooks.html">Amazon
    /// EC2 Auto Scaling lifecycle hooks</a> in the <i>Amazon EC2 Auto Scaling User Guide</i>.
    /// </para>
    /// </summary>
    public partial class LifecycleHookSpecification
    {
        /// <summary>
        /// Gets and sets the property DefaultResult. 
        /// <para>
        /// The action the Auto Scaling group takes when the lifecycle hook timeout elapses or
        /// if an unexpected failure occurs. The default value is <c>ABANDON</c>.
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
        /// Gets and sets the property HeartbeatTimeout. 
        /// <para>
        /// The maximum time, in seconds, that can elapse before the lifecycle hook times out.
        /// The range is from <c>30</c> to <c>7200</c> seconds. The default value is <c>3600</c>
        /// seconds (1 hour).
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
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string LifecycleHookName { get; set; }

        /// <summary>
        /// Checks to see if the LifecycleHookName property is set.
        /// </summary>
        internal bool IsSetLifecycleHookName() => this.LifecycleHookName != null;

        /// <summary>
        /// Gets and sets the property LifecycleTransition. 
        /// <para>
        /// The lifecycle transition. For Auto Scaling groups, there are two major lifecycle transitions.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// To create a lifecycle hook for scale-out events, specify <c>autoscaling:EC2_INSTANCE_LAUNCHING</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To create a lifecycle hook for scale-in events, specify <c>autoscaling:EC2_INSTANCE_TERMINATING</c>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required = true)]
        public string LifecycleTransition { get; set; }

        /// <summary>
        /// Checks to see if the LifecycleTransition property is set.
        /// </summary>
        internal bool IsSetLifecycleTransition() => this.LifecycleTransition != null;

        /// <summary>
        /// Gets and sets the property NotificationMetadata. 
        /// <para>
        /// Additional information that you want to include any time Amazon EC2 Auto Scaling sends
        /// a message to the notification target.
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
        /// The Amazon Resource Name (ARN) of the notification target that Amazon EC2 Auto Scaling
        /// sends notifications to when an instance is in a wait state for the lifecycle hook.
        /// You can specify an Amazon SNS topic or an Amazon SQS queue.
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
        /// notification target. For information about creating this role, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/prepare-for-lifecycle-notifications.html">Prepare
        /// to add a lifecycle hook to your Auto Scaling group</a> in the <i>Amazon EC2 Auto Scaling
        /// User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// Valid only if the notification target is an Amazon SNS topic or an Amazon SQS queue.
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
