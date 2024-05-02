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
    /// Container for the parameters to the SendTestEventNotification operation.
    /// The <c>SendTestEventNotification</c> operation causes Amazon Mechanical Turk to send
    /// a notification message as if a HIT event occurred, according to the provided notification
    /// specification. This allows you to test notifications without setting up notifications
    /// for a real HIT type and trying to trigger them using the website. When you call this
    /// operation, the service attempts to send the test notification immediately.
    /// </summary>
    public partial class SendTestEventNotificationRequest : AmazonMTurkRequest
    {
        private NotificationSpecification _notification;
        private EventType _testEventType;

        /// <summary>
        /// Gets and sets the property Notification. 
        /// <para>
        ///  The notification specification to test. This value is identical to the value you
        /// would provide to the UpdateNotificationSettings operation when you establish the notification
        /// specification for a HIT type. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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

        /// <summary>
        /// Gets and sets the property TestEventType. 
        /// <para>
        ///  The event to simulate to test the notification specification. This event is included
        /// in the test message even if the notification specification does not include the event
        /// type. The notification specification does not filter out the test event. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public EventType TestEventType
        {
            get { return this._testEventType; }
            set { this._testEventType = value; }
        }

        // Check to see if TestEventType property is set
        internal bool IsSetTestEventType()
        {
            return this._testEventType != null;
        }

    }
}