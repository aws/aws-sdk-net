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

namespace Amazon.MediaConvert.Model
{
    /// <summary>
    /// Container specific settings.
    /// </summary>
    public partial class ContainerSettings
    {
        /// <summary>
        /// Gets and sets the property CmfcSettings. These settings relate to the fragmented MP4
        /// container for the segments in your CMAF outputs.
        /// </summary>
        public CmfcSettings CmfcSettings { get; set; }

        /// <summary>
        /// Checks to see if the CmfcSettings property is set.
        /// </summary>
        internal bool IsSetCmfcSettings() => this.CmfcSettings != null;

        /// <summary>
        /// Gets and sets the property Container. Container for this output. Some containers require
        /// a container settings object. If not specified, the default object will be created.
        /// </summary>
        public ContainerType Container { get; set; }

        /// <summary>
        /// Checks to see if the Container property is set.
        /// </summary>
        internal bool IsSetContainer() => this.Container != null;

        /// <summary>
        /// Gets and sets the property F4vSettings. Settings for F4v container
        /// </summary>
        public F4vSettings F4vSettings { get; set; }

        /// <summary>
        /// Checks to see if the F4vSettings property is set.
        /// </summary>
        internal bool IsSetF4vSettings() => this.F4vSettings != null;

        /// <summary>
        /// Gets and sets the property M2tsSettings. MPEG-2 TS container settings. These apply
        /// to outputs in a File output group when the output's container is MPEG-2 Transport
        /// Stream (M2TS). In these assets, data is organized by the program map table (PMT).
        /// Each transport stream program contains subsets of data, including audio, video, and
        /// metadata. Each of these subsets of data has a numerical label called a packet identifier
        /// (PID). Each transport stream program corresponds to one MediaConvert output. The PMT
        /// lists the types of data in a program along with their PID. Downstream systems and
        /// players use the program map table to look up the PID for each type of data it accesses
        /// and then uses the PIDs to locate specific data within the asset.
        /// </summary>
        public M2tsSettings M2tsSettings { get; set; }

        /// <summary>
        /// Checks to see if the M2tsSettings property is set.
        /// </summary>
        internal bool IsSetM2tsSettings() => this.M2tsSettings != null;

        /// <summary>
        /// Gets and sets the property M3u8Settings. These settings relate to the MPEG-2 transport
        /// stream (MPEG2-TS) container for the MPEG2-TS segments in your HLS outputs.
        /// </summary>
        public M3u8Settings M3u8Settings { get; set; }

        /// <summary>
        /// Checks to see if the M3u8Settings property is set.
        /// </summary>
        internal bool IsSetM3u8Settings() => this.M3u8Settings != null;

        /// <summary>
        /// Gets and sets the property MovSettings. These settings relate to your QuickTime MOV
        /// output container.
        /// </summary>
        public MovSettings MovSettings { get; set; }

        /// <summary>
        /// Checks to see if the MovSettings property is set.
        /// </summary>
        internal bool IsSetMovSettings() => this.MovSettings != null;

        /// <summary>
        /// Gets and sets the property Mp4Settings. These settings relate to your MP4 output container.
        /// You can create audio only outputs with this container. For more information, see https://docs.aws.amazon.com/mediaconvert/latest/ug/supported-codecs-containers-audio-only.html#output-codecs-and-containers-supported-for-audio-only.
        /// </summary>
        public Mp4Settings Mp4Settings { get; set; }

        /// <summary>
        /// Checks to see if the Mp4Settings property is set.
        /// </summary>
        internal bool IsSetMp4Settings() => this.Mp4Settings != null;

        /// <summary>
        /// Gets and sets the property MpdSettings. These settings relate to the fragmented MP4
        /// container for the segments in your DASH outputs.
        /// </summary>
        public MpdSettings MpdSettings { get; set; }

        /// <summary>
        /// Checks to see if the MpdSettings property is set.
        /// </summary>
        internal bool IsSetMpdSettings() => this.MpdSettings != null;

        /// <summary>
        /// Gets and sets the property MxfSettings. These settings relate to your MXF output container.
        /// </summary>
        public MxfSettings MxfSettings { get; set; }

        /// <summary>
        /// Checks to see if the MxfSettings property is set.
        /// </summary>
        internal bool IsSetMxfSettings() => this.MxfSettings != null;
    }
}
