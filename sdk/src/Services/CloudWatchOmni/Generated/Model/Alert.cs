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
    /// Full alert entity, returned by both CreateAlert and GetAlert. A create and a read
    /// of the same alert describe it identically except for {@code state}, which only the
    /// read paths populate. UpdateAlert returns an empty response.
    /// </summary>
    public partial class Alert
    {
        private string _accountId;
        private string _alertArn;
        private string _alertId;
        private DateTime? _createdAt;
        private string _description;
        private string _name;
        private List<NotificationRule> _notificationRules = AWSConfigs.InitializeCollections ? new List<NotificationRule>() : null;
        private NotificationStatus _notificationStatus;
        private string _profileId;
        private Rule _rule;
        private string _spaceId;
        private AlertStateInfo _state;
        private DateTime? _updatedAt;

        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// The AWS account ID that owns the alert.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=12, Max=12)]
        public string AccountId
        {
            get { return this._accountId; }
            set { this._accountId = value; }
        }

        // Check to see if AccountId property is set
        internal bool IsSetAccountId()
        {
            return this._accountId != null;
        }

        /// <summary>
        /// Gets and sets the property AlertArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the alert.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2048)]
        public string AlertArn
        {
            get { return this._alertArn; }
            set { this._alertArn = value; }
        }

        // Check to see if AlertArn property is set
        internal bool IsSetAlertArn()
        {
            return this._alertArn != null;
        }

        /// <summary>
        /// Gets and sets the property AlertId. 
        /// <para>
        /// The stable alert identifier (see {@link AlertId}), minted on create and immutable
        /// across updates. Use it (not {@code name}) to address the alert on GetAlert/UpdateAlert/DeleteAlert;
        /// it is also the ARN's resource id.
        /// </para>
        /// </summary>
        [AWSProperty(Min=32, Max=32)]
        public string AlertId
        {
            get { return this._alertId; }
            set { this._alertId = value; }
        }

        // Check to see if AlertId property is set
        internal bool IsSetAlertId()
        {
            return this._alertId != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The timestamp when the alert was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? CreatedAt
        {
            get { return this._createdAt; }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// An optional description of the alert.
        /// </para>
        /// </summary>
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
        /// The name of the alert.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// The notification rules for the alert.
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
        /// Gets and sets the property NotificationStatus. 
        /// <para>
        /// Whether notifications are enabled.
        /// </para>
        /// </summary>
        public NotificationStatus NotificationStatus
        {
            get { return this._notificationStatus; }
            set { this._notificationStatus = value; }
        }

        // Check to see if NotificationStatus property is set
        internal bool IsSetNotificationStatus()
        {
            return this._notificationStatus != null;
        }

        /// <summary>
        /// Gets and sets the property ProfileId. 
        /// <para>
        /// The ID of the access profile associated with the alert.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
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
        /// The ID of the space the alert belongs to.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property State. 
        /// <para>
        /// Live evaluation state (read-only, system-managed). Populated by GetAlert. ListAlerts
        /// reports state on <c>AlertSummary</c> instead, where it stays required.
        /// </para>
        ///  
        /// <para>
        /// Absent on CreateAlert: a newly created alert has never been evaluated, so any state
        /// reported there would be a default rather than an observation. Call GetAlert for live
        /// state. Not @required for that reason — GetAlert always populates it.
        /// </para>
        ///  
        /// <para>
        /// <c>contributorSummary</c> is nested inside this member, so it too is absent on CreateAlert.
        /// </para>
        /// </summary>
        public AlertStateInfo State
        {
            get { return this._state; }
            set { this._state = value; }
        }

        // Check to see if State property is set
        internal bool IsSetState()
        {
            return this._state != null;
        }

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The timestamp when the alert was last updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? UpdatedAt
        {
            get { return this._updatedAt; }
            set { this._updatedAt = value; }
        }

        // Check to see if UpdatedAt property is set
        internal bool IsSetUpdatedAt()
        {
            return this._updatedAt.HasValue; 
        }

    }
}