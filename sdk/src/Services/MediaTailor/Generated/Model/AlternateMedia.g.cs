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
    /// A playlist of media (VOD and/or live) to be played instead of the default media on
    /// a particular program.
    /// </summary>
    public partial class AlternateMedia
    {
        /// <summary>
        /// Gets and sets the property AdBreaks. 
        /// <para>
        /// Ad break configuration parameters defined in AlternateMedia.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AdBreak> AdBreaks { get; set; } = AWSConfigs.InitializeCollections ? new List<AdBreak>() : null;

        /// <summary>
        /// Checks to see if the AdBreaks property is set.
        /// </summary>
        internal bool IsSetAdBreaks() => this.AdBreaks != null && (this.AdBreaks.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ClipRange.
        /// </summary>
        public ClipRange ClipRange { get; set; }

        /// <summary>
        /// Checks to see if the ClipRange property is set.
        /// </summary>
        internal bool IsSetClipRange() => this.ClipRange != null;

        /// <summary>
        /// Gets and sets the property DurationMillis. 
        /// <para>
        /// The duration of the alternateMedia in milliseconds.
        /// </para>
        /// </summary>
        public long? DurationMillis { get; set; }

        /// <summary>
        /// Checks to see if the DurationMillis property is set.
        /// </summary>
        internal bool IsSetDurationMillis() => this.DurationMillis.HasValue;

        /// <summary>
        /// Gets and sets the property LiveSourceName. 
        /// <para>
        /// The name of the live source for alternateMedia.
        /// </para>
        /// </summary>
        public string LiveSourceName { get; set; }

        /// <summary>
        /// Checks to see if the LiveSourceName property is set.
        /// </summary>
        internal bool IsSetLiveSourceName() => this.LiveSourceName != null;

        /// <summary>
        /// Gets and sets the property ScheduledStartTimeMillis. 
        /// <para>
        /// The date and time that the alternateMedia is scheduled to start, in epoch milliseconds.
        /// </para>
        /// </summary>
        public long? ScheduledStartTimeMillis { get; set; }

        /// <summary>
        /// Checks to see if the ScheduledStartTimeMillis property is set.
        /// </summary>
        internal bool IsSetScheduledStartTimeMillis() => this.ScheduledStartTimeMillis.HasValue;

        /// <summary>
        /// Gets and sets the property SourceLocationName. 
        /// <para>
        /// The name of the source location for alternateMedia.
        /// </para>
        /// </summary>
        public string SourceLocationName { get; set; }

        /// <summary>
        /// Checks to see if the SourceLocationName property is set.
        /// </summary>
        internal bool IsSetSourceLocationName() => this.SourceLocationName != null;

        /// <summary>
        /// Gets and sets the property VodSourceName. 
        /// <para>
        /// The name of the VOD source for alternateMedia.
        /// </para>
        /// </summary>
        public string VodSourceName { get; set; }

        /// <summary>
        /// Checks to see if the VodSourceName property is set.
        /// </summary>
        internal bool IsSetVodSourceName() => this.VodSourceName != null;
    }
}
