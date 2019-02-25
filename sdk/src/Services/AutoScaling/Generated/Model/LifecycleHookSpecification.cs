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
    /// Describes a lifecycle hook, which tells Amazon EC2 Auto Scaling that you want to perform
    /// an action whenever it launches instances or whenever it terminates instances.
    /// 
    ///  
    /// <para>
    /// For more information, see <a href="http://docs.aws.amazon.com/autoscaling/ec2/userguide/lifecycle-hooks.html">Amazon
    /// EC2 Auto Scaling Lifecycle Hooks</a> in the <i>Amazon EC2 Auto Scaling User Guide</i>.
    /// </para>
    /// </summary>
    public partial class LifecycleHookSpecification
    {
        private string _defaultResult;
        private int? _heartbeatTimeout;
        private string _lifecycleHookName;
        private string _lifecycleTransition;
        private string _notificationMetadata;
        private string _notificationTargetARN;
        private string _roleARN;

        /// <summary>
        /// Gets and sets the property DefaultResult. 
        /// <para>
        /// Defines the action the Auto Scaling group should take when the lifecycle hook timeout
        /// elapses or if an unexpected failure occurs. The valid values are <code>CONTINUE</code>
        /// and <code>ABANDON</code>.
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
        /// The maximum time, in seconds, that can elapse before the lifecycle hook times out.
        /// If the lifecycle hook times out, Amazon EC2 Auto Scaling performs the default action.
        /// You can prevent the lifecycle hook from timing out by calling <a>RecordLifecycleActionHeartbeat</a>.
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
        /// The state of the EC2 instance to which you want to attach the lifecycle hook. The
        /// possible values are:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// autoscaling:EC2_INSTANCE_LAUNCHING
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// autoscaling:EC2_INSTANCE_TERMINATING
        /// </para>
        ///  </li> </ul>
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
        /// Additional information that you want to include any time Amazon EC2 Auto Scaling sends
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
        /// The ARN of the target that Amazon EC2 Auto Scaling sends notifications to when an
        /// instance is in the transition state for the lifecycle hook. The notification target
        /// can be either an SQS queue or an SNS topic.
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