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

namespace Amazon.NetworkManager.Model
{
    /// <summary>
    /// Describes a core network attachment.
    /// </summary>
    public partial class Attachment
    {
        /// <summary>
        /// Gets and sets the property AttachmentId. 
        /// <para>
        /// The ID of the attachment.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 50)]
        public string AttachmentId { get; set; }

        /// <summary>
        /// Checks to see if the AttachmentId property is set.
        /// </summary>
        internal bool IsSetAttachmentId() => this.AttachmentId != null;

        /// <summary>
        /// Gets and sets the property AttachmentPolicyRuleNumber. 
        /// <para>
        /// The policy rule number associated with the attachment.
        /// </para>
        /// </summary>
        public int? AttachmentPolicyRuleNumber { get; set; }

        /// <summary>
        /// Checks to see if the AttachmentPolicyRuleNumber property is set.
        /// </summary>
        internal bool IsSetAttachmentPolicyRuleNumber() => this.AttachmentPolicyRuleNumber.HasValue;

        /// <summary>
        /// Gets and sets the property AttachmentType. 
        /// <para>
        /// The type of attachment.
        /// </para>
        /// </summary>
        public AttachmentType AttachmentType { get; set; }

        /// <summary>
        /// Checks to see if the AttachmentType property is set.
        /// </summary>
        internal bool IsSetAttachmentType() => this.AttachmentType != null;

        /// <summary>
        /// Gets and sets the property CoreNetworkArn. 
        /// <para>
        /// The ARN of a core network.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 500)]
        public string CoreNetworkArn { get; set; }

        /// <summary>
        /// Checks to see if the CoreNetworkArn property is set.
        /// </summary>
        internal bool IsSetCoreNetworkArn() => this.CoreNetworkArn != null;

        /// <summary>
        /// Gets and sets the property CoreNetworkId. 
        /// <para>
        /// The ID of a core network.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 50)]
        public string CoreNetworkId { get; set; }

        /// <summary>
        /// Checks to see if the CoreNetworkId property is set.
        /// </summary>
        internal bool IsSetCoreNetworkId() => this.CoreNetworkId != null;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The timestamp when the attachment was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property EdgeLocation. 
        /// <para>
        /// The Region where the edge is located. This is returned for all attachment types except
        /// a Direct Connect gateway attachment, which instead returns <c>EdgeLocations</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 63)]
        public string EdgeLocation { get; set; }

        /// <summary>
        /// Checks to see if the EdgeLocation property is set.
        /// </summary>
        internal bool IsSetEdgeLocation() => this.EdgeLocation != null;

        /// <summary>
        /// Gets and sets the property EdgeLocations. 
        /// <para>
        /// The edge locations that the Direct Connect gateway is associated with. This is returned
        /// only for Direct Connect gateway attachments. All other attachment types retrun <c>EdgeLocation</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> EdgeLocations { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the EdgeLocations property is set.
        /// </summary>
        internal bool IsSetEdgeLocations() => this.EdgeLocations != null && (this.EdgeLocations.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property LastModificationErrors. 
        /// <para>
        /// Describes the error associated with the attachment request.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 20)]
        public List<AttachmentError> LastModificationErrors { get; set; } = AWSConfigs.InitializeCollections ? new List<AttachmentError>() : null;

        /// <summary>
        /// Checks to see if the LastModificationErrors property is set.
        /// </summary>
        internal bool IsSetLastModificationErrors() => this.LastModificationErrors != null && (this.LastModificationErrors.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property NetworkFunctionGroupName. 
        /// <para>
        /// The name of the network function group.
        /// </para>
        /// </summary>
        public string NetworkFunctionGroupName { get; set; }

        /// <summary>
        /// Checks to see if the NetworkFunctionGroupName property is set.
        /// </summary>
        internal bool IsSetNetworkFunctionGroupName() => this.NetworkFunctionGroupName != null;

        /// <summary>
        /// Gets and sets the property OwnerAccountId. 
        /// <para>
        /// The ID of the attachment account owner.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 12, Max = 12)]
        public string OwnerAccountId { get; set; }

        /// <summary>
        /// Checks to see if the OwnerAccountId property is set.
        /// </summary>
        internal bool IsSetOwnerAccountId() => this.OwnerAccountId != null;

        /// <summary>
        /// Gets and sets the property ProposedNetworkFunctionGroupChange. 
        /// <para>
        /// Describes a proposed change to a network function group associated with the attachment.
        /// </para>
        /// </summary>
        public ProposedNetworkFunctionGroupChange ProposedNetworkFunctionGroupChange { get; set; }

        /// <summary>
        /// Checks to see if the ProposedNetworkFunctionGroupChange property is set.
        /// </summary>
        internal bool IsSetProposedNetworkFunctionGroupChange() => this.ProposedNetworkFunctionGroupChange != null;

        /// <summary>
        /// Gets and sets the property ProposedSegmentChange. 
        /// <para>
        /// The attachment to move from one segment to another.
        /// </para>
        /// </summary>
        public ProposedSegmentChange ProposedSegmentChange { get; set; }

        /// <summary>
        /// Checks to see if the ProposedSegmentChange property is set.
        /// </summary>
        internal bool IsSetProposedSegmentChange() => this.ProposedSegmentChange != null;

        /// <summary>
        /// Gets and sets the property ResourceArn. 
        /// <para>
        /// The attachment resource ARN.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1500)]
        public string ResourceArn { get; set; }

        /// <summary>
        /// Checks to see if the ResourceArn property is set.
        /// </summary>
        internal bool IsSetResourceArn() => this.ResourceArn != null;

        /// <summary>
        /// Gets and sets the property SegmentName. 
        /// <para>
        /// The name of the segment attachment.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string SegmentName { get; set; }

        /// <summary>
        /// Checks to see if the SegmentName property is set.
        /// </summary>
        internal bool IsSetSegmentName() => this.SegmentName != null;

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The state of the attachment.
        /// </para>
        /// </summary>
        public AttachmentState State { get; set; }

        /// <summary>
        /// Checks to see if the State property is set.
        /// </summary>
        internal bool IsSetState() => this.State != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags associated with the attachment.
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
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The timestamp when the attachment was last updated.
        /// </para>
        /// </summary>
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the UpdatedAt property is set.
        /// </summary>
        internal bool IsSetUpdatedAt() => this.UpdatedAt.HasValue;
    }
}
