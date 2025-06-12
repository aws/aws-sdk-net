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
 * Do not modify this file. This file is generated from the networkmanager-2019-07-05.normal.json service model.
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
        private string _attachmentId;
        private int? _attachmentPolicyRuleNumber;
        private AttachmentType _attachmentType;
        private string _coreNetworkArn;
        private string _coreNetworkId;
        private DateTime? _createdAt;
        private string _edgeLocation;
        private List<string> _edgeLocations = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<AttachmentError> _lastModificationErrors = AWSConfigs.InitializeCollections ? new List<AttachmentError>() : null;
        private string _networkFunctionGroupName;
        private string _ownerAccountId;
        private ProposedNetworkFunctionGroupChange _proposedNetworkFunctionGroupChange;
        private ProposedSegmentChange _proposedSegmentChange;
        private string _resourceArn;
        private string _segmentName;
        private AttachmentState _state;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;
        private DateTime? _updatedAt;

        /// <summary>
        /// Gets and sets the property AttachmentId. 
        /// <para>
        /// The ID of the attachment.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
        public string AttachmentId
        {
            get { return this._attachmentId; }
            set { this._attachmentId = value; }
        }

        // Check to see if AttachmentId property is set
        internal bool IsSetAttachmentId()
        {
            return this._attachmentId != null;
        }

        /// <summary>
        /// Gets and sets the property AttachmentPolicyRuleNumber. 
        /// <para>
        /// The policy rule number associated with the attachment.
        /// </para>
        /// </summary>
        public int? AttachmentPolicyRuleNumber
        {
            get { return this._attachmentPolicyRuleNumber; }
            set { this._attachmentPolicyRuleNumber = value; }
        }

        // Check to see if AttachmentPolicyRuleNumber property is set
        internal bool IsSetAttachmentPolicyRuleNumber()
        {
            return this._attachmentPolicyRuleNumber.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property AttachmentType. 
        /// <para>
        /// The type of attachment.
        /// </para>
        /// </summary>
        public AttachmentType AttachmentType
        {
            get { return this._attachmentType; }
            set { this._attachmentType = value; }
        }

        // Check to see if AttachmentType property is set
        internal bool IsSetAttachmentType()
        {
            return this._attachmentType != null;
        }

        /// <summary>
        /// Gets and sets the property CoreNetworkArn. 
        /// <para>
        /// The ARN of a core network.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=500)]
        public string CoreNetworkArn
        {
            get { return this._coreNetworkArn; }
            set { this._coreNetworkArn = value; }
        }

        // Check to see if CoreNetworkArn property is set
        internal bool IsSetCoreNetworkArn()
        {
            return this._coreNetworkArn != null;
        }

        /// <summary>
        /// Gets and sets the property CoreNetworkId. 
        /// <para>
        /// The ID of a core network.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
        public string CoreNetworkId
        {
            get { return this._coreNetworkId; }
            set { this._coreNetworkId = value; }
        }

        // Check to see if CoreNetworkId property is set
        internal bool IsSetCoreNetworkId()
        {
            return this._coreNetworkId != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The timestamp when the attachment was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedAt
        {
            get { return this._createdAt; }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EdgeLocation. 
        /// <para>
        /// The Region where the edge is located. This is returned for all attachment types except
        /// a Direct Connect gateway attachment, which instead returns <c>EdgeLocations</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=63)]
        public string EdgeLocation
        {
            get { return this._edgeLocation; }
            set { this._edgeLocation = value; }
        }

        // Check to see if EdgeLocation property is set
        internal bool IsSetEdgeLocation()
        {
            return this._edgeLocation != null;
        }

        /// <summary>
        /// Gets and sets the property EdgeLocations. 
        /// <para>
        /// The edge locations that the Direct Connect gateway is associated with. This is returned
        /// only for Direct Connect gateway attachments. All other attachment types retrun <c>EdgeLocation</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> EdgeLocations
        {
            get { return this._edgeLocations; }
            set { this._edgeLocations = value; }
        }

        // Check to see if EdgeLocations property is set
        internal bool IsSetEdgeLocations()
        {
            return this._edgeLocations != null && (this._edgeLocations.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property LastModificationErrors. 
        /// <para>
        /// Describes the error associated with the attachment request.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=20)]
        public List<AttachmentError> LastModificationErrors
        {
            get { return this._lastModificationErrors; }
            set { this._lastModificationErrors = value; }
        }

        // Check to see if LastModificationErrors property is set
        internal bool IsSetLastModificationErrors()
        {
            return this._lastModificationErrors != null && (this._lastModificationErrors.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property NetworkFunctionGroupName. 
        /// <para>
        /// The name of the network function group.
        /// </para>
        /// </summary>
        public string NetworkFunctionGroupName
        {
            get { return this._networkFunctionGroupName; }
            set { this._networkFunctionGroupName = value; }
        }

        // Check to see if NetworkFunctionGroupName property is set
        internal bool IsSetNetworkFunctionGroupName()
        {
            return this._networkFunctionGroupName != null;
        }

        /// <summary>
        /// Gets and sets the property OwnerAccountId. 
        /// <para>
        /// The ID of the attachment account owner.
        /// </para>
        /// </summary>
        [AWSProperty(Min=12, Max=12)]
        public string OwnerAccountId
        {
            get { return this._ownerAccountId; }
            set { this._ownerAccountId = value; }
        }

        // Check to see if OwnerAccountId property is set
        internal bool IsSetOwnerAccountId()
        {
            return this._ownerAccountId != null;
        }

        /// <summary>
        /// Gets and sets the property ProposedNetworkFunctionGroupChange. 
        /// <para>
        /// Describes a proposed change to a network function group associated with the attachment.
        /// </para>
        /// </summary>
        public ProposedNetworkFunctionGroupChange ProposedNetworkFunctionGroupChange
        {
            get { return this._proposedNetworkFunctionGroupChange; }
            set { this._proposedNetworkFunctionGroupChange = value; }
        }

        // Check to see if ProposedNetworkFunctionGroupChange property is set
        internal bool IsSetProposedNetworkFunctionGroupChange()
        {
            return this._proposedNetworkFunctionGroupChange != null;
        }

        /// <summary>
        /// Gets and sets the property ProposedSegmentChange. 
        /// <para>
        /// The attachment to move from one segment to another.
        /// </para>
        /// </summary>
        public ProposedSegmentChange ProposedSegmentChange
        {
            get { return this._proposedSegmentChange; }
            set { this._proposedSegmentChange = value; }
        }

        // Check to see if ProposedSegmentChange property is set
        internal bool IsSetProposedSegmentChange()
        {
            return this._proposedSegmentChange != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceArn. 
        /// <para>
        /// The attachment resource ARN.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1500)]
        public string ResourceArn
        {
            get { return this._resourceArn; }
            set { this._resourceArn = value; }
        }

        // Check to see if ResourceArn property is set
        internal bool IsSetResourceArn()
        {
            return this._resourceArn != null;
        }

        /// <summary>
        /// Gets and sets the property SegmentName. 
        /// <para>
        /// The name of the segment attachment.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=256)]
        public string SegmentName
        {
            get { return this._segmentName; }
            set { this._segmentName = value; }
        }

        // Check to see if SegmentName property is set
        internal bool IsSetSegmentName()
        {
            return this._segmentName != null;
        }

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The state of the attachment.
        /// </para>
        /// </summary>
        public AttachmentState State
        {
            get { return this._state; }
            set { this._state = value; }
        }

        // Check to see if State property is set
        internal bool IsSetState()
        {
            return this._state != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags associated with the attachment.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
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
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The timestamp when the attachment was last updated.
        /// </para>
        /// </summary>
        public DateTime? UpdatedAt
        {
            get { return this._updatedAt; }
            set { this._updatedAt = value; }
        }

        // Check to see if UpdatedAt property is set
        internal bool IsSetUpdatedAt()
        {
            return this._updatedAt.HasValue; 
        }

    }
}