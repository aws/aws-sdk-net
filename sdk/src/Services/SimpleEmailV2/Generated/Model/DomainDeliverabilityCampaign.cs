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
 * Do not modify this file. This file is generated from the sesv2-2019-09-27.normal.json service model.
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
namespace Amazon.SimpleEmailV2.Model
{
    /// <summary>
    /// An object that contains the deliverability data for a specific campaign. This data
    /// is available for a campaign only if the campaign sent email by using a domain that
    /// the Deliverability dashboard is enabled for (<c>PutDeliverabilityDashboardOption</c>
    /// operation).
    /// </summary>
    public partial class DomainDeliverabilityCampaign
    {
        private string _campaignId;
        private double? _deleteRate;
        private List<string> _esps = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private DateTime? _firstSeenDateTime;
        private string _fromAddress;
        private string _imageUrl;
        private long? _inboxCount;
        private DateTime? _lastSeenDateTime;
        private long? _projectedVolume;
        private double? _readDeleteRate;
        private double? _readRate;
        private List<string> _sendingIps = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private long? _spamCount;
        private string _subject;

        /// <summary>
        /// Gets and sets the property CampaignId. 
        /// <para>
        /// The unique identifier for the campaign. The Deliverability dashboard automatically
        /// generates and assigns this identifier to a campaign.
        /// </para>
        /// </summary>
        public string CampaignId
        {
            get { return this._campaignId; }
            set { this._campaignId = value; }
        }

        // Check to see if CampaignId property is set
        internal bool IsSetCampaignId()
        {
            return this._campaignId != null;
        }

        /// <summary>
        /// Gets and sets the property DeleteRate. 
        /// <para>
        /// The percentage of email messages that were deleted by recipients, without being opened
        /// first. Due to technical limitations, this value only includes recipients who opened
        /// the message by using an email client that supports images.
        /// </para>
        /// </summary>
        public double? DeleteRate
        {
            get { return this._deleteRate; }
            set { this._deleteRate = value; }
        }

        // Check to see if DeleteRate property is set
        internal bool IsSetDeleteRate()
        {
            return this._deleteRate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Esps. 
        /// <para>
        /// The major email providers who handled the email message.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Esps
        {
            get { return this._esps; }
            set { this._esps = value; }
        }

        // Check to see if Esps property is set
        internal bool IsSetEsps()
        {
            return this._esps != null && (this._esps.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property FirstSeenDateTime. 
        /// <para>
        /// The first time when the email message was delivered to any recipient's inbox. This
        /// value can help you determine how long it took for a campaign to deliver an email message.
        /// </para>
        /// </summary>
        public DateTime? FirstSeenDateTime
        {
            get { return this._firstSeenDateTime; }
            set { this._firstSeenDateTime = value; }
        }

        // Check to see if FirstSeenDateTime property is set
        internal bool IsSetFirstSeenDateTime()
        {
            return this._firstSeenDateTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property FromAddress. 
        /// <para>
        /// The verified email address that the email message was sent from.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public string FromAddress
        {
            get { return this._fromAddress; }
            set { this._fromAddress = value; }
        }

        // Check to see if FromAddress property is set
        internal bool IsSetFromAddress()
        {
            return this._fromAddress != null;
        }

        /// <summary>
        /// Gets and sets the property ImageUrl. 
        /// <para>
        /// The URL of an image that contains a snapshot of the email message that was sent.
        /// </para>
        /// </summary>
        public string ImageUrl
        {
            get { return this._imageUrl; }
            set { this._imageUrl = value; }
        }

        // Check to see if ImageUrl property is set
        internal bool IsSetImageUrl()
        {
            return this._imageUrl != null;
        }

        /// <summary>
        /// Gets and sets the property InboxCount. 
        /// <para>
        /// The number of email messages that were delivered to recipients’ inboxes.
        /// </para>
        /// </summary>
        public long? InboxCount
        {
            get { return this._inboxCount; }
            set { this._inboxCount = value; }
        }

        // Check to see if InboxCount property is set
        internal bool IsSetInboxCount()
        {
            return this._inboxCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LastSeenDateTime. 
        /// <para>
        /// The last time when the email message was delivered to any recipient's inbox. This
        /// value can help you determine how long it took for a campaign to deliver an email message.
        /// </para>
        /// </summary>
        public DateTime? LastSeenDateTime
        {
            get { return this._lastSeenDateTime; }
            set { this._lastSeenDateTime = value; }
        }

        // Check to see if LastSeenDateTime property is set
        internal bool IsSetLastSeenDateTime()
        {
            return this._lastSeenDateTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ProjectedVolume. 
        /// <para>
        /// The projected number of recipients that the email message was sent to.
        /// </para>
        /// </summary>
        public long? ProjectedVolume
        {
            get { return this._projectedVolume; }
            set { this._projectedVolume = value; }
        }

        // Check to see if ProjectedVolume property is set
        internal bool IsSetProjectedVolume()
        {
            return this._projectedVolume.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ReadDeleteRate. 
        /// <para>
        /// The percentage of email messages that were opened and then deleted by recipients.
        /// Due to technical limitations, this value only includes recipients who opened the message
        /// by using an email client that supports images.
        /// </para>
        /// </summary>
        public double? ReadDeleteRate
        {
            get { return this._readDeleteRate; }
            set { this._readDeleteRate = value; }
        }

        // Check to see if ReadDeleteRate property is set
        internal bool IsSetReadDeleteRate()
        {
            return this._readDeleteRate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ReadRate. 
        /// <para>
        /// The percentage of email messages that were opened by recipients. Due to technical
        /// limitations, this value only includes recipients who opened the message by using an
        /// email client that supports images.
        /// </para>
        /// </summary>
        public double? ReadRate
        {
            get { return this._readRate; }
            set { this._readRate = value; }
        }

        // Check to see if ReadRate property is set
        internal bool IsSetReadRate()
        {
            return this._readRate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SendingIps. 
        /// <para>
        /// The IP addresses that were used to send the email message.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> SendingIps
        {
            get { return this._sendingIps; }
            set { this._sendingIps = value; }
        }

        // Check to see if SendingIps property is set
        internal bool IsSetSendingIps()
        {
            return this._sendingIps != null && (this._sendingIps.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SpamCount. 
        /// <para>
        /// The number of email messages that were delivered to recipients' spam or junk mail
        /// folders.
        /// </para>
        /// </summary>
        public long? SpamCount
        {
            get { return this._spamCount; }
            set { this._spamCount = value; }
        }

        // Check to see if SpamCount property is set
        internal bool IsSetSpamCount()
        {
            return this._spamCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Subject. 
        /// <para>
        /// The subject line, or title, of the email message.
        /// </para>
        /// </summary>
        public string Subject
        {
            get { return this._subject; }
            set { this._subject = value; }
        }

        // Check to see if Subject property is set
        internal bool IsSetSubject()
        {
            return this._subject != null;
        }

    }
}