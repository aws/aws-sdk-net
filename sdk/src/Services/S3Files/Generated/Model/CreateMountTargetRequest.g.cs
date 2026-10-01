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

namespace Amazon.S3Files.Model
{
    /// <summary>
    /// Container for the parameters to the CreateMountTarget operation. Creates a mount target
    /// resource as an endpoint for mounting the S3 File System from compute resources in
    /// a specific Availability Zone and VPC. Mount targets provide network access to the
    /// file system.
    /// </summary>
    public partial class CreateMountTargetRequest : AmazonS3FilesRequest
    {
        /// <summary>
        /// Gets and sets the property FileSystemId. 
        /// <para>
        /// The ID or Amazon Resource Name (ARN) of the S3 File System to create the mount target
        /// for.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Max = 128)]
        public string FileSystemId { get; set; }

        /// <summary>
        /// Checks to see if the FileSystemId property is set.
        /// </summary>
        internal bool IsSetFileSystemId() => this.FileSystemId != null;

        /// <summary>
        /// Gets and sets the property IpAddressType. 
        /// <para>
        /// The IP address type for the mount target. If not specified, <c>IPV4_ONLY</c> is used.
        /// The IP address type must match the IP configuration of the specified subnet.
        /// </para>
        /// </summary>
        public IpAddressType IpAddressType { get; set; }

        /// <summary>
        /// Checks to see if the IpAddressType property is set.
        /// </summary>
        internal bool IsSetIpAddressType() => this.IpAddressType != null;

        /// <summary>
        /// Gets and sets the property Ipv4Address. 
        /// <para>
        /// A specific IPv4 address to assign to the mount target. If not specified and the IP
        /// address type supports IPv4, an address is automatically assigned from the subnet's
        /// available IPv4 address range. The address must be within the subnet's CIDR block and
        /// not already in use.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 7, Max = 15)]
        public string Ipv4Address { get; set; }

        /// <summary>
        /// Checks to see if the Ipv4Address property is set.
        /// </summary>
        internal bool IsSetIpv4Address() => this.Ipv4Address != null;

        /// <summary>
        /// Gets and sets the property Ipv6Address. 
        /// <para>
        /// A specific IPv6 address to assign to the mount target. If not specified and the IP
        /// address type supports IPv6, an address is automatically assigned from the subnet's
        /// available IPv6 address range. The address must be within the subnet's IPv6 CIDR block
        /// and not already in use.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 3, Max = 39)]
        public string Ipv6Address { get; set; }

        /// <summary>
        /// Checks to see if the Ipv6Address property is set.
        /// </summary>
        internal bool IsSetIpv6Address() => this.Ipv6Address != null;

        /// <summary>
        /// Gets and sets the property SecurityGroups. 
        /// <para>
        /// An array of VPC security group IDs to associate with the mount target's network interface.
        /// These security groups control network access to the mount target. If not specified,
        /// the default security group for the subnet's VPC is used. All security groups must
        /// belong to the same VPC as the subnet.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 100)]
        public List<string> SecurityGroups { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the SecurityGroups property is set.
        /// </summary>
        internal bool IsSetSecurityGroups() => this.SecurityGroups != null && (this.SecurityGroups.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SubnetId. 
        /// <para>
        /// The ID of the subnet where the mount target will be created. The subnet must be in
        /// the same Amazon Web Services Region as the file system. For file systems with regional
        /// availability, you can create mount targets in any subnet within the Region. The subnet
        /// determines the Availability Zone where the mount target will be located.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 15, Max = 47)]
        public string SubnetId { get; set; }

        /// <summary>
        /// Checks to see if the SubnetId property is set.
        /// </summary>
        internal bool IsSetSubnetId() => this.SubnetId != null;
    }
}
