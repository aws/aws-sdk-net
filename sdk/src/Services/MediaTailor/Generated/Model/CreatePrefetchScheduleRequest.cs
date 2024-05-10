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
    /// Container for the parameters to the CreatePrefetchSchedule operation.
    /// Creates a prefetch schedule for a playback configuration. A prefetch schedule allows
    /// you to tell MediaTailor to fetch and prepare certain ads before an ad break happens.
    /// For more information about ad prefetching, see <a href="https://docs.aws.amazon.com/mediatailor/latest/ug/prefetching-ads.html">Using
    /// ad prefetching</a> in the <i>MediaTailor User Guide</i>.
    /// </summary>
    public partial class CreatePrefetchScheduleRequest : AmazonMediaTailorRequest
    {
        private PrefetchConsumption _consumption;
        private string _name;
        private string _playbackConfigurationName;
        private PrefetchRetrieval _retrieval;
        private string _streamId;

        /// <summary>
        /// Gets and sets the property Consumption. 
        /// <para>
        /// The configuration settings for MediaTailor's <i>consumption</i> of the prefetched
        /// ads from the ad decision server. Each consumption configuration contains an end time
        /// and an optional start time that define the <i>consumption window</i>. Prefetch schedules
        /// automatically expire no earlier than seven days after the end time.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// The name to assign to the schedule request.
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
        /// Gets and sets the property PlaybackConfigurationName. 
        /// <para>
        /// The name to assign to the playback configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property Retrieval. 
        /// <para>
        /// The configuration settings for retrieval of prefetched ads from the ad decision server.
        /// Only one set of prefetched ads will be retrieved and subsequently consumed for each
        /// ad break.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property StreamId. 
        /// <para>
        /// An optional stream identifier that MediaTailor uses to prefetch ads for multiple streams
        /// that use the same playback configuration. If <c>StreamId</c> is specified, MediaTailor
        /// returns all of the prefetch schedules with an exact match on <c>StreamId</c>. If not
        /// specified, MediaTailor returns all of the prefetch schedules for the playback configuration,
        /// regardless of <c>StreamId</c>.
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