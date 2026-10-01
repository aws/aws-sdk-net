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
        /// <summary>
        /// Gets and sets the property CampaignId. 
        /// <para>
        /// The unique identifier for the campaign. The Deliverability dashboard automatically
        /// generates and assigns this identifier to a campaign.
        /// </para>
        /// </summary>
        public string CampaignId { get; set; }

        /// <summary>
        /// Checks to see if the CampaignId property is set.
        /// </summary>
        internal bool IsSetCampaignId() => this.CampaignId != null;

        /// <summary>
        /// Gets and sets the property DeleteRate. 
        /// <para>
        /// The percentage of email messages that were deleted by recipients, without being opened
        /// first. Due to technical limitations, this value only includes recipients who opened
        /// the message by using an email client that supports images.
        /// </para>
        /// </summary>
        public double? DeleteRate { get; set; }

        /// <summary>
        /// Checks to see if the DeleteRate property is set.
        /// </summary>
        internal bool IsSetDeleteRate() => this.DeleteRate.HasValue;

        /// <summary>
        /// Gets and sets the property Esps. 
        /// <para>
        /// The major email providers who handled the email message.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Esps { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Esps property is set.
        /// </summary>
        internal bool IsSetEsps() => this.Esps != null && (this.Esps.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property FirstSeenDateTime. 
        /// <para>
        /// The first time when the email message was delivered to any recipient's inbox. This
        /// value can help you determine how long it took for a campaign to deliver an email message.
        /// </para>
        /// </summary>
        public DateTime? FirstSeenDateTime { get; set; }

        /// <summary>
        /// Checks to see if the FirstSeenDateTime property is set.
        /// </summary>
        internal bool IsSetFirstSeenDateTime() => this.FirstSeenDateTime.HasValue;

        /// <summary>
        /// Gets and sets the property FromAddress. 
        /// <para>
        /// The verified email address that the email message was sent from.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public string FromAddress { get; set; }

        /// <summary>
        /// Checks to see if the FromAddress property is set.
        /// </summary>
        internal bool IsSetFromAddress() => this.FromAddress != null;

        /// <summary>
        /// Gets and sets the property ImageUrl. 
        /// <para>
        /// The URL of an image that contains a snapshot of the email message that was sent.
        /// </para>
        /// </summary>
        public string ImageUrl { get; set; }

        /// <summary>
        /// Checks to see if the ImageUrl property is set.
        /// </summary>
        internal bool IsSetImageUrl() => this.ImageUrl != null;

        /// <summary>
        /// Gets and sets the property InboxCount. 
        /// <para>
        /// The number of email messages that were delivered to recipients’ inboxes.
        /// </para>
        /// </summary>
        public long? InboxCount { get; set; }

        /// <summary>
        /// Checks to see if the InboxCount property is set.
        /// </summary>
        internal bool IsSetInboxCount() => this.InboxCount.HasValue;

        /// <summary>
        /// Gets and sets the property LastSeenDateTime. 
        /// <para>
        /// The last time when the email message was delivered to any recipient's inbox. This
        /// value can help you determine how long it took for a campaign to deliver an email message.
        /// </para>
        /// </summary>
        public DateTime? LastSeenDateTime { get; set; }

        /// <summary>
        /// Checks to see if the LastSeenDateTime property is set.
        /// </summary>
        internal bool IsSetLastSeenDateTime() => this.LastSeenDateTime.HasValue;

        /// <summary>
        /// Gets and sets the property ProjectedVolume. 
        /// <para>
        /// The projected number of recipients that the email message was sent to.
        /// </para>
        /// </summary>
        public long? ProjectedVolume { get; set; }

        /// <summary>
        /// Checks to see if the ProjectedVolume property is set.
        /// </summary>
        internal bool IsSetProjectedVolume() => this.ProjectedVolume.HasValue;

        /// <summary>
        /// Gets and sets the property ReadDeleteRate. 
        /// <para>
        /// The percentage of email messages that were opened and then deleted by recipients.
        /// Due to technical limitations, this value only includes recipients who opened the message
        /// by using an email client that supports images.
        /// </para>
        /// </summary>
        public double? ReadDeleteRate { get; set; }

        /// <summary>
        /// Checks to see if the ReadDeleteRate property is set.
        /// </summary>
        internal bool IsSetReadDeleteRate() => this.ReadDeleteRate.HasValue;

        /// <summary>
        /// Gets and sets the property ReadRate. 
        /// <para>
        /// The percentage of email messages that were opened by recipients. Due to technical
        /// limitations, this value only includes recipients who opened the message by using an
        /// email client that supports images.
        /// </para>
        /// </summary>
        public double? ReadRate { get; set; }

        /// <summary>
        /// Checks to see if the ReadRate property is set.
        /// </summary>
        internal bool IsSetReadRate() => this.ReadRate.HasValue;

        /// <summary>
        /// Gets and sets the property SendingIps. 
        /// <para>
        /// The IP addresses that were used to send the email message.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> SendingIps { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the SendingIps property is set.
        /// </summary>
        internal bool IsSetSendingIps() => this.SendingIps != null && (this.SendingIps.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SpamCount. 
        /// <para>
        /// The number of email messages that were delivered to recipients' spam or junk mail
        /// folders.
        /// </para>
        /// </summary>
        public long? SpamCount { get; set; }

        /// <summary>
        /// Checks to see if the SpamCount property is set.
        /// </summary>
        internal bool IsSetSpamCount() => this.SpamCount.HasValue;

        /// <summary>
        /// Gets and sets the property Subject. 
        /// <para>
        /// The subject line, or title, of the email message.
        /// </para>
        /// </summary>
        public string Subject { get; set; }

        /// <summary>
        /// Checks to see if the Subject property is set.
        /// </summary>
        internal bool IsSetSubject() => this.Subject != null;
    }
}
