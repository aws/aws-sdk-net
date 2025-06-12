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
 * Do not modify this file. This file is generated from the sms-voice-2018-09-05.normal.json service model.
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
namespace Amazon.PinpointSMSVoice.Model
{
    /// <summary>
    /// An object that defines an event destination.
    /// </summary>
    public partial class EventDestination
    {
        private CloudWatchLogsDestination _cloudWatchLogsDestination;
        private bool? _enabled;
        private KinesisFirehoseDestination _kinesisFirehoseDestination;
        private List<string> _matchingEventTypes = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _name;
        private SnsDestination _snsDestination;

        /// <summary>
        /// Gets and sets the property CloudWatchLogsDestination.
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
        /// Gets and sets the property Enabled. Indicates whether or not the event destination
        /// is enabled. If the event destination is enabled, then Amazon Pinpoint sends response
        /// data to the specified event destination.
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
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
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
        /// Gets and sets the property Name. A name that identifies the event destination configuration.
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

        /// <summary>
        /// Gets and sets the property SnsDestination.
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