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
    /// <para> Sets the health status of an instance. </para>
    /// </summary>
    /// <seealso cref="Amazon.AutoScaling.AmazonAutoScaling.SetInstanceHealth"/>
    public class SetInstanceHealthRequest : AmazonWebServiceRequest
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

        /// <summary>
        /// Sets the InstanceId property
        /// </summary>
        /// <param name="instanceId">The value to set for the InstanceId property </param>
        /// <returns>this instance</returns>
        public SetInstanceHealthRequest WithInstanceId(string instanceId)
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
        /// The health status of the instance. "Healthy" means that the instance is healthy and should remain in service. "Unhealthy" means that the
        /// instance is unhealthy. Auto Scaling should terminate and replace it.
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

        /// <summary>
        /// Sets the HealthStatus property
        /// </summary>
        /// <param name="healthStatus">The value to set for the HealthStatus property </param>
        /// <returns>this instance</returns>
        public SetInstanceHealthRequest WithHealthStatus(string healthStatus)
        {
            this.healthStatus = healthStatus;
            return this;
        }
            

        // Check to see if HealthStatus property is set
        internal bool IsSetHealthStatus()
        {
            return this.healthStatus != null;       
        }

        /// <summary>
        /// If True, this call should respect the grace period associated with the group.
        ///  
        /// </summary>
        public bool ShouldRespectGracePeriod
        {
            get { return this.shouldRespectGracePeriod ?? default(bool); }
            set { this.shouldRespectGracePeriod = value; }
        }

        /// <summary>
        /// Sets the ShouldRespectGracePeriod property
        /// </summary>
        /// <param name="shouldRespectGracePeriod">The value to set for the ShouldRespectGracePeriod property </param>
        /// <returns>this instance</returns>
        public SetInstanceHealthRequest WithShouldRespectGracePeriod(bool shouldRespectGracePeriod)
        {
            this.shouldRespectGracePeriod = shouldRespectGracePeriod;
            return this;
        }
            

        // Check to see if ShouldRespectGracePeriod property is set
        internal bool IsSetShouldRespectGracePeriod()
        {
            return this.shouldRespectGracePeriod.HasValue;       
        }
    }
}
    
