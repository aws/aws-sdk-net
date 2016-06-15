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
    /// Represents the notification attributes of an identity, including whether an identity
    /// has Amazon Simple Notification Service (Amazon SNS) topics set for bounce, complaint,
    /// and/or delivery notifications, and whether feedback forwarding is enabled for bounce
    /// and complaint notifications.
    /// </summary>
    public partial class IdentityNotificationAttributes
    {
        private string _bounceTopic;
        private string _complaintTopic;
        private string _deliveryTopic;
        private bool? _forwardingEnabled;
        private bool? _headersInBounceNotificationsEnabled;
        private bool? _headersInComplaintNotificationsEnabled;
        private bool? _headersInDeliveryNotificationsEnabled;

        /// <summary>
        /// Gets and sets the property BounceTopic. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Amazon SNS topic where Amazon SES will publish
        /// bounce notifications.
        /// </para>
        /// </summary>
        public string BounceTopic
        {
            get { return this._bounceTopic; }
            set { this._bounceTopic = value; }
        }

        // Check to see if BounceTopic property is set
        internal bool IsSetBounceTopic()
        {
            return this._bounceTopic != null;
        }

        /// <summary>
        /// Gets and sets the property ComplaintTopic. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Amazon SNS topic where Amazon SES will publish
        /// complaint notifications.
        /// </para>
        /// </summary>
        public string ComplaintTopic
        {
            get { return this._complaintTopic; }
            set { this._complaintTopic = value; }
        }

        // Check to see if ComplaintTopic property is set
        internal bool IsSetComplaintTopic()
        {
            return this._complaintTopic != null;
        }

        /// <summary>
        /// Gets and sets the property DeliveryTopic. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Amazon SNS topic where Amazon SES will publish
        /// delivery notifications.
        /// </para>
        /// </summary>
        public string DeliveryTopic
        {
            get { return this._deliveryTopic; }
            set { this._deliveryTopic = value; }
        }

        // Check to see if DeliveryTopic property is set
        internal bool IsSetDeliveryTopic()
        {
            return this._deliveryTopic != null;
        }

        /// <summary>
        /// Gets and sets the property ForwardingEnabled. 
        /// <para>
        /// Describes whether Amazon SES will forward bounce and complaint notifications as email.
        /// <code>true</code> indicates that Amazon SES will forward bounce and complaint notifications
        /// as email, while <code>false</code> indicates that bounce and complaint notifications
        /// will be published only to the specified bounce and complaint Amazon SNS topics.
        /// </para>
        /// </summary>
        public bool ForwardingEnabled
        {
            get { return this._forwardingEnabled.GetValueOrDefault(); }
            set { this._forwardingEnabled = value; }
        }

        // Check to see if ForwardingEnabled property is set
        internal bool IsSetForwardingEnabled()
        {
            return this._forwardingEnabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property HeadersInBounceNotificationsEnabled. 
        /// <para>
        /// Describes whether Amazon SES includes the original email headers in Amazon SNS notifications
        /// of type <code>Bounce</code>. A value of <code>true</code> specifies that Amazon SES
        /// will include headers in bounce notifications, and a value of <code>false</code> specifies
        /// that Amazon SES will not include headers in bounce notifications.
        /// </para>
        /// </summary>
        public bool HeadersInBounceNotificationsEnabled
        {
            get { return this._headersInBounceNotificationsEnabled.GetValueOrDefault(); }
            set { this._headersInBounceNotificationsEnabled = value; }
        }

        // Check to see if HeadersInBounceNotificationsEnabled property is set
        internal bool IsSetHeadersInBounceNotificationsEnabled()
        {
            return this._headersInBounceNotificationsEnabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property HeadersInComplaintNotificationsEnabled. 
        /// <para>
        /// Describes whether Amazon SES includes the original email headers in Amazon SNS notifications
        /// of type <code>Complaint</code>. A value of <code>true</code> specifies that Amazon
        /// SES will include headers in complaint notifications, and a value of <code>false</code>
        /// specifies that Amazon SES will not include headers in complaint notifications.
        /// </para>
        /// </summary>
        public bool HeadersInComplaintNotificationsEnabled
        {
            get { return this._headersInComplaintNotificationsEnabled.GetValueOrDefault(); }
            set { this._headersInComplaintNotificationsEnabled = value; }
        }

        // Check to see if HeadersInComplaintNotificationsEnabled property is set
        internal bool IsSetHeadersInComplaintNotificationsEnabled()
        {
            return this._headersInComplaintNotificationsEnabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property HeadersInDeliveryNotificationsEnabled. 
        /// <para>
        /// Describes whether Amazon SES includes the original email headers in Amazon SNS notifications
        /// of type <code>Delivery</code>. A value of <code>true</code> specifies that Amazon
        /// SES will include headers in delivery notifications, and a value of <code>false</code>
        /// specifies that Amazon SES will not include headers in delivery notifications.
        /// </para>
        /// </summary>
        public bool HeadersInDeliveryNotificationsEnabled
        {
            get { return this._headersInDeliveryNotificationsEnabled.GetValueOrDefault(); }
            set { this._headersInDeliveryNotificationsEnabled = value; }
        }

        // Check to see if HeadersInDeliveryNotificationsEnabled property is set
        internal bool IsSetHeadersInDeliveryNotificationsEnabled()
        {
            return this._headersInDeliveryNotificationsEnabled.HasValue; 
        }

    }
}