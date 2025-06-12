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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.MediaConvert.Model
{
    /// <summary>
    /// Input settings for Video overlay. You can include one or more video overlays in sequence
    /// at different times that you specify.
    /// </summary>
    public partial class VideoOverlayInput
    {
        private string _fileInput;
        private List<VideoOverlayInputClipping> _inputClippings = AWSConfigs.InitializeCollections ? new List<VideoOverlayInputClipping>() : null;
        private InputTimecodeSource _timecodeSource;
        private string _timecodeStart;

        /// <summary>
        /// Gets and sets the property FileInput. Specify the input file S3, HTTP, or HTTPS URL
        /// for your video overlay.To specify one or more Transitions for your base input video
        /// instead: Leave blank.
        /// </summary>
        public string FileInput
        {
            get { return this._fileInput; }
            set { this._fileInput = value; }
        }

        // Check to see if FileInput property is set
        internal bool IsSetFileInput()
        {
            return this._fileInput != null;
        }

        /// <summary>
        /// Gets and sets the property InputClippings. Specify one or more clips to use from your
        /// video overlay. When you include an input clip, you must also specify its start timecode,
        /// end timecode, or both start and end timecode.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<VideoOverlayInputClipping> InputClippings
        {
            get { return this._inputClippings; }
            set { this._inputClippings = value; }
        }

        // Check to see if InputClippings property is set
        internal bool IsSetInputClippings()
        {
            return this._inputClippings != null && (this._inputClippings.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TimecodeSource. Specify the timecode source for your video
        /// overlay input clips. To use the timecode present in your video overlay: Choose Embedded.
        /// To use a zerobased timecode: Choose Start at 0. To choose a timecode: Choose Specified
        /// start. When you do, enter the starting timecode in Start timecode. If you don't specify
        /// a value for Timecode source, MediaConvert uses Embedded by default.
        /// </summary>
        public InputTimecodeSource TimecodeSource
        {
            get { return this._timecodeSource; }
            set { this._timecodeSource = value; }
        }

        // Check to see if TimecodeSource property is set
        internal bool IsSetTimecodeSource()
        {
            return this._timecodeSource != null;
        }

        /// <summary>
        /// Gets and sets the property TimecodeStart. Specify the starting timecode for this video
        /// overlay. To use this setting, you must set Timecode source to Specified start.
        /// </summary>
        [AWSProperty(Min=11, Max=11)]
        public string TimecodeStart
        {
            get { return this._timecodeStart; }
            set { this._timecodeStart = value; }
        }

        // Check to see if TimecodeStart property is set
        internal bool IsSetTimecodeStart()
        {
            return this._timecodeStart != null;
        }

    }
}