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
 * Do not modify this file. This file is generated from the partnercentral-selling-2022-07-26.normal.json service model.
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
namespace Amazon.PartnerCentralSelling.Model
{
    /// <summary>
    /// Provides a summarized view of the Engagement Invitation, including details like the
    /// identifier, status, and sender. This summary helps partners track and manage AWS originated
    /// opportunities.
    /// </summary>
    public partial class EngagementInvitationSummary
    {
        private string _arn;
        private string _catalog;
        private string _engagementId;
        private string _engagementTitle;
        private DateTime? _expirationDate;
        private string _id;
        private DateTime? _invitationDate;
        private ParticipantType _participantType;
        private EngagementInvitationPayloadType _payloadType;
        private Receiver _receiver;
        private string _senderAwsAccountId;
        private string _senderCompanyName;
        private InvitationStatus _status;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Engagement Invitation. The ARN is a unique identifier
        /// that allows partners to reference the invitation in their system and manage its lifecycle.
        /// </para>
        /// </summary>
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property Catalog. 
        /// <para>
        /// Specifies the catalog in which the Engagement Invitation resides. This can be either
        /// the <c>AWS</c> or <c>Sandbox</c> catalog, indicating whether the opportunity is live
        /// or being tested.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Catalog
        {
            get { return this._catalog; }
            set { this._catalog = value; }
        }

        // Check to see if Catalog property is set
        internal bool IsSetCatalog()
        {
            return this._catalog != null;
        }

        /// <summary>
        /// Gets and sets the property EngagementId. 
        /// <para>
        ///  The identifier of the Engagement associated with this invitation. This links the
        /// invitation to its parent Engagement. 
        /// </para>
        /// </summary>
        public string EngagementId
        {
            get { return this._engagementId; }
            set { this._engagementId = value; }
        }

        // Check to see if EngagementId property is set
        internal bool IsSetEngagementId()
        {
            return this._engagementId != null;
        }

        /// <summary>
        /// Gets and sets the property EngagementTitle. 
        /// <para>
        /// Provides a short title or description of the Engagement Invitation. This title helps
        /// partners quickly identify and differentiate between multiple engagement opportunities.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=40)]
        public string EngagementTitle
        {
            get { return this._engagementTitle; }
            set { this._engagementTitle = value; }
        }

        // Check to see if EngagementTitle property is set
        internal bool IsSetEngagementTitle()
        {
            return this._engagementTitle != null;
        }

        /// <summary>
        /// Gets and sets the property ExpirationDate. 
        /// <para>
        /// Indicates the date and time when the Engagement Invitation will expire. After this
        /// date, the invitation can no longer be accepted, and the opportunity will be unavailable
        /// to the partner.
        /// </para>
        /// </summary>
        public DateTime? ExpirationDate
        {
            get { return this._expirationDate; }
            set { this._expirationDate = value; }
        }

        // Check to see if ExpirationDate property is set
        internal bool IsSetExpirationDate()
        {
            return this._expirationDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// Represents the unique identifier of the Engagement Invitation. This identifier is
        /// used to track the invitation and to manage responses like acceptance or rejection.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property InvitationDate. 
        /// <para>
        /// Indicates the date when the Engagement Invitation was sent to the partner. This provides
        /// context for when the opportunity was shared and helps in tracking the timeline for
        /// engagement.
        /// </para>
        /// </summary>
        public DateTime? InvitationDate
        {
            get { return this._invitationDate; }
            set { this._invitationDate = value; }
        }

        // Check to see if InvitationDate property is set
        internal bool IsSetInvitationDate()
        {
            return this._invitationDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ParticipantType. 
        /// <para>
        /// Identifies the role of the caller in the engagement invitation.
        /// </para>
        /// </summary>
        public ParticipantType ParticipantType
        {
            get { return this._participantType; }
            set { this._participantType = value; }
        }

        // Check to see if ParticipantType property is set
        internal bool IsSetParticipantType()
        {
            return this._participantType != null;
        }

        /// <summary>
        /// Gets and sets the property PayloadType. 
        /// <para>
        /// Describes the type of payload associated with the Engagement Invitation, such as <c>Opportunity</c>
        /// or <c>MarketplaceOffer</c>. This helps partners understand the nature of the engagement
        /// request from AWS.
        /// </para>
        /// </summary>
        public EngagementInvitationPayloadType PayloadType
        {
            get { return this._payloadType; }
            set { this._payloadType = value; }
        }

        // Check to see if PayloadType property is set
        internal bool IsSetPayloadType()
        {
            return this._payloadType != null;
        }

        /// <summary>
        /// Gets and sets the property Receiver. 
        /// <para>
        /// Specifies the partner company or individual that received the Engagement Invitation.
        /// This field is important for tracking who the invitation was sent to within the partner
        /// organization.
        /// </para>
        /// </summary>
        public Receiver Receiver
        {
            get { return this._receiver; }
            set { this._receiver = value; }
        }

        // Check to see if Receiver property is set
        internal bool IsSetReceiver()
        {
            return this._receiver != null;
        }

        /// <summary>
        /// Gets and sets the property SenderAwsAccountId. 
        /// <para>
        /// Specifies the AWS account ID of the sender who initiated the Engagement Invitation.
        /// This allows the partner to identify the AWS entity or representative responsible for
        /// sharing the opportunity.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public string SenderAwsAccountId
        {
            get { return this._senderAwsAccountId; }
            set { this._senderAwsAccountId = value; }
        }

        // Check to see if SenderAwsAccountId property is set
        internal bool IsSetSenderAwsAccountId()
        {
            return this._senderAwsAccountId != null;
        }

        /// <summary>
        /// Gets and sets the property SenderCompanyName. 
        /// <para>
        /// Indicates the name of the company or AWS division that sent the Engagement Invitation.
        /// This information is useful for partners to know which part of AWS is requesting engagement.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=120)]
        public string SenderCompanyName
        {
            get { return this._senderCompanyName; }
            set { this._senderCompanyName = value; }
        }

        // Check to see if SenderCompanyName property is set
        internal bool IsSetSenderCompanyName()
        {
            return this._senderCompanyName != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Represents the current status of the Engagement Invitation, such as <c>Pending</c>,
        /// <c>Accepted</c>, or <c>Rejected</c>. The status helps track the progress and response
        /// to the invitation.
        /// </para>
        /// </summary>
        public InvitationStatus Status
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