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
    /// Caption Destination Settings
    /// </summary>
    public partial class CaptionDestinationSettings
    {
        private AribDestinationSettings _aribDestinationSettings;
        private BurnInDestinationSettings _burnInDestinationSettings;
        private DvbSubDestinationSettings _dvbSubDestinationSettings;
        private EbuTtDDestinationSettings _ebuTtDDestinationSettings;
        private EmbeddedDestinationSettings _embeddedDestinationSettings;
        private EmbeddedPlusScte20DestinationSettings _embeddedPlusScte20DestinationSettings;
        private RtmpCaptionInfoDestinationSettings _rtmpCaptionInfoDestinationSettings;
        private Scte20PlusEmbeddedDestinationSettings _scte20PlusEmbeddedDestinationSettings;
        private Scte27DestinationSettings _scte27DestinationSettings;
        private SmpteTtDestinationSettings _smpteTtDestinationSettings;
        private TeletextDestinationSettings _teletextDestinationSettings;
        private TtmlDestinationSettings _ttmlDestinationSettings;
        private WebvttDestinationSettings _webvttDestinationSettings;

        /// <summary>
        /// Gets and sets the property AribDestinationSettings.
        /// </summary>
        public AribDestinationSettings AribDestinationSettings
        {
            get { return this._aribDestinationSettings; }
            set { this._aribDestinationSettings = value; }
        }

        // Check to see if AribDestinationSettings property is set
        internal bool IsSetAribDestinationSettings()
        {
            return this._aribDestinationSettings != null;
        }

        /// <summary>
        /// Gets and sets the property BurnInDestinationSettings.
        /// </summary>
        public BurnInDestinationSettings BurnInDestinationSettings
        {
            get { return this._burnInDestinationSettings; }
            set { this._burnInDestinationSettings = value; }
        }

        // Check to see if BurnInDestinationSettings property is set
        internal bool IsSetBurnInDestinationSettings()
        {
            return this._burnInDestinationSettings != null;
        }

        /// <summary>
        /// Gets and sets the property DvbSubDestinationSettings.
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
        /// Gets and sets the property EbuTtDDestinationSettings.
        /// </summary>
        public EbuTtDDestinationSettings EbuTtDDestinationSettings
        {
            get { return this._ebuTtDDestinationSettings; }
            set { this._ebuTtDDestinationSettings = value; }
        }

        // Check to see if EbuTtDDestinationSettings property is set
        internal bool IsSetEbuTtDDestinationSettings()
        {
            return this._ebuTtDDestinationSettings != null;
        }

        /// <summary>
        /// Gets and sets the property EmbeddedDestinationSettings.
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
        /// Gets and sets the property EmbeddedPlusScte20DestinationSettings.
        /// </summary>
        public EmbeddedPlusScte20DestinationSettings EmbeddedPlusScte20DestinationSettings
        {
            get { return this._embeddedPlusScte20DestinationSettings; }
            set { this._embeddedPlusScte20DestinationSettings = value; }
        }

        // Check to see if EmbeddedPlusScte20DestinationSettings property is set
        internal bool IsSetEmbeddedPlusScte20DestinationSettings()
        {
            return this._embeddedPlusScte20DestinationSettings != null;
        }

        /// <summary>
        /// Gets and sets the property RtmpCaptionInfoDestinationSettings.
        /// </summary>
        public RtmpCaptionInfoDestinationSettings RtmpCaptionInfoDestinationSettings
        {
            get { return this._rtmpCaptionInfoDestinationSettings; }
            set { this._rtmpCaptionInfoDestinationSettings = value; }
        }

        // Check to see if RtmpCaptionInfoDestinationSettings property is set
        internal bool IsSetRtmpCaptionInfoDestinationSettings()
        {
            return this._rtmpCaptionInfoDestinationSettings != null;
        }

        /// <summary>
        /// Gets and sets the property Scte20PlusEmbeddedDestinationSettings.
        /// </summary>
        public Scte20PlusEmbeddedDestinationSettings Scte20PlusEmbeddedDestinationSettings
        {
            get { return this._scte20PlusEmbeddedDestinationSettings; }
            set { this._scte20PlusEmbeddedDestinationSettings = value; }
        }

        // Check to see if Scte20PlusEmbeddedDestinationSettings property is set
        internal bool IsSetScte20PlusEmbeddedDestinationSettings()
        {
            return this._scte20PlusEmbeddedDestinationSettings != null;
        }

        /// <summary>
        /// Gets and sets the property Scte27DestinationSettings.
        /// </summary>
        public Scte27DestinationSettings Scte27DestinationSettings
        {
            get { return this._scte27DestinationSettings; }
            set { this._scte27DestinationSettings = value; }
        }

        // Check to see if Scte27DestinationSettings property is set
        internal bool IsSetScte27DestinationSettings()
        {
            return this._scte27DestinationSettings != null;
        }

        /// <summary>
        /// Gets and sets the property SmpteTtDestinationSettings.
        /// </summary>
        public SmpteTtDestinationSettings SmpteTtDestinationSettings
        {
            get { return this._smpteTtDestinationSettings; }
            set { this._smpteTtDestinationSettings = value; }
        }

        // Check to see if SmpteTtDestinationSettings property is set
        internal bool IsSetSmpteTtDestinationSettings()
        {
            return this._smpteTtDestinationSettings != null;
        }

        /// <summary>
        /// Gets and sets the property TeletextDestinationSettings.
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
        /// Gets and sets the property TtmlDestinationSettings.
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
        /// Gets and sets the property WebvttDestinationSettings.
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