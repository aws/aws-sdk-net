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
    /// Find additional transcoding features under Preprocessors (VideoPreprocessors). Enable
    /// the features at each output individually. These features are disabled by default.
    /// </summary>
    public partial class VideoPreprocessor
    {
        private ColorCorrector _colorCorrector;
        private Deinterlacer _deinterlacer;
        private ImageInserter _imageInserter;
        private NoiseReducer _noiseReducer;
        private TimecodeBurnin _timecodeBurnin;

        /// <summary>
        /// Gets and sets the property ColorCorrector. Enable the Color corrector (ColorCorrector)
        /// feature if necessary. Enable or disable this feature for each output individually.
        /// This setting is disabled by default.
        /// </summary>
        public ColorCorrector ColorCorrector
        {
            get { return this._colorCorrector; }
            set { this._colorCorrector = value; }
        }

        // Check to see if ColorCorrector property is set
        internal bool IsSetColorCorrector()
        {
            return this._colorCorrector != null;
        }

        /// <summary>
        /// Gets and sets the property Deinterlacer. Use Deinterlacer (Deinterlacer) to produce
        /// smoother motion and a clearer picture.
        /// </summary>
        public Deinterlacer Deinterlacer
        {
            get { return this._deinterlacer; }
            set { this._deinterlacer = value; }
        }

        // Check to see if Deinterlacer property is set
        internal bool IsSetDeinterlacer()
        {
            return this._deinterlacer != null;
        }

        /// <summary>
        /// Gets and sets the property ImageInserter. Enable the Image inserter (ImageInserter)
        /// feature to include a graphic overlay on your video. Enable or disable this feature
        /// for each output individually. This setting is disabled by default.
        /// </summary>
        public ImageInserter ImageInserter
        {
            get { return this._imageInserter; }
            set { this._imageInserter = value; }
        }

        // Check to see if ImageInserter property is set
        internal bool IsSetImageInserter()
        {
            return this._imageInserter != null;
        }

        /// <summary>
        /// Gets and sets the property NoiseReducer. Enable the Noise reducer (NoiseReducer) feature
        /// to remove noise from your video output if necessary. Enable or disable this feature
        /// for each output individually. This setting is disabled by default.
        /// </summary>
        public NoiseReducer NoiseReducer
        {
            get { return this._noiseReducer; }
            set { this._noiseReducer = value; }
        }

        // Check to see if NoiseReducer property is set
        internal bool IsSetNoiseReducer()
        {
            return this._noiseReducer != null;
        }

        /// <summary>
        /// Gets and sets the property TimecodeBurnin. Timecode burn-in (TimecodeBurnIn)--Burns
        /// the output timecode and specified prefix into the output.
        /// </summary>
        public TimecodeBurnin TimecodeBurnin
        {
            get { return this._timecodeBurnin; }
            set { this._timecodeBurnin = value; }
        }

        // Check to see if TimecodeBurnin property is set
        internal bool IsSetTimecodeBurnin()
        {
            return this._timecodeBurnin != null;
        }

    }
}