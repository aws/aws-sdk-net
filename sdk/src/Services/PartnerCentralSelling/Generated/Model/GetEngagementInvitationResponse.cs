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
    /// This is the response object from the GetEngagementInvitation operation.
    /// </summary>
    public partial class GetEngagementInvitationResponse : AmazonWebServiceResponse
    {
        private string _arn;
        private string _catalog;
        private string _engagementTitle;
        private DateTime? _expirationDate;
        private string _id;
        private DateTime? _invitationDate;
        private Payload _payload;
        private EngagementInvitationPayloadType _payloadType;
        private Receiver _receiver;
        private string _rejectionReason;
        private string _senderAwsAccountId;
        private string _senderCompanyName;
        private InvitationStatus _status;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) that identifies the engagement invitation.
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
        /// Indicates the catalog from which the engagement invitation details are retrieved.
        /// This field helps in identifying the appropriate catalog (e.g., <c>AWS</c> or <c>Sandbox</c>)
        /// used in the request.
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
        /// Gets and sets the property EngagementTitle. 
        /// <para>
        /// The title of the engagement invitation, summarizing the purpose or objectives of the
        /// opportunity shared by AWS.
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
        /// Indicates the date on which the engagement invitation will expire if not accepted
        /// by the partner.
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
        /// Unique identifier assigned to the engagement invitation being retrieved.
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
        /// The date when the engagement invitation was sent to the partner.
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
        /// Gets and sets the property Payload. 
        /// <para>
        /// Details of the engagement invitation payload, including specific data relevant to
        /// the invitation's contents, such as customer information and opportunity insights.
        /// </para>
        /// </summary>
        public Payload Payload
        {
            get { return this._payload; }
            set { this._payload = value; }
        }

        // Check to see if Payload property is set
        internal bool IsSetPayload()
        {
            return this._payload != null;
        }

        /// <summary>
        /// Gets and sets the property PayloadType. 
        /// <para>
        /// The type of payload contained in the engagement invitation, indicating what data or
        /// context the payload covers.
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
        /// Information about the partner organization or team that received the engagement invitation,
        /// including contact details and identifiers.
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
        /// Gets and sets the property RejectionReason. 
        /// <para>
        /// If the engagement invitation was rejected, this field specifies the reason provided
        /// by the partner for the rejection.
        /// </para>
        /// </summary>
        public string RejectionReason
        {
            get { return this._rejectionReason; }
            set { this._rejectionReason = value; }
        }

        // Check to see if RejectionReason property is set
        internal bool IsSetRejectionReason()
        {
            return this._rejectionReason != null;
        }

        /// <summary>
        /// Gets and sets the property SenderAwsAccountId. 
        /// <para>
        /// Specifies the AWS Account ID of the sender, which identifies the AWS team responsible
        /// for sharing the engagement invitation. 
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
        /// The name of the AWS organization or team that sent the engagement invitation.
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
        /// The current status of the engagement invitation.
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