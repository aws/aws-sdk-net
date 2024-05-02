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
    /// Provides information about a VPC peering connection between two VPCs: a requester
    /// VPC that you own and an accepter VPC with which to create the connection.
    /// </summary>
    public partial class AwsEc2VpcPeeringConnectionDetails
    {
        private AwsEc2VpcPeeringConnectionVpcInfoDetails _accepterVpcInfo;
        private string _expirationTime;
        private AwsEc2VpcPeeringConnectionVpcInfoDetails _requesterVpcInfo;
        private AwsEc2VpcPeeringConnectionStatusDetails _status;
        private string _vpcPeeringConnectionId;

        /// <summary>
        /// Gets and sets the property AccepterVpcInfo. 
        /// <para>
        /// Information about the accepter VPC. 
        /// </para>
        /// </summary>
        public AwsEc2VpcPeeringConnectionVpcInfoDetails AccepterVpcInfo
        {
            get { return this._accepterVpcInfo; }
            set { this._accepterVpcInfo = value; }
        }

        // Check to see if AccepterVpcInfo property is set
        internal bool IsSetAccepterVpcInfo()
        {
            return this._accepterVpcInfo != null;
        }

        /// <summary>
        /// Gets and sets the property ExpirationTime. 
        /// <para>
        /// The time at which an unaccepted VPC peering connection will expire. 
        /// </para>
        /// </summary>
        public string ExpirationTime
        {
            get { return this._expirationTime; }
            set { this._expirationTime = value; }
        }

        // Check to see if ExpirationTime property is set
        internal bool IsSetExpirationTime()
        {
            return this._expirationTime != null;
        }

        /// <summary>
        /// Gets and sets the property RequesterVpcInfo. 
        /// <para>
        /// Information about the requester VPC. 
        /// </para>
        /// </summary>
        public AwsEc2VpcPeeringConnectionVpcInfoDetails RequesterVpcInfo
        {
            get { return this._requesterVpcInfo; }
            set { this._requesterVpcInfo = value; }
        }

        // Check to see if RequesterVpcInfo property is set
        internal bool IsSetRequesterVpcInfo()
        {
            return this._requesterVpcInfo != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the VPC peering connection. 
        /// </para>
        /// </summary>
        public AwsEc2VpcPeeringConnectionStatusDetails Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
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