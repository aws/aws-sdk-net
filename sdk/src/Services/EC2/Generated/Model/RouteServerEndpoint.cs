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
    /// Describes a route server endpoint and its properties.
    /// 
    ///  
    /// <para>
    /// A route server endpoint is an Amazon Web Services-managed component inside a subnet
    /// that facilitates <a href="https://en.wikipedia.org/wiki/Border_Gateway_Protocol">BGP
    /// (Border Gateway Protocol)</a> connections between your route server and your BGP peers.
    /// </para>
    /// </summary>
    public partial class RouteServerEndpoint
    {
        private string _eniAddress;
        private string _eniId;
        private string _failureReason;
        private string _routeServerEndpointId;
        private string _routeServerId;
        private RouteServerEndpointState _state;
        private string _subnetId;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;
        private string _vpcId;

        /// <summary>
        /// Gets and sets the property EniAddress. 
        /// <para>
        /// The IP address of the Elastic network interface for the endpoint.
        /// </para>
        /// </summary>
        public string EniAddress
        {
            get { return this._eniAddress; }
            set { this._eniAddress = value; }
        }

        // Check to see if EniAddress property is set
        internal bool IsSetEniAddress()
        {
            return this._eniAddress != null;
        }

        /// <summary>
        /// Gets and sets the property EniId. 
        /// <para>
        /// The ID of the Elastic network interface for the endpoint.
        /// </para>
        /// </summary>
        public string EniId
        {
            get { return this._eniId; }
            set { this._eniId = value; }
        }

        // Check to see if EniId property is set
        internal bool IsSetEniId()
        {
            return this._eniId != null;
        }

        /// <summary>
        /// Gets and sets the property FailureReason. 
        /// <para>
        /// The reason for any failure in endpoint creation or operation.
        /// </para>
        /// </summary>
        public string FailureReason
        {
            get { return this._failureReason; }
            set { this._failureReason = value; }
        }

        // Check to see if FailureReason property is set
        internal bool IsSetFailureReason()
        {
            return this._failureReason != null;
        }

        /// <summary>
        /// Gets and sets the property RouteServerEndpointId. 
        /// <para>
        /// The unique identifier of the route server endpoint.
        /// </para>
        /// </summary>
        public string RouteServerEndpointId
        {
            get { return this._routeServerEndpointId; }
            set { this._routeServerEndpointId = value; }
        }

        // Check to see if RouteServerEndpointId property is set
        internal bool IsSetRouteServerEndpointId()
        {
            return this._routeServerEndpointId != null;
        }

        /// <summary>
        /// Gets and sets the property RouteServerId. 
        /// <para>
        /// The ID of the route server associated with this endpoint.
        /// </para>
        /// </summary>
        public string RouteServerId
        {
            get { return this._routeServerId; }
            set { this._routeServerId = value; }
        }

        // Check to see if RouteServerId property is set
        internal bool IsSetRouteServerId()
        {
            return this._routeServerId != null;
        }

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The current state of the route server endpoint.
        /// </para>
        /// </summary>
        public RouteServerEndpointState State
        {
            get { return this._state; }
            set { this._state = value; }
        }

        // Check to see if State property is set
        internal bool IsSetState()
        {
            return this._state != null;
        }

        /// <summary>
        /// Gets and sets the property SubnetId. 
        /// <para>
        /// The ID of the subnet to place the route server endpoint into.
        /// </para>
        /// </summary>
        public string SubnetId
        {
            get { return this._subnetId; }
            set { this._subnetId = value; }
        }

        // Check to see if SubnetId property is set
        internal bool IsSetSubnetId()
        {
            return this._subnetId != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Any tags assigned to the route server endpoint.
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
        /// Gets and sets the property VpcId. 
        /// <para>
        /// The ID of the VPC containing the endpoint.
        /// </para>
        /// </summary>
        public string VpcId
        {
            get { return this._vpcId; }
            set { this._vpcId = value; }
        }

        // Check to see if VpcId property is set
        internal bool IsSetVpcId()
        {
            return this._vpcId != null;
        }

    }
}