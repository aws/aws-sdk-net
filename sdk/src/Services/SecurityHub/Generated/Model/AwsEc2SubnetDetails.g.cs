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
    /// Contains information about a subnet in Amazon EC2.
    /// </summary>
    public partial class AwsEc2SubnetDetails
    {
        /// <summary>
        /// Gets and sets the property AssignIpv6AddressOnCreation. 
        /// <para>
        /// Whether to assign an IPV6 address to a network interface that is created in this subnet.
        /// </para>
        /// </summary>
        public bool? AssignIpv6AddressOnCreation { get; set; }

        /// <summary>
        /// Checks to see if the AssignIpv6AddressOnCreation property is set.
        /// </summary>
        internal bool IsSetAssignIpv6AddressOnCreation() => this.AssignIpv6AddressOnCreation.HasValue;

        /// <summary>
        /// Gets and sets the property AvailabilityZone. 
        /// <para>
        /// The Availability Zone for the subnet.
        /// </para>
        /// </summary>
        public string AvailabilityZone { get; set; }

        /// <summary>
        /// Checks to see if the AvailabilityZone property is set.
        /// </summary>
        internal bool IsSetAvailabilityZone() => this.AvailabilityZone != null;

        /// <summary>
        /// Gets and sets the property AvailabilityZoneId. 
        /// <para>
        /// The identifier of the Availability Zone for the subnet.
        /// </para>
        /// </summary>
        public string AvailabilityZoneId { get; set; }

        /// <summary>
        /// Checks to see if the AvailabilityZoneId property is set.
        /// </summary>
        internal bool IsSetAvailabilityZoneId() => this.AvailabilityZoneId != null;

        /// <summary>
        /// Gets and sets the property AvailableIpAddressCount. 
        /// <para>
        /// The number of available IPV4 addresses in the subnet. Does not include addresses for
        /// stopped instances.
        /// </para>
        /// </summary>
        public int? AvailableIpAddressCount { get; set; }

        /// <summary>
        /// Checks to see if the AvailableIpAddressCount property is set.
        /// </summary>
        internal bool IsSetAvailableIpAddressCount() => this.AvailableIpAddressCount.HasValue;

        /// <summary>
        /// Gets and sets the property CidrBlock. 
        /// <para>
        /// The IPV4 CIDR block that is assigned to the subnet.
        /// </para>
        /// </summary>
        public string CidrBlock { get; set; }

        /// <summary>
        /// Checks to see if the CidrBlock property is set.
        /// </summary>
        internal bool IsSetCidrBlock() => this.CidrBlock != null;

        /// <summary>
        /// Gets and sets the property DefaultForAz. 
        /// <para>
        /// Whether this subnet is the default subnet for the Availability Zone.
        /// </para>
        /// </summary>
        public bool? DefaultForAz { get; set; }

        /// <summary>
        /// Checks to see if the DefaultForAz property is set.
        /// </summary>
        internal bool IsSetDefaultForAz() => this.DefaultForAz.HasValue;

        /// <summary>
        /// Gets and sets the property Ipv6CidrBlockAssociationSet. 
        /// <para>
        /// The IPV6 CIDR blocks that are associated with the subnet.
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
        /// Gets and sets the property MapPublicIpOnLaunch. 
        /// <para>
        /// Whether instances in this subnet receive a public IP address.
        /// </para>
        /// </summary>
        public bool? MapPublicIpOnLaunch { get; set; }

        /// <summary>
        /// Checks to see if the MapPublicIpOnLaunch property is set.
        /// </summary>
        internal bool IsSetMapPublicIpOnLaunch() => this.MapPublicIpOnLaunch.HasValue;

        /// <summary>
        /// Gets and sets the property OwnerId. 
        /// <para>
        /// The identifier of the Amazon Web Services account that owns the subnet.
        /// </para>
        /// </summary>
        public string OwnerId { get; set; }

        /// <summary>
        /// Checks to see if the OwnerId property is set.
        /// </summary>
        internal bool IsSetOwnerId() => this.OwnerId != null;

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The current state of the subnet. Valid values are <c>available</c> or <c>pending</c>.
        /// </para>
        /// </summary>
        public string State { get; set; }

        /// <summary>
        /// Checks to see if the State property is set.
        /// </summary>
        internal bool IsSetState() => this.State != null;

        /// <summary>
        /// Gets and sets the property SubnetArn. 
        /// <para>
        /// The ARN of the subnet.
        /// </para>
        /// </summary>
        public string SubnetArn { get; set; }

        /// <summary>
        /// Checks to see if the SubnetArn property is set.
        /// </summary>
        internal bool IsSetSubnetArn() => this.SubnetArn != null;

        /// <summary>
        /// Gets and sets the property SubnetId. 
        /// <para>
        /// The identifier of the subnet.
        /// </para>
        /// </summary>
        public string SubnetId { get; set; }

        /// <summary>
        /// Checks to see if the SubnetId property is set.
        /// </summary>
        internal bool IsSetSubnetId() => this.SubnetId != null;

        /// <summary>
        /// Gets and sets the property VpcId. 
        /// <para>
        /// The identifier of the VPC that contains the subnet.
        /// </para>
        /// </summary>
        public string VpcId { get; set; }

        /// <summary>
        /// Checks to see if the VpcId property is set.
        /// </summary>
        internal bool IsSetVpcId() => this.VpcId != null;
    }
}
