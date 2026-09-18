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

namespace Amazon.MediaTailor.Model
{
    /// <summary>
    /// This is the response object from the GetPrefetchSchedule operation.
    /// </summary>
    public partial class GetPrefetchScheduleResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the prefetch schedule.
        /// </para>
        /// </summary>
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property Consumption. 
        /// <para>
        /// The configuration settings for how and when MediaTailor consumes prefetched ads from
        /// the ad decision server for single prefetch schedules. Each consumption configuration
        /// contains an end time and an optional start time that define the <i>consumption window</i>.
        /// Prefetch schedules automatically expire no earlier than seven days after the end time.
        /// </para>
        /// </summary>
        public PrefetchConsumption Consumption { get; set; }

        /// <summary>
        /// Checks to see if the Consumption property is set.
        /// </summary>
        internal bool IsSetConsumption() => this.Consumption != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the prefetch schedule. The name must be unique among all prefetch schedules
        /// that are associated with the specified playback configuration.
        /// </para>
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property PlaybackConfigurationName. 
        /// <para>
        /// The name of the playback configuration to create the prefetch schedule for.
        /// </para>
        /// </summary>
        public string PlaybackConfigurationName { get; set; }

        /// <summary>
        /// Checks to see if the PlaybackConfigurationName property is set.
        /// </summary>
        internal bool IsSetPlaybackConfigurationName() => this.PlaybackConfigurationName != null;

        /// <summary>
        /// Gets and sets the property RecurringPrefetchConfiguration. 
        /// <para>
        /// The configuration that defines how and when MediaTailor performs ad prefetching in
        /// a live event.
        /// </para>
        /// </summary>
        public RecurringPrefetchConfiguration RecurringPrefetchConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the RecurringPrefetchConfiguration property is set.
        /// </summary>
        internal bool IsSetRecurringPrefetchConfiguration() => this.RecurringPrefetchConfiguration != null;

        /// <summary>
        /// Gets and sets the property Retrieval. 
        /// <para>
        /// A complex type that contains settings for prefetch retrieval from the ad decision
        /// server (ADS).
        /// </para>
        /// </summary>
        public PrefetchRetrieval Retrieval { get; set; }

        /// <summary>
        /// Checks to see if the Retrieval property is set.
        /// </summary>
        internal bool IsSetRetrieval() => this.Retrieval != null;

        /// <summary>
        /// Gets and sets the property ScheduleType. 
        /// <para>
        /// The frequency that MediaTailor creates prefetch schedules. <c>SINGLE</c> indicates
        /// that this schedule applies to one ad break. <c>RECURRING</c> indicates that MediaTailor
        /// automatically creates a schedule for each ad avail in a live event.
        /// </para>
        /// </summary>
        public PrefetchScheduleType ScheduleType { get; set; }

        /// <summary>
        /// Checks to see if the ScheduleType property is set.
        /// </summary>
        internal bool IsSetScheduleType() => this.ScheduleType != null;

        /// <summary>
        /// Gets and sets the property StreamId. 
        /// <para>
        /// An optional stream identifier that you can specify in order to prefetch for multiple
        /// streams that use the same playback configuration.
        /// </para>
        /// </summary>
        public string StreamId { get; set; }

        /// <summary>
        /// Checks to see if the StreamId property is set.
        /// </summary>
        internal bool IsSetStreamId() => this.StreamId != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags assigned to the prefetch schedule. Tags are key-value pairs that you can
        /// associate with Amazon resources to help with organization, access control, and cost
        /// tracking. For more information, see <a href="https://docs.aws.amazon.com/mediatailor/latest/ug/tagging.html">Tagging
        /// AWS Elemental MediaTailor Resources</a>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Tags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
