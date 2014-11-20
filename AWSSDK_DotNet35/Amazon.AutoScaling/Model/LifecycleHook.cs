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
    /// Describes a lifecycle hook, which tells Auto Scaling that you want to perform an action
    /// when an instance launches or terminates. When you have a lifecycle hook in place,
    /// the Auto Scaling group will either:
    /// 
    ///  <ul> <li>Pause the instance after it launches, but before it is put into service</li>
    /// <li>Pause the instance as it terminates, but before it is fully terminated</li> </ul>
    /// 
    /// <para>
    /// For more information, see <a href="http://docs.aws.amazon.com/AutoScaling/latest/DeveloperGuide/AutoScalingPendingState.html">Auto
    /// Scaling Pending State</a> and <a href="http://docs.aws.amazon.com/AutoScaling/latest/DeveloperGuide/AutoScalingTerminatingState.html">Auto
    /// Scaling Terminating State</a> in the <i>Auto Scaling Developer Guide</i>.
    /// </para>
    /// </summary>
    public partial class LifecycleHook
    {
        private string _autoScalingGroupName;
        private string _defaultResult;
        private int? _globalTimeout;
        private int? _heartbeatTimeout;
        private string _lifecycleHookName;
        private string _lifecycleTransition;
        private string _notificationMetadata;
        private string _notificationTargetARN;
        private string _roleARN;

        /// <summary>
        /// Gets and sets the property AutoScalingGroupName. 
        /// <para>
        /// The name of the Auto Scaling group for the lifecycle hook.
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
        /// elapses or if an unexpected failure occurs. The valid values are <code>CONTINUE</code>
        /// and <code>ABANDON</code>. The default value is <code>CONTINUE</code>.
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
        /// Gets and sets the property GlobalTimeout. 
        /// <para>
        /// The maximum length of time an instance can remain in a <code>Pending:Wait</code> or
        /// <code>Terminating:Wait</code> state. Currently, this value is set at 48 hours.
        /// </para>
        /// </summary>
        public int GlobalTimeout
        {
            get { return this._globalTimeout.GetValueOrDefault(); }
            set { this._globalTimeout = value; }
        }

        // Check to see if GlobalTimeout property is set
        internal bool IsSetGlobalTimeout()
        {
            return this._globalTimeout.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property HeartbeatTimeout. 
        /// <para>
        /// The amount of time that can elapse before the lifecycle hook times out. When the lifecycle
        /// hook times out, Auto Scaling performs the action defined in the <code>DefaultResult</code>
        /// parameter. You can prevent the lifecycle hook from timing out by calling <a>RecordLifecycleActionHeartbeat</a>.
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
        /// The state of the EC2 instance to which you want to attach the lifecycle hook. For
        /// a list of lifecycle hook types, see <a>DescribeLifecycleHooks</a>.
        /// </para>
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
        /// Additional information that you want to include any time Auto Scaling sends a message
        /// to the notification target.
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
        /// The ARN of the notification target that Auto Scaling uses to notify you when an instance
        /// is in the transition state for the lifecycle hook. This ARN target can be either an
        /// SQS queue or an SNS topic. The notification message sent to the target includes the
        /// following:
        /// </para>
        ///  <ul> <li>Lifecycle action token</li> <li>User account ID</li> <li>Name of the Auto
        /// Scaling group</li> <li>Lifecycle hook name</li> <li>EC2 instance ID</li> <li>Lifecycle
        /// transition</li> <li>Notification metadata</li> </ul>
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