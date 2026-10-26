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
    /// Output Settings
    /// </summary>
    public partial class OutputSettings
    {
        /// <summary>
        /// Gets and sets the property ArchiveOutputSettings.
        /// </summary>
        public ArchiveOutputSettings ArchiveOutputSettings { get; set; }

        /// <summary>
        /// Checks to see if the ArchiveOutputSettings property is set.
        /// </summary>
        internal bool IsSetArchiveOutputSettings() => this.ArchiveOutputSettings != null;

        /// <summary>
        /// Gets and sets the property CmafIngestOutputSettings.
        /// </summary>
        public CmafIngestOutputSettings CmafIngestOutputSettings { get; set; }

        /// <summary>
        /// Checks to see if the CmafIngestOutputSettings property is set.
        /// </summary>
        internal bool IsSetCmafIngestOutputSettings() => this.CmafIngestOutputSettings != null;

        /// <summary>
        /// Gets and sets the property FrameCaptureOutputSettings.
        /// </summary>
        public FrameCaptureOutputSettings FrameCaptureOutputSettings { get; set; }

        /// <summary>
        /// Checks to see if the FrameCaptureOutputSettings property is set.
        /// </summary>
        internal bool IsSetFrameCaptureOutputSettings() => this.FrameCaptureOutputSettings != null;

        /// <summary>
        /// Gets and sets the property HlsOutputSettings.
        /// </summary>
        public HlsOutputSettings HlsOutputSettings { get; set; }

        /// <summary>
        /// Checks to see if the HlsOutputSettings property is set.
        /// </summary>
        internal bool IsSetHlsOutputSettings() => this.HlsOutputSettings != null;

        /// <summary>
        /// Gets and sets the property MediaConnectRouterOutputSettings.
        /// </summary>
        public MediaConnectRouterOutputSettings MediaConnectRouterOutputSettings { get; set; }

        /// <summary>
        /// Checks to see if the MediaConnectRouterOutputSettings property is set.
        /// </summary>
        internal bool IsSetMediaConnectRouterOutputSettings() => this.MediaConnectRouterOutputSettings != null;

        /// <summary>
        /// Gets and sets the property MediaPackageOutputSettings.
        /// </summary>
        public MediaPackageOutputSettings MediaPackageOutputSettings { get; set; }

        /// <summary>
        /// Checks to see if the MediaPackageOutputSettings property is set.
        /// </summary>
        internal bool IsSetMediaPackageOutputSettings() => this.MediaPackageOutputSettings != null;

        /// <summary>
        /// Gets and sets the property MsSmoothOutputSettings.
        /// </summary>
        public MsSmoothOutputSettings MsSmoothOutputSettings { get; set; }

        /// <summary>
        /// Checks to see if the MsSmoothOutputSettings property is set.
        /// </summary>
        internal bool IsSetMsSmoothOutputSettings() => this.MsSmoothOutputSettings != null;

        /// <summary>
        /// Gets and sets the property MultiplexOutputSettings.
        /// </summary>
        public MultiplexOutputSettings MultiplexOutputSettings { get; set; }

        /// <summary>
        /// Checks to see if the MultiplexOutputSettings property is set.
        /// </summary>
        internal bool IsSetMultiplexOutputSettings() => this.MultiplexOutputSettings != null;

        /// <summary>
        /// Gets and sets the property RtmpOutputSettings.
        /// </summary>
        public RtmpOutputSettings RtmpOutputSettings { get; set; }

        /// <summary>
        /// Checks to see if the RtmpOutputSettings property is set.
        /// </summary>
        internal bool IsSetRtmpOutputSettings() => this.RtmpOutputSettings != null;

        /// <summary>
        /// Gets and sets the property SrtOutputSettings.
        /// </summary>
        public SrtOutputSettings SrtOutputSettings { get; set; }

        /// <summary>
        /// Checks to see if the SrtOutputSettings property is set.
        /// </summary>
        internal bool IsSetSrtOutputSettings() => this.SrtOutputSettings != null;

        /// <summary>
        /// Gets and sets the property UdpOutputSettings.
        /// </summary>
        public UdpOutputSettings UdpOutputSettings { get; set; }

        /// <summary>
        /// Checks to see if the UdpOutputSettings property is set.
        /// </summary>
        internal bool IsSetUdpOutputSettings() => this.UdpOutputSettings != null;
    }
}
