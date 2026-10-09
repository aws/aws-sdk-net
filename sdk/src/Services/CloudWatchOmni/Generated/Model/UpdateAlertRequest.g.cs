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
    /// Container for the parameters to the UpdateAlert operation. Updates an existing alert.
    /// Only non-null fields overwrite existing values.
    /// </summary>
    public partial class UpdateAlertRequest : AmazonCloudWatchOmniRequest
    {
        /// <summary>
        /// Gets and sets the property AlertId. The alert to update.
        /// </summary>
        [AWSProperty(Required = true, Min = 32, Max = 32)]
        public string AlertId { get; set; }

        /// <summary>
        /// Checks to see if the AlertId property is set.
        /// </summary>
        internal bool IsSetAlertId() => this.AlertId != null;

        /// <summary>
        /// Gets and sets the property Description. A new description of the alert. Omit to leave
        /// unchanged.
        /// </summary>
        [AWSProperty(Max = 1024)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property Name. A new display name for the alert. Omit to leave the
        /// name unchanged (apply-if-present / PATCH). Same constraints as CreateAlert.name; the
        /// name is not the alert's identity, so a rename never changes the alertId.
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property NotificationRules. Replaces the entire notification rule
        /// list when present; full-replace, not merge. Omitted = leave existing rules unchanged.
        /// An empty list clears all rules (the alert keeps evaluating; only notifications stop).
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
        /// Gets and sets the property NotificationsEnabled. Whether actions (notifications) are
        /// enabled for this alert. Omitted = leave existing value unchanged.
        /// </summary>
        public bool? NotificationsEnabled { get; set; }

        /// <summary>
        /// Checks to see if the NotificationsEnabled property is set.
        /// </summary>
        internal bool IsSetNotificationsEnabled() => this.NotificationsEnabled.HasValue;

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
        /// Omit to leave unchanged. Each sub-block is replaced whole when present: {@code query},
        /// {@code condition}, {@code evaluation} and {@code noData} are applied only when supplied,
        /// and within a supplied block an omitted optional member is cleared to unset (null/absent)
        /// rather than preserved from the stored alert or defaulted. See {@link AlertCondition}
        /// and {@link AlertEvaluation}.
        /// </summary>
        public Rule Rule { get; set; }

        /// <summary>
        /// Checks to see if the Rule property is set.
        /// </summary>
        internal bool IsSetRule() => this.Rule != null;

        /// <summary>
        /// Gets and sets the property SpaceId. The unique ID of the space.
        /// </summary>
        [AWSProperty(Required = true)]
        public string SpaceId { get; set; }

        /// <summary>
        /// Checks to see if the SpaceId property is set.
        /// </summary>
        internal bool IsSetSpaceId() => this.SpaceId != null;
    }
}
