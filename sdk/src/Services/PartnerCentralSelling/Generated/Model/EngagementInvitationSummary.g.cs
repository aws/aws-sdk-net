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

namespace Amazon.PartnerCentralSelling.Model
{
    /// <summary>
    /// Provides a summarized view of the Engagement Invitation, including details like the
    /// identifier, status, and sender. This summary helps partners track and manage AWS originated
    /// opportunities.
    /// </summary>
    public partial class EngagementInvitationSummary
    {
        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Engagement Invitation. The ARN is a unique identifier
        /// that allows partners to reference the invitation in their system and manage its lifecycle.
        /// </para>
        /// </summary>
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property Catalog. 
        /// <para>
        /// Specifies the catalog in which the Engagement Invitation resides. This can be either
        /// the <c>AWS</c> or <c>Sandbox</c> catalog, indicating whether the opportunity is live
        /// or being tested.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Catalog { get; set; }

        /// <summary>
        /// Checks to see if the Catalog property is set.
        /// </summary>
        internal bool IsSetCatalog() => this.Catalog != null;

        /// <summary>
        /// Gets and sets the property EngagementId. 
        /// <para>
        ///  The identifier of the Engagement associated with this invitation. This links the
        /// invitation to its parent Engagement. 
        /// </para>
        /// </summary>
        public string EngagementId { get; set; }

        /// <summary>
        /// Checks to see if the EngagementId property is set.
        /// </summary>
        internal bool IsSetEngagementId() => this.EngagementId != null;

        /// <summary>
        /// Gets and sets the property EngagementTitle. 
        /// <para>
        /// Provides a short title or description of the Engagement Invitation. This title helps
        /// partners quickly identify and differentiate between multiple engagement opportunities.
        /// </para>
        /// </summary>
        public string EngagementTitle { get; set; }

        /// <summary>
        /// Checks to see if the EngagementTitle property is set.
        /// </summary>
        internal bool IsSetEngagementTitle() => this.EngagementTitle != null;

        /// <summary>
        /// Gets and sets the property ExpirationDate. 
        /// <para>
        /// Indicates the date and time when the Engagement Invitation will expire. After this
        /// date, the invitation can no longer be accepted, and the opportunity will be unavailable
        /// to the partner.
        /// </para>
        /// </summary>
        public DateTime? ExpirationDate { get; set; }

        /// <summary>
        /// Checks to see if the ExpirationDate property is set.
        /// </summary>
        internal bool IsSetExpirationDate() => this.ExpirationDate.HasValue;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// Represents the unique identifier of the Engagement Invitation. This identifier is
        /// used to track the invitation and to manage responses like acceptance or rejection.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property InvitationDate. 
        /// <para>
        /// Indicates the date when the Engagement Invitation was sent to the partner. This provides
        /// context for when the opportunity was shared and helps in tracking the timeline for
        /// engagement.
        /// </para>
        /// </summary>
        public DateTime? InvitationDate { get; set; }

        /// <summary>
        /// Checks to see if the InvitationDate property is set.
        /// </summary>
        internal bool IsSetInvitationDate() => this.InvitationDate.HasValue;

        /// <summary>
        /// Gets and sets the property ParticipantType. 
        /// <para>
        /// Identifies the role of the caller in the engagement invitation.
        /// </para>
        /// </summary>
        public ParticipantType ParticipantType { get; set; }

        /// <summary>
        /// Checks to see if the ParticipantType property is set.
        /// </summary>
        internal bool IsSetParticipantType() => this.ParticipantType != null;

        /// <summary>
        /// Gets and sets the property PayloadType. 
        /// <para>
        /// Describes the type of payload associated with the Engagement Invitation, such as <c>Opportunity</c>
        /// or <c>MarketplaceOffer</c>. This helps partners understand the nature of the engagement
        /// request from AWS.
        /// </para>
        /// </summary>
        public EngagementInvitationPayloadType PayloadType { get; set; }

        /// <summary>
        /// Checks to see if the PayloadType property is set.
        /// </summary>
        internal bool IsSetPayloadType() => this.PayloadType != null;

        /// <summary>
        /// Gets and sets the property Receiver. 
        /// <para>
        /// Specifies the partner company or individual that received the Engagement Invitation.
        /// This field is important for tracking who the invitation was sent to within the partner
        /// organization.
        /// </para>
        /// </summary>
        public Receiver Receiver { get; set; }

        /// <summary>
        /// Checks to see if the Receiver property is set.
        /// </summary>
        internal bool IsSetReceiver() => this.Receiver != null;

        /// <summary>
        /// Gets and sets the property SenderAwsAccountId. 
        /// <para>
        /// Specifies the AWS account ID of the sender who initiated the Engagement Invitation.
        /// This allows the partner to identify the AWS entity or representative responsible for
        /// sharing the opportunity.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public string SenderAwsAccountId { get; set; }

        /// <summary>
        /// Checks to see if the SenderAwsAccountId property is set.
        /// </summary>
        internal bool IsSetSenderAwsAccountId() => this.SenderAwsAccountId != null;

        /// <summary>
        /// Gets and sets the property SenderCompanyName. 
        /// <para>
        /// Indicates the name of the company or AWS division that sent the Engagement Invitation.
        /// This information is useful for partners to know which part of AWS is requesting engagement.
        /// </para>
        /// </summary>
        public string SenderCompanyName { get; set; }

        /// <summary>
        /// Checks to see if the SenderCompanyName property is set.
        /// </summary>
        internal bool IsSetSenderCompanyName() => this.SenderCompanyName != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Represents the current status of the Engagement Invitation, such as <c>Pending</c>,
        /// <c>Accepted</c>, or <c>Rejected</c>. The status helps track the progress and response
        /// to the invitation.
        /// </para>
        /// </summary>
        public InvitationStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
