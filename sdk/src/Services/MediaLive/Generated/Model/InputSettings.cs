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
    /// Live Event input parameters. There can be multiple inputs in a single Live Event.
    /// </summary>
    public partial class InputSettings
    {
        private List<AudioSelector> _audioSelectors = AWSConfigs.InitializeCollections ? new List<AudioSelector>() : null;
        private List<CaptionSelector> _captionSelectors = AWSConfigs.InitializeCollections ? new List<CaptionSelector>() : null;
        private InputDeblockFilter _deblockFilter;
        private InputDenoiseFilter _denoiseFilter;
        private int? _filterStrength;
        private InputFilter _inputFilter;
        private NetworkInputSettings _networkInputSettings;
        private int? _scte35Pid;
        private Smpte2038DataPreference _smpte2038DataPreference;
        private InputSourceEndBehavior _sourceEndBehavior;
        private VideoSelector _videoSelector;

        /// <summary>
        /// Gets and sets the property AudioSelectors. Used to select the audio stream to decode
        /// for inputs that have multiple available.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AudioSelector> AudioSelectors
        {
            get { return this._audioSelectors; }
            set { this._audioSelectors = value; }
        }

        // Check to see if AudioSelectors property is set
        internal bool IsSetAudioSelectors()
        {
            return this._audioSelectors != null && (this._audioSelectors.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property CaptionSelectors. Used to select the caption input to use
        /// for inputs that have multiple available.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<CaptionSelector> CaptionSelectors
        {
            get { return this._captionSelectors; }
            set { this._captionSelectors = value; }
        }

        // Check to see if CaptionSelectors property is set
        internal bool IsSetCaptionSelectors()
        {
            return this._captionSelectors != null && (this._captionSelectors.Count > 0 || !AWSConfigs.InitializeCollections); 
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
        [AWSProperty(Min=1, Max=5)]
        public int? FilterStrength
        {
            get { return this._filterStrength; }
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
        /// Gets and sets the property Scte35Pid. PID from which to read SCTE-35 messages. If
        /// left undefined, EML will select the first SCTE-35 PID found in the input.
        /// </summary>
        [AWSProperty(Min=32, Max=8191)]
        public int? Scte35Pid
        {
            get { return this._scte35Pid; }
            set { this._scte35Pid = value; }
        }

        // Check to see if Scte35Pid property is set
        internal bool IsSetScte35Pid()
        {
            return this._scte35Pid.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Smpte2038DataPreference. Specifies whether to extract applicable
        /// ancillary data from a SMPTE-2038 source in this input. Applicable data types are captions,
        /// timecode, AFD, and SCTE-104 messages.- PREFER: Extract from SMPTE-2038 if present
        /// in this input, otherwise extract from another source (if any).- IGNORE: Never extract
        /// any ancillary data from SMPTE-2038.
        /// </summary>
        public Smpte2038DataPreference Smpte2038DataPreference
        {
            get { return this._smpte2038DataPreference; }
            set { this._smpte2038DataPreference = value; }
        }

        // Check to see if Smpte2038DataPreference property is set
        internal bool IsSetSmpte2038DataPreference()
        {
            return this._smpte2038DataPreference != null;
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