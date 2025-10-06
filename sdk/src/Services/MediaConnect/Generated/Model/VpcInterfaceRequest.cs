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
 * Do not modify this file. This file is generated from the mediaconnect-2018-11-14.normal.json service model.
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
namespace Amazon.MediaConnect.Model
{
    /// <summary>
    /// The details of the VPC interfaces that you want to add to the flow.
    /// </summary>
    public partial class VpcInterfaceRequest
    {
        private string _name;
        private NetworkInterfaceType _networkInterfaceType;
        private string _roleArn;
        private List<string> _securityGroupIds = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _subnetId;
        private Dictionary<string, string> _vpcInterfaceTags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name for the VPC interface. This name must be unique within the flow. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property NetworkInterfaceType. 
        /// <para>
        /// The type of network interface. 
        /// </para>
        /// </summary>
        public NetworkInterfaceType NetworkInterfaceType
        {
            get { return this._networkInterfaceType; }
            set { this._networkInterfaceType = value; }
        }

        // Check to see if NetworkInterfaceType property is set
        internal bool IsSetNetworkInterfaceType()
        {
            return this._networkInterfaceType != null;
        }

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the role that you created when you set up MediaConnect
        /// as a trusted service. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string RoleArn
        {
            get { return this._roleArn; }
            set { this._roleArn = value; }
        }

        // Check to see if RoleArn property is set
        internal bool IsSetRoleArn()
        {
            return this._roleArn != null;
        }

        /// <summary>
        /// Gets and sets the property SecurityGroupIds. 
        /// <para>
        /// A virtual firewall to control inbound and outbound traffic. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> SecurityGroupIds
        {
            get { return this._securityGroupIds; }
            set { this._securityGroupIds = value; }
        }

        // Check to see if SecurityGroupIds property is set
        internal bool IsSetSecurityGroupIds()
        {
            return this._securityGroupIds != null && (this._securityGroupIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SubnetId. 
        /// <para>
        ///  The subnet IDs that you want to use for your VPC interface. A range of IP addresses
        /// in your VPC. When you create your VPC, you specify a range of IPv4 addresses for the
        /// VPC in the form of a Classless Inter-Domain Routing (CIDR) block; for example, 10.0.0.0/16.
        /// This is the primary CIDR block for your VPC. When you create a subnet for your VPC,
        /// you specify the CIDR block for the subnet, which is a subset of the VPC CIDR block.
        /// The subnets that you use across all VPC interfaces on the flow must be in the same
        /// Availability Zone as the flow. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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

        /// <summary>
        /// Gets and sets the property VpcInterfaceTags. 
        /// <para>
        ///  The key-value pairs that can be used to tag and organize the VPC network interface.
        /// 
        /// </para>
        /// </summary>
        public Dictionary<string, string> VpcInterfaceTags
        {
            get { return this._vpcInterfaceTags; }
            set { this._vpcInterfaceTags = value; }
        }

        // Check to see if VpcInterfaceTags property is set
        internal bool IsSetVpcInterfaceTags()
        {
            return this._vpcInterfaceTags != null && (this._vpcInterfaceTags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}