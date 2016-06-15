/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the email-2010-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SimpleEmail.Model
{
    /// <summary>
    /// Container for the parameters to the SetIdentityHeadersInNotificationsEnabled operation.
    /// Given an identity (an email address or a domain), sets whether Amazon SES includes
    /// the original email headers in the Amazon Simple Notification Service (Amazon SNS)
    /// notifications of a specified type.
    /// 
    ///  
    /// <para>
    /// This action is throttled at one request per second.
    /// </para>
    ///  
    /// <para>
    /// For more information about using notifications with Amazon SES, see the <a href="http://docs.aws.amazon.com/ses/latest/DeveloperGuide/notifications.html">Amazon
    /// SES Developer Guide</a>.
    /// </para>
    /// </summary>
    public partial class SetIdentityHeadersInNotificationsEnabledRequest : AmazonSimpleEmailServiceRequest
    {
        private bool? _enabled;
        private string _identity;
        private NotificationType _notificationType;

        /// <summary>
        /// Gets and sets the property Enabled. 
        /// <para>
        /// Sets whether Amazon SES includes the original email headers in Amazon SNS notifications
        /// of the specified notification type. A value of <code>true</code> specifies that Amazon
        /// SES will include headers in notifications, and a value of <code>false</code> specifies
        /// that Amazon SES will not include headers in notifications.
        /// </para>
        ///  
        /// <para>
        /// This value can only be set when <code>NotificationType</code> is already set to use
        /// a particular Amazon SNS topic.
        /// </para>
        /// </summary>
        public bool Enabled
        {
            get { return this._enabled.GetValueOrDefault(); }
            set { this._enabled = value; }
        }

        // Check to see if Enabled property is set
        internal bool IsSetEnabled()
        {
            return this._enabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Identity. 
        /// <para>
        /// The identity for which to enable or disable headers in notifications. Examples: <code>user@example.com</code>,
        /// <code>example.com</code>.
        /// </para>
        /// </summary>
        public string Identity
        {
            get { return this._identity; }
            set { this._identity = value; }
        }

        // Check to see if Identity property is set
        internal bool IsSetIdentity()
        {
            return this._identity != null;
        }

        /// <summary>
        /// Gets and sets the property NotificationType. 
        /// <para>
        /// The notification type for which to enable or disable headers in notifications. 
        /// </para>
        /// </summary>
        public NotificationType NotificationType
        {
            get { return this._notificationType; }
            set { this._notificationType = value; }
        }

        // Check to see if NotificationType property is set
        internal bool IsSetNotificationType()
        {
            return this._notificationType != null;
        }

    }
}