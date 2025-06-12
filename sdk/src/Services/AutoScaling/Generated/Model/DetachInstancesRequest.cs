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
    /// Container for the parameters to the DetachInstances operation.
    /// Removes one or more instances from the specified Auto Scaling group.
    /// 
    ///  
    /// <para>
    /// After the instances are detached, you can manage them independent of the Auto Scaling
    /// group.
    /// </para>
    ///  
    /// <para>
    /// If you do not specify the option to decrement the desired capacity, Amazon EC2 Auto
    /// Scaling launches instances to replace the ones that are detached.
    /// </para>
    ///  
    /// <para>
    /// If there is a Classic Load Balancer attached to the Auto Scaling group, the instances
    /// are deregistered from the load balancer. If there are target groups attached to the
    /// Auto Scaling group, the instances are deregistered from the target groups.
    /// </para>
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/ec2-auto-scaling-detach-attach-instances.html">Detach
    /// or attach instances</a> in the <i>Amazon EC2 Auto Scaling User Guide</i>.
    /// </para>
    /// </summary>
    public partial class DetachInstancesRequest : AmazonAutoScalingRequest
    {
        private string _autoScalingGroupName;
        private List<string> _instanceIds = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private bool? _shouldDecrementDesiredCapacity;

        /// <summary>
        /// Gets and sets the property AutoScalingGroupName. 
        /// <para>
        /// The name of the Auto Scaling group.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
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
        /// Gets and sets the property InstanceIds. 
        /// <para>
        /// The IDs of the instances. You can specify up to 20 instances.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
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
        /// Indicates whether the Auto Scaling group decrements the desired capacity value by
        /// the number of instances detached.
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