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
 * Do not modify this file. This file is generated from the mediatailor-2018-04-23.normal.json service model.
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
        private string _arn;
        private PrefetchConsumption _consumption;
        private string _name;
        private string _playbackConfigurationName;
        private RecurringPrefetchConfiguration _recurringPrefetchConfiguration;
        private PrefetchRetrieval _retrieval;
        private PrefetchScheduleType _scheduleType;
        private string _streamId;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the prefetch schedule.
        /// </para>
        /// </summary>
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property Consumption. 
        /// <para>
        /// The configuration settings for how and when MediaTailor consumes prefetched ads from
        /// the ad decision server for single prefetch schedules. Each consumption configuration
        /// contains an end time and an optional start time that define the <i>consumption window</i>.
        /// Prefetch schedules automatically expire no earlier than seven days after the end time.
        /// </para>
        /// </summary>
        public PrefetchConsumption Consumption
        {
            get { return this._consumption; }
            set { this._consumption = value; }
        }

        // Check to see if Consumption property is set
        internal bool IsSetConsumption()
        {
            return this._consumption != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the prefetch schedule. The name must be unique among all prefetch schedules
        /// that are associated with the specified playback configuration.
        /// </para>
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
        /// Gets and sets the property PlaybackConfigurationName. 
        /// <para>
        /// The name of the playback configuration to create the prefetch schedule for.
        /// </para>
        /// </summary>
        public string PlaybackConfigurationName
        {
            get { return this._playbackConfigurationName; }
            set { this._playbackConfigurationName = value; }
        }

        // Check to see if PlaybackConfigurationName property is set
        internal bool IsSetPlaybackConfigurationName()
        {
            return this._playbackConfigurationName != null;
        }

        /// <summary>
        /// Gets and sets the property RecurringPrefetchConfiguration. 
        /// <para>
        /// The configuration that defines how and when MediaTailor performs ad prefetching in
        /// a live event.
        /// </para>
        /// </summary>
        public RecurringPrefetchConfiguration RecurringPrefetchConfiguration
        {
            get { return this._recurringPrefetchConfiguration; }
            set { this._recurringPrefetchConfiguration = value; }
        }

        // Check to see if RecurringPrefetchConfiguration property is set
        internal bool IsSetRecurringPrefetchConfiguration()
        {
            return this._recurringPrefetchConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property Retrieval. 
        /// <para>
        /// A complex type that contains settings for prefetch retrieval from the ad decision
        /// server (ADS).
        /// </para>
        /// </summary>
        public PrefetchRetrieval Retrieval
        {
            get { return this._retrieval; }
            set { this._retrieval = value; }
        }

        // Check to see if Retrieval property is set
        internal bool IsSetRetrieval()
        {
            return this._retrieval != null;
        }

        /// <summary>
        /// Gets and sets the property ScheduleType. 
        /// <para>
        /// The frequency that MediaTailor creates prefetch schedules. <c>SINGLE</c> indicates
        /// that this schedule applies to one ad break. <c>RECURRING</c> indicates that MediaTailor
        /// automatically creates a schedule for each ad avail in a live event.
        /// </para>
        /// </summary>
        public PrefetchScheduleType ScheduleType
        {
            get { return this._scheduleType; }
            set { this._scheduleType = value; }
        }

        // Check to see if ScheduleType property is set
        internal bool IsSetScheduleType()
        {
            return this._scheduleType != null;
        }

        /// <summary>
        /// Gets and sets the property StreamId. 
        /// <para>
        /// An optional stream identifier that you can specify in order to prefetch for multiple
        /// streams that use the same playback configuration.
        /// </para>
        /// </summary>
        public string StreamId
        {
            get { return this._streamId; }
            set { this._streamId = value; }
        }

        // Check to see if StreamId property is set
        internal bool IsSetStreamId()
        {
            return this._streamId != null;
        }

    }
}