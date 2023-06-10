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
 * Do not modify this file. This file is generated from the sesv2-2019-09-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SimpleEmailV2.Model
{
    /// <summary>
    /// In the Amazon SES API v2, <i>events</i> include message sends, deliveries, opens,
    /// clicks, bounces, complaints and delivery delays. <i>Event destinations</i> are places
    /// that you can send information about these events to. For example, you can send event
    /// data to Amazon SNS to receive notifications when you receive bounces or complaints,
    /// or you can use Amazon Kinesis Data Firehose to stream data to Amazon S3 for long-term
    /// storage.
    /// </summary>
    public partial class EventDestination
    {
        private CloudWatchDestination _cloudWatchDestination;
        private bool? _enabled;
        private KinesisFirehoseDestination _kinesisFirehoseDestination;
        private List<string> _matchingEventTypes = new List<string>();
        private string _name;
        private PinpointDestination _pinpointDestination;
        private SnsDestination _snsDestination;

        /// <summary>
        /// Gets and sets the property CloudWatchDestination. 
        /// <para>
        /// An object that defines an Amazon CloudWatch destination for email events. You can
        /// use Amazon CloudWatch to monitor and gain insights on your email sending metrics.
        /// </para>
        /// </summary>
        public CloudWatchDestination CloudWatchDestination
        {
            get { return this._cloudWatchDestination; }
            set { this._cloudWatchDestination = value; }
        }

        // Check to see if CloudWatchDestination property is set
        internal bool IsSetCloudWatchDestination()
        {
            return this._cloudWatchDestination != null;
        }

        /// <summary>
        /// Gets and sets the property Enabled. 
        /// <para>
        /// If <code>true</code>, the event destination is enabled. When the event destination
        /// is enabled, the specified event types are sent to the destinations in this <code>EventDestinationDefinition</code>.
        /// </para>
        ///  
        /// <para>
        /// If <code>false</code>, the event destination is disabled. When the event destination
        /// is disabled, events aren't sent to the specified destinations.
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
        /// Gets and sets the property KinesisFirehoseDestination. 
        /// <para>
        /// An object that defines an Amazon Kinesis Data Firehose destination for email events.
        /// You can use Amazon Kinesis Data Firehose to stream data to other services, such as
        /// Amazon S3 and Amazon Redshift.
        /// </para>
        /// </summary>
        public KinesisFirehoseDestination KinesisFirehoseDestination
        {
            get { return this._kinesisFirehoseDestination; }
            set { this._kinesisFirehoseDestination = value; }
        }

        // Check to see if KinesisFirehoseDestination property is set
        internal bool IsSetKinesisFirehoseDestination()
        {
            return this._kinesisFirehoseDestination != null;
        }

        /// <summary>
        /// Gets and sets the property MatchingEventTypes. 
        /// <para>
        /// The types of events that Amazon SES sends to the specified event destinations.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>SEND</code> - The send request was successful and SES will attempt to deliver
        /// the message to the recipient’s mail server. (If account-level or global suppression
        /// is being used, SES will still count it as a send, but delivery is suppressed.)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>REJECT</code> - SES accepted the email, but determined that it contained a
        /// virus and didn’t attempt to deliver it to the recipient’s mail server.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>BOUNCE</code> - (<i>Hard bounce</i>) The recipient's mail server permanently
        /// rejected the email. (<i>Soft bounces</i> are only included when SES fails to deliver
        /// the email after retrying for a period of time.)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>COMPLAINT</code> - The email was successfully delivered to the recipient’s
        /// mail server, but the recipient marked it as spam.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>DELIVERY</code> - SES successfully delivered the email to the recipient's mail
        /// server.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>OPEN</code> - The recipient received the message and opened it in their email
        /// client.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>CLICK</code> - The recipient clicked one or more links in the email.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>RENDERING_FAILURE</code> - The email wasn't sent because of a template rendering
        /// issue. This event type can occur when template data is missing, or when there is a
        /// mismatch between template parameters and data. (This event type only occurs when you
        /// send email using the <a href="https://docs.aws.amazon.com/ses/latest/APIReference/API_SendTemplatedEmail.html">
        /// <code>SendTemplatedEmail</code> </a> or <a href="https://docs.aws.amazon.com/ses/latest/APIReference/API_SendBulkTemplatedEmail.html">
        /// <code>SendBulkTemplatedEmail</code> </a> API operations.) 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>DELIVERY_DELAY</code> - The email couldn't be delivered to the recipient’s
        /// mail server because a temporary issue occurred. Delivery delays can occur, for example,
        /// when the recipient's inbox is full, or when the receiving email server experiences
        /// a transient issue.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>SUBSCRIPTION</code> - The email was successfully delivered, but the recipient
        /// updated their subscription preferences by clicking on an <i>unsubscribe</i> link as
        /// part of your <a href="https://docs.aws.amazon.com/ses/latest/dg/sending-email-subscription-management.html">subscription
        /// management</a>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> MatchingEventTypes
        {
            get { return this._matchingEventTypes; }
            set { this._matchingEventTypes = value; }
        }

        // Check to see if MatchingEventTypes property is set
        internal bool IsSetMatchingEventTypes()
        {
            return this._matchingEventTypes != null && this._matchingEventTypes.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// A name that identifies the event destination.
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
        /// Gets and sets the property PinpointDestination. 
        /// <para>
        /// An object that defines an Amazon Pinpoint project destination for email events. You
        /// can send email event data to a Amazon Pinpoint project to view metrics using the Transactional
        /// Messaging dashboards that are built in to Amazon Pinpoint. For more information, see
        /// <a href="https://docs.aws.amazon.com/pinpoint/latest/userguide/analytics-transactional-messages.html">Transactional
        /// Messaging Charts</a> in the <i>Amazon Pinpoint User Guide</i>.
        /// </para>
        /// </summary>
        public PinpointDestination PinpointDestination
        {
            get { return this._pinpointDestination; }
            set { this._pinpointDestination = value; }
        }

        // Check to see if PinpointDestination property is set
        internal bool IsSetPinpointDestination()
        {
            return this._pinpointDestination != null;
        }

        /// <summary>
        /// Gets and sets the property SnsDestination. 
        /// <para>
        /// An object that defines an Amazon SNS destination for email events. You can use Amazon
        /// SNS to send notification when certain email events occur.
        /// </para>
        /// </summary>
        public SnsDestination SnsDestination
        {
            get { return this._snsDestination; }
            set { this._snsDestination = value; }
        }

        // Check to see if SnsDestination property is set
        internal bool IsSetSnsDestination()
        {
            return this._snsDestination != null;
        }

    }
}