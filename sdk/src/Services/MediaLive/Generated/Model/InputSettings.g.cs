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

namespace Amazon.MediaLive.Model
{
    /// <summary>
    /// Live Event input parameters. There can be multiple inputs in a single Live Event.
    /// </summary>
    public partial class InputSettings
    {
        /// <summary>
        /// Gets and sets the property AudioSelectors. Used to select the audio stream to decode
        /// for inputs that have multiple available.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AudioSelector> AudioSelectors { get; set; } = AWSConfigs.InitializeCollections ? new List<AudioSelector>() : null;

        /// <summary>
        /// Checks to see if the AudioSelectors property is set.
        /// </summary>
        internal bool IsSetAudioSelectors() => this.AudioSelectors != null && (this.AudioSelectors.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property CaptionSelectors. Used to select the caption input to use
        /// for inputs that have multiple available.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<CaptionSelector> CaptionSelectors { get; set; } = AWSConfigs.InitializeCollections ? new List<CaptionSelector>() : null;

        /// <summary>
        /// Checks to see if the CaptionSelectors property is set.
        /// </summary>
        internal bool IsSetCaptionSelectors() => this.CaptionSelectors != null && (this.CaptionSelectors.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property DeblockFilter. Enable or disable the deblock filter when
        /// filtering.
        /// </summary>
        public InputDeblockFilter DeblockFilter { get; set; }

        /// <summary>
        /// Checks to see if the DeblockFilter property is set.
        /// </summary>
        internal bool IsSetDeblockFilter() => this.DeblockFilter != null;

        /// <summary>
        /// Gets and sets the property DenoiseFilter. Enable or disable the denoise filter when
        /// filtering.
        /// </summary>
        public InputDenoiseFilter DenoiseFilter { get; set; }

        /// <summary>
        /// Checks to see if the DenoiseFilter property is set.
        /// </summary>
        internal bool IsSetDenoiseFilter() => this.DenoiseFilter != null;

        /// <summary>
        /// Gets and sets the property FilterStrength. Adjusts the magnitude of filtering from
        /// 1 (minimal) to 5 (strongest).
        /// </summary>
        public int? FilterStrength { get; set; }

        /// <summary>
        /// Checks to see if the FilterStrength property is set.
        /// </summary>
        internal bool IsSetFilterStrength() => this.FilterStrength.HasValue;

        /// <summary>
        /// Gets and sets the property InputFilter. Turns on the filter for this input. MPEG-2
        /// inputs have the deblocking filter enabled by default. 1) auto - filtering will be
        /// applied depending on input type/quality 2) disabled - no filtering will be applied
        /// to the input 3) forced - filtering will be applied regardless of input type
        /// </summary>
        public InputFilter InputFilter { get; set; }

        /// <summary>
        /// Checks to see if the InputFilter property is set.
        /// </summary>
        internal bool IsSetInputFilter() => this.InputFilter != null;

        /// <summary>
        /// Gets and sets the property NetworkInputSettings. Input settings.
        /// </summary>
        public NetworkInputSettings NetworkInputSettings { get; set; }

        /// <summary>
        /// Checks to see if the NetworkInputSettings property is set.
        /// </summary>
        internal bool IsSetNetworkInputSettings() => this.NetworkInputSettings != null;

        /// <summary>
        /// Gets and sets the property Scte35Pid. PID from which to read SCTE-35 messages. If
        /// left undefined, EML will select the first SCTE-35 PID found in the input.
        /// </summary>
        public int? Scte35Pid { get; set; }

        /// <summary>
        /// Checks to see if the Scte35Pid property is set.
        /// </summary>
        internal bool IsSetScte35Pid() => this.Scte35Pid.HasValue;

        /// <summary>
        /// Gets and sets the property Smpte2038DataPreference. Specifies whether to extract applicable
        /// ancillary data from a SMPTE-2038 source in this input. Applicable data types are captions,
        /// timecode, AFD, and SCTE-104 messages. - PREFER: Extract from SMPTE-2038 if present
        /// in this input, otherwise extract from another source (if any). - IGNORE: Never extract
        /// any ancillary data from SMPTE-2038.
        /// </summary>
        public Smpte2038DataPreference Smpte2038DataPreference { get; set; }

        /// <summary>
        /// Checks to see if the Smpte2038DataPreference property is set.
        /// </summary>
        internal bool IsSetSmpte2038DataPreference() => this.Smpte2038DataPreference != null;

        /// <summary>
        /// Gets and sets the property SourceEndBehavior. Loop input if it is a file. This allows
        /// a file input to be streamed indefinitely.
        /// </summary>
        public InputSourceEndBehavior SourceEndBehavior { get; set; }

        /// <summary>
        /// Checks to see if the SourceEndBehavior property is set.
        /// </summary>
        internal bool IsSetSourceEndBehavior() => this.SourceEndBehavior != null;

        /// <summary>
        /// Gets and sets the property VideoSelector. Informs which video elementary stream to
        /// decode for input types that have multiple available.
        /// </summary>
        public VideoSelector VideoSelector { get; set; }

        /// <summary>
        /// Checks to see if the VideoSelector property is set.
        /// </summary>
        internal bool IsSetVideoSelector() => this.VideoSelector != null;
    }
}
