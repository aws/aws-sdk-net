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

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Provides information about a VPC peering connection between two VPCs: a requester
    /// VPC that you own and an accepter VPC with which to create the connection.
    /// </summary>
    public partial class AwsEc2VpcPeeringConnectionDetails
    {
        /// <summary>
        /// Gets and sets the property AccepterVpcInfo. 
        /// <para>
        /// Information about the accepter VPC. 
        /// </para>
        /// </summary>
        public AwsEc2VpcPeeringConnectionVpcInfoDetails AccepterVpcInfo { get; set; }

        /// <summary>
        /// Checks to see if the AccepterVpcInfo property is set.
        /// </summary>
        internal bool IsSetAccepterVpcInfo() => this.AccepterVpcInfo != null;

        /// <summary>
        /// Gets and sets the property ExpirationTime. 
        /// <para>
        /// The time at which an unaccepted VPC peering connection will expire. 
        /// </para>
        /// </summary>
        public string ExpirationTime { get; set; }

        /// <summary>
        /// Checks to see if the ExpirationTime property is set.
        /// </summary>
        internal bool IsSetExpirationTime() => this.ExpirationTime != null;

        /// <summary>
        /// Gets and sets the property RequesterVpcInfo. 
        /// <para>
        /// Information about the requester VPC. 
        /// </para>
        /// </summary>
        public AwsEc2VpcPeeringConnectionVpcInfoDetails RequesterVpcInfo { get; set; }

        /// <summary>
        /// Checks to see if the RequesterVpcInfo property is set.
        /// </summary>
        internal bool IsSetRequesterVpcInfo() => this.RequesterVpcInfo != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the VPC peering connection. 
        /// </para>
        /// </summary>
        public AwsEc2VpcPeeringConnectionStatusDetails Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property VpcPeeringConnectionId. 
        /// <para>
        /// The ID of the VPC peering connection. 
        /// </para>
        /// </summary>
        public string VpcPeeringConnectionId { get; set; }

        /// <summary>
        /// Checks to see if the VpcPeeringConnectionId property is set.
        /// </summary>
        internal bool IsSetVpcPeeringConnectionId() => this.VpcPeeringConnectionId != null;
    }
}
