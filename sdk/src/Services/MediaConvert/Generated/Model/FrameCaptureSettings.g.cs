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

namespace Amazon.MediaConvert.Model
{
    /// <summary>
    /// Required when you set Codec to the value FRAME_CAPTURE.
    /// </summary>
    public partial class FrameCaptureSettings
    {
        /// <summary>
        /// Gets and sets the property FramerateDenominator. Frame capture will encode the first
        /// frame of the output stream, then one frame every framerateDenominator/framerateNumerator
        /// seconds. For example, settings of framerateNumerator = 1 and framerateDenominator
        /// = 3 (a rate of 1/3 frame per second) will capture the first frame, then 1 frame every
        /// 3s. Files will be named as filename.n.jpg where n is the 0-based sequence number of
        /// each Capture.
        /// </summary>
        [AWSProperty(Min = 1, Max = 2147483647)]
        public int? FramerateDenominator { get; set; }

        /// <summary>
        /// Checks to see if the FramerateDenominator property is set.
        /// </summary>
        internal bool IsSetFramerateDenominator() => this.FramerateDenominator.HasValue;

        /// <summary>
        /// Gets and sets the property FramerateNumerator. Frame capture will encode the first
        /// frame of the output stream, then one frame every framerateDenominator/framerateNumerator
        /// seconds. For example, settings of framerateNumerator = 1 and framerateDenominator
        /// = 3 (a rate of 1/3 frame per second) will capture the first frame, then 1 frame every
        /// 3s. Files will be named as filename.NNNNNNN.jpg where N is the 0-based frame sequence
        /// number zero padded to 7 decimal places.
        /// </summary>
        [AWSProperty(Min = 1, Max = 2147483647)]
        public int? FramerateNumerator { get; set; }

        /// <summary>
        /// Checks to see if the FramerateNumerator property is set.
        /// </summary>
        internal bool IsSetFramerateNumerator() => this.FramerateNumerator.HasValue;

        /// <summary>
        /// Gets and sets the property MaxCaptures. Maximum number of captures (encoded jpg output
        /// files).
        /// </summary>
        [AWSProperty(Min = 1, Max = 10000000)]
        public int? MaxCaptures { get; set; }

        /// <summary>
        /// Checks to see if the MaxCaptures property is set.
        /// </summary>
        internal bool IsSetMaxCaptures() => this.MaxCaptures.HasValue;

        /// <summary>
        /// Gets and sets the property Quality. JPEG Quality - a higher value equals higher quality.
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public int? Quality { get; set; }

        /// <summary>
        /// Checks to see if the Quality property is set.
        /// </summary>
        internal bool IsSetQuality() => this.Quality.HasValue;
    }
}
