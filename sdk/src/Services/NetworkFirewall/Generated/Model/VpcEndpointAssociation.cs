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
 * Do not modify this file. This file is generated from the network-firewall-2020-11-12.normal.json service model.
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
namespace Amazon.NetworkFirewall.Model
{
    /// <summary>
    /// A VPC endpoint association defines a single subnet to use for a firewall endpoint
    /// for a <c>Firewall</c>. You can define VPC endpoint associations only in the Availability
    /// Zones that already have a subnet mapping defined in the <c>Firewall</c> resource.
    /// 
    /// 
    ///  <note> 
    /// <para>
    /// You can retrieve the list of Availability Zones that are available for use by calling
    /// <c>DescribeFirewallMetadata</c>.
    /// </para>
    ///  </note> 
    /// <para>
    /// To manage firewall endpoints, first, in the <c>Firewall</c> specification, you specify
    /// a single VPC and one subnet for each of the Availability Zones where you want to use
    /// the firewall. Then you can define additional endpoints as VPC endpoint associations.
    /// 
    /// </para>
    ///  
    /// <para>
    /// You can use VPC endpoint associations to expand the protections of the firewall as
    /// follows: 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <b>Protect multiple VPCs with a single firewall</b> - You can use the firewall to
    /// protect other VPCs, either in your account or in accounts where the firewall is shared.
    /// You can only specify Availability Zones that already have a firewall endpoint defined
    /// in the <c>Firewall</c> subnet mappings.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>Define multiple firewall endpoints for a VPC in an Availability Zone</b> - You
    /// can create additional firewall endpoints for the VPC that you have defined in the
    /// firewall, in any Availability Zone that already has an endpoint defined in the <c>Firewall</c>
    /// subnet mappings. You can create multiple VPC endpoint associations for any other VPC
    /// where you use the firewall.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// You can use Resource Access Manager to share a <c>Firewall</c> that you own with other
    /// accounts, which gives them the ability to use the firewall to create VPC endpoint
    /// associations. For information about sharing a firewall, see <c>PutResourcePolicy</c>
    /// in this guide and see <a href="https://docs.aws.amazon.com/network-firewall/latest/developerguide/sharing.html">Sharing
    /// Network Firewall resources</a> in the <i>Network Firewall Developer Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// The status of the VPC endpoint association, which indicates whether it's ready to
    /// filter network traffic, is provided in the corresponding <a>VpcEndpointAssociationStatus</a>.
    /// You can retrieve both the association and its status by calling <a>DescribeVpcEndpointAssociation</a>.
    /// </para>
    /// </summary>
    public partial class VpcEndpointAssociation
    {
        private string _description;
        private string _firewallArn;
        private SubnetMapping _subnetMapping;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;
        private string _vpcEndpointAssociationArn;
        private string _vpcEndpointAssociationId;
        private string _vpcId;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the VPC endpoint association. 
        /// </para>
        /// </summary>
        [AWSProperty(Max=512)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property FirewallArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the firewall.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string FirewallArn
        {
            get { return this._firewallArn; }
            set { this._firewallArn = value; }
        }

        // Check to see if FirewallArn property is set
        internal bool IsSetFirewallArn()
        {
            return this._firewallArn != null;
        }

        /// <summary>
        /// Gets and sets the property SubnetMapping.
        /// </summary>
        [AWSProperty(Required=true)]
        public SubnetMapping SubnetMapping
        {
            get { return this._subnetMapping; }
            set { this._subnetMapping = value; }
        }

        // Check to see if SubnetMapping property is set
        internal bool IsSetSubnetMapping()
        {
            return this._subnetMapping != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The key:value pairs to associate with the resource.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=200)]
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property VpcEndpointAssociationArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of a VPC endpoint association.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string VpcEndpointAssociationArn
        {
            get { return this._vpcEndpointAssociationArn; }
            set { this._vpcEndpointAssociationArn = value; }
        }

        // Check to see if VpcEndpointAssociationArn property is set
        internal bool IsSetVpcEndpointAssociationArn()
        {
            return this._vpcEndpointAssociationArn != null;
        }

        /// <summary>
        /// Gets and sets the property VpcEndpointAssociationId. 
        /// <para>
        /// The unique identifier of the VPC endpoint association. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=36, Max=36)]
        public string VpcEndpointAssociationId
        {
            get { return this._vpcEndpointAssociationId; }
            set { this._vpcEndpointAssociationId = value; }
        }

        // Check to see if VpcEndpointAssociationId property is set
        internal bool IsSetVpcEndpointAssociationId()
        {
            return this._vpcEndpointAssociationId != null;
        }

        /// <summary>
        /// Gets and sets the property VpcId. 
        /// <para>
        /// The unique identifier of the VPC for the endpoint association. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
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