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
    /// Caption Selector Settings
    /// </summary>
    public partial class CaptionSelectorSettings
    {
        private AncillarySourceSettings _ancillarySourceSettings;
        private AribSourceSettings _aribSourceSettings;
        private DvbSubSourceSettings _dvbSubSourceSettings;
        private EmbeddedSourceSettings _embeddedSourceSettings;
        private Scte20SourceSettings _scte20SourceSettings;
        private Scte27SourceSettings _scte27SourceSettings;
        private TeletextSourceSettings _teletextSourceSettings;

        /// <summary>
        /// Gets and sets the property AncillarySourceSettings.
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
        /// Gets and sets the property AribSourceSettings.
        /// </summary>
        public AribSourceSettings AribSourceSettings
        {
            get { return this._aribSourceSettings; }
            set { this._aribSourceSettings = value; }
        }

        // Check to see if AribSourceSettings property is set
        internal bool IsSetAribSourceSettings()
        {
            return this._aribSourceSettings != null;
        }

        /// <summary>
        /// Gets and sets the property DvbSubSourceSettings.
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
        /// Gets and sets the property EmbeddedSourceSettings.
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
        /// Gets and sets the property Scte20SourceSettings.
        /// </summary>
        public Scte20SourceSettings Scte20SourceSettings
        {
            get { return this._scte20SourceSettings; }
            set { this._scte20SourceSettings = value; }
        }

        // Check to see if Scte20SourceSettings property is set
        internal bool IsSetScte20SourceSettings()
        {
            return this._scte20SourceSettings != null;
        }

        /// <summary>
        /// Gets and sets the property Scte27SourceSettings.
        /// </summary>
        public Scte27SourceSettings Scte27SourceSettings
        {
            get { return this._scte27SourceSettings; }
            set { this._scte27SourceSettings = value; }
        }

        // Check to see if Scte27SourceSettings property is set
        internal bool IsSetScte27SourceSettings()
        {
            return this._scte27SourceSettings != null;
        }

        /// <summary>
        /// Gets and sets the property TeletextSourceSettings.
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

    }
}