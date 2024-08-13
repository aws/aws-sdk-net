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
 * Do not modify this file. This file is generated from the globalaccelerator-2018-08-08.normal.json service model.
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
namespace Amazon.GlobalAccelerator.Model
{
    /// <summary>
    /// A complex type for an endpoint. Each endpoint group can include one or more endpoints,
    /// such as load balancers.
    /// </summary>
    public partial class EndpointDescription
    {
        private bool? _clientIPPreservationEnabled;
        private string _endpointId;
        private string _healthReason;
        private HealthState _healthState;
        private int? _weight;

        /// <summary>
        /// Gets and sets the property ClientIPPreservationEnabled. 
        /// <para>
        /// Indicates whether client IP address preservation is enabled for an endpoint. The value
        /// is true or false. The default value is true for Application Load Balancers endpoints.
        /// 
        /// </para>
        ///  
        /// <para>
        /// If the value is set to true, the client's IP address is preserved in the <c>X-Forwarded-For</c>
        /// request header as traffic travels to applications on the endpoint fronted by the accelerator.
        /// </para>
        ///  
        /// <para>
        /// Client IP address preservation is supported, in specific Amazon Web Services Regions,
        /// for endpoints that are Application Load Balancers, Amazon EC2 instances, and Network
        /// Load Balancers with security groups. IMPORTANT: You cannot use client IP address preservation
        /// with Network Load Balancers with TLS listeners.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/global-accelerator/latest/dg/preserve-client-ip-address.html">
        /// Preserve client IP addresses in Global Accelerator</a> in the <i>Global Accelerator
        /// Developer Guide</i>.
        /// </para>
        /// </summary>
        public bool? ClientIPPreservationEnabled
        {
            get { return this._clientIPPreservationEnabled; }
            set { this._clientIPPreservationEnabled = value; }
        }

        // Check to see if ClientIPPreservationEnabled property is set
        internal bool IsSetClientIPPreservationEnabled()
        {
            return this._clientIPPreservationEnabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EndpointId. 
        /// <para>
        /// An ID for the endpoint. If the endpoint is a Network Load Balancer or Application
        /// Load Balancer, this is the Amazon Resource Name (ARN) of the resource. If the endpoint
        /// is an Elastic IP address, this is the Elastic IP address allocation ID. For Amazon
        /// EC2 instances, this is the EC2 instance ID. 
        /// </para>
        ///  
        /// <para>
        /// An Application Load Balancer can be either internal or internet-facing.
        /// </para>
        /// </summary>
        [AWSProperty(Max=255)]
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
        /// Returns a null result.
        /// </para>
        /// </summary>
        [AWSProperty(Max=255)]
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
        /// Global Accelerator to route traffic based on proportions that you specify. For example,
        /// you might specify endpoint weights of 4, 5, 5, and 6 (sum=20). The result is that
        /// 4/20 of your traffic, on average, is routed to the first endpoint, 5/20 is routed
        /// both to the second and third endpoints, and 6/20 is routed to the last endpoint. For
        /// more information, see <a href="https://docs.aws.amazon.com/global-accelerator/latest/dg/about-endpoints-endpoint-weights.html">Endpoint
        /// weights</a> in the <i>Global Accelerator Developer Guide</i>. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=255)]
        public int? Weight
        {
            get { return this._weight; }
            set { this._weight = value; }
        }

        // Check to see if Weight property is set
        internal bool IsSetWeight()
        {
            return this._weight.HasValue; 
        }

    }
}