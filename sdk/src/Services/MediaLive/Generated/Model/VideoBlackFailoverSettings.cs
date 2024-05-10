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
    /// Placeholder documentation for VideoBlackFailoverSettings
    /// </summary>
    public partial class VideoBlackFailoverSettings
    {
        private double? _blackDetectThreshold;
        private int? _videoBlackThresholdMsec;

        /// <summary>
        /// Gets and sets the property BlackDetectThreshold. A value used in calculating the threshold
        /// below which MediaLive considers a pixel to be 'black'. For the input to be considered
        /// black, every pixel in a frame must be below this threshold. The threshold is calculated
        /// as a percentage (expressed as a decimal) of white. Therefore .1 means 10% white (or
        /// 90% black). Note how the formula works for any color depth. For example, if you set
        /// this field to 0.1 in 10-bit color depth: (1023*0.1=102.3), which means a pixel value
        /// of 102 or less is 'black'. If you set this field to .1 in an 8-bit color depth: (255*0.1=25.5),
        /// which means a pixel value of 25 or less is 'black'. The range is 0.0 to 1.0, with
        /// any number of decimal places.
        /// </summary>
        public double? BlackDetectThreshold
        {
            get { return this._blackDetectThreshold; }
            set { this._blackDetectThreshold = value; }
        }

        // Check to see if BlackDetectThreshold property is set
        internal bool IsSetBlackDetectThreshold()
        {
            return this._blackDetectThreshold.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property VideoBlackThresholdMsec. The amount of time (in milliseconds)
        /// that the active input must be black before automatic input failover occurs.
        /// </summary>
        [AWSProperty(Min=1000)]
        public int? VideoBlackThresholdMsec
        {
            get { return this._videoBlackThresholdMsec; }
            set { this._videoBlackThresholdMsec = value; }
        }

        // Check to see if VideoBlackThresholdMsec property is set
        internal bool IsSetVideoBlackThresholdMsec()
        {
            return this._videoBlackThresholdMsec.HasValue; 
        }

    }
}