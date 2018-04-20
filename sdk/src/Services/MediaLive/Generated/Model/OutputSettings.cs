/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.MediaLive.Model
{
    /// <summary>
    /// Placeholder documentation for OutputSettings
    /// </summary>
    public partial class OutputSettings
    {
        private ArchiveOutputSettings _archiveOutputSettings;
        private HlsOutputSettings _hlsOutputSettings;
        private MsSmoothOutputSettings _msSmoothOutputSettings;
        private RtmpOutputSettings _rtmpOutputSettings;
        private UdpOutputSettings _udpOutputSettings;

        /// <summary>
        /// Gets and sets the property ArchiveOutputSettings.
        /// </summary>
        public ArchiveOutputSettings ArchiveOutputSettings
        {
            get { return this._archiveOutputSettings; }
            set { this._archiveOutputSettings = value; }
        }

        // Check to see if ArchiveOutputSettings property is set
        internal bool IsSetArchiveOutputSettings()
        {
            return this._archiveOutputSettings != null;
        }

        /// <summary>
        /// Gets and sets the property HlsOutputSettings.
        /// </summary>
        public HlsOutputSettings HlsOutputSettings
        {
            get { return this._hlsOutputSettings; }
            set { this._hlsOutputSettings = value; }
        }

        // Check to see if HlsOutputSettings property is set
        internal bool IsSetHlsOutputSettings()
        {
            return this._hlsOutputSettings != null;
        }

        /// <summary>
        /// Gets and sets the property MsSmoothOutputSettings.
        /// </summary>
        public MsSmoothOutputSettings MsSmoothOutputSettings
        {
            get { return this._msSmoothOutputSettings; }
            set { this._msSmoothOutputSettings = value; }
        }

        // Check to see if MsSmoothOutputSettings property is set
        internal bool IsSetMsSmoothOutputSettings()
        {
            return this._msSmoothOutputSettings != null;
        }

        /// <summary>
        /// Gets and sets the property RtmpOutputSettings.
        /// </summary>
        public RtmpOutputSettings RtmpOutputSettings
        {
            get { return this._rtmpOutputSettings; }
            set { this._rtmpOutputSettings = value; }
        }

        // Check to see if RtmpOutputSettings property is set
        internal bool IsSetRtmpOutputSettings()
        {
            return this._rtmpOutputSettings != null;
        }

        /// <summary>
        /// Gets and sets the property UdpOutputSettings.
        /// </summary>
        public UdpOutputSettings UdpOutputSettings
        {
            get { return this._udpOutputSettings; }
            set { this._udpOutputSettings = value; }
        }

        // Check to see if UdpOutputSettings property is set
        internal bool IsSetUdpOutputSettings()
        {
            return this._udpOutputSettings != null;
        }

    }
}