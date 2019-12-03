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
    /// Describes the transit gateway peering attachment.
    /// </summary>
    public partial class TransitGatewayPeeringAttachment
    {
        private PeeringTgwInfo _accepterTgwInfo;
        private DateTime? _creationTime;
        private PeeringTgwInfo _requesterTgwInfo;
        private TransitGatewayAttachmentState _state;
        private PeeringAttachmentStatus _status;
        private List<Tag> _tags = new List<Tag>();
        private string _transitGatewayAttachmentId;

        /// <summary>
        /// Gets and sets the property AccepterTgwInfo. 
        /// <para>
        /// Information about the accepter transit gateway.
        /// </para>
        /// </summary>
        public PeeringTgwInfo AccepterTgwInfo
        {
            get { return this._accepterTgwInfo; }
            set { this._accepterTgwInfo = value; }
        }

        // Check to see if AccepterTgwInfo property is set
        internal bool IsSetAccepterTgwInfo()
        {
            return this._accepterTgwInfo != null;
        }

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The time the transit gateway peering attachment was created.
        /// </para>
        /// </summary>
        public DateTime CreationTime
        {
            get { return this._creationTime.GetValueOrDefault(); }
            set { this._creationTime = value; }
        }

        // Check to see if CreationTime property is set
        internal bool IsSetCreationTime()
        {
            return this._creationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RequesterTgwInfo. 
        /// <para>
        /// Information about the requester transit gateway.
        /// </para>
        /// </summary>
        public PeeringTgwInfo RequesterTgwInfo
        {
            get { return this._requesterTgwInfo; }
            set { this._requesterTgwInfo = value; }
        }

        // Check to see if RequesterTgwInfo property is set
        internal bool IsSetRequesterTgwInfo()
        {
            return this._requesterTgwInfo != null;
        }

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The state of the transit gateway peering attachment.
        /// </para>
        /// </summary>
        public TransitGatewayAttachmentState State
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
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the transit gateway peering attachment.
        /// </para>
        /// </summary>
        public PeeringAttachmentStatus Status
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
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags for the transit gateway peering attachment.
        /// </para>
        /// </summary>
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property TransitGatewayAttachmentId. 
        /// <para>
        /// The ID of the transit gateway peering attachment.
        /// </para>
        /// </summary>
        public string TransitGatewayAttachmentId
        {
            get { return this._transitGatewayAttachmentId; }
            set { this._transitGatewayAttachmentId = value; }
        }

        // Check to see if TransitGatewayAttachmentId property is set
        internal bool IsSetTransitGatewayAttachmentId()
        {
            return this._transitGatewayAttachmentId != null;
        }

    }
}