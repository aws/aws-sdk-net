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
 * Do not modify this file. This file is generated from the notifications-2018-05-10.normal.json service model.
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
namespace Amazon.Notifications.Model
{
    /// <summary>
    /// Describes an overview of a <c>NotificationHub</c>.
    /// 
    ///  
    /// <para>
    /// A <c>NotificationConfiguration</c> is an account-level setting used to select the
    /// Regions where you want to store, process and replicate your notifications.
    /// </para>
    /// </summary>
    public partial class NotificationHubOverview
    {
        private DateTime? _creationTime;
        private DateTime? _lastActivationTime;
        private string _notificationHubRegion;
        private NotificationHubStatusSummary _statusSummary;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The date and time the <c>NotificationHubOverview</c> was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime CreationTime
        {
            get { return this._creationTime.GetValueOrDefault(); }
            set { this._creationTime = value; }
        }

        // Check to see if CreationTime property is set
        internal bool IsSetCreationTime()
        {
            return this._creationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LastActivationTime. 
        /// <para>
        /// The most recent time this <c>NotificationHub</c> had an <c>ACTIVE</c> status.
        /// </para>
        /// </summary>
        public DateTime LastActivationTime
        {
            get { return this._lastActivationTime.GetValueOrDefault(); }
            set { this._lastActivationTime = value; }
        }

        // Check to see if LastActivationTime property is set
        internal bool IsSetLastActivationTime()
        {
            return this._lastActivationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NotificationHubRegion. 
        /// <para>
        /// The Region of the resource.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=2, Max=25)]
        public string NotificationHubRegion
        {
            get { return this._notificationHubRegion; }
            set { this._notificationHubRegion = value; }
        }

        // Check to see if NotificationHubRegion property is set
        internal bool IsSetNotificationHubRegion()
        {
            return this._notificationHubRegion != null;
        }

        /// <summary>
        /// Gets and sets the property StatusSummary. 
        /// <para>
        /// The status summary of the resource.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public NotificationHubStatusSummary StatusSummary
        {
            get { return this._statusSummary; }
            set { this._statusSummary = value; }
        }

        // Check to see if StatusSummary property is set
        internal bool IsSetStatusSummary()
        {
            return this._statusSummary != null;
        }

    }
}