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
 * Do not modify this file. This file is generated from the autoscaling-2011-01-01.normal.json service model.
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
    /// Container for the parameters to the CompleteLifecycleAction operation.
    /// Completes the lifecycle action for the specified token or instance with the specified
    /// result.
    /// 
    ///  
    /// <para>
    /// This step is a part of the procedure for adding a lifecycle hook to an Auto Scaling
    /// group:
    /// </para>
    ///  <ol> <li> 
    /// <para>
    /// (Optional) Create a launch template or launch configuration with a user data script
    /// that runs while an instance is in a wait state due to a lifecycle hook.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// (Optional) Create a Lambda function and a rule that allows Amazon EventBridge to invoke
    /// your Lambda function when an instance is put into a wait state due to a lifecycle
    /// hook.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// (Optional) Create a notification target and an IAM role. The target can be either
    /// an Amazon SQS queue or an Amazon SNS topic. The role allows Amazon EC2 Auto Scaling
    /// to publish lifecycle notifications to the target.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Create the lifecycle hook. Specify whether the hook is used when the instances launch
    /// or terminate.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// If you need more time, record the lifecycle action heartbeat to keep the instance
    /// in a wait state.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>If you finish before the timeout period ends, send a callback by using the <a
    /// href="https://docs.aws.amazon.com/autoscaling/ec2/APIReference/API_CompleteLifecycleAction.html">CompleteLifecycleAction</a>
    /// API call.</b> 
    /// </para>
    ///  </li> </ol> 
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/completing-lifecycle-hooks.html">Complete
    /// a lifecycle action</a> in the <i>Amazon EC2 Auto Scaling User Guide</i>.
    /// </para>
    /// </summary>
    public partial class CompleteLifecycleActionRequest : AmazonAutoScalingRequest
    {
        private string _autoScalingGroupName;
        private string _instanceId;
        private string _lifecycleActionResult;
        private string _lifecycleActionToken;
        private string _lifecycleHookName;

        /// <summary>
        /// Gets and sets the property AutoScalingGroupName. 
        /// <para>
        /// The name of the Auto Scaling group.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1600)]
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
        [AWSProperty(Min=1, Max=19)]
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
        /// Gets and sets the property LifecycleActionResult. 
        /// <para>
        /// The action for the group to take. You can specify either <c>CONTINUE</c> or <c>ABANDON</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// associated with an instance. Amazon EC2 Auto Scaling sends this token to the notification
        /// target you specified when you created the lifecycle hook.
        /// </para>
        /// </summary>
        [AWSProperty(Min=36, Max=36)]
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
        [AWSProperty(Required=true, Min=1, Max=255)]
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