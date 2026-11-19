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

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Describes a Traffic Mirror target.
    /// </summary>
    public partial class TrafficMirrorTarget
    {
        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// Information about the Traffic Mirror target.
        /// </para>
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property GatewayLoadBalancerEndpointId. 
        /// <para>
        /// The ID of the Gateway Load Balancer endpoint.
        /// </para>
        /// </summary>
        public string GatewayLoadBalancerEndpointId { get; set; }

        /// <summary>
        /// Checks to see if the GatewayLoadBalancerEndpointId property is set.
        /// </summary>
        internal bool IsSetGatewayLoadBalancerEndpointId() => this.GatewayLoadBalancerEndpointId != null;

        /// <summary>
        /// Gets and sets the property NetworkInterfaceId. 
        /// <para>
        /// The network interface ID that is attached to the target.
        /// </para>
        /// </summary>
        public string NetworkInterfaceId { get; set; }

        /// <summary>
        /// Checks to see if the NetworkInterfaceId property is set.
        /// </summary>
        internal bool IsSetNetworkInterfaceId() => this.NetworkInterfaceId != null;

        /// <summary>
        /// Gets and sets the property NetworkLoadBalancerArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Network Load Balancer.
        /// </para>
        /// </summary>
        public string NetworkLoadBalancerArn { get; set; }

        /// <summary>
        /// Checks to see if the NetworkLoadBalancerArn property is set.
        /// </summary>
        internal bool IsSetNetworkLoadBalancerArn() => this.NetworkLoadBalancerArn != null;

        /// <summary>
        /// Gets and sets the property OwnerId. 
        /// <para>
        /// The ID of the account that owns the Traffic Mirror target.
        /// </para>
        /// </summary>
        public string OwnerId { get; set; }

        /// <summary>
        /// Checks to see if the OwnerId property is set.
        /// </summary>
        internal bool IsSetOwnerId() => this.OwnerId != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags assigned to the Traffic Mirror target.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TrafficMirrorTargetId. 
        /// <para>
        /// The ID of the Traffic Mirror target.
        /// </para>
        /// </summary>
        public string TrafficMirrorTargetId { get; set; }

        /// <summary>
        /// Checks to see if the TrafficMirrorTargetId property is set.
        /// </summary>
        internal bool IsSetTrafficMirrorTargetId() => this.TrafficMirrorTargetId != null;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of Traffic Mirror target.
        /// </para>
        /// </summary>
        public TrafficMirrorTargetType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;
    }
}
