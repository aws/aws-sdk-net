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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.PinpointSMSVoiceV2.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateEventDestination operation.
    /// Updates an existing event destination in a configuration set. You can update the IAM
    /// role ARN for CloudWatch Logs and Firehose. You can also enable or disable the event
    /// destination.
    /// 
    ///  
    /// <para>
    /// You may want to update an event destination to change its matching event types or
    /// updating the destination resource ARN. You can't change an event destination's type
    /// between CloudWatch Logs, Firehose, and Amazon SNS.
    /// </para>
    /// </summary>
    public partial class UpdateEventDestinationRequest : AmazonPinpointSMSVoiceV2Request
    {
        private CloudWatchLogsDestination _cloudWatchLogsDestination;
        private string _configurationSetName;
        private bool? _enabled;
        private string _eventDestinationName;
        private KinesisFirehoseDestination _kinesisFirehoseDestination;
        private List<string> _matchingEventTypes = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private SnsDestination _snsDestination;

        /// <summary>
        /// Gets and sets the property CloudWatchLogsDestination. 
        /// <para>
        /// An object that contains information about an event destination that sends data to
        /// CloudWatch Logs.
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
        /// Gets and sets the property ConfigurationSetName. 
        /// <para>
        /// The configuration set to update with the new event destination. Valid values for this
        /// can be the ConfigurationSetName or ConfigurationSetArn.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string ConfigurationSetName
        {
            get { return this._configurationSetName; }
            set { this._configurationSetName = value; }
        }

        // Check to see if ConfigurationSetName property is set
        internal bool IsSetConfigurationSetName()
        {
            return this._configurationSetName != null;
        }

        /// <summary>
        /// Gets and sets the property Enabled. 
        /// <para>
        /// When set to true logging is enabled.
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
        /// Gets and sets the property EventDestinationName. 
        /// <para>
        /// The name to use for the event destination.
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
        /// An object that contains information about an event destination for logging to Firehose.
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
        ///  <note> 
        /// <para>
        /// The <c>TEXT_SENT</c> event type is not supported.
        /// </para>
        ///  </note>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=43)]
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
        /// Gets and sets the property SnsDestination. 
        /// <para>
        /// An object that contains information about an event destination that sends data to
        /// Amazon SNS.
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