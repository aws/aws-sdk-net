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
        /// <summary>
        /// Gets and sets the property EniAddress. 
        /// <para>
        /// The IP address of the Elastic network interface for the endpoint.
        /// </para>
        /// </summary>
        public string EniAddress { get; set; }

        /// <summary>
        /// Checks to see if the EniAddress property is set.
        /// </summary>
        internal bool IsSetEniAddress() => this.EniAddress != null;

        /// <summary>
        /// Gets and sets the property EniId. 
        /// <para>
        /// The ID of the Elastic network interface for the endpoint.
        /// </para>
        /// </summary>
        public string EniId { get; set; }

        /// <summary>
        /// Checks to see if the EniId property is set.
        /// </summary>
        internal bool IsSetEniId() => this.EniId != null;

        /// <summary>
        /// Gets and sets the property FailureReason. 
        /// <para>
        /// The reason for any failure in endpoint creation or operation.
        /// </para>
        /// </summary>
        public string FailureReason { get; set; }

        /// <summary>
        /// Checks to see if the FailureReason property is set.
        /// </summary>
        internal bool IsSetFailureReason() => this.FailureReason != null;

        /// <summary>
        /// Gets and sets the property RouteServerEndpointId. 
        /// <para>
        /// The unique identifier of the route server endpoint.
        /// </para>
        /// </summary>
        public string RouteServerEndpointId { get; set; }

        /// <summary>
        /// Checks to see if the RouteServerEndpointId property is set.
        /// </summary>
        internal bool IsSetRouteServerEndpointId() => this.RouteServerEndpointId != null;

        /// <summary>
        /// Gets and sets the property RouteServerId. 
        /// <para>
        /// The ID of the route server associated with this endpoint.
        /// </para>
        /// </summary>
        public string RouteServerId { get; set; }

        /// <summary>
        /// Checks to see if the RouteServerId property is set.
        /// </summary>
        internal bool IsSetRouteServerId() => this.RouteServerId != null;

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The current state of the route server endpoint.
        /// </para>
        /// </summary>
        public RouteServerEndpointState State { get; set; }

        /// <summary>
        /// Checks to see if the State property is set.
        /// </summary>
        internal bool IsSetState() => this.State != null;

        /// <summary>
        /// Gets and sets the property SubnetId. 
        /// <para>
        /// The ID of the subnet to place the route server endpoint into.
        /// </para>
        /// </summary>
        public string SubnetId { get; set; }

        /// <summary>
        /// Checks to see if the SubnetId property is set.
        /// </summary>
        internal bool IsSetSubnetId() => this.SubnetId != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Any tags assigned to the route server endpoint.
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
        /// Gets and sets the property VpcId. 
        /// <para>
        /// The ID of the VPC containing the endpoint.
        /// </para>
        /// </summary>
        public string VpcId { get; set; }

        /// <summary>
        /// Checks to see if the VpcId property is set.
        /// </summary>
        internal bool IsSetVpcId() => this.VpcId != null;
    }
}
