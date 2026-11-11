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
    /// Describes the transit gateway peering attachment.
    /// </summary>
    public partial class TransitGatewayPeeringAttachment
    {
        /// <summary>
        /// Gets and sets the property AccepterTgwInfo. 
        /// <para>
        /// Information about the accepter transit gateway.
        /// </para>
        /// </summary>
        public PeeringTgwInfo AccepterTgwInfo { get; set; }

        /// <summary>
        /// Checks to see if the AccepterTgwInfo property is set.
        /// </summary>
        internal bool IsSetAccepterTgwInfo() => this.AccepterTgwInfo != null;

        /// <summary>
        /// Gets and sets the property AccepterTransitGatewayAttachmentId. 
        /// <para>
        /// The ID of the accepter transit gateway attachment.
        /// </para>
        /// </summary>
        public string AccepterTransitGatewayAttachmentId { get; set; }

        /// <summary>
        /// Checks to see if the AccepterTransitGatewayAttachmentId property is set.
        /// </summary>
        internal bool IsSetAccepterTransitGatewayAttachmentId() => this.AccepterTransitGatewayAttachmentId != null;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The time the transit gateway peering attachment was created.
        /// </para>
        /// </summary>
        public DateTime? CreationTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationTime property is set.
        /// </summary>
        internal bool IsSetCreationTime() => this.CreationTime.HasValue;

        /// <summary>
        /// Gets and sets the property Options. 
        /// <para>
        /// Details about the transit gateway peering attachment.
        /// </para>
        /// </summary>
        public TransitGatewayPeeringAttachmentOptions Options { get; set; }

        /// <summary>
        /// Checks to see if the Options property is set.
        /// </summary>
        internal bool IsSetOptions() => this.Options != null;

        /// <summary>
        /// Gets and sets the property RequesterTgwInfo. 
        /// <para>
        /// Information about the requester transit gateway.
        /// </para>
        /// </summary>
        public PeeringTgwInfo RequesterTgwInfo { get; set; }

        /// <summary>
        /// Checks to see if the RequesterTgwInfo property is set.
        /// </summary>
        internal bool IsSetRequesterTgwInfo() => this.RequesterTgwInfo != null;

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The state of the transit gateway peering attachment. Note that the <c>initiating</c>
        /// state has been deprecated.
        /// </para>
        /// </summary>
        public TransitGatewayAttachmentState State { get; set; }

        /// <summary>
        /// Checks to see if the State property is set.
        /// </summary>
        internal bool IsSetState() => this.State != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the transit gateway peering attachment.
        /// </para>
        /// </summary>
        public PeeringAttachmentStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags for the transit gateway peering attachment.
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
        /// Gets and sets the property TransitGatewayAttachmentId. 
        /// <para>
        /// The ID of the transit gateway peering attachment.
        /// </para>
        /// </summary>
        public string TransitGatewayAttachmentId { get; set; }

        /// <summary>
        /// Checks to see if the TransitGatewayAttachmentId property is set.
        /// </summary>
        internal bool IsSetTransitGatewayAttachmentId() => this.TransitGatewayAttachmentId != null;
    }
}
