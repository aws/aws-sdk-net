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

namespace Amazon.PinpointSMSVoice.Model
{
    /// <summary>
    /// An object that defines a single event destination.
    /// </summary>
    public partial class EventDestinationDefinition
    {
        /// <summary>
        /// Gets and sets the property CloudWatchLogsDestination.
        /// </summary>
        public CloudWatchLogsDestination CloudWatchLogsDestination { get; set; }

        /// <summary>
        /// Checks to see if the CloudWatchLogsDestination property is set.
        /// </summary>
        internal bool IsSetCloudWatchLogsDestination() => this.CloudWatchLogsDestination != null;

        /// <summary>
        /// Gets and sets the property Enabled. Indicates whether or not the event destination
        /// is enabled. If the event destination is enabled, then Amazon Pinpoint sends response
        /// data to the specified event destination.
        /// </summary>
        public bool? Enabled { get; set; }

        /// <summary>
        /// Checks to see if the Enabled property is set.
        /// </summary>
        internal bool IsSetEnabled() => this.Enabled.HasValue;

        /// <summary>
        /// Gets and sets the property KinesisFirehoseDestination.
        /// </summary>
        public KinesisFirehoseDestination KinesisFirehoseDestination { get; set; }

        /// <summary>
        /// Checks to see if the KinesisFirehoseDestination property is set.
        /// </summary>
        internal bool IsSetKinesisFirehoseDestination() => this.KinesisFirehoseDestination != null;

        /// <summary>
        /// Gets and sets the property MatchingEventTypes.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> MatchingEventTypes { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the MatchingEventTypes property is set.
        /// </summary>
        internal bool IsSetMatchingEventTypes() => this.MatchingEventTypes != null && (this.MatchingEventTypes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SnsDestination.
        /// </summary>
        public SnsDestination SnsDestination { get; set; }

        /// <summary>
        /// Checks to see if the SnsDestination property is set.
        /// </summary>
        internal bool IsSetSnsDestination() => this.SnsDestination != null;
    }
}
