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
    /// Container for the parameters to the CreateCustomRoutingEndpointGroup operation.
    /// Create an endpoint group for the specified listener for a custom routing accelerator.
    /// An endpoint group is a collection of endpoints in one AWS Region.
    /// </summary>
    public partial class CreateCustomRoutingEndpointGroupRequest : AmazonGlobalAcceleratorRequest
    {
        private List<CustomRoutingDestinationConfiguration> _destinationConfigurations = new List<CustomRoutingDestinationConfiguration>();
        private string _endpointGroupRegion;
        private string _idempotencyToken;
        private string _listenerArn;

        /// <summary>
        /// Gets and sets the property DestinationConfigurations. 
        /// <para>
        /// Sets the port range and protocol for all endpoints (virtual private cloud subnets)
        /// in a custom routing endpoint group to accept client traffic on.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public List<CustomRoutingDestinationConfiguration> DestinationConfigurations
        {
            get { return this._destinationConfigurations; }
            set { this._destinationConfigurations = value; }
        }

        // Check to see if DestinationConfigurations property is set
        internal bool IsSetDestinationConfigurations()
        {
            return this._destinationConfigurations != null && this._destinationConfigurations.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property EndpointGroupRegion. 
        /// <para>
        /// The AWS Region where the endpoint group is located. A listener can have only one endpoint
        /// group in a specific Region.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=255)]
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

        /// <summary>
        /// Gets and sets the property IdempotencyToken. 
        /// <para>
        /// A unique, case-sensitive identifier that you provide to ensure the idempotency—that
        /// is, the uniqueness—of the request.
        /// </para>
        /// </summary>
        [AWSProperty(Max=255)]
        public string IdempotencyToken
        {
            get { return this._idempotencyToken; }
            set { this._idempotencyToken = value; }
        }

        // Check to see if IdempotencyToken property is set
        internal bool IsSetIdempotencyToken()
        {
            return this._idempotencyToken != null;
        }

        /// <summary>
        /// Gets and sets the property ListenerArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the listener for a custom routing endpoint.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=255)]
        public string ListenerArn
        {
            get { return this._listenerArn; }
            set { this._listenerArn = value; }
        }

        // Check to see if ListenerArn property is set
        internal bool IsSetListenerArn()
        {
            return this._listenerArn != null;
        }

    }
}