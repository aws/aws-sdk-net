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
 * Do not modify this file. This file is generated from the globalaccelerator-2018-08-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.GlobalAccelerator.Model
{
    /// <summary>
    /// A complex type for an endpoint. Each endpoint group can include one or more endpoints,
    /// such as load balancers.
    /// </summary>
    public partial class EndpointDescription
    {
        private string _endpointId;
        private string _healthReason;
        private HealthState _healthState;
        private int? _weight;

        /// <summary>
        /// Gets and sets the property EndpointId. 
        /// <para>
        /// An ID for the endpoint. If the endpoint is a Network Load Balancer or Application
        /// Load Balancer, this is the Amazon Resource Name (ARN) of the resource. If the endpoint
        /// is an Elastic IP address, this is the Elastic IP address allocation ID.
        /// </para>
        /// </summary>
        public string EndpointId
        {
            get { return this._endpointId; }
            set { this._endpointId = value; }
        }

        // Check to see if EndpointId property is set
        internal bool IsSetEndpointId()
        {
            return this._endpointId != null;
        }

        /// <summary>
        /// Gets and sets the property HealthReason. 
        /// <para>
        /// The reason code associated with why the endpoint is not healthy. If the endpoint state
        /// is healthy, a reason code is not provided.
        /// </para>
        ///  
        /// <para>
        /// If the endpoint state is <b>unhealthy</b>, the reason code can be one of the following
        /// values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>Timeout</b>: The health check requests to the endpoint are timing out before returning
        /// a status.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Failed</b>: The health check failed, for example because the endpoint response
        /// was invalid (malformed).
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If the endpoint state is <b>initial</b>, the reason code can be one of the following
        /// values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>ProvisioningInProgress</b>: The endpoint is in the process of being provisioned.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>InitialHealthChecking</b>: Global Accelerator is still setting up the minimum
        /// number of health checks for the endpoint that are required to determine its health
        /// status.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string HealthReason
        {
            get { return this._healthReason; }
            set { this._healthReason = value; }
        }

        // Check to see if HealthReason property is set
        internal bool IsSetHealthReason()
        {
            return this._healthReason != null;
        }

        /// <summary>
        /// Gets and sets the property HealthState. 
        /// <para>
        /// The health status of the endpoint.
        /// </para>
        /// </summary>
        public HealthState HealthState
        {
            get { return this._healthState; }
            set { this._healthState = value; }
        }

        // Check to see if HealthState property is set
        internal bool IsSetHealthState()
        {
            return this._healthState != null;
        }

        /// <summary>
        /// Gets and sets the property Weight. 
        /// <para>
        /// The weight associated with the endpoint. When you add weights to endpoints, you configure
        /// AWS Global Accelerator to route traffic based on proportions that you specify. For
        /// example, you might specify endpoint weights of 4, 5, 5, and 6 (sum=20). The result
        /// is that 4/20 of your traffic, on average, is routed to the first endpoint, 5/20 is
        /// routed both to the second and third endpoints, and 6/20 is routed to the last endpoint.
        /// For more information, see <a href="https://docs.awa.amazon.com/global-accelerator/latest/dg/about-endpoints-endpoint-weights.html">Endpoint
        /// Weights</a> in the <i>AWS Global Accelerator Developer Guide</i>. 
        /// </para>
        /// </summary>
        public int Weight
        {
            get { return this._weight.GetValueOrDefault(); }
            set { this._weight = value; }
        }

        // Check to see if Weight property is set
        internal bool IsSetWeight()
        {
            return this._weight.HasValue; 
        }

    }
}