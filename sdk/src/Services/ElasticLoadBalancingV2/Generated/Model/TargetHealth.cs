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
 * Do not modify this file. This file is generated from the elasticloadbalancingv2-2015-12-01.normal.json service model.
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
        /// is <c>healthy</c>, a description is not provided.
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
        /// If the target state is <c>healthy</c>, a reason code is not provided.
        /// </para>
        ///  
        /// <para>
        /// If the target state is <c>initial</c>, the reason code can be one of the following
        /// values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>Elb.RegistrationInProgress</c> - The target is in the process of being registered
        /// with the load balancer.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Elb.InitialHealthChecking</c> - The load balancer is still sending the target
        /// the minimum number of health checks required to determine its health status.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If the target state is <c>unhealthy</c>, the reason code can be one of the following
        /// values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>Target.ResponseCodeMismatch</c> - The health checks did not return an expected
        /// HTTP code. Applies only to Application Load Balancers and Gateway Load Balancers.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Target.Timeout</c> - The health check requests timed out. Applies only to Application
        /// Load Balancers and Gateway Load Balancers.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Target.FailedHealthChecks</c> - The load balancer received an error while establishing
        /// a connection to the target or the target response was malformed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Elb.InternalError</c> - The health checks failed due to an internal error. Applies
        /// only to Application Load Balancers.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If the target state is <c>unused</c>, the reason code can be one of the following
        /// values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>Target.NotRegistered</c> - The target is not registered with the target group.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Target.NotInUse</c> - The target group is not used by any load balancer or the
        /// target is in an Availability Zone that is not enabled for its load balancer.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Target.InvalidState</c> - The target is in the stopped or terminated state.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Target.IpUnusable</c> - The target IP address is reserved for use by a load balancer.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If the target state is <c>draining</c>, the reason code can be the following value:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>Target.DeregistrationInProgress</c> - The target is in the process of being deregistered
        /// and the deregistration delay period has not expired.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If the target state is <c>unavailable</c>, the reason code can be the following value:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>Target.HealthCheckDisabled</c> - Health checks are disabled for the target group.
        /// Applies only to Application Load Balancers.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Elb.InternalError</c> - Target health is unavailable due to an internal error.
        /// Applies only to Network Load Balancers.
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