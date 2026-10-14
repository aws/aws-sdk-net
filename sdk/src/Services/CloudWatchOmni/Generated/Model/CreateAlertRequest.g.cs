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
    /// Container for the parameters to the CreateAlert operation. Creates a new alert within
    /// a space. Use GetAlert and ListAlerts to retrieve alerts, UpdateAlert to modify one,
    /// and DeleteAlert to remove it.
    /// </summary>
    public partial class CreateAlertRequest : AmazonCloudWatchOmniRequest
    {
        /// <summary>
        /// Gets and sets the property ClientToken. Idempotency token for safe retries. Retrying
        /// with the same token within the idempotency window returns the original alert instead
        /// of creating a duplicate.
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property Description. An optional description of the alert.
        /// </summary>
        [AWSProperty(Max = 1024)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property Name. Alert name, for display. Max 256 (the AlarmName budget).
        /// Not the alert's identity: the backend mints a separate uuid as the {@link AlertId},
        /// so the name need not be unique within a space and addressing an alert never depends
        /// on it. UpdateAlert accepts a new name to rename the alert.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property NotificationRules. The notification rules that determine
        /// when and where notifications are sent.
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
        /// enabled for this alert. Defaults to true when omitted.
        /// </summary>
        public bool? NotificationsEnabled { get; set; }

        /// <summary>
        /// Checks to see if the NotificationsEnabled property is set.
        /// </summary>
        internal bool IsSetNotificationsEnabled() => this.NotificationsEnabled.HasValue;

        /// <summary>
        /// Gets and sets the property ProfileId. The ID of the access profile the alert uses
        /// to evaluate its query and execute notifications. The caller supplies it: there is
        /// no managed alert profile, and the service does not pick one on the caller's behalf.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
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
        /// Gets and sets the property SpaceId. The unique ID of the space to create the alert
        /// in.
        /// </summary>
        [AWSProperty(Required = true)]
        public string SpaceId { get; set; }

        /// <summary>
        /// Checks to see if the SpaceId property is set.
        /// </summary>
        internal bool IsSetSpaceId() => this.SpaceId != null;

        /// <summary>
        /// Gets and sets the property Tags. The tags to associate with the alert.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 50)]
        public Dictionary<string, string> Tags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
