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

namespace Amazon.SimpleEmail.Model
{
    /// <summary>
    /// Represents the notification attributes of an identity, including whether an identity
    /// has Amazon Simple Notification Service (Amazon SNS) topics set for bounce, complaint,
    /// and/or delivery notifications, and whether feedback forwarding is enabled for bounce
    /// and complaint notifications.
    /// </summary>
    public partial class IdentityNotificationAttributes
    {
        /// <summary>
        /// Gets and sets the property BounceTopic. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Amazon SNS topic where Amazon SES publishes
        /// bounce notifications.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string BounceTopic { get; set; }

        /// <summary>
        /// Checks to see if the BounceTopic property is set.
        /// </summary>
        internal bool IsSetBounceTopic() => this.BounceTopic != null;

        /// <summary>
        /// Gets and sets the property ComplaintTopic. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Amazon SNS topic where Amazon SES publishes
        /// complaint notifications.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ComplaintTopic { get; set; }

        /// <summary>
        /// Checks to see if the ComplaintTopic property is set.
        /// </summary>
        internal bool IsSetComplaintTopic() => this.ComplaintTopic != null;

        /// <summary>
        /// Gets and sets the property DeliveryTopic. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Amazon SNS topic where Amazon SES publishes
        /// delivery notifications.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string DeliveryTopic { get; set; }

        /// <summary>
        /// Checks to see if the DeliveryTopic property is set.
        /// </summary>
        internal bool IsSetDeliveryTopic() => this.DeliveryTopic != null;

        /// <summary>
        /// Gets and sets the property ForwardingEnabled. 
        /// <para>
        /// Describes whether Amazon SES forwards bounce and complaint notifications as email.
        /// <c>true</c> indicates that Amazon SES forwards bounce and complaint notifications
        /// as email, while <c>false</c> indicates that bounce and complaint notifications are
        /// published only to the specified bounce and complaint Amazon SNS topics.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public bool? ForwardingEnabled { get; set; }

        /// <summary>
        /// Checks to see if the ForwardingEnabled property is set.
        /// </summary>
        internal bool IsSetForwardingEnabled() => this.ForwardingEnabled.HasValue;

        /// <summary>
        /// Gets and sets the property HeadersInBounceNotificationsEnabled. 
        /// <para>
        /// Describes whether Amazon SES includes the original email headers in Amazon SNS notifications
        /// of type <c>Bounce</c>. A value of <c>true</c> specifies that Amazon SES includes headers
        /// in bounce notifications, and a value of <c>false</c> specifies that Amazon SES does
        /// not include headers in bounce notifications.
        /// </para>
        /// </summary>
        public bool? HeadersInBounceNotificationsEnabled { get; set; }

        /// <summary>
        /// Checks to see if the HeadersInBounceNotificationsEnabled property is set.
        /// </summary>
        internal bool IsSetHeadersInBounceNotificationsEnabled() => this.HeadersInBounceNotificationsEnabled.HasValue;

        /// <summary>
        /// Gets and sets the property HeadersInComplaintNotificationsEnabled. 
        /// <para>
        /// Describes whether Amazon SES includes the original email headers in Amazon SNS notifications
        /// of type <c>Complaint</c>. A value of <c>true</c> specifies that Amazon SES includes
        /// headers in complaint notifications, and a value of <c>false</c> specifies that Amazon
        /// SES does not include headers in complaint notifications.
        /// </para>
        /// </summary>
        public bool? HeadersInComplaintNotificationsEnabled { get; set; }

        /// <summary>
        /// Checks to see if the HeadersInComplaintNotificationsEnabled property is set.
        /// </summary>
        internal bool IsSetHeadersInComplaintNotificationsEnabled() => this.HeadersInComplaintNotificationsEnabled.HasValue;

        /// <summary>
        /// Gets and sets the property HeadersInDeliveryNotificationsEnabled. 
        /// <para>
        /// Describes whether Amazon SES includes the original email headers in Amazon SNS notifications
        /// of type <c>Delivery</c>. A value of <c>true</c> specifies that Amazon SES includes
        /// headers in delivery notifications, and a value of <c>false</c> specifies that Amazon
        /// SES does not include headers in delivery notifications.
        /// </para>
        /// </summary>
        public bool? HeadersInDeliveryNotificationsEnabled { get; set; }

        /// <summary>
        /// Checks to see if the HeadersInDeliveryNotificationsEnabled property is set.
        /// </summary>
        internal bool IsSetHeadersInDeliveryNotificationsEnabled() => this.HeadersInDeliveryNotificationsEnabled.HasValue;
    }
}
