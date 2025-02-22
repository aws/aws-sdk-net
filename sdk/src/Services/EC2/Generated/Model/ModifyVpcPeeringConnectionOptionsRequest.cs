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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the ModifyVpcPeeringConnectionOptions operation.
    /// Modifies the VPC peering connection options on one side of a VPC peering connection.
    /// 
    ///  
    /// <para>
    /// If the peered VPCs are in the same Amazon Web Services account, you can enable DNS
    /// resolution for queries from the local VPC. This ensures that queries from the local
    /// VPC resolve to private IP addresses in the peer VPC. This option is not available
    /// if the peered VPCs are in different Amazon Web Services accounts or different Regions.
    /// For peered VPCs in different Amazon Web Services accounts, each Amazon Web Services
    /// account owner must initiate a separate request to modify the peering connection options.
    /// For inter-region peering connections, you must use the Region for the requester VPC
    /// to modify the requester VPC peering options and the Region for the accepter VPC to
    /// modify the accepter VPC peering options. To verify which VPCs are the accepter and
    /// the requester for a VPC peering connection, use the <a>DescribeVpcPeeringConnections</a>
    /// command.
    /// </para>
    /// </summary>
    public partial class ModifyVpcPeeringConnectionOptionsRequest : AmazonEC2Request
    {
        private PeeringConnectionOptionsRequest _accepterPeeringConnectionOptions;
        private bool? _dryRun;
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
        /// Gets and sets the property DryRun. 
        /// <para>
        /// Checks whether you have the required permissions for the action, without actually
        /// making the request, and provides an error response. If you have the required permissions,
        /// the error response is <c>DryRunOperation</c>. Otherwise, it is <c>UnauthorizedOperation</c>.
        /// </para>
        /// </summary>
        public bool? DryRun
        {
            get { return this._dryRun; }
            set { this._dryRun = value; }
        }

        // Check to see if DryRun property is set
        internal bool IsSetDryRun()
        {
            return this._dryRun.HasValue; 
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
        [AWSProperty(Required=true)]
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