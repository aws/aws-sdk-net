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

namespace Amazon.GlobalAccelerator.Model
{
    /// <summary>
    /// A complex type for the endpoint group for a custom routing accelerator. An AWS Region
    /// can have only one endpoint group for a specific listener.
    /// </summary>
    public partial class CustomRoutingEndpointGroup
    {
        private List<CustomRoutingDestinationDescription> _destinationDescriptions = new List<CustomRoutingDestinationDescription>();
        private List<CustomRoutingEndpointDescription> _endpointDescriptions = new List<CustomRoutingEndpointDescription>();
        private string _endpointGroupArn;
        private string _endpointGroupRegion;

        /// <summary>
        /// Gets and sets the property DestinationDescriptions. 
        /// <para>
        /// For a custom routing accelerator, describes the port range and protocol for all endpoints
        /// (virtual private cloud subnets) in an endpoint group to accept client traffic on.
        /// </para>
        /// </summary>
        public List<CustomRoutingDestinationDescription> DestinationDescriptions
        {
            get { return this._destinationDescriptions; }
            set { this._destinationDescriptions = value; }
        }

        // Check to see if DestinationDescriptions property is set
        internal bool IsSetDestinationDescriptions()
        {
            return this._destinationDescriptions != null && this._destinationDescriptions.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property EndpointDescriptions. 
        /// <para>
        /// For a custom routing accelerator, describes the endpoints (virtual private cloud subnets)
        /// in an endpoint group to accept client traffic on.
        /// </para>
        /// </summary>
        public List<CustomRoutingEndpointDescription> EndpointDescriptions
        {
            get { return this._endpointDescriptions; }
            set { this._endpointDescriptions = value; }
        }

        // Check to see if EndpointDescriptions property is set
        internal bool IsSetEndpointDescriptions()
        {
            return this._endpointDescriptions != null && this._endpointDescriptions.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property EndpointGroupArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the endpoint group.
        /// </para>
        /// </summary>
        [AWSProperty(Max=255)]
        public string EndpointGroupArn
        {
            get { return this._endpointGroupArn; }
            set { this._endpointGroupArn = value; }
        }

        // Check to see if EndpointGroupArn property is set
        internal bool IsSetEndpointGroupArn()
        {
            return this._endpointGroupArn != null;
        }

        /// <summary>
        /// Gets and sets the property EndpointGroupRegion. 
        /// <para>
        /// The AWS Region where the endpoint group is located.
        /// </para>
        /// </summary>
        [AWSProperty(Max=255)]
        public string EndpointGroupRegion
        {
            get { return this._endpointGroupRegion; }
            set { this._endpointGroupRegion = value; }
        }

        // Check to see if EndpointGroupRegion property is set
        internal bool IsSetEndpointGroupRegion()
        {
            return this._endpointGroupRegion != null;
        }

    }
}