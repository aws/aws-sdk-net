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
    /// Summary representation of an alert used in list responses.
    /// </summary>
    public partial class AlertSummary
    {
        private string _alertArn;
        private string _alertId;
        private DateTime? _createdAt;
        private string _name;
        private NotificationStatus _notificationStatus;
        private string _profileId;
        private string _spaceId;
        private AlertStateInfo _state;
        private DateTime? _updatedAt;

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
        /// The stable alert identifier (see {@link Alert#alertId}). Use it to address the alert;
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
        /// Live evaluation state (read-only, system-managed).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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