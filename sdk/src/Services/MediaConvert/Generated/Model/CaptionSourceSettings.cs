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
 * Do not modify this file. This file is generated from the mediaconvert-2017-08-29.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.MediaConvert.Model
{
    /// <summary>
    /// Source settings (SourceSettings) contains the group of settings for captions in the
    /// input.
    /// </summary>
    public partial class CaptionSourceSettings
    {
        private AncillarySourceSettings _ancillarySourceSettings;
        private DvbSubSourceSettings _dvbSubSourceSettings;
        private EmbeddedSourceSettings _embeddedSourceSettings;
        private FileSourceSettings _fileSourceSettings;
        private CaptionSourceType _sourceType;
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
        /// Gets and sets the property FileSourceSettings.
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
        /// Gets and sets the property SourceType.
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