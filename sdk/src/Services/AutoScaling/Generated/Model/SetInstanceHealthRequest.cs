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

/*
 * Do not modify this file. This file is generated from the autoscaling-2011-01-01.normal.json service model.
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
    /// Sets the health status of the specified instance.
    /// 
    ///  
    /// <para>
    /// For more information, see <a href="http://docs.aws.amazon.com/AutoScaling/latest/DeveloperGuide/healthcheck.html">Health
    /// Checks</a> in the <i>Auto Scaling Developer Guide</i>.
    /// </para>
    /// </summary>
    public partial class SetInstanceHealthRequest : AmazonAutoScalingRequest
    {
        private string _healthStatus;
        private string _instanceId;
        private bool? _shouldRespectGracePeriod;

        /// <summary>
        /// Gets and sets the property HealthStatus. 
        /// <para>
        ///  The health status of the instance. Set to <code>Healthy</code> if you want the instance
        /// to remain in service. Set to <code>Unhealthy</code> if you want the instance to be
        /// out of service. Auto Scaling will terminate and replace the unhealthy instance. 
        /// </para>
        /// </summary>
        public string HealthStatus
        {
            get { return this._healthStatus; }
            set { this._healthStatus = value; }
        }

        // Check to see if HealthStatus property is set
        internal bool IsSetHealthStatus()
        {
            return this._healthStatus != null;
        }

        /// <summary>
        /// Gets and sets the property InstanceId. 
        /// <para>
        /// The ID of the EC2 instance.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property ShouldRespectGracePeriod. 
        /// <para>
        /// If the Auto Scaling group of the specified instance has a <code>HealthCheckGracePeriod</code>
        /// specified for the group, by default, this call will respect the grace period. Set
        /// this to <code>False</code>, if you do not want the call to respect the grace period
        /// associated with the group.
        /// </para>
        ///  
        /// <para>
        /// For more information, see the <code>HealthCheckGracePeriod</code> parameter description
        /// for <a>CreateAutoScalingGroup</a>.
        /// </para>
        /// </summary>
        public bool ShouldRespectGracePeriod
        {
            get { return this._shouldRespectGracePeriod.GetValueOrDefault(); }
            set { this._shouldRespectGracePeriod = value; }
        }

        // Check to see if ShouldRespectGracePeriod property is set
        internal bool IsSetShouldRespectGracePeriod()
        {
            return this._shouldRespectGracePeriod.HasValue; 
        }

    }
}