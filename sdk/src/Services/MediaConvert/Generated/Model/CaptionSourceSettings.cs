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

namespace Amazon.MediaConvert.Model
{
    /// <summary>
    /// If your input captions are SCC, TTML, STL, SMI, SRT, or IMSC in an xml file, specify
    /// the URI of the input captions source file. If your input captions are IMSC in an IMF
    /// package, use TrackSourceSettings instead of FileSoureSettings.
    /// </summary>
    public partial class CaptionSourceSettings
    {
        private AncillarySourceSettings _ancillarySourceSettings;
        private DvbSubSourceSettings _dvbSubSourceSettings;
        private EmbeddedSourceSettings _embeddedSourceSettings;
        private FileSourceSettings _fileSourceSettings;
        private CaptionSourceType _sourceType;
        private TeletextSourceSettings _teletextSourceSettings;
        private TrackSourceSettings _trackSourceSettings;
        private WebvttHlsSourceSettings _webvttHlsSourceSettings;

        /// <summary>
        /// Gets and sets the property AncillarySourceSettings. Settings for ancillary captions
        /// source.
        /// </summary>
        public AncillarySourceSettings AncillarySourceSettings
        {
            get { return this._ancillarySourceSettings; }
            set { this._ancillarySourceSettings = value; }
        }

        // Check to see if AncillarySourceSettings property is set
        internal bool IsSetAncillarySourceSettings()
        {
            return this._ancillarySourceSettings != null;
        }

        /// <summary>
        /// Gets and sets the property DvbSubSourceSettings. DVB Sub Source Settings
        /// </summary>
        public DvbSubSourceSettings DvbSubSourceSettings
        {
            get { return this._dvbSubSourceSettings; }
            set { this._dvbSubSourceSettings = value; }
        }

        // Check to see if DvbSubSourceSettings property is set
        internal bool IsSetDvbSubSourceSettings()
        {
            return this._dvbSubSourceSettings != null;
        }

        /// <summary>
        /// Gets and sets the property EmbeddedSourceSettings. Settings for embedded captions
        /// Source
        /// </summary>
        public EmbeddedSourceSettings EmbeddedSourceSettings
        {
            get { return this._embeddedSourceSettings; }
            set { this._embeddedSourceSettings = value; }
        }

        // Check to see if EmbeddedSourceSettings property is set
        internal bool IsSetEmbeddedSourceSettings()
        {
            return this._embeddedSourceSettings != null;
        }

        /// <summary>
        /// Gets and sets the property FileSourceSettings. If your input captions are SCC, SMI,
        /// SRT, STL, TTML, WebVTT, or IMSC 1.1 in an xml file, specify the URI of the input caption
        /// source file. If your caption source is IMSC in an IMF package, use TrackSourceSettings
        /// instead of FileSoureSettings.
        /// </summary>
        public FileSourceSettings FileSourceSettings
        {
            get { return this._fileSourceSettings; }
            set { this._fileSourceSettings = value; }
        }

        // Check to see if FileSourceSettings property is set
        internal bool IsSetFileSourceSettings()
        {
            return this._fileSourceSettings != null;
        }

        /// <summary>
        /// Gets and sets the property SourceType. Use Source (SourceType) to identify the format
        /// of your input captions. The service cannot auto-detect caption format.
        /// </summary>
        public CaptionSourceType SourceType
        {
            get { return this._sourceType; }
            set { this._sourceType = value; }
        }

        // Check to see if SourceType property is set
        internal bool IsSetSourceType()
        {
            return this._sourceType != null;
        }

        /// <summary>
        /// Gets and sets the property TeletextSourceSettings. Settings specific to Teletext caption
        /// sources, including Page number.
        /// </summary>
        public TeletextSourceSettings TeletextSourceSettings
        {
            get { return this._teletextSourceSettings; }
            set { this._teletextSourceSettings = value; }
        }

        // Check to see if TeletextSourceSettings property is set
        internal bool IsSetTeletextSourceSettings()
        {
            return this._teletextSourceSettings != null;
        }

        /// <summary>
        /// Gets and sets the property TrackSourceSettings. Settings specific to caption sources
        /// that are specified by track number. Currently, this is only IMSC captions in an IMF
        /// package. If your caption source is IMSC 1.1 in a separate xml file, use FileSourceSettings
        /// instead of TrackSourceSettings.
        /// </summary>
        public TrackSourceSettings TrackSourceSettings
        {
            get { return this._trackSourceSettings; }
            set { this._trackSourceSettings = value; }
        }

        // Check to see if TrackSourceSettings property is set
        internal bool IsSetTrackSourceSettings()
        {
            return this._trackSourceSettings != null;
        }

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
        public WebvttHlsSourceSettings WebvttHlsSourceSettings
        {
            get { return this._webvttHlsSourceSettings; }
            set { this._webvttHlsSourceSettings = value; }
        }

        // Check to see if WebvttHlsSourceSettings property is set
        internal bool IsSetWebvttHlsSourceSettings()
        {
            return this._webvttHlsSourceSettings != null;
        }

    }
}