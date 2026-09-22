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
 * Do not modify this file. This file is generated from the cloudwatchomni-2025-01-01.normal.json service model.
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
    /// Container for the parameters to the CreateAlert operation.
    /// Creates a new alert within a space.
    /// 
    ///  
    /// <para>
    /// Use GetAlert and ListAlerts to retrieve alerts, UpdateAlert to modify one, and DeleteAlert
    /// to remove it.
    /// </para>
    /// </summary>
    public partial class CreateAlertRequest : AmazonCloudWatchOmniRequest
    {
        private string _clientToken;
        private string _description;
        private string _name;
        private List<NotificationRule> _notificationRules = AWSConfigs.InitializeCollections ? new List<NotificationRule>() : null;
        private bool? _notificationsEnabled;
        private string _profileId;
        private Rule _rule;
        private string _spaceId;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// Idempotency token for safe retries. Retrying with the same token within the idempotency
        /// window returns the original alert instead of creating a duplicate.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// An optional description of the alert.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// Alert name, for display. Max 256 (the AlarmName budget). Not the alert's identity:
        /// the backend mints a separate uuid as the {@link AlertId}, so the name need not be
        /// unique within a space and addressing an alert never depends on it. UpdateAlert accepts
        /// a new name to rename the alert.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property NotificationRules. 
        /// <para>
        /// The notification rules that determine when and where notifications are sent.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=5)]
        public List<NotificationRule> NotificationRules
        {
            get { return this._notificationRules; }
            set { this._notificationRules = value; }
        }

        // Check to see if NotificationRules property is set
        internal bool IsSetNotificationRules()
        {
            return this._notificationRules != null && (this._notificationRules.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property NotificationsEnabled. 
        /// <para>
        /// Whether actions (notifications) are enabled for this alert. Defaults to true when
        /// omitted.
        /// </para>
        /// </summary>
        public bool? NotificationsEnabled
        {
            get { return this._notificationsEnabled; }
            set { this._notificationsEnabled = value; }
        }

        // Check to see if NotificationsEnabled property is set
        internal bool IsSetNotificationsEnabled()
        {
            return this._notificationsEnabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ProfileId. 
        /// <para>
        /// The ID of the access profile the alert uses to evaluate its query and execute notifications.
        /// The caller supplies it: there is no managed alert profile, and the service does not
        /// pick one on the caller's behalf.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string ProfileId
        {
            get { return this._profileId; }
            set { this._profileId = value; }
        }

        // Check to see if ProfileId property is set
        internal bool IsSetProfileId()
        {
            return this._profileId != null;
        }

        /// <summary>
        /// Gets and sets the property Rule. 
        /// <para>
        /// The rule that defines how the alert is evaluated.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public Rule Rule
        {
            get { return this._rule; }
            set { this._rule = value; }
        }

        // Check to see if Rule property is set
        internal bool IsSetRule()
        {
            return this._rule != null;
        }

        /// <summary>
        /// Gets and sets the property SpaceId. 
        /// <para>
        /// The unique ID of the space to create the alert in.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string SpaceId
        {
            get { return this._spaceId; }
            set { this._spaceId = value; }
        }

        // Check to see if SpaceId property is set
        internal bool IsSetSpaceId()
        {
            return this._spaceId != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags to associate with the alert.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}