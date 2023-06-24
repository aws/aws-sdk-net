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
 * Do not modify this file. This file is generated from the pinpoint-sms-voice-v2-2022-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.PinpointSMSVoiceV2.Model
{
    /// <summary>
    /// Contains information about an event destination.
    /// 
    ///  
    /// <para>
    /// Event destinations are associated with configuration sets, which enable you to publish
    /// message sending events to Amazon CloudWatch, Amazon Kinesis Data Firehose, or Amazon
    /// SNS.
    /// </para>
    /// </summary>
    public partial class EventDestination
    {
        private CloudWatchLogsDestination _cloudWatchLogsDestination;
        private bool? _enabled;
        private string _eventDestinationName;
        private KinesisFirehoseDestination _kinesisFirehoseDestination;
        private List<string> _matchingEventTypes = new List<string>();
        private SnsDestination _snsDestination;

        /// <summary>
        /// Gets and sets the property CloudWatchLogsDestination. 
        /// <para>
        /// An object that contains information about an event destination that sends logging
        /// events to Amazon CloudWatch logs.
        /// </para>
        /// </summary>
        public CloudWatchLogsDestination CloudWatchLogsDestination
        {
            get { return this._cloudWatchLogsDestination; }
            set { this._cloudWatchLogsDestination = value; }
        }

        // Check to see if CloudWatchLogsDestination property is set
        internal bool IsSetCloudWatchLogsDestination()
        {
            return this._cloudWatchLogsDestination != null;
        }

        /// <summary>
        /// Gets and sets the property Enabled. 
        /// <para>
        /// When set to true events will be logged.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property EventDestinationName. 
        /// <para>
        /// The name of the EventDestination.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string EventDestinationName
        {
            get { return this._eventDestinationName; }
            set { this._eventDestinationName = value; }
        }

        // Check to see if EventDestinationName property is set
        internal bool IsSetEventDestinationName()
        {
            return this._eventDestinationName != null;
        }

        /// <summary>
        /// Gets and sets the property KinesisFirehoseDestination. 
        /// <para>
        /// An object that contains information about an event destination for logging to Amazon
        /// Kinesis Data Firehose.
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
        /// An array of event types that determine which events to log.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=25)]
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
        /// Gets and sets the property SnsDestination. 
        /// <para>
        /// An object that contains information about an event destination that sends logging
        /// events to Amazon SNS.
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