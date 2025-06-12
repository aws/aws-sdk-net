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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
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
        private string _description;
        private string _gatewayLoadBalancerEndpointId;
        private string _networkInterfaceId;
        private string _networkLoadBalancerArn;
        private string _ownerId;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;
        private string _trafficMirrorTargetId;
        private TrafficMirrorTargetType _type;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// Information about the Traffic Mirror target.
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
        /// Gets and sets the property GatewayLoadBalancerEndpointId. 
        /// <para>
        /// The ID of the Gateway Load Balancer endpoint.
        /// </para>
        /// </summary>
        public string GatewayLoadBalancerEndpointId
        {
            get { return this._gatewayLoadBalancerEndpointId; }
            set { this._gatewayLoadBalancerEndpointId = value; }
        }

        // Check to see if GatewayLoadBalancerEndpointId property is set
        internal bool IsSetGatewayLoadBalancerEndpointId()
        {
            return this._gatewayLoadBalancerEndpointId != null;
        }

        /// <summary>
        /// Gets and sets the property NetworkInterfaceId. 
        /// <para>
        /// The network interface ID that is attached to the target.
        /// </para>
        /// </summary>
        public string NetworkInterfaceId
        {
            get { return this._networkInterfaceId; }
            set { this._networkInterfaceId = value; }
        }

        // Check to see if NetworkInterfaceId property is set
        internal bool IsSetNetworkInterfaceId()
        {
            return this._networkInterfaceId != null;
        }

        /// <summary>
        /// Gets and sets the property NetworkLoadBalancerArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Network Load Balancer.
        /// </para>
        /// </summary>
        public string NetworkLoadBalancerArn
        {
            get { return this._networkLoadBalancerArn; }
            set { this._networkLoadBalancerArn = value; }
        }

        // Check to see if NetworkLoadBalancerArn property is set
        internal bool IsSetNetworkLoadBalancerArn()
        {
            return this._networkLoadBalancerArn != null;
        }

        /// <summary>
        /// Gets and sets the property OwnerId. 
        /// <para>
        /// The ID of the account that owns the Traffic Mirror target.
        /// </para>
        /// </summary>
        public string OwnerId
        {
            get { return this._ownerId; }
            set { this._ownerId = value; }
        }

        // Check to see if OwnerId property is set
        internal bool IsSetOwnerId()
        {
            return this._ownerId != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags assigned to the Traffic Mirror target.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TrafficMirrorTargetId. 
        /// <para>
        /// The ID of the Traffic Mirror target.
        /// </para>
        /// </summary>
        public string TrafficMirrorTargetId
        {
            get { return this._trafficMirrorTargetId; }
            set { this._trafficMirrorTargetId = value; }
        }

        // Check to see if TrafficMirrorTargetId property is set
        internal bool IsSetTrafficMirrorTargetId()
        {
            return this._trafficMirrorTargetId != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of Traffic Mirror target.
        /// </para>
        /// </summary>
        public TrafficMirrorTargetType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}