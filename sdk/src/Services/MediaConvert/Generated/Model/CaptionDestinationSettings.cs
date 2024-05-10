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
 * Do not modify this file. This file is generated from the mediaconvert-2017-08-29.normal.json service model.
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
        private BurninDestinationSettings _burninDestinationSettings;
        private CaptionDestinationType _destinationType;
        private DvbSubDestinationSettings _dvbSubDestinationSettings;
        private EmbeddedDestinationSettings _embeddedDestinationSettings;
        private ImscDestinationSettings _imscDestinationSettings;
        private SccDestinationSettings _sccDestinationSettings;
        private SrtDestinationSettings _srtDestinationSettings;
        private TeletextDestinationSettings _teletextDestinationSettings;
        private TtmlDestinationSettings _ttmlDestinationSettings;
        private WebvttDestinationSettings _webvttDestinationSettings;

        /// <summary>
        /// Gets and sets the property BurninDestinationSettings. Burn-in is a captions delivery
        /// method, rather than a captions format. Burn-in writes the captions directly on your
        /// video frames, replacing pixels of video content with the captions. Set up burn-in
        /// captions in the same output as your video. For more information, see https://docs.aws.amazon.com/mediaconvert/latest/ug/burn-in-output-captions.html.
        /// </summary>
        public BurninDestinationSettings BurninDestinationSettings
        {
            get { return this._burninDestinationSettings; }
            set { this._burninDestinationSettings = value; }
        }

        // Check to see if BurninDestinationSettings property is set
        internal bool IsSetBurninDestinationSettings()
        {
            return this._burninDestinationSettings != null;
        }

        /// <summary>
        /// Gets and sets the property DestinationType. Specify the format for this set of captions
        /// on this output. The default format is embedded without SCTE-20. Note that your choice
        /// of video output container constrains your choice of output captions format. For more
        /// information, see https://docs.aws.amazon.com/mediaconvert/latest/ug/captions-support-tables.html.
        /// If you are using SCTE-20 and you want to create an output that complies with the SCTE-43
        /// spec, choose SCTE-20 plus embedded. To create a non-compliant output where the embedded
        /// captions come first, choose Embedded plus SCTE-20.
        /// </summary>
        public CaptionDestinationType DestinationType
        {
            get { return this._destinationType; }
            set { this._destinationType = value; }
        }

        // Check to see if DestinationType property is set
        internal bool IsSetDestinationType()
        {
            return this._destinationType != null;
        }

        /// <summary>
        /// Gets and sets the property DvbSubDestinationSettings. Settings related to DVB-Sub
        /// captions. Set up DVB-Sub captions in the same output as your video. For more information,
        /// see https://docs.aws.amazon.com/mediaconvert/latest/ug/dvb-sub-output-captions.html.
        /// </summary>
        public DvbSubDestinationSettings DvbSubDestinationSettings
        {
            get { return this._dvbSubDestinationSettings; }
            set { this._dvbSubDestinationSettings = value; }
        }

        // Check to see if DvbSubDestinationSettings property is set
        internal bool IsSetDvbSubDestinationSettings()
        {
            return this._dvbSubDestinationSettings != null;
        }

        /// <summary>
        /// Gets and sets the property EmbeddedDestinationSettings. Settings related to CEA/EIA-608
        /// and CEA/EIA-708 (also called embedded or ancillary) captions. Set up embedded captions
        /// in the same output as your video. For more information, see https://docs.aws.amazon.com/mediaconvert/latest/ug/embedded-output-captions.html.
        /// </summary>
        public EmbeddedDestinationSettings EmbeddedDestinationSettings
        {
            get { return this._embeddedDestinationSettings; }
            set { this._embeddedDestinationSettings = value; }
        }

        // Check to see if EmbeddedDestinationSettings property is set
        internal bool IsSetEmbeddedDestinationSettings()
        {
            return this._embeddedDestinationSettings != null;
        }

        /// <summary>
        /// Gets and sets the property ImscDestinationSettings. Settings related to IMSC captions.
        /// IMSC is a sidecar format that holds captions in a file that is separate from the video
        /// container. Set up sidecar captions in the same output group, but different output
        /// from your video. For more information, see https://docs.aws.amazon.com/mediaconvert/latest/ug/ttml-and-webvtt-output-captions.html.
        /// </summary>
        public ImscDestinationSettings ImscDestinationSettings
        {
            get { return this._imscDestinationSettings; }
            set { this._imscDestinationSettings = value; }
        }

        // Check to see if ImscDestinationSettings property is set
        internal bool IsSetImscDestinationSettings()
        {
            return this._imscDestinationSettings != null;
        }

        /// <summary>
        /// Gets and sets the property SccDestinationSettings. Settings related to SCC captions.
        /// SCC is a sidecar format that holds captions in a file that is separate from the video
        /// container. Set up sidecar captions in the same output group, but different output
        /// from your video. For more information, see https://docs.aws.amazon.com/mediaconvert/latest/ug/scc-srt-output-captions.html.
        /// </summary>
        public SccDestinationSettings SccDestinationSettings
        {
            get { return this._sccDestinationSettings; }
            set { this._sccDestinationSettings = value; }
        }

        // Check to see if SccDestinationSettings property is set
        internal bool IsSetSccDestinationSettings()
        {
            return this._sccDestinationSettings != null;
        }

        /// <summary>
        /// Gets and sets the property SrtDestinationSettings. Settings related to SRT captions.
        /// SRT is a sidecar format that holds captions in a file that is separate from the video
        /// container. Set up sidecar captions in the same output group, but different output
        /// from your video.
        /// </summary>
        public SrtDestinationSettings SrtDestinationSettings
        {
            get { return this._srtDestinationSettings; }
            set { this._srtDestinationSettings = value; }
        }

        // Check to see if SrtDestinationSettings property is set
        internal bool IsSetSrtDestinationSettings()
        {
            return this._srtDestinationSettings != null;
        }

        /// <summary>
        /// Gets and sets the property TeletextDestinationSettings. Settings related to teletext
        /// captions. Set up teletext captions in the same output as your video. For more information,
        /// see https://docs.aws.amazon.com/mediaconvert/latest/ug/teletext-output-captions.html.
        /// </summary>
        public TeletextDestinationSettings TeletextDestinationSettings
        {
            get { return this._teletextDestinationSettings; }
            set { this._teletextDestinationSettings = value; }
        }

        // Check to see if TeletextDestinationSettings property is set
        internal bool IsSetTeletextDestinationSettings()
        {
            return this._teletextDestinationSettings != null;
        }

        /// <summary>
        /// Gets and sets the property TtmlDestinationSettings. Settings related to TTML captions.
        /// TTML is a sidecar format that holds captions in a file that is separate from the video
        /// container. Set up sidecar captions in the same output group, but different output
        /// from your video. For more information, see https://docs.aws.amazon.com/mediaconvert/latest/ug/ttml-and-webvtt-output-captions.html.
        /// </summary>
        public TtmlDestinationSettings TtmlDestinationSettings
        {
            get { return this._ttmlDestinationSettings; }
            set { this._ttmlDestinationSettings = value; }
        }

        // Check to see if TtmlDestinationSettings property is set
        internal bool IsSetTtmlDestinationSettings()
        {
            return this._ttmlDestinationSettings != null;
        }

        /// <summary>
        /// Gets and sets the property WebvttDestinationSettings. Settings related to WebVTT captions.
        /// WebVTT is a sidecar format that holds captions in a file that is separate from the
        /// video container. Set up sidecar captions in the same output group, but different output
        /// from your video. For more information, see https://docs.aws.amazon.com/mediaconvert/latest/ug/ttml-and-webvtt-output-captions.html.
        /// </summary>
        public WebvttDestinationSettings WebvttDestinationSettings
        {
            get { return this._webvttDestinationSettings; }
            set { this._webvttDestinationSettings = value; }
        }

        // Check to see if WebvttDestinationSettings property is set
        internal bool IsSetWebvttDestinationSettings()
        {
            return this._webvttDestinationSettings != null;
        }

    }
}