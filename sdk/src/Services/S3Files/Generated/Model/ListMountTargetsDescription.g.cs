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
    /// Contains information about a mount target returned in list operations.
    /// </summary>
    public partial class ListMountTargetsDescription
    {
        /// <summary>
        /// Gets and sets the property AvailabilityZoneId. 
        /// <para>
        /// The Availability Zone ID where the mount target is located.
        /// </para>
        /// </summary>
        public string AvailabilityZoneId { get; set; }

        /// <summary>
        /// Checks to see if the AvailabilityZoneId property is set.
        /// </summary>
        internal bool IsSetAvailabilityZoneId() => this.AvailabilityZoneId != null;

        /// <summary>
        /// Gets and sets the property FileSystemId. 
        /// <para>
        /// The ID of the S3 File System.
        /// </para>
        /// </summary>
        [AWSProperty(Max = 128)]
        public string FileSystemId { get; set; }

        /// <summary>
        /// Checks to see if the FileSystemId property is set.
        /// </summary>
        internal bool IsSetFileSystemId() => this.FileSystemId != null;

        /// <summary>
        /// Gets and sets the property Ipv4Address. 
        /// <para>
        /// The IPv4 address of the mount target.
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
        /// The IPv6 address of the mount target.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 3, Max = 39)]
        public string Ipv6Address { get; set; }

        /// <summary>
        /// Checks to see if the Ipv6Address property is set.
        /// </summary>
        internal bool IsSetIpv6Address() => this.Ipv6Address != null;

        /// <summary>
        /// Gets and sets the property MountTargetId. 
        /// <para>
        /// The ID of the mount target.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 22, Max = 45)]
        public string MountTargetId { get; set; }

        /// <summary>
        /// Checks to see if the MountTargetId property is set.
        /// </summary>
        internal bool IsSetMountTargetId() => this.MountTargetId != null;

        /// <summary>
        /// Gets and sets the property NetworkInterfaceId. 
        /// <para>
        /// The ID of the network interface associated with the mount target.
        /// </para>
        /// </summary>
        public string NetworkInterfaceId { get; set; }

        /// <summary>
        /// Checks to see if the NetworkInterfaceId property is set.
        /// </summary>
        internal bool IsSetNetworkInterfaceId() => this.NetworkInterfaceId != null;

        /// <summary>
        /// Gets and sets the property OwnerId. 
        /// <para>
        /// The Amazon Web Services account ID of the mount target owner.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Max = 12)]
        public string OwnerId { get; set; }

        /// <summary>
        /// Checks to see if the OwnerId property is set.
        /// </summary>
        internal bool IsSetOwnerId() => this.OwnerId != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the mount target.
        /// </para>
        /// </summary>
        public LifeCycleState Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property StatusMessage. 
        /// <para>
        /// Additional information about the mount target status.
        /// </para>
        /// </summary>
        public string StatusMessage { get; set; }

        /// <summary>
        /// Checks to see if the StatusMessage property is set.
        /// </summary>
        internal bool IsSetStatusMessage() => this.StatusMessage != null;

        /// <summary>
        /// Gets and sets the property SubnetId. 
        /// <para>
        /// The ID of the subnet where the mount target is located.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 15, Max = 47)]
        public string SubnetId { get; set; }

        /// <summary>
        /// Checks to see if the SubnetId property is set.
        /// </summary>
        internal bool IsSetSubnetId() => this.SubnetId != null;

        /// <summary>
        /// Gets and sets the property VpcId. 
        /// <para>
        /// The ID of the VPC where the mount target is located.
        /// </para>
        /// </summary>
        public string VpcId { get; set; }

        /// <summary>
        /// Checks to see if the VpcId property is set.
        /// </summary>
        internal bool IsSetVpcId() => this.VpcId != null;
    }
}
