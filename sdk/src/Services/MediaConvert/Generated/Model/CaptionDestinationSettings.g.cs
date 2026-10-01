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
    /// Settings related to one captions tab on the MediaConvert console. Usually, one captions
    /// tab corresponds to one output captions track. Depending on your output captions format,
    /// one tab might correspond to a set of output captions tracks. For more information,
    /// see https://docs.aws.amazon.com/mediaconvert/latest/ug/including-captions.html.
    /// </summary>
    public partial class CaptionDestinationSettings
    {
        /// <summary>
        /// Gets and sets the property BurninDestinationSettings. Burn-in is a captions delivery
        /// method, rather than a captions format. Burn-in writes the captions directly on your
        /// video frames, replacing pixels of video content with the captions. Set up burn-in
        /// captions in the same output as your video. For more information, see https://docs.aws.amazon.com/mediaconvert/latest/ug/burn-in-output-captions.html.
        /// </summary>
        public BurninDestinationSettings BurninDestinationSettings { get; set; }

        /// <summary>
        /// Checks to see if the BurninDestinationSettings property is set.
        /// </summary>
        internal bool IsSetBurninDestinationSettings() => this.BurninDestinationSettings != null;

        /// <summary>
        /// Gets and sets the property DestinationType. Specify the format for this set of captions
        /// on this output. The default format is embedded without SCTE-20. Note that your choice
        /// of video output container constrains your choice of output captions format. For more
        /// information, see https://docs.aws.amazon.com/mediaconvert/latest/ug/captions-support-tables.html.
        /// If you are using SCTE-20 and you want to create an output that complies with the SCTE-43
        /// spec, choose SCTE-20 plus embedded. To create a non-compliant output where the embedded
        /// captions come first, choose Embedded plus SCTE-20.
        /// </summary>
        public CaptionDestinationType DestinationType { get; set; }

        /// <summary>
        /// Checks to see if the DestinationType property is set.
        /// </summary>
        internal bool IsSetDestinationType() => this.DestinationType != null;

        /// <summary>
        /// Gets and sets the property DvbSubDestinationSettings. Settings related to DVB-Sub
        /// captions. Set up DVB-Sub captions in the same output as your video. For more information,
        /// see https://docs.aws.amazon.com/mediaconvert/latest/ug/dvb-sub-output-captions.html.
        /// </summary>
        public DvbSubDestinationSettings DvbSubDestinationSettings { get; set; }

        /// <summary>
        /// Checks to see if the DvbSubDestinationSettings property is set.
        /// </summary>
        internal bool IsSetDvbSubDestinationSettings() => this.DvbSubDestinationSettings != null;

        /// <summary>
        /// Gets and sets the property EmbeddedDestinationSettings. Settings related to CEA/EIA-608
        /// and CEA/EIA-708 (also called embedded or ancillary) captions. Set up embedded captions
        /// in the same output as your video. For more information, see https://docs.aws.amazon.com/mediaconvert/latest/ug/embedded-output-captions.html.
        /// </summary>
        public EmbeddedDestinationSettings EmbeddedDestinationSettings { get; set; }

        /// <summary>
        /// Checks to see if the EmbeddedDestinationSettings property is set.
        /// </summary>
        internal bool IsSetEmbeddedDestinationSettings() => this.EmbeddedDestinationSettings != null;

        /// <summary>
        /// Gets and sets the property ImscDestinationSettings. Settings related to IMSC captions.
        /// IMSC is a sidecar format that holds captions in a file that is separate from the video
        /// container. Set up sidecar captions in the same output group, but different output
        /// from your video. For more information, see https://docs.aws.amazon.com/mediaconvert/latest/ug/ttml-and-webvtt-output-captions.html.
        /// </summary>
        public ImscDestinationSettings ImscDestinationSettings { get; set; }

        /// <summary>
        /// Checks to see if the ImscDestinationSettings property is set.
        /// </summary>
        internal bool IsSetImscDestinationSettings() => this.ImscDestinationSettings != null;

        /// <summary>
        /// Gets and sets the property SccDestinationSettings. Settings related to SCC captions.
        /// SCC is a sidecar format that holds captions in a file that is separate from the video
        /// container. Set up sidecar captions in the same output group, but different output
        /// from your video. For more information, see https://docs.aws.amazon.com/mediaconvert/latest/ug/scc-srt-output-captions.html.
        /// </summary>
        public SccDestinationSettings SccDestinationSettings { get; set; }

        /// <summary>
        /// Checks to see if the SccDestinationSettings property is set.
        /// </summary>
        internal bool IsSetSccDestinationSettings() => this.SccDestinationSettings != null;

        /// <summary>
        /// Gets and sets the property SrtDestinationSettings. Settings related to SRT captions.
        /// SRT is a sidecar format that holds captions in a file that is separate from the video
        /// container. Set up sidecar captions in the same output group, but different output
        /// from your video.
        /// </summary>
        public SrtDestinationSettings SrtDestinationSettings { get; set; }

        /// <summary>
        /// Checks to see if the SrtDestinationSettings property is set.
        /// </summary>
        internal bool IsSetSrtDestinationSettings() => this.SrtDestinationSettings != null;

        /// <summary>
        /// Gets and sets the property TeletextDestinationSettings. Settings related to teletext
        /// captions. Set up teletext captions in the same output as your video. For more information,
        /// see https://docs.aws.amazon.com/mediaconvert/latest/ug/teletext-output-captions.html.
        /// </summary>
        public TeletextDestinationSettings TeletextDestinationSettings { get; set; }

        /// <summary>
        /// Checks to see if the TeletextDestinationSettings property is set.
        /// </summary>
        internal bool IsSetTeletextDestinationSettings() => this.TeletextDestinationSettings != null;

        /// <summary>
        /// Gets and sets the property TtmlDestinationSettings. Settings related to TTML captions.
        /// TTML is a sidecar format that holds captions in a file that is separate from the video
        /// container. Set up sidecar captions in the same output group, but different output
        /// from your video. For more information, see https://docs.aws.amazon.com/mediaconvert/latest/ug/ttml-and-webvtt-output-captions.html.
        /// </summary>
        public TtmlDestinationSettings TtmlDestinationSettings { get; set; }

        /// <summary>
        /// Checks to see if the TtmlDestinationSettings property is set.
        /// </summary>
        internal bool IsSetTtmlDestinationSettings() => this.TtmlDestinationSettings != null;

        /// <summary>
        /// Gets and sets the property WebvttDestinationSettings. Settings related to WebVTT captions.
        /// WebVTT is a sidecar format that holds captions in a file that is separate from the
        /// video container. Set up sidecar captions in the same output group, but different output
        /// from your video. For more information, see https://docs.aws.amazon.com/mediaconvert/latest/ug/ttml-and-webvtt-output-captions.html.
        /// </summary>
        public WebvttDestinationSettings WebvttDestinationSettings { get; set; }

        /// <summary>
        /// Checks to see if the WebvttDestinationSettings property is set.
        /// </summary>
        internal bool IsSetWebvttDestinationSettings() => this.WebvttDestinationSettings != null;
    }
}
