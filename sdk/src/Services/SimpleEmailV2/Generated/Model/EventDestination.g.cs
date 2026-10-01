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
        /// <summary>
        /// Gets and sets the property CloudWatchDestination. 
        /// <para>
        /// An object that defines an Amazon CloudWatch destination for email events. You can
        /// use Amazon CloudWatch to monitor and gain insights on your email sending metrics.
        /// </para>
        /// </summary>
        public CloudWatchDestination CloudWatchDestination { get; set; }

        /// <summary>
        /// Checks to see if the CloudWatchDestination property is set.
        /// </summary>
        internal bool IsSetCloudWatchDestination() => this.CloudWatchDestination != null;

        /// <summary>
        /// Gets and sets the property Enabled. 
        /// <para>
        /// If <c>true</c>, the event destination is enabled. When the event destination is enabled,
        /// the specified event types are sent to the destinations in this <c>EventDestinationDefinition</c>.
        /// </para>
        ///  
        /// <para>
        /// If <c>false</c>, the event destination is disabled. When the event destination is
        /// disabled, events aren't sent to the specified destinations.
        /// </para>
        /// </summary>
        public bool? Enabled { get; set; }

        /// <summary>
        /// Checks to see if the Enabled property is set.
        /// </summary>
        internal bool IsSetEnabled() => this.Enabled.HasValue;

        /// <summary>
        /// Gets and sets the property EventBridgeDestination. 
        /// <para>
        /// An object that defines an Amazon EventBridge destination for email events. You can
        /// use Amazon EventBridge to send notifications when certain email events occur.
        /// </para>
        /// </summary>
        public EventBridgeDestination EventBridgeDestination { get; set; }

        /// <summary>
        /// Checks to see if the EventBridgeDestination property is set.
        /// </summary>
        internal bool IsSetEventBridgeDestination() => this.EventBridgeDestination != null;

        /// <summary>
        /// Gets and sets the property KinesisFirehoseDestination. 
        /// <para>
        /// An object that defines an Amazon Kinesis Data Firehose destination for email events.
        /// You can use Amazon Kinesis Data Firehose to stream data to other services, such as
        /// Amazon S3 and Amazon Redshift.
        /// </para>
        /// </summary>
        public KinesisFirehoseDestination KinesisFirehoseDestination { get; set; }

        /// <summary>
        /// Checks to see if the KinesisFirehoseDestination property is set.
        /// </summary>
        internal bool IsSetKinesisFirehoseDestination() => this.KinesisFirehoseDestination != null;

        /// <summary>
        /// Gets and sets the property MatchingEventTypes. 
        /// <para>
        /// The types of events that Amazon SES sends to the specified event destinations.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>SEND</c> - The send request was successful and SES will attempt to deliver the
        /// message to the recipient’s mail server. (If account-level or global suppression is
        /// being used, SES will still count it as a send, but delivery is suppressed.)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>REJECT</c> - SES accepted the email, but determined that it contained a virus
        /// and didn’t attempt to deliver it to the recipient’s mail server.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>BOUNCE</c> - (<i>Hard bounce</i>) The recipient's mail server permanently rejected
        /// the email. (<i>Soft bounces</i> are only included when SES fails to deliver the email
        /// after retrying for a period of time.)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>COMPLAINT</c> - The email was successfully delivered to the recipient’s mail server,
        /// but the recipient marked it as spam.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DELIVERY</c> - SES successfully delivered the email to the recipient's mail server.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>OPEN</c> - The recipient received the message and opened it in their email client.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>CLICK</c> - The recipient clicked one or more links in the email.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>RENDERING_FAILURE</c> - The email wasn't sent because of a template rendering
        /// issue. This event type can occur when template data is missing, or when there is a
        /// mismatch between template parameters and data. (This event type only occurs when you
        /// send email using the <a href="https://docs.aws.amazon.com/ses/latest/APIReference-V2/API_SendEmail.html">
        /// <c>SendEmail</c> </a> or <a href="https://docs.aws.amazon.com/ses/latest/APIReference-V2/API_SendBulkEmail.html">
        /// <c>SendBulkEmail</c> </a> API operations.) 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DELIVERY_DELAY</c> - The email couldn't be delivered to the recipient’s mail server
        /// because a temporary issue occurred. Delivery delays can occur, for example, when the
        /// recipient's inbox is full, or when the receiving email server experiences a transient
        /// issue.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>SUBSCRIPTION</c> - The email was successfully delivered, but the recipient updated
        /// their subscription preferences by clicking on an <i>unsubscribe</i> link as part of
        /// your <a href="https://docs.aws.amazon.com/ses/latest/dg/sending-email-subscription-management.html">subscription
        /// management</a>.
        /// </para>
        ///  </li> </ul>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<string> MatchingEventTypes { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the MatchingEventTypes property is set.
        /// </summary>
        internal bool IsSetMatchingEventTypes() => this.MatchingEventTypes != null && (this.MatchingEventTypes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// A name that identifies the event destination.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

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
        public PinpointDestination PinpointDestination { get; set; }

        /// <summary>
        /// Checks to see if the PinpointDestination property is set.
        /// </summary>
        internal bool IsSetPinpointDestination() => this.PinpointDestination != null;

        /// <summary>
        /// Gets and sets the property SnsDestination. 
        /// <para>
        /// An object that defines an Amazon SNS destination for email events. You can use Amazon
        /// SNS to send notifications when certain email events occur.
        /// </para>
        /// </summary>
        public SnsDestination SnsDestination { get; set; }

        /// <summary>
        /// Checks to see if the SnsDestination property is set.
        /// </summary>
        internal bool IsSetSnsDestination() => this.SnsDestination != null;
    }
}
