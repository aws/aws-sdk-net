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
    /// The <code>Instance</code> data type.
    /// </summary>
    public partial class Instance
    {
        private string _availabilityZone;
        private string _healthStatus;
        private string _instanceId;
        private string _launchConfigurationName;
        private string _lifecycleState;


        /// <summary>
        /// Gets and sets the property AvailabilityZone. 
        /// <para>
        ///             Availability Zones associated with this instance.        
        /// </para>
        /// </summary>
        public string AvailabilityZone
        {
            get { return this._availabilityZone; }
            set { this._availabilityZone = value; }
        }


        /// <summary>
        /// Sets the AvailabilityZone property
        /// </summary>
        /// <param name="availabilityZone">The value to set for the AvailabilityZone property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Instance WithAvailabilityZone(string availabilityZone)
        {
            this._availabilityZone = availabilityZone;
            return this;
        }

        // Check to see if AvailabilityZone property is set
        internal bool IsSetAvailabilityZone()
        {
            return this._availabilityZone != null;
        }


        /// <summary>
        /// Gets and sets the property HealthStatus. 
        /// <para>
        ///             The instance's health status.        
        /// </para>
        /// </summary>
        public string HealthStatus
        {
            get { return this._healthStatus; }
            set { this._healthStatus = value; }
        }


        /// <summary>
        /// Sets the HealthStatus property
        /// </summary>
        /// <param name="healthStatus">The value to set for the HealthStatus property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Instance WithHealthStatus(string healthStatus)
        {
            this._healthStatus = healthStatus;
            return this;
        }

        // Check to see if HealthStatus property is set
        internal bool IsSetHealthStatus()
        {
            return this._healthStatus != null;
        }


        /// <summary>
        /// Gets and sets the property InstanceId. 
        /// <para>
        ///         Specifies the ID of the Amazon EC2 instance.        
        /// </para>
        /// </summary>
        public string InstanceId
        {
            get { return this._instanceId; }
            set { this._instanceId = value; }
        }


        /// <summary>
        /// Sets the InstanceId property
        /// </summary>
        /// <param name="instanceId">The value to set for the InstanceId property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Instance WithInstanceId(string instanceId)
        {
            this._instanceId = instanceId;
            return this;
        }

        // Check to see if InstanceId property is set
        internal bool IsSetInstanceId()
        {
            return this._instanceId != null;
        }


        /// <summary>
        /// Gets and sets the property LaunchConfigurationName. 
        /// <para>
        ///             The launch configuration associated with this instance.        
        /// </para>
        /// </summary>
        public string LaunchConfigurationName
        {
            get { return this._launchConfigurationName; }
            set { this._launchConfigurationName = value; }
        }


        /// <summary>
        /// Sets the LaunchConfigurationName property
        /// </summary>
        /// <param name="launchConfigurationName">The value to set for the LaunchConfigurationName property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Instance WithLaunchConfigurationName(string launchConfigurationName)
        {
            this._launchConfigurationName = launchConfigurationName;
            return this;
        }

        // Check to see if LaunchConfigurationName property is set
        internal bool IsSetLaunchConfigurationName()
        {
            return this._launchConfigurationName != null;
        }


        /// <summary>
        /// Gets and sets the property LifecycleState. 
        /// <para>
        ///         Contains a description of the current <i>lifecycle</i> state.            
        ///       
        /// </para>
        ///         <note>            
        /// <para>
        /// The <code>Quarantined</code> lifecycle state is currently not used.
        /// </para>
        ///         </note>
        /// </summary>
        public string LifecycleState
        {
            get { return this._lifecycleState; }
            set { this._lifecycleState = value; }
        }


        /// <summary>
        /// Sets the LifecycleState property
        /// </summary>
        /// <param name="lifecycleState">The value to set for the LifecycleState property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Instance WithLifecycleState(string lifecycleState)
        {
            this._lifecycleState = lifecycleState;
            return this;
        }

        // Check to see if LifecycleState property is set
        internal bool IsSetLifecycleState()
        {
            return this._lifecycleState != null;
        }

    }
}