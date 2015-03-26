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
 * Do not modify this file. This file is generated from the autoscaling-2011-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.AutoScaling.Model
{
    /// <summary>
    /// Container for the parameters to the PutLifecycleHook operation.
    /// Creates or updates a lifecycle hook for the specified Auto Scaling Group.
    /// 
    ///  
    /// <para>
    /// A lifecycle hook tells Auto Scaling that you want to perform an action on an instance
    /// that is not actively in service; for example, either when the instance launches or
    /// before the instance terminates.
    /// </para>
    ///  
    /// <para>
    /// This operation is a part of the basic sequence for adding a lifecycle hook to an Auto
    /// Scaling group:
    /// </para>
    ///  <ol> <li>Create a notification target. A target can be either an Amazon SQS queue
    /// or an Amazon SNS topic.</li> <li>Create an IAM role. This role allows Auto Scaling
    /// to publish lifecycle notifications to the designated SQS queue or SNS topic.</li>
    /// <li><b>Create the lifecycle hook. You can create a hook that acts when instances launch
    /// or when instances terminate.</b></li> <li>If necessary, record the lifecycle action
    /// heartbeat to keep the instance in a pending state.</li> <li>Complete the lifecycle
    /// action.</li> </ol> 
    /// <para>
    /// For more information, see <a href="http://docs.aws.amazon.com/AutoScaling/latest/DeveloperGuide/AutoScalingPendingState.html">Auto
    /// Scaling Pending State</a> and <a href="http://docs.aws.amazon.com/AutoScaling/latest/DeveloperGuide/AutoScalingTerminatingState.html">Auto
    /// Scaling Terminating State</a> in the <i>Auto Scaling Developer Guide</i>.
    /// </para>
    /// </summary>
    public partial class PutLifecycleHookRequest : AmazonAutoScalingRequest
    {
        private string _autoScalingGroupName;
        private string _defaultResult;
        private int? _heartbeatTimeout;
        private string _lifecycleHookName;
        private string _lifecycleTransition;
        private string _notificationMetadata;
        private string _notificationTargetARN;
        private string _roleARN;

        /// <summary>
        /// Gets and sets the property AutoScalingGroupName. 
        /// <para>
        /// The name of the Auto Scaling group to which you want to assign the lifecycle hook.
        /// </para>
        /// </summary>
        public string AutoScalingGroupName
        {
            get { return this._autoScalingGroupName; }
            set { this._autoScalingGroupName = value; }
        }

        // Check to see if AutoScalingGroupName property is set
        internal bool IsSetAutoScalingGroupName()
        {
            return this._autoScalingGroupName != null;
        }

        /// <summary>
        /// Gets and sets the property DefaultResult. 
        /// <para>
        /// Defines the action the Auto Scaling group should take when the lifecycle hook timeout
        /// elapses or if an unexpected failure occurs. The value for this parameter can be either
        /// <code>CONTINUE</code> or <code>ABANDON</code>. The default value for this parameter
        /// is <code>ABANDON</code>.
        /// </para>
        /// </summary>
        public string DefaultResult
        {
            get { return this._defaultResult; }
            set { this._defaultResult = value; }
        }

        // Check to see if DefaultResult property is set
        internal bool IsSetDefaultResult()
        {
            return this._defaultResult != null;
        }

        /// <summary>
        /// Gets and sets the property HeartbeatTimeout. 
        /// <para>
        /// Defines the amount of time, in seconds, that can elapse before the lifecycle hook
        /// times out. When the lifecycle hook times out, Auto Scaling performs the action defined
        /// in the <code>DefaultResult</code> parameter. You can prevent the lifecycle hook from
        /// timing out by calling <a>RecordLifecycleActionHeartbeat</a>. The default value for
        /// this parameter is 3600 seconds (1 hour).
        /// </para>
        /// </summary>
        public int HeartbeatTimeout
        {
            get { return this._heartbeatTimeout.GetValueOrDefault(); }
            set { this._heartbeatTimeout = value; }
        }

        // Check to see if HeartbeatTimeout property is set
        internal bool IsSetHeartbeatTimeout()
        {
            return this._heartbeatTimeout.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LifecycleHookName. 
        /// <para>
        /// The name of the lifecycle hook.
        /// </para>
        /// </summary>
        public string LifecycleHookName
        {
            get { return this._lifecycleHookName; }
            set { this._lifecycleHookName = value; }
        }

        // Check to see if LifecycleHookName property is set
        internal bool IsSetLifecycleHookName()
        {
            return this._lifecycleHookName != null;
        }

        /// <summary>
        /// Gets and sets the property LifecycleTransition. 
        /// <para>
        /// The Amazon EC2 instance state to which you want to attach the lifecycle hook. See
        /// <a>DescribeLifecycleHookTypes</a> for a list of available lifecycle hook types.
        /// </para>
        ///  <note> 
        /// <para>
        /// This parameter is required for new lifecycle hooks, but optional when updating existing
        /// hooks.
        /// </para>
        ///  </note>
        /// </summary>
        public string LifecycleTransition
        {
            get { return this._lifecycleTransition; }
            set { this._lifecycleTransition = value; }
        }

        // Check to see if LifecycleTransition property is set
        internal bool IsSetLifecycleTransition()
        {
            return this._lifecycleTransition != null;
        }

        /// <summary>
        /// Gets and sets the property NotificationMetadata. 
        /// <para>
        /// Contains additional information that you want to include any time Auto Scaling sends
        /// a message to the notification target.
        /// </para>
        /// </summary>
        public string NotificationMetadata
        {
            get { return this._notificationMetadata; }
            set { this._notificationMetadata = value; }
        }

        // Check to see if NotificationMetadata property is set
        internal bool IsSetNotificationMetadata()
        {
            return this._notificationMetadata != null;
        }

        /// <summary>
        /// Gets and sets the property NotificationTargetARN. 
        /// <para>
        /// The ARN of the notification target that Auto Scaling will use to notify you when an
        /// instance is in the transition state for the lifecycle hook. This ARN target can be
        /// either an SQS queue or an SNS topic. 
        /// </para>
        ///  <note> 
        /// <para>
        /// This parameter is required for new lifecycle hooks, but optional when updating existing
        /// hooks.
        /// </para>
        ///  </note> 
        /// <para>
        /// The notification message sent to the target will include:
        /// </para>
        ///  <ul> <li> <b>LifecycleActionToken</b>. The Lifecycle action token.</li> <li> <b>AccountId</b>.
        /// The user account ID.</li> <li> <b>AutoScalingGroupName</b>. The name of the Auto Scaling
        /// group.</li> <li> <b>LifecycleHookName</b>. The lifecycle hook name.</li> <li> <b>EC2InstanceId</b>.
        /// The EC2 instance ID.</li> <li> <b>LifecycleTransition</b>. The lifecycle transition.</li>
        /// <li> <b>NotificationMetadata</b>. The notification metadata.</li> </ul> 
        /// <para>
        /// This operation uses the JSON format when sending notifications to an Amazon SQS queue,
        /// and an email key/value pair format when sending notifications to an Amazon SNS topic.
        /// </para>
        ///  
        /// <para>
        /// When you call this operation, a test message is sent to the notification target. This
        /// test message contains an additional key/value pair: <code>Event:autoscaling:TEST_NOTIFICATION</code>.
        /// </para>
        /// </summary>
        public string NotificationTargetARN
        {
            get { return this._notificationTargetARN; }
            set { this._notificationTargetARN = value; }
        }

        // Check to see if NotificationTargetARN property is set
        internal bool IsSetNotificationTargetARN()
        {
            return this._notificationTargetARN != null;
        }

        /// <summary>
        /// Gets and sets the property RoleARN. 
        /// <para>
        /// The ARN of the IAM role that allows the Auto Scaling group to publish to the specified
        /// notification target.
        /// </para>
        ///  <note> 
        /// <para>
        /// This parameter is required for new lifecycle hooks, but optional when updating existing
        /// hooks.
        /// </para>
        ///  </note>
        /// </summary>
        public string RoleARN
        {
            get { return this._roleARN; }
            set { this._roleARN = value; }
        }

        // Check to see if RoleARN property is set
        internal bool IsSetRoleARN()
        {
            return this._roleARN != null;
        }

    }
}