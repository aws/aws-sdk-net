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
    /// Details about an EC2 VPC.
    /// </summary>
    public partial class AwsEc2VpcDetails
    {
        /// <summary>
        /// Gets and sets the property CidrBlockAssociationSet. 
        /// <para>
        /// Information about the IPv4 CIDR blocks associated with the VPC.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<CidrBlockAssociation> CidrBlockAssociationSet { get; set; } = AWSConfigs.InitializeCollections ? new List<CidrBlockAssociation>() : null;

        /// <summary>
        /// Checks to see if the CidrBlockAssociationSet property is set.
        /// </summary>
        internal bool IsSetCidrBlockAssociationSet() => this.CidrBlockAssociationSet != null && (this.CidrBlockAssociationSet.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property DhcpOptionsId. 
        /// <para>
        /// The identifier of the set of Dynamic Host Configuration Protocol (DHCP) options that
        /// are associated with the VPC. If the default options are associated with the VPC, then
        /// this is default.
        /// </para>
        /// </summary>
        public string DhcpOptionsId { get; set; }

        /// <summary>
        /// Checks to see if the DhcpOptionsId property is set.
        /// </summary>
        internal bool IsSetDhcpOptionsId() => this.DhcpOptionsId != null;

        /// <summary>
        /// Gets and sets the property Ipv6CidrBlockAssociationSet. 
        /// <para>
        /// Information about the IPv6 CIDR blocks associated with the VPC.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Ipv6CidrBlockAssociation> Ipv6CidrBlockAssociationSet { get; set; } = AWSConfigs.InitializeCollections ? new List<Ipv6CidrBlockAssociation>() : null;

        /// <summary>
        /// Checks to see if the Ipv6CidrBlockAssociationSet property is set.
        /// </summary>
        internal bool IsSetIpv6CidrBlockAssociationSet() => this.Ipv6CidrBlockAssociationSet != null && (this.Ipv6CidrBlockAssociationSet.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The current state of the VPC. Valid values are <c>available</c> or <c>pending</c>.
        /// </para>
        /// </summary>
        public string State { get; set; }

        /// <summary>
        /// Checks to see if the State property is set.
        /// </summary>
        internal bool IsSetState() => this.State != null;
    }
}
