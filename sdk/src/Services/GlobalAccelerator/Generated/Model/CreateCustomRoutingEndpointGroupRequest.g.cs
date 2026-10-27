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
    /// Container for the parameters to the CreateCustomRoutingEndpointGroup operation. Create
    /// an endpoint group for the specified listener for a custom routing accelerator. An
    /// endpoint group is a collection of endpoints in one Amazon Web Services Region.
    /// </summary>
    public partial class CreateCustomRoutingEndpointGroupRequest : AmazonGlobalAcceleratorRequest
    {
        /// <summary>
        /// Gets and sets the property DestinationConfigurations. 
        /// <para>
        /// Sets the port range and protocol for all endpoints (virtual private cloud subnets)
        /// in a custom routing endpoint group to accept client traffic on.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 100)]
        public List<CustomRoutingDestinationConfiguration> DestinationConfigurations { get; set; } = AWSConfigs.InitializeCollections ? new List<CustomRoutingDestinationConfiguration>() : null;

        /// <summary>
        /// Checks to see if the DestinationConfigurations property is set.
        /// </summary>
        internal bool IsSetDestinationConfigurations() => this.DestinationConfigurations != null && (this.DestinationConfigurations.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property EndpointGroupRegion. 
        /// <para>
        /// The Amazon Web Services Region where the endpoint group is located. A listener can
        /// have only one endpoint group in a specific Region.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 255)]
        public string EndpointGroupRegion { get; set; }

        /// <summary>
        /// Checks to see if the EndpointGroupRegion property is set.
        /// </summary>
        internal bool IsSetEndpointGroupRegion() => this.EndpointGroupRegion != null;

        /// <summary>
        /// Gets and sets the property IdempotencyToken. 
        /// <para>
        /// A unique, case-sensitive identifier that you provide to ensure the idempotency—that
        /// is, the uniqueness—of the request.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 255)]
        public string IdempotencyToken { get; set; }

        /// <summary>
        /// Checks to see if the IdempotencyToken property is set.
        /// </summary>
        internal bool IsSetIdempotencyToken() => this.IdempotencyToken != null;

        /// <summary>
        /// Gets and sets the property ListenerArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the listener for a custom routing endpoint.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 255)]
        public string ListenerArn { get; set; }

        /// <summary>
        /// Checks to see if the ListenerArn property is set.
        /// </summary>
        internal bool IsSetListenerArn() => this.ListenerArn != null;
    }
}
