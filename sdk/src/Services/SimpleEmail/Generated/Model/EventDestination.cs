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
    /// Contains information about the event destination to which the specified email sending
    /// events are published.
    /// 
    ///  <note> 
    /// <para>
    /// When you create or update an event destination, you must provide one, and only one,
    /// destination. The destination can be either Amazon CloudWatch or Amazon Kinesis Firehose.
    /// </para>
    ///  </note> 
    /// <para>
    /// Event destinations are associated with configuration sets, which enable you to publish
    /// email sending events to Amazon CloudWatch or Amazon Kinesis Firehose. For information
    /// about using configuration sets, see the <a href="http://docs.aws.amazon.com/ses/latest/DeveloperGuide/monitor-sending-activity.html">Amazon
    /// SES Developer Guide</a>.
    /// </para>
    /// </summary>
    public partial class EventDestination
    {
        private CloudWatchDestination _cloudWatchDestination;
        private bool? _enabled;
        private KinesisFirehoseDestination _kinesisFirehoseDestination;
        private List<string> _matchingEventTypes = new List<string>();
        private string _name;

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
        /// with the associated configuration set. Set to <code>true</code> to enable publishing
        /// to this destination; set to <code>false</code> to prevent publishing to this destination.
        /// The default value is <code>false</code>.
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
        /// </summary>
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
        /// The name of the event destination. The name must:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Contain only ASCII letters (a-z, A-Z), numbers (0-9), underscores (_), or dashes (-).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Contain less than 64 characters.
        /// </para>
        ///  </li> </ul>
        /// </summary>
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

    }
}