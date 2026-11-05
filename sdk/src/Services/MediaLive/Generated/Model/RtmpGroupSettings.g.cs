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

namespace Amazon.MediaLive.Model
{
    /// <summary>
    /// Rtmp Group Settings
    /// </summary>
    public partial class RtmpGroupSettings
    {
        /// <summary>
        /// Gets and sets the property AdMarkers. Choose the ad marker type for this output group.
        /// MediaLive will create a message based on the content of each SCTE-35 message, format
        /// it for that marker type, and insert it in the datastream.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> AdMarkers { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the AdMarkers property is set.
        /// </summary>
        internal bool IsSetAdMarkers() => this.AdMarkers != null && (this.AdMarkers.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property AuthenticationScheme. Authentication scheme to use when
        /// connecting with CDN
        /// </summary>
        public AuthenticationScheme AuthenticationScheme { get; set; }

        /// <summary>
        /// Checks to see if the AuthenticationScheme property is set.
        /// </summary>
        internal bool IsSetAuthenticationScheme() => this.AuthenticationScheme != null;

        /// <summary>
        /// Gets and sets the property CacheFullBehavior. Controls behavior when content cache
        /// fills up. If remote origin server stalls the RTMP connection and does not accept content
        /// fast enough the 'Media Cache' will fill up. When the cache reaches the duration specified
        /// by cacheLength the cache will stop accepting new content. If set to disconnectImmediately,
        /// the RTMP output will force a disconnect. Clear the media cache, and reconnect after
        /// restartDelay seconds. If set to waitForServer, the RTMP output will wait up to 5 minutes
        /// to allow the origin server to begin accepting data again.
        /// </summary>
        public RtmpCacheFullBehavior CacheFullBehavior { get; set; }

        /// <summary>
        /// Checks to see if the CacheFullBehavior property is set.
        /// </summary>
        internal bool IsSetCacheFullBehavior() => this.CacheFullBehavior != null;

        /// <summary>
        /// Gets and sets the property CacheLength. Cache length, in seconds, is used to calculate
        /// buffer size.
        /// </summary>
        public int? CacheLength { get; set; }

        /// <summary>
        /// Checks to see if the CacheLength property is set.
        /// </summary>
        internal bool IsSetCacheLength() => this.CacheLength.HasValue;

        /// <summary>
        /// Gets and sets the property CaptionData. Controls the types of data that passes to
        /// onCaptionInfo outputs. If set to 'all' then 608 and 708 carried DTVCC data will be
        /// passed. If set to 'field1AndField2608' then DTVCC data will be stripped out, but 608
        /// data from both fields will be passed. If set to 'field1608' then only the data carried
        /// in 608 from field 1 video will be passed.
        /// </summary>
        public RtmpCaptionData CaptionData { get; set; }

        /// <summary>
        /// Checks to see if the CaptionData property is set.
        /// </summary>
        internal bool IsSetCaptionData() => this.CaptionData != null;

        /// <summary>
        /// Gets and sets the property IncludeFillerNalUnits. Applies only when the rate control
        /// mode (in the codec settings) is CBR (constant bit rate). Controls whether the RTMP
        /// output stream is padded (with FILL NAL units) in order to achieve a constant bit rate
        /// that is truly constant. When there is no padding, the bandwidth varies (up to the
        /// bitrate value in the codec settings). We recommend that you choose Auto.
        /// </summary>
        public IncludeFillerNalUnits IncludeFillerNalUnits { get; set; }

        /// <summary>
        /// Checks to see if the IncludeFillerNalUnits property is set.
        /// </summary>
        internal bool IsSetIncludeFillerNalUnits() => this.IncludeFillerNalUnits != null;

        /// <summary>
        /// Gets and sets the property InputLossAction. Controls the behavior of this RTMP group
        /// if input becomes unavailable. - emitOutput: Emit a slate until input returns. - pauseOutput:
        /// Stop transmitting data until input returns. This does not close the underlying RTMP
        /// connection.
        /// </summary>
        public InputLossActionForRtmpOut InputLossAction { get; set; }

        /// <summary>
        /// Checks to see if the InputLossAction property is set.
        /// </summary>
        internal bool IsSetInputLossAction() => this.InputLossAction != null;

        /// <summary>
        /// Gets and sets the property RestartDelay. If a streaming output fails, number of seconds
        /// to wait until a restart is initiated. A value of 0 means never restart.
        /// </summary>
        public int? RestartDelay { get; set; }

        /// <summary>
        /// Checks to see if the RestartDelay property is set.
        /// </summary>
        internal bool IsSetRestartDelay() => this.RestartDelay.HasValue;
    }
}
