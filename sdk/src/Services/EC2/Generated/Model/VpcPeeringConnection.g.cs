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

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Describes a VPC peering connection.
    /// </summary>
    public partial class VpcPeeringConnection
    {
        /// <summary>
        /// Gets and sets the property AccepterVpcInfo. 
        /// <para>
        /// Information about the accepter VPC. CIDR block information is only returned when describing
        /// an active VPC peering connection.
        /// </para>
        /// </summary>
        public VpcPeeringConnectionVpcInfo AccepterVpcInfo { get; set; }

        /// <summary>
        /// Checks to see if the AccepterVpcInfo property is set.
        /// </summary>
        internal bool IsSetAccepterVpcInfo() => this.AccepterVpcInfo != null;

        /// <summary>
        /// Gets and sets the property ExpirationTime. 
        /// <para>
        /// The time that an unaccepted VPC peering connection will expire.
        /// </para>
        /// </summary>
        public DateTime? ExpirationTime { get; set; }

        /// <summary>
        /// Checks to see if the ExpirationTime property is set.
        /// </summary>
        internal bool IsSetExpirationTime() => this.ExpirationTime.HasValue;

        /// <summary>
        /// Gets and sets the property RequesterVpcInfo. 
        /// <para>
        /// Information about the requester VPC. CIDR block information is only returned when
        /// describing an active VPC peering connection.
        /// </para>
        /// </summary>
        public VpcPeeringConnectionVpcInfo RequesterVpcInfo { get; set; }

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
        public VpcPeeringConnectionStateReason Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Any tags assigned to the resource.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

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
