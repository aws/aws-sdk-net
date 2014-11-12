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
    /// Container for the parameters to the SetInstanceHealth operation.
    /// Sets the health status of a specified instance that belongs to any of
    /// your Auto Scaling groups.         
    /// 
    ///         
    /// <para>
    /// For more information, see <a href="http://docs.aws.amazon.com/AutoScaling/latest/DeveloperGuide/as-configure-healthcheck.html">Configure
    /// Health Checks for Your Auto Scaling group</a>.
    /// </para>
    /// </summary>
    public partial class SetInstanceHealthRequest : AmazonWebServiceRequest
    {
        private string _healthStatus;
        private string _instanceId;
        private bool? _shouldRespectGracePeriod;


        /// <summary>
        /// Gets and sets the property HealthStatus. 
        /// <para>
        ///             The health status of the instance.             Set to <code>Healthy</code>
        /// if you want the instance to remain in service.            Set to <code>Unhealthy</code>
        /// if you want the instance to be out of service. Auto            Scaling will terminate
        /// and replace the unhealthy instance.        
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
        public SetInstanceHealthRequest WithHealthStatus(string healthStatus)
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
        ///             The identifier of the Amazon EC2 instance.        
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
        public SetInstanceHealthRequest WithInstanceId(string instanceId)
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
        /// Gets and sets the property ShouldRespectGracePeriod. 
        /// <para>
        /// If the Auto Scaling group of the specified instance has a <code>HealthCheckGracePeriod</code>
        ///             specified for the group, by default, this call will respect the grace
        /// period. Set this             to <code>False</code>, if you do not want the call to
        /// respect the grace period associated             with the group.
        /// </para>
        ///         
        /// <para>
        /// For more information, see the <code>HealthCheckGracePeriod</code> parameter description
        /// in the             <a>CreateAutoScalingGroup</a> action. 
        /// </para>
        /// </summary>
        public bool ShouldRespectGracePeriod
        {
            get { return this._shouldRespectGracePeriod.GetValueOrDefault(); }
            set { this._shouldRespectGracePeriod = value; }
        }


        /// <summary>
        /// Sets the ShouldRespectGracePeriod property
        /// </summary>
        /// <param name="shouldRespectGracePeriod">The value to set for the ShouldRespectGracePeriod property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public SetInstanceHealthRequest WithShouldRespectGracePeriod(bool shouldRespectGracePeriod)
        {
            this._shouldRespectGracePeriod = shouldRespectGracePeriod;
            return this;
        }

        // Check to see if ShouldRespectGracePeriod property is set
        internal bool IsSetShouldRespectGracePeriod()
        {
            return this._shouldRespectGracePeriod.HasValue; 
        }

    }
}