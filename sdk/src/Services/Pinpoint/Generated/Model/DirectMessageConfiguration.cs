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
 * Do not modify this file. This file is generated from the pinpoint-2016-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Pinpoint.Model
{
    /// <summary>
    /// The message configuration.
    /// </summary>
    public partial class DirectMessageConfiguration
    {
        private APNSMessage _apnsMessage;
        private DefaultMessage _defaultMessage;
        private DefaultPushNotificationMessage _defaultPushNotificationMessage;
        private GCMMessage _gcmMessage;
        private SMSMessage _smsMessage;

        /// <summary>
        /// Gets and sets the property APNSMessage. The message to APNS channels. Overrides the
        /// default push notification message.
        /// </summary>
        public APNSMessage APNSMessage
        {
            get { return this._apnsMessage; }
            set { this._apnsMessage = value; }
        }

        // Check to see if APNSMessage property is set
        internal bool IsSetAPNSMessage()
        {
            return this._apnsMessage != null;
        }

        /// <summary>
        /// Gets and sets the property DefaultMessage. The default message for all channels.
        /// </summary>
        public DefaultMessage DefaultMessage
        {
            get { return this._defaultMessage; }
            set { this._defaultMessage = value; }
        }

        // Check to see if DefaultMessage property is set
        internal bool IsSetDefaultMessage()
        {
            return this._defaultMessage != null;
        }

        /// <summary>
        /// Gets and sets the property DefaultPushNotificationMessage. The default push notification
        /// message for all push channels.
        /// </summary>
        public DefaultPushNotificationMessage DefaultPushNotificationMessage
        {
            get { return this._defaultPushNotificationMessage; }
            set { this._defaultPushNotificationMessage = value; }
        }

        // Check to see if DefaultPushNotificationMessage property is set
        internal bool IsSetDefaultPushNotificationMessage()
        {
            return this._defaultPushNotificationMessage != null;
        }

        /// <summary>
        /// Gets and sets the property GCMMessage. The message to GCM channels. Overrides the
        /// default push notification message.
        /// </summary>
        public GCMMessage GCMMessage
        {
            get { return this._gcmMessage; }
            set { this._gcmMessage = value; }
        }

        // Check to see if GCMMessage property is set
        internal bool IsSetGCMMessage()
        {
            return this._gcmMessage != null;
        }

        /// <summary>
        /// Gets and sets the property SMSMessage. The message to SMS channels. Overrides the
        /// default message.
        /// </summary>
        public SMSMessage SMSMessage
        {
            get { return this._smsMessage; }
            set { this._smsMessage = value; }
        }

        // Check to see if SMSMessage property is set
        internal bool IsSetSMSMessage()
        {
            return this._smsMessage != null;
        }

    }
}