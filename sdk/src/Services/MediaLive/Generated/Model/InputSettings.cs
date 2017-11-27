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
 * Do not modify this file. This file is generated from the medialive-2017-10-14.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.MediaLive.Model
{
    /// <summary>
    /// Live Event input parameters. There can be multiple inputs in a single Live Event.
    /// </summary>
    public partial class InputSettings
    {
        private List<AudioSelector> _audioSelectors = new List<AudioSelector>();
        private List<CaptionSelector> _captionSelectors = new List<CaptionSelector>();
        private InputDeblockFilter _deblockFilter;
        private InputDenoiseFilter _denoiseFilter;
        private int? _filterStrength;
        private InputFilter _inputFilter;
        private NetworkInputSettings _networkInputSettings;
        private InputSourceEndBehavior _sourceEndBehavior;
        private VideoSelector _videoSelector;

        /// <summary>
        /// Gets and sets the property AudioSelectors. Used to select the audio stream to decode
        /// for inputs that have multiple available.
        /// </summary>
        public List<AudioSelector> AudioSelectors
        {
            get { return this._audioSelectors; }
            set { this._audioSelectors = value; }
        }

        // Check to see if AudioSelectors property is set
        internal bool IsSetAudioSelectors()
        {
            return this._audioSelectors != null && this._audioSelectors.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property CaptionSelectors. Used to select the caption input to use
        /// for inputs that have multiple available.
        /// </summary>
        public List<CaptionSelector> CaptionSelectors
        {
            get { return this._captionSelectors; }
            set { this._captionSelectors = value; }
        }

        // Check to see if CaptionSelectors property is set
        internal bool IsSetCaptionSelectors()
        {
            return this._captionSelectors != null && this._captionSelectors.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property DeblockFilter. Enable or disable the deblock filter when
        /// filtering.
        /// </summary>
        public InputDeblockFilter DeblockFilter
        {
            get { return this._deblockFilter; }
            set { this._deblockFilter = value; }
        }

        // Check to see if DeblockFilter property is set
        internal bool IsSetDeblockFilter()
        {
            return this._deblockFilter != null;
        }

        /// <summary>
        /// Gets and sets the property DenoiseFilter. Enable or disable the denoise filter when
        /// filtering.
        /// </summary>
        public InputDenoiseFilter DenoiseFilter
        {
            get { return this._denoiseFilter; }
            set { this._denoiseFilter = value; }
        }

        // Check to see if DenoiseFilter property is set
        internal bool IsSetDenoiseFilter()
        {
            return this._denoiseFilter != null;
        }

        /// <summary>
        /// Gets and sets the property FilterStrength. Adjusts the magnitude of filtering from
        /// 1 (minimal) to 5 (strongest).
        /// </summary>
        public int FilterStrength
        {
            get { return this._filterStrength.GetValueOrDefault(); }
            set { this._filterStrength = value; }
        }

        // Check to see if FilterStrength property is set
        internal bool IsSetFilterStrength()
        {
            return this._filterStrength.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property InputFilter. Turns on the filter for this input. MPEG-2
        /// inputs have the deblocking filter enabled by default.1) auto - filtering will be applied
        /// depending on input type/quality2) disabled - no filtering will be applied to the input3)
        /// forced - filtering will be applied regardless of input type
        /// </summary>
        public InputFilter InputFilter
        {
            get { return this._inputFilter; }
            set { this._inputFilter = value; }
        }

        // Check to see if InputFilter property is set
        internal bool IsSetInputFilter()
        {
            return this._inputFilter != null;
        }

        /// <summary>
        /// Gets and sets the property NetworkInputSettings. Input settings.
        /// </summary>
        public NetworkInputSettings NetworkInputSettings
        {
            get { return this._networkInputSettings; }
            set { this._networkInputSettings = value; }
        }

        // Check to see if NetworkInputSettings property is set
        internal bool IsSetNetworkInputSettings()
        {
            return this._networkInputSettings != null;
        }

        /// <summary>
        /// Gets and sets the property SourceEndBehavior. Loop input if it is a file. This allows
        /// a file input to be streamed indefinitely.
        /// </summary>
        public InputSourceEndBehavior SourceEndBehavior
        {
            get { return this._sourceEndBehavior; }
            set { this._sourceEndBehavior = value; }
        }

        // Check to see if SourceEndBehavior property is set
        internal bool IsSetSourceEndBehavior()
        {
            return this._sourceEndBehavior != null;
        }

        /// <summary>
        /// Gets and sets the property VideoSelector. Informs which video elementary stream to
        /// decode for input types that have multiple available.
        /// </summary>
        public VideoSelector VideoSelector
        {
            get { return this._videoSelector; }
            set { this._videoSelector = value; }
        }

        // Check to see if VideoSelector property is set
        internal bool IsSetVideoSelector()
        {
            return this._videoSelector != null;
        }

    }
}