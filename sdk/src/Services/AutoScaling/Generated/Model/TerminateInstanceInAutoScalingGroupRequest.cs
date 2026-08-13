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
    /// Container for the parameters to the TerminateInstanceInAutoScalingGroup operation.
    /// Terminates the specified instance and optionally adjusts the desired group size. This
    /// operation cannot be called on instances in a warm pool.
    /// 
    ///  
    /// <para>
    /// This call simply makes a termination request. The instances are not terminated immediately.
    /// When an instance is terminated, the instance status changes to <c>terminated</c>.
    /// You can't connect to or start an instance after you've terminated it.
    /// </para>
    ///  
    /// <para>
    /// If you do not specify the option to decrement the desired capacity, Amazon EC2 Auto
    /// Scaling launches instances to replace the ones that are terminated. 
    /// </para>
    ///  
    /// <para>
    /// To terminate multiple instances in a single call, use the <c>InstanceIds</c> and <c>AutoScalingGroupName</c>
    /// parameters instead of <c>InstanceId</c>. When terminating multiple instances, the
    /// response populates <c>Activities</c> instead of <c>Activity</c>.
    /// </para>
    ///  
    /// <para>
    /// By default, Amazon EC2 Auto Scaling balances instances across all Availability Zones.
    /// If you decrement the desired capacity, your Auto Scaling group can become unbalanced
    /// between Availability Zones. Amazon EC2 Auto Scaling tries to rebalance the group,
    /// and rebalancing might terminate instances in other zones. For more information, see
    /// <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/ec2-auto-scaling-scaling-manually.html">Manual
    /// scaling</a> in the <i>Amazon EC2 Auto Scaling User Guide</i>.
    /// </para>
    /// </summary>
    public partial class TerminateInstanceInAutoScalingGroupRequest : AmazonAutoScalingRequest
    {
        private string _autoScalingGroupName;
        private string _instanceId;
        private List<string> _instanceIds = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private bool? _shouldDecrementDesiredCapacity;

        /// <summary>
        /// Gets and sets the property AutoScalingGroupName. 
        /// <para>
        /// The name of the Auto Scaling group. Required when using <c>InstanceIds</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
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
        /// Gets and sets the property InstanceIds. 
        /// <para>
        /// The IDs of the instances. You can specify up to 100 instances.
        /// </para>
        ///  
        /// <para>
        /// This parameter requires that you also specify <c>AutoScalingGroupName</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public List<string> InstanceIds
        {
            get { return this._instanceIds; }
            set { this._instanceIds = value; }
        }

        // Check to see if InstanceIds property is set
        internal bool IsSetInstanceIds()
        {
            return this._instanceIds != null && (this._instanceIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ShouldDecrementDesiredCapacity. 
        /// <para>
        /// Indicates whether terminating the instance also decrements the size of the Auto Scaling
        /// group.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public bool? ShouldDecrementDesiredCapacity
        {
            get { return this._shouldDecrementDesiredCapacity; }
            set { this._shouldDecrementDesiredCapacity = value; }
        }

        // Check to see if ShouldDecrementDesiredCapacity property is set
        internal bool IsSetShouldDecrementDesiredCapacity()
        {
            return this._shouldDecrementDesiredCapacity.HasValue; 
        }

    }
}