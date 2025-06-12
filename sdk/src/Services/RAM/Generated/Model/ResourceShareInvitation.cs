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
 * Do not modify this file. This file is generated from the ram-2018-01-04.normal.json service model.
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
namespace Amazon.RAM.Model
{
    /// <summary>
    /// Describes an invitation for an Amazon Web Services account to join a resource share.
    /// </summary>
    public partial class ResourceShareInvitation
    {
        private DateTime? _invitationTimestamp;
        private string _receiverAccountId;
        private string _receiverArn;
        private string _resourceShareArn;
        private List<ResourceShareAssociation> _resourceShareAssociations = AWSConfigs.InitializeCollections ? new List<ResourceShareAssociation>() : null;
        private string _resourceShareInvitationArn;
        private string _resourceShareName;
        private string _senderAccountId;
        private ResourceShareInvitationStatus _status;

        /// <summary>
        /// Gets and sets the property InvitationTimestamp. 
        /// <para>
        /// The date and time when the invitation was sent.
        /// </para>
        /// </summary>
        public DateTime? InvitationTimestamp
        {
            get { return this._invitationTimestamp; }
            set { this._invitationTimestamp = value; }
        }

        // Check to see if InvitationTimestamp property is set
        internal bool IsSetInvitationTimestamp()
        {
            return this._invitationTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ReceiverAccountId. 
        /// <para>
        /// The ID of the Amazon Web Services account that received the invitation.
        /// </para>
        /// </summary>
        public string ReceiverAccountId
        {
            get { return this._receiverAccountId; }
            set { this._receiverAccountId = value; }
        }

        // Check to see if ReceiverAccountId property is set
        internal bool IsSetReceiverAccountId()
        {
            return this._receiverAccountId != null;
        }

        /// <summary>
        /// Gets and sets the property ReceiverArn. 
        /// <para>
        /// The <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">Amazon
        /// Resource Name (ARN)</a> of the IAM user or role that received the invitation.
        /// </para>
        /// </summary>
        public string ReceiverArn
        {
            get { return this._receiverArn; }
            set { this._receiverArn = value; }
        }

        // Check to see if ReceiverArn property is set
        internal bool IsSetReceiverArn()
        {
            return this._receiverArn != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceShareArn. 
        /// <para>
        /// The <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">Amazon
        /// Resource Name (ARN)</a> of the resource share
        /// </para>
        /// </summary>
        public string ResourceShareArn
        {
            get { return this._resourceShareArn; }
            set { this._resourceShareArn = value; }
        }

        // Check to see if ResourceShareArn property is set
        internal bool IsSetResourceShareArn()
        {
            return this._resourceShareArn != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceShareAssociations. 
        /// <para>
        /// To view the resources associated with a pending resource share invitation, use <a>ListPendingInvitationResources</a>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [Obsolete("This member has been deprecated. Use ListPendingInvitationResources.")]
        public List<ResourceShareAssociation> ResourceShareAssociations
        {
            get { return this._resourceShareAssociations; }
            set { this._resourceShareAssociations = value; }
        }

        // Check to see if ResourceShareAssociations property is set
        internal bool IsSetResourceShareAssociations()
        {
            return this._resourceShareAssociations != null && (this._resourceShareAssociations.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ResourceShareInvitationArn. 
        /// <para>
        /// The <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">Amazon
        /// Resource Name (ARN)</a> of the invitation.
        /// </para>
        /// </summary>
        public string ResourceShareInvitationArn
        {
            get { return this._resourceShareInvitationArn; }
            set { this._resourceShareInvitationArn = value; }
        }

        // Check to see if ResourceShareInvitationArn property is set
        internal bool IsSetResourceShareInvitationArn()
        {
            return this._resourceShareInvitationArn != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceShareName. 
        /// <para>
        /// The name of the resource share.
        /// </para>
        /// </summary>
        public string ResourceShareName
        {
            get { return this._resourceShareName; }
            set { this._resourceShareName = value; }
        }

        // Check to see if ResourceShareName property is set
        internal bool IsSetResourceShareName()
        {
            return this._resourceShareName != null;
        }

        /// <summary>
        /// Gets and sets the property SenderAccountId. 
        /// <para>
        /// The ID of the Amazon Web Services account that sent the invitation.
        /// </para>
        /// </summary>
        public string SenderAccountId
        {
            get { return this._senderAccountId; }
            set { this._senderAccountId = value; }
        }

        // Check to see if SenderAccountId property is set
        internal bool IsSetSenderAccountId()
        {
            return this._senderAccountId != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the invitation.
        /// </para>
        /// </summary>
        public ResourceShareInvitationStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}