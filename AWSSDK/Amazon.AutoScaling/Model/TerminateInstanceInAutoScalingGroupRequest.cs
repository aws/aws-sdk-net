/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
    /// Container for the parameters to the TerminateInstanceInAutoScalingGroup operation.
    /// <para> Terminates the specified instance. Optionally, the desired group size can be adjusted. </para> <para><b>NOTE:</b> This call simply
    /// registers a termination request. The termination of the instance cannot happen immediately. </para>
    /// </summary>
    /// <seealso cref="Amazon.AutoScaling.AmazonAutoScaling.TerminateInstanceInAutoScalingGroup"/>
    public class TerminateInstanceInAutoScalingGroupRequest : AmazonWebServiceRequest
    {
        private string instanceId;
        private bool? shouldDecrementDesiredCapacity;

        /// <summary>
        /// The ID of the Amazon EC2 instance to be terminated.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>1 - 16</description>
        ///     </item>
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>[\u0020-\uD7FF\uE000-\uFFFD\uD800\uDC00-\uDBFF\uDFFF\r\n\t]*</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string InstanceId
        {
            get { return this.instanceId; }
            set { this.instanceId = value; }
        }

        /// <summary>
        /// Sets the InstanceId property
        /// </summary>
        /// <param name="instanceId">The value to set for the InstanceId property </param>
        /// <returns>this instance</returns>
        public TerminateInstanceInAutoScalingGroupRequest WithInstanceId(string instanceId)
        {
            this.instanceId = instanceId;
            return this;
        }
            

        // Check to see if InstanceId property is set
        internal bool IsSetInstanceId()
        {
            return this.instanceId != null;       
        }

        /// <summary>
        /// Specifies whether (<i>true</i>) or not (<i>false</i>) terminating this instance should also decrement the size of the
        /// <a>AutoScalingGroup</a>.
        ///  
        /// </summary>
        public bool ShouldDecrementDesiredCapacity
        {
            get { return this.shouldDecrementDesiredCapacity ?? default(bool); }
            set { this.shouldDecrementDesiredCapacity = value; }
        }

        /// <summary>
        /// Sets the ShouldDecrementDesiredCapacity property
        /// </summary>
        /// <param name="shouldDecrementDesiredCapacity">The value to set for the ShouldDecrementDesiredCapacity property </param>
        /// <returns>this instance</returns>
        public TerminateInstanceInAutoScalingGroupRequest WithShouldDecrementDesiredCapacity(bool shouldDecrementDesiredCapacity)
        {
            this.shouldDecrementDesiredCapacity = shouldDecrementDesiredCapacity;
            return this;
        }
            

        // Check to see if ShouldDecrementDesiredCapacity property is set
        internal bool IsSetShouldDecrementDesiredCapacity()
        {
            return this.shouldDecrementDesiredCapacity.HasValue;       
        }
    }
}
    
