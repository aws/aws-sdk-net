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

namespace Amazon.PartnerCentralMarketing.Model
{
    /// <summary>
    /// Summary representation of an asset for list operations.
    /// </summary>
    public partial class CampaignAssetSummary
    {
        /// <summary>
        /// Gets and sets the property Category. The asset category.
        /// </summary>
        [AWSProperty(Required = true)]
        public CampaignAssetCategory Category { get; set; }

        /// <summary>
        /// Checks to see if the Category property is set.
        /// </summary>
        internal bool IsSetCategory() => this.Category != null;

        /// <summary>
        /// Gets and sets the property DeliveryStatus. Whether the platform has delivered the
        /// asset.
        /// </summary>
        public DeliveryStatus DeliveryStatus { get; set; }

        /// <summary>
        /// Checks to see if the DeliveryStatus property is set.
        /// </summary>
        internal bool IsSetDeliveryStatus() => this.DeliveryStatus != null;

        /// <summary>
        /// Gets and sets the property DeliveryStatusReason. Why delivery failed. Present only
        /// when DeliveryStatus is FAILED. For an email the platform rejected: SENDER_EMAIL_INVALID,
        /// RECIPIENT_LIST_EMPTY, MAILING_CREDITS_EXHAUSTED or RECIPIENT_LIMIT_EXCEEDED. Otherwise
        /// DELIVERY_FAILED. A Facebook post refused because its connection has no Page is FAILED
        /// with SOCIAL_CONNECTION_PAGE_REQUIRED, and withdrawn: reconnect Facebook with a Page
        /// selected. A social post the platform stopped retrying, because it could not publish
        /// within 12 hours of its scheduled time, is FAILED with DELIVERY_FAILED. Any other social
        /// post that could not be published stays PENDING while it is investigated, and is reported
        /// FAILED with DELIVERY_FAILED once it is confirmed it will not go out. Deactivate and
        /// activate the asset again to retry.
        /// </summary>
        public CampaignAssetStateReason DeliveryStatusReason { get; set; }

        /// <summary>
        /// Checks to see if the DeliveryStatusReason property is set.
        /// </summary>
        internal bool IsSetDeliveryStatusReason() => this.DeliveryStatusReason != null;

        /// <summary>
        /// Gets and sets the property FileFormat. Concrete file format of the finished artifact.
        /// </summary>
        public FileFormat FileFormat { get; set; }

        /// <summary>
        /// Checks to see if the FileFormat property is set.
        /// </summary>
        internal bool IsSetFileFormat() => this.FileFormat != null;

        /// <summary>
        /// Gets and sets the property Id. The asset identifier.
        /// </summary>
        [AWSProperty(Required = true, Min = 17, Max = 17)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property LastActivationStatus. How the last hand-over to the delivery
        /// platform ended. Absent before the first activation.
        /// </summary>
        public AttemptStatus LastActivationStatus { get; set; }

        /// <summary>
        /// Checks to see if the LastActivationStatus property is set.
        /// </summary>
        internal bool IsSetLastActivationStatus() => this.LastActivationStatus != null;

        /// <summary>
        /// Gets and sets the property LinkLabel. DOCUMENT only: the words a page uses for this
        /// document, such as "eBook". A client listing the candidates for an `AssetLink` field
        /// reads it here, so a preview can update on pick without a fetch.
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public string LinkLabel { get; set; }

        /// <summary>
        /// Checks to see if the LinkLabel property is set.
        /// </summary>
        internal bool IsSetLinkLabel() => this.LinkLabel != null;

        /// <summary>
        /// Gets and sets the property Name. The display name.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 200)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property ScheduledSendAt. The send time, present only when `SendMode`
        /// is `SCHEDULED`. It reaches the delivery platform at the asset's next activation. Was
        /// `scheduleDate: UtcDate`; retyped with the write member of the same name.
        /// </summary>
        public DateTime? ScheduledSendAt { get; set; }

        /// <summary>
        /// Checks to see if the ScheduledSendAt property is set.
        /// </summary>
        internal bool IsSetScheduledSendAt() => this.ScheduledSendAt.HasValue;

        /// <summary>
        /// Gets and sets the property SendMode. When this asset sends, as chosen with UpdateCampaignAsset.
        /// `EMAIL` and `SOCIAL_POST` only — the two categories whose delivery platform holds
        /// a schedule of its own. Absent until chosen, and then the asset reports `SEND_MODE_MISSING`.
        /// </summary>
        public SendMode SendMode { get; set; }

        /// <summary>
        /// Checks to see if the SendMode property is set.
        /// </summary>
        internal bool IsSetSendMode() => this.SendMode != null;

        /// <summary>
        /// Gets and sets the property SocialPlatform. SOCIAL_POST only: the platform the post
        /// goes to. Join it with ListSocialConnections' status for that platform to show a post
        /// that cannot activate (a connection missing, EXPIRED or PAGE_REQUIRED) before Start
        /// is pressed.
        /// </summary>
        public Platform SocialPlatform { get; set; }

        /// <summary>
        /// Checks to see if the SocialPlatform property is set.
        /// </summary>
        internal bool IsSetSocialPlatform() => this.SocialPlatform != null;

        /// <summary>
        /// Gets and sets the property SourceAssetTemplateId. The asset template this asset was
        /// created from. The same value `CampaignAsset.SourceAssetTemplateId` reports, and absent
        /// when it is.
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string SourceAssetTemplateId { get; set; }

        /// <summary>
        /// Checks to see if the SourceAssetTemplateId property is set.
        /// </summary>
        internal bool IsSetSourceAssetTemplateId() => this.SourceAssetTemplateId != null;

        /// <summary>
        /// Gets and sets the property StartedAt. When the asset first went live, set once. Absent
        /// if it never has.
        /// </summary>
        public DateTime? StartedAt { get; set; }

        /// <summary>
        /// Checks to see if the StartedAt property is set.
        /// </summary>
        internal bool IsSetStartedAt() => this.StartedAt.HasValue;

        /// <summary>
        /// Gets and sets the property State. Where the asset sits in its lifecycle.
        /// </summary>
        public CampaignAssetState State { get; set; }

        /// <summary>
        /// Checks to see if the State property is set.
        /// </summary>
        internal bool IsSetState() => this.State != null;
    }
}
