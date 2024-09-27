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
    /// Output Group Settings
    /// </summary>
    public partial class OutputGroupSettings
    {
        private ArchiveGroupSettings _archiveGroupSettings;
        private CmafIngestGroupSettings _cmafIngestGroupSettings;
        private FrameCaptureGroupSettings _frameCaptureGroupSettings;
        private HlsGroupSettings _hlsGroupSettings;
        private MediaPackageGroupSettings _mediaPackageGroupSettings;
        private MsSmoothGroupSettings _msSmoothGroupSettings;
        private MultiplexGroupSettings _multiplexGroupSettings;
        private RtmpGroupSettings _rtmpGroupSettings;
        private SrtGroupSettings _srtGroupSettings;
        private UdpGroupSettings _udpGroupSettings;

        /// <summary>
        /// Gets and sets the property ArchiveGroupSettings.
        /// </summary>
        public ArchiveGroupSettings ArchiveGroupSettings
        {
            get { return this._archiveGroupSettings; }
            set { this._archiveGroupSettings = value; }
        }

        // Check to see if ArchiveGroupSettings property is set
        internal bool IsSetArchiveGroupSettings()
        {
            return this._archiveGroupSettings != null;
        }

        /// <summary>
        /// Gets and sets the property CmafIngestGroupSettings.
        /// </summary>
        public CmafIngestGroupSettings CmafIngestGroupSettings
        {
            get { return this._cmafIngestGroupSettings; }
            set { this._cmafIngestGroupSettings = value; }
        }

        // Check to see if CmafIngestGroupSettings property is set
        internal bool IsSetCmafIngestGroupSettings()
        {
            return this._cmafIngestGroupSettings != null;
        }

        /// <summary>
        /// Gets and sets the property FrameCaptureGroupSettings.
        /// </summary>
        public FrameCaptureGroupSettings FrameCaptureGroupSettings
        {
            get { return this._frameCaptureGroupSettings; }
            set { this._frameCaptureGroupSettings = value; }
        }

        // Check to see if FrameCaptureGroupSettings property is set
        internal bool IsSetFrameCaptureGroupSettings()
        {
            return this._frameCaptureGroupSettings != null;
        }

        /// <summary>
        /// Gets and sets the property HlsGroupSettings.
        /// </summary>
        public HlsGroupSettings HlsGroupSettings
        {
            get { return this._hlsGroupSettings; }
            set { this._hlsGroupSettings = value; }
        }

        // Check to see if HlsGroupSettings property is set
        internal bool IsSetHlsGroupSettings()
        {
            return this._hlsGroupSettings != null;
        }

        /// <summary>
        /// Gets and sets the property MediaPackageGroupSettings.
        /// </summary>
        public MediaPackageGroupSettings MediaPackageGroupSettings
        {
            get { return this._mediaPackageGroupSettings; }
            set { this._mediaPackageGroupSettings = value; }
        }

        // Check to see if MediaPackageGroupSettings property is set
        internal bool IsSetMediaPackageGroupSettings()
        {
            return this._mediaPackageGroupSettings != null;
        }

        /// <summary>
        /// Gets and sets the property MsSmoothGroupSettings.
        /// </summary>
        public MsSmoothGroupSettings MsSmoothGroupSettings
        {
            get { return this._msSmoothGroupSettings; }
            set { this._msSmoothGroupSettings = value; }
        }

        // Check to see if MsSmoothGroupSettings property is set
        internal bool IsSetMsSmoothGroupSettings()
        {
            return this._msSmoothGroupSettings != null;
        }

        /// <summary>
        /// Gets and sets the property MultiplexGroupSettings.
        /// </summary>
        public MultiplexGroupSettings MultiplexGroupSettings
        {
            get { return this._multiplexGroupSettings; }
            set { this._multiplexGroupSettings = value; }
        }

        // Check to see if MultiplexGroupSettings property is set
        internal bool IsSetMultiplexGroupSettings()
        {
            return this._multiplexGroupSettings != null;
        }

        /// <summary>
        /// Gets and sets the property RtmpGroupSettings.
        /// </summary>
        public RtmpGroupSettings RtmpGroupSettings
        {
            get { return this._rtmpGroupSettings; }
            set { this._rtmpGroupSettings = value; }
        }

        // Check to see if RtmpGroupSettings property is set
        internal bool IsSetRtmpGroupSettings()
        {
            return this._rtmpGroupSettings != null;
        }

        /// <summary>
        /// Gets and sets the property SrtGroupSettings.
        /// </summary>
        public SrtGroupSettings SrtGroupSettings
        {
            get { return this._srtGroupSettings; }
            set { this._srtGroupSettings = value; }
        }

        // Check to see if SrtGroupSettings property is set
        internal bool IsSetSrtGroupSettings()
        {
            return this._srtGroupSettings != null;
        }

        /// <summary>
        /// Gets and sets the property UdpGroupSettings.
        /// </summary>
        public UdpGroupSettings UdpGroupSettings
        {
            get { return this._udpGroupSettings; }
            set { this._udpGroupSettings = value; }
        }

        // Check to see if UdpGroupSettings property is set
        internal bool IsSetUdpGroupSettings()
        {
            return this._udpGroupSettings != null;
        }

    }
}