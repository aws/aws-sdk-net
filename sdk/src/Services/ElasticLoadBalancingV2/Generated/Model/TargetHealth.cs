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
 * Do not modify this file. This file is generated from the elasticloadbalancingv2-2015-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ElasticLoadBalancingV2.Model
{
    /// <summary>
    /// Information about the current health of a target.
    /// </summary>
    public partial class TargetHealth
    {
        private string _description;
        private TargetHealthReasonEnum _reason;
        private TargetHealthStateEnum _state;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the target health that provides additional details. If the state
        /// is <code>healthy</code>, a description is not provided.
        /// </para>
        /// </summary>
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property Reason. 
        /// <para>
        /// The reason code.
        /// </para>
        ///  
        /// <para>
        /// If the target state is <code>healthy</code>, a reason code is not provided.
        /// </para>
        ///  
        /// <para>
        /// If the target state is <code>initial</code>, the reason code can be one of the following
        /// values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>Elb.RegistrationInProgress</code> - The target is in the process of being registered
        /// with the load balancer.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Elb.InitialHealthChecking</code> - The load balancer is still sending the target
        /// the minimum number of health checks required to determine its health status.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If the target state is <code>unhealthy</code>, the reason code can be one of the following
        /// values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>Target.ResponseCodeMismatch</code> - The health checks did not return an expected
        /// HTTP code.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Target.Timeout</code> - The health check requests timed out.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Target.FailedHealthChecks</code> - The health checks failed because the connection
        /// to the target timed out, the target response was malformed, or the target failed the
        /// health check for an unknown reason.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Elb.InternalError</code> - The health checks failed due to an internal error.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If the target state is <code>unused</code>, the reason code can be one of the following
        /// values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>Target.NotRegistered</code> - The target is not registered with the target
        /// group.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Target.NotInUse</code> - The target group is not used by any load balancer
        /// or the target is in an Availability Zone that is not enabled for its load balancer.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Target.IpUnusable</code> - The target IP address is reserved for use by a load
        /// balancer.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Target.InvalidState</code> - The target is in the stopped or terminated state.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If the target state is <code>draining</code>, the reason code can be the following
        /// value:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>Target.DeregistrationInProgress</code> - The target is in the process of being
        /// deregistered and the deregistration delay period has not expired.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If the target state is <code>unavailable</code>, the reason code can be the following
        /// value:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>Target.HealthCheckDisabled</code> - Health checks are disabled for the target
        /// group.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public TargetHealthReasonEnum Reason
        {
            get { return this._reason; }
            set { this._reason = value; }
        }

        // Check to see if Reason property is set
        internal bool IsSetReason()
        {
            return this._reason != null;
        }

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The state of the target.
        /// </para>
        /// </summary>
        public TargetHealthStateEnum State
        {
            get { return this._state; }
            set { this._state = value; }
        }

        // Check to see if State property is set
        internal bool IsSetState()
        {
            return this._state != null;
        }

    }
}