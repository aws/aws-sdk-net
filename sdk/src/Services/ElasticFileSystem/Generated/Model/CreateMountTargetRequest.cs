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
    /// You can create only one mount target for an EFS file system using One Zone storage
    /// classes. You must create that mount target in the same Availability Zone in which
    /// the file system is located. Use the <code>AvailabilityZoneName</code> and <code>AvailabiltyZoneId</code>
    /// properties in the <a>DescribeFileSystems</a> response object to get this information.
    /// Use the <code>subnetId</code> associated with the file system's Availability Zone
    /// when creating the mount target.
    /// </para>
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/efs/latest/ug/how-it-works.html">Amazon
    /// EFS: How it Works</a>. 
    /// </para>
    ///  
    /// <para>
    /// To create a mount target for a file system, the file system's lifecycle state must
    /// be <code>available</code>. For more information, see <a>DescribeFileSystems</a>.
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
    /// After creating the mount target, Amazon EFS returns a response that includes, a <code>MountTargetId</code>
    /// and an <code>IpAddress</code>. You use this IP address when mounting the file system
    /// in an EC2 instance. You can also use the mount target's DNS name when mounting the
    /// file system. The EC2 instance on which you mount the file system by using the mount
    /// target can resolve the mount target's DNS name to its IP address. For more information,
    /// see <a href="https://docs.aws.amazon.com/efs/latest/ug/how-it-works.html#how-it-works-implementation">How
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
    /// If the request provides an <code>IpAddress</code>, Amazon EFS assigns that IP address
    /// to the network interface. Otherwise, Amazon EFS assigns a free address in the subnet
    /// (in the same way that the Amazon EC2 <code>CreateNetworkInterface</code> call does
    /// when a request does not specify a primary private IP address).
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// If the request provides <code>SecurityGroups</code>, this network interface is associated
    /// with those security groups. Otherwise, it belongs to the default security group for
    /// the subnet's VPC.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Assigns the description <code>Mount target <i>fsmt-id</i> for file system <i>fs-id</i>
    /// </code> where <code> <i>fsmt-id</i> </code> is the mount target ID, and <code> <i>fs-id</i>
    /// </code> is the <code>FileSystemId</code>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Sets the <code>requesterManaged</code> property of the network interface to <code>true</code>,
    /// and the <code>requesterId</code> value to <code>EFS</code>.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// Each Amazon EFS mount target has one corresponding requester-managed EC2 network interface.
    /// After the network interface is created, Amazon EFS sets the <code>NetworkInterfaceId</code>
    /// field in the mount target's description to the network interface ID, and the <code>IpAddress</code>
    /// field to its address. If network interface creation fails, the entire <code>CreateMountTarget</code>
    /// operation fails.
    /// </para>
    ///  </li> </ul> <note> 
    /// <para>
    /// The <code>CreateMountTarget</code> call returns only after creating the network interface,
    /// but while the mount target state is still <code>creating</code>, you can check the
    /// mount target creation status by calling the <a>DescribeMountTargets</a> operation,
    /// which among other things returns the mount target state.
    /// </para>
    ///  </note> 
    /// <para>
    /// We recommend that you create a mount target in each of the Availability Zones. There
    /// are cost considerations for using a file system in an Availability Zone through a
    /// mount target created in another Availability Zone. For more information, see <a href="http://aws.amazon.com/efs/">Amazon
    /// EFS</a>. In addition, by always using a mount target local to the instance's Availability
    /// Zone, you eliminate a partial failure scenario. If the Availability Zone in which
    /// your mount target is created goes down, then you can't access your file system through
    /// that mount target. 
    /// </para>
    ///  
    /// <para>
    /// This operation requires permissions for the following action on the file system:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <code>elasticfilesystem:CreateMountTarget</code> 
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// This operation also requires permissions for the following Amazon EC2 actions:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <code>ec2:DescribeSubnets</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>ec2:DescribeNetworkInterfaces</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>ec2:CreateNetworkInterface</code> 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class CreateMountTargetRequest : AmazonElasticFileSystemRequest
    {
        private string _fileSystemId;
        private string _ipAddress;
        private List<string> _securityGroups = new List<string>();
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
        /// Valid IPv4 address within the address range of the specified subnet.
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
        /// Gets and sets the property SecurityGroups. 
        /// <para>
        /// Up to five VPC security group IDs, of the form <code>sg-xxxxxxxx</code>. These must
        /// be for the same VPC as subnet specified.
        /// </para>
        /// </summary>
        [AWSProperty(Max=5)]
        public List<string> SecurityGroups
        {
            get { return this._securityGroups; }
            set { this._securityGroups = value; }
        }

        // Check to see if SecurityGroups property is set
        internal bool IsSetSecurityGroups()
        {
            return this._securityGroups != null && this._securityGroups.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property SubnetId. 
        /// <para>
        /// The ID of the subnet to add the mount target in. For file systems that use One Zone
        /// storage classes, use the subnet that is associated with the file system's Availability
        /// Zone.
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