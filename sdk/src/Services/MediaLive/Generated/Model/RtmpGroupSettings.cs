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
 * Do not modify this file. This file is generated from the medialive-2017-10-14.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.MediaLive.Model
{
    /// <summary>
    /// Rtmp Group Settings
    /// </summary>
    public partial class RtmpGroupSettings
    {
        private List<string> _adMarkers = new List<string>();
        private AuthenticationScheme _authenticationScheme;
        private RtmpCacheFullBehavior _cacheFullBehavior;
        private int? _cacheLength;
        private RtmpCaptionData _captionData;
        private InputLossActionForRtmpOut _inputLossAction;
        private int? _restartDelay;

        /// <summary>
        /// Gets and sets the property AdMarkers. Choose the ad marker type for this output group.
        /// MediaLive will create a message based on the content of each SCTE-35 message, format
        /// it for that marker type, and insert it in the datastream.
        /// </summary>
        public List<string> AdMarkers
        {
            get { return this._adMarkers; }
            set { this._adMarkers = value; }
        }

        // Check to see if AdMarkers property is set
        internal bool IsSetAdMarkers()
        {
            return this._adMarkers != null && this._adMarkers.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property AuthenticationScheme. Authentication scheme to use when
        /// connecting with CDN
        /// </summary>
        public AuthenticationScheme AuthenticationScheme
        {
            get { return this._authenticationScheme; }
            set { this._authenticationScheme = value; }
        }

        // Check to see if AuthenticationScheme property is set
        internal bool IsSetAuthenticationScheme()
        {
            return this._authenticationScheme != null;
        }

        /// <summary>
        /// Gets and sets the property CacheFullBehavior. Controls behavior when content cache
        /// fills up. If remote origin server stalls the RTMP connection and does not accept content
        /// fast enough the 'Media Cache' will fill up. When the cache reaches the duration specified
        /// by cacheLength the cache will stop accepting new content. If set to disconnectImmediately,
        /// the RTMP output will force a disconnect. Clear the media cache, and reconnect after
        /// restartDelay seconds. If set to waitForServer, the RTMP output will wait up to 5 minutes
        /// to allow the origin server to begin accepting data again.
        /// </summary>
        public RtmpCacheFullBehavior CacheFullBehavior
        {
            get { return this._cacheFullBehavior; }
            set { this._cacheFullBehavior = value; }
        }

        // Check to see if CacheFullBehavior property is set
        internal bool IsSetCacheFullBehavior()
        {
            return this._cacheFullBehavior != null;
        }

        /// <summary>
        /// Gets and sets the property CacheLength. Cache length, in seconds, is used to calculate
        /// buffer size.
        /// </summary>
        [AWSProperty(Min=30)]
        public int CacheLength
        {
            get { return this._cacheLength.GetValueOrDefault(); }
            set { this._cacheLength = value; }
        }

        // Check to see if CacheLength property is set
        internal bool IsSetCacheLength()
        {
            return this._cacheLength.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CaptionData. Controls the types of data that passes to
        /// onCaptionInfo outputs.  If set to 'all' then 608 and 708 carried DTVCC data will be
        /// passed.  If set to 'field1AndField2608' then DTVCC data will be stripped out, but
        /// 608 data from both fields will be passed. If set to 'field1608' then only the data
        /// carried in 608 from field 1 video will be passed.
        /// </summary>
        public RtmpCaptionData CaptionData
        {
            get { return this._captionData; }
            set { this._captionData = value; }
        }

        // Check to see if CaptionData property is set
        internal bool IsSetCaptionData()
        {
            return this._captionData != null;
        }

        /// <summary>
        /// Gets and sets the property InputLossAction. Controls the behavior of this RTMP group
        /// if input becomes unavailable.- emitOutput: Emit a slate until input returns.- pauseOutput:
        /// Stop transmitting data until input returns. This does not close the underlying RTMP
        /// connection.
        /// </summary>
        public InputLossActionForRtmpOut InputLossAction
        {
            get { return this._inputLossAction; }
            set { this._inputLossAction = value; }
        }

        // Check to see if InputLossAction property is set
        internal bool IsSetInputLossAction()
        {
            return this._inputLossAction != null;
        }

        /// <summary>
        /// Gets and sets the property RestartDelay. If a streaming output fails, number of seconds
        /// to wait until a restart is initiated. A value of 0 means never restart.
        /// </summary>
        [AWSProperty(Min=0)]
        public int RestartDelay
        {
            get { return this._restartDelay.GetValueOrDefault(); }
            set { this._restartDelay = value; }
        }

        // Check to see if RestartDelay property is set
        internal bool IsSetRestartDelay()
        {
            return this._restartDelay.HasValue; 
        }

    }
}