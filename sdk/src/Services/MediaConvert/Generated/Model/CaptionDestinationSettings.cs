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
    /// Specific settings required by destination type. Note that burnin_destination_settings
    /// are not available if the source of the caption data is Embedded or Teletext.
    /// </summary>
    public partial class CaptionDestinationSettings
    {
        private BurninDestinationSettings _burninDestinationSettings;
        private CaptionDestinationType _destinationType;
        private DvbSubDestinationSettings _dvbSubDestinationSettings;
        private SccDestinationSettings _sccDestinationSettings;
        private TeletextDestinationSettings _teletextDestinationSettings;
        private TtmlDestinationSettings _ttmlDestinationSettings;

        /// <summary>
        /// Gets and sets the property BurninDestinationSettings.
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
        /// Gets and sets the property DestinationType.
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
        /// Gets and sets the property SccDestinationSettings.
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

    }
}