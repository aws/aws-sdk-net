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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.MediaLive.Model
{
    /// <summary>
    /// Information about the SDP files that describe the SMPTE 2110 streams that go into
    /// one SMPTE 2110 receiver group.
    /// </summary>
    public partial class Smpte2110ReceiverGroupSdpSettings
    {
        private List<InputSdpLocation> _ancillarySdps = AWSConfigs.InitializeCollections ? new List<InputSdpLocation>() : null;
        private List<InputSdpLocation> _audioSdps = AWSConfigs.InitializeCollections ? new List<InputSdpLocation>() : null;
        private InputSdpLocation _videoSdp;

        /// <summary>
        /// Gets and sets the property AncillarySdps. A list of InputSdpLocations. Each item in
        /// the list specifies the SDP file and index for one ancillary SMPTE 2110 stream.Each
        /// stream encapsulates one captions stream (out of any number you can include) or the
        /// single SCTE 35 stream that you can include.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<InputSdpLocation> AncillarySdps
        {
            get { return this._ancillarySdps; }
            set { this._ancillarySdps = value; }
        }

        // Check to see if AncillarySdps property is set
        internal bool IsSetAncillarySdps()
        {
            return this._ancillarySdps != null && (this._ancillarySdps.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property AudioSdps. A list of InputSdpLocations. Each item in the
        /// list specifies the SDP file and index for one audio SMPTE 2110 stream.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<InputSdpLocation> AudioSdps
        {
            get { return this._audioSdps; }
            set { this._audioSdps = value; }
        }

        // Check to see if AudioSdps property is set
        internal bool IsSetAudioSdps()
        {
            return this._audioSdps != null && (this._audioSdps.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property VideoSdp. The InputSdpLocation that specifies the SDP file
        /// and index for the single video SMPTE 2110 stream for this 2110 input.
        /// </summary>
        public InputSdpLocation VideoSdp
        {
            get { return this._videoSdp; }
            set { this._videoSdp = value; }
        }

        // Check to see if VideoSdp property is set
        internal bool IsSetVideoSdp()
        {
            return this._videoSdp != null;
        }

    }
}