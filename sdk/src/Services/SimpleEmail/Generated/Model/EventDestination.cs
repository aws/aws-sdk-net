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
 * Do not modify this file. This file is generated from the email-2010-12-01.normal.json service model.
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
    /// Contains information about an event destination.
    /// 
    ///  <note> 
    /// <para>
    /// When you create or update an event destination, you must provide one, and only one,
    /// destination. The destination can be Amazon CloudWatch, Amazon Kinesis Firehose or
    /// Amazon Simple Notification Service (Amazon SNS).
    /// </para>
    ///  </note> 
    /// <para>
    /// Event destinations are associated with configuration sets, which enable you to publish
    /// email sending events to Amazon CloudWatch, Amazon Kinesis Firehose, or Amazon Simple
    /// Notification Service (Amazon SNS). For information about using configuration sets,
    /// see the <a href="https://docs.aws.amazon.com/ses/latest/dg/monitor-sending-activity.html">Amazon
    /// SES Developer Guide</a>.
    /// </para>
    /// </summary>
    public partial class EventDestination
    {
        private CloudWatchDestination _cloudWatchDestination;
        private bool? _enabled;
        private KinesisFirehoseDestination _kinesisFirehoseDestination;
        private List<string> _matchingEventTypes = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _name;
        private SNSDestination _snsDestination;

        /// <summary>
        /// Gets and sets the property CloudWatchDestination. 
        /// <para>
        /// An object that contains the names, default values, and sources of the dimensions associated
        /// with an Amazon CloudWatch event destination.
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
        /// Sets whether Amazon SES publishes events to this destination when you send an email
        /// with the associated configuration set. Set to <c>true</c> to enable publishing to
        /// this destination; set to <c>false</c> to prevent publishing to this destination. The
        /// default value is <c>false</c>.
        /// </para>
        /// </summary>
        public bool? Enabled
        {
            get { return this._enabled; }
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
        /// An object that contains the delivery stream ARN and the IAM role ARN associated with
        /// an Amazon Kinesis Firehose event destination.
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
        /// The type of email sending events to publish to the event destination.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>send</c> - The call was successful and Amazon SES is attempting to deliver the
        /// email.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>reject</c> - Amazon SES determined that the email contained a virus and rejected
        /// it.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>bounce</c> - The recipient's mail server permanently rejected the email. This
        /// corresponds to a hard bounce.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>complaint</c> - The recipient marked the email as spam.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>delivery</c> - Amazon SES successfully delivered the email to the recipient's
        /// mail server.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>open</c> - The recipient received the email and opened it in their email client.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>click</c> - The recipient clicked one or more links in the email.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>renderingFailure</c> - Amazon SES did not send the email because of a template
        /// rendering issue.
        /// </para>
        ///  </li> </ul>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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
            return this._matchingEventTypes != null && (this._matchingEventTypes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the event destination. The name must meet the following requirements:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Contain only ASCII letters (a-z, A-Z), numbers (0-9), underscores (_), or dashes (-).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Contain 64 characters or fewer.
        /// </para>
        ///  </li> </ul>
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
        /// Gets and sets the property SNSDestination. 
        /// <para>
        /// An object that contains the topic ARN associated with an Amazon Simple Notification
        /// Service (Amazon SNS) event destination.
        /// </para>
        /// </summary>
        public SNSDestination SNSDestination
        {
            get { return this._snsDestination; }
            set { this._snsDestination = value; }
        }

        // Check to see if SNSDestination property is set
        internal bool IsSetSNSDestination()
        {
            return this._snsDestination != null;
        }

    }
}