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
    /// If your input captions are SCC, TTML, STL, SMI, SRT, or IMSC in an xml file, specify
    /// the URI of the input captions source file. If your input captions are IMSC in an IMF
    /// package, use TrackSourceSettings instead of FileSoureSettings.
    /// </summary>
    public partial class CaptionSourceSettings
    {
        /// <summary>
        /// Gets and sets the property AncillarySourceSettings. Settings for ancillary captions
        /// source.
        /// </summary>
        public AncillarySourceSettings AncillarySourceSettings { get; set; }

        /// <summary>
        /// Checks to see if the AncillarySourceSettings property is set.
        /// </summary>
        internal bool IsSetAncillarySourceSettings() => this.AncillarySourceSettings != null;

        /// <summary>
        /// Gets and sets the property DvbSubSourceSettings. DVB Sub Source Settings
        /// </summary>
        public DvbSubSourceSettings DvbSubSourceSettings { get; set; }

        /// <summary>
        /// Checks to see if the DvbSubSourceSettings property is set.
        /// </summary>
        internal bool IsSetDvbSubSourceSettings() => this.DvbSubSourceSettings != null;

        /// <summary>
        /// Gets and sets the property EmbeddedSourceSettings. Settings for embedded captions
        /// Source
        /// </summary>
        public EmbeddedSourceSettings EmbeddedSourceSettings { get; set; }

        /// <summary>
        /// Checks to see if the EmbeddedSourceSettings property is set.
        /// </summary>
        internal bool IsSetEmbeddedSourceSettings() => this.EmbeddedSourceSettings != null;

        /// <summary>
        /// Gets and sets the property FileSourceSettings. If your input captions are SCC, SMI,
        /// SRT, STL, TTML, WebVTT, or IMSC 1.1 in an xml file, specify the URI of the input caption
        /// source file. If your caption source is IMSC in an IMF package, use TrackSourceSettings
        /// instead of FileSoureSettings.
        /// </summary>
        public FileSourceSettings FileSourceSettings { get; set; }

        /// <summary>
        /// Checks to see if the FileSourceSettings property is set.
        /// </summary>
        internal bool IsSetFileSourceSettings() => this.FileSourceSettings != null;

        /// <summary>
        /// Gets and sets the property SourceType. Use Source to identify the format of your input
        /// captions. The service cannot auto-detect caption format.
        /// </summary>
        public CaptionSourceType SourceType { get; set; }

        /// <summary>
        /// Checks to see if the SourceType property is set.
        /// </summary>
        internal bool IsSetSourceType() => this.SourceType != null;

        /// <summary>
        /// Gets and sets the property TeletextSourceSettings. Settings specific to Teletext caption
        /// sources, including Page number.
        /// </summary>
        public TeletextSourceSettings TeletextSourceSettings { get; set; }

        /// <summary>
        /// Checks to see if the TeletextSourceSettings property is set.
        /// </summary>
        internal bool IsSetTeletextSourceSettings() => this.TeletextSourceSettings != null;

        /// <summary>
        /// Gets and sets the property TrackSourceSettings. Settings specific to caption sources
        /// that are specified by track number. Currently, this is only IMSC captions in an IMF
        /// package. If your caption source is IMSC 1.1 in a separate xml file, use FileSourceSettings
        /// instead of TrackSourceSettings.
        /// </summary>
        public TrackSourceSettings TrackSourceSettings { get; set; }

        /// <summary>
        /// Checks to see if the TrackSourceSettings property is set.
        /// </summary>
        internal bool IsSetTrackSourceSettings() => this.TrackSourceSettings != null;

        /// <summary>
        /// Gets and sets the property WebvttHlsSourceSettings. Settings specific to WebVTT sources
        /// in HLS alternative rendition group. Specify the properties (renditionGroupId, renditionName
        /// or renditionLanguageCode) to identify the unique subtitle track among the alternative
        /// rendition groups present in the HLS manifest. If no unique track is found, or multiple
        /// tracks match the specified properties, the job fails. If there is only one subtitle
        /// track in the rendition group, the settings can be left empty and the default subtitle
        /// track will be chosen. If your caption source is a sidecar file, use FileSourceSettings
        /// instead of WebvttHlsSourceSettings.
        /// </summary>
        public WebvttHlsSourceSettings WebvttHlsSourceSettings { get; set; }

        /// <summary>
        /// Checks to see if the WebvttHlsSourceSettings property is set.
        /// </summary>
        internal bool IsSetWebvttHlsSourceSettings() => this.WebvttHlsSourceSettings != null;
    }
}
