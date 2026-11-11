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

namespace Amazon.Connect.Model
{
    /// <summary>
    /// Information about the send notification action.
    /// </summary>
    public partial class SendNotificationActionDefinition
    {
        /// <summary>
        /// Gets and sets the property Content. 
        /// <para>
        /// Notification content. Supports variable injection. For more information, see <a href="https://docs.aws.amazon.com/connect/latest/adminguide/contact-lens-variable-injection.html">JSONPath
        /// reference</a> in the <i>Connect Customer Administrators Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 1024)]
        public string Content { get; set; }

        /// <summary>
        /// Checks to see if the Content property is set.
        /// </summary>
        internal bool IsSetContent() => this.Content != null;

        /// <summary>
        /// Gets and sets the property ContentType. 
        /// <para>
        /// Content type format.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public NotificationContentType ContentType { get; set; }

        /// <summary>
        /// Checks to see if the ContentType property is set.
        /// </summary>
        internal bool IsSetContentType() => this.ContentType != null;

        /// <summary>
        /// Gets and sets the property DeliveryMethod. 
        /// <para>
        /// Notification delivery method.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public NotificationDeliveryType DeliveryMethod { get; set; }

        /// <summary>
        /// Checks to see if the DeliveryMethod property is set.
        /// </summary>
        internal bool IsSetDeliveryMethod() => this.DeliveryMethod != null;

        /// <summary>
        /// Gets and sets the property Exclusion. 
        /// <para>
        /// Recipients to exclude from notification.
        /// </para>
        /// </summary>
        public NotificationRecipientType Exclusion { get; set; }

        /// <summary>
        /// Checks to see if the Exclusion property is set.
        /// </summary>
        internal bool IsSetExclusion() => this.Exclusion != null;

        /// <summary>
        /// Gets and sets the property Recipient. 
        /// <para>
        /// Notification recipient.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public NotificationRecipientType Recipient { get; set; }

        /// <summary>
        /// Checks to see if the Recipient property is set.
        /// </summary>
        internal bool IsSetRecipient() => this.Recipient != null;

        /// <summary>
        /// Gets and sets the property Subject. 
        /// <para>
        /// The subject of the email if the delivery method is <c>EMAIL</c>. Supports variable
        /// injection. For more information, see <a href="https://docs.aws.amazon.com/connect/latest/adminguide/contact-lens-variable-injection.html">JSONPath
        /// reference</a> in the <i>Connect Customer Administrators Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 200)]
        public string Subject { get; set; }

        /// <summary>
        /// Checks to see if the Subject property is set.
        /// </summary>
        internal bool IsSetSubject() => this.Subject != null;
    }
}
