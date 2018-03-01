/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the ModifyVpcPeeringConnectionOptions operation.
    /// Modifies the VPC peering connection options on one side of a VPC peering connection.
    /// You can do the following:
    /// 
    ///  <ul> <li> 
    /// <para>
    /// Enable/disable communication over the peering connection between an EC2-Classic instance
    /// that's linked to your VPC (using ClassicLink) and instances in the peer VPC.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Enable/disable communication over the peering connection between instances in your
    /// VPC and an EC2-Classic instance that's linked to the peer VPC.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Enable/disable the ability to resolve public DNS hostnames to private IP addresses
    /// when queried from instances in the peer VPC.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// If the peered VPCs are in different accounts, each owner must initiate a separate
    /// request to modify the peering connection options, depending on whether their VPC was
    /// the requester or accepter for the VPC peering connection. If the peered VPCs are in
    /// the same account, you can modify the requester and accepter options in the same request.
    /// To confirm which VPC is the accepter and requester for a VPC peering connection, use
    /// the <a>DescribeVpcPeeringConnections</a> command.
    /// </para>
    /// </summary>
    public partial class ModifyVpcPeeringConnectionOptionsRequest : AmazonEC2Request
    {
        private PeeringConnectionOptionsRequest _accepterPeeringConnectionOptions;
        private PeeringConnectionOptionsRequest _requesterPeeringConnectionOptions;
        private string _vpcPeeringConnectionId;

        /// <summary>
        /// Gets and sets the property AccepterPeeringConnectionOptions. 
        /// <para>
        /// The VPC peering connection options for the accepter VPC.
        /// </para>
        /// </summary>
        public PeeringConnectionOptionsRequest AccepterPeeringConnectionOptions
        {
            get { return this._accepterPeeringConnectionOptions; }
            set { this._accepterPeeringConnectionOptions = value; }
        }

        // Check to see if AccepterPeeringConnectionOptions property is set
        internal bool IsSetAccepterPeeringConnectionOptions()
        {
            return this._accepterPeeringConnectionOptions != null;
        }

        /// <summary>
        /// Gets and sets the property RequesterPeeringConnectionOptions. 
        /// <para>
        /// The VPC peering connection options for the requester VPC.
        /// </para>
        /// </summary>
        public PeeringConnectionOptionsRequest RequesterPeeringConnectionOptions
        {
            get { return this._requesterPeeringConnectionOptions; }
            set { this._requesterPeeringConnectionOptions = value; }
        }

        // Check to see if RequesterPeeringConnectionOptions property is set
        internal bool IsSetRequesterPeeringConnectionOptions()
        {
            return this._requesterPeeringConnectionOptions != null;
        }

        /// <summary>
        /// Gets and sets the property VpcPeeringConnectionId. 
        /// <para>
        /// The ID of the VPC peering connection.
        /// </para>
        /// </summary>
        public string VpcPeeringConnectionId
        {
            get { return this._vpcPeeringConnectionId; }
            set { this._vpcPeeringConnectionId = value; }
        }

        // Check to see if VpcPeeringConnectionId property is set
        internal bool IsSetVpcPeeringConnectionId()
        {
            return this._vpcPeeringConnectionId != null;
        }

    }
}