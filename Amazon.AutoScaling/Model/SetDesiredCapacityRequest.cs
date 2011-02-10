/*
 * Copyright 2010-2011 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
    /// Container for the parameters to the SetDesiredCapacity operation.
    /// <para> Adjusts the desired size of the AutoScalingGroup by initiating
    /// scaling activities. When reducing the size of the group, it is not
    /// possible to define which EC2 instances will be terminated. This
    /// applies to any auto-scaling decisions that might result in the
    /// termination of instances. </para>
    /// </summary>
    /// <seealso cref="Amazon.AutoScaling.AmazonAutoScaling.SetDesiredCapacity"/>
    public class SetDesiredCapacityRequest : AmazonWebServiceRequest
    {
        private string autoScalingGroupName;
        private int? desiredCapacity;
        private bool? honorCooldown;

        /// <summary>
        /// The name of the AutoScalingGroup.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>1 - 1600</description>
        ///     </item>
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>[\u0020-\uD7FF\uE000-\uFFFD\uD800\uDC00-\uDBFF\uDFFF\r\n\t]*</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string AutoScalingGroupName
        {
            get { return this.autoScalingGroupName; }
            set { this.autoScalingGroupName = value; }
        }

        /// <summary>
        /// Sets the AutoScalingGroupName property
        /// </summary>
        /// <param name="autoScalingGroupName">The value to set for the AutoScalingGroupName property </param>
        /// <returns>this instance</returns>
        public SetDesiredCapacityRequest WithAutoScalingGroupName(string autoScalingGroupName)
        {
            this.autoScalingGroupName = autoScalingGroupName;
            return this;
        }
            

        // Check to see if AutoScalingGroupName property is set
        internal bool IsSetAutoScalingGroupName()
        {
            return this.autoScalingGroupName != null;       
        }

        /// <summary>
        /// The new capacity setting for the AutoScalingGroup.
        ///  
        /// </summary>
        public int DesiredCapacity
        {
            get { return this.desiredCapacity ?? default(int); }
            set { this.desiredCapacity = value; }
        }

        /// <summary>
        /// Sets the DesiredCapacity property
        /// </summary>
        /// <param name="desiredCapacity">The value to set for the DesiredCapacity property </param>
        /// <returns>this instance</returns>
        public SetDesiredCapacityRequest WithDesiredCapacity(int desiredCapacity)
        {
            this.desiredCapacity = desiredCapacity;
            return this;
        }
            

        // Check to see if DesiredCapacity property is set
        internal bool IsSetDesiredCapacity()
        {
            return this.desiredCapacity.HasValue;       
        }

        /// <summary>
        /// Set to True if you want Auto Scaling to reject this request if the
        /// Auto Scaling group is in cooldown.
        ///  
        /// </summary>
        public bool HonorCooldown
        {
            get { return this.honorCooldown ?? default(bool); }
            set { this.honorCooldown = value; }
        }

        /// <summary>
        /// Sets the HonorCooldown property
        /// </summary>
        /// <param name="honorCooldown">The value to set for the HonorCooldown property </param>
        /// <returns>this instance</returns>
        public SetDesiredCapacityRequest WithHonorCooldown(bool honorCooldown)
        {
            this.honorCooldown = honorCooldown;
            return this;
        }
            

        // Check to see if HonorCooldown property is set
        internal bool IsSetHonorCooldown()
        {
            return this.honorCooldown.HasValue;       
        }
    }
}
    
