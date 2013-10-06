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

namespace Amazon.AutoScaling.Model
{
    /// <summary>
    /// <para> The <c>Instance</c> data type. </para>
    /// </summary>
    public class Instance
    {
        
        private string instanceId;
        private string availabilityZone;
        private string lifecycleState;
        private string healthStatus;
        private string launchConfigurationName;

        /// <summary>
        /// Specifies the ID of the Amazon EC2 instance.
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
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Instance WithInstanceId(string instanceId)
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
        /// Availability Zones associated with this instance.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>1 - 255</description>
        ///     </item>
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>[\u0020-\uD7FF\uE000-\uFFFD\uD800\uDC00-\uDBFF\uDFFF\r\n\t]*</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string AvailabilityZone
        {
            get { return this.availabilityZone; }
            set { this.availabilityZone = value; }
        }

        /// <summary>
        /// Sets the AvailabilityZone property
        /// </summary>
        /// <param name="availabilityZone">The value to set for the AvailabilityZone property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Instance WithAvailabilityZone(string availabilityZone)
        {
            this.availabilityZone = availabilityZone;
            return this;
        }
            

        // Check to see if AvailabilityZone property is set
        internal bool IsSetAvailabilityZone()
        {
            return this.availabilityZone != null;
        }

        /// <summary>
        /// Contains a description of the current <i>lifecycle</i> state. <note> The <c>Quarantined</c> lifecycle state is currently not used. </note>
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Allowed Values</term>
        ///         <description>Pending, Quarantined, InService, Terminating, Terminated</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string LifecycleState
        {
            get { return this.lifecycleState; }
            set { this.lifecycleState = value; }
        }

        /// <summary>
        /// Sets the LifecycleState property
        /// </summary>
        /// <param name="lifecycleState">The value to set for the LifecycleState property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Instance WithLifecycleState(string lifecycleState)
        {
            this.lifecycleState = lifecycleState;
            return this;
        }
            

        // Check to see if LifecycleState property is set
        internal bool IsSetLifecycleState()
        {
            return this.lifecycleState != null;
        }

        /// <summary>
        /// The instance's health status.
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
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Instance WithHealthStatus(string healthStatus)
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
        /// The launch configuration associated with this instance.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>1 - 255</description>
        ///     </item>
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>[\u0020-\uD7FF\uE000-\uFFFD\uD800\uDC00-\uDBFF\uDFFF\r\n\t]*</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string LaunchConfigurationName
        {
            get { return this.launchConfigurationName; }
            set { this.launchConfigurationName = value; }
        }

        /// <summary>
        /// Sets the LaunchConfigurationName property
        /// </summary>
        /// <param name="launchConfigurationName">The value to set for the LaunchConfigurationName property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Instance WithLaunchConfigurationName(string launchConfigurationName)
        {
            this.launchConfigurationName = launchConfigurationName;
            return this;
        }
            

        // Check to see if LaunchConfigurationName property is set
        internal bool IsSetLaunchConfigurationName()
        {
            return this.launchConfigurationName != null;
        }
    }
}
