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

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Describes a VPC in a VPC peering connection.
    /// </summary>
    public partial class AwsEc2VpcPeeringConnectionVpcInfoDetails
    {
        /// <summary>
        /// Gets and sets the property CidrBlock. 
        /// <para>
        /// The IPv4 CIDR block for the VPC. 
        /// </para>
        /// </summary>
        public string CidrBlock { get; set; }

        /// <summary>
        /// Checks to see if the CidrBlock property is set.
        /// </summary>
        internal bool IsSetCidrBlock() => this.CidrBlock != null;

        /// <summary>
        /// Gets and sets the property CidrBlockSet. 
        /// <para>
        /// Information about the IPv4 CIDR blocks for the VPC. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<VpcInfoCidrBlockSetDetails> CidrBlockSet { get; set; } = AWSConfigs.InitializeCollections ? new List<VpcInfoCidrBlockSetDetails>() : null;

        /// <summary>
        /// Checks to see if the CidrBlockSet property is set.
        /// </summary>
        internal bool IsSetCidrBlockSet() => this.CidrBlockSet != null && (this.CidrBlockSet.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Ipv6CidrBlockSet. 
        /// <para>
        /// The IPv6 CIDR block for the VPC. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<VpcInfoIpv6CidrBlockSetDetails> Ipv6CidrBlockSet { get; set; } = AWSConfigs.InitializeCollections ? new List<VpcInfoIpv6CidrBlockSetDetails>() : null;

        /// <summary>
        /// Checks to see if the Ipv6CidrBlockSet property is set.
        /// </summary>
        internal bool IsSetIpv6CidrBlockSet() => this.Ipv6CidrBlockSet != null && (this.Ipv6CidrBlockSet.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property OwnerId. 
        /// <para>
        /// The ID of the Amazon Web Services account that owns the VPC. 
        /// </para>
        /// </summary>
        public string OwnerId { get; set; }

        /// <summary>
        /// Checks to see if the OwnerId property is set.
        /// </summary>
        internal bool IsSetOwnerId() => this.OwnerId != null;

        /// <summary>
        /// Gets and sets the property PeeringOptions. 
        /// <para>
        /// Information about the VPC peering connection options for the accepter or requester
        /// VPC. 
        /// </para>
        /// </summary>
        public VpcInfoPeeringOptionsDetails PeeringOptions { get; set; }

        /// <summary>
        /// Checks to see if the PeeringOptions property is set.
        /// </summary>
        internal bool IsSetPeeringOptions() => this.PeeringOptions != null;

        /// <summary>
        /// Gets and sets the property Region. 
        /// <para>
        /// The Amazon Web Services Region in which the VPC is located. 
        /// </para>
        /// </summary>
        public string Region { get; set; }

        /// <summary>
        /// Checks to see if the Region property is set.
        /// </summary>
        internal bool IsSetRegion() => this.Region != null;

        /// <summary>
        /// Gets and sets the property VpcId. 
        /// <para>
        /// The ID of the VPC. 
        /// </para>
        /// </summary>
        public string VpcId { get; set; }

        /// <summary>
        /// Checks to see if the VpcId property is set.
        /// </summary>
        internal bool IsSetVpcId() => this.VpcId != null;
    }
}
