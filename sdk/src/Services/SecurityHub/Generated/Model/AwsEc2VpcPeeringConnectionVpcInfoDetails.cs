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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
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
    /// Describes a VPC in a VPC peering connection.
    /// </summary>
    public partial class AwsEc2VpcPeeringConnectionVpcInfoDetails
    {
        private string _cidrBlock;
        private List<VpcInfoCidrBlockSetDetails> _cidrBlockSet = AWSConfigs.InitializeCollections ? new List<VpcInfoCidrBlockSetDetails>() : null;
        private List<VpcInfoIpv6CidrBlockSetDetails> _ipv6CidrBlockSet = AWSConfigs.InitializeCollections ? new List<VpcInfoIpv6CidrBlockSetDetails>() : null;
        private string _ownerId;
        private VpcInfoPeeringOptionsDetails _peeringOptions;
        private string _region;
        private string _vpcId;

        /// <summary>
        /// Gets and sets the property CidrBlock. 
        /// <para>
        /// The IPv4 CIDR block for the VPC. 
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
        /// Gets and sets the property CidrBlockSet. 
        /// <para>
        /// Information about the IPv4 CIDR blocks for the VPC. 
        /// </para>
        /// </summary>
        public List<VpcInfoCidrBlockSetDetails> CidrBlockSet
        {
            get { return this._cidrBlockSet; }
            set { this._cidrBlockSet = value; }
        }

        // Check to see if CidrBlockSet property is set
        internal bool IsSetCidrBlockSet()
        {
            return this._cidrBlockSet != null && (this._cidrBlockSet.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Ipv6CidrBlockSet. 
        /// <para>
        /// The IPv6 CIDR block for the VPC. 
        /// </para>
        /// </summary>
        public List<VpcInfoIpv6CidrBlockSetDetails> Ipv6CidrBlockSet
        {
            get { return this._ipv6CidrBlockSet; }
            set { this._ipv6CidrBlockSet = value; }
        }

        // Check to see if Ipv6CidrBlockSet property is set
        internal bool IsSetIpv6CidrBlockSet()
        {
            return this._ipv6CidrBlockSet != null && (this._ipv6CidrBlockSet.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property OwnerId. 
        /// <para>
        /// The ID of the Amazon Web Services account that owns the VPC. 
        /// </para>
        /// </summary>
        public string OwnerId
        {
            get { return this._ownerId; }
            set { this._ownerId = value; }
        }

        // Check to see if OwnerId property is set
        internal bool IsSetOwnerId()
        {
            return this._ownerId != null;
        }

        /// <summary>
        /// Gets and sets the property PeeringOptions. 
        /// <para>
        /// Information about the VPC peering connection options for the accepter or requester
        /// VPC. 
        /// </para>
        /// </summary>
        public VpcInfoPeeringOptionsDetails PeeringOptions
        {
            get { return this._peeringOptions; }
            set { this._peeringOptions = value; }
        }

        // Check to see if PeeringOptions property is set
        internal bool IsSetPeeringOptions()
        {
            return this._peeringOptions != null;
        }

        /// <summary>
        /// Gets and sets the property Region. 
        /// <para>
        /// The Amazon Web Services Region in which the VPC is located. 
        /// </para>
        /// </summary>
        public string Region
        {
            get { return this._region; }
            set { this._region = value; }
        }

        // Check to see if Region property is set
        internal bool IsSetRegion()
        {
            return this._region != null;
        }

        /// <summary>
        /// Gets and sets the property VpcId. 
        /// <para>
        /// The ID of the VPC. 
        /// </para>
        /// </summary>
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