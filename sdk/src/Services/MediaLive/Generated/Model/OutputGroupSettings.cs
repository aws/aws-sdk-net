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
    /// Placeholder documentation for OutputGroupSettings
    /// </summary>
    public partial class OutputGroupSettings
    {
        private ArchiveGroupSettings _archiveGroupSettings;
        private HlsGroupSettings _hlsGroupSettings;
        private MsSmoothGroupSettings _msSmoothGroupSettings;
        private RtmpGroupSettings _rtmpGroupSettings;
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