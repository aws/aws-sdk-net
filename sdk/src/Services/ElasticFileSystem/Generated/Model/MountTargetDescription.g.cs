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

namespace Amazon.ElasticFileSystem.Model
{
    /// <summary>
    /// Provides a description of a mount target.
    /// </summary>
    public partial class MountTargetDescription
    {
        /// <summary>
        /// Gets and sets the property AvailabilityZoneId. 
        /// <para>
        /// The unique and consistent identifier of the Availability Zone that the mount target
        /// resides in. For example, <c>use1-az1</c> is an AZ ID for the us-east-1 Region and
        /// it has the same location in every Amazon Web Services account.
        /// </para>
        /// </summary>
        public string AvailabilityZoneId { get; set; }

        /// <summary>
        /// Checks to see if the AvailabilityZoneId property is set.
        /// </summary>
        internal bool IsSetAvailabilityZoneId() => this.AvailabilityZoneId != null;

        /// <summary>
        /// Gets and sets the property AvailabilityZoneName. 
        /// <para>
        /// The name of the Availability Zone in which the mount target is located. Availability
        /// Zones are independently mapped to names for each Amazon Web Services account. For
        /// example, the Availability Zone <c>us-east-1a</c> for your Amazon Web Services account
        /// might not be the same location as <c>us-east-1a</c> for another Amazon Web Services
        /// account.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string AvailabilityZoneName { get; set; }

        /// <summary>
        /// Checks to see if the AvailabilityZoneName property is set.
        /// </summary>
        internal bool IsSetAvailabilityZoneName() => this.AvailabilityZoneName != null;

        /// <summary>
        /// Gets and sets the property FileSystemId. 
        /// <para>
        /// The ID of the file system for which the mount target is intended.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 128)]
        public string FileSystemId { get; set; }

        /// <summary>
        /// Checks to see if the FileSystemId property is set.
        /// </summary>
        internal bool IsSetFileSystemId() => this.FileSystemId != null;

        /// <summary>
        /// Gets and sets the property IpAddress. 
        /// <para>
        /// Address at which the file system can be mounted by using the mount target.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 7, Max = 15)]
        public string IpAddress { get; set; }

        /// <summary>
        /// Checks to see if the IpAddress property is set.
        /// </summary>
        internal bool IsSetIpAddress() => this.IpAddress != null;

        /// <summary>
        /// Gets and sets the property Ipv6Address. 
        /// <para>
        /// The IPv6 address for the mount target.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 3, Max = 39)]
        public string Ipv6Address { get; set; }

        /// <summary>
        /// Checks to see if the Ipv6Address property is set.
        /// </summary>
        internal bool IsSetIpv6Address() => this.Ipv6Address != null;

        /// <summary>
        /// Gets and sets the property LifeCycleState. 
        /// <para>
        /// Lifecycle state of the mount target.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public LifeCycleState LifeCycleState { get; set; }

        /// <summary>
        /// Checks to see if the LifeCycleState property is set.
        /// </summary>
        internal bool IsSetLifeCycleState() => this.LifeCycleState != null;

        /// <summary>
        /// Gets and sets the property MountTargetId. 
        /// <para>
        /// System-assigned mount target ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 13, Max = 45)]
        public string MountTargetId { get; set; }

        /// <summary>
        /// Checks to see if the MountTargetId property is set.
        /// </summary>
        internal bool IsSetMountTargetId() => this.MountTargetId != null;

        /// <summary>
        /// Gets and sets the property NetworkInterfaceId. 
        /// <para>
        /// The ID of the network interface that Amazon EFS created when it created the mount
        /// target.
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
        /// Amazon Web Services account ID that owns the resource.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 14)]
        public string OwnerId { get; set; }

        /// <summary>
        /// Checks to see if the OwnerId property is set.
        /// </summary>
        internal bool IsSetOwnerId() => this.OwnerId != null;

        /// <summary>
        /// Gets and sets the property SubnetId. 
        /// <para>
        /// The ID of the mount target's subnet.
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
        /// The virtual private cloud (VPC) ID that the mount target is configured in.
        /// </para>
        /// </summary>
        public string VpcId { get; set; }

        /// <summary>
        /// Checks to see if the VpcId property is set.
        /// </summary>
        internal bool IsSetVpcId() => this.VpcId != null;
    }
}
