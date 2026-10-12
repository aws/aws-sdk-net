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
    /// This is the response object from the GetEngagementInvitation operation.
    /// </summary>
    public partial class GetEngagementInvitationResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) that identifies the engagement invitation.
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
        /// Indicates the catalog from which the engagement invitation details are retrieved.
        /// This field helps in identifying the appropriate catalog (e.g., <c>AWS</c> or <c>Sandbox</c>)
        /// used in the request.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Catalog { get; set; }

        /// <summary>
        /// Checks to see if the Catalog property is set.
        /// </summary>
        internal bool IsSetCatalog() => this.Catalog != null;

        /// <summary>
        /// Gets and sets the property EngagementDescription. 
        /// <para>
        /// The description of the engagement associated with this invitation.
        /// </para>
        /// </summary>
        public string EngagementDescription { get; set; }

        /// <summary>
        /// Checks to see if the EngagementDescription property is set.
        /// </summary>
        internal bool IsSetEngagementDescription() => this.EngagementDescription != null;

        /// <summary>
        /// Gets and sets the property EngagementId. 
        /// <para>
        /// The identifier of the engagement associated with this invitation.This ID links the
        /// invitation to its corresponding engagement.
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
        /// The title of the engagement invitation, summarizing the purpose or objectives of the
        /// opportunity shared by AWS.
        /// </para>
        /// </summary>
        public string EngagementTitle { get; set; }

        /// <summary>
        /// Checks to see if the EngagementTitle property is set.
        /// </summary>
        internal bool IsSetEngagementTitle() => this.EngagementTitle != null;

        /// <summary>
        /// Gets and sets the property EnrichmentContext. 
        /// <para>
        /// The enrichment data for the engagement associated with this invitation. You can view
        /// propensity scores, program eligibility, and lead readiness assessments before taking
        /// action on the invitation.
        /// </para>
        /// </summary>
        public EnrichmentContext EnrichmentContext { get; set; }

        /// <summary>
        /// Checks to see if the EnrichmentContext property is set.
        /// </summary>
        internal bool IsSetEnrichmentContext() => this.EnrichmentContext != null;

        /// <summary>
        /// Gets and sets the property ExistingMembers. 
        /// <para>
        /// A list of active members currently part of the Engagement. This array contains a maximum
        /// of 10 members, each represented by an object with the following properties.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// CompanyName: The name of the member's company.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// WebsiteUrl: The website URL of the member's company.
        /// </para>
        ///  </li> </ul>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<EngagementMemberSummary> ExistingMembers { get; set; } = AWSConfigs.InitializeCollections ? new List<EngagementMemberSummary>() : null;

        /// <summary>
        /// Checks to see if the ExistingMembers property is set.
        /// </summary>
        internal bool IsSetExistingMembers() => this.ExistingMembers != null && (this.ExistingMembers.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ExpirationDate. 
        /// <para>
        /// Indicates the date on which the engagement invitation will expire if not accepted
        /// by the partner.
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
        /// Unique identifier assigned to the engagement invitation being retrieved.
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
        /// The date when the engagement invitation was sent to the partner.
        /// </para>
        /// </summary>
        public DateTime? InvitationDate { get; set; }

        /// <summary>
        /// Checks to see if the InvitationDate property is set.
        /// </summary>
        internal bool IsSetInvitationDate() => this.InvitationDate.HasValue;

        /// <summary>
        /// Gets and sets the property InvitationMessage. 
        /// <para>
        /// The message sent to the invited partner when the invitation was created.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public string InvitationMessage { get; set; }

        /// <summary>
        /// Checks to see if the InvitationMessage property is set.
        /// </summary>
        internal bool IsSetInvitationMessage() => this.InvitationMessage != null;

        /// <summary>
        /// Gets and sets the property Payload. 
        /// <para>
        /// Details of the engagement invitation payload, including specific data relevant to
        /// the invitation's contents, such as customer information and opportunity insights.
        /// </para>
        /// </summary>
        public Payload Payload { get; set; }

        /// <summary>
        /// Checks to see if the Payload property is set.
        /// </summary>
        internal bool IsSetPayload() => this.Payload != null;

        /// <summary>
        /// Gets and sets the property PayloadType. 
        /// <para>
        /// The type of payload contained in the engagement invitation, indicating what data or
        /// context the payload covers.
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
        /// Information about the partner organization or team that received the engagement invitation,
        /// including contact details and identifiers.
        /// </para>
        /// </summary>
        public Receiver Receiver { get; set; }

        /// <summary>
        /// Checks to see if the Receiver property is set.
        /// </summary>
        internal bool IsSetReceiver() => this.Receiver != null;

        /// <summary>
        /// Gets and sets the property RejectionReason. 
        /// <para>
        /// If the engagement invitation was rejected, this field specifies the reason provided
        /// by the partner for the rejection.
        /// </para>
        /// </summary>
        public string RejectionReason { get; set; }

        /// <summary>
        /// Checks to see if the RejectionReason property is set.
        /// </summary>
        internal bool IsSetRejectionReason() => this.RejectionReason != null;

        /// <summary>
        /// Gets and sets the property SenderAwsAccountId. 
        /// <para>
        /// Specifies the AWS Account ID of the sender, which identifies the AWS team responsible
        /// for sharing the engagement invitation.
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
        /// The name of the AWS organization or team that sent the engagement invitation.
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
        /// The current status of the engagement invitation.
        /// </para>
        /// </summary>
        public InvitationStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
