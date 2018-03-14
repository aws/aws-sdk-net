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
 * Do not modify this file. This file is generated from the lightsail-2016-11-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

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
        /// More information about the instance health. If the <code>instanceHealth</code> is
        /// <code>healthy</code>, then an <code>instanceHealthReason</code> value is not provided.
        /// </para>
        ///  
        /// <para>
        /// If <b> <code>instanceHealth</code> </b> is <code>initial</code>, the <b> <code>instanceHealthReason</code>
        /// </b> value can be one of the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b> <code>Lb.RegistrationInProgress</code> </b> - The target instance is in the process
        /// of being registered with the load balancer.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b> <code>Lb.InitialHealthChecking</code> </b> - The Lightsail load balancer is still
        /// sending the target instance the minimum number of health checks required to determine
        /// its health status.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If <b> <code>instanceHealth</code> </b> is <code>unhealthy</code>, the <b> <code>instanceHealthReason</code>
        /// </b> value can be one of the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b> <code>Instance.ResponseCodeMismatch</code> </b> - The health checks did not return
        /// an expected HTTP code.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b> <code>Instance.Timeout</code> </b> - The health check requests timed out.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b> <code>Instance.FailedHealthChecks</code> </b> - The health checks failed because
        /// the connection to the target instance timed out, the target instance response was
        /// malformed, or the target instance failed the health check for an unknown reason.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b> <code>Lb.InternalError</code> </b> - The health checks failed due to an internal
        /// error.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If <b> <code>instanceHealth</code> </b> is <code>unused</code>, the <b> <code>instanceHealthReason</code>
        /// </b> value can be one of the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b> <code>Instance.NotRegistered</code> </b> - The target instance is not registered
        /// with the target group.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b> <code>Instance.NotInUse</code> </b> - The target group is not used by any load
        /// balancer, or the target instance is in an Availability Zone that is not enabled for
        /// its load balancer.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b> <code>Instance.IpUnusable</code> </b> - The target IP address is reserved for
        /// use by a Lightsail load balancer.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b> <code>Instance.InvalidState</code> </b> - The target is in the stopped or terminated
        /// state.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If <b> <code>instanceHealth</code> </b> is <code>draining</code>, the <b> <code>instanceHealthReason</code>
        /// </b> value can be one of the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b> <code>Instance.DeregistrationInProgress</code> </b> - The target instance is
        /// in the process of being deregistered and the deregistration delay period has not expired.
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