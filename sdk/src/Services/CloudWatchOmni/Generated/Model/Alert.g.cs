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

namespace Amazon.CloudWatchOmni.Model
{
    /// <summary>
    /// Full alert entity, returned by both CreateAlert and GetAlert. A create and a read
    /// of the same alert describe it identically except for {@code state}, which only the
    /// read paths populate. UpdateAlert returns an empty response.
    /// </summary>
    public partial class Alert
    {
        /// <summary>
        /// Gets and sets the property AccountId. The AWS account ID that owns the alert.
        /// </summary>
        [AWSProperty(Required = true, Min = 12, Max = 12)]
        public string AccountId { get; set; }

        /// <summary>
        /// Checks to see if the AccountId property is set.
        /// </summary>
        internal bool IsSetAccountId() => this.AccountId != null;

        /// <summary>
        /// Gets and sets the property AlertArn. The Amazon Resource Name (ARN) of the alert.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 2048)]
        public string AlertArn { get; set; }

        /// <summary>
        /// Checks to see if the AlertArn property is set.
        /// </summary>
        internal bool IsSetAlertArn() => this.AlertArn != null;

        /// <summary>
        /// Gets and sets the property AlertId. The stable alert identifier (see {@link AlertId}),
        /// minted on create and immutable across updates. Use it (not {@code name}) to address
        /// the alert on GetAlert/UpdateAlert/DeleteAlert; it is also the ARN's resource id.
        /// </summary>
        [AWSProperty(Min = 32, Max = 32)]
        public string AlertId { get; set; }

        /// <summary>
        /// Checks to see if the AlertId property is set.
        /// </summary>
        internal bool IsSetAlertId() => this.AlertId != null;

        /// <summary>
        /// Gets and sets the property CreatedAt. The timestamp when the alert was created.
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property Description. An optional description of the alert.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property Name. The name of the alert.
        /// </summary>
        [AWSProperty(Required = true)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property NotificationRules. The notification rules for the alert.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 5)]
        public List<NotificationRule> NotificationRules { get; set; } = AWSConfigs.InitializeCollections ? new List<NotificationRule>() : null;

        /// <summary>
        /// Checks to see if the NotificationRules property is set.
        /// </summary>
        internal bool IsSetNotificationRules() => this.NotificationRules != null && (this.NotificationRules.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property NotificationStatus. Whether notifications are enabled.
        /// </summary>
        public NotificationStatus NotificationStatus { get; set; }

        /// <summary>
        /// Checks to see if the NotificationStatus property is set.
        /// </summary>
        internal bool IsSetNotificationStatus() => this.NotificationStatus != null;

        /// <summary>
        /// Gets and sets the property ProfileId. The ID of the access profile associated with
        /// the alert.
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string ProfileId { get; set; }

        /// <summary>
        /// Checks to see if the ProfileId property is set.
        /// </summary>
        internal bool IsSetProfileId() => this.ProfileId != null;

        /// <summary>
        /// Gets and sets the property Rule. The rule that defines how the alert is evaluated.
        /// </summary>
        [AWSProperty(Required = true)]
        public Rule Rule { get; set; }

        /// <summary>
        /// Checks to see if the Rule property is set.
        /// </summary>
        internal bool IsSetRule() => this.Rule != null;

        /// <summary>
        /// Gets and sets the property SpaceId. The ID of the space the alert belongs to.
        /// </summary>
        public string SpaceId { get; set; }

        /// <summary>
        /// Checks to see if the SpaceId property is set.
        /// </summary>
        internal bool IsSetSpaceId() => this.SpaceId != null;

        /// <summary>
        /// Gets and sets the property State. Live evaluation state (read-only, system-managed).
        /// Populated by GetAlert. ListAlerts reports state on `AlertSummary` instead, where it
        /// stays required. Absent on CreateAlert: a newly created alert has never been evaluated,
        /// so any state reported there would be a default rather than an observation. Call GetAlert
        /// for live state. Not @required for that reason — GetAlert always populates it. `contributorSummary`
        /// is nested inside this member, so it too is absent on CreateAlert.
        /// </summary>
        public AlertStateInfo State { get; set; }

        /// <summary>
        /// Checks to see if the State property is set.
        /// </summary>
        internal bool IsSetState() => this.State != null;

        /// <summary>
        /// Gets and sets the property UpdatedAt. The timestamp when the alert was last updated.
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the UpdatedAt property is set.
        /// </summary>
        internal bool IsSetUpdatedAt() => this.UpdatedAt.HasValue;
    }
}
