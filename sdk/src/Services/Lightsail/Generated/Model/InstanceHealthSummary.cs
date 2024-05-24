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
 * Do not modify this file. This file is generated from the lightsail-2016-11-28.normal.json service model.
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
namespace Amazon.Lightsail.Model
{
    /// <summary>
    /// Describes information about the health of the instance.
    /// </summary>
    public partial class InstanceHealthSummary
    {
        private InstanceHealthState _instanceHealth;
        private InstanceHealthReason _instanceHealthReason;
        private string _instanceName;

        /// <summary>
        /// Gets and sets the property InstanceHealth. 
        /// <para>
        /// Describes the overall instance health. Valid values are below.
        /// </para>
        /// </summary>
        public InstanceHealthState InstanceHealth
        {
            get { return this._instanceHealth; }
            set { this._instanceHealth = value; }
        }

        // Check to see if InstanceHealth property is set
        internal bool IsSetInstanceHealth()
        {
            return this._instanceHealth != null;
        }

        /// <summary>
        /// Gets and sets the property InstanceHealthReason. 
        /// <para>
        /// More information about the instance health. If the <c>instanceHealth</c> is <c>healthy</c>,
        /// then an <c>instanceHealthReason</c> value is not provided.
        /// </para>
        ///  
        /// <para>
        /// If <b> <c>instanceHealth</c> </b> is <c>initial</c>, the <b> <c>instanceHealthReason</c>
        /// </b> value can be one of the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b> <c>Lb.RegistrationInProgress</c> </b> - The target instance is in the process
        /// of being registered with the load balancer.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b> <c>Lb.InitialHealthChecking</c> </b> - The Lightsail load balancer is still sending
        /// the target instance the minimum number of health checks required to determine its
        /// health status.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If <b> <c>instanceHealth</c> </b> is <c>unhealthy</c>, the <b> <c>instanceHealthReason</c>
        /// </b> value can be one of the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b> <c>Instance.ResponseCodeMismatch</c> </b> - The health checks did not return
        /// an expected HTTP code.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b> <c>Instance.Timeout</c> </b> - The health check requests timed out.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b> <c>Instance.FailedHealthChecks</c> </b> - The health checks failed because the
        /// connection to the target instance timed out, the target instance response was malformed,
        /// or the target instance failed the health check for an unknown reason.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b> <c>Lb.InternalError</c> </b> - The health checks failed due to an internal error.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If <b> <c>instanceHealth</c> </b> is <c>unused</c>, the <b> <c>instanceHealthReason</c>
        /// </b> value can be one of the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b> <c>Instance.NotRegistered</c> </b> - The target instance is not registered with
        /// the target group.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b> <c>Instance.NotInUse</c> </b> - The target group is not used by any load balancer,
        /// or the target instance is in an Availability Zone that is not enabled for its load
        /// balancer.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b> <c>Instance.IpUnusable</c> </b> - The target IP address is reserved for use by
        /// a Lightsail load balancer.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b> <c>Instance.InvalidState</c> </b> - The target is in the stopped or terminated
        /// state.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If <b> <c>instanceHealth</c> </b> is <c>draining</c>, the <b> <c>instanceHealthReason</c>
        /// </b> value can be one of the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b> <c>Instance.DeregistrationInProgress</c> </b> - The target instance is in the
        /// process of being deregistered and the deregistration delay period has not expired.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public InstanceHealthReason InstanceHealthReason
        {
            get { return this._instanceHealthReason; }
            set { this._instanceHealthReason = value; }
        }

        // Check to see if InstanceHealthReason property is set
        internal bool IsSetInstanceHealthReason()
        {
            return this._instanceHealthReason != null;
        }

        /// <summary>
        /// Gets and sets the property InstanceName. 
        /// <para>
        /// The name of the Lightsail instance for which you are requesting health check data.
        /// </para>
        /// </summary>
        public string InstanceName
        {
            get { return this._instanceName; }
            set { this._instanceName = value; }
        }

        // Check to see if InstanceName property is set
        internal bool IsSetInstanceName()
        {
            return this._instanceName != null;
        }

    }
}