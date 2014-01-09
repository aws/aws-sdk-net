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
    /// Container for the parameters to the SetInstanceHealth operation.
    /// <para> Sets the health status of a specified instance that belongs to any of your Auto Scaling groups. </para> <para>For more information,
    /// see <a href="http://docs.aws.amazon.com/AutoScaling/latest/DeveloperGuide/as-configure-healthcheck.html" >Configure Health Checks for Your
    /// Auto Scaling group</a> .</para>
    /// </summary>
    public partial class SetInstanceHealthRequest : AmazonAutoScalingRequest
    {
        private string instanceId;
        private string healthStatus;
        private bool? shouldRespectGracePeriod;


        /// <summary>
        /// The identifier of the Amazon EC2 instance.
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

        // Check to see if InstanceId property is set
        internal bool IsSetInstanceId()
        {
            return this.instanceId != null;
        }

        /// <summary>
        /// The health status of the instance. Set to <c>Healthy</c> if you want the instance to remain in service. Set to <c>Unhealthy</c> if you want
        /// the instance to be out of service. Auto Scaling will terminate and replace the unhealthy instance.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>1 - 32</description>
        ///     </item>
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>[\u0020-\uD7FF\uE000-\uFFFD\uD800\uDC00-\uDBFF\uDFFF\r\n\t]*</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string HealthStatus
        {
            get { return this.healthStatus; }
            set { this.healthStatus = value; }
        }

        // Check to see if HealthStatus property is set
        internal bool IsSetHealthStatus()
        {
            return this.healthStatus != null;
        }

        /// <summary>
        /// If the Auto Scaling group of the specified instance has a <c>HealthCheckGracePeriod</c> specified for the group, by default, this call will
        /// respect the grace period. Set this to <c>False</c>, if you do not want the call to respect the grace period associated with the group. For
        /// more information, see the <c>HealthCheckGracePeriod</c> parameter description in the <a>CreateAutoScalingGroup</a> action.
        ///  
        /// </summary>
        public bool ShouldRespectGracePeriod
        {
            get { return this.shouldRespectGracePeriod ?? default(bool); }
            set { this.shouldRespectGracePeriod = value; }
        }

        // Check to see if ShouldRespectGracePeriod property is set
        internal bool IsSetShouldRespectGracePeriod()
        {
            return this.shouldRespectGracePeriod.HasValue;
        }

    }
}
    
