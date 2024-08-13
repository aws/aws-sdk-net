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
 * Do not modify this file. This file is generated from the mturk-requester-2017-01-17.normal.json service model.
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
namespace Amazon.MTurk.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateNotificationSettings operation.
    /// The <c>UpdateNotificationSettings</c> operation creates, updates, disables or re-enables
    /// notifications for a HIT type. If you call the UpdateNotificationSettings operation
    /// for a HIT type that already has a notification specification, the operation replaces
    /// the old specification with a new one. You can call the UpdateNotificationSettings
    /// operation to enable or disable notifications for the HIT type, without having to modify
    /// the notification specification itself by providing updates to the Active status without
    /// specifying a new notification specification. To change the Active status of a HIT
    /// type's notifications, the HIT type must already have a notification specification,
    /// or one must be provided in the same call to <c>UpdateNotificationSettings</c>.
    /// </summary>
    public partial class UpdateNotificationSettingsRequest : AmazonMTurkRequest
    {
        private bool? _active;
        private string _hitTypeId;
        private NotificationSpecification _notification;

        /// <summary>
        /// Gets and sets the property Active. 
        /// <para>
        ///  Specifies whether notifications are sent for HITs of this HIT type, according to
        /// the notification specification. You must specify either the Notification parameter
        /// or the Active parameter for the call to UpdateNotificationSettings to succeed. 
        /// </para>
        /// </summary>
        public bool? Active
        {
            get { return this._active; }
            set { this._active = value; }
        }

        // Check to see if Active property is set
        internal bool IsSetActive()
        {
            return this._active.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property HITTypeId. 
        /// <para>
        ///  The ID of the HIT type whose notification specification is being updated. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string HITTypeId
        {
            get { return this._hitTypeId; }
            set { this._hitTypeId = value; }
        }

        // Check to see if HITTypeId property is set
        internal bool IsSetHITTypeId()
        {
            return this._hitTypeId != null;
        }

        /// <summary>
        /// Gets and sets the property Notification. 
        /// <para>
        ///  The notification specification for the HIT type. 
        /// </para>
        /// </summary>
        public NotificationSpecification Notification
        {
            get { return this._notification; }
            set { this._notification = value; }
        }

        // Check to see if Notification property is set
        internal bool IsSetNotification()
        {
            return this._notification != null;
        }

    }
}