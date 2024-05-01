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
    /// Settings for quality-defined variable bitrate encoding with the H.265 codec. Use these
    /// settings only when you set QVBR for Rate control mode.
    /// </summary>
    public partial class H265QvbrSettings
    {
        private int? _maxAverageBitrate;
        private int? _qvbrQualityLevel;
        private double? _qvbrQualityLevelFineTune;

        /// <summary>
        /// Gets and sets the property MaxAverageBitrate. Use this setting only when Rate control
        /// mode is QVBR and Quality tuning level is Multi-pass HQ. For Max average bitrate values
        /// suited to the complexity of your input video, the service limits the average bitrate
        /// of the video part of this output to the value that you choose. That is, the total
        /// size of the video element is less than or equal to the value you set multiplied by
        /// the number of seconds of encoded output.
        /// </summary>
        [AWSProperty(Min=1000, Max=1466400000)]
        public int? MaxAverageBitrate
        {
            get { return this._maxAverageBitrate; }
            set { this._maxAverageBitrate = value; }
        }

        // Check to see if MaxAverageBitrate property is set
        internal bool IsSetMaxAverageBitrate()
        {
            return this._maxAverageBitrate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property QvbrQualityLevel. Use this setting only when you set Rate
        /// control mode to QVBR. Specify the target quality level for this output. MediaConvert
        /// determines the right number of bits to use for each part of the video to maintain
        /// the video quality that you specify. When you keep the default value, AUTO, MediaConvert
        /// picks a quality level for you, based on characteristics of your input video. If you
        /// prefer to specify a quality level, specify a number from 1 through 10. Use higher
        /// numbers for greater quality. Level 10 results in nearly lossless compression. The
        /// quality level for most broadcast-quality transcodes is between 6 and 9. Optionally,
        /// to specify a value between whole numbers, also provide a value for the setting qvbrQualityLevelFineTune.
        /// For example, if you want your QVBR quality level to be 7.33, set qvbrQualityLevel
        /// to 7 and set qvbrQualityLevelFineTune to .33.
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public int? QvbrQualityLevel
        {
            get { return this._qvbrQualityLevel; }
            set { this._qvbrQualityLevel = value; }
        }

        // Check to see if QvbrQualityLevel property is set
        internal bool IsSetQvbrQualityLevel()
        {
            return this._qvbrQualityLevel.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property QvbrQualityLevelFineTune. Optional. Specify a value here
        /// to set the QVBR quality to a level that is between whole numbers. For example, if
        /// you want your QVBR quality level to be 7.33, set qvbrQualityLevel to 7 and set qvbrQualityLevelFineTune
        /// to .33. MediaConvert rounds your QVBR quality level to the nearest third of a whole
        /// number. For example, if you set qvbrQualityLevel to 7 and you set qvbrQualityLevelFineTune
        /// to .25, your actual QVBR quality level is 7.33.
        /// </summary>
        public double? QvbrQualityLevelFineTune
        {
            get { return this._qvbrQualityLevelFineTune; }
            set { this._qvbrQualityLevelFineTune = value; }
        }

        // Check to see if QvbrQualityLevelFineTune property is set
        internal bool IsSetQvbrQualityLevelFineTune()
        {
            return this._qvbrQualityLevelFineTune.HasValue; 
        }

    }
}