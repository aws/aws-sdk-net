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
    /// A playlist of media (VOD and/or live) to be played instead of the default media on
    /// a particular program.
    /// </summary>
    public partial class AlternateMedia
    {
        private List<AdBreak> _adBreaks = AWSConfigs.InitializeCollections ? new List<AdBreak>() : null;
        private ClipRange _clipRange;
        private long? _durationMillis;
        private string _liveSourceName;
        private long? _scheduledStartTimeMillis;
        private string _sourceLocationName;
        private string _vodSourceName;

        /// <summary>
        /// Gets and sets the property AdBreaks. 
        /// <para>
        /// Ad break configuration parameters defined in AlternateMedia.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AdBreak> AdBreaks
        {
            get { return this._adBreaks; }
            set { this._adBreaks = value; }
        }

        // Check to see if AdBreaks property is set
        internal bool IsSetAdBreaks()
        {
            return this._adBreaks != null && (this._adBreaks.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ClipRange.
        /// </summary>
        public ClipRange ClipRange
        {
            get { return this._clipRange; }
            set { this._clipRange = value; }
        }

        // Check to see if ClipRange property is set
        internal bool IsSetClipRange()
        {
            return this._clipRange != null;
        }

        /// <summary>
        /// Gets and sets the property DurationMillis. 
        /// <para>
        /// The duration of the alternateMedia in milliseconds.
        /// </para>
        /// </summary>
        public long? DurationMillis
        {
            get { return this._durationMillis; }
            set { this._durationMillis = value; }
        }

        // Check to see if DurationMillis property is set
        internal bool IsSetDurationMillis()
        {
            return this._durationMillis.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LiveSourceName. 
        /// <para>
        /// The name of the live source for alternateMedia.
        /// </para>
        /// </summary>
        public string LiveSourceName
        {
            get { return this._liveSourceName; }
            set { this._liveSourceName = value; }
        }

        // Check to see if LiveSourceName property is set
        internal bool IsSetLiveSourceName()
        {
            return this._liveSourceName != null;
        }

        /// <summary>
        /// Gets and sets the property ScheduledStartTimeMillis. 
        /// <para>
        /// The date and time that the alternateMedia is scheduled to start, in epoch milliseconds.
        /// </para>
        /// </summary>
        public long? ScheduledStartTimeMillis
        {
            get { return this._scheduledStartTimeMillis; }
            set { this._scheduledStartTimeMillis = value; }
        }

        // Check to see if ScheduledStartTimeMillis property is set
        internal bool IsSetScheduledStartTimeMillis()
        {
            return this._scheduledStartTimeMillis.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SourceLocationName. 
        /// <para>
        /// The name of the source location for alternateMedia.
        /// </para>
        /// </summary>
        public string SourceLocationName
        {
            get { return this._sourceLocationName; }
            set { this._sourceLocationName = value; }
        }

        // Check to see if SourceLocationName property is set
        internal bool IsSetSourceLocationName()
        {
            return this._sourceLocationName != null;
        }

        /// <summary>
        /// Gets and sets the property VodSourceName. 
        /// <para>
        /// The name of the VOD source for alternateMedia.
        /// </para>
        /// </summary>
        public string VodSourceName
        {
            get { return this._vodSourceName; }
            set { this._vodSourceName = value; }
        }

        // Check to see if VodSourceName property is set
        internal bool IsSetVodSourceName()
        {
            return this._vodSourceName != null;
        }

    }
}