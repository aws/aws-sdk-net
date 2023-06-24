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

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the CreateSubnet operation.
    /// Creates a subnet in the specified VPC. For an IPv4 only subnet, specify an IPv4 CIDR
    /// block. If the VPC has an IPv6 CIDR block, you can create an IPv6 only subnet or a
    /// dual stack subnet instead. For an IPv6 only subnet, specify an IPv6 CIDR block. For
    /// a dual stack subnet, specify both an IPv4 CIDR block and an IPv6 CIDR block.
    /// 
    ///  
    /// <para>
    /// A subnet CIDR block must not overlap the CIDR block of an existing subnet in the VPC.
    /// After you create a subnet, you can't change its CIDR block.
    /// </para>
    ///  
    /// <para>
    /// The allowed size for an IPv4 subnet is between a /28 netmask (16 IP addresses) and
    /// a /16 netmask (65,536 IP addresses). Amazon Web Services reserves both the first four
    /// and the last IPv4 address in each subnet's CIDR block. They're not available for your
    /// use.
    /// </para>
    ///  
    /// <para>
    /// If you've associated an IPv6 CIDR block with your VPC, you can associate an IPv6 CIDR
    /// block with a subnet when you create it. The allowed block size for an IPv6 subnet
    /// is a /64 netmask.
    /// </para>
    ///  
    /// <para>
    /// If you add more than one subnet to a VPC, they're set up in a star topology with a
    /// logical router in the middle.
    /// </para>
    ///  
    /// <para>
    /// When you stop an instance in a subnet, it retains its private IPv4 address. It's therefore
    /// possible to have a subnet with no running instances (they're all stopped), but no
    /// remaining IP addresses available.
    /// </para>
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/vpc/latest/userguide/configure-subnets.html">Subnets</a>
    /// in the <i>Amazon Virtual Private Cloud User Guide</i>.
    /// </para>
    /// </summary>
    public partial class CreateSubnetRequest : AmazonEC2Request
    {
        private string _availabilityZone;
        private string _availabilityZoneId;
        private string _cidrBlock;
        private string _ipv6CidrBlock;
        private bool? _ipv6Native;
        private string _outpostArn;
        private List<TagSpecification> _tagSpecifications = new List<TagSpecification>();
        private string _vpcId;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public CreateSubnetRequest() { }

        /// <summary>
        /// Instantiates CreateSubnetRequest with the parameterized properties
        /// </summary>
        /// <param name="vpcId">The ID of the VPC.</param>
        /// <param name="cidrBlock">The IPv4 network range for the subnet, in CIDR notation. For example, <code>10.0.0.0/24</code>. We modify the specified CIDR block to its canonical form; for example, if you specify <code>100.68.0.18/18</code>, we modify it to <code>100.68.0.0/18</code>. This parameter is not supported for an IPv6 only subnet.</param>
        public CreateSubnetRequest(string vpcId, string cidrBlock)
        {
            _vpcId = vpcId;
            _cidrBlock = cidrBlock;
        }

        /// <summary>
        /// Gets and sets the property AvailabilityZone. 
        /// <para>
        /// The Availability Zone or Local Zone for the subnet.
        /// </para>
        ///  
        /// <para>
        /// Default: Amazon Web Services selects one for you. If you create more than one subnet
        /// in your VPC, we do not necessarily select a different zone for each subnet.
        /// </para>
        ///  
        /// <para>
        /// To create a subnet in a Local Zone, set this value to the Local Zone ID, for example
        /// <code>us-west-2-lax-1a</code>. For information about the Regions that support Local
        /// Zones, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/using-regions-availability-zones.html#concepts-available-regions">Available
        /// Regions</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// To create a subnet in an Outpost, set this value to the Availability Zone for the
        /// Outpost and specify the Outpost ARN.
        /// </para>
        /// </summary>
        public string AvailabilityZone
        {
            get { return this._availabilityZone; }
            set { this._availabilityZone = value; }
        }

        // Check to see if AvailabilityZone property is set
        internal bool IsSetAvailabilityZone()
        {
            return this._availabilityZone != null;
        }

        /// <summary>
        /// Gets and sets the property AvailabilityZoneId. 
        /// <para>
        /// The AZ ID or the Local Zone ID of the subnet.
        /// </para>
        /// </summary>
        public string AvailabilityZoneId
        {
            get { return this._availabilityZoneId; }
            set { this._availabilityZoneId = value; }
        }

        // Check to see if AvailabilityZoneId property is set
        internal bool IsSetAvailabilityZoneId()
        {
            return this._availabilityZoneId != null;
        }

        /// <summary>
        /// Gets and sets the property CidrBlock. 
        /// <para>
        /// The IPv4 network range for the subnet, in CIDR notation. For example, <code>10.0.0.0/24</code>.
        /// We modify the specified CIDR block to its canonical form; for example, if you specify
        /// <code>100.68.0.18/18</code>, we modify it to <code>100.68.0.0/18</code>.
        /// </para>
        ///  
        /// <para>
        /// This parameter is not supported for an IPv6 only subnet.
        /// </para>
        /// </summary>
        public string CidrBlock
        {
            get { return this._cidrBlock; }
            set { this._cidrBlock = value; }
        }

        // Check to see if CidrBlock property is set
        internal bool IsSetCidrBlock()
        {
            return this._cidrBlock != null;
        }

        /// <summary>
        /// Gets and sets the property Ipv6CidrBlock. 
        /// <para>
        /// The IPv6 network range for the subnet, in CIDR notation. The subnet size must use
        /// a /64 prefix length.
        /// </para>
        ///  
        /// <para>
        /// This parameter is required for an IPv6 only subnet.
        /// </para>
        /// </summary>
        public string Ipv6CidrBlock
        {
            get { return this._ipv6CidrBlock; }
            set { this._ipv6CidrBlock = value; }
        }

        // Check to see if Ipv6CidrBlock property is set
        internal bool IsSetIpv6CidrBlock()
        {
            return this._ipv6CidrBlock != null;
        }

        /// <summary>
        /// Gets and sets the property Ipv6Native. 
        /// <para>
        /// Indicates whether to create an IPv6 only subnet.
        /// </para>
        /// </summary>
        public bool Ipv6Native
        {
            get { return this._ipv6Native.GetValueOrDefault(); }
            set { this._ipv6Native = value; }
        }

        // Check to see if Ipv6Native property is set
        internal bool IsSetIpv6Native()
        {
            return this._ipv6Native.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property OutpostArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Outpost. If you specify an Outpost ARN, you
        /// must also specify the Availability Zone of the Outpost subnet.
        /// </para>
        /// </summary>
        public string OutpostArn
        {
            get { return this._outpostArn; }
            set { this._outpostArn = value; }
        }

        // Check to see if OutpostArn property is set
        internal bool IsSetOutpostArn()
        {
            return this._outpostArn != null;
        }

        /// <summary>
        /// Gets and sets the property TagSpecifications. 
        /// <para>
        /// The tags to assign to the subnet.
        /// </para>
        /// </summary>
        public List<TagSpecification> TagSpecifications
        {
            get { return this._tagSpecifications; }
            set { this._tagSpecifications = value; }
        }

        // Check to see if TagSpecifications property is set
        internal bool IsSetTagSpecifications()
        {
            return this._tagSpecifications != null && this._tagSpecifications.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property VpcId. 
        /// <para>
        /// The ID of the VPC.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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