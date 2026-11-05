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
    /// Output Group Settings
    /// </summary>
    public partial class OutputGroupSettings
    {
        /// <summary>
        /// Gets and sets the property ArchiveGroupSettings.
        /// </summary>
        public ArchiveGroupSettings ArchiveGroupSettings { get; set; }

        /// <summary>
        /// Checks to see if the ArchiveGroupSettings property is set.
        /// </summary>
        internal bool IsSetArchiveGroupSettings() => this.ArchiveGroupSettings != null;

        /// <summary>
        /// Gets and sets the property CmafIngestGroupSettings.
        /// </summary>
        public CmafIngestGroupSettings CmafIngestGroupSettings { get; set; }

        /// <summary>
        /// Checks to see if the CmafIngestGroupSettings property is set.
        /// </summary>
        internal bool IsSetCmafIngestGroupSettings() => this.CmafIngestGroupSettings != null;

        /// <summary>
        /// Gets and sets the property FrameCaptureGroupSettings.
        /// </summary>
        public FrameCaptureGroupSettings FrameCaptureGroupSettings { get; set; }

        /// <summary>
        /// Checks to see if the FrameCaptureGroupSettings property is set.
        /// </summary>
        internal bool IsSetFrameCaptureGroupSettings() => this.FrameCaptureGroupSettings != null;

        /// <summary>
        /// Gets and sets the property HlsGroupSettings.
        /// </summary>
        public HlsGroupSettings HlsGroupSettings { get; set; }

        /// <summary>
        /// Checks to see if the HlsGroupSettings property is set.
        /// </summary>
        internal bool IsSetHlsGroupSettings() => this.HlsGroupSettings != null;

        /// <summary>
        /// Gets and sets the property MediaConnectRouterGroupSettings.
        /// </summary>
        public MediaConnectRouterGroupSettings MediaConnectRouterGroupSettings { get; set; }

        /// <summary>
        /// Checks to see if the MediaConnectRouterGroupSettings property is set.
        /// </summary>
        internal bool IsSetMediaConnectRouterGroupSettings() => this.MediaConnectRouterGroupSettings != null;

        /// <summary>
        /// Gets and sets the property MediaPackageGroupSettings.
        /// </summary>
        public MediaPackageGroupSettings MediaPackageGroupSettings { get; set; }

        /// <summary>
        /// Checks to see if the MediaPackageGroupSettings property is set.
        /// </summary>
        internal bool IsSetMediaPackageGroupSettings() => this.MediaPackageGroupSettings != null;

        /// <summary>
        /// Gets and sets the property MsSmoothGroupSettings.
        /// </summary>
        public MsSmoothGroupSettings MsSmoothGroupSettings { get; set; }

        /// <summary>
        /// Checks to see if the MsSmoothGroupSettings property is set.
        /// </summary>
        internal bool IsSetMsSmoothGroupSettings() => this.MsSmoothGroupSettings != null;

        /// <summary>
        /// Gets and sets the property MultiplexGroupSettings.
        /// </summary>
        public MultiplexGroupSettings MultiplexGroupSettings { get; set; }

        /// <summary>
        /// Checks to see if the MultiplexGroupSettings property is set.
        /// </summary>
        internal bool IsSetMultiplexGroupSettings() => this.MultiplexGroupSettings != null;

        /// <summary>
        /// Gets and sets the property RtmpGroupSettings.
        /// </summary>
        public RtmpGroupSettings RtmpGroupSettings { get; set; }

        /// <summary>
        /// Checks to see if the RtmpGroupSettings property is set.
        /// </summary>
        internal bool IsSetRtmpGroupSettings() => this.RtmpGroupSettings != null;

        /// <summary>
        /// Gets and sets the property SrtGroupSettings.
        /// </summary>
        public SrtGroupSettings SrtGroupSettings { get; set; }

        /// <summary>
        /// Checks to see if the SrtGroupSettings property is set.
        /// </summary>
        internal bool IsSetSrtGroupSettings() => this.SrtGroupSettings != null;

        /// <summary>
        /// Gets and sets the property UdpGroupSettings.
        /// </summary>
        public UdpGroupSettings UdpGroupSettings { get; set; }

        /// <summary>
        /// Checks to see if the UdpGroupSettings property is set.
        /// </summary>
        internal bool IsSetUdpGroupSettings() => this.UdpGroupSettings != null;
    }
}
