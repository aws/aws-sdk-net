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
    /// Container for the parameters to the CompleteLifecycleAction operation.
    /// Completes the lifecycle action for the associated token initiated under the given
    /// lifecycle hook with the specified result. 
    /// 
    ///  
    /// <para>
    /// This operation is a part of the basic sequence for adding a lifecycle hook to an Auto
    /// Scaling group:
    /// </para>
    ///  <ol> <li>Create a notification target. A target can be either an Amazon SQS queue
    /// or an Amazon SNS topic.</li> <li>Create an IAM role. This role allows Auto Scaling
    /// to publish lifecycle notifications to the designated SQS queue or SNS topic.</li>
    /// <li>Create the lifecycle hook. You can create a hook that acts when instances launch
    /// or when instances terminate.</li> <li>If necessary, record the lifecycle action heartbeat
    /// to keep the instance in a pending state.</li> <li> <b>Complete the lifecycle action</b>.</li>
    /// </ol> 
    /// <para>
    /// For more information, see <a href="http://docs.aws.amazon.com/AutoScaling/latest/DeveloperGuide/AutoScalingPendingState.html">Auto
    /// Scaling Pending State</a> and <a href="http://docs.aws.amazon.com/AutoScaling/latest/DeveloperGuide/AutoScalingTerminatingState.html">Auto
    /// Scaling Terminating State</a> in the <i>Auto Scaling Developer Guide</i>.
    /// </para>
    /// </summary>
    public partial class CompleteLifecycleActionRequest : AmazonAutoScalingRequest
    {
        private string _autoScalingGroupName;
        private string _lifecycleActionResult;
        private string _lifecycleActionToken;
        private string _lifecycleHookName;

        /// <summary>
        /// Gets and sets the property AutoScalingGroupName. 
        /// <para>
        /// The name of the group for the lifecycle hook.
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
        /// Gets and sets the property LifecycleActionResult. 
        /// <para>
        /// The action for the group to take. This parameter can be either <code>CONTINUE</code>
        /// or <code>ABANDON</code>.
        /// </para>
        /// </summary>
        public string LifecycleActionResult
        {
            get { return this._lifecycleActionResult; }
            set { this._lifecycleActionResult = value; }
        }

        // Check to see if LifecycleActionResult property is set
        internal bool IsSetLifecycleActionResult()
        {
            return this._lifecycleActionResult != null;
        }

        /// <summary>
        /// Gets and sets the property LifecycleActionToken. 
        /// <para>
        /// A universally unique identifier (UUID) that identifies a specific lifecycle action
        /// associated with an instance. Auto Scaling sends this token to the notification target
        /// you specified when you created the lifecycle hook.
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