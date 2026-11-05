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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// A complex type for the endpoint group for a custom routing accelerator. An Amazon
    /// Web Services Region can have only one endpoint group for a specific listener.
    /// </summary>
    public partial class CustomRoutingEndpointGroup
    {
        /// <summary>
        /// Gets and sets the property DestinationDescriptions. 
        /// <para>
        /// For a custom routing accelerator, describes the port range and protocol for all endpoints
        /// (virtual private cloud subnets) in an endpoint group to accept client traffic on.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<CustomRoutingDestinationDescription> DestinationDescriptions { get; set; } = AWSConfigs.InitializeCollections ? new List<CustomRoutingDestinationDescription>() : null;

        /// <summary>
        /// Checks to see if the DestinationDescriptions property is set.
        /// </summary>
        internal bool IsSetDestinationDescriptions() => this.DestinationDescriptions != null && (this.DestinationDescriptions.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property EndpointDescriptions. 
        /// <para>
        /// For a custom routing accelerator, describes the endpoints (virtual private cloud subnets)
        /// in an endpoint group to accept client traffic on.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<CustomRoutingEndpointDescription> EndpointDescriptions { get; set; } = AWSConfigs.InitializeCollections ? new List<CustomRoutingEndpointDescription>() : null;

        /// <summary>
        /// Checks to see if the EndpointDescriptions property is set.
        /// </summary>
        internal bool IsSetEndpointDescriptions() => this.EndpointDescriptions != null && (this.EndpointDescriptions.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property EndpointGroupArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the endpoint group.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 255)]
        public string EndpointGroupArn { get; set; }

        /// <summary>
        /// Checks to see if the EndpointGroupArn property is set.
        /// </summary>
        internal bool IsSetEndpointGroupArn() => this.EndpointGroupArn != null;

        /// <summary>
        /// Gets and sets the property EndpointGroupRegion. 
        /// <para>
        /// The Amazon Web Services Region where the endpoint group is located.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 255)]
        public string EndpointGroupRegion { get; set; }

        /// <summary>
        /// Checks to see if the EndpointGroupRegion property is set.
        /// </summary>
        internal bool IsSetEndpointGroupRegion() => this.EndpointGroupRegion != null;
    }
}
