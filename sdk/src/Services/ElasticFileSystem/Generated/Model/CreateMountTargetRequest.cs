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
 * Do not modify this file. This file is generated from the elasticfilesystem-2015-02-01.normal.json service model.
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
    /// Container for the parameters to the CreateMountTarget operation.
    /// Creates a mount target for a file system. You can then mount the file system on EC2
    /// instances by using the mount target.
    /// 
    ///  
    /// <para>
    /// You can create one mount target in each Availability Zone in your VPC. All EC2 instances
    /// in a VPC within a given Availability Zone share a single mount target for a given
    /// file system. If you have multiple subnets in an Availability Zone, you create a mount
    /// target in one of the subnets. EC2 instances do not need to be in the same subnet as
    /// the mount target in order to access their file system.
    /// </para>
    ///  
    /// <para>
    /// You can create only one mount target for a One Zone file system. You must create that
    /// mount target in the same Availability Zone in which the file system is located. Use
    /// the <c>AvailabilityZoneName</c> and <c>AvailabiltyZoneId</c> properties in the <a>DescribeFileSystems</a>
    /// response object to get this information. Use the <c>subnetId</c> associated with the
    /// file system's Availability Zone when creating the mount target.
    /// </para>
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/efs/latest/ug/how-it-works.html">Amazon
    /// EFS: How it Works</a>. 
    /// </para>
    ///  
    /// <para>
    /// To create a mount target for a file system, the file system's lifecycle state must
    /// be <c>available</c>. For more information, see <a>DescribeFileSystems</a>.
    /// </para>
    ///  
    /// <para>
    /// In the request, provide the following:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// The file system ID for which you are creating the mount target.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// A subnet ID, which determines the following:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// The VPC in which Amazon EFS creates the mount target
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The Availability Zone in which Amazon EFS creates the mount target
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The IP address range from which Amazon EFS selects the IP address of the mount target
    /// (if you don't specify an IP address in the request)
    /// </para>
    ///  </li> </ul> </li> </ul> 
    /// <para>
    /// After creating the mount target, Amazon EFS returns a response that includes, a <c>MountTargetId</c>
    /// and an <c>IpAddress</c>. You use this IP address when mounting the file system in
    /// an EC2 instance. You can also use the mount target's DNS name when mounting the file
    /// system. The EC2 instance on which you mount the file system by using the mount target
    /// can resolve the mount target's DNS name to its IP address. For more information, see
    /// <a href="https://docs.aws.amazon.com/efs/latest/ug/how-it-works.html#how-it-works-implementation">How
    /// it Works: Implementation Overview</a>. 
    /// </para>
    ///  
    /// <para>
    /// Note that you can create mount targets for a file system in only one VPC, and there
    /// can be only one mount target per Availability Zone. That is, if the file system already
    /// has one or more mount targets created for it, the subnet specified in the request
    /// to add another mount target must meet the following requirements:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Must belong to the same VPC as the subnets of the existing mount targets
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Must not be in the same Availability Zone as any of the subnets of the existing mount
    /// targets
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// If the request satisfies the requirements, Amazon EFS does the following:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Creates a new mount target in the specified subnet.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Also creates a new network interface in the subnet as follows:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// If the request provides an <c>IpAddress</c>, Amazon EFS assigns that IP address to
    /// the network interface. Otherwise, Amazon EFS assigns a free address in the subnet
    /// (in the same way that the Amazon EC2 <c>CreateNetworkInterface</c> call does when
    /// a request does not specify a primary private IP address).
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// If the request provides <c>SecurityGroups</c>, this network interface is associated
    /// with those security groups. Otherwise, it belongs to the default security group for
    /// the subnet's VPC.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Assigns the description <c>Mount target <i>fsmt-id</i> for file system <i>fs-id</i>
    /// </c> where <c> <i>fsmt-id</i> </c> is the mount target ID, and <c> <i>fs-id</i> </c>
    /// is the <c>FileSystemId</c>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Sets the <c>requesterManaged</c> property of the network interface to <c>true</c>,
    /// and the <c>requesterId</c> value to <c>EFS</c>.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// Each Amazon EFS mount target has one corresponding requester-managed EC2 network interface.
    /// After the network interface is created, Amazon EFS sets the <c>NetworkInterfaceId</c>
    /// field in the mount target's description to the network interface ID, and the <c>IpAddress</c>
    /// field to its address. If network interface creation fails, the entire <c>CreateMountTarget</c>
    /// operation fails.
    /// </para>
    ///  </li> </ul> <note> 
    /// <para>
    /// The <c>CreateMountTarget</c> call returns only after creating the network interface,
    /// but while the mount target state is still <c>creating</c>, you can check the mount
    /// target creation status by calling the <a>DescribeMountTargets</a> operation, which
    /// among other things returns the mount target state.
    /// </para>
    ///  </note> 
    /// <para>
    /// We recommend that you create a mount target in each of the Availability Zones. There
    /// are cost considerations for using a file system in an Availability Zone through a
    /// mount target created in another Availability Zone. For more information, see <a href="http://aws.amazon.com/efs/pricing/">Amazon
    /// EFS pricing</a>. In addition, by always using a mount target local to the instance's
    /// Availability Zone, you eliminate a partial failure scenario. If the Availability Zone
    /// in which your mount target is created goes down, then you can't access your file system
    /// through that mount target. 
    /// </para>
    ///  
    /// <para>
    /// This operation requires permissions for the following action on the file system:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <c>elasticfilesystem:CreateMountTarget</c> 
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// This operation also requires permissions for the following Amazon EC2 actions:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <c>ec2:DescribeSubnets</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>ec2:DescribeNetworkInterfaces</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>ec2:CreateNetworkInterface</c> 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class CreateMountTargetRequest : AmazonElasticFileSystemRequest
    {
        private string _fileSystemId;
        private string _ipAddress;
        private IpAddressType _ipAddressType;
        private string _ipv6Address;
        private List<string> _securityGroups = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _subnetId;

        /// <summary>
        /// Gets and sets the property FileSystemId. 
        /// <para>
        /// The ID of the file system for which to create the mount target.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=128)]
        public string FileSystemId
        {
            get { return this._fileSystemId; }
            set { this._fileSystemId = value; }
        }

        // Check to see if FileSystemId property is set
        internal bool IsSetFileSystemId()
        {
            return this._fileSystemId != null;
        }

        /// <summary>
        /// Gets and sets the property IpAddress. 
        /// <para>
        /// If the IP address type for the mount target is IPv4, then specify the IPv4 address
        /// within the address range of the specified subnet.
        /// </para>
        /// </summary>
        [AWSProperty(Min=7, Max=15)]
        public string IpAddress
        {
            get { return this._ipAddress; }
            set { this._ipAddress = value; }
        }

        // Check to see if IpAddress property is set
        internal bool IsSetIpAddress()
        {
            return this._ipAddress != null;
        }

        /// <summary>
        /// Gets and sets the property IpAddressType. 
        /// <para>
        /// Specify the type of IP address of the mount target you are creating. Options are IPv4,
        /// dual stack, or IPv6. If you don’t specify an IpAddressType, then IPv4 is used.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// IPV4_ONLY – Create mount target with IPv4 only subnet or dual-stack subnet.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// DUAL_STACK – Create mount target with dual-stack subnet.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// IPV6_ONLY – Create mount target with IPv6 only subnet.
        /// </para>
        ///  </li> </ul> <note> 
        /// <para>
        /// Creating IPv6 mount target only ENI in dual-stack subnet is not supported.
        /// </para>
        ///  </note>
        /// </summary>
        public IpAddressType IpAddressType
        {
            get { return this._ipAddressType; }
            set { this._ipAddressType = value; }
        }

        // Check to see if IpAddressType property is set
        internal bool IsSetIpAddressType()
        {
            return this._ipAddressType != null;
        }

        /// <summary>
        /// Gets and sets the property Ipv6Address. 
        /// <para>
        /// If the IP address type for the mount target is IPv6, then specify the IPv6 address
        /// within the address range of the specified subnet.
        /// </para>
        /// </summary>
        [AWSProperty(Min=3, Max=39)]
        public string Ipv6Address
        {
            get { return this._ipv6Address; }
            set { this._ipv6Address = value; }
        }

        // Check to see if Ipv6Address property is set
        internal bool IsSetIpv6Address()
        {
            return this._ipv6Address != null;
        }

        /// <summary>
        /// Gets and sets the property SecurityGroups. 
        /// <para>
        /// VPC security group IDs, of the form <c>sg-xxxxxxxx</c>. These must be for the same
        /// VPC as the subnet specified. The maximum number of security groups depends on account
        /// quota. For more information, see <a href="https://docs.aws.amazon.com/vpc/latest/userguide/amazon-vpc-limits.html">Amazon
        /// VPC Quotas</a> in the <i>Amazon VPC User Guide</i> (see the <b>Security Groups</b>
        /// table). 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max=100)]
        public List<string> SecurityGroups
        {
            get { return this._securityGroups; }
            set { this._securityGroups = value; }
        }

        // Check to see if SecurityGroups property is set
        internal bool IsSetSecurityGroups()
        {
            return this._securityGroups != null && (this._securityGroups.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SubnetId. 
        /// <para>
        /// The ID of the subnet to add the mount target in. For One Zone file systems, use the
        /// subnet that is associated with the file system's Availability Zone.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=15, Max=47)]
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

    }
}