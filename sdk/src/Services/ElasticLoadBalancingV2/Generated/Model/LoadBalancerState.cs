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
    /// Information about the state of the load balancer.
    /// </summary>
    public partial class LoadBalancerState
    {
        private LoadBalancerStateEnum _code;
        private string _reason;

        /// <summary>
        /// Gets and sets the property Code. 
        /// <para>
        /// The state code. The initial state of the load balancer is <c>provisioning</c>. After
        /// the load balancer is fully set up and ready to route traffic, its state is <c>active</c>.
        /// If load balancer is routing traffic but does not have the resources it needs to scale,
        /// its state is<c>active_impaired</c>. If the load balancer could not be set up, its
        /// state is <c>failed</c>.
        /// </para>
        /// </summary>
        public LoadBalancerStateEnum Code
        {
            get { return this._code; }
            set { this._code = value; }
        }

        // Check to see if Code property is set
        internal bool IsSetCode()
        {
            return this._code != null;
        }

        /// <summary>
        /// Gets and sets the property Reason. 
        /// <para>
        /// A description of the state.
        /// </para>
        /// </summary>
        public string Reason
        {
            get { return this._reason; }
            set { this._reason = value; }
        }

        // Check to see if Reason property is set
        internal bool IsSetReason()
        {
            return this._reason != null;
        }

    }
}