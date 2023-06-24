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
 * Do not modify this file. This file is generated from the connect-2017-08-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Connect.Model
{
    /// <summary>
    /// Information about the send notification action.
    /// </summary>
    public partial class SendNotificationActionDefinition
    {
        private string _content;
        private NotificationContentType _contentType;
        private NotificationDeliveryType _deliveryMethod;
        private NotificationRecipientType _recipient;
        private string _subject;

        /// <summary>
        /// Gets and sets the property Content. 
        /// <para>
        /// Notification content. Supports variable injection. For more information, see <a href="https://docs.aws.amazon.com/connect/latest/adminguide/contact-lens-variable-injection.html">JSONPath
        /// reference</a> in the <i>Amazon Connect Administrators Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1024)]
        public string Content
        {
            get { return this._content; }
            set { this._content = value; }
        }

        // Check to see if Content property is set
        internal bool IsSetContent()
        {
            return this._content != null;
        }

        /// <summary>
        /// Gets and sets the property ContentType. 
        /// <para>
        /// Content type format.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public NotificationContentType ContentType
        {
            get { return this._contentType; }
            set { this._contentType = value; }
        }

        // Check to see if ContentType property is set
        internal bool IsSetContentType()
        {
            return this._contentType != null;
        }

        /// <summary>
        /// Gets and sets the property DeliveryMethod. 
        /// <para>
        /// Notification delivery method.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public NotificationDeliveryType DeliveryMethod
        {
            get { return this._deliveryMethod; }
            set { this._deliveryMethod = value; }
        }

        // Check to see if DeliveryMethod property is set
        internal bool IsSetDeliveryMethod()
        {
            return this._deliveryMethod != null;
        }

        /// <summary>
        /// Gets and sets the property Recipient. 
        /// <para>
        /// Notification recipient.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public NotificationRecipientType Recipient
        {
            get { return this._recipient; }
            set { this._recipient = value; }
        }

        // Check to see if Recipient property is set
        internal bool IsSetRecipient()
        {
            return this._recipient != null;
        }

        /// <summary>
        /// Gets and sets the property Subject. 
        /// <para>
        /// The subject of the email if the delivery method is <code>EMAIL</code>. Supports variable
        /// injection. For more information, see <a href="https://docs.aws.amazon.com/connect/latest/adminguide/contact-lens-variable-injection.html">JSONPath
        /// reference</a> in the <i>Amazon Connect Administrators Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=200)]
        public string Subject
        {
            get { return this._subject; }
            set { this._subject = value; }
        }

        // Check to see if Subject property is set
        internal bool IsSetSubject()
        {
            return this._subject != null;
        }

    }
}