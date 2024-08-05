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
    /// Container for the parameters to the SetDesiredCapacity operation.
    /// Sets the size of the specified Auto Scaling group.
    /// 
    ///  
    /// <para>
    /// If a scale-in activity occurs as a result of a new <c>DesiredCapacity</c> value that
    /// is lower than the current size of the group, the Auto Scaling group uses its termination
    /// policy to determine which instances to terminate. 
    /// </para>
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/ec2-auto-scaling-scaling-manually.html">Manual
    /// scaling</a> in the <i>Amazon EC2 Auto Scaling User Guide</i>.
    /// </para>
    /// </summary>
    public partial class SetDesiredCapacityRequest : AmazonAutoScalingRequest
    {
        private string _autoScalingGroupName;
        private int? _desiredCapacity;
        private bool? _honorCooldown;

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
        /// Gets and sets the property DesiredCapacity. 
        /// <para>
        /// The desired capacity is the initial capacity of the Auto Scaling group after this
        /// operation completes and the capacity it attempts to maintain.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int? DesiredCapacity
        {
            get { return this._desiredCapacity; }
            set { this._desiredCapacity = value; }
        }

        // Check to see if DesiredCapacity property is set
        internal bool IsSetDesiredCapacity()
        {
            return this._desiredCapacity.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property HonorCooldown. 
        /// <para>
        /// Indicates whether Amazon EC2 Auto Scaling waits for the cooldown period to complete
        /// before initiating a scaling activity to set your Auto Scaling group to its new capacity.
        /// By default, Amazon EC2 Auto Scaling does not honor the cooldown period during manual
        /// scaling activities.
        /// </para>
        /// </summary>
        public bool? HonorCooldown
        {
            get { return this._honorCooldown; }
            set { this._honorCooldown = value; }
        }

        // Check to see if HonorCooldown property is set
        internal bool IsSetHonorCooldown()
        {
            return this._honorCooldown.HasValue; 
        }

    }
}