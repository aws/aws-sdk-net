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
    /// Settings for quality-defined variable bitrate encoding with the H.265 codec. Required
    /// when you set Rate control mode to QVBR. Not valid when you set Rate control mode to
    /// a value other than QVBR, or when you don't define Rate control mode.
    /// </summary>
    public partial class H265QvbrSettings
    {
        private int? _maxAverageBitrate;
        private int? _qvbrQualityLevel;

        /// <summary>
        /// Gets and sets the property MaxAverageBitrate. Use this setting only when Rate control
        /// mode is QVBR and Quality tuning level is Multi-pass HQ. For Max average bitrate values
        /// suited to the complexity of your input video, the service limits the average bitrate
        /// of the video part of this output to the value you choose. That is, the total size
        /// of the video element is less than or equal to the value you set multiplied by the
        /// number of seconds of encoded output.
        /// </summary>
        public int MaxAverageBitrate
        {
            get { return this._maxAverageBitrate.GetValueOrDefault(); }
            set { this._maxAverageBitrate = value; }
        }

        // Check to see if MaxAverageBitrate property is set
        internal bool IsSetMaxAverageBitrate()
        {
            return this._maxAverageBitrate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property QvbrQualityLevel. Required when you use QVBR rate control
        /// mode. That is, when you specify qvbrSettings within h265Settings. Specify the target
        /// quality level for this output, from 1 to 10. Use higher numbers for greater quality.
        /// Level 10 results in nearly lossless compression. The quality level for most broadcast-quality
        /// transcodes is between 6 and 9.
        /// </summary>
        public int QvbrQualityLevel
        {
            get { return this._qvbrQualityLevel.GetValueOrDefault(); }
            set { this._qvbrQualityLevel = value; }
        }

        // Check to see if QvbrQualityLevel property is set
        internal bool IsSetQvbrQualityLevel()
        {
            return this._qvbrQualityLevel.HasValue; 
        }

    }
}