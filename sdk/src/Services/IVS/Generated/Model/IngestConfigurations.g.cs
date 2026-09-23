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

namespace Amazon.IVS.Model
{
    /// <summary>
    /// Object specifying the ingest configuration set up by the broadcaster, usually in an
    /// encoder. 
    /// 
    ///  
    /// <para>
    ///  <b>Note:</b> Use IngestConfigurations instead of <a>IngestConfiguration</a> (which
    /// is deprecated). If multitrack is not enabled, IngestConfiguration and IngestConfigurations
    /// contain the same data, namely information about Track0 (the sole track). If multitrack
    /// is enabled, IngestConfiguration contains data for only the first track (Track0) and
    /// IngestConfigurations contains data for all tracks.
    /// </para>
    /// </summary>
    public partial class IngestConfigurations
    {
        /// <summary>
        /// Gets and sets the property AudioConfigurations. 
        /// <para>
        /// Encoder settings for audio.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<AudioConfiguration> AudioConfigurations { get; set; } = AWSConfigs.InitializeCollections ? new List<AudioConfiguration>() : null;

        /// <summary>
        /// Checks to see if the AudioConfigurations property is set.
        /// </summary>
        internal bool IsSetAudioConfigurations() => this.AudioConfigurations != null && (this.AudioConfigurations.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property VideoConfigurations. 
        /// <para>
        /// Encoder settings for video
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<VideoConfiguration> VideoConfigurations { get; set; } = AWSConfigs.InitializeCollections ? new List<VideoConfiguration>() : null;

        /// <summary>
        /// Checks to see if the VideoConfigurations property is set.
        /// </summary>
        internal bool IsSetVideoConfigurations() => this.VideoConfigurations != null && (this.VideoConfigurations.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
