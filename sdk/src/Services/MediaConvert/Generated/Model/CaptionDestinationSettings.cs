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
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.MediaConvert.Model
{
    /// <summary>
    /// Specific settings required by destination type. Note that burnin_destination_settings
    /// are not available if the source of the caption data is Embedded or Teletext.
    /// </summary>
    public partial class CaptionDestinationSettings
    {
        private BurninDestinationSettings _burninDestinationSettings;
        private CaptionDestinationType _destinationType;
        private DvbSubDestinationSettings _dvbSubDestinationSettings;
        private EmbeddedDestinationSettings _embeddedDestinationSettings;
        private ImscDestinationSettings _imscDestinationSettings;
        private SccDestinationSettings _sccDestinationSettings;
        private TeletextDestinationSettings _teletextDestinationSettings;
        private TtmlDestinationSettings _ttmlDestinationSettings;

        /// <summary>
        /// Gets and sets the property BurninDestinationSettings. Burn-In Destination Settings.
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
        /// on this output. The default format is embedded without SCTE-20. Other options are
        /// embedded with SCTE-20, burn-in, DVB-sub, IMSC, SCC, SRT, teletext, TTML, and web-VTT.
        /// If you are using SCTE-20, choose SCTE-20 plus embedded (SCTE20_PLUS_EMBEDDED) to create
        /// an output that complies with the SCTE-43 spec. To create a non-compliant output where
        /// the embedded captions come first, choose Embedded plus SCTE-20 (EMBEDDED_PLUS_SCTE20).
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
        /// Gets and sets the property DvbSubDestinationSettings. DVB-Sub Destination Settings
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
        /// Gets and sets the property EmbeddedDestinationSettings. Settings specific to embedded/ancillary
        /// caption outputs, including 608/708 Channel destination number.
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
        /// Gets and sets the property ImscDestinationSettings. Settings specific to IMSC caption
        /// outputs.
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
        /// Gets and sets the property SccDestinationSettings. Settings for SCC caption output.
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
        /// Gets and sets the property TeletextDestinationSettings. Settings for Teletext caption
        /// output
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
        /// Gets and sets the property TtmlDestinationSettings. Settings specific to TTML caption
        /// outputs, including Pass style information (TtmlStylePassthrough).
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

    }
}