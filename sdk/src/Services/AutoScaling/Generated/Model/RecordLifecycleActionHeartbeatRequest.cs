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
    /// Container for the parameters to the RecordLifecycleActionHeartbeat operation.
    /// Records a heartbeat for the lifecycle action associated with the specified token or
    /// instance. This extends the timeout by the length of time defined using <a>PutLifecycleHook</a>.
    /// 
    ///  
    /// <para>
    /// This step is a part of the procedure for adding a lifecycle hook to an Auto Scaling
    /// group:
    /// </para>
    ///  <ol> <li> 
    /// <para>
    /// (Optional) Create a Lambda function and a rule that allows CloudWatch Events to invoke
    /// your Lambda function when Auto Scaling launches or terminates instances.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// (Optional) Create a notification target and an IAM role. The target can be either
    /// an Amazon SQS queue or an Amazon SNS topic. The role allows Auto Scaling to publish
    /// lifecycle notifications to the target.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Create the lifecycle hook. Specify whether the hook is used when the instances launch
    /// or terminate.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>If you need more time, record the lifecycle action heartbeat to keep the instance
    /// in a pending state.</b> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// If you finish before the timeout period ends, complete the lifecycle action.
    /// </para>
    ///  </li> </ol> 
    /// <para>
    /// For more information, see <a href="http://docs.aws.amazon.com/autoscaling/latest/userguide/AutoScalingGroupLifecycle.html">Auto
    /// Scaling Lifecycle</a> in the <i>Auto Scaling User Guide</i>.
    /// </para>
    /// </summary>
    public partial class RecordLifecycleActionHeartbeatRequest : AmazonAutoScalingRequest
    {
        private string _autoScalingGroupName;
        private string _instanceId;
        private string _lifecycleActionToken;
        private string _lifecycleHookName;

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
        /// Gets and sets the property InstanceId. 
        /// <para>
        /// The ID of the instance.
        /// </para>
        /// </summary>
        public string InstanceId
        {
            get { return this._instanceId; }
            set { this._instanceId = value; }
        }

        // Check to see if InstanceId property is set
        internal bool IsSetInstanceId()
        {
            return this._instanceId != null;
        }

        /// <summary>
        /// Gets and sets the property LifecycleActionToken. 
        /// <para>
        /// A token that uniquely identifies a specific lifecycle action associated with an instance.
        /// Auto Scaling sends this token to the notification target you specified when you created
        /// the lifecycle hook.
        /// </para>
        /// </summary>
        public string LifecycleActionToken
        {
            get { return this._lifecycleActionToken; }
            set { this._lifecycleActionToken = value; }
        }

        // Check to see if LifecycleActionToken property is set
        internal bool IsSetLifecycleActionToken()
        {
            return this._lifecycleActionToken != null;
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

    }
}