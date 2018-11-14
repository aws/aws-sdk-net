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
    /// Creates or updates a lifecycle hook for the specified Auto Scaling group.
    /// 
    ///  
    /// <para>
    /// A lifecycle hook tells Amazon EC2 Auto Scaling to perform an action on an instance
    /// that is not actively in service; for example, either when the instance launches or
    /// before the instance terminates.
    /// </para>
    ///  
    /// <para>
    /// This step is a part of the procedure for adding a lifecycle hook to an Auto Scaling
    /// group:
    /// </para>
    ///  <ol> <li> 
    /// <para>
    /// (Optional) Create a Lambda function and a rule that allows CloudWatch Events to invoke
    /// your Lambda function when Amazon EC2 Auto Scaling launches or terminates instances.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// (Optional) Create a notification target and an IAM role. The target can be either
    /// an Amazon SQS queue or an Amazon SNS topic. The role allows Amazon EC2 Auto Scaling
    /// to publish lifecycle notifications to the target.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>Create the lifecycle hook. Specify whether the hook is used when the instances
    /// launch or terminate.</b> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// If you need more time, record the lifecycle action heartbeat to keep the instance
    /// in a pending state.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// If you finish before the timeout period ends, complete the lifecycle action.
    /// </para>
    ///  </li> </ol> 
    /// <para>
    /// For more information, see <a href="http://docs.aws.amazon.com/autoscaling/ec2/userguide/lifecycle-hooks.html">Auto
    /// Scaling Lifecycle Hooks</a> in the <i>Amazon EC2 Auto Scaling User Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// If you exceed your maximum limit of lifecycle hooks, which by default is 50 per Auto
    /// Scaling group, the call fails. For information about updating this limit, see <a href="http://docs.aws.amazon.com/general/latest/gr/aws_service_limits.html">AWS
    /// Service Limits</a> in the <i>Amazon Web Services General Reference</i>.
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
        /// The name of the Auto Scaling group.
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
        /// elapses or if an unexpected failure occurs. This parameter can be either <code>CONTINUE</code>
        /// or <code>ABANDON</code>. The default value is <code>ABANDON</code>.
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
        /// The range is from 30 to 7200 seconds. The default is 3600 seconds (1 hour).
        /// </para>
        ///  
        /// <para>
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
        /// The instance state to which you want to attach the lifecycle hook. The possible values
        /// are:
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
        /// <para>
        /// This parameter is required for new lifecycle hooks, but optional when updating existing
        /// hooks.
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
        /// Contains additional information that you want to include any time Amazon EC2 Auto
        /// Scaling sends a message to the notification target.
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
        /// The ARN of the notification target that Amazon EC2 Auto Scaling uses to notify you
        /// when an instance is in the transition state for the lifecycle hook. This target can
        /// be either an SQS queue or an SNS topic. If you specify an empty string, this overrides
        /// the current ARN.
        /// </para>
        ///  
        /// <para>
        /// This operation uses the JSON format when sending notifications to an Amazon SQS queue,
        /// and an email key-value pair format when sending notifications to an Amazon SNS topic.
        /// </para>
        ///  
        /// <para>
        /// When you specify a notification target, Amazon EC2 Auto Scaling sends it a test message.
        /// Test messages contain the following additional key-value pair: <code>"Event": "autoscaling:TEST_NOTIFICATION"</code>.
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
        ///  
        /// <para>
        /// This parameter is required for new lifecycle hooks, but optional when updating existing
        /// hooks.
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